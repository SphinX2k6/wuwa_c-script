using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BF5 RID: 7157
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsBulletScreenPanel : UiPanelBase
{
	// Token: 0x06011CA0 RID: 72864 RVA: 0x0053B138 File Offset: 0x00539338
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x06011CA1 RID: 72865 RVA: 0x0053B15C File Offset: 0x0053935C
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

	// Token: 0x06011CA2 RID: 72866 RVA: 0x0053B218 File Offset: 0x00539418
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

	// Token: 0x06011CA3 RID: 72867 RVA: 0x0053B270 File Offset: 0x00539470
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

	// Token: 0x06011CA4 RID: 72868 RVA: 0x0053B354 File Offset: 0x00539554
	private UniTask ShowBulletScreenAsync()
	{
		RacingBetsBulletScreenPanel.<ShowBulletScreenAsync>d__21 <ShowBulletScreenAsync>d__;
		<ShowBulletScreenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowBulletScreenAsync>d__.<>4__this = this;
		<ShowBulletScreenAsync>d__.<>1__state = -1;
		<ShowBulletScreenAsync>d__.<>t__builder.Start<RacingBetsBulletScreenPanel.<ShowBulletScreenAsync>d__21>(ref <ShowBulletScreenAsync>d__);
		return <ShowBulletScreenAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011CA5 RID: 72869 RVA: 0x0053B398 File Offset: 0x00539598
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

	// Token: 0x06011CA6 RID: 72870 RVA: 0x0053B424 File Offset: 0x00539624
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

	// Token: 0x06011CA7 RID: 72871 RVA: 0x0053B4DF File Offset: 0x005396DF
	protected override void OnBeforeDestroy()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.FlowTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06011CA8 RID: 72872 RVA: 0x0053B504 File Offset: 0x00539704
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

	// Token: 0x06011CA9 RID: 72873 RVA: 0x0053B564 File Offset: 0x00539764
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

	// Token: 0x06011CAA RID: 72874 RVA: 0x0053B5D8 File Offset: 0x005397D8
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

	// Token: 0x06011CAB RID: 72875 RVA: 0x0053B600 File Offset: 0x00539800
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

	// Token: 0x06011CAC RID: 72876 RVA: 0x0053B640 File Offset: 0x00539840
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

	// Token: 0x06011CAD RID: 72877 RVA: 0x0053B684 File Offset: 0x00539884
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

	// Token: 0x06011CAE RID: 72878 RVA: 0x0053B6BD File Offset: 0x005398BD
	[NullableContext(2)]
	private UUIItem CreateBulletActor()
	{
		if (this.TemplateGridActor == null)
		{
			return null;
		}
		return LguiUtil.Instance.CopyItem(this.TemplateGridActor.GetUIItem(), base.GetRootItem());
	}

	// Token: 0x06011CAF RID: 72879 RVA: 0x0053B6E4 File Offset: 0x005398E4
	public void SetBulletScreenShowType(ERacingBetsBulletScreenShowType showType)
	{
		if (showType == ERacingBetsBulletScreenShowType.Full)
		{
			this.BulletTrackCount = (int)Math.Floor((double)(this.ViewportHeight / this.BulletScreenItemHeight));
			return;
		}
		this.BulletTrackCount = (int)Math.Floor((double)(this.ViewportHeight / this.BulletScreenItemHeight / 2f));
	}

	// Token: 0x06011CB0 RID: 72880 RVA: 0x0053B730 File Offset: 0x00539930
	public void PushBulletScreen(IReadOnlyList<int> bulletScreenIdList, bool isSelf)
	{
		if (isSelf)
		{
			this.SelfBulletScreenIdList.AddRange(bulletScreenIdList);
			return;
		}
		this.BulletScreenIdList = new List<int>(bulletScreenIdList);
	}

	// Token: 0x04009B70 RID: 39792
	private float ViewportHeight;

	// Token: 0x04009B71 RID: 39793
	private float ViewportWidth;

	// Token: 0x04009B72 RID: 39794
	private readonly float BulletScreenItemHeight = 80f;

	// Token: 0x04009B73 RID: 39795
	private readonly float BulletScreenInternal = 200f;

	// Token: 0x04009B74 RID: 39796
	private readonly float BulletScreenSpeed = 0.2f;

	// Token: 0x04009B75 RID: 39797
	private readonly int MaxRandomTime = 5;

	// Token: 0x04009B76 RID: 39798
	private float BulletScreenCurInternal;

	// Token: 0x04009B77 RID: 39799
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04009B78 RID: 39800
	private readonly Dictionary<int, RacingBetsBulletScreenItem> BulletTrackMap = new Dictionary<int, RacingBetsBulletScreenItem>();

	// Token: 0x04009B79 RID: 39801
	private int BulletTrackCount;

	// Token: 0x04009B7A RID: 39802
	private readonly HashSet<RacingBetsBulletScreenItem> BulletScreenItemList = new HashSet<RacingBetsBulletScreenItem>();

	// Token: 0x04009B7B RID: 39803
	private readonly List<RacingBetsBulletScreenItem> BulletScreenItemPool = new List<RacingBetsBulletScreenItem>();

	// Token: 0x04009B7C RID: 39804
	private List<int> BulletScreenIdList = new List<int>();

	// Token: 0x04009B7D RID: 39805
	private readonly List<int> SelfBulletScreenIdList = new List<int>();

	// Token: 0x04009B7E RID: 39806
	private readonly List<RacingBetsBulletScreenItem> PendingRemoveList = new List<RacingBetsBulletScreenItem>();

	// Token: 0x04009B7F RID: 39807
	[Nullable(2)]
	private AUIBaseActor TemplateGridActor;

	// Token: 0x02007EDF RID: 32479
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040290F0 RID: 168176
		BulletContent
	}
}
