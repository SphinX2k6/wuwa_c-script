using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D55 RID: 23893
	public class HonamiStoryRoleItemData
	{
		// Token: 0x0401F991 RID: 129425
		public int RoleId;

		// Token: 0x0401F992 RID: 129426
		public int ItemSubType;

		// Token: 0x0401F993 RID: 129427
		public bool BuffActive;

		// Token: 0x0401F994 RID: 129428
		[Nullable(2)]
		public List<int> SuitIdList;

		// Token: 0x0401F995 RID: 129429
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<HonamiStoryWeaponSuitActiveData> SuitDataList;
	}
}
