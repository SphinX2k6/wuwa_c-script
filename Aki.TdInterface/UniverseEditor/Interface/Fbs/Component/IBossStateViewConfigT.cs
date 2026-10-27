using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F1A RID: 20250
	public class IBossStateViewConfigT
	{
		// Token: 0x170091DB RID: 37339
		// (get) Token: 0x0602006A RID: 131178 RVA: 0x00474FE0 File Offset: 0x004731E0
		// (set) Token: 0x0602006B RID: 131179 RVA: 0x00474FE8 File Offset: 0x004731E8
		public EBossStateViewType BossStateViewType { get; set; }

		// Token: 0x170091DC RID: 37340
		// (get) Token: 0x0602006C RID: 131180 RVA: 0x00474FF1 File Offset: 0x004731F1
		// (set) Token: 0x0602006D RID: 131181 RVA: 0x00474FF9 File Offset: 0x004731F9
		public IDoubleViewBossStateViewStyleT BossStateViewStyle { get; set; }

		// Token: 0x170091DD RID: 37341
		// (get) Token: 0x0602006E RID: 131182 RVA: 0x00475002 File Offset: 0x00473202
		// (set) Token: 0x0602006F RID: 131183 RVA: 0x0047500A File Offset: 0x0047320A
		public string TidBossSubTitle { get; set; }

		// Token: 0x170091DE RID: 37342
		// (get) Token: 0x06020070 RID: 131184 RVA: 0x00475013 File Offset: 0x00473213
		// (set) Token: 0x06020071 RID: 131185 RVA: 0x0047501B File Offset: 0x0047321B
		public EBossStateInfoShowType BossStateInfoShowType { get; set; }

		// Token: 0x170091DF RID: 37343
		// (get) Token: 0x06020072 RID: 131186 RVA: 0x00475024 File Offset: 0x00473224
		// (set) Token: 0x06020073 RID: 131187 RVA: 0x0047502C File Offset: 0x0047322C
		public string TidLevelText { get; set; }

		// Token: 0x170091E0 RID: 37344
		// (get) Token: 0x06020074 RID: 131188 RVA: 0x00475035 File Offset: 0x00473235
		// (set) Token: 0x06020075 RID: 131189 RVA: 0x0047503D File Offset: 0x0047323D
		public bool OnlyShowInBattleState { get; set; }

		// Token: 0x170091E1 RID: 37345
		// (get) Token: 0x06020076 RID: 131190 RVA: 0x00475046 File Offset: 0x00473246
		// (set) Token: 0x06020077 RID: 131191 RVA: 0x0047504E File Offset: 0x0047324E
		public int ShowDistance { get; set; }

		// Token: 0x170091E2 RID: 37346
		// (get) Token: 0x06020078 RID: 131192 RVA: 0x00475057 File Offset: 0x00473257
		// (set) Token: 0x06020079 RID: 131193 RVA: 0x0047505F File Offset: 0x0047325F
		public byte NullMask { get; set; }

		// Token: 0x0602007A RID: 131194 RVA: 0x00475068 File Offset: 0x00473268
		public IBossStateViewConfigT()
		{
			this.BossStateViewType = EBossStateViewType.None;
			this.BossStateViewStyle = null;
			this.TidBossSubTitle = null;
			this.BossStateInfoShowType = EBossStateInfoShowType.Common;
			this.TidLevelText = null;
			this.OnlyShowInBattleState = false;
			this.ShowDistance = 0;
			this.NullMask = 0;
		}
	}
}
