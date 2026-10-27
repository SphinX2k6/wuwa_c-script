using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072B1 RID: 29361
	public class ITalkEffectPlayT
	{
		// Token: 0x1700D9C6 RID: 55750
		// (get) Token: 0x06034195 RID: 213397 RVA: 0x00700B1B File Offset: 0x006FED1B
		// (set) Token: 0x06034196 RID: 213398 RVA: 0x00700B23 File Offset: 0x006FED23
		public ETalkEffectActionType Type { get; set; }

		// Token: 0x1700D9C7 RID: 55751
		// (get) Token: 0x06034197 RID: 213399 RVA: 0x00700B2C File Offset: 0x006FED2C
		// (set) Token: 0x06034198 RID: 213400 RVA: 0x00700B34 File Offset: 0x006FED34
		public ITalkCommonEffectT Effect { get; set; }

		// Token: 0x1700D9C8 RID: 55752
		// (get) Token: 0x06034199 RID: 213401 RVA: 0x00700B3D File Offset: 0x006FED3D
		// (set) Token: 0x0603419A RID: 213402 RVA: 0x00700B45 File Offset: 0x006FED45
		public bool KeepPlay { get; set; }

		// Token: 0x1700D9C9 RID: 55753
		// (get) Token: 0x0603419B RID: 213403 RVA: 0x00700B4E File Offset: 0x006FED4E
		// (set) Token: 0x0603419C RID: 213404 RVA: 0x00700B56 File Offset: 0x006FED56
		public string EffectKey { get; set; }

		// Token: 0x1700D9CA RID: 55754
		// (get) Token: 0x0603419D RID: 213405 RVA: 0x00700B5F File Offset: 0x006FED5F
		// (set) Token: 0x0603419E RID: 213406 RVA: 0x00700B67 File Offset: 0x006FED67
		public float DelayTime { get; set; }

		// Token: 0x1700D9CB RID: 55755
		// (get) Token: 0x0603419F RID: 213407 RVA: 0x00700B70 File Offset: 0x006FED70
		// (set) Token: 0x060341A0 RID: 213408 RVA: 0x00700B78 File Offset: 0x006FED78
		public byte NullMask { get; set; }

		// Token: 0x060341A1 RID: 213409 RVA: 0x00700B81 File Offset: 0x006FED81
		public ITalkEffectPlayT()
		{
			this.Type = ETalkEffectActionType.Play;
			this.Effect = null;
			this.KeepPlay = false;
			this.EffectKey = null;
			this.DelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
