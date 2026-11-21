using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ACE RID: 31438
	public class ITalkItemPhoneMessageVoiceT
	{
		// Token: 0x1700E96B RID: 59755
		// (get) Token: 0x060381D7 RID: 229847 RVA: 0x0078C448 File Offset: 0x0078A648
		// (set) Token: 0x060381D8 RID: 229848 RVA: 0x0078C450 File Offset: 0x0078A650
		public EPhoneMessageType Type { get; set; }

		// Token: 0x1700E96C RID: 59756
		// (get) Token: 0x060381D9 RID: 229849 RVA: 0x0078C459 File Offset: 0x0078A659
		// (set) Token: 0x060381DA RID: 229850 RVA: 0x0078C461 File Offset: 0x0078A661
		public EPhoneMessageVoicePushCondition PushCondition { get; set; }

		// Token: 0x1700E96D RID: 59757
		// (get) Token: 0x060381DB RID: 229851 RVA: 0x0078C46A File Offset: 0x0078A66A
		// (set) Token: 0x060381DC RID: 229852 RVA: 0x0078C472 File Offset: 0x0078A672
		public bool AutoPlay { get; set; }

		// Token: 0x1700E96E RID: 59758
		// (get) Token: 0x060381DD RID: 229853 RVA: 0x0078C47B File Offset: 0x0078A67B
		// (set) Token: 0x060381DE RID: 229854 RVA: 0x0078C483 File Offset: 0x0078A683
		public byte NullMask { get; set; }

		// Token: 0x060381DF RID: 229855 RVA: 0x0078C48C File Offset: 0x0078A68C
		public ITalkItemPhoneMessageVoiceT()
		{
			this.Type = EPhoneMessageType.Voice;
			this.PushCondition = EPhoneMessageVoicePushCondition.PlayVoice;
			this.AutoPlay = false;
			this.NullMask = 0;
		}
	}
}
