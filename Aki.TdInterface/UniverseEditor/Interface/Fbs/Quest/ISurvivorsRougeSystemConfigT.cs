using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045B1 RID: 17841
	public class ISurvivorsRougeSystemConfigT
	{
		// Token: 0x17007CB0 RID: 31920
		// (get) Token: 0x0601A06C RID: 106604 RVA: 0x003B5933 File Offset: 0x003B3B33
		// (set) Token: 0x0601A06D RID: 106605 RVA: 0x003B593B File Offset: 0x003B3B3B
		public EEnableSystemType Type { get; set; }

		// Token: 0x17007CB1 RID: 31921
		// (get) Token: 0x0601A06E RID: 106606 RVA: 0x003B5944 File Offset: 0x003B3B44
		// (set) Token: 0x0601A06F RID: 106607 RVA: 0x003B594C File Offset: 0x003B3B4C
		public List<ISurvivorsRougeSystemVarT> Vars { get; set; }

		// Token: 0x0601A070 RID: 106608 RVA: 0x003B5955 File Offset: 0x003B3B55
		public ISurvivorsRougeSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.Vars = null;
		}
	}
}
