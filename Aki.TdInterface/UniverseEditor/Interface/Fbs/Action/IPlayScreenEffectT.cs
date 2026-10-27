using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D3C RID: 27964
	public class IPlayScreenEffectT
	{
		// Token: 0x1700D07C RID: 53372
		// (get) Token: 0x060315C5 RID: 202181 RVA: 0x006B1D10 File Offset: 0x006AFF10
		// (set) Token: 0x060315C6 RID: 202182 RVA: 0x006B1D18 File Offset: 0x006AFF18
		public EEffectType Type { get; set; }

		// Token: 0x1700D07D RID: 53373
		// (get) Token: 0x060315C7 RID: 202183 RVA: 0x006B1D21 File Offset: 0x006AFF21
		// (set) Token: 0x060315C8 RID: 202184 RVA: 0x006B1D29 File Offset: 0x006AFF29
		public string Path { get; set; }

		// Token: 0x1700D07E RID: 53374
		// (get) Token: 0x060315C9 RID: 202185 RVA: 0x006B1D32 File Offset: 0x006AFF32
		// (set) Token: 0x060315CA RID: 202186 RVA: 0x006B1D3A File Offset: 0x006AFF3A
		public float DestroyTime { get; set; }

		// Token: 0x1700D07F RID: 53375
		// (get) Token: 0x060315CB RID: 202187 RVA: 0x006B1D43 File Offset: 0x006AFF43
		// (set) Token: 0x060315CC RID: 202188 RVA: 0x006B1D4B File Offset: 0x006AFF4B
		public string BindSubScreenKey { get; set; }

		// Token: 0x1700D080 RID: 53376
		// (get) Token: 0x060315CD RID: 202189 RVA: 0x006B1D54 File Offset: 0x006AFF54
		// (set) Token: 0x060315CE RID: 202190 RVA: 0x006B1D5C File Offset: 0x006AFF5C
		public byte NullMask { get; set; }

		// Token: 0x060315CF RID: 202191 RVA: 0x006B1D65 File Offset: 0x006AFF65
		public IPlayScreenEffectT()
		{
			this.Type = EEffectType.Effect;
			this.Path = null;
			this.DestroyTime = 0f;
			this.BindSubScreenKey = null;
			this.NullMask = 0;
		}
	}
}
