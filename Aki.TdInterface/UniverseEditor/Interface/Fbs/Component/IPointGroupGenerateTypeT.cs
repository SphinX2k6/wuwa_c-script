using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005761 RID: 22369
	public class IPointGroupGenerateTypeT
	{
		// Token: 0x1700A6DD RID: 42717
		// (get) Token: 0x060257D3 RID: 153555 RVA: 0x0052C13A File Offset: 0x0052A33A
		// (set) Token: 0x060257D4 RID: 153556 RVA: 0x0052C142 File Offset: 0x0052A342
		public EPointGroupGenerateType Type { get; set; }

		// Token: 0x060257D5 RID: 153557 RVA: 0x0052C14B File Offset: 0x0052A34B
		public IPointGroupGenerateTypeT()
		{
			this.Type = EPointGroupGenerateType.Layer;
		}
	}
}
