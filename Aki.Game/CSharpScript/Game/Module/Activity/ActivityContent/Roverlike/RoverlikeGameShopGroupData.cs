using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006155 RID: 24917
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeGameShopGroupData : IRoverlikeGameShopGroupData
	{
		// Token: 0x170091AF RID: 37295
		// (get) Token: 0x0603EFBA RID: 257978 RVA: 0x00F37164 File Offset: 0x00F35364
		// (set) Token: 0x0603EFBB RID: 257979 RVA: 0x00F3716C File Offset: 0x00F3536C
		public ERoverlikeGameShopItemType GroupType { get; set; }

		// Token: 0x170091B0 RID: 37296
		// (get) Token: 0x0603EFBC RID: 257980 RVA: 0x00F37175 File Offset: 0x00F35375
		// (set) Token: 0x0603EFBD RID: 257981 RVA: 0x00F3717D File Offset: 0x00F3537D
		public string TitleTextKey { get; set; }

		// Token: 0x170091B1 RID: 37297
		// (get) Token: 0x0603EFBE RID: 257982 RVA: 0x00F37186 File Offset: 0x00F35386
		// (set) Token: 0x0603EFBF RID: 257983 RVA: 0x00F3718E File Offset: 0x00F3538E
		public List<IRoverlikeGameShopGridData> Grids { get; set; }
	}
}
