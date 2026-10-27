using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D8D RID: 28045
	public class IPreloadCharacterTypeT
	{
		// Token: 0x1700D139 RID: 53561
		// (get) Token: 0x060318AD RID: 202925 RVA: 0x006B71AE File Offset: 0x006B53AE
		// (set) Token: 0x060318AE RID: 202926 RVA: 0x006B71B6 File Offset: 0x006B53B6
		public EPreloadObjectType Type { get; set; }

		// Token: 0x060318AF RID: 202927 RVA: 0x006B71BF File Offset: 0x006B53BF
		public IPreloadCharacterTypeT()
		{
			this.Type = EPreloadObjectType.PreloadTrialCharacterForSkill;
		}
	}
}
