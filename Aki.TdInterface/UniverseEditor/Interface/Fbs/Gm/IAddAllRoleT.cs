using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004A9C RID: 19100
	public class IAddAllRoleT
	{
		// Token: 0x170085CA RID: 34250
		// (get) Token: 0x0601CB58 RID: 117592 RVA: 0x0040C2C6 File Offset: 0x0040A4C6
		// (set) Token: 0x0601CB59 RID: 117593 RVA: 0x0040C2CE File Offset: 0x0040A4CE
		public EGmCommand Type { get; set; }

		// Token: 0x0601CB5A RID: 117594 RVA: 0x0040C2D7 File Offset: 0x0040A4D7
		public IAddAllRoleT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
