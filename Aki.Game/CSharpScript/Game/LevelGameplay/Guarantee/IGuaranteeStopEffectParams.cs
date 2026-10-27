using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02006E05 RID: 28165
	[NullableContext(2)]
	public interface IGuaranteeStopEffectParams
	{
		// Token: 0x170099EC RID: 39404
		// (get) Token: 0x06044B3B RID: 281403
		// (set) Token: 0x06044B3C RID: 281404
		int? EffectId { get; set; }

		// Token: 0x170099ED RID: 39405
		// (get) Token: 0x06044B3D RID: 281405
		// (set) Token: 0x06044B3E RID: 281406
		int? ScreenEffectHandle { get; set; }

		// Token: 0x170099EE RID: 39406
		// (get) Token: 0x06044B3F RID: 281407
		// (set) Token: 0x06044B40 RID: 281408
		string Mp4Name { get; set; }
	}
}
