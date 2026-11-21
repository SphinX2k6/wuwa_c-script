using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DAA RID: 15786
	public class TeamRoleGridRoguelike : TeamRoleGridBase
	{
		// Token: 0x060285BF RID: 165311 RVA: 0x00B4F45C File Offset: 0x00B4D65C
		[NullableContext(1)]
		protected override CharacterMediumItemGrid GetRoleParameters(CharacterMediumItemGrid baseParameter, RoleDataBase data)
		{
			int roleShowLevel = RoguelikeModel.Instance.GetEntranceViewModel().RoleShowLevel;
			int level = data.GetLevelData().GetLevel();
			if (roleShowLevel > level)
			{
				baseParameter.BottomTextId = null;
				baseParameter.BottomTextParameter = null;
				baseParameter.AddLevel = new int?(roleShowLevel);
			}
			return baseParameter;
		}
	}
}
