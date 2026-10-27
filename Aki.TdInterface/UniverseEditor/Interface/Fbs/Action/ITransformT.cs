using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200743A RID: 29754
	public class ITransformT
	{
		// Token: 0x1700E1E9 RID: 57833
		// (get) Token: 0x060360E0 RID: 221408 RVA: 0x0075A32A File Offset: 0x0075852A
		// (set) Token: 0x060360E1 RID: 221409 RVA: 0x0075A332 File Offset: 0x00758532
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700E1EA RID: 57834
		// (get) Token: 0x060360E2 RID: 221410 RVA: 0x0075A33B File Offset: 0x0075853B
		// (set) Token: 0x060360E3 RID: 221411 RVA: 0x0075A343 File Offset: 0x00758543
		public IVectorInfoT Rot { get; set; }

		// Token: 0x1700E1EB RID: 57835
		// (get) Token: 0x060360E4 RID: 221412 RVA: 0x0075A34C File Offset: 0x0075854C
		// (set) Token: 0x060360E5 RID: 221413 RVA: 0x0075A354 File Offset: 0x00758554
		public IVectorInfoT Scale { get; set; }

		// Token: 0x1700E1EC RID: 57836
		// (get) Token: 0x060360E6 RID: 221414 RVA: 0x0075A35D File Offset: 0x0075855D
		// (set) Token: 0x060360E7 RID: 221415 RVA: 0x0075A365 File Offset: 0x00758565
		public bool _Folded { get; set; }

		// Token: 0x1700E1ED RID: 57837
		// (get) Token: 0x060360E8 RID: 221416 RVA: 0x0075A36E File Offset: 0x0075856E
		// (set) Token: 0x060360E9 RID: 221417 RVA: 0x0075A376 File Offset: 0x00758576
		public byte NullMask { get; set; }

		// Token: 0x060360EA RID: 221418 RVA: 0x0075A37F File Offset: 0x0075857F
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
