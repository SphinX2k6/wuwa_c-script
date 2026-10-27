using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BFE RID: 27646
	public class IOpenGiantDeliveryWithReturnT
	{
		// Token: 0x1700CD95 RID: 52629
		// (get) Token: 0x060309A4 RID: 199076 RVA: 0x00699095 File Offset: 0x00697295
		// (set) Token: 0x060309A5 RID: 199077 RVA: 0x0069909D File Offset: 0x0069729D
		public ESystemType Type { get; set; }

		// Token: 0x1700CD96 RID: 52630
		// (get) Token: 0x060309A6 RID: 199078 RVA: 0x006990A6 File Offset: 0x006972A6
		// (set) Token: 0x060309A7 RID: 199079 RVA: 0x006990AE File Offset: 0x006972AE
		public EGiantEcoType EcoType { get; set; }

		// Token: 0x1700CD97 RID: 52631
		// (get) Token: 0x060309A8 RID: 199080 RVA: 0x006990B7 File Offset: 0x006972B7
		// (set) Token: 0x060309A9 RID: 199081 RVA: 0x006990BF File Offset: 0x006972BF
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x060309AA RID: 199082 RVA: 0x006990C8 File Offset: 0x006972C8
		public IOpenGiantDeliveryWithReturnT()
		{
			this.Type = ESystemType.Shop;
			this.EcoType = EGiantEcoType.Fire;
			this.ReturnVar = null;
		}
	}
}
