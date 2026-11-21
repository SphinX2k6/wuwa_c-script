using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A24 RID: 14884
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseMarkInfo : ITrapDefenseMarkInfo
	{
		// Token: 0x17004E86 RID: 20102
		// (get) Token: 0x0602642F RID: 156719 RVA: 0x00AB6878 File Offset: 0x00AB4A78
		// (set) Token: 0x06026430 RID: 156720 RVA: 0x00AB6880 File Offset: 0x00AB4A80
		public int MarkId { get; set; }

		// Token: 0x17004E87 RID: 20103
		// (get) Token: 0x06026431 RID: 156721 RVA: 0x00AB6889 File Offset: 0x00AB4A89
		// (set) Token: 0x06026432 RID: 156722 RVA: 0x00AB6891 File Offset: 0x00AB4A91
		public TrapDefenseDefine.ETrapDefenseMarkType MarkType { get; set; }

		// Token: 0x17004E88 RID: 20104
		// (get) Token: 0x06026433 RID: 156723 RVA: 0x00AB689A File Offset: 0x00AB4A9A
		// (set) Token: 0x06026434 RID: 156724 RVA: 0x00AB68A2 File Offset: 0x00AB4AA2
		public object ExtraParam { get; set; }
	}
}
