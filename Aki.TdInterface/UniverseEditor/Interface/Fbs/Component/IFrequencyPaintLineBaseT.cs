using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005851 RID: 22609
	public class IFrequencyPaintLineBaseT
	{
		// Token: 0x1700A3C5 RID: 41925
		// (get) Token: 0x06024A1F RID: 150047 RVA: 0x0050877A File Offset: 0x0050697A
		// (set) Token: 0x06024A20 RID: 150048 RVA: 0x00508782 File Offset: 0x00506982
		public EFrequencyPaintLineType Type { get; set; }

		// Token: 0x06024A21 RID: 150049 RVA: 0x0050878B File Offset: 0x0050698B
		public IFrequencyPaintLineBaseT()
		{
			this.Type = EFrequencyPaintLineType.Straight;
		}
	}
}
