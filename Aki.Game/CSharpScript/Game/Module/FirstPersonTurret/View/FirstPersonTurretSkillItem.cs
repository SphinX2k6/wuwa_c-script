using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.SkillButtonUi;

namespace CSharpScript.Game.Module.FirstPersonTurret.View
{
	// Token: 0x02004A5C RID: 19036
	[NullableContext(2)]
	[Nullable(0)]
	public class FirstPersonTurretSkillItem : BattleSkillItem
	{
		// Token: 0x0602FA38 RID: 195128 RVA: 0x00D49FEC File Offset: 0x00D481EC
		public override void Initialize(object param = null)
		{
			FirstPersonTurretSkillItemParam firstPersonTurretSkillItemParam = param as FirstPersonTurretSkillItemParam;
			if (firstPersonTurretSkillItemParam != null)
			{
				this.TurretButtonType = new ESkillButtonType?(firstPersonTurretSkillItemParam.ButtonType);
				base.Initialize(firstPersonTurretSkillItemParam.InputIndex);
				return;
			}
			this.TurretButtonType = null;
			base.Initialize(param);
		}

		// Token: 0x0602FA39 RID: 195129 RVA: 0x00D4A039 File Offset: 0x00D48239
		public override void Refresh(ISkillButtonData skillButtonData)
		{
			base.Refresh(skillButtonData);
			this.DisableActionInput();
		}

		// Token: 0x0602FA3A RID: 195130 RVA: 0x00D4A048 File Offset: 0x00D48248
		public override void RefreshKey()
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.SetActive(false);
		}

		// Token: 0x0602FA3B RID: 195131 RVA: 0x00D4A05B File Offset: 0x00D4825B
		public override void Reset()
		{
			this.RestoreActionInput();
			base.Reset();
		}

		// Token: 0x0602FA3C RID: 195132 RVA: 0x00D4A069 File Offset: 0x00D48269
		public ESkillButtonType? GetTurretButtonType()
		{
			return this.TurretButtonType;
		}

		// Token: 0x0602FA3D RID: 195133 RVA: 0x00D4A074 File Offset: 0x00D48274
		public void RestoreActionInput()
		{
			TsCharacterController characterController = Global.CharacterController;
			if (characterController != null)
			{
				foreach (string actionName in this.DisabledActionNameSet)
				{
					characterController.SetActionEnable(actionName, true);
				}
			}
			this.DisabledActionNameSet.Clear();
		}

		// Token: 0x0602FA3E RID: 195134 RVA: 0x00D4A0DC File Offset: 0x00D482DC
		private void DisableActionInput()
		{
			ISkillButtonData skillButtonData = this.SkillButtonData;
			string text = (skillButtonData != null) ? skillButtonData.GetActionName() : null;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			TsCharacterController characterController = Global.CharacterController;
			if (characterController != null)
			{
				characterController.SetActionEnable(text, false);
			}
			this.DisabledActionNameSet.Add(text);
		}

		// Token: 0x040194AF RID: 103599
		private ESkillButtonType? TurretButtonType;

		// Token: 0x040194B0 RID: 103600
		[Nullable(1)]
		private readonly HashSet<string> DisabledActionNameSet = new HashSet<string>();
	}
}
