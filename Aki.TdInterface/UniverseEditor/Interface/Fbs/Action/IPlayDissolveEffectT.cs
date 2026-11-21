using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007452 RID: 29778
	public class IPlayDissolveEffectT
	{
		// Token: 0x1700DAD4 RID: 56020
		// (get) Token: 0x0603420D RID: 213517 RVA: 0x0070628F File Offset: 0x0070448F
		// (set) Token: 0x0603420E RID: 213518 RVA: 0x00706297 File Offset: 0x00704497
		public EEffectType Type { get; set; }

		// Token: 0x1700DAD5 RID: 56021
		// (get) Token: 0x0603420F RID: 213519 RVA: 0x007062A0 File Offset: 0x007044A0
		// (set) Token: 0x06034210 RID: 213520 RVA: 0x007062A8 File Offset: 0x007044A8
		public string Path { get; set; }

		// Token: 0x1700DAD6 RID: 56022
		// (get) Token: 0x06034211 RID: 213521 RVA: 0x007062B1 File Offset: 0x007044B1
		// (set) Token: 0x06034212 RID: 213522 RVA: 0x007062B9 File Offset: 0x007044B9
		public IVector2T ScreenPos { get; set; }

		// Token: 0x1700DAD7 RID: 56023
		// (get) Token: 0x06034213 RID: 213523 RVA: 0x007062C2 File Offset: 0x007044C2
		// (set) Token: 0x06034214 RID: 213524 RVA: 0x007062CA File Offset: 0x007044CA
		public IPlayDissolveEffectInActorPosConfigT PlayInActorPos { get; set; }

		// Token: 0x1700DAD8 RID: 56024
		// (get) Token: 0x06034215 RID: 213525 RVA: 0x007062D3 File Offset: 0x007044D3
		// (set) Token: 0x06034216 RID: 213526 RVA: 0x007062DB File Offset: 0x007044DB
		public float Scale { get; set; }

		// Token: 0x1700DAD9 RID: 56025
		// (get) Token: 0x06034217 RID: 213527 RVA: 0x007062E4 File Offset: 0x007044E4
		// (set) Token: 0x06034218 RID: 213528 RVA: 0x007062EC File Offset: 0x007044EC
		public float DissolveParam { get; set; }

		// Token: 0x1700DADA RID: 56026
		// (get) Token: 0x06034219 RID: 213529 RVA: 0x007062F5 File Offset: 0x007044F5
		// (set) Token: 0x0603421A RID: 213530 RVA: 0x007062FD File Offset: 0x007044FD
		public float FadeInTime { get; set; }

		// Token: 0x1700DADB RID: 56027
		// (get) Token: 0x0603421B RID: 213531 RVA: 0x00706306 File Offset: 0x00704506
		// (set) Token: 0x0603421C RID: 213532 RVA: 0x0070630E File Offset: 0x0070450E
		public float FadeOutTime { get; set; }

		// Token: 0x1700DADC RID: 56028
		// (get) Token: 0x0603421D RID: 213533 RVA: 0x00706317 File Offset: 0x00704517
		// (set) Token: 0x0603421E RID: 213534 RVA: 0x0070631F File Offset: 0x0070451F
		public bool IsFullScreenMask { get; set; }

		// Token: 0x1700DADD RID: 56029
		// (get) Token: 0x0603421F RID: 213535 RVA: 0x00706328 File Offset: 0x00704528
		// (set) Token: 0x06034220 RID: 213536 RVA: 0x00706330 File Offset: 0x00704530
		public byte NullMask { get; set; }

		// Token: 0x06034221 RID: 213537 RVA: 0x0070633C File Offset: 0x0070453C
		public IPlayDissolveEffectT()
		{
			this.Type = EEffectType.Effect;
			this.Path = null;
			this.ScreenPos = null;
			this.PlayInActorPos = new IPlayDissolveEffectInActorPosConfigT();
			this.Scale = 0f;
			this.DissolveParam = 0f;
			this.FadeInTime = 0f;
			this.FadeOutTime = 0f;
			this.IsFullScreenMask = false;
			this.NullMask = 0;
		}
	}
}
