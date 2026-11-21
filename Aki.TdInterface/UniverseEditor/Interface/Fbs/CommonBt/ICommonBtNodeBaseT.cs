using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006501 RID: 25857
	public class ICommonBtNodeBaseT
	{
		// Token: 0x1700BEA4 RID: 48804
		// (get) Token: 0x0602C03D RID: 180285 RVA: 0x005FE12F File Offset: 0x005FC32F
		// (set) Token: 0x0602C03E RID: 180286 RVA: 0x005FE137 File Offset: 0x005FC337
		public ECommonBtNodeType Type { get; set; }

		// Token: 0x1700BEA5 RID: 48805
		// (get) Token: 0x0602C03F RID: 180287 RVA: 0x005FE140 File Offset: 0x005FC340
		// (set) Token: 0x0602C040 RID: 180288 RVA: 0x005FE148 File Offset: 0x005FC348
		public int Id { get; set; }

		// Token: 0x1700BEA6 RID: 48806
		// (get) Token: 0x0602C041 RID: 180289 RVA: 0x005FE151 File Offset: 0x005FC351
		// (set) Token: 0x0602C042 RID: 180290 RVA: 0x005FE159 File Offset: 0x005FC359
		public string Desc { get; set; }

		// Token: 0x1700BEA7 RID: 48807
		// (get) Token: 0x0602C043 RID: 180291 RVA: 0x005FE162 File Offset: 0x005FC362
		// (set) Token: 0x0602C044 RID: 180292 RVA: 0x005FE16A File Offset: 0x005FC36A
		public List<TCommonBtDecoratorUnion> Decorators { get; set; }

		// Token: 0x1700BEA8 RID: 48808
		// (get) Token: 0x0602C045 RID: 180293 RVA: 0x005FE173 File Offset: 0x005FC373
		// (set) Token: 0x0602C046 RID: 180294 RVA: 0x005FE17B File Offset: 0x005FC37B
		public bool _FoldedForTree { get; set; }

		// Token: 0x1700BEA9 RID: 48809
		// (get) Token: 0x0602C047 RID: 180295 RVA: 0x005FE184 File Offset: 0x005FC384
		// (set) Token: 0x0602C048 RID: 180296 RVA: 0x005FE18C File Offset: 0x005FC38C
		public byte NullMask { get; set; }

		// Token: 0x0602C049 RID: 180297 RVA: 0x005FE195 File Offset: 0x005FC395
		public ICommonBtNodeBaseT()
		{
			this.Type = ECommonBtNodeType.Start;
			this.Id = 0;
			this.Desc = null;
			this.Decorators = null;
			this._FoldedForTree = false;
			this.NullMask = 0;
		}
	}
}
