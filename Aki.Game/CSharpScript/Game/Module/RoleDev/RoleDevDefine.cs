using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CD9 RID: 19673
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleDevDefine : IStaticVariableResetter
	{
		// Token: 0x06032C92 RID: 208018 RVA: 0x00BD563B File Offset: 0x00BD383B
		static RoleDevDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoleDevDefine.CreateStaticDefaultValue), new Action(RoleDevDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06032C93 RID: 208019 RVA: 0x00BD565A File Offset: 0x00BD385A
		public static void ResetStaticDefaultValue()
		{
			RoleDevDefine.tabTypeToMainPageMap = null;
			RoleDevDefine.roleTabMaterialTypeToSubPageButtonMap = null;
			RoleDevDefine.weaponTabMaterialTypeToSubPageButtonMap = null;
			RoleDevDefine.skillTabMaterialTypeToSubPageButtonMap = null;
		}

		// Token: 0x06032C94 RID: 208020 RVA: 0x00BD5674 File Offset: 0x00BD3874
		public static void CreateStaticDefaultValue()
		{
			RoleDevDefine.tabTypeToMainPageMap = new Dictionary<ERoleDevTabType, ERoleDevMainPage>
			{
				{
					ERoleDevTabType.Role,
					ERoleDevMainPage.Role
				},
				{
					ERoleDevTabType.Weapon,
					ERoleDevMainPage.Weapon
				},
				{
					ERoleDevTabType.Phantom,
					ERoleDevMainPage.Phantom
				},
				{
					ERoleDevTabType.Skill,
					ERoleDevMainPage.Skill
				}
			};
			RoleDevDefine.roleTabMaterialTypeToSubPageButtonMap = new Dictionary<EItemMaterialType, ERoleDevSubPageButton>
			{
				{
					EItemMaterialType.RoleExp,
					ERoleDevSubPageButton.RoleExpMaterialGo
				},
				{
					EItemMaterialType.RoleBreak,
					ERoleDevSubPageButton.RoleBreakthroughMaterialGo
				},
				{
					EItemMaterialType.Map,
					ERoleDevSubPageButton.RoleMapMaterialGo
				},
				{
					EItemMaterialType.Drop,
					ERoleDevSubPageButton.RoleDropMaterialGo
				}
			};
			RoleDevDefine.weaponTabMaterialTypeToSubPageButtonMap = new Dictionary<EItemMaterialType, ERoleDevSubPageButton>
			{
				{
					EItemMaterialType.WeaponExp,
					ERoleDevSubPageButton.WeaponExpMaterialGo
				},
				{
					EItemMaterialType.WeaponSkill,
					ERoleDevSubPageButton.WeaponSkillMaterialGo
				},
				{
					EItemMaterialType.Drop,
					ERoleDevSubPageButton.WeaponDropMaterialGo
				}
			};
			RoleDevDefine.skillTabMaterialTypeToSubPageButtonMap = new Dictionary<EItemMaterialType, ERoleDevSubPageButton>
			{
				{
					EItemMaterialType.WeaponSkill,
					ERoleDevSubPageButton.SkillWeaponMaterialGo
				},
				{
					EItemMaterialType.Weekly,
					ERoleDevSubPageButton.SkillWeeklyMaterialGo
				},
				{
					EItemMaterialType.Drop,
					ERoleDevSubPageButton.SkillDropMaterialGo
				}
			};
		}

		// Token: 0x0401B09D RID: 110749
		public static Dictionary<ERoleDevTabType, ERoleDevMainPage> tabTypeToMainPageMap;

		// Token: 0x0401B09E RID: 110750
		public static Dictionary<EItemMaterialType, ERoleDevSubPageButton> roleTabMaterialTypeToSubPageButtonMap;

		// Token: 0x0401B09F RID: 110751
		public static Dictionary<EItemMaterialType, ERoleDevSubPageButton> weaponTabMaterialTypeToSubPageButtonMap;

		// Token: 0x0401B0A0 RID: 110752
		public static Dictionary<EItemMaterialType, ERoleDevSubPageButton> skillTabMaterialTypeToSubPageButtonMap;
	}
}
