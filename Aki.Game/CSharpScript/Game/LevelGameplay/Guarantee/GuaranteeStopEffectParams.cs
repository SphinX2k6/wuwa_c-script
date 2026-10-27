using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02006E06 RID: 28166
	[NullableContext(2)]
	[Nullable(0)]
	public class GuaranteeStopEffectParams : ActionParams, IGuaranteeStopEffectParams
	{
		// Token: 0x170099EF RID: 39407
		// (get) Token: 0x06044B41 RID: 281409 RVA: 0x010F53BA File Offset: 0x010F35BA
		// (set) Token: 0x06044B42 RID: 281410 RVA: 0x010F53C2 File Offset: 0x010F35C2
		public int? EffectId { get; set; }

		// Token: 0x170099F0 RID: 39408
		// (get) Token: 0x06044B43 RID: 281411 RVA: 0x010F53CB File Offset: 0x010F35CB
		// (set) Token: 0x06044B44 RID: 281412 RVA: 0x010F53D3 File Offset: 0x010F35D3
		public int? ScreenEffectHandle { get; set; }

		// Token: 0x170099F1 RID: 39409
		// (get) Token: 0x06044B45 RID: 281413 RVA: 0x010F53DC File Offset: 0x010F35DC
		// (set) Token: 0x06044B46 RID: 281414 RVA: 0x010F53E4 File Offset: 0x010F35E4
		public string Mp4Name { get; set; }
	}
}
