using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004179 RID: 16761
	public class ICheckPlayerPressButtonT
	{
		// Token: 0x17007192 RID: 29074
		// (get) Token: 0x06017119 RID: 94489 RVA: 0x00349EE4 File Offset: 0x003480E4
		// (set) Token: 0x0601711A RID: 94490 RVA: 0x00349EEC File Offset: 0x003480EC
		public ECheckPlayerInputType Type { get; set; }

		// Token: 0x17007193 RID: 29075
		// (get) Token: 0x0601711B RID: 94491 RVA: 0x00349EF5 File Offset: 0x003480F5
		// (set) Token: 0x0601711C RID: 94492 RVA: 0x00349EFD File Offset: 0x003480FD
		public EPlayerButtonType ButtonType { get; set; }

		// Token: 0x0601711D RID: 94493 RVA: 0x00349F06 File Offset: 0x00348106
		public ICheckPlayerPressButtonT()
		{
			this.Type = ECheckPlayerInputType.PressButton;
			this.ButtonType = EPlayerButtonType.ChallengeAgain;
		}
	}
}
