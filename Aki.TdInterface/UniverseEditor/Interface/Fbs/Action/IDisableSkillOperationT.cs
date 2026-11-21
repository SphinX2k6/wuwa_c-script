using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C66 RID: 27750
	public class IDisableSkillOperationT
	{
		// Token: 0x1700CB8D RID: 52109
		// (get) Token: 0x0602FCCA RID: 195786 RVA: 0x00682804 File Offset: 0x00680A04
		// (set) Token: 0x0602FCCB RID: 195787 RVA: 0x0068280C File Offset: 0x00680A0C
		public ESkillOperationType Type { get; set; }

		// Token: 0x1700CB8E RID: 52110
		// (get) Token: 0x0602FCCC RID: 195788 RVA: 0x00682815 File Offset: 0x00680A15
		// (set) Token: 0x0602FCCD RID: 195789 RVA: 0x0068281D File Offset: 0x00680A1D
		public EDisplayModeInSkillOp DisplayMode { get; set; }

		// Token: 0x1700CB8F RID: 52111
		// (get) Token: 0x0602FCCE RID: 195790 RVA: 0x00682826 File Offset: 0x00680A26
		// (set) Token: 0x0602FCCF RID: 195791 RVA: 0x0068282E File Offset: 0x00680A2E
		public bool DisableSkillWheel { get; set; }

		// Token: 0x1700CB90 RID: 52112
		// (get) Token: 0x0602FCD0 RID: 195792 RVA: 0x00682837 File Offset: 0x00680A37
		// (set) Token: 0x0602FCD1 RID: 195793 RVA: 0x0068283F File Offset: 0x00680A3F
		public byte NullMask { get; set; }

		// Token: 0x0602FCD2 RID: 195794 RVA: 0x00682848 File Offset: 0x00680A48
		public IDisableSkillOperationT()
		{
			this.Type = ESkillOperationType.Enable;
			this.DisplayMode = EDisplayModeInSkillOp.Ashen;
			this.DisableSkillWheel = false;
			this.NullMask = 0;
		}
	}
}
