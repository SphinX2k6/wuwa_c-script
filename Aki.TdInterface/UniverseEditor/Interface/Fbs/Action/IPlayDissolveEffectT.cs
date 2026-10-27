using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CDF RID: 27871
	public class IPlayDissolveEffectT
	{
		// Token: 0x1700CF99 RID: 53145
		// (get) Token: 0x06031246 RID: 201286 RVA: 0x006AB129 File Offset: 0x006A9329
		// (set) Token: 0x06031247 RID: 201287 RVA: 0x006AB131 File Offset: 0x006A9331
		public EEffectType Type { get; set; }

		// Token: 0x1700CF9A RID: 53146
		// (get) Token: 0x06031248 RID: 201288 RVA: 0x006AB13A File Offset: 0x006A933A
		// (set) Token: 0x06031249 RID: 201289 RVA: 0x006AB142 File Offset: 0x006A9342
		public string Path { get; set; }

		// Token: 0x1700CF9B RID: 53147
		// (get) Token: 0x0603124A RID: 201290 RVA: 0x006AB14B File Offset: 0x006A934B
		// (set) Token: 0x0603124B RID: 201291 RVA: 0x006AB153 File Offset: 0x006A9353
		public IVector2T ScreenPos { get; set; }

		// Token: 0x1700CF9C RID: 53148
		// (get) Token: 0x0603124C RID: 201292 RVA: 0x006AB15C File Offset: 0x006A935C
		// (set) Token: 0x0603124D RID: 201293 RVA: 0x006AB164 File Offset: 0x006A9364
		public float Scale { get; set; }

		// Token: 0x1700CF9D RID: 53149
		// (get) Token: 0x0603124E RID: 201294 RVA: 0x006AB16D File Offset: 0x006A936D
		// (set) Token: 0x0603124F RID: 201295 RVA: 0x006AB175 File Offset: 0x006A9375
		public float DissolveParam { get; set; }

		// Token: 0x1700CF9E RID: 53150
		// (get) Token: 0x06031250 RID: 201296 RVA: 0x006AB17E File Offset: 0x006A937E
		// (set) Token: 0x06031251 RID: 201297 RVA: 0x006AB186 File Offset: 0x006A9386
		public float FadeInTime { get; set; }

		// Token: 0x1700CF9F RID: 53151
		// (get) Token: 0x06031252 RID: 201298 RVA: 0x006AB18F File Offset: 0x006A938F
		// (set) Token: 0x06031253 RID: 201299 RVA: 0x006AB197 File Offset: 0x006A9397
		public float FadeOutTime { get; set; }

		// Token: 0x1700CFA0 RID: 53152
		// (get) Token: 0x06031254 RID: 201300 RVA: 0x006AB1A0 File Offset: 0x006A93A0
		// (set) Token: 0x06031255 RID: 201301 RVA: 0x006AB1A8 File Offset: 0x006A93A8
		public bool IsFullScreenMask { get; set; }

		// Token: 0x1700CFA1 RID: 53153
		// (get) Token: 0x06031256 RID: 201302 RVA: 0x006AB1B1 File Offset: 0x006A93B1
		// (set) Token: 0x06031257 RID: 201303 RVA: 0x006AB1B9 File Offset: 0x006A93B9
		public byte NullMask { get; set; }

		// Token: 0x06031258 RID: 201304 RVA: 0x006AB1C4 File Offset: 0x006A93C4
		public IPlayDissolveEffectT()
		{
			this.Type = EEffectType.Effect;
			this.Path = null;
			this.ScreenPos = null;
			this.Scale = 0f;
			this.DissolveParam = 0f;
			this.FadeInTime = 0f;
			this.FadeOutTime = 0f;
			this.IsFullScreenMask = false;
			this.NullMask = 0;
		}
	}
}
