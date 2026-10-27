using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x0200665C RID: 26204
	[NullableContext(1)]
	public interface IEncircleArgs
	{
		// Token: 0x1700962A RID: 38442
		// (get) Token: 0x06041ACB RID: 269003
		// (set) Token: 0x06041ACC RID: 269004
		Dictionary<int, IHexData> Hexes { get; set; }

		// Token: 0x1700962B RID: 38443
		// (get) Token: 0x06041ACD RID: 269005
		// (set) Token: 0x06041ACE RID: 269006
		int Height { get; set; }

		// Token: 0x1700962C RID: 38444
		// (get) Token: 0x06041ACF RID: 269007
		// (set) Token: 0x06041AD0 RID: 269008
		int Width { get; set; }
	}
}
