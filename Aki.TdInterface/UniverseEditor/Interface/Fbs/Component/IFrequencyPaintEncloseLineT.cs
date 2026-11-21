using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200584E RID: 22606
	public class IFrequencyPaintEncloseLineT
	{
		// Token: 0x1700A3C2 RID: 41922
		// (get) Token: 0x06024A0D RID: 150029 RVA: 0x00508602 File Offset: 0x00506802
		// (set) Token: 0x06024A0E RID: 150030 RVA: 0x0050860A File Offset: 0x0050680A
		public EFrequencyPaintLineType Type { get; set; }

		// Token: 0x06024A0F RID: 150031 RVA: 0x00508613 File Offset: 0x00506813
		public IFrequencyPaintEncloseLineT()
		{
			this.Type = EFrequencyPaintLineType.Straight;
		}
	}
}
