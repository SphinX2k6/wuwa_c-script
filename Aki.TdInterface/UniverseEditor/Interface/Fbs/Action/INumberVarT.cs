using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007350 RID: 29520
	public class INumberVarT
	{
		// Token: 0x1700D86A RID: 55402
		// (get) Token: 0x060337E6 RID: 210918 RVA: 0x006F0B57 File Offset: 0x006EED57
		// (set) Token: 0x060337E7 RID: 210919 RVA: 0x006F0B5F File Offset: 0x006EED5F
		public string Name { get; set; }

		// Token: 0x1700D86B RID: 55403
		// (get) Token: 0x060337E8 RID: 210920 RVA: 0x006F0B68 File Offset: 0x006EED68
		// (set) Token: 0x060337E9 RID: 210921 RVA: 0x006F0B70 File Offset: 0x006EED70
		public float Value { get; set; }

		// Token: 0x060337EA RID: 210922 RVA: 0x006F0B79 File Offset: 0x006EED79
		public INumberVarT()
		{
			this.Name = null;
			this.Value = 0f;
		}
	}
}
