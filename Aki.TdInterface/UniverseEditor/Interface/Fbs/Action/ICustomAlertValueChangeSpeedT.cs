using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B64 RID: 27492
	public class ICustomAlertValueChangeSpeedT
	{
		// Token: 0x1700C9CE RID: 51662
		// (get) Token: 0x0602F4F9 RID: 193785 RVA: 0x0067529C File Offset: 0x0067349C
		// (set) Token: 0x0602F4FA RID: 193786 RVA: 0x006752A4 File Offset: 0x006734A4
		public EValueChangeType Type { get; set; }

		// Token: 0x1700C9CF RID: 51663
		// (get) Token: 0x0602F4FB RID: 193787 RVA: 0x006752AD File Offset: 0x006734AD
		// (set) Token: 0x0602F4FC RID: 193788 RVA: 0x006752B5 File Offset: 0x006734B5
		public float CustomValue { get; set; }

		// Token: 0x0602F4FD RID: 193789 RVA: 0x006752BE File Offset: 0x006734BE
		public ICustomAlertValueChangeSpeedT()
		{
			this.Type = EValueChangeType.AddOrSub;
			this.CustomValue = 0f;
		}
	}
}
