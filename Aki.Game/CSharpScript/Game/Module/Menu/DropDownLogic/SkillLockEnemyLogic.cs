using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Menu.DropDownLogic
{
	// Token: 0x02004457 RID: 17495
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillLockEnemyLogic : DropDownLogicBase
	{
		// Token: 0x0602C218 RID: 180760 RVA: 0x00C65348 File Offset: 0x00C63548
		public override IReadOnlyList<object> GetDropDownDataList()
		{
			List<SkillLockEnemyDropDownData> list = new List<SkillLockEnemyDropDownData>();
			MenuConfig? menuConfigByFunctionId = MenuBaseConfig.Instance.GetMenuConfigByFunctionId(133);
			if (menuConfigByFunctionId == null)
			{
				return list;
			}
			string[] array = menuConfigByFunctionId.Value.OptionsName();
			for (int i = 0; i < array.Length; i++)
			{
				string textId = array[i];
				SkillLockEnemyDropDownData item = new SkillLockEnemyDropDownData(i, textId);
				list.Add(item);
			}
			return list;
		}

		// Token: 0x0602C219 RID: 180761 RVA: 0x00C653B2 File Offset: 0x00C635B2
		public override TableTextArgNew GetDataTextId(object data, MenuData menuData)
		{
			return new TableTextArgNew(((SkillLockEnemyDropDownData)data).TextId, Array.Empty<object>());
		}

		// Token: 0x0602C21A RID: 180762 RVA: 0x00C653CC File Offset: 0x00C635CC
		public override void TriggerSelectChange(object data, MenuData menuData)
		{
			int targetConfig = MenuController.Instance.GetTargetConfig(menuData.FunctionId);
			int index = ((SkillLockEnemyDropDownData)data).Index;
			if (targetConfig == index)
			{
				return;
			}
			GameSettingsManager.Instance.HandleValueChange(menuData.FunctionId, index, EGameSettingsApplyReason.WhenUi);
			MenuModel.Instance.IsEdited = true;
		}

		// Token: 0x0602C21B RID: 180763 RVA: 0x00C65416 File Offset: 0x00C63616
		public override int GetDefaultIndex(MenuData menuData)
		{
			return MenuController.Instance.GetTargetConfig(menuData.FunctionId);
		}
	}
}
