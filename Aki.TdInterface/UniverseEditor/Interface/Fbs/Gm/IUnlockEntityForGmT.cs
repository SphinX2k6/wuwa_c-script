using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046D0 RID: 18128
	public class IUnlockEntityForGmT
	{
		// Token: 0x170080CD RID: 32973
		// (get) Token: 0x0601B905 RID: 112901 RVA: 0x003E8FF7 File Offset: 0x003E71F7
		// (set) Token: 0x0601B906 RID: 112902 RVA: 0x003E8FFF File Offset: 0x003E71FF
		public EGmCommand Type { get; set; }

		// Token: 0x170080CE RID: 32974
		// (get) Token: 0x0601B907 RID: 112903 RVA: 0x003E9008 File Offset: 0x003E7208
		// (set) Token: 0x0601B908 RID: 112904 RVA: 0x003E9010 File Offset: 0x003E7210
		public List<int> EntityIds { get; set; }

		// Token: 0x0601B909 RID: 112905 RVA: 0x003E9019 File Offset: 0x003E7219
		public IUnlockEntityForGmT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.EntityIds = null;
		}
	}
}
