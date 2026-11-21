using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B34 RID: 27444
	public class IContinualGamepadShakeT
	{
		// Token: 0x1700C98F RID: 51599
		// (get) Token: 0x0602F39C RID: 193436 RVA: 0x00672EDF File Offset: 0x006710DF
		// (set) Token: 0x0602F39D RID: 193437 RVA: 0x00672EE7 File Offset: 0x006710E7
		public EGamepadShakeType Type { get; set; }

		// Token: 0x1700C990 RID: 51600
		// (get) Token: 0x0602F39E RID: 193438 RVA: 0x00672EF0 File Offset: 0x006710F0
		// (set) Token: 0x0602F39F RID: 193439 RVA: 0x00672EF8 File Offset: 0x006710F8
		public bool IsIgnoreTimeDilation { get; set; }

		// Token: 0x1700C991 RID: 51601
		// (get) Token: 0x0602F3A0 RID: 193440 RVA: 0x00672F01 File Offset: 0x00671101
		// (set) Token: 0x0602F3A1 RID: 193441 RVA: 0x00672F09 File Offset: 0x00671109
		public float Duration { get; set; }

		// Token: 0x1700C992 RID: 51602
		// (get) Token: 0x0602F3A2 RID: 193442 RVA: 0x00672F12 File Offset: 0x00671112
		// (set) Token: 0x0602F3A3 RID: 193443 RVA: 0x00672F1A File Offset: 0x0067111A
		public bool IsLoop { get; set; }

		// Token: 0x1700C993 RID: 51603
		// (get) Token: 0x0602F3A4 RID: 193444 RVA: 0x00672F23 File Offset: 0x00671123
		// (set) Token: 0x0602F3A5 RID: 193445 RVA: 0x00672F2B File Offset: 0x0067112B
		public string GamepadShakeTag { get; set; }

		// Token: 0x1700C994 RID: 51604
		// (get) Token: 0x0602F3A6 RID: 193446 RVA: 0x00672F34 File Offset: 0x00671134
		// (set) Token: 0x0602F3A7 RID: 193447 RVA: 0x00672F3C File Offset: 0x0067113C
		public byte NullMask { get; set; }

		// Token: 0x0602F3A8 RID: 193448 RVA: 0x00672F45 File Offset: 0x00671145
		public IContinualGamepadShakeT()
		{
			this.Type = EGamepadShakeType.Onetime;
			this.IsIgnoreTimeDilation = false;
			this.Duration = 0f;
			this.IsLoop = false;
			this.GamepadShakeTag = null;
			this.NullMask = 0;
		}
	}
}
