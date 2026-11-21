using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FF0 RID: 20464
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SpringManorRoleGridItem : LoopScrollMediumItemGrid<RoleDataBase>
	{
		// Token: 0x060333D0 RID: 209872 RVA: 0x00E5CA54 File Offset: 0x00E5AC54
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

		// Token: 0x060333D1 RID: 209873 RVA: 0x00E5CB41 File Offset: 0x00E5AD41
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false, false, false);
		}

		// Token: 0x060333D2 RID: 209874 RVA: 0x00E5CB4C File Offset: 0x00E5AD4C
		public void SetToggleState(bool select, bool fireEvent, bool skipAnim = false)
		{
			UUIExtendToggle itemGridExtendToggle = this.GetItemGridExtendToggle();
			if (itemGridExtendToggle == null)
			{
				return;
			}
			itemGridExtendToggle.SetToggleStateForce(select ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, skipAnim);
		}

		// Token: 0x0401B378 RID: 111480
		private int RoleId;
	}
}
