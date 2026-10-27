using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200270A RID: 9994
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsBulletScreenPanel : UiPanelBase
{
	// Token: 0x060147BE RID: 83902 RVA: 0x0052C41C File Offset: 0x0052A61C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x060147BF RID: 83903 RVA: 0x0052C440 File Offset: 0x0052A640
	protected override void OnStart()
	{
		this.TimerHandle = TimerSystem.FlowTimeInstance.Forever(new TTimerAction(this.OnTick), 20f, 1f, null, null, false);
		UUIItem rootItem = base.GetRootItem();
		object obj;
		if (rootItem == null)
		{
			obj = null;
		}
		else
		{
			UUIItem attachUIChild = rootItem.GetAttachUIChild(0);
			obj = ((attachUIChild != null) ? attachUIChild.GetOwner() : null);
		}
		this.TemplateGridActor = (obj as AUIBaseActor);
		if (this.TemplateGridActor == null)
		{
			return;
		}
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			this.ViewportHeight = item.GetHeight();
			this.ViewportWidth = item.GetWidth();
		}
		this.BulletTrackCount = (int)Math.Floor((double)(this.ViewportHeight / this.BulletScreenItemHeight));
		UUIItem uiitem = this.TemplateGridActor.GetUIItem();
		if (uiitem == null)
		{
			return;
		}
		uiitem.SetUIActive(false);
	}

	// Token: 0x060147C0 RID: 83904 RVA: 0x0052C4FC File Offset: 0x0052A6FC
	private void OnTick(float delta)
	{
		this.MoveBulletScreen(delta);
		this.BulletScreenCurInternal += delta;
		if (this.BulletScreenCurInternal < this.BulletScreenInternal)
		{
			return;
		}
		if (!this.CheckCanPushBulletScreen())
		{
			return;
		}
		this.BulletScreenCurInternal %= this.BulletScreenInternal;
		this.ShowBulletScreenAsync().Forget();
	}

	// Token: 0x060147C1 RID: 83905 RVA: 0x0052C554 File Offset: 0x0052A754
	private void MoveBulletScreen(float delta)
	{
		float num = delta * this.BulletScreenSpeed;
		foreach (RacingBetsBulletScreenItem racingBetsBulletScreenItem in this.BulletScreenItemList)
		{
			UUIItem rootItem = racingBetsBulletScreenItem.GetRootItem();
			float num2 = rootItem.GetAnchorOffsetX() - num;
			rootItem.SetAnchorOffsetX(num2);
			float num3 = -racingBetsBulletScreenItem.GetBulletScreenItemWidth();
			if (num2 < num3)
			{
				this.PendingRemoveList.Add(racingBetsBulletScreenItem);
			}
		}
		if (this.PendingRemoveList.Count > 0)
		{
			foreach (RacingBetsBulletScreenItem bulletScreenItem in this.PendingRemoveList)
			{
				this.RemoveBulletScreen(bulletScreenItem);
			}
			this.PendingRemoveList.Clear();
		}
	}

	// Token: 0x060147C2 RID: 83906 RVA: 0x0052C638 File Offset: 0x0052A838
	private UniTask ShowBulletScreenAsync()
	{
		RacingBetsBulletScreenPanel.<ShowBulletScreenAsync>d__21 <ShowBulletScreenAsync>d__;
		<ShowBulletScreenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowBulletScreenAsync>d__.<>4__this = this;
		<ShowBulletScreenAsync>d__.<>1__state = -1;
		<ShowBulletScreenAsync>d__.<>t__builder.Start<RacingBetsBulletScreenPanel.<ShowBulletScreenAsync>d__21>(ref <ShowBulletScreenAsync>d__);
		return <ShowBulletScreenAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060147C3 RID: 83907 RVA: 0x0052C67C File Offset: 0x0052A87C
	private void RemoveBulletScreen(RacingBetsBulletScreenItem bulletScreenItem)
	{
		this.BulletScreenItemList.Remove(bulletScreenItem);
		bulletScreenItem.GetRootItem().SetUIActive(false);
		this.BulletScreenItemPool.Add(bulletScreenItem);
		foreach (int key in bulletScreenItem.OccupiedTracks)
		{
			this.BulletTrackMap.Remove(key);
		}
		bulletScreenItem.OccupiedTracks.Clear();
	}

	// Token: 0x060147C4 RID: 83908 RVA: 0x0052C708 File Offset: 0x0052A908
	private void InitBulletScreenBornPosition(int bulletScreenId, RacingBetsBulletScreenItem bulletScreenItem)
	{
		int bulletScreenTrackCount = this.GetBulletScreenTrackCount(bulletScreenId);
		int randomTrack = this.GetRandomTrack(bulletScreenTrackCount);
		float num = this.BulletScreenItemHeight * (float)bulletScreenTrackCount - bulletScreenItem.GetBulletScreenItemHeight();
		float num2;
		if (num <= 0f)
		{
			num2 = 0f;
		}
		else
		{
			num2 = (float)(Random.Shared.NextDouble() * (double)num - (double)(num / 2f));
		}
		UUIItem rootItem = bulletScreenItem.GetRootItem();
		rootItem.SetAnchorOffsetX(this.ViewportWidth);
		rootItem.SetAnchorOffsetY((float)(-(float)randomTrack) * this.BulletScreenItemHeight - num2);
		bulletScreenItem.OccupiedTracks.Clear();
		for (int i = 0; i < bulletScreenTrackCount; i++)
		{
			int num3 = randomTrack + i;
			this.BulletTrackMap[num3] = bulletScreenItem;
			bulletScreenItem.OccupiedTracks.Add(num3);
		}
	}

	// Token: 0x060147C5 RID: 83909 RVA: 0x0052C7C3 File Offset: 0x0052A9C3
	protected override void OnBeforeDestroy()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.FlowTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x060147C6 RID: 83910 RVA: 0x0052C7E8 File Offset: 0x0052A9E8
	private int GetRandomTrack(int trackCount)
	{
		int i = 0;
		while (i < this.MaxRandomTime)
		{
			i++;
			int num = Random.Shared.Next(this.BulletTrackCount + 1 - trackCount);
			if (this.CheckMultiTrackCanPushBulletScreen(num, trackCount))
			{
				return num;
			}
		}
		for (int j = 0; j < this.BulletTrackCount; j++)
		{
			if (this.CheckMultiTrackCanPushBulletScreen(j, trackCount))
			{
				return j;
			}
		}
		return 0;
	}

	// Token: 0x060147C7 RID: 83911 RVA: 0x0052C848 File Offset: 0x0052AA48
	private bool CheckCanPushBulletScreen()
	{
		int bulletScreenId;
		if (this.SelfBulletScreenIdList.Count > 0)
		{
			bulletScreenId = this.SelfBulletScreenIdList[0];
		}
		else
		{
			if (this.BulletScreenIdList.Count <= 0)
			{
				return false;
			}
			bulletScreenId = this.BulletScreenIdList[0];
		}
		int bulletScreenTrackCount = this.GetBulletScreenTrackCount(bulletScreenId);
		for (int i = 0; i < this.BulletTrackCount; i++)
		{
			if (this.CheckMultiTrackCanPushBulletScreen(i, bulletScreenTrackCount))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060147C8 RID: 83912 RVA: 0x0052C8BC File Offset: 0x0052AABC
	private bool CheckMultiTrackCanPushBulletScreen(int track, int trackCount)
	{
		for (int i = 0; i < trackCount; i++)
		{
			if (!this.CheckTrackCanPushBulletScreen(track + i))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060147C9 RID: 83913 RVA: 0x0052C8E4 File Offset: 0x0052AAE4
	private bool CheckTrackCanPushBulletScreen(int track)
	{
		RacingBetsBulletScreenItem racingBetsBulletScreenItem;
		if (!this.BulletTrackMap.TryGetValue(track, out racingBetsBulletScreenItem))
		{
			return true;
		}
		UUIItem rootItem = racingBetsBulletScreenItem.GetRootItem();
		return rootItem == null || rootItem.GetAnchorOffsetX() + racingBetsBulletScreenItem.GetBulletScreenItemWidth() < this.ViewportWidth;
	}

	// Token: 0x060147CA RID: 83914 RVA: 0x0052C924 File Offset: 0x0052AB24
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<RacingBetsBulletScreenItem> GetBulletScreenItemAsync()
	{
		RacingBetsBulletScreenPanel.<GetBulletScreenItemAsync>d__29 <GetBulletScreenItemAsync>d__;
		<GetBulletScreenItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<RacingBetsBulletScreenItem>.Create();
		<GetBulletScreenItemAsync>d__.<>4__this = this;
		<GetBulletScreenItemAsync>d__.<>1__state = -1;
		<GetBulletScreenItemAsync>d__.<>t__builder.Start<RacingBetsBulletScreenPanel.<GetBulletScreenItemAsync>d__29>(ref <GetBulletScreenItemAsync>d__);
		return <GetBulletScreenItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060147CB RID: 83915 RVA: 0x0052C968 File Offset: 0x0052AB68
	private int GetBulletScreenTrackCount(int bulletScreenId)
	{
		RacingBetsBulletScreen? racingBetsBulletScreen = RacingBetsConfig.Instance.GetRacingBetsBulletScreen(bulletScreenId);
		if (racingBetsBulletScreen == null)
		{
			return 1;
		}
		if (racingBetsBulletScreen.Value.Type == 1)
		{
			return 2;
		}
		return 1;
	}

	// Token: 0x060147CC RID: 83916 RVA: 0x0052C9A1 File Offset: 0x0052ABA1
	[NullableContext(2)]
	private UUIItem CreateBulletActor()
	{
		if (this.TemplateGridActor == null)
		{
			return null;
		}
		return LguiUtil.Instance.CopyItem(this.TemplateGridActor.GetUIItem(), base.GetRootItem());
	}

	// Token: 0x060147CD RID: 83917 RVA: 0x0052C9C8 File Offset: 0x0052ABC8
	public void SetBulletScreenShowType(ERacingBetsBulletScreenShowType showType)
	{
		if (showType == ERacingBetsBulletScreenShowType.Full)
		{
			this.BulletTrackCount = (int)Math.Floor((double)(this.ViewportHeight / this.BulletScreenItemHeight));
			return;
		}
		this.BulletTrackCount = (int)Math.Floor((double)(this.ViewportHeight / this.BulletScreenItemHeight / 2f));
	}

	// Token: 0x060147CE RID: 83918 RVA: 0x0052CA14 File Offset: 0x0052AC14
	public void PushBulletScreen(IReadOnlyList<int> bulletScreenIdList, bool isSelf)
	{
		if (isSelf)
		{
			this.SelfBulletScreenIdList.AddRange(bulletScreenIdList);
			return;
		}
		this.BulletScreenIdList = new List<int>(bulletScreenIdList);
	}

	// Token: 0x04009A18 RID: 39448
	private float ViewportHeight;

	// Token: 0x04009A19 RID: 39449
	private float ViewportWidth;

	// Token: 0x04009A1A RID: 39450
	private readonly float BulletScreenItemHeight = 80f;

	// Token: 0x04009A1B RID: 39451
	private readonly float BulletScreenInternal = 200f;

	// Token: 0x04009A1C RID: 39452
	private readonly float BulletScreenSpeed = 0.2f;

	// Token: 0x04009A1D RID: 39453
	private readonly int MaxRandomTime = 5;

	// Token: 0x04009A1E RID: 39454
	private float BulletScreenCurInternal;

	// Token: 0x04009A1F RID: 39455
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04009A20 RID: 39456
	private readonly Dictionary<int, RacingBetsBulletScreenItem> BulletTrackMap = new Dictionary<int, RacingBetsBulletScreenItem>();

	// Token: 0x04009A21 RID: 39457
	private int BulletTrackCount;

	// Token: 0x04009A22 RID: 39458
	private readonly HashSet<RacingBetsBulletScreenItem> BulletScreenItemList = new HashSet<RacingBetsBulletScreenItem>();

	// Token: 0x04009A23 RID: 39459
	private readonly List<RacingBetsBulletScreenItem> BulletScreenItemPool = new List<RacingBetsBulletScreenItem>();

	// Token: 0x04009A24 RID: 39460
	private List<int> BulletScreenIdList = new List<int>();

	// Token: 0x04009A25 RID: 39461
	private readonly List<int> SelfBulletScreenIdList = new List<int>();

	// Token: 0x04009A26 RID: 39462
	private readonly List<RacingBetsBulletScreenItem> PendingRemoveList = new List<RacingBetsBulletScreenItem>();

	// Token: 0x04009A27 RID: 39463
	[Nullable(2)]
	private AUIBaseActor TemplateGridActor;

	// Token: 0x02008D56 RID: 36182
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402DDD9 RID: 187865
		BulletContent
	}
}
