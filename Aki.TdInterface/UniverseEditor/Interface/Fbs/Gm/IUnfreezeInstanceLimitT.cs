using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046CA RID: 18122
	public class IUnfreezeInstanceLimitT
	{
		// Token: 0x170080C6 RID: 32966
		// (get) Token: 0x0601B8D7 RID: 112855 RVA: 0x003E8B76 File Offset: 0x003E6D76
		// (set) Token: 0x0601B8D8 RID: 112856 RVA: 0x003E8B7E File Offset: 0x003E6D7E
		public EGmCommand Type { get; set; }

		// Token: 0x0601B8D9 RID: 112857 RVA: 0x003E8B87 File Offset: 0x003E6D87
		public IUnfreezeInstanceLimitT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
