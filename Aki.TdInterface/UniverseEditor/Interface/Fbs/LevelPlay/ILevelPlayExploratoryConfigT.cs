using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004957 RID: 18775
	public class ILevelPlayExploratoryConfigT
	{
		// Token: 0x1700834E RID: 33614
		// (get) Token: 0x0601BF8E RID: 114574 RVA: 0x003F4B9D File Offset: 0x003F2D9D
		// (set) Token: 0x0601BF8F RID: 114575 RVA: 0x003F4BA5 File Offset: 0x003F2DA5
		public ELevelPlayExploratoryCheckTiming When { get; set; }

		// Token: 0x1700834F RID: 33615
		// (get) Token: 0x0601BF90 RID: 114576 RVA: 0x003F4BAE File Offset: 0x003F2DAE
		// (set) Token: 0x0601BF91 RID: 114577 RVA: 0x003F4BB6 File Offset: 0x003F2DB6
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17008350 RID: 33616
		// (get) Token: 0x0601BF92 RID: 114578 RVA: 0x003F4BBF File Offset: 0x003F2DBF
		// (set) Token: 0x0601BF93 RID: 114579 RVA: 0x003F4BC7 File Offset: 0x003F2DC7
		public int AddType { get; set; }

		// Token: 0x17008351 RID: 33617
		// (get) Token: 0x0601BF94 RID: 114580 RVA: 0x003F4BD0 File Offset: 0x003F2DD0
		// (set) Token: 0x0601BF95 RID: 114581 RVA: 0x003F4BD8 File Offset: 0x003F2DD8
		public int AreaId { get; set; }

		// Token: 0x17008352 RID: 33618
		// (get) Token: 0x0601BF96 RID: 114582 RVA: 0x003F4BE1 File Offset: 0x003F2DE1
		// (set) Token: 0x0601BF97 RID: 114583 RVA: 0x003F4BE9 File Offset: 0x003F2DE9
		public byte NullMask { get; set; }

		// Token: 0x0601BF98 RID: 114584 RVA: 0x003F4BF2 File Offset: 0x003F2DF2
		public ILevelPlayExploratoryConfigT()
		{
			this.When = ELevelPlayExploratoryCheckTiming.OnCompletion;
			this.Condition = null;
			this.AddType = 0;
			this.AreaId = 0;
			this.NullMask = 0;
		}
	}
}
