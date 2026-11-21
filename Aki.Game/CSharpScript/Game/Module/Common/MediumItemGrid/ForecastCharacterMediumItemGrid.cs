using System;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02004B3E RID: 19262
	public class ForecastCharacterMediumItemGrid : MediumItemGridBase
	{
		// Token: 0x17006083 RID: 24707
		// (get) Token: 0x060302D2 RID: 197330 RVA: 0x00D6F285 File Offset: 0x00D6D485
		public override EMediumItemGridType Type
		{
			get
			{
				return EMediumItemGridType.ForecastCharacter;
			}
		}

		// Token: 0x040198B2 RID: 104626
		public ERoleDevelopHotRoleTag? RoleDevTag;
	}
}
