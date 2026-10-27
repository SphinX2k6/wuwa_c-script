using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.SkillButtonUi;

namespace CSharpScript.Game.Module.FirstPersonTurret.View
{
	// Token: 0x02005A80 RID: 23168
	[NullableContext(2)]
	[Nullable(0)]
	public class FirstPersonTurretSkillItem : BattleSkillItem
	{
		// Token: 0x0603AAEF RID: 240367 RVA: 0x00DF9A58 File Offset: 0x00DF7C58
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

		// Token: 0x0603AAF0 RID: 240368 RVA: 0x00DF9AA5 File Offset: 0x00DF7CA5
		public override void Refresh(ISkillButtonData skillButtonData)
		{
			base.Refresh(skillButtonData);
			this.DisableActionInput();
		}

		// Token: 0x0603AAF1 RID: 240369 RVA: 0x00DF9AB4 File Offset: 0x00DF7CB4
		public override void RefreshKey()
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.SetActive(false);
		}

		// Token: 0x0603AAF2 RID: 240370 RVA: 0x00DF9AC7 File Offset: 0x00DF7CC7
		public override void Reset()
		{
			this.RestoreActionInput();
			base.Reset();
		}

		// Token: 0x0603AAF3 RID: 240371 RVA: 0x00DF9AD5 File Offset: 0x00DF7CD5
		public ESkillButtonType? GetTurretButtonType()
		{
			return this.TurretButtonType;
		}

		// Token: 0x0603AAF4 RID: 240372 RVA: 0x00DF9AE0 File Offset: 0x00DF7CE0
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

		// Token: 0x0603AAF5 RID: 240373 RVA: 0x00DF9B48 File Offset: 0x00DF7D48
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

		// Token: 0x0401EA08 RID: 125448
		private ESkillButtonType? TurretButtonType;

		// Token: 0x0401EA09 RID: 125449
		[Nullable(1)]
		private readonly HashSet<string> DisabledActionNameSet = new HashSet<string>();
	}
}
