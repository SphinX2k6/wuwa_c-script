using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046F2 RID: 18162
	public class IGameCurrBreakNodeInfoT
	{
		// Token: 0x170081D7 RID: 33239
		// (get) Token: 0x0601BCC9 RID: 113865 RVA: 0x003F0D25 File Offset: 0x003EEF25
		// (set) Token: 0x0601BCCA RID: 113866 RVA: 0x003F0D2D File Offset: 0x003EEF2D
		public int Id { get; set; }

		// Token: 0x170081D8 RID: 33240
		// (get) Token: 0x0601BCCB RID: 113867 RVA: 0x003F0D36 File Offset: 0x003EEF36
		// (set) Token: 0x0601BCCC RID: 113868 RVA: 0x003F0D3E File Offset: 0x003EEF3E
		public ENodeBreakMoment BreakMoment { get; set; }

		// Token: 0x170081D9 RID: 33241
		// (get) Token: 0x0601BCCD RID: 113869 RVA: 0x003F0D47 File Offset: 0x003EEF47
		// (set) Token: 0x0601BCCE RID: 113870 RVA: 0x003F0D4F File Offset: 0x003EEF4F
		public List<IGameCurrBreakNodeInfo_RefVarsT> RefVars { get; set; }

		// Token: 0x0601BCCF RID: 113871 RVA: 0x003F0D58 File Offset: 0x003EEF58
		public IGameCurrBreakNodeInfoT()
		{
			this.Id = 0;
			this.BreakMoment = ENodeBreakMoment.Null;
			this.RefVars = null;
		}
	}
}
