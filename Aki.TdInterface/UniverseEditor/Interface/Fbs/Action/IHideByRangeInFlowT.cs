using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068E3 RID: 26851
	public class IHideByRangeInFlowT
	{
		// Token: 0x1700C738 RID: 51000
		// (get) Token: 0x0602ED66 RID: 191846 RVA: 0x00663EEE File Offset: 0x006620EE
		// (set) Token: 0x0602ED67 RID: 191847 RVA: 0x00663EF6 File Offset: 0x006620F6
		public ETriggerShape Type { get; set; }

		// Token: 0x1700C739 RID: 51001
		// (get) Token: 0x0602ED68 RID: 191848 RVA: 0x00663EFF File Offset: 0x006620FF
		// (set) Token: 0x0602ED69 RID: 191849 RVA: 0x00663F07 File Offset: 0x00662107
		public IVectorInfoT Center { get; set; }

		// Token: 0x1700C73A RID: 51002
		// (get) Token: 0x0602ED6A RID: 191850 RVA: 0x00663F10 File Offset: 0x00662110
		// (set) Token: 0x0602ED6B RID: 191851 RVA: 0x00663F18 File Offset: 0x00662118
		public int Radius { get; set; }

		// Token: 0x1700C73B RID: 51003
		// (get) Token: 0x0602ED6C RID: 191852 RVA: 0x00663F21 File Offset: 0x00662121
		// (set) Token: 0x0602ED6D RID: 191853 RVA: 0x00663F29 File Offset: 0x00662129
		public List<int> EntityIds { get; set; }

		// Token: 0x1700C73C RID: 51004
		// (get) Token: 0x0602ED6E RID: 191854 RVA: 0x00663F32 File Offset: 0x00662132
		// (set) Token: 0x0602ED6F RID: 191855 RVA: 0x00663F3A File Offset: 0x0066213A
		public bool IsCleanSimpleNpc { get; set; }

		// Token: 0x1700C73D RID: 51005
		// (get) Token: 0x0602ED70 RID: 191856 RVA: 0x00663F43 File Offset: 0x00662143
		// (set) Token: 0x0602ED71 RID: 191857 RVA: 0x00663F4B File Offset: 0x0066214B
		public bool IsCleanPasserByNpc { get; set; }

		// Token: 0x1700C73E RID: 51006
		// (get) Token: 0x0602ED72 RID: 191858 RVA: 0x00663F54 File Offset: 0x00662154
		// (set) Token: 0x0602ED73 RID: 191859 RVA: 0x00663F5C File Offset: 0x0066215C
		public byte NullMask { get; set; }

		// Token: 0x0602ED74 RID: 191860 RVA: 0x00663F65 File Offset: 0x00662165
		public IHideByRangeInFlowT()
		{
			this.Type = ETriggerShape.Box;
			this.Center = null;
			this.Radius = 0;
			this.EntityIds = null;
			this.IsCleanSimpleNpc = false;
			this.IsCleanPasserByNpc = false;
			this.NullMask = 0;
		}
	}
}
