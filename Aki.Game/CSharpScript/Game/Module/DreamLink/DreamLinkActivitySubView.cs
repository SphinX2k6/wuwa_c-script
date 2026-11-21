using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A7F RID: 19071
	[NullableContext(2)]
	[Nullable(0)]
	public class DreamLinkActivitySubView : ActivitySubViewBase
	{
		// Token: 0x17005FE2 RID: 24546
		// (get) Token: 0x0602FB98 RID: 195480 RVA: 0x00D4F941 File Offset: 0x00D4DB41
		protected new DreamLinkData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as DreamLinkData;
			}
		}

		// Token: 0x0602FB99 RID: 195481 RVA: 0x00D4F950 File Offset: 0x00D4DB50
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602FB9A RID: 195482 RVA: 0x00D4FA1C File Offset: 0x00D4DC1C
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkActivitySubView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkActivitySubView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FB9B RID: 195483 RVA: 0x00D4FA60 File Offset: 0x00D4DC60
		protected override UniTask OnBeforeHideSelfAsync()
		{
			DreamLinkActivitySubView.<OnBeforeHideSelfAsync>d__8 <OnBeforeHideSelfAsync>d__;
			<OnBeforeHideSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideSelfAsync>d__.<>4__this = this;
			<OnBeforeHideSelfAsync>d__.<>1__state = -1;
			<OnBeforeHideSelfAsync>d__.<>t__builder.Start<DreamLinkActivitySubView.<OnBeforeHideSelfAsync>d__8>(ref <OnBeforeHideSelfAsync>d__);
			return <OnBeforeHideSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FB9C RID: 195484 RVA: 0x00D4FAA4 File Offset: 0x00D4DCA4
		protected override void OnRefreshView()
		{
			this.RefreshStage();
			this.RefreshButton();
			DreamLinkLimitTimeRewardItem limitTimeRewardItem = this.LimitTimeRewardItem;
			if (limitTimeRewardItem != null)
			{
				limitTimeRewardItem.RefreshActive();
			}
			DreamLinkScoreRewardItem rewardItem = this.RewardItem;
			if (rewardItem != null)
			{
				DreamLinkData activityBaseData = this.ActivityBaseData;
				rewardItem.SetActive(activityBaseData != null && activityBaseData.IsUnLock());
			}
			DreamLinkData activityBaseData2 = this.ActivityBaseData;
			if (activityBaseData2 != null && activityBaseData2.IsUnLock())
			{
				DreamLinkScoreRewardItem rewardItem2 = this.RewardItem;
				if (rewardItem2 == null)
				{
					return;
				}
				rewardItem2.RefreshPerformance();
			}
		}

		// Token: 0x0602FB9D RID: 195485 RVA: 0x00D4FB15 File Offset: 0x00D4DD15
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnRefreshSubPackageDownLoadByPriority, new Action(this.OnRefreshSubPackageDownLoadByPriority));
		}

		// Token: 0x0602FB9E RID: 195486 RVA: 0x00D4FB33 File Offset: 0x00D4DD33
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshSubPackageDownLoadByPriority, new Action(this.OnRefreshSubPackageDownLoadByPriority));
		}

		// Token: 0x0602FB9F RID: 195487 RVA: 0x00D4FB51 File Offset: 0x00D4DD51
		private void OnRefreshSubPackageDownLoadByPriority()
		{
			this.RefreshButton();
		}

		// Token: 0x0602FBA0 RID: 195488 RVA: 0x00D4FB59 File Offset: 0x00D4DD59
		[NullableContext(1)]
		private void OnBtnClick(ActivityBaseData data)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				ActivityController.Instance.OpenActivityContentView(this.ActivityBaseData);
			});
		}

		// Token: 0x0602FBA1 RID: 195489 RVA: 0x00D4FB78 File Offset: 0x00D4DD78
		private void RefreshStage()
		{
			DreamLinkData activityBaseData = this.ActivityBaseData;
			bool flag = activityBaseData != null && activityBaseData.GetInstStage() == EDreamLinkStage.First;
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!flag);
		}

		// Token: 0x0602FBA2 RID: 195490 RVA: 0x00D4FBC4 File Offset: 0x00D4DDC4
		private void RefreshButton()
		{
			DreamLinkData activityBaseData = this.ActivityBaseData;
			if (activityBaseData == null || !activityBaseData.IsDreamLinkFunctionUnlock(0))
			{
				ActivitySubViewGeneralInfo generalActivityInfo = this.GeneralActivityInfo;
				if (generalActivityInfo != null)
				{
					DreamLinkData activityBaseData2 = this.ActivityBaseData;
					generalActivityInfo.SetFunctionRedDotVisible(activityBaseData2 != null && activityBaseData2.GetQuestRedDotState());
				}
				ActivitySubViewGeneralInfo generalActivityInfo2 = this.GeneralActivityInfo;
				if (generalActivityInfo2 == null)
				{
					return;
				}
				generalActivityInfo2.SetBtnText("PrefabTextItem_2152138235_Text", Array.Empty<object>());
				return;
			}
			else
			{
				SubPackageDownLoadModel instance = SubPackageDownLoadModel.Instance;
				DreamLinkData activityBaseData3 = this.ActivityBaseData;
				bool flag = instance.CheckActivityTeleportHaveSubPackage((activityBaseData3 != null) ? activityBaseData3.Id : 0);
				if (!flag)
				{
					ActivitySubViewGeneralInfo generalActivityInfo3 = this.GeneralActivityInfo;
					object obj = (generalActivityInfo3 != null) ? generalActivityInfo3.GetFunctional() : null;
					DreamLinkData activityBaseData4 = this.ActivityBaseData;
					int[] array = (activityBaseData4 != null) ? ((activityBaseData4.LocalConfig != null) ? activityBaseData4.LocalConfig.GetValueOrDefault().GetDownLoadSubPackageListArray() : null) : null;
					object obj2 = obj;
					if (obj2 != null)
					{
						DreamLinkData activityBaseData5 = this.ActivityBaseData;
						obj2.SetPerformanceSubPackageLock((activityBaseData5 != null) ? ((activityBaseData5.LocalConfig != null) ? activityBaseData5.LocalConfig.GetValueOrDefault().AreaTips : null) : null, (array == null) ? null : new List<int>(array));
					}
					if (obj2 != null)
					{
						obj2.SetLockTextByTextId("SubPackageDownLoad_ActivityLock_Des", Array.Empty<string>());
					}
					if (obj2 != null)
					{
						obj2.SetPanelConditionVisible(!flag);
					}
					if (obj2 != null)
					{
						ActivityButtonItem functionButton = obj2.FunctionButton;
						if (functionButton != null)
						{
							functionButton.SetUiActive(flag);
						}
					}
					if (obj2 == null)
					{
						return;
					}
					FunctionalPanelConditionActivate panelActivate = obj2.PanelActivate;
					if (panelActivate == null)
					{
						return;
					}
					panelActivate.SetUiActive(flag);
					return;
				}
				else
				{
					ActivitySubViewGeneralInfo generalActivityInfo4 = this.GeneralActivityInfo;
					if (generalActivityInfo4 != null)
					{
						DreamLinkData activityBaseData6 = this.ActivityBaseData;
						generalActivityInfo4.SetFunctionRedDotVisible(activityBaseData6 != null && activityBaseData6.RedPointShowState);
					}
					ActivitySubViewGeneralInfo generalActivityInfo5 = this.GeneralActivityInfo;
					if (generalActivityInfo5 == null)
					{
						return;
					}
					generalActivityInfo5.SetBtnText("FragmentMemoryEnterText", Array.Empty<object>());
					return;
				}
			}
		}

		// Token: 0x04019561 RID: 103777
		public ActivitySubViewGeneralInfo GeneralActivityInfo;

		// Token: 0x04019562 RID: 103778
		private DreamLinkLimitTimeRewardItem LimitTimeRewardItem;

		// Token: 0x04019563 RID: 103779
		private DreamLinkScoreRewardItem RewardItem;

		// Token: 0x0200A6D7 RID: 42711
		[NullableContext(0)]
		private class EDreamLinkActivitySubViewDefine
		{
			// Token: 0x040338FE RID: 211198
			public const int CommonActivityInfo = 0;

			// Token: 0x040338FF RID: 211199
			public const int LimitTimeReward = 1;

			// Token: 0x04033900 RID: 211200
			public const int PermanentReward = 2;

			// Token: 0x04033901 RID: 211201
			public const int PanelStage1 = 3;

			// Token: 0x04033902 RID: 211202
			public const int PanelStage2 = 4;
		}
	}
}
