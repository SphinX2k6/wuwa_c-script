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
	// Token: 0x020068D2 RID: 26834
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopEntranceView : UiViewBase
	{
		// Token: 0x06042F55 RID: 274261 RVA: 0x0104E61F File Offset: 0x0104C81F
		public CoopEntranceView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042F56 RID: 274262 RVA: 0x0104E628 File Offset: 0x0104C828
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

		// Token: 0x06042F57 RID: 274263 RVA: 0x0104E790 File Offset: 0x0104C990
		protected override void OnBeforeCreate()
		{
			this.ActivityData = (this.OpenParam as CoopActivityData);
		}

		// Token: 0x06042F58 RID: 274264 RVA: 0x0104E7A4 File Offset: 0x0104C9A4
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnCoopLevelUpdate, new Action(this.RefreshRole));
			EventSystem.Instance.Add(EEventName.OnCoopLevelUpdate, new Action(this.RefreshRewardButton));
			EventSystem.Instance.Add(EEventName.OnCoopSpUpdate, new Action(this.RefreshRewardButton));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06042F59 RID: 274265 RVA: 0x0104E824 File Offset: 0x0104CA24
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnCoopLevelUpdate, new Action(this.RefreshRole));
			EventSystem.Instance.Remove(EEventName.OnCoopLevelUpdate, new Action(this.RefreshRewardButton));
			EventSystem.Instance.Remove(EEventName.OnCoopSpUpdate, new Action(this.RefreshRewardButton));
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06042F5A RID: 274266 RVA: 0x0104E8A4 File Offset: 0x0104CAA4
		protected override UniTask OnBeforeStartAsync()
		{
			CoopEntranceView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CoopEntranceView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042F5B RID: 274267 RVA: 0x0104E8E8 File Offset: 0x0104CAE8
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

		// Token: 0x06042F5C RID: 274268 RVA: 0x0104E944 File Offset: 0x0104CB44
		protected override void OnBeforeHide()
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.LGUI.CreateMeshSectionOptVis ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.ValueBeforeShow);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		}

		// Token: 0x06042F5D RID: 274269 RVA: 0x0104E988 File Offset: 0x0104CB88
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

		// Token: 0x06042F5E RID: 274270 RVA: 0x0104E9EC File Offset: 0x0104CBEC
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

		// Token: 0x06042F5F RID: 274271 RVA: 0x0104EA4C File Offset: 0x0104CC4C
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

		// Token: 0x06042F60 RID: 274272 RVA: 0x0104EA92 File Offset: 0x0104CC92
		private void OnClickRewardBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.CoopSpRewardView, this.ActivityData, null);
		}

		// Token: 0x06042F61 RID: 274273 RVA: 0x0104EAAC File Offset: 0x0104CCAC
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

		// Token: 0x06042F62 RID: 274274 RVA: 0x0104EAF4 File Offset: 0x0104CCF4
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

		// Token: 0x06042F63 RID: 274275 RVA: 0x0104EBD7 File Offset: 0x0104CDD7
		private void OnRolePointerExit()
		{
			UUIItem item = base.GetItem(12);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x04022D6B RID: 142699
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<CoopEntryRoleItem> RoleButtonList;

		// Token: 0x04022D6C RID: 142700
		[Nullable(2)]
		private CoopActivityData ActivityData;

		// Token: 0x04022D6D RID: 142701
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022D6E RID: 142702
		[Nullable(2)]
		private CoopRewardButton RewardButton;

		// Token: 0x04022D6F RID: 142703
		private int ValueBeforeShow;
	}
}
