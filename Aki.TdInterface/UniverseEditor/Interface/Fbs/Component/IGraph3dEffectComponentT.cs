using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005316 RID: 21270
	public class IGraph3dEffectComponentT
	{
		// Token: 0x17009C2D RID: 39981
		// (get) Token: 0x06022BF8 RID: 142328 RVA: 0x004D074B File Offset: 0x004CE94B
		// (set) Token: 0x06022BF9 RID: 142329 RVA: 0x004D0753 File Offset: 0x004CE953
		public bool Disabled { get; set; }

		// Token: 0x17009C2E RID: 39982
		// (get) Token: 0x06022BFA RID: 142330 RVA: 0x004D075C File Offset: 0x004CE95C
		// (set) Token: 0x06022BFB RID: 142331 RVA: 0x004D0764 File Offset: 0x004CE964
		public int Graph3dEntityId { get; set; }

		// Token: 0x17009C2F RID: 39983
		// (get) Token: 0x06022BFC RID: 142332 RVA: 0x004D076D File Offset: 0x004CE96D
		// (set) Token: 0x06022BFD RID: 142333 RVA: 0x004D0775 File Offset: 0x004CE975
		public IFireBoxFishEffectT EffectType { get; set; }

		// Token: 0x17009C30 RID: 39984
		// (get) Token: 0x06022BFE RID: 142334 RVA: 0x004D077E File Offset: 0x004CE97E
		// (set) Token: 0x06022BFF RID: 142335 RVA: 0x004D0786 File Offset: 0x004CE986
		public byte NullMask { get; set; }

		// Token: 0x06022C00 RID: 142336 RVA: 0x004D078F File Offset: 0x004CE98F
		public IGraph3dEffectComponentT()
		{
			this.Disabled = false;
			this.Graph3dEntityId = 0;
			this.EffectType = null;
			this.NullMask = 0;
		}
	}
}
