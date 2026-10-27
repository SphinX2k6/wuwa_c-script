using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053BD RID: 21437
	public class IHookFetchMoveUniformT
	{
		// Token: 0x17009D8F RID: 40335
		// (get) Token: 0x0602321A RID: 143898 RVA: 0x004DCEFC File Offset: 0x004DB0FC
		// (set) Token: 0x0602321B RID: 143899 RVA: 0x004DCF04 File Offset: 0x004DB104
		public EHookFetchMoveMode Type { get; set; }

		// Token: 0x17009D90 RID: 40336
		// (get) Token: 0x0602321C RID: 143900 RVA: 0x004DCF0D File Offset: 0x004DB10D
		// (set) Token: 0x0602321D RID: 143901 RVA: 0x004DCF15 File Offset: 0x004DB115
		public float Speed { get; set; }

		// Token: 0x0602321E RID: 143902 RVA: 0x004DCF1E File Offset: 0x004DB11E
		public IHookFetchMoveUniformT()
		{
			this.Type = EHookFetchMoveMode.Uniform;
			this.Speed = 0f;
		}
	}
}
