using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036BF RID: 14015
	[NullableContext(1)]
	public interface IMapNoteParams
	{
		// Token: 0x17004A92 RID: 19090
		// (get) Token: 0x06024692 RID: 149138
		// (set) Token: 0x06024693 RID: 149139
		EMapNoteId MapNoteId { get; set; }

		// Token: 0x17004A93 RID: 19091
		// (get) Token: 0x06024694 RID: 149140
		// (set) Token: 0x06024695 RID: 149141
		Action<int> ClickCallBack { get; set; }

		// Token: 0x17004A94 RID: 19092
		// (get) Token: 0x06024696 RID: 149142
		// (set) Token: 0x06024697 RID: 149143
		MapNote MapNoteConfig { get; set; }

		// Token: 0x17004A95 RID: 19093
		// (get) Token: 0x06024698 RID: 149144
		// (set) Token: 0x06024699 RID: 149145
		int? MapMarkId { get; set; }

		// Token: 0x17004A96 RID: 19094
		// (get) Token: 0x0602469A RID: 149146
		// (set) Token: 0x0602469B RID: 149147
		[Nullable(2)]
		string CustomDesc { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
