using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A1B RID: 23067
	public class IItemFoundation2T
	{
		// Token: 0x1700A7B0 RID: 42928
		// (get) Token: 0x06025AF6 RID: 154358 RVA: 0x0052A999 File Offset: 0x00528B99
		// (set) Token: 0x06025AF7 RID: 154359 RVA: 0x0052A9A1 File Offset: 0x00528BA1
		public bool Disabled { get; set; }

		// Token: 0x1700A7B1 RID: 42929
		// (get) Token: 0x06025AF8 RID: 154360 RVA: 0x0052A9AA File Offset: 0x00528BAA
		// (set) Token: 0x06025AF9 RID: 154361 RVA: 0x0052A9B2 File Offset: 0x00528BB2
		public TItemFoundationUnion Config { get; set; }

		// Token: 0x1700A7B2 RID: 42930
		// (get) Token: 0x06025AFA RID: 154362 RVA: 0x0052A9BB File Offset: 0x00528BBB
		// (set) Token: 0x06025AFB RID: 154363 RVA: 0x0052A9C3 File Offset: 0x00528BC3
		public byte NullMask { get; set; }

		// Token: 0x06025AFC RID: 154364 RVA: 0x0052A9CC File Offset: 0x00528BCC
		public IItemFoundation2T()
		{
			this.Disabled = false;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
