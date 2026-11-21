using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D80 RID: 32128
	public class IVisualNovelMainRoleActionConfigBaseT
	{
		// Token: 0x1700F05D RID: 61533
		// (get) Token: 0x06039FFA RID: 237562 RVA: 0x007D1BAE File Offset: 0x007CFDAE
		// (set) Token: 0x06039FFB RID: 237563 RVA: 0x007D1BB6 File Offset: 0x007CFDB6
		public EVisualNovelSubType Type { get; set; }

		// Token: 0x06039FFC RID: 237564 RVA: 0x007D1BBF File Offset: 0x007CFDBF
		public IVisualNovelMainRoleActionConfigBaseT()
		{
			this.Type = EVisualNovelSubType.SolarSchool;
		}
	}
}
