using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C9F RID: 27807
	public class IEffectPlayerPos2T
	{
		// Token: 0x1700CBF7 RID: 52215
		// (get) Token: 0x0602FEA8 RID: 196264 RVA: 0x00685E69 File Offset: 0x00684069
		// (set) Token: 0x0602FEA9 RID: 196265 RVA: 0x00685E71 File Offset: 0x00684071
		public EPos2 Type { get; set; }

		// Token: 0x1700CBF8 RID: 52216
		// (get) Token: 0x0602FEAA RID: 196266 RVA: 0x00685E7A File Offset: 0x0068407A
		// (set) Token: 0x0602FEAB RID: 196267 RVA: 0x00685E82 File Offset: 0x00684082
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700CBF9 RID: 52217
		// (get) Token: 0x0602FEAC RID: 196268 RVA: 0x00685E8B File Offset: 0x0068408B
		// (set) Token: 0x0602FEAD RID: 196269 RVA: 0x00685E93 File Offset: 0x00684093
		public string AttachSocket { get; set; }

		// Token: 0x0602FEAE RID: 196270 RVA: 0x00685E9C File Offset: 0x0068409C
		public IEffectPlayerPos2T()
		{
			this.Type = EPos2.Player;
			this.Offset = null;
			this.AttachSocket = null;
		}
	}
}
