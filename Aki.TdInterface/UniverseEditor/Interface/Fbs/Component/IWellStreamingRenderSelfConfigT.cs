using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200618E RID: 24974
	public class IWellStreamingRenderSelfConfigT
	{
		// Token: 0x1700BA41 RID: 47681
		// (get) Token: 0x0602A719 RID: 173849 RVA: 0x005CA486 File Offset: 0x005C8686
		// (set) Token: 0x0602A71A RID: 173850 RVA: 0x005CA48E File Offset: 0x005C868E
		public string RtActorRefKey { get; set; }

		// Token: 0x1700BA42 RID: 47682
		// (get) Token: 0x0602A71B RID: 173851 RVA: 0x005CA497 File Offset: 0x005C8697
		// (set) Token: 0x0602A71C RID: 173852 RVA: 0x005CA49F File Offset: 0x005C869F
		public string FallbackCubeMapKey { get; set; }

		// Token: 0x0602A71D RID: 173853 RVA: 0x005CA4A8 File Offset: 0x005C86A8
		public IWellStreamingRenderSelfConfigT()
		{
			this.RtActorRefKey = null;
			this.FallbackCubeMapKey = null;
		}
	}
}
