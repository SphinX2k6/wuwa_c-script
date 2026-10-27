using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x0200478E RID: 18318
	[NullableContext(1)]
	public interface IMapNoteParams
	{
		// Token: 0x170077D6 RID: 30678
		// (get) Token: 0x0602FEC7 RID: 196295
		// (set) Token: 0x0602FEC8 RID: 196296
		EMapNoteId MapNoteId { get; set; }

		// Token: 0x170077D7 RID: 30679
		// (get) Token: 0x0602FEC9 RID: 196297
		// (set) Token: 0x0602FECA RID: 196298
		Action<int> ClickCallBack { get; set; }

		// Token: 0x170077D8 RID: 30680
		// (get) Token: 0x0602FECB RID: 196299
		// (set) Token: 0x0602FECC RID: 196300
		MapNote MapNoteConfig { get; set; }

		// Token: 0x170077D9 RID: 30681
		// (get) Token: 0x0602FECD RID: 196301
		// (set) Token: 0x0602FECE RID: 196302
		int? MapMarkId { get; set; }

		// Token: 0x170077DA RID: 30682
		// (get) Token: 0x0602FECF RID: 196303
		// (set) Token: 0x0602FED0 RID: 196304
		[Nullable(2)]
		string CustomDesc { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
