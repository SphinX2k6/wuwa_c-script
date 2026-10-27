using System;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02005B5F RID: 23391
	public class ForecastCharacterMediumItemGrid : MediumItemGridBase
	{
		// Token: 0x17008CB1 RID: 36017
		// (get) Token: 0x0603B386 RID: 242566 RVA: 0x00E1ED19 File Offset: 0x00E1CF19
		public override EMediumItemGridType Type
		{
			get
			{
				return EMediumItemGridType.ForecastCharacter;
			}
		}

		// Token: 0x0401EE03 RID: 126467
		public ERoleDevelopHotRoleTag? RoleDevTag;
	}
}
