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
	// Token: 0x02005212 RID: 21010
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AreaTaskItem : SyncGridProxyAbstract<IAreaTaskItemData>
	{
		// Token: 0x060344A9 RID: 214185 RVA: 0x00EA0CCB File Offset: 0x00E9EECB
		public AreaTaskItem(ActivityRealmBetweenData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x060344AA RID: 214186 RVA: 0x00EA0CDC File Offset: 0x00E9EEDC
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

		// Token: 0x060344AB RID: 214187 RVA: 0x00EA0DA4 File Offset: 0x00E9EFA4
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(2), new Func<ActivitySmallItemGrid>(this.InitRewardItem), null, false, null);
			this.InitGotoBtnProxy();
			this.InitRewardBtnProxy();
		}

		// Token: 0x060344AC RID: 214188 RVA: 0x00EA0DD4 File Offset: 0x00E9EFD4
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

		// Token: 0x060344AD RID: 214189 RVA: 0x00EA0FB8 File Offset: 0x00E9F1B8
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

		// Token: 0x060344AE RID: 214190 RVA: 0x00EA1087 File Offset: 0x00E9F287
		[NullableContext(2)]
		public UUIItem GetFirstUiItem()
		{
			return this.RootItem;
		}

		// Token: 0x060344AF RID: 214191 RVA: 0x00EA108F File Offset: 0x00E9F28F
		private ActivitySmallItemGrid InitRewardItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x060344B0 RID: 214192 RVA: 0x00EA1098 File Offset: 0x00E9F298
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

		// Token: 0x060344B1 RID: 214193 RVA: 0x00EA1100 File Offset: 0x00E9F300
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

		// Token: 0x060344B2 RID: 214194 RVA: 0x00EA1168 File Offset: 0x00E9F368
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

		// Token: 0x060344B3 RID: 214195 RVA: 0x00EA11F8 File Offset: 0x00E9F3F8
		private void OnGotoBtnClick()
		{
			RealmBetweenTask value = ActivityRealmBetweenConfig.Instance.GetRealmBetweenTaskConfig(this.TaskData.Id).Value;
			if (value.JumpId != 0)
			{
				SkipTaskManager.RunByConfigId(value.JumpId, null);
			}
		}

		// Token: 0x060344B4 RID: 214196 RVA: 0x00EA123C File Offset: 0x00E9F43C
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

		// Token: 0x060344B5 RID: 214197 RVA: 0x00EA12D0 File Offset: 0x00E9F4D0
		protected override void OnBeforeDestroy()
		{
			this.RewardScrollView = null;
		}

		// Token: 0x0401BC3A RID: 113722
		private int CurrentAreaId;

		// Token: 0x0401BC3B RID: 113723
		private ActivityTaskData TaskData;

		// Token: 0x0401BC3C RID: 113724
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

		// Token: 0x0401BC3D RID: 113725
		protected ActivityRealmBetweenData ActivityBaseData;

		// Token: 0x0401BC3E RID: 113726
		[Nullable(2)]
		private AreaTaskBtnProxy GotoBtnProxy;

		// Token: 0x0401BC3F RID: 113727
		[Nullable(2)]
		private AreaTaskBtnProxy RewardBtnProxy;
	}
}
