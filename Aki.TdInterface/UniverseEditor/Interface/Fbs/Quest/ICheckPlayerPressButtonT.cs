using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D62 RID: 15714
	public class ICheckPlayerPressButtonT
	{
		// Token: 0x17006BD8 RID: 27608
		// (get) Token: 0x06015BE1 RID: 89057 RVA: 0x00322C6C File Offset: 0x00320E6C
		// (set) Token: 0x06015BE2 RID: 89058 RVA: 0x00322C74 File Offset: 0x00320E74
		public ECheckPlayerInputType Type { get; set; }

		// Token: 0x17006BD9 RID: 27609
		// (get) Token: 0x06015BE3 RID: 89059 RVA: 0x00322C7D File Offset: 0x00320E7D
		// (set) Token: 0x06015BE4 RID: 89060 RVA: 0x00322C85 File Offset: 0x00320E85
		public EPlayerButtonType ButtonType { get; set; }

		// Token: 0x06015BE5 RID: 89061 RVA: 0x00322C8E File Offset: 0x00320E8E
		public ICheckPlayerPressButtonT()
		{
			this.Type = ECheckPlayerInputType.PressButton;
			this.ButtonType = EPlayerButtonType.ChallengeAgain;
		}
	}
}
