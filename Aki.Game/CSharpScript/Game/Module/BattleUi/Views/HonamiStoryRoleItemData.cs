using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D37 RID: 19767
	public class HonamiStoryRoleItemData
	{
		// Token: 0x0401A44A RID: 107594
		public int RoleId;

		// Token: 0x0401A44B RID: 107595
		public int ItemSubType;

		// Token: 0x0401A44C RID: 107596
		public bool BuffActive;

		// Token: 0x0401A44D RID: 107597
		[Nullable(2)]
		public List<int> SuitIdList;

		// Token: 0x0401A44E RID: 107598
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<HonamiStoryWeaponSuitActiveData> SuitDataList;
	}
}
