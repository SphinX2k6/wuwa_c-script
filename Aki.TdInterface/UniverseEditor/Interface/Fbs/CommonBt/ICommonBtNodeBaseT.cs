using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EBE RID: 24254
	public class ICommonBtNodeBaseT
	{
		// Token: 0x1700B539 RID: 46393
		// (get) Token: 0x06029989 RID: 170377 RVA: 0x005B4C4B File Offset: 0x005B2E4B
		// (set) Token: 0x0602998A RID: 170378 RVA: 0x005B4C53 File Offset: 0x005B2E53
		public ECommonBtNodeType Type { get; set; }

		// Token: 0x1700B53A RID: 46394
		// (get) Token: 0x0602998B RID: 170379 RVA: 0x005B4C5C File Offset: 0x005B2E5C
		// (set) Token: 0x0602998C RID: 170380 RVA: 0x005B4C64 File Offset: 0x005B2E64
		public int Id { get; set; }

		// Token: 0x1700B53B RID: 46395
		// (get) Token: 0x0602998D RID: 170381 RVA: 0x005B4C6D File Offset: 0x005B2E6D
		// (set) Token: 0x0602998E RID: 170382 RVA: 0x005B4C75 File Offset: 0x005B2E75
		public string Desc { get; set; }

		// Token: 0x1700B53C RID: 46396
		// (get) Token: 0x0602998F RID: 170383 RVA: 0x005B4C7E File Offset: 0x005B2E7E
		// (set) Token: 0x06029990 RID: 170384 RVA: 0x005B4C86 File Offset: 0x005B2E86
		public List<TCommonBtDecoratorUnion> Decorators { get; set; }

		// Token: 0x1700B53D RID: 46397
		// (get) Token: 0x06029991 RID: 170385 RVA: 0x005B4C8F File Offset: 0x005B2E8F
		// (set) Token: 0x06029992 RID: 170386 RVA: 0x005B4C97 File Offset: 0x005B2E97
		public bool _FoldedForTree { get; set; }

		// Token: 0x1700B53E RID: 46398
		// (get) Token: 0x06029993 RID: 170387 RVA: 0x005B4CA0 File Offset: 0x005B2EA0
		// (set) Token: 0x06029994 RID: 170388 RVA: 0x005B4CA8 File Offset: 0x005B2EA8
		public byte NullMask { get; set; }

		// Token: 0x06029995 RID: 170389 RVA: 0x005B4CB1 File Offset: 0x005B2EB1
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
