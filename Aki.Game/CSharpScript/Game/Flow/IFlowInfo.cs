using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x02007245 RID: 29253
	[NullableContext(1)]
	public interface IFlowInfo
	{
		// Token: 0x17009E4E RID: 40526
		// (get) Token: 0x06047B7E RID: 293758
		// (set) Token: 0x06047B7F RID: 293759
		int Id { get; set; }

		// Token: 0x17009E4F RID: 40527
		// (get) Token: 0x06047B80 RID: 293760
		// (set) Token: 0x06047B81 RID: 293761
		string Name { get; set; }

		// Token: 0x17009E50 RID: 40528
		// (get) Token: 0x06047B82 RID: 293762
		// (set) Token: 0x06047B83 RID: 293763
		bool? _folded { get; set; }

		// Token: 0x17009E51 RID: 40529
		// (get) Token: 0x06047B84 RID: 293764
		// (set) Token: 0x06047B85 RID: 293765
		int StateGenId { get; set; }

		// Token: 0x17009E52 RID: 40530
		// (get) Token: 0x06047B86 RID: 293766
		// (set) Token: 0x06047B87 RID: 293767
		IStateInfo[] States { get; set; }
	}
}
