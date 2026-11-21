using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02003005 RID: 12293
	[NullableContext(1)]
	public interface IHexData
	{
		// Token: 0x17002E52 RID: 11858
		// (get) Token: 0x0601D2D7 RID: 119511
		// (set) Token: 0x0601D2D8 RID: 119512
		IHexPos HexPos { get; set; }

		// Token: 0x17002E53 RID: 11859
		// (get) Token: 0x0601D2D9 RID: 119513
		// (set) Token: 0x0601D2DA RID: 119514
		EncircleHexType Type { get; set; }

		// Token: 0x17002E54 RID: 11860
		// (get) Token: 0x0601D2DB RID: 119515
		// (set) Token: 0x0601D2DC RID: 119516
		int MapId { get; set; }
	}
}
