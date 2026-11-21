using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.CountDown
{
	// Token: 0x02006098 RID: 24728
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelGamePlayPrepareCountDownViewParams : ILevelGamePlayPrepareCountDownViewParams
	{
		// Token: 0x17007043 RID: 28739
		// (get) Token: 0x0603B51D RID: 242973 RVA: 0x010CA20D File Offset: 0x010C840D
		// (set) Token: 0x0603B51E RID: 242974 RVA: 0x010CA215 File Offset: 0x010C8415
		public int CountDownNum { get; set; }

		// Token: 0x17007044 RID: 28740
		// (get) Token: 0x0603B51F RID: 242975 RVA: 0x010CA21E File Offset: 0x010C841E
		// (set) Token: 0x0603B520 RID: 242976 RVA: 0x010CA226 File Offset: 0x010C8426
		public string TidText { get; set; }

		// Token: 0x17007045 RID: 28741
		// (get) Token: 0x0603B521 RID: 242977 RVA: 0x010CA22F File Offset: 0x010C842F
		// (set) Token: 0x0603B522 RID: 242978 RVA: 0x010CA237 File Offset: 0x010C8437
		public ECountDownUiStyle? UiStyle { get; set; }
	}
}
