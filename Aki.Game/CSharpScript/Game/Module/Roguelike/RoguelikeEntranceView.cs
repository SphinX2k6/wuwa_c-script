using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DD6 RID: 19926
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeEntranceView : UiViewBase
	{
		// Token: 0x060336E0 RID: 210656 RVA: 0x00C02C64 File Offset: 0x00C00E64
		[NullableContext(1)]
		public RoguelikeEntranceView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060336E1 RID: 210657 RVA: 0x00C02C70 File Offset: 0x00C00E70
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060336E2 RID: 210658 RVA: 0x00C02D80 File Offset: 0x00C00F80
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeEntranceView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeEntranceView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060336E3 RID: 210659 RVA: 0x00C02DC4 File Offset: 0x00C00FC4
		protected override void OnStart()
		{
			this.RoleSelectPanel.ShowNewUnlockRole(this.Vm.ShowNewUnlockRole);
			if (this.Vm.HasMultiAvailableEntriesGroup())
			{
				EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoguelikeEntranceCanSetMultiplier");
				return;
			}
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoguelikeEntranceLockSetMultiplier");
		}

		// Token: 0x060336E4 RID: 210660 RVA: 0x00C02E20 File Offset: 0x00C01020
		protected override void OnBeforeShow()
		{
			RoguelikeEntryData currentSelectEntryData = this.Vm.CurrentSelectEntryData;
			int? num = (currentSelectEntryData != null) ? new int?(currentSelectEntryData.GroupId) : null;
			if (num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null))
				{
					this.EntriesPanel.ScrollToGroup(num.Value);
					return;
				}
			}
		}

		// Token: 0x060336E5 RID: 210661 RVA: 0x00C02E86 File Offset: 0x00C01086
		protected override void OnAfterShow()
		{
			if (this.NewUnlockEntriesGroupId != null)
			{
				this.ShowNewUnlockEntriesGroupId(this.NewUnlockEntriesGroupId.Value).Forget();
				this.NewUnlockEntriesGroupId = null;
			}
		}

		// Token: 0x060336E6 RID: 210662 RVA: 0x00C02EB7 File Offset: 0x00C010B7
		protected override void OnBeforeDestroy()
		{
			this.UnlockLevelSequencePlayer = null;
			RoguelikeModel.Instance.ClearEntranceViewModel();
		}

		// Token: 0x060336E7 RID: 210663 RVA: 0x00C02ECA File Offset: 0x00C010CA
		private void OnBtnBack()
		{
			InstanceDungeonEntranceController.Instance.RevertEntranceFlowStep();
			base.CloseMe(null);
		}

		// Token: 0x060336E8 RID: 210664 RVA: 0x00C02EE0 File Offset: 0x00C010E0
		private UniTask InitEntriesPanel()
		{
			RoguelikeEntranceView.<InitEntriesPanel>d__16 <InitEntriesPanel>d__;
			<InitEntriesPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitEntriesPanel>d__.<>4__this = this;
			<InitEntriesPanel>d__.<>1__state = -1;
			<InitEntriesPanel>d__.<>t__builder.Start<RoguelikeEntranceView.<InitEntriesPanel>d__16>(ref <InitEntriesPanel>d__);
			return <InitEntriesPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060336E9 RID: 210665 RVA: 0x00C02F24 File Offset: 0x00C01124
		private UniTask InitEntriesDescPanel()
		{
			RoguelikeEntranceView.<InitEntriesDescPanel>d__17 <InitEntriesDescPanel>d__;
			<InitEntriesDescPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitEntriesDescPanel>d__.<>4__this = this;
			<InitEntriesDescPanel>d__.<>1__state = -1;
			<InitEntriesDescPanel>d__.<>t__builder.Start<RoguelikeEntranceView.<InitEntriesDescPanel>d__17>(ref <InitEntriesDescPanel>d__);
			return <InitEntriesDescPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060336EA RID: 210666 RVA: 0x00C02F68 File Offset: 0x00C01168
		private void OnMultiplierChange(bool isAdd)
		{
			int currentEntriesGroupIndex = this.Vm.CurrentEntriesGroupIndex;
			this.Vm.CurrentEntriesGroupIndex += (isAdd ? 1 : -1);
			if (currentEntriesGroupIndex != this.Vm.CurrentEntriesGroupIndex)
			{
				this.EntriesDescPanel.Refresh(this.Vm);
				this.EntriesPanel.Refresh(this.Vm);
				this.EntriesPanel.ScrollToGroup(this.Vm.EntriesDataGroupList[this.Vm.CurrentEntriesGroupIndex].Id);
			}
		}

		// Token: 0x060336EB RID: 210667 RVA: 0x00C02FF4 File Offset: 0x00C011F4
		[NullableContext(1)]
		private void OnClickEntry(bool isSelect, RoguelikeEntryData data)
		{
			if (this.Vm.CurrentSelectEntryData == data)
			{
				return;
			}
			if (!isSelect)
			{
				return;
			}
			if (this.Vm.CurrentSelectEntryData != null)
			{
				Action<bool, bool> setEntryToggleState = this.Vm.CurrentSelectEntryData.SetEntryToggleState;
				if (setEntryToggleState != null)
				{
					setEntryToggleState(false, false);
				}
				this.Vm.CurrentSelectEntryData = null;
			}
			this.Vm.SetCurrentSelectEntryData(data);
			this.EntriesPanel.RefreshSelectEntry(this.Vm, data, true);
		}

		// Token: 0x060336EC RID: 210668 RVA: 0x00C0306C File Offset: 0x00C0126C
		[NullableContext(0)]
		public UniTask ShowNewUnlockEntriesGroupId(ValueTuple<int, int> groupId)
		{
			RoguelikeEntranceView.<ShowNewUnlockEntriesGroupId>d__20 <ShowNewUnlockEntriesGroupId>d__;
			<ShowNewUnlockEntriesGroupId>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowNewUnlockEntriesGroupId>d__.<>4__this = this;
			<ShowNewUnlockEntriesGroupId>d__.groupId = groupId;
			<ShowNewUnlockEntriesGroupId>d__.<>1__state = -1;
			<ShowNewUnlockEntriesGroupId>d__.<>t__builder.Start<RoguelikeEntranceView.<ShowNewUnlockEntriesGroupId>d__20>(ref <ShowNewUnlockEntriesGroupId>d__);
			return <ShowNewUnlockEntriesGroupId>d__.<>t__builder.Task;
		}

		// Token: 0x060336ED RID: 210669 RVA: 0x00C030B8 File Offset: 0x00C012B8
		private UniTask InitRoleSelectPanel()
		{
			RoguelikeEntranceView.<InitRoleSelectPanel>d__21 <InitRoleSelectPanel>d__;
			<InitRoleSelectPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleSelectPanel>d__.<>4__this = this;
			<InitRoleSelectPanel>d__.<>1__state = -1;
			<InitRoleSelectPanel>d__.<>t__builder.Start<RoguelikeEntranceView.<InitRoleSelectPanel>d__21>(ref <InitRoleSelectPanel>d__);
			return <InitRoleSelectPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060336EE RID: 210670 RVA: 0x00C030FC File Offset: 0x00C012FC
		private void OnClickRoleItemFunc(int index)
		{
			int selectRoleId = this.Vm.FormationIdList[index];
			Action<int> confirmFunction = delegate(int roleId)
			{
				int selectRoleId;
				if (selectRoleId == roleId)
				{
					this.Vm.FormationIdList[index] = 0;
				}
				else
				{
					selectRoleId = selectRoleId;
					for (int i = 0; i < this.Vm.FormationIdList.Count; i++)
					{
						if (this.Vm.FormationIdList[i] == roleId)
						{
							this.Vm.FormationIdList[i] = selectRoleId;
							break;
						}
					}
					this.Vm.FormationIdList[index] = roleId;
				}
				this.Vm.CacheRoleSelect();
				this.RoleSelectPanel.Refresh(this.Vm);
			};
			Func<int, string> getConfirmButtonTextCallBack = delegate(int roleConfigId)
			{
				if (roleConfigId == 0)
				{
					return null;
				}
				if (selectRoleId == 0)
				{
					return "JoinText";
				}
				if (selectRoleId == roleConfigId)
				{
					return "GoDownText";
				}
				return "ChangeText";
			};
			TeamRoleSelectViewData teamRoleSelectViewData = new TeamRoleSelectViewData(EFilterSortGroupId.EditFormation, selectRoleId, this.Vm.GetFormationRoleDataList(), confirmFunction, null, new int?(index + 1), null);
			teamRoleSelectViewData.FormationRoleList = this.Vm.FormationIdList.ToArray();
			teamRoleSelectViewData.IsNeedRevive = new Func<int, bool>(this.IsNeedRevive);
			teamRoleSelectViewData.GetConfirmButtonTextCallBack = getConfirmButtonTextCallBack;
			teamRoleSelectViewData.GetDetailButtonVisible = new Func<int, bool>(this.GetDetailButtonVisible);
			teamRoleSelectViewData.GetConfirmButtonEnableCallBack = new Func<int, bool>(this.CanJoinTeam);
			teamRoleSelectViewData.CanJoinTeam = new Func<int, bool>(this.CanJoinTeam);
			if (index != 0)
			{
				teamRoleSelectViewData.GetCustomSkillShowData = new Func<int, List<TeamRoleSkillData>>(this.Vm.GetSupportCustomSkillShowData);
			}
			teamRoleSelectViewData.OverrideGridProxyCreate = (() => new TeamRoleGridRoguelike());
			RoleController.Instance.OpenTeamRoleSelectView(teamRoleSelectViewData);
			if (this.Vm.ShowNewUnlockRole)
			{
				this.RoleSelectPanel.ShowNewUnlockRole(false);
				this.Vm.CacheNewUnlockRoleId();
			}
		}

		// Token: 0x060336EF RID: 210671 RVA: 0x00C0325C File Offset: 0x00C0145C
		private bool IsNeedRevive(int roleConfigId)
		{
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleConfigId, true);
			return !((roleDataById != null) ? new bool?(roleDataById.IsTrialRole()) : null).GetValueOrDefault() && FormationModel.Instance.IsRoleDead(roleConfigId);
		}

		// Token: 0x060336F0 RID: 210672 RVA: 0x00C032A8 File Offset: 0x00C014A8
		private bool GetDetailButtonVisible(int roleId)
		{
			return false;
		}

		// Token: 0x060336F1 RID: 210673 RVA: 0x00C032AC File Offset: 0x00C014AC
		private bool CanJoinTeam(int roleId)
		{
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
			bool? flag = (roleDataById != null) ? new bool?(roleDataById.IsTrialRole()) : null;
			foreach (int num in this.Vm.FormationIdList)
			{
				RoleDataBase roleDataById2 = RoleModel.Instance.GetRoleDataById(num, true);
				if (roleDataById2 != null && roleDataById2.IsTrialRole() && roleDataById2.GetRoleId() == roleId)
				{
					return false;
				}
				if (roleDataById != null && flag.GetValueOrDefault() && roleDataById.GetRoleId() == num)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060336F2 RID: 210674 RVA: 0x00C03370 File Offset: 0x00C01570
		private void OnEnterInst()
		{
			Action action = delegate()
			{
				InstanceDungeonEntranceController.Instance.ContinueEntranceFlow();
			};
			if (this.Vm.FormationIdList[0] == 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("RoguelikeInstEnterEmptyTips", Array.Empty<object>());
				return;
			}
			bool flag = false;
			using (List<int>.Enumerator enumerator = this.Vm.FormationIdList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == 0)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoguelikeInstEnterConfirm);
				confirmBoxDataNew.FunctionMap[2] = action;
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			action();
		}

		// Token: 0x0401B4D6 RID: 111830
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B4D7 RID: 111831
		private RoguelikePopularEntriesDescPanel EntriesDescPanel;

		// Token: 0x0401B4D8 RID: 111832
		private RoguelikePopularEntriesPanel EntriesPanel;

		// Token: 0x0401B4D9 RID: 111833
		private RoguelikeRoleSelectPanel RoleSelectPanel;

		// Token: 0x0401B4DA RID: 111834
		[Nullable(1)]
		private RoguelikeEntranceViewModel Vm;

		// Token: 0x0401B4DB RID: 111835
		[Nullable(0)]
		private ValueTuple<int, int>? NewUnlockEntriesGroupId;

		// Token: 0x0401B4DC RID: 111836
		private LevelSequencePlayer UnlockLevelSequencePlayer;

		// Token: 0x0200AF50 RID: 44880
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040353B6 RID: 218038
			public const int CaptionItem = 0;

			// Token: 0x040353B7 RID: 218039
			public const int PopularEntriesPanel = 1;

			// Token: 0x040353B8 RID: 218040
			public const int PopularEntriesDescPanel = 2;

			// Token: 0x040353B9 RID: 218041
			public const int RoleSelectPanel = 3;

			// Token: 0x040353BA RID: 218042
			public const int PanelEntriesGroupNewUnlock = 4;

			// Token: 0x040353BB RID: 218043
			public const int TxtLastGroup = 5;

			// Token: 0x040353BC RID: 218044
			public const int TxtNewGroup = 6;
		}
	}
}
