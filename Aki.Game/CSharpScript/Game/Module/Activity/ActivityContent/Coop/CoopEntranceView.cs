using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x02005822 RID: 22562
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopEntranceView : UiViewBase
	{
		// Token: 0x06037AAD RID: 228013 RVA: 0x00F8FC47 File Offset: 0x00F8DE47
		public CoopEntranceView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06037AAE RID: 228014 RVA: 0x00F8FC50 File Offset: 0x00F8DE50
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIText)),
				new ValueTuple<int, Type>(14, typeof(UUIText))
			};
		}

		// Token: 0x06037AAF RID: 228015 RVA: 0x00F8FDB8 File Offset: 0x00F8DFB8
		protected override void OnBeforeCreate()
		{
			this.ActivityData = (this.OpenParam as CoopActivityData);
		}

		// Token: 0x06037AB0 RID: 228016 RVA: 0x00F8FDCC File Offset: 0x00F8DFCC
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnCoopLevelUpdate, new Action(this.RefreshRole));
			EventSystem.Instance.Add(EEventName.OnCoopLevelUpdate, new Action(this.RefreshRewardButton));
			EventSystem.Instance.Add(EEventName.OnCoopSpUpdate, new Action(this.RefreshRewardButton));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06037AB1 RID: 228017 RVA: 0x00F8FE4C File Offset: 0x00F8E04C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnCoopLevelUpdate, new Action(this.RefreshRole));
			EventSystem.Instance.Remove(EEventName.OnCoopLevelUpdate, new Action(this.RefreshRewardButton));
			EventSystem.Instance.Remove(EEventName.OnCoopSpUpdate, new Action(this.RefreshRewardButton));
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06037AB2 RID: 228018 RVA: 0x00F8FECC File Offset: 0x00F8E0CC
		protected override UniTask OnBeforeStartAsync()
		{
			CoopEntranceView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CoopEntranceView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037AB3 RID: 228019 RVA: 0x00F8FF10 File Offset: 0x00F8E110
		protected override void OnBeforeShow()
		{
			this.RefreshRole();
			this.RefreshRewardButton();
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			if (GameSettingsDeviceRender.Instance.IsVulkanRHI() != 0)
			{
				this.ValueBeforeShow = UKismetSystemLibrary.GetConsoleVariableIntValue("r.LGUI.CreateMeshSectionOptVis");
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.LGUI.CreateMeshSectionOptVis 0", null);
			}
		}

		// Token: 0x06037AB4 RID: 228020 RVA: 0x00F8FF6C File Offset: 0x00F8E16C
		protected override void OnBeforeHide()
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.LGUI.CreateMeshSectionOptVis ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.ValueBeforeShow);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		}

		// Token: 0x06037AB5 RID: 228021 RVA: 0x00F8FFB0 File Offset: 0x00F8E1B0
		private void OnClickedRole(CoopRoleData data)
		{
			int roleIndexByRoleId = this.ActivityData.GetRoleIndexByRoleId(data.RoleId);
			if (roleIndexByRoleId == -1)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.CoopRoleSelectView, new CoopRoleSelectViewParams
			{
				ActivityData = this.ActivityData,
				Index = roleIndexByRoleId,
				Level = 0,
				LevelId = 0,
				IsOpenByUpGradeView = false
			}, null);
		}

		// Token: 0x06037AB6 RID: 228022 RVA: 0x00F90014 File Offset: 0x00F8E214
		private void RefreshRole()
		{
			List<CoopRoleData> coopRoleDataList = this.ActivityData.CoopRoleDataList;
			if (coopRoleDataList == null)
			{
				return;
			}
			for (int i = 0; i < this.RoleButtonList.Count; i++)
			{
				CoopEntryRoleItem coopEntryRoleItem = this.RoleButtonList[i];
				CoopRoleData coopRoleData = (i < coopRoleDataList.Count) ? coopRoleDataList[i] : null;
				if (coopRoleData != null)
				{
					coopEntryRoleItem.Refresh(coopRoleData, false, i);
				}
			}
		}

		// Token: 0x06037AB7 RID: 228023 RVA: 0x00F90074 File Offset: 0x00F8E274
		private void RefreshRewardButton()
		{
			int claimedRewardCount = this.ActivityData.GetClaimedRewardCount();
			CoopRewardButton rewardButton = this.RewardButton;
			if (rewardButton != null)
			{
				rewardButton.RefreshRewardCount(claimedRewardCount);
			}
			CoopRewardButton rewardButton2 = this.RewardButton;
			if (rewardButton2 == null)
			{
				return;
			}
			rewardButton2.SetRedDotShow(this.ActivityData.IsHasCoopSpRewardRedDot());
		}

		// Token: 0x06037AB8 RID: 228024 RVA: 0x00F900BA File Offset: 0x00F8E2BA
		private void OnClickRewardBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.CoopSpRewardView, this.ActivityData, null);
		}

		// Token: 0x06037AB9 RID: 228025 RVA: 0x00F900D4 File Offset: 0x00F8E2D4
		private void OnRefreshCommonActivityRedDot(int id)
		{
			CoopActivityData activityData = this.ActivityData;
			int? num = (activityData != null) ? new int?(activityData.Id) : null;
			if (!(id == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			this.RefreshRole();
		}

		// Token: 0x06037ABA RID: 228026 RVA: 0x00F9011C File Offset: 0x00F8E31C
		private void OnRolePointerEnter(CoopRoleData data)
		{
			CoopRole? coopRoleConfigByRoleId = CoopConfig.Instance.GetCoopRoleConfigByRoleId(data.RoleId);
			if (coopRoleConfigByRoleId == null)
			{
				return;
			}
			UUIText text = base.GetText(13);
			if (text != null && !string.IsNullOrEmpty(coopRoleConfigByRoleId.Value.RoleName))
			{
				LguiUtil.Instance.SetLocalTextNew(text, coopRoleConfigByRoleId.Value.RoleName, Array.Empty<object>());
			}
			int roleCurCoopLevelIdFinalZero = this.ActivityData.GetRoleCurCoopLevelIdFinalZero(data.RoleId);
			UUIText text2 = base.GetText(14);
			if (text2 != null)
			{
				text2.SetUIActive(roleCurCoopLevelIdFinalZero > 0);
			}
			if (text2 != null && roleCurCoopLevelIdFinalZero > 0)
			{
				CoopRoleLevel? coopConfigById = CoopConfig.Instance.GetCoopConfigById(roleCurCoopLevelIdFinalZero);
				if (coopConfigById != null)
				{
					LguiUtil.Instance.SetLocalTextNew(text2, coopConfigById.Value.LevelUpText, Array.Empty<object>());
				}
			}
			UUIItem item = base.GetItem(12);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(true);
		}

		// Token: 0x06037ABB RID: 228027 RVA: 0x00F901FF File Offset: 0x00F8E3FF
		private void OnRolePointerExit()
		{
			UUIItem item = base.GetItem(12);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0401D5C7 RID: 120263
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<CoopEntryRoleItem> RoleButtonList;

		// Token: 0x0401D5C8 RID: 120264
		[Nullable(2)]
		private CoopActivityData ActivityData;

		// Token: 0x0401D5C9 RID: 120265
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D5CA RID: 120266
		[Nullable(2)]
		private CoopRewardButton RewardButton;

		// Token: 0x0401D5CB RID: 120267
		private int ValueBeforeShow;
	}
}
