using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C8A RID: 15498
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleDevDefine : IStaticVariableResetter
	{
		// Token: 0x06027A46 RID: 162374 RVA: 0x00B1A3D3 File Offset: 0x00B185D3
		static RoleDevDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoleDevDefine.CreateStaticDefaultValue), new Action(RoleDevDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06027A47 RID: 162375 RVA: 0x00B1A3F2 File Offset: 0x00B185F2
		public static void ResetStaticDefaultValue()
		{
			RoleDevDefine.tabTypeToMainPageMap = null;
			RoleDevDefine.roleTabMaterialTypeToSubPageButtonMap = null;
			RoleDevDefine.weaponTabMaterialTypeToSubPageButtonMap = null;
			RoleDevDefine.skillTabMaterialTypeToSubPageButtonMap = null;
		}

		// Token: 0x06027A48 RID: 162376 RVA: 0x00B1A40C File Offset: 0x00B1860C
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

		// Token: 0x040159FE RID: 88574
		public static Dictionary<ERoleDevTabType, ERoleDevMainPage> tabTypeToMainPageMap;

		// Token: 0x040159FF RID: 88575
		public static Dictionary<EItemMaterialType, ERoleDevSubPageButton> roleTabMaterialTypeToSubPageButtonMap;

		// Token: 0x04015A00 RID: 88576
		public static Dictionary<EItemMaterialType, ERoleDevSubPageButton> weaponTabMaterialTypeToSubPageButtonMap;

		// Token: 0x04015A01 RID: 88577
		public static Dictionary<EItemMaterialType, ERoleDevSubPageButton> skillTabMaterialTypeToSubPageButtonMap;
	}
}
