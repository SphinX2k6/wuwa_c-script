using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleSkill
{
	// Token: 0x02004CF8 RID: 19704
	public class RoleSkillBranchItem : UiPanelBase
	{
		// Token: 0x06032EFC RID: 208636 RVA: 0x00BDF498 File Offset: 0x00BDD698
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnBranchToggleClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBranchHelpButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnCloseTipsButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06032EFD RID: 208637 RVA: 0x00BDF66C File Offset: 0x00BDD86C
		protected override UniTask OnBeforeStartAsync()
		{
			RoleSkillBranchItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkillBranchItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032EFE RID: 208638 RVA: 0x00BDF6B0 File Offset: 0x00BDD8B0
		private UniTask InitBranchTipsItem()
		{
			RoleSkillBranchItem.<InitBranchTipsItem>d__7 <InitBranchTipsItem>d__;
			<InitBranchTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBranchTipsItem>d__.<>4__this = this;
			<InitBranchTipsItem>d__.<>1__state = -1;
			<InitBranchTipsItem>d__.<>t__builder.Start<RoleSkillBranchItem.<InitBranchTipsItem>d__7>(ref <InitBranchTipsItem>d__);
			return <InitBranchTipsItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032EFF RID: 208639 RVA: 0x00BDF6F4 File Offset: 0x00BDD8F4
		public bool SetSkillBranchVisible(ESkillBranchInvisibleReason reason, bool visible)
		{
			if (visible)
			{
				this.InvisibleSet.Remove(reason);
			}
			else
			{
				this.InvisibleSet.Add(reason);
			}
			bool flag = this.CanShowSkillBranch();
			base.GetRootItem().SetUIActive(flag);
			return flag;
		}

		// Token: 0x06032F00 RID: 208640 RVA: 0x00BDF734 File Offset: 0x00BDD934
		public void SetSkillBranchTipsVisible(bool visible)
		{
			this.RoleSkillBranchTipsItem.SetTipsVisible(visible, true);
			base.GetButton(6).RootUIComp.Get().SetUIActive(visible);
		}

		// Token: 0x06032F01 RID: 208641 RVA: 0x00BDF768 File Offset: 0x00BDD968
		private bool CanShowSkillBranch()
		{
			return this.InvisibleSet.Count == 0;
		}

		// Token: 0x06032F02 RID: 208642 RVA: 0x00BDF778 File Offset: 0x00BDD978
		public void Refresh(int roleId, bool enableSwitchBranch)
		{
			this.RoleId = roleId;
			this.EnableSwitchBranch = enableSwitchBranch;
			bool visible = RoleModel.Instance.IsRoleHasBranch(this.RoleId);
			if (!this.SetSkillBranchVisible(ESkillBranchInvisibleReason.NotHaveSkillBranch, visible))
			{
				return;
			}
			base.GetSprite(1).SetUIActive(!this.EnableSwitchBranch);
			int roleBranchIdByIndex = RoleModel.Instance.GetRoleBranchIdByIndex(this.RoleId, 0);
			this.SetSpriteByPath(RoleConfig.Instance.GetSkillBranchConfigById(roleBranchIdByIndex).Value.Icon, base.GetSprite(4), false, null, null);
			int roleBranchIdByIndex2 = RoleModel.Instance.GetRoleBranchIdByIndex(this.RoleId, 1);
			this.SetSpriteByPath(RoleConfig.Instance.GetSkillBranchConfigById(roleBranchIdByIndex2).Value.Icon, base.GetSprite(5), false, null, null);
			base.GetItem(7).SetUIActive(this.EnableSwitchBranch);
			base.GetItem(8).SetUIActive(this.EnableSwitchBranch);
			EToggleState etoggleState = (RoleModel.Instance.GetRoleCurrentBranchIndex(this.RoleId) == 0) ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
			EToggleState state = this.EnableSwitchBranch ? etoggleState : EToggleState.ETT_UnDetermined;
			base.GetExtendToggle(0).SetToggleStateForce(state, false, false, false);
			if (RoleModel.Instance.IsRoleOwned(this.RoleId))
			{
				EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "OnShowOwnedRoleSkillBranch");
			}
		}

		// Token: 0x06032F03 RID: 208643 RVA: 0x00BDF8D8 File Offset: 0x00BDDAD8
		private void OnBranchToggleClick(EToggleState state)
		{
			int index = (state > EToggleState.ETT_UnChecked) ? 1 : 0;
			int roleBranchIdByIndex = RoleModel.Instance.GetRoleBranchIdByIndex(this.RoleId, index);
			int roleCurrentBranchId = RoleModel.Instance.GetRoleCurrentBranchId(this.RoleId);
			if (roleBranchIdByIndex == roleCurrentBranchId)
			{
				return;
			}
			RoleController.Instance.RequestRoleSkillBranchModify(this.RoleId, roleBranchIdByIndex);
		}

		// Token: 0x06032F04 RID: 208644 RVA: 0x00BDF923 File Offset: 0x00BDDB23
		private void OnBranchHelpButtonClick()
		{
			if (this.RoleSkillBranchTipsItem.IsTipsVisible)
			{
				this.RoleSkillBranchTipsItem.SetTipsVisible(false, true);
				return;
			}
			this.RoleSkillBranchTipsItem.RefreshView(this.RoleId, this.EnableSwitchBranch);
			this.SetSkillBranchTipsVisible(true);
		}

		// Token: 0x06032F05 RID: 208645 RVA: 0x00BDF95E File Offset: 0x00BDDB5E
		private bool CanExecuteChange()
		{
			return RoleModel.Instance.CheckCanSwitchRoleBranch(true) && RoleModel.Instance.IsRoleHasBranch(this.RoleId);
		}

		// Token: 0x06032F06 RID: 208646 RVA: 0x00BDF980 File Offset: 0x00BDDB80
		private void OnCloseTipsButtonClick()
		{
			this.RoleSkillBranchTipsItem.SetTipsVisible(false, true);
			base.GetButton(6).RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x0401B189 RID: 110985
		private int RoleId;

		// Token: 0x0401B18A RID: 110986
		private bool EnableSwitchBranch;

		// Token: 0x0401B18B RID: 110987
		[Nullable(2)]
		private RoleSkillBranchTipsItem RoleSkillBranchTipsItem;

		// Token: 0x0401B18C RID: 110988
		[Nullable(1)]
		private HashSet<ESkillBranchInvisibleReason> InvisibleSet = new HashSet<ESkillBranchInvisibleReason>();

		// Token: 0x0200AE87 RID: 44679
		private enum EComponent
		{
			// Token: 0x04034FEA RID: 217066
			BranchToggle,
			// Token: 0x04034FEB RID: 217067
			StateSprite,
			// Token: 0x04034FEC RID: 217068
			BranchHelpButton,
			// Token: 0x04034FED RID: 217069
			BranchTipsSlot,
			// Token: 0x04034FEE RID: 217070
			BranchLeftTagSprite,
			// Token: 0x04034FEF RID: 217071
			BranchRightTagSprite,
			// Token: 0x04034FF0 RID: 217072
			CloseTipsButton,
			// Token: 0x04034FF1 RID: 217073
			BranchLeftItem,
			// Token: 0x04034FF2 RID: 217074
			BranchRightItem
		}
	}
}
