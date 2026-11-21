using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005857 RID: 22615
	public class IFrequencyPaintStraightLineT
	{
		// Token: 0x1700A3CA RID: 41930
		// (get) Token: 0x06024A43 RID: 150083 RVA: 0x00508ABA File Offset: 0x00506CBA
		// (set) Token: 0x06024A44 RID: 150084 RVA: 0x00508AC2 File Offset: 0x00506CC2
		public EFrequencyPaintLineType Type { get; set; }

		// Token: 0x06024A45 RID: 150085 RVA: 0x00508ACB File Offset: 0x00506CCB
		public IFrequencyPaintStraightLineT()
		{
			this.Type = EFrequencyPaintLineType.Straight;
		}
	}
}
