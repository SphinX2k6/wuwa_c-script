using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FFF RID: 28671
	public class ISetHeadIconVisibleT
	{
		// Token: 0x1700D4F7 RID: 54519
		// (get) Token: 0x06032B75 RID: 207733 RVA: 0x006D7DAB File Offset: 0x006D5FAB
		// (set) Token: 0x06032B76 RID: 207734 RVA: 0x006D7DB3 File Offset: 0x006D5FB3
		public THeadStyleUnion HeadStyleConfig { get; set; }

		// Token: 0x1700D4F8 RID: 54520
		// (get) Token: 0x06032B77 RID: 207735 RVA: 0x006D7DBC File Offset: 0x006D5FBC
		// (set) Token: 0x06032B78 RID: 207736 RVA: 0x006D7DC4 File Offset: 0x006D5FC4
		public bool Visible { get; set; }

		// Token: 0x06032B79 RID: 207737 RVA: 0x006D7DCD File Offset: 0x006D5FCD
		public ISetHeadIconVisibleT()
		{
			this.HeadStyleConfig = null;
			this.Visible = false;
		}
	}
}
