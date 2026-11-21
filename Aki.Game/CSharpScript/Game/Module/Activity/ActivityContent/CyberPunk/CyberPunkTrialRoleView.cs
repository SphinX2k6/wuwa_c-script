using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x0200580F RID: 22543
	[NullableContext(2)]
	[Nullable(0)]
	public class CyberPunkTrialRoleView : UiViewBase
	{
		// Token: 0x06037A09 RID: 227849 RVA: 0x00F8CB94 File Offset: 0x00F8AD94
		[NullableContext(1)]
		public CyberPunkTrialRoleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06037A0A RID: 227850 RVA: 0x00F8CBA0 File Offset: 0x00F8ADA0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(USpineSkeletonAnimationComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06037A0B RID: 227851 RVA: 0x00F8CC90 File Offset: 0x00F8AE90
		protected override UniTask OnBeforeStartAsync()
		{
			CyberPunkTrialRoleView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CyberPunkTrialRoleView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037A0C RID: 227852 RVA: 0x00F8CCD4 File Offset: 0x00F8AED4
		protected override void OnStart()
		{
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickClose));
			this.CaptionItem.SetHelpCallBack(new Action(this.OnClickHelp));
			this.CaptionItem.SetHomeBtnShowState(true);
			this.InitData();
			this.RefreshView();
			this.PlaySpineIdle();
		}

		// Token: 0x06037A0D RID: 227853 RVA: 0x00F8CD2D File Offset: 0x00F8AF2D
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnTrialStateChange));
		}

		// Token: 0x06037A0E RID: 227854 RVA: 0x00F8CD67 File Offset: 0x00F8AF67
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnTrialStateChange));
		}

		// Token: 0x06037A0F RID: 227855 RVA: 0x00F8CDA1 File Offset: 0x00F8AFA1
		protected override void OnBeforeDestroy()
		{
			this.SetTrialRoleState(ERoleTrialFlowState.ActivityOff);
		}

		// Token: 0x06037A10 RID: 227856 RVA: 0x00F8CDAC File Offset: 0x00F8AFAC
		private void SetTrialRoleState(ERoleTrialFlowState state)
		{
			CyberPunkConfig instance = CyberPunkConfig.Instance;
			IReadOnlyList<EdgeRunnerTrial> readOnlyList = (instance != null) ? instance.GetTrialRoleListByCyberPunkActivityId(this.ActivityId) : null;
			if (readOnlyList == null)
			{
				return;
			}
			foreach (EdgeRunnerTrial edgeRunnerTrial in readOnlyList)
			{
				ActivityRoleTrialData activityRoleTrialData = ActivityModel.Instance.GetActivityById(edgeRunnerTrial.ActivityId) as ActivityRoleTrialData;
				if (activityRoleTrialData != null && (state != ERoleTrialFlowState.ActivityOff || !activityRoleTrialData.IsRoleInstanceOn()))
				{
					activityRoleTrialData.SetRoleTrialState(state);
				}
			}
		}

		// Token: 0x06037A11 RID: 227857 RVA: 0x00F8CE38 File Offset: 0x00F8B038
		private void InitData()
		{
			List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.EdgeRunnerActivity);
			if (currentActivitiesByType != null && currentActivitiesByType.Count > 0)
			{
				this.ActivityData = (currentActivitiesByType[0] as CyberPunkData);
				this.ActivityId = this.ActivityData.Id;
			}
			if (this.ActivityData == null)
			{
				return;
			}
			IReadOnlyList<EdgeRunnerTrial> trialRoleListByCyberPunkActivityId = CyberPunkConfig.Instance.GetTrialRoleListByCyberPunkActivityId(this.ActivityId);
			if (trialRoleListByCyberPunkActivityId == null || trialRoleListByCyberPunkActivityId.Count == 0)
			{
				return;
			}
			if (trialRoleListByCyberPunkActivityId.Count > 0)
			{
				CyberPunkTrialRolePanel rolePanel = this.RolePanel1;
				if (rolePanel != null)
				{
					rolePanel.SetData(trialRoleListByCyberPunkActivityId[0].Id, trialRoleListByCyberPunkActivityId[0].ActivityId, this.ActivityId);
				}
			}
			if (trialRoleListByCyberPunkActivityId.Count > 1)
			{
				CyberPunkTrialRolePanel rolePanel2 = this.RolePanel2;
				if (rolePanel2 == null)
				{
					return;
				}
				rolePanel2.SetData(trialRoleListByCyberPunkActivityId[1].Id, trialRoleListByCyberPunkActivityId[1].ActivityId, this.ActivityId);
			}
		}

		// Token: 0x06037A12 RID: 227858 RVA: 0x00F8CF22 File Offset: 0x00F8B122
		private void RefreshView()
		{
			this.SetTrialRoleState(ERoleTrialFlowState.ActivityOn);
			this.RefreshRemainTime();
			CyberPunkTrialRolePanel rolePanel = this.RolePanel1;
			if (rolePanel != null)
			{
				rolePanel.RefreshPanel();
			}
			CyberPunkTrialRolePanel rolePanel2 = this.RolePanel2;
			if (rolePanel2 == null)
			{
				return;
			}
			rolePanel2.RefreshPanel();
		}

		// Token: 0x06037A13 RID: 227859 RVA: 0x00F8CF54 File Offset: 0x00F8B154
		private void RefreshRemainTime()
		{
			if (this.ActivityData == null)
			{
				return;
			}
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.ActivityData, null);
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetUIActive(item);
				if (item)
				{
					text.SetText(item2, true);
				}
			}
		}

		// Token: 0x06037A14 RID: 227860 RVA: 0x00F8CFA8 File Offset: 0x00F8B1A8
		private void PlaySpineIdle()
		{
			USpineSkeletonAnimationComponent spine = base.GetSpine(4);
			if (spine != null && spine.IsValid())
			{
				spine.SetAnimation(0, "idle", true);
			}
			USpineSkeletonAnimationComponent spine2 = base.GetSpine(5);
			if (spine2 != null && spine2.IsValid())
			{
				spine2.SetAnimation(0, "idle", true);
			}
		}

		// Token: 0x06037A15 RID: 227861 RVA: 0x00F8CFF7 File Offset: 0x00F8B1F7
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06037A16 RID: 227862 RVA: 0x00F8D000 File Offset: 0x00F8B200
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(0);
		}

		// Token: 0x06037A17 RID: 227863 RVA: 0x00F8D00D File Offset: 0x00F8B20D
		[NullableContext(1)]
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			if (CyberPunkController.Instance.CurrentActivityId == this.ActivityId)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x06037A18 RID: 227864 RVA: 0x00F8D028 File Offset: 0x00F8B228
		private void OnTrialStateChange(int activityId)
		{
			if (activityId != this.ActivityId)
			{
				return;
			}
			CyberPunkTrialRolePanel rolePanel = this.RolePanel1;
			if (rolePanel != null)
			{
				rolePanel.RefreshPanel();
			}
			CyberPunkTrialRolePanel rolePanel2 = this.RolePanel2;
			if (rolePanel2 == null)
			{
				return;
			}
			rolePanel2.RefreshPanel();
		}

		// Token: 0x06037A19 RID: 227865 RVA: 0x00F8D058 File Offset: 0x00F8B258
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "BackToBattleViewBtn"))
			{
				return null;
			}
			UActorComponent componentInChildren = ULGUIBPLibrary.GetComponentInChildren(base.GetRootActor(), TsUiHomeHelper.StaticClass(), false);
			AActor aactor = (componentInChildren != null) ? componentInChildren.GetOwner() : null;
			if (aactor == null)
			{
				return null;
			}
			UUIButtonComponent uuibuttonComponent = ULGUIBPLibrary.GetComponentInChildren(aactor, UUIButtonComponent.StaticClass(), false) as UUIButtonComponent;
			UUIItem uuiitem = (uuibuttonComponent != null) ? uuibuttonComponent.GetRootComponent() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x0401D560 RID: 120160
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D561 RID: 120161
		private CyberPunkTrialRolePanel RolePanel1;

		// Token: 0x0401D562 RID: 120162
		private CyberPunkTrialRolePanel RolePanel2;

		// Token: 0x0401D563 RID: 120163
		private CyberPunkData ActivityData;

		// Token: 0x0401D564 RID: 120164
		private int ActivityId;

		// Token: 0x0200B45E RID: 46174
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04037C93 RID: 228499
			public const int Caption = 0;

			// Token: 0x04037C94 RID: 228500
			public const int PnlRole1 = 1;

			// Token: 0x04037C95 RID: 228501
			public const int PnlRole2 = 2;

			// Token: 0x04037C96 RID: 228502
			public const int RemainTimeText = 3;

			// Token: 0x04037C97 RID: 228503
			public const int Spine1 = 4;

			// Token: 0x04037C98 RID: 228504
			public const int Spine2 = 5;
		}
	}
}
