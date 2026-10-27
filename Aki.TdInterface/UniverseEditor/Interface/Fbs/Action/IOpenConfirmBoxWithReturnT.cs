using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BF8 RID: 27640
	public class IOpenConfirmBoxWithReturnT
	{
		// Token: 0x1700CD87 RID: 52615
		// (get) Token: 0x06030962 RID: 199010 RVA: 0x0069865D File Offset: 0x0069685D
		// (set) Token: 0x06030963 RID: 199011 RVA: 0x00698665 File Offset: 0x00696865
		public ESystemType Type { get; set; }

		// Token: 0x1700CD88 RID: 52616
		// (get) Token: 0x06030964 RID: 199012 RVA: 0x0069866E File Offset: 0x0069686E
		// (set) Token: 0x06030965 RID: 199013 RVA: 0x00698676 File Offset: 0x00696876
		public int Id { get; set; }

		// Token: 0x1700CD89 RID: 52617
		// (get) Token: 0x06030966 RID: 199014 RVA: 0x0069867F File Offset: 0x0069687F
		// (set) Token: 0x06030967 RID: 199015 RVA: 0x00698687 File Offset: 0x00696887
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x06030968 RID: 199016 RVA: 0x00698690 File Offset: 0x00696890
		public IOpenConfirmBoxWithReturnT()
		{
			this.Type = ESystemType.Shop;
			this.Id = 0;
			this.ReturnVar = null;
		}
	}
}
