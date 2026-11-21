using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C2D RID: 31789
	public class ITransformT
	{
		// Token: 0x1700EE06 RID: 60934
		// (get) Token: 0x060394C9 RID: 234697 RVA: 0x007BD056 File Offset: 0x007BB256
		// (set) Token: 0x060394CA RID: 234698 RVA: 0x007BD05E File Offset: 0x007BB25E
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700EE07 RID: 60935
		// (get) Token: 0x060394CB RID: 234699 RVA: 0x007BD067 File Offset: 0x007BB267
		// (set) Token: 0x060394CC RID: 234700 RVA: 0x007BD06F File Offset: 0x007BB26F
		public IVectorInfoT Rot { get; set; }

		// Token: 0x1700EE08 RID: 60936
		// (get) Token: 0x060394CD RID: 234701 RVA: 0x007BD078 File Offset: 0x007BB278
		// (set) Token: 0x060394CE RID: 234702 RVA: 0x007BD080 File Offset: 0x007BB280
		public IVectorInfoT Scale { get; set; }

		// Token: 0x1700EE09 RID: 60937
		// (get) Token: 0x060394CF RID: 234703 RVA: 0x007BD089 File Offset: 0x007BB289
		// (set) Token: 0x060394D0 RID: 234704 RVA: 0x007BD091 File Offset: 0x007BB291
		public bool _Folded { get; set; }

		// Token: 0x1700EE0A RID: 60938
		// (get) Token: 0x060394D1 RID: 234705 RVA: 0x007BD09A File Offset: 0x007BB29A
		// (set) Token: 0x060394D2 RID: 234706 RVA: 0x007BD0A2 File Offset: 0x007BB2A2
		public byte NullMask { get; set; }

		// Token: 0x060394D3 RID: 234707 RVA: 0x007BD0AB File Offset: 0x007BB2AB
		public ITransformT()
		{
			this.Pos = null;
			this.Rot = null;
			this.Scale = null;
			this._Folded = false;
			this.NullMask = 0;
		}
	}
}
