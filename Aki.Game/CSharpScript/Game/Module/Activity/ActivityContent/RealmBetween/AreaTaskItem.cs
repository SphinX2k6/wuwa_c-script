using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006294 RID: 25236
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AreaTaskItem : SyncGridProxyAbstract<IAreaTaskItemData>
	{
		// Token: 0x0603F7E8 RID: 260072 RVA: 0x00F59D6F File Offset: 0x00F57F6F
		public AreaTaskItem(ActivityRealmBetweenData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0603F7E9 RID: 260073 RVA: 0x00F59D80 File Offset: 0x00F57F80
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
		}

		// Token: 0x0603F7EA RID: 260074 RVA: 0x00F59E48 File Offset: 0x00F58048
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(2), new Func<ActivitySmallItemGrid>(this.InitRewardItem), null, false, null);
			this.InitGotoBtnProxy();
			this.InitRewardBtnProxy();
		}

		// Token: 0x0603F7EB RID: 260075 RVA: 0x00F59E78 File Offset: 0x00F58078
		public override void Refresh(IAreaTaskItemData data)
		{
			this.CurrentAreaId = data.AreaData.AreaId;
			if (data.UnlockJumpId != null)
			{
				this.RefreshAsLockGuide(data.UnlockJumpId.Value, data.UnlockHintText ?? "");
				return;
			}
			this.TaskData = data.TaskData;
			RealmBetweenTask value = ActivityRealmBetweenConfig.Instance.GetRealmBetweenTaskConfig(this.TaskData.Id).Value;
			bool flag = this.TaskData.Status == EActivityTaskState.FinishedAndClaimed;
			bool value2 = value.JumpId > 0 && this.TaskData.Status == EActivityTaskState.Active;
			bool flag2 = this.TaskData.Status == EActivityTaskState.FinishedAndUnclaimed;
			base.GetText(0).SetUIActive(true);
			base.GetText(1).SetUIActive(true);
			base.GetScrollViewWithScrollbar(2).RootUIComp.Get().SetUIActive(true);
			base.GetItem(7).SetUIActive(flag);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), value.Name, Array.Empty<object>());
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(Math.Min(this.TaskData.Current, this.TaskData.Target));
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.TaskData.Target);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			this.RefreshRewardData(value.TaskReward);
			AreaTaskBtnProxy gotoBtnProxy = this.GotoBtnProxy;
			if (gotoBtnProxy != null)
			{
				gotoBtnProxy.SetClickFunction(new Action(this.OnGotoBtnClick));
			}
			AreaTaskBtnProxy gotoBtnProxy2 = this.GotoBtnProxy;
			if (gotoBtnProxy2 != null)
			{
				gotoBtnProxy2.SetTextById("RealmBetweenEnterName_Text", Array.Empty<object>());
			}
			base.SetButtonUiActive(6, value2);
			base.SetButtonUiActive(5, flag2);
			base.GetItem(4).SetUIActive(value.JumpId == 0 && !flag && !flag2);
		}

		// Token: 0x0603F7EC RID: 260076 RVA: 0x00F5A05C File Offset: 0x00F5825C
		private void RefreshAsLockGuide(int jumpId, string hintText)
		{
			base.GetText(0).SetUIActive(true);
			base.GetText(1).SetUIActive(false);
			base.GetScrollViewWithScrollbar(2).RootUIComp.Get().SetUIActive(false);
			base.GetItem(4).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			base.SetButtonUiActive(5, false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), hintText, Array.Empty<object>());
			AreaTaskBtnProxy gotoBtnProxy = this.GotoBtnProxy;
			if (gotoBtnProxy != null)
			{
				gotoBtnProxy.SetClickFunction(delegate
				{
					if (jumpId > 0)
					{
						SkipTaskManager.RunByConfigId(jumpId, null);
					}
				});
			}
			AreaTaskBtnProxy gotoBtnProxy2 = this.GotoBtnProxy;
			if (gotoBtnProxy2 != null)
			{
				gotoBtnProxy2.SetTextById("RealmBetweenEnterName_Text", Array.Empty<object>());
			}
			base.SetButtonUiActive(6, jumpId > 0);
		}

		// Token: 0x0603F7ED RID: 260077 RVA: 0x00F5A12B File Offset: 0x00F5832B
		[NullableContext(2)]
		public UUIItem GetFirstUiItem()
		{
			return this.RootItem;
		}

		// Token: 0x0603F7EE RID: 260078 RVA: 0x00F5A133 File Offset: 0x00F58333
		private ActivitySmallItemGrid InitRewardItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x0603F7EF RID: 260079 RVA: 0x00F5A13C File Offset: 0x00F5833C
		private void InitGotoBtnProxy()
		{
			AActor owner = base.GetButton(6).GetOwner();
			if (this.GotoBtnProxy == null)
			{
				this.GotoBtnProxy = new AreaTaskBtnProxy();
				this.GotoBtnProxy.CreateThenShowByActor(owner, null);
			}
			this.GotoBtnProxy.SetClickFunction(new Action(this.OnGotoBtnClick));
			this.GotoBtnProxy.SetTextById("RealmBetweenEnterName_Text", Array.Empty<object>());
		}

		// Token: 0x0603F7F0 RID: 260080 RVA: 0x00F5A1A4 File Offset: 0x00F583A4
		private void InitRewardBtnProxy()
		{
			AActor owner = base.GetButton(5).GetOwner();
			if (this.RewardBtnProxy == null)
			{
				this.RewardBtnProxy = new AreaTaskBtnProxy();
				this.RewardBtnProxy.CreateThenShowByActor(owner, null);
			}
			this.RewardBtnProxy.SetClickFunction(new Action(this.OnRewardBtnClick));
			this.RewardBtnProxy.SetTextById("RealmBetweenGetReward_Text", Array.Empty<object>());
		}

		// Token: 0x0603F7F1 RID: 260081 RVA: 0x00F5A20C File Offset: 0x00F5840C
		private void RefreshRewardData(int rewardId)
		{
			List<IItemGridData> list = new List<IItemGridData>();
			foreach (TItem item in CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(rewardId))
			{
				ItemGridData item2 = new ItemGridData
				{
					Item = item,
					HasClaimed = (this.TaskData.Status == EActivityTaskState.FinishedAndClaimed)
				};
				list.Add(item2);
			}
			this.RewardScrollView.RefreshByData(list, null, false);
		}

		// Token: 0x0603F7F2 RID: 260082 RVA: 0x00F5A29C File Offset: 0x00F5849C
		private void OnGotoBtnClick()
		{
			RealmBetweenTask value = ActivityRealmBetweenConfig.Instance.GetRealmBetweenTaskConfig(this.TaskData.Id).Value;
			if (value.JumpId != 0)
			{
				SkipTaskManager.RunByConfigId(value.JumpId, null);
			}
		}

		// Token: 0x0603F7F3 RID: 260083 RVA: 0x00F5A2E0 File Offset: 0x00F584E0
		private void OnRewardBtnClick()
		{
			if (this.CurrentAreaId <= 0)
			{
				return;
			}
			List<ActivityTaskData> areaTaskDataList = this.ActivityBaseData.GetAreaTaskDataList(this.CurrentAreaId);
			List<int> list = new List<int>();
			foreach (ActivityTaskData activityTaskData in areaTaskDataList)
			{
				if (activityTaskData.Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					list.Add(activityTaskData.Id);
				}
			}
			if (list.Count > 0)
			{
				ActivityRealmBetweenController.Instance.RequestMultiRealmBetweenTaskReward(list.ToArray());
			}
		}

		// Token: 0x0603F7F4 RID: 260084 RVA: 0x00F5A374 File Offset: 0x00F58574
		protected override void OnBeforeDestroy()
		{
			this.RewardScrollView = null;
		}

		// Token: 0x0402130B RID: 135947
		private int CurrentAreaId;

		// Token: 0x0402130C RID: 135948
		private ActivityTaskData TaskData;

		// Token: 0x0402130D RID: 135949
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

		// Token: 0x0402130E RID: 135950
		protected ActivityRealmBetweenData ActivityBaseData;

		// Token: 0x0402130F RID: 135951
		[Nullable(2)]
		private AreaTaskBtnProxy GotoBtnProxy;

		// Token: 0x04021310 RID: 135952
		[Nullable(2)]
		private AreaTaskBtnProxy RewardBtnProxy;
	}
}
