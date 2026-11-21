using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200585A RID: 22618
	public class IFrequencyPaintStrokeLineT
	{
		// Token: 0x1700A3CD RID: 41933
		// (get) Token: 0x06024A55 RID: 150101 RVA: 0x00508C32 File Offset: 0x00506E32
		// (set) Token: 0x06024A56 RID: 150102 RVA: 0x00508C3A File Offset: 0x00506E3A
		public EFrequencyPaintLineType Type { get; set; }

		// Token: 0x06024A57 RID: 150103 RVA: 0x00508C43 File Offset: 0x00506E43
		public IFrequencyPaintStrokeLineT()
		{
			this.Type = EFrequencyPaintLineType.Straight;
		}
	}
}
