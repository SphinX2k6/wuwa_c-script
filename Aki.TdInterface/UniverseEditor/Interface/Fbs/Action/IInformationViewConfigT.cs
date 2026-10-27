using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006946 RID: 26950
	public class IInformationViewConfigT
	{
		// Token: 0x1700C7F2 RID: 51186
		// (get) Token: 0x0602F0F2 RID: 192754 RVA: 0x0066A0FC File Offset: 0x006682FC
		// (set) Token: 0x0602F0F3 RID: 192755 RVA: 0x0066A104 File Offset: 0x00668304
		public int InfoDisplayGroup { get; set; }

		// Token: 0x1700C7F3 RID: 51187
		// (get) Token: 0x0602F0F4 RID: 192756 RVA: 0x0066A10D File Offset: 0x0066830D
		// (set) Token: 0x0602F0F5 RID: 192757 RVA: 0x0066A115 File Offset: 0x00668315
		public byte NullMask { get; set; }

		// Token: 0x0602F0F6 RID: 192758 RVA: 0x0066A11E File Offset: 0x0066831E
		public IInformationViewConfigT()
		{
			this.InfoDisplayGroup = 0;
			this.NullMask = 0;
		}
	}
}
