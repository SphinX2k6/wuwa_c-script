using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007203 RID: 29187
	public class ISubScreenConfigT
	{
		// Token: 0x1700D8B4 RID: 55476
		// (get) Token: 0x06033C50 RID: 212048 RVA: 0x006F7D56 File Offset: 0x006F5F56
		// (set) Token: 0x06033C51 RID: 212049 RVA: 0x006F7D5E File Offset: 0x006F5F5E
		public IVector2T Anchor { get; set; }

		// Token: 0x1700D8B5 RID: 55477
		// (get) Token: 0x06033C52 RID: 212050 RVA: 0x006F7D67 File Offset: 0x006F5F67
		// (set) Token: 0x06033C53 RID: 212051 RVA: 0x006F7D6F File Offset: 0x006F5F6F
		public IVector2T Size { get; set; }

		// Token: 0x1700D8B6 RID: 55478
		// (get) Token: 0x06033C54 RID: 212052 RVA: 0x006F7D78 File Offset: 0x006F5F78
		// (set) Token: 0x06033C55 RID: 212053 RVA: 0x006F7D80 File Offset: 0x006F5F80
		public bool IsSeamlessScreen { get; set; }

		// Token: 0x1700D8B7 RID: 55479
		// (get) Token: 0x06033C56 RID: 212054 RVA: 0x006F7D89 File Offset: 0x006F5F89
		// (set) Token: 0x06033C57 RID: 212055 RVA: 0x006F7D91 File Offset: 0x006F5F91
		public byte NullMask { get; set; }

		// Token: 0x06033C58 RID: 212056 RVA: 0x006F7D9A File Offset: 0x006F5F9A
		public ISubScreenConfigT()
		{
			this.Anchor = null;
			this.Size = null;
			this.IsSeamlessScreen = false;
			this.NullMask = 0;
		}
	}
}
