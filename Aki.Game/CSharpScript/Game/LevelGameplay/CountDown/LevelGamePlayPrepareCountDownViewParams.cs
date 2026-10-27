using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.CountDown
{
	// Token: 0x02006F17 RID: 28439
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelGamePlayPrepareCountDownViewParams : ILevelGamePlayPrepareCountDownViewParams
	{
		// Token: 0x17009B04 RID: 39684
		// (get) Token: 0x0604536F RID: 283503 RVA: 0x0112026D File Offset: 0x0111E46D
		// (set) Token: 0x06045370 RID: 283504 RVA: 0x01120275 File Offset: 0x0111E475
		public int CountDownNum { get; set; }

		// Token: 0x17009B05 RID: 39685
		// (get) Token: 0x06045371 RID: 283505 RVA: 0x0112027E File Offset: 0x0111E47E
		// (set) Token: 0x06045372 RID: 283506 RVA: 0x01120286 File Offset: 0x0111E486
		public string TidText { get; set; }

		// Token: 0x17009B06 RID: 39686
		// (get) Token: 0x06045373 RID: 283507 RVA: 0x0112028F File Offset: 0x0111E48F
		// (set) Token: 0x06045374 RID: 283508 RVA: 0x01120297 File Offset: 0x0111E497
		public ECountDownUiStyle? UiStyle { get; set; }
	}
}
