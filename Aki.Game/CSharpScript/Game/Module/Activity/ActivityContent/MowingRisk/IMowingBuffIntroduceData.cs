using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005335 RID: 21301
	[NullableContext(1)]
	public interface IMowingBuffIntroduceData
	{
		// Token: 0x170066F7 RID: 26359
		// (get) Token: 0x06035046 RID: 217158
		// (set) Token: 0x06035047 RID: 217159
		string BackgroundPath { get; set; }

		// Token: 0x170066F8 RID: 26360
		// (get) Token: 0x06035048 RID: 217160
		// (set) Token: 0x06035049 RID: 217161
		string LevelTextId { get; set; }

		// Token: 0x170066F9 RID: 26361
		// (get) Token: 0x0603504A RID: 217162
		// (set) Token: 0x0603504B RID: 217163
		string[] LevelTextArgs { get; set; }

		// Token: 0x170066FA RID: 26362
		// (get) Token: 0x0603504C RID: 217164
		// (set) Token: 0x0603504D RID: 217165
		string NameTextId { get; set; }

		// Token: 0x170066FB RID: 26363
		// (get) Token: 0x0603504E RID: 217166
		// (set) Token: 0x0603504F RID: 217167
		string TipsTextId { get; set; }

		// Token: 0x170066FC RID: 26364
		// (get) Token: 0x06035050 RID: 217168
		// (set) Token: 0x06035051 RID: 217169
		string[] TipsArgs { get; set; }

		// Token: 0x170066FD RID: 26365
		// (get) Token: 0x06035052 RID: 217170
		// (set) Token: 0x06035053 RID: 217171
		string IconPath { get; set; }

		// Token: 0x170066FE RID: 26366
		// (get) Token: 0x06035054 RID: 217172
		// (set) Token: 0x06035055 RID: 217173
		string HexColor { get; set; }

		// Token: 0x170066FF RID: 26367
		// (get) Token: 0x06035056 RID: 217174
		// (set) Token: 0x06035057 RID: 217175
		bool IsUnlock { get; set; }
	}
}
