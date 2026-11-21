using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055C0 RID: 21952
	public class ICustomPrimitiveMappingT
	{
		// Token: 0x17009D2C RID: 40236
		// (get) Token: 0x06022ECF RID: 143055 RVA: 0x004CEF3F File Offset: 0x004CD13F
		// (set) Token: 0x06022ED0 RID: 143056 RVA: 0x004CEF47 File Offset: 0x004CD147
		public string KeyPrefix { get; set; }

		// Token: 0x17009D2D RID: 40237
		// (get) Token: 0x06022ED1 RID: 143057 RVA: 0x004CEF50 File Offset: 0x004CD150
		// (set) Token: 0x06022ED2 RID: 143058 RVA: 0x004CEF58 File Offset: 0x004CD158
		public int Index { get; set; }

		// Token: 0x06022ED3 RID: 143059 RVA: 0x004CEF61 File Offset: 0x004CD161
		public ICustomPrimitiveMappingT()
		{
			this.KeyPrefix = null;
			this.Index = 0;
		}
	}
}
