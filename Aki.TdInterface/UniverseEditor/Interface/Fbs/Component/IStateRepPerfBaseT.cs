using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FBB RID: 24507
	public class IStateRepPerfBaseT
	{
		// Token: 0x1700B581 RID: 46465
		// (get) Token: 0x060293C2 RID: 168898 RVA: 0x005A0EA6 File Offset: 0x0059F0A6
		// (set) Token: 0x060293C3 RID: 168899 RVA: 0x005A0EAE File Offset: 0x0059F0AE
		public EStateRepPerfType Type { get; set; }

		// Token: 0x060293C4 RID: 168900 RVA: 0x005A0EB7 File Offset: 0x0059F0B7
		public IStateRepPerfBaseT()
		{
			this.Type = EStateRepPerfType.SkillId;
		}
	}
}
