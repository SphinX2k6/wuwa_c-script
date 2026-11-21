using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B3E RID: 19262
	public class IUpdateSceneRolesT
	{
		// Token: 0x17008718 RID: 34584
		// (get) Token: 0x0601D108 RID: 119048 RVA: 0x004156C7 File Offset: 0x004138C7
		// (set) Token: 0x0601D109 RID: 119049 RVA: 0x004156CF File Offset: 0x004138CF
		public EGmCommand Type { get; set; }

		// Token: 0x17008719 RID: 34585
		// (get) Token: 0x0601D10A RID: 119050 RVA: 0x004156D8 File Offset: 0x004138D8
		// (set) Token: 0x0601D10B RID: 119051 RVA: 0x004156E0 File Offset: 0x004138E0
		public string Group { get; set; }

		// Token: 0x0601D10C RID: 119052 RVA: 0x004156E9 File Offset: 0x004138E9
		public IUpdateSceneRolesT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.Group = null;
		}
	}
}
