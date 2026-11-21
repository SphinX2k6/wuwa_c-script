using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F0E RID: 16142
	public class IVarIntValidateConfigT
	{
		// Token: 0x17006D53 RID: 27987
		// (get) Token: 0x06015EC5 RID: 89797 RVA: 0x0032728D File Offset: 0x0032548D
		// (set) Token: 0x06015EC6 RID: 89798 RVA: 0x00327295 File Offset: 0x00325495
		public EVar Type { get; set; }

		// Token: 0x17006D54 RID: 27988
		// (get) Token: 0x06015EC7 RID: 89799 RVA: 0x0032729E File Offset: 0x0032549E
		// (set) Token: 0x06015EC8 RID: 89800 RVA: 0x003272A6 File Offset: 0x003254A6
		public List<int> ValidList { get; set; }

		// Token: 0x17006D55 RID: 27989
		// (get) Token: 0x06015EC9 RID: 89801 RVA: 0x003272AF File Offset: 0x003254AF
		// (set) Token: 0x06015ECA RID: 89802 RVA: 0x003272B7 File Offset: 0x003254B7
		public int MinValue { get; set; }

		// Token: 0x17006D56 RID: 27990
		// (get) Token: 0x06015ECB RID: 89803 RVA: 0x003272C0 File Offset: 0x003254C0
		// (set) Token: 0x06015ECC RID: 89804 RVA: 0x003272C8 File Offset: 0x003254C8
		public int MaxValue { get; set; }

		// Token: 0x17006D57 RID: 27991
		// (get) Token: 0x06015ECD RID: 89805 RVA: 0x003272D1 File Offset: 0x003254D1
		// (set) Token: 0x06015ECE RID: 89806 RVA: 0x003272D9 File Offset: 0x003254D9
		public byte NullMask { get; set; }

		// Token: 0x06015ECF RID: 89807 RVA: 0x003272E2 File Offset: 0x003254E2
		public IVarIntValidateConfigT()
		{
			this.Type = EVar.Boolean;
			this.ValidList = null;
			this.MinValue = 0;
			this.MaxValue = 0;
			this.NullMask = 0;
		}
	}
}
