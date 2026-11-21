using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EEE RID: 28398
	public class IFoxAutoJumpT
	{
		// Token: 0x1700D03B RID: 53307
		// (get) Token: 0x06031225 RID: 201253 RVA: 0x006A921F File Offset: 0x006A741F
		// (set) Token: 0x06031226 RID: 201254 RVA: 0x006A9227 File Offset: 0x006A7427
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700D03C RID: 53308
		// (get) Token: 0x06031227 RID: 201255 RVA: 0x006A9230 File Offset: 0x006A7430
		// (set) Token: 0x06031228 RID: 201256 RVA: 0x006A9238 File Offset: 0x006A7438
		public IVectorInfoT LandPosition { get; set; }

		// Token: 0x06031229 RID: 201257 RVA: 0x006A9241 File Offset: 0x006A7441
		public IFoxAutoJumpT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.LandPosition = null;
		}
	}
}
