using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C3D RID: 19517
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMainTabItemData : ISheriffMainTabItemData
	{
		// Token: 0x17007CAD RID: 31917
		// (get) Token: 0x060327C9 RID: 206793 RVA: 0x00BC31C2 File Offset: 0x00BC13C2
		// (set) Token: 0x060327CA RID: 206794 RVA: 0x00BC31CA File Offset: 0x00BC13CA
		public ESheriffMainTabType TabType { get; set; }

		// Token: 0x17007CAE RID: 31918
		// (get) Token: 0x060327CB RID: 206795 RVA: 0x00BC31D3 File Offset: 0x00BC13D3
		// (set) Token: 0x060327CC RID: 206796 RVA: 0x00BC31DB File Offset: 0x00BC13DB
		public string TabIcon { get; set; } = "";

		// Token: 0x17007CAF RID: 31919
		// (get) Token: 0x060327CD RID: 206797 RVA: 0x00BC31E4 File Offset: 0x00BC13E4
		// (set) Token: 0x060327CE RID: 206798 RVA: 0x00BC31EC File Offset: 0x00BC13EC
		public string TabTxt { get; set; } = "";

		// Token: 0x17007CB0 RID: 31920
		// (get) Token: 0x060327CF RID: 206799 RVA: 0x00BC31F5 File Offset: 0x00BC13F5
		// (set) Token: 0x060327D0 RID: 206800 RVA: 0x00BC31FD File Offset: 0x00BC13FD
		public bool? IsLock { get; set; }

		// Token: 0x17007CB1 RID: 31921
		// (get) Token: 0x060327D1 RID: 206801 RVA: 0x00BC3206 File Offset: 0x00BC1406
		// (set) Token: 0x060327D2 RID: 206802 RVA: 0x00BC320E File Offset: 0x00BC140E
		public EFunctionType FunctionType { get; set; }
	}
}
