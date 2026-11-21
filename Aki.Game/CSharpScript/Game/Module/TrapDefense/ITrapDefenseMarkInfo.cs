using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A23 RID: 14883
	[NullableContext(2)]
	public interface ITrapDefenseMarkInfo
	{
		// Token: 0x17004E83 RID: 20099
		// (get) Token: 0x06026429 RID: 156713
		// (set) Token: 0x0602642A RID: 156714
		int MarkId { get; set; }

		// Token: 0x17004E84 RID: 20100
		// (get) Token: 0x0602642B RID: 156715
		// (set) Token: 0x0602642C RID: 156716
		TrapDefenseDefine.ETrapDefenseMarkType MarkType { get; set; }

		// Token: 0x17004E85 RID: 20101
		// (get) Token: 0x0602642D RID: 156717
		// (set) Token: 0x0602642E RID: 156718
		object ExtraParam { get; set; }
	}
}
