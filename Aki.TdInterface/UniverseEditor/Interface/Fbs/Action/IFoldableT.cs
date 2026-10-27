using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006850 RID: 26704
	public class IFoldableT
	{
		// Token: 0x1700C658 RID: 50776
		// (get) Token: 0x0602E8F7 RID: 190711 RVA: 0x0065A208 File Offset: 0x00658408
		// (set) Token: 0x0602E8F8 RID: 190712 RVA: 0x0065A210 File Offset: 0x00658410
		public bool _Folded { get; set; }

		// Token: 0x1700C659 RID: 50777
		// (get) Token: 0x0602E8F9 RID: 190713 RVA: 0x0065A219 File Offset: 0x00658419
		// (set) Token: 0x0602E8FA RID: 190714 RVA: 0x0065A221 File Offset: 0x00658421
		public byte NullMask { get; set; }

		// Token: 0x0602E8FB RID: 190715 RVA: 0x0065A22A File Offset: 0x0065842A
		public IFoldableT()
		{
			this._Folded = false;
			this.NullMask = 0;
		}
	}
}
