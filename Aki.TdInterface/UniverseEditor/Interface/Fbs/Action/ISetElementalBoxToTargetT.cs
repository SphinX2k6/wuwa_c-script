using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FDB RID: 28635
	public class ISetElementalBoxToTargetT
	{
		// Token: 0x1700D49A RID: 54426
		// (get) Token: 0x060329F2 RID: 207346 RVA: 0x006D47E7 File Offset: 0x006D29E7
		// (set) Token: 0x060329F3 RID: 207347 RVA: 0x006D47EF File Offset: 0x006D29EF
		public int ElementalBoxId { get; set; }

		// Token: 0x1700D49B RID: 54427
		// (get) Token: 0x060329F4 RID: 207348 RVA: 0x006D47F8 File Offset: 0x006D29F8
		// (set) Token: 0x060329F5 RID: 207349 RVA: 0x006D4800 File Offset: 0x006D2A00
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x060329F6 RID: 207350 RVA: 0x006D4809 File Offset: 0x006D2A09
		public ISetElementalBoxToTargetT()
		{
			this.ElementalBoxId = 0;
			this.Target = null;
		}
	}
}
