using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007446 RID: 29766
	public class ITransitionPopupConfigT
	{
		// Token: 0x1700E1FC RID: 57852
		// (get) Token: 0x06036137 RID: 221495 RVA: 0x0075AD15 File Offset: 0x00758F15
		// (set) Token: 0x06036138 RID: 221496 RVA: 0x0075AD1D File Offset: 0x00758F1D
		public float Duration { get; set; }

		// Token: 0x1700E1FD RID: 57853
		// (get) Token: 0x06036139 RID: 221497 RVA: 0x0075AD26 File Offset: 0x00758F26
		// (set) Token: 0x0603613A RID: 221498 RVA: 0x0075AD2E File Offset: 0x00758F2E
		public TTransitionPopupStyleUnion PopupStyle { get; set; }

		// Token: 0x1700E1FE RID: 57854
		// (get) Token: 0x0603613B RID: 221499 RVA: 0x0075AD37 File Offset: 0x00758F37
		// (set) Token: 0x0603613C RID: 221500 RVA: 0x0075AD3F File Offset: 0x00758F3F
		public byte NullMask { get; set; }

		// Token: 0x0603613D RID: 221501 RVA: 0x0075AD48 File Offset: 0x00758F48
		public ITransitionPopupConfigT()
		{
			this.Duration = 0f;
			this.PopupStyle = null;
			this.NullMask = 0;
		}
	}
}
