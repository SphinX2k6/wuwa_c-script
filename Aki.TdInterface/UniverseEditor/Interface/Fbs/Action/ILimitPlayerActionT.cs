using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070C2 RID: 28866
	public class ILimitPlayerActionT
	{
		// Token: 0x1700D376 RID: 54134
		// (get) Token: 0x0603220B RID: 205323 RVA: 0x006C88C2 File Offset: 0x006C6AC2
		// (set) Token: 0x0603220C RID: 205324 RVA: 0x006C88CA File Offset: 0x006C6ACA
		public ELimitPlayOperation Type { get; set; }

		// Token: 0x0603220D RID: 205325 RVA: 0x006C88D3 File Offset: 0x006C6AD3
		public ILimitPlayerActionT()
		{
			this.Type = ELimitPlayOperation.AllowCamera;
		}
	}
}
