using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063D7 RID: 25559
	public class IClientModifyTargetT
	{
		// Token: 0x1700BE67 RID: 48743
		// (get) Token: 0x0602C363 RID: 181091 RVA: 0x00611ADA File Offset: 0x0060FCDA
		// (set) Token: 0x0602C364 RID: 181092 RVA: 0x00611AE2 File Offset: 0x0060FCE2
		public EClientModifyTargetType Type { get; set; }

		// Token: 0x0602C365 RID: 181093 RVA: 0x00611AEB File Offset: 0x0060FCEB
		public IClientModifyTargetT()
		{
			this.Type = EClientModifyTargetType.Self;
		}
	}
}
