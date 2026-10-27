using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F97 RID: 28567
	public class ISetAlertValueTypeT
	{
		// Token: 0x1700D42D RID: 54317
		// (get) Token: 0x060327CD RID: 206797 RVA: 0x006D09AA File Offset: 0x006CEBAA
		// (set) Token: 0x060327CE RID: 206798 RVA: 0x006D09B2 File Offset: 0x006CEBB2
		public EValueChangeType Type { get; set; }

		// Token: 0x060327CF RID: 206799 RVA: 0x006D09BB File Offset: 0x006CEBBB
		public ISetAlertValueTypeT()
		{
			this.Type = EValueChangeType.AddOrSub;
		}
	}
}
