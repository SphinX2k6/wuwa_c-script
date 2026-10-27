using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200625B RID: 25179
	public class IBvbSelectCardT
	{
		// Token: 0x1700BBAA RID: 48042
		// (get) Token: 0x0602B6F4 RID: 177908 RVA: 0x005FA6C5 File Offset: 0x005F88C5
		// (set) Token: 0x0602B6F5 RID: 177909 RVA: 0x005FA6CD File Offset: 0x005F88CD
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700BBAB RID: 48043
		// (get) Token: 0x0602B6F6 RID: 177910 RVA: 0x005FA6D6 File Offset: 0x005F88D6
		// (set) Token: 0x0602B6F7 RID: 177911 RVA: 0x005FA6DE File Offset: 0x005F88DE
		public List<int> CardIdList { get; set; }

		// Token: 0x1700BBAC RID: 48044
		// (get) Token: 0x0602B6F8 RID: 177912 RVA: 0x005FA6E7 File Offset: 0x005F88E7
		// (set) Token: 0x0602B6F9 RID: 177913 RVA: 0x005FA6EF File Offset: 0x005F88EF
		public byte NullMask { get; set; }

		// Token: 0x0602B6FA RID: 177914 RVA: 0x005FA6F8 File Offset: 0x005F88F8
		public IBvbSelectCardT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
			this.CardIdList = null;
			this.NullMask = 0;
		}
	}
}
