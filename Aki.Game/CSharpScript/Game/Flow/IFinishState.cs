using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x02007252 RID: 29266
	[NullableContext(2)]
	public interface IFinishState
	{
		// Token: 0x17009E6C RID: 40556
		// (get) Token: 0x06047BBC RID: 293820
		// (set) Token: 0x06047BBD RID: 293821
		[Nullable(1)]
		string Result { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17009E6D RID: 40557
		// (get) Token: 0x06047BBE RID: 293822
		// (set) Token: 0x06047BBF RID: 293823
		string Arg1 { get; set; }

		// Token: 0x17009E6E RID: 40558
		// (get) Token: 0x06047BC0 RID: 293824
		// (set) Token: 0x06047BC1 RID: 293825
		string Arg2 { get; set; }
	}
}
