using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02006659 RID: 26201
	[NullableContext(1)]
	[Nullable(0)]
	public class HexData : IHexData
	{
		// Token: 0x17009625 RID: 38437
		// (get) Token: 0x06041ABF RID: 268991 RVA: 0x00FED6AB File Offset: 0x00FEB8AB
		// (set) Token: 0x06041AC0 RID: 268992 RVA: 0x00FED6B3 File Offset: 0x00FEB8B3
		public IHexPos HexPos { get; set; }

		// Token: 0x17009626 RID: 38438
		// (get) Token: 0x06041AC1 RID: 268993 RVA: 0x00FED6BC File Offset: 0x00FEB8BC
		// (set) Token: 0x06041AC2 RID: 268994 RVA: 0x00FED6C4 File Offset: 0x00FEB8C4
		public EncircleHexType Type { get; set; }

		// Token: 0x17009627 RID: 38439
		// (get) Token: 0x06041AC3 RID: 268995 RVA: 0x00FED6CD File Offset: 0x00FEB8CD
		// (set) Token: 0x06041AC4 RID: 268996 RVA: 0x00FED6D5 File Offset: 0x00FEB8D5
		public int MapId { get; set; }
	}
}
