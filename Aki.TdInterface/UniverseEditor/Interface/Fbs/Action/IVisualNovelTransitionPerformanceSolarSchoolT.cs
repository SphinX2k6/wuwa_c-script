using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075F0 RID: 30192
	public class IVisualNovelTransitionPerformanceSolarSchoolT
	{
		// Token: 0x1700E557 RID: 58711
		// (get) Token: 0x06036FEE RID: 225262 RVA: 0x0077654B File Offset: 0x0077474B
		// (set) Token: 0x06036FEF RID: 225263 RVA: 0x00776553 File Offset: 0x00774753
		public EVisualNovelSubType Type { get; set; }

		// Token: 0x1700E558 RID: 58712
		// (get) Token: 0x06036FF0 RID: 225264 RVA: 0x0077655C File Offset: 0x0077475C
		// (set) Token: 0x06036FF1 RID: 225265 RVA: 0x00776564 File Offset: 0x00774764
		public TVisualNovelTransitionConfigUnion TransitionConfig { get; set; }

		// Token: 0x06036FF2 RID: 225266 RVA: 0x0077656D File Offset: 0x0077476D
		public IVisualNovelTransitionPerformanceSolarSchoolT()
		{
			this.Type = EVisualNovelSubType.SolarSchool;
			this.TransitionConfig = null;
		}
	}
}
