using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D12 RID: 7442
[NullableContext(1)]
[Nullable(0)]
public class RoleTowerWaveView : UiViewBase
{
	// Token: 0x060126C4 RID: 75460 RVA: 0x00571B2F File Offset: 0x0056FD2F
	public RoleTowerWaveView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060126C5 RID: 75461 RVA: 0x00571B64 File Offset: 0x0056FD64
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x060126C6 RID: 75462 RVA: 0x00571BBE File Offset: 0x0056FDBE
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x060126C7 RID: 75463 RVA: 0x00571BD2 File Offset: 0x0056FDD2
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RoleTowerBattleWaveUpdate, new Action(this.OnWaveUpdate));
	}

	// Token: 0x060126C8 RID: 75464 RVA: 0x00571BF0 File Offset: 0x0056FDF0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RoleTowerBattleWaveUpdate, new Action(this.OnWaveUpdate));
	}

	// Token: 0x060126C9 RID: 75465 RVA: 0x00571C0E File Offset: 0x0056FE0E
	protected override void OnBeforeShow()
	{
		this.OnWaveUpdate();
	}

	// Token: 0x060126CA RID: 75466 RVA: 0x00571C18 File Offset: 0x0056FE18
	protected override void OnBeforeDestroy()
	{
		this.IsViewDestroyed = true;
		foreach (TimerHandle handle in this.RemoveTimers.Values)
		{
			TimerSystem.RealTimeInstance.Remove(handle);
		}
		this.RemoveTimers.Clear();
		this.WaveItems.Clear();
		this.DisplayOrder.Clear();
		this.NewestItem = null;
	}

	// Token: 0x060126CB RID: 75467 RVA: 0x00571CA4 File Offset: 0x0056FEA4
	private void OnWaveUpdate()
	{
		IReadOnlyList<RoleTowerWaveRecordData> battleWaveRecords = RoleTowerModel.Instance.GetBattleWaveRecords();
		for (int i = battleWaveRecords.Count - 1; i >= 0; i--)
		{
			RoleTowerWaveRecordData record = battleWaveRecords[i];
			if (!this.ShownRecords.Add(record))
			{
				RoleTowerWaveTipsItem roleTowerWaveTipsItem;
				if (this.WaveItems.TryGetValue(record, out roleTowerWaveTipsItem) && roleTowerWaveTipsItem.IsBound)
				{
					roleTowerWaveTipsItem.Refresh(record, false, 0);
				}
			}
			else
			{
				this.DisplayOrder.Insert(0, record);
				this.AddWaveItem(record).Forget();
				this.TrimOverflow();
				TimerHandle timerHandle = TimerSystem.RealTimeInstance.Delay(delegate(float _)
				{
					this.OnWaveItemExpire(record);
				}, 5000f, null, null, true, 1f);
				if (timerHandle != null)
				{
					this.RemoveTimers[record] = timerHandle;
				}
			}
		}
	}

	// Token: 0x060126CC RID: 75468 RVA: 0x00571D94 File Offset: 0x0056FF94
	private UniTask AddWaveItem(RoleTowerWaveRecordData record)
	{
		RoleTowerWaveView.<AddWaveItem>d__17 <AddWaveItem>d__;
		<AddWaveItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AddWaveItem>d__.<>4__this = this;
		<AddWaveItem>d__.record = record;
		<AddWaveItem>d__.<>1__state = -1;
		<AddWaveItem>d__.<>t__builder.Start<RoleTowerWaveView.<AddWaveItem>d__17>(ref <AddWaveItem>d__);
		return <AddWaveItem>d__.<>t__builder.Task;
	}

	// Token: 0x060126CD RID: 75469 RVA: 0x00571DDF File Offset: 0x0056FFDF
	private void OnWaveItemExpire(RoleTowerWaveRecordData record)
	{
		this.RemoveWaveItem(record);
	}

	// Token: 0x060126CE RID: 75470 RVA: 0x00571DE8 File Offset: 0x0056FFE8
	private void TrimOverflow()
	{
		while (this.DisplayOrder.Count > 2)
		{
			this.RemoveWaveItem(this.DisplayOrder[this.DisplayOrder.Count - 1]);
		}
	}

	// Token: 0x060126CF RID: 75471 RVA: 0x00571E18 File Offset: 0x00570018
	private void RemoveWaveItem(RoleTowerWaveRecordData record)
	{
		this.DisplayOrder.Remove(record);
		TimerHandle timerHandle;
		if (this.RemoveTimers.Remove(record, out timerHandle) && timerHandle != null)
		{
			TimerSystem.RealTimeInstance.Remove(timerHandle);
		}
		RoleTowerWaveTipsItem item;
		if (!this.WaveItems.Remove(record, out item))
		{
			return;
		}
		if (this.NewestItem == item)
		{
			this.NewestItem = null;
		}
		if (!item.IsBound)
		{
			return;
		}
		item.PlayClose(delegate
		{
			item.Destroy(null);
		});
	}

	// Token: 0x0400A074 RID: 41076
	private const float WaveItemShowMs = 5000f;

	// Token: 0x0400A075 RID: 41077
	private const int MaxWaveItemCount = 2;

	// Token: 0x0400A076 RID: 41078
	private readonly HashSet<RoleTowerWaveRecordData> ShownRecords = new HashSet<RoleTowerWaveRecordData>();

	// Token: 0x0400A077 RID: 41079
	private readonly Dictionary<RoleTowerWaveRecordData, RoleTowerWaveTipsItem> WaveItems = new Dictionary<RoleTowerWaveRecordData, RoleTowerWaveTipsItem>();

	// Token: 0x0400A078 RID: 41080
	[Nullable(2)]
	private RoleTowerWaveTipsItem NewestItem;

	// Token: 0x0400A079 RID: 41081
	private readonly List<RoleTowerWaveRecordData> DisplayOrder = new List<RoleTowerWaveRecordData>();

	// Token: 0x0400A07A RID: 41082
	private readonly Dictionary<RoleTowerWaveRecordData, TimerHandle> RemoveTimers = new Dictionary<RoleTowerWaveRecordData, TimerHandle>();

	// Token: 0x0400A07B RID: 41083
	private bool IsViewDestroyed;

	// Token: 0x0200804D RID: 32845
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402983E RID: 170046
		public const int PnlMission = 0;

		// Token: 0x0402983F RID: 170047
		public const int PnlWaveHor = 1;

		// Token: 0x04029840 RID: 170048
		public const int PnlWaveItem = 2;
	}
}
