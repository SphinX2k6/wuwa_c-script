using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200467F RID: 18047
	public class IPlayFlowForGmT
	{
		// Token: 0x17008028 RID: 32808
		// (get) Token: 0x0601B667 RID: 112231 RVA: 0x003E4D9B File Offset: 0x003E2F9B
		// (set) Token: 0x0601B668 RID: 112232 RVA: 0x003E4DA3 File Offset: 0x003E2FA3
		public EGmCommand Type { get; set; }

		// Token: 0x17008029 RID: 32809
		// (get) Token: 0x0601B669 RID: 112233 RVA: 0x003E4DAC File Offset: 0x003E2FAC
		// (set) Token: 0x0601B66A RID: 112234 RVA: 0x003E4DB4 File Offset: 0x003E2FB4
		public IPlayFlowT Flow { get; set; }

		// Token: 0x0601B66B RID: 112235 RVA: 0x003E4DBD File Offset: 0x003E2FBD
		public IPlayFlowForGmT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.Flow = null;
		}
	}
}
