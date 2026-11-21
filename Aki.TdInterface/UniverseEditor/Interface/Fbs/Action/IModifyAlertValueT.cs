using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071ED RID: 29165
	public class IModifyAlertValueT
	{
		// Token: 0x1700D583 RID: 54659
		// (get) Token: 0x06032BD2 RID: 207826 RVA: 0x006DAA93 File Offset: 0x006D8C93
		// (set) Token: 0x06032BD3 RID: 207827 RVA: 0x006DAA9B File Offset: 0x006D8C9B
		public EAlertSystemOption Type { get; set; }

		// Token: 0x1700D584 RID: 54660
		// (get) Token: 0x06032BD4 RID: 207828 RVA: 0x006DAAA4 File Offset: 0x006D8CA4
		// (set) Token: 0x06032BD5 RID: 207829 RVA: 0x006DAAAC File Offset: 0x006D8CAC
		public int AreaId { get; set; }

		// Token: 0x1700D585 RID: 54661
		// (get) Token: 0x06032BD6 RID: 207830 RVA: 0x006DAAB5 File Offset: 0x006D8CB5
		// (set) Token: 0x06032BD7 RID: 207831 RVA: 0x006DAABD File Offset: 0x006D8CBD
		public TSetAlertValueTypeUnion SetType { get; set; }

		// Token: 0x1700D586 RID: 54662
		// (get) Token: 0x06032BD8 RID: 207832 RVA: 0x006DAAC6 File Offset: 0x006D8CC6
		// (set) Token: 0x06032BD9 RID: 207833 RVA: 0x006DAACE File Offset: 0x006D8CCE
		public TAlertValueChangeSpeedUnion ChangeSpeed { get; set; }

		// Token: 0x06032BDA RID: 207834 RVA: 0x006DAAD7 File Offset: 0x006D8CD7
		public IModifyAlertValueT()
		{
			this.Type = EAlertSystemOption.EnableAlertArea;
			this.AreaId = 0;
			this.SetType = null;
			this.ChangeSpeed = null;
		}
	}
}
