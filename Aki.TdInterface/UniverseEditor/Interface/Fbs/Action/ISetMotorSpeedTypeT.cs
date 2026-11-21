using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077EF RID: 30703
	public class ISetMotorSpeedTypeT
	{
		// Token: 0x1700E10D RID: 57613
		// (get) Token: 0x06035F0D RID: 220941 RVA: 0x00739DAE File Offset: 0x00737FAE
		// (set) Token: 0x06035F0E RID: 220942 RVA: 0x00739DB6 File Offset: 0x00737FB6
		public EMotorSpeedType Type { get; set; }

		// Token: 0x06035F0F RID: 220943 RVA: 0x00739DBF File Offset: 0x00737FBF
		public ISetMotorSpeedTypeT()
		{
			this.Type = EMotorSpeedType.TargetSpeed;
		}
	}
}
