using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DE1 RID: 19937
	public class TeamRoleGridRoguelike : TeamRoleGridBase
	{
		// Token: 0x06033754 RID: 210772 RVA: 0x00C05F4C File Offset: 0x00C0414C
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
