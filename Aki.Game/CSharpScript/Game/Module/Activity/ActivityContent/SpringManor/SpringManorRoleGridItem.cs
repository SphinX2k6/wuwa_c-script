using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006072 RID: 24690
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SpringManorRoleGridItem : LoopScrollMediumItemGrid<RoleDataBase>
	{
		// Token: 0x0603E70C RID: 255756 RVA: 0x00F15C90 File Offset: 0x00F13E90
		protected override void OnRefresh(RoleDataBase roleDataBase, bool isSelected, int gridIndex)
		{
			int dataId = roleDataBase.GetDataId();
			if (dataId == this.RoleId)
			{
				return;
			}
			this.RoleId = dataId;
			bool value = roleDataBase.IsTrialRole();
			CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
			{
				Data = roleDataBase,
				ItemConfigId = new int?(dataId),
				SkinId = roleDataBase.GetRoleConfig().SkinId,
				BottomText = roleDataBase.GetName(null),
				IsTrialRoleVisible = new bool?(value),
				IsDisable = new bool?(SpringManorModel.Instance.IsRoleDead(dataId))
			};
			base.SetUseFixedAsync(true);
			base.Apply<CharacterMediumItemGrid>(parameters);
			FormationData currentFormationData = FormationModel.Instance.CurrentFormationData;
			int? num = (currentFormationData != null) ? currentFormationData.CurrentRoleConfigId : null;
			int? num2 = num;
			int num3 = dataId;
			base.SetCurTagIcon(new bool?(num2.GetValueOrDefault() == num3 & num2 != null));
			this.SetToggleState(isSelected, false, true);
		}

		// Token: 0x0603E70D RID: 255757 RVA: 0x00F15D7D File Offset: 0x00F13F7D
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false, false, false);
		}

		// Token: 0x0603E70E RID: 255758 RVA: 0x00F15D88 File Offset: 0x00F13F88
		public void SetToggleState(bool select, bool fireEvent, bool skipAnim = false)
		{
			UUIExtendToggle itemGridExtendToggle = this.GetItemGridExtendToggle();
			if (itemGridExtendToggle == null)
			{
				return;
			}
			itemGridExtendToggle.SetToggleStateForce(select ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, skipAnim);
		}

		// Token: 0x04020A4B RID: 133707
		private int RoleId;
	}
}
