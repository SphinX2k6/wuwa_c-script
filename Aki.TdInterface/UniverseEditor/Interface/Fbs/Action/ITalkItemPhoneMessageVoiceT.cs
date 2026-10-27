using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072F9 RID: 29433
	public class ITalkItemPhoneMessageVoiceT
	{
		// Token: 0x1700DD72 RID: 56690
		// (get) Token: 0x06034ED1 RID: 216785 RVA: 0x0072AFE4 File Offset: 0x007291E4
		// (set) Token: 0x06034ED2 RID: 216786 RVA: 0x0072AFEC File Offset: 0x007291EC
		public EPhoneMessageType Type { get; set; }

		// Token: 0x1700DD73 RID: 56691
		// (get) Token: 0x06034ED3 RID: 216787 RVA: 0x0072AFF5 File Offset: 0x007291F5
		// (set) Token: 0x06034ED4 RID: 216788 RVA: 0x0072AFFD File Offset: 0x007291FD
		public EPhoneMessageVoicePushCondition PushCondition { get; set; }

		// Token: 0x1700DD74 RID: 56692
		// (get) Token: 0x06034ED5 RID: 216789 RVA: 0x0072B006 File Offset: 0x00729206
		// (set) Token: 0x06034ED6 RID: 216790 RVA: 0x0072B00E File Offset: 0x0072920E
		public bool AutoPlay { get; set; }

		// Token: 0x1700DD75 RID: 56693
		// (get) Token: 0x06034ED7 RID: 216791 RVA: 0x0072B017 File Offset: 0x00729217
		// (set) Token: 0x06034ED8 RID: 216792 RVA: 0x0072B01F File Offset: 0x0072921F
		public byte NullMask { get; set; }

		// Token: 0x06034ED9 RID: 216793 RVA: 0x0072B028 File Offset: 0x00729228
		public ITalkItemPhoneMessageVoiceT()
		{
			this.Type = EPhoneMessageType.Voice;
			this.PushCondition = EPhoneMessageVoicePushCondition.PlayVoice;
			this.AutoPlay = false;
			this.NullMask = 0;
		}
	}
}
