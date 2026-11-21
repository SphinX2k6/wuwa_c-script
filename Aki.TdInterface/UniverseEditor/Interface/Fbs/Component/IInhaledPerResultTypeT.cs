using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200599A RID: 22938
	public class IInhaledPerResultTypeT
	{
		// Token: 0x1700A698 RID: 42648
		// (get) Token: 0x06025663 RID: 153187 RVA: 0x00521AD2 File Offset: 0x0051FCD2
		// (set) Token: 0x06025664 RID: 153188 RVA: 0x00521ADA File Offset: 0x0051FCDA
		public EInhaledPerResultType Type { get; set; }

		// Token: 0x06025665 RID: 153189 RVA: 0x00521AE3 File Offset: 0x0051FCE3
		public IInhaledPerResultTypeT()
		{
			this.Type = EInhaledPerResultType.DestroySelf;
		}
	}
}
