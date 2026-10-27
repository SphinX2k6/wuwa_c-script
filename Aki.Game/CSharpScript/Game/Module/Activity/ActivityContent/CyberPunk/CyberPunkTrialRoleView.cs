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
	// Token: 0x020068BF RID: 26815
	[NullableContext(2)]
	[Nullable(0)]
	public class CyberPunkTrialRoleView : UiViewBase
	{
		// Token: 0x06042EB1 RID: 274097 RVA: 0x0104B56C File Offset: 0x0104976C
		[NullableContext(1)]
		public CyberPunkTrialRoleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042EB2 RID: 274098 RVA: 0x0104B578 File Offset: 0x01049778
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

		// Token: 0x06042EB3 RID: 274099 RVA: 0x0104B668 File Offset: 0x01049868
		protected override UniTask OnBeforeStartAsync()
		{
			CyberPunkTrialRoleView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CyberPunkTrialRoleView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042EB4 RID: 274100 RVA: 0x0104B6AC File Offset: 0x010498AC
		protected override void OnStart()
		{
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickClose));
			this.CaptionItem.SetHelpCallBack(new Action(this.OnClickHelp));
			this.CaptionItem.SetHomeBtnShowState(true);
			this.InitData();
			this.RefreshView();
			this.PlaySpineIdle();
		}

		// Token: 0x06042EB5 RID: 274101 RVA: 0x0104B705 File Offset: 0x01049905
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnTrialStateChange));
		}

		// Token: 0x06042EB6 RID: 274102 RVA: 0x0104B73F File Offset: 0x0104993F
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnTrialStateChange));
		}

		// Token: 0x06042EB7 RID: 274103 RVA: 0x0104B779 File Offset: 0x01049979
		protected override void OnBeforeDestroy()
		{
			this.SetTrialRoleState(ERoleTrialFlowState.ActivityOff);
		}

		// Token: 0x06042EB8 RID: 274104 RVA: 0x0104B784 File Offset: 0x01049984
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

		// Token: 0x06042EB9 RID: 274105 RVA: 0x0104B810 File Offset: 0x01049A10
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

		// Token: 0x06042EBA RID: 274106 RVA: 0x0104B8FA File Offset: 0x01049AFA
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

		// Token: 0x06042EBB RID: 274107 RVA: 0x0104B92C File Offset: 0x01049B2C
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

		// Token: 0x06042EBC RID: 274108 RVA: 0x0104B980 File Offset: 0x01049B80
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

		// Token: 0x06042EBD RID: 274109 RVA: 0x0104B9CF File Offset: 0x01049BCF
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06042EBE RID: 274110 RVA: 0x0104B9D8 File Offset: 0x01049BD8
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(0);
		}

		// Token: 0x06042EBF RID: 274111 RVA: 0x0104B9E5 File Offset: 0x01049BE5
		[NullableContext(1)]
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			if (CyberPunkController.Instance.CurrentActivityId == this.ActivityId)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x06042EC0 RID: 274112 RVA: 0x0104BA00 File Offset: 0x01049C00
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

		// Token: 0x06042EC1 RID: 274113 RVA: 0x0104BA30 File Offset: 0x01049C30
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

		// Token: 0x04022D04 RID: 142596
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022D05 RID: 142597
		private CyberPunkTrialRolePanel RolePanel1;

		// Token: 0x04022D06 RID: 142598
		private CyberPunkTrialRolePanel RolePanel2;

		// Token: 0x04022D07 RID: 142599
		private CyberPunkData ActivityData;

		// Token: 0x04022D08 RID: 142600
		private int ActivityId;

		// Token: 0x0200CA96 RID: 51862
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403D3B9 RID: 250809
			public const int Caption = 0;

			// Token: 0x0403D3BA RID: 250810
			public const int PnlRole1 = 1;

			// Token: 0x0403D3BB RID: 250811
			public const int PnlRole2 = 2;

			// Token: 0x0403D3BC RID: 250812
			public const int RemainTimeText = 3;

			// Token: 0x0403D3BD RID: 250813
			public const int Spine1 = 4;

			// Token: 0x0403D3BE RID: 250814
			public const int Spine2 = 5;
		}
	}
}
