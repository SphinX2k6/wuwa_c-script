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
	// Token: 0x02003CAA RID: 15530
	public class RoleSkillBranchItem : UiPanelBase
	{
		// Token: 0x06027CD7 RID: 163031 RVA: 0x00B24DA0 File Offset: 0x00B22FA0
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

		// Token: 0x06027CD8 RID: 163032 RVA: 0x00B24F74 File Offset: 0x00B23174
		protected override UniTask OnBeforeStartAsync()
		{
			RoleSkillBranchItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkillBranchItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027CD9 RID: 163033 RVA: 0x00B24FB8 File Offset: 0x00B231B8
		private UniTask InitBranchTipsItem()
		{
			RoleSkillBranchItem.<InitBranchTipsItem>d__7 <InitBranchTipsItem>d__;
			<InitBranchTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBranchTipsItem>d__.<>4__this = this;
			<InitBranchTipsItem>d__.<>1__state = -1;
			<InitBranchTipsItem>d__.<>t__builder.Start<RoleSkillBranchItem.<InitBranchTipsItem>d__7>(ref <InitBranchTipsItem>d__);
			return <InitBranchTipsItem>d__.<>t__builder.Task;
		}

		// Token: 0x06027CDA RID: 163034 RVA: 0x00B24FFC File Offset: 0x00B231FC
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

		// Token: 0x06027CDB RID: 163035 RVA: 0x00B2503C File Offset: 0x00B2323C
		public void SetSkillBranchTipsVisible(bool visible)
		{
			this.RoleSkillBranchTipsItem.SetTipsVisible(visible, true);
			base.GetButton(6).RootUIComp.Get().SetUIActive(visible);
		}

		// Token: 0x06027CDC RID: 163036 RVA: 0x00B25070 File Offset: 0x00B23270
		private bool CanShowSkillBranch()
		{
			return this.InvisibleSet.Count == 0;
		}

		// Token: 0x06027CDD RID: 163037 RVA: 0x00B25080 File Offset: 0x00B23280
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

		// Token: 0x06027CDE RID: 163038 RVA: 0x00B251E0 File Offset: 0x00B233E0
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

		// Token: 0x06027CDF RID: 163039 RVA: 0x00B2522B File Offset: 0x00B2342B
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

		// Token: 0x06027CE0 RID: 163040 RVA: 0x00B25266 File Offset: 0x00B23466
		private bool CanExecuteChange()
		{
			return RoleModel.Instance.CheckCanSwitchRoleBranch(true) && RoleModel.Instance.IsRoleHasBranch(this.RoleId);
		}

		// Token: 0x06027CE1 RID: 163041 RVA: 0x00B25288 File Offset: 0x00B23488
		private void OnCloseTipsButtonClick()
		{
			this.RoleSkillBranchTipsItem.SetTipsVisible(false, true);
			base.GetButton(6).RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x04015B0E RID: 88846
		private int RoleId;

		// Token: 0x04015B0F RID: 88847
		private bool EnableSwitchBranch;

		// Token: 0x04015B10 RID: 88848
		[Nullable(2)]
		private RoleSkillBranchTipsItem RoleSkillBranchTipsItem;

		// Token: 0x04015B11 RID: 88849
		[Nullable(1)]
		private HashSet<ESkillBranchInvisibleReason> InvisibleSet = new HashSet<ESkillBranchInvisibleReason>();

		// Token: 0x020098A5 RID: 39077
		private enum EComponent
		{
			// Token: 0x0402F992 RID: 194962
			BranchToggle,
			// Token: 0x0402F993 RID: 194963
			StateSprite,
			// Token: 0x0402F994 RID: 194964
			BranchHelpButton,
			// Token: 0x0402F995 RID: 194965
			BranchTipsSlot,
			// Token: 0x0402F996 RID: 194966
			BranchLeftTagSprite,
			// Token: 0x0402F997 RID: 194967
			BranchRightTagSprite,
			// Token: 0x0402F998 RID: 194968
			CloseTipsButton,
			// Token: 0x0402F999 RID: 194969
			BranchLeftItem,
			// Token: 0x0402F99A RID: 194970
			BranchRightItem
		}
	}
}
