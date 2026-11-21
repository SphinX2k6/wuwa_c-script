using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042D2 RID: 17106
	public class IHardBattleModeSettingT
	{
		// Token: 0x17007527 RID: 29991
		// (get) Token: 0x06018027 RID: 98343 RVA: 0x0036D768 File Offset: 0x0036B968
		// (set) Token: 0x06018028 RID: 98344 RVA: 0x0036D770 File Offset: 0x0036B970
		public bool CanOpenHardBattleMode { get; set; }

		// Token: 0x17007528 RID: 29992
		// (get) Token: 0x06018029 RID: 98345 RVA: 0x0036D779 File Offset: 0x0036B979
		// (set) Token: 0x0601802A RID: 98346 RVA: 0x0036D781 File Offset: 0x0036B981
		public byte NullMask { get; set; }

		// Token: 0x0601802B RID: 98347 RVA: 0x0036D78A File Offset: 0x0036B98A
		public IHardBattleModeSettingT()
		{
			this.CanOpenHardBattleMode = false;
			this.NullMask = 0;
		}
	}
}
