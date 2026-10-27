using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DC2 RID: 24002
	public class IGiantResponsePlayAnimationT
	{
		// Token: 0x1700B3B5 RID: 46005
		// (get) Token: 0x06029154 RID: 168276 RVA: 0x005A3C0C File Offset: 0x005A1E0C
		// (set) Token: 0x06029155 RID: 168277 RVA: 0x005A3C14 File Offset: 0x005A1E14
		public EGiantResponseType Type { get; set; }

		// Token: 0x1700B3B6 RID: 46006
		// (get) Token: 0x06029156 RID: 168278 RVA: 0x005A3C1D File Offset: 0x005A1E1D
		// (set) Token: 0x06029157 RID: 168279 RVA: 0x005A3C25 File Offset: 0x005A1E25
		public int GiantAnimationId { get; set; }

		// Token: 0x06029158 RID: 168280 RVA: 0x005A3C2E File Offset: 0x005A1E2E
		public IGiantResponsePlayAnimationT()
		{
			this.Type = EGiantResponseType.PlayAnimation;
			this.GiantAnimationId = 0;
		}
	}
}
