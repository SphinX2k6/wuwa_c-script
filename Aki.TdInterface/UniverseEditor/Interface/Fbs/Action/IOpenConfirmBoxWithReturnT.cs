using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200735C RID: 29532
	public class IOpenConfirmBoxWithReturnT
	{
		// Token: 0x1700D895 RID: 55445
		// (get) Token: 0x06033882 RID: 211074 RVA: 0x006F1FF1 File Offset: 0x006F01F1
		// (set) Token: 0x06033883 RID: 211075 RVA: 0x006F1FF9 File Offset: 0x006F01F9
		public ESystemType Type { get; set; }

		// Token: 0x1700D896 RID: 55446
		// (get) Token: 0x06033884 RID: 211076 RVA: 0x006F2002 File Offset: 0x006F0202
		// (set) Token: 0x06033885 RID: 211077 RVA: 0x006F200A File Offset: 0x006F020A
		public int Id { get; set; }

		// Token: 0x1700D897 RID: 55447
		// (get) Token: 0x06033886 RID: 211078 RVA: 0x006F2013 File Offset: 0x006F0213
		// (set) Token: 0x06033887 RID: 211079 RVA: 0x006F201B File Offset: 0x006F021B
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x06033888 RID: 211080 RVA: 0x006F2024 File Offset: 0x006F0224
		public IOpenConfirmBoxWithReturnT()
		{
			this.Type = ESystemType.Shop;
			this.Id = 0;
			this.ReturnVar = null;
		}
	}
}
