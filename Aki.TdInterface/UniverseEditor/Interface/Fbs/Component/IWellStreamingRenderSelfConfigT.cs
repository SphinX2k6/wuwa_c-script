using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B78 RID: 23416
	public class IWellStreamingRenderSelfConfigT
	{
		// Token: 0x1700B0F9 RID: 45305
		// (get) Token: 0x06028155 RID: 164181 RVA: 0x005829F6 File Offset: 0x00580BF6
		// (set) Token: 0x06028156 RID: 164182 RVA: 0x005829FE File Offset: 0x00580BFE
		public string RtActorRefKey { get; set; }

		// Token: 0x1700B0FA RID: 45306
		// (get) Token: 0x06028157 RID: 164183 RVA: 0x00582A07 File Offset: 0x00580C07
		// (set) Token: 0x06028158 RID: 164184 RVA: 0x00582A0F File Offset: 0x00580C0F
		public string FallbackCubeMapKey { get; set; }

		// Token: 0x06028159 RID: 164185 RVA: 0x00582A18 File Offset: 0x00580C18
		public IWellStreamingRenderSelfConfigT()
		{
			this.RtActorRefKey = null;
			this.FallbackCubeMapKey = null;
		}
	}
}
