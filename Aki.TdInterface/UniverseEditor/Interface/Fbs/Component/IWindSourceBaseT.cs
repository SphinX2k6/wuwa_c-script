using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006197 RID: 24983
	public class IWindSourceBaseT
	{
		// Token: 0x1700BA53 RID: 47699
		// (get) Token: 0x0602A769 RID: 173929 RVA: 0x005CADB2 File Offset: 0x005C8FB2
		// (set) Token: 0x0602A76A RID: 173930 RVA: 0x005CADBA File Offset: 0x005C8FBA
		public EWindSourceType Type { get; set; }

		// Token: 0x0602A76B RID: 173931 RVA: 0x005CADC3 File Offset: 0x005C8FC3
		public IWindSourceBaseT()
		{
			this.Type = EWindSourceType.Directional;
		}
	}
}
