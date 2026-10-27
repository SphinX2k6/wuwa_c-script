using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007449 RID: 29769
	public class ITransitionPopupLeftBottomTransitionT
	{
		// Token: 0x1700E203 RID: 57859
		// (get) Token: 0x06036155 RID: 221525 RVA: 0x0075B044 File Offset: 0x00759244
		// (set) Token: 0x06036156 RID: 221526 RVA: 0x0075B04C File Offset: 0x0075924C
		public ETransitionPopupStyleType Type { get; set; }

		// Token: 0x1700E204 RID: 57860
		// (get) Token: 0x06036157 RID: 221527 RVA: 0x0075B055 File Offset: 0x00759255
		// (set) Token: 0x06036158 RID: 221528 RVA: 0x0075B05D File Offset: 0x0075925D
		public string TitleText { get; set; }

		// Token: 0x1700E205 RID: 57861
		// (get) Token: 0x06036159 RID: 221529 RVA: 0x0075B066 File Offset: 0x00759266
		// (set) Token: 0x0603615A RID: 221530 RVA: 0x0075B06E File Offset: 0x0075926E
		public string ContentText { get; set; }

		// Token: 0x0603615B RID: 221531 RVA: 0x0075B077 File Offset: 0x00759277
		public ITransitionPopupLeftBottomTransitionT()
		{
			this.Type = ETransitionPopupStyleType.LeftTopTip;
			this.TitleText = null;
			this.ContentText = null;
		}
	}
}
