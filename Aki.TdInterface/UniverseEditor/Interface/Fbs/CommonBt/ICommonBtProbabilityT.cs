using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006507 RID: 25863
	public class ICommonBtProbabilityT
	{
		// Token: 0x1700BEB7 RID: 48823
		// (get) Token: 0x0602C0A5 RID: 180389 RVA: 0x005FF2C8 File Offset: 0x005FD4C8
		// (set) Token: 0x0602C0A6 RID: 180390 RVA: 0x005FF2D0 File Offset: 0x005FD4D0
		public ECommonBtNodeType Type { get; set; }

		// Token: 0x1700BEB8 RID: 48824
		// (get) Token: 0x0602C0A7 RID: 180391 RVA: 0x005FF2D9 File Offset: 0x005FD4D9
		// (set) Token: 0x0602C0A8 RID: 180392 RVA: 0x005FF2E1 File Offset: 0x005FD4E1
		public int Id { get; set; }

		// Token: 0x1700BEB9 RID: 48825
		// (get) Token: 0x0602C0A9 RID: 180393 RVA: 0x005FF2EA File Offset: 0x005FD4EA
		// (set) Token: 0x0602C0AA RID: 180394 RVA: 0x005FF2F2 File Offset: 0x005FD4F2
		public string Desc { get; set; }

		// Token: 0x1700BEBA RID: 48826
		// (get) Token: 0x0602C0AB RID: 180395 RVA: 0x005FF2FB File Offset: 0x005FD4FB
		// (set) Token: 0x0602C0AC RID: 180396 RVA: 0x005FF303 File Offset: 0x005FD503
		public List<TCommonBtDecoratorUnion> Decorators { get; set; }

		// Token: 0x1700BEBB RID: 48827
		// (get) Token: 0x0602C0AD RID: 180397 RVA: 0x005FF30C File Offset: 0x005FD50C
		// (set) Token: 0x0602C0AE RID: 180398 RVA: 0x005FF314 File Offset: 0x005FD514
		public bool _FoldedForTree { get; set; }

		// Token: 0x1700BEBC RID: 48828
		// (get) Token: 0x0602C0AF RID: 180399 RVA: 0x005FF31D File Offset: 0x005FD51D
		// (set) Token: 0x0602C0B0 RID: 180400 RVA: 0x005FF325 File Offset: 0x005FD525
		public List<TCommonBtNodeUnion> Children { get; set; }

		// Token: 0x1700BEBD RID: 48829
		// (get) Token: 0x0602C0B1 RID: 180401 RVA: 0x005FF32E File Offset: 0x005FD52E
		// (set) Token: 0x0602C0B2 RID: 180402 RVA: 0x005FF336 File Offset: 0x005FD536
		public List<float> RandomWeights { get; set; }

		// Token: 0x1700BEBE RID: 48830
		// (get) Token: 0x0602C0B3 RID: 180403 RVA: 0x005FF33F File Offset: 0x005FD53F
		// (set) Token: 0x0602C0B4 RID: 180404 RVA: 0x005FF347 File Offset: 0x005FD547
		public byte NullMask { get; set; }

		// Token: 0x0602C0B5 RID: 180405 RVA: 0x005FF350 File Offset: 0x005FD550
		public ICommonBtProbabilityT()
		{
			this.Type = ECommonBtNodeType.Start;
			this.Id = 0;
			this.Desc = null;
			this.Decorators = null;
			this._FoldedForTree = false;
			this.Children = null;
			this.RandomWeights = null;
			this.NullMask = 0;
		}
	}
}
