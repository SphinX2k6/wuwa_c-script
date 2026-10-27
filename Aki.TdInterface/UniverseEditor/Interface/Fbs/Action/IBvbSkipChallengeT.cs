using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006264 RID: 25188
	public class IBvbSkipChallengeT
	{
		// Token: 0x1700BBB5 RID: 48053
		// (get) Token: 0x0602B762 RID: 178018 RVA: 0x005FBDA6 File Offset: 0x005F9FA6
		// (set) Token: 0x0602B763 RID: 178019 RVA: 0x005FBDAE File Offset: 0x005F9FAE
		public int ChallengeId { get; set; }

		// Token: 0x0602B764 RID: 178020 RVA: 0x005FBDB7 File Offset: 0x005F9FB7
		public IBvbSkipChallengeT()
		{
			this.ChallengeId = 0;
		}
	}
}
