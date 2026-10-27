using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x0200665D RID: 26205
	[NullableContext(1)]
	[Nullable(0)]
	public class EncircleArgs : IEncircleArgs
	{
		// Token: 0x1700962D RID: 38445
		// (get) Token: 0x06041AD1 RID: 269009 RVA: 0x00FED6FF File Offset: 0x00FEB8FF
		// (set) Token: 0x06041AD2 RID: 269010 RVA: 0x00FED707 File Offset: 0x00FEB907
		public Dictionary<int, IHexData> Hexes { get; set; }

		// Token: 0x1700962E RID: 38446
		// (get) Token: 0x06041AD3 RID: 269011 RVA: 0x00FED710 File Offset: 0x00FEB910
		// (set) Token: 0x06041AD4 RID: 269012 RVA: 0x00FED718 File Offset: 0x00FEB918
		public int Height { get; set; }

		// Token: 0x1700962F RID: 38447
		// (get) Token: 0x06041AD5 RID: 269013 RVA: 0x00FED721 File Offset: 0x00FEB921
		// (set) Token: 0x06041AD6 RID: 269014 RVA: 0x00FED729 File Offset: 0x00FEB929
		public int Width { get; set; }
	}
}
