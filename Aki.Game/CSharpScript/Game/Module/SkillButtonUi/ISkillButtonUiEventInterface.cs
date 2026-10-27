using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Battle;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02004BFD RID: 19453
	[NullableContext(1)]
	public interface ISkillButtonUiEventInterface
	{
		// Token: 0x060324D8 RID: 206040 RVA: 0x00BB05C5 File Offset: 0x00BAE7C5
		void EquipExplorePhantomSkill()
		{
		}

		// Token: 0x060324D9 RID: 206041 RVA: 0x00BB05C7 File Offset: 0x00BAE7C7
		void SkillCountChanged(GroupSkillCdInfo groupSkillCdInfo)
		{
		}

		// Token: 0x060324DA RID: 206042 RVA: 0x00BB05C9 File Offset: 0x00BAE7C9
		void SkillRemainCdChanged(GroupSkillCdInfo groupSkillCdInfo)
		{
		}
	}
}
