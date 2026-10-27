using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FD5 RID: 28629
	public class ISetCameraModeT
	{
		// Token: 0x1700D48B RID: 54411
		// (get) Token: 0x060329AD RID: 207277 RVA: 0x006D3EAD File Offset: 0x006D20AD
		// (set) Token: 0x060329AE RID: 207278 RVA: 0x006D3EB5 File Offset: 0x006D20B5
		public string Mode { get; set; }

		// Token: 0x060329AF RID: 207279 RVA: 0x006D3EBE File Offset: 0x006D20BE
		public ISetCameraModeT()
		{
			this.Mode = null;
		}
	}
}
