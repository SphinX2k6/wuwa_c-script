using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B25 RID: 27429
	public class IMotorParkourTrackingEventT
	{
		// Token: 0x1700CBDC RID: 52188
		// (get) Token: 0x06030255 RID: 197205 RVA: 0x0068B5E5 File Offset: 0x006897E5
		// (set) Token: 0x06030256 RID: 197206 RVA: 0x0068B5ED File Offset: 0x006897ED
		public ETrackingEventType Type { get; set; }

		// Token: 0x1700CBDD RID: 52189
		// (get) Token: 0x06030257 RID: 197207 RVA: 0x0068B5F6 File Offset: 0x006897F6
		// (set) Token: 0x06030258 RID: 197208 RVA: 0x0068B5FE File Offset: 0x006897FE
		public EMotorParkourPhase MotorParkourPhase { get; set; }

		// Token: 0x1700CBDE RID: 52190
		// (get) Token: 0x06030259 RID: 197209 RVA: 0x0068B607 File Offset: 0x00689807
		// (set) Token: 0x0603025A RID: 197210 RVA: 0x0068B60F File Offset: 0x0068980F
		public TVarRefUnion MotorParkourScoreVarRef { get; set; }

		// Token: 0x0603025B RID: 197211 RVA: 0x0068B618 File Offset: 0x00689818
		public IMotorParkourTrackingEventT()
		{
			this.Type = ETrackingEventType.EasterEgg;
			this.MotorParkourPhase = EMotorParkourPhase.Start;
			this.MotorParkourScoreVarRef = null;
		}
	}
}
