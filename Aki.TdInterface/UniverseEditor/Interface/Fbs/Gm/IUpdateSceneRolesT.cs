using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046D6 RID: 18134
	public class IUpdateSceneRolesT
	{
		// Token: 0x170080D7 RID: 32983
		// (get) Token: 0x0601B933 RID: 112947 RVA: 0x003E942B File Offset: 0x003E762B
		// (set) Token: 0x0601B934 RID: 112948 RVA: 0x003E9433 File Offset: 0x003E7633
		public EGmCommand Type { get; set; }

		// Token: 0x170080D8 RID: 32984
		// (get) Token: 0x0601B935 RID: 112949 RVA: 0x003E943C File Offset: 0x003E763C
		// (set) Token: 0x0601B936 RID: 112950 RVA: 0x003E9444 File Offset: 0x003E7644
		public string Group { get; set; }

		// Token: 0x0601B937 RID: 112951 RVA: 0x003E944D File Offset: 0x003E764D
		public IUpdateSceneRolesT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.Group = null;
		}
	}
}
