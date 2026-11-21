using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005797 RID: 22423
	public class IFanEffectConfigT
	{
		// Token: 0x1700A227 RID: 41511
		// (get) Token: 0x0602431B RID: 148251 RVA: 0x004FA0B4 File Offset: 0x004F82B4
		// (set) Token: 0x0602431C RID: 148252 RVA: 0x004FA0BC File Offset: 0x004F82BC
		public string EffectPath { get; set; }

		// Token: 0x1700A228 RID: 41512
		// (get) Token: 0x0602431D RID: 148253 RVA: 0x004FA0C5 File Offset: 0x004F82C5
		// (set) Token: 0x0602431E RID: 148254 RVA: 0x004FA0CD File Offset: 0x004F82CD
		public float DefaultEffectLength { get; set; }

		// Token: 0x1700A229 RID: 41513
		// (get) Token: 0x0602431F RID: 148255 RVA: 0x004FA0D6 File Offset: 0x004F82D6
		// (set) Token: 0x06024320 RID: 148256 RVA: 0x004FA0DE File Offset: 0x004F82DE
		public string HitEffectPath { get; set; }

		// Token: 0x06024321 RID: 148257 RVA: 0x004FA0E7 File Offset: 0x004F82E7
		public IFanEffectConfigT()
		{
			this.EffectPath = null;
			this.DefaultEffectLength = 0f;
			this.HitEffectPath = null;
		}
	}
}
