using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004434 RID: 17460
	public class IQuestMonsterHealthScoreT
	{
		// Token: 0x170078F1 RID: 30961
		// (get) Token: 0x06019006 RID: 102406 RVA: 0x00390FB6 File Offset: 0x0038F1B6
		// (set) Token: 0x06019007 RID: 102407 RVA: 0x00390FBE File Offset: 0x0038F1BE
		public EStatisticsEventType Type { get; set; }

		// Token: 0x170078F2 RID: 30962
		// (get) Token: 0x06019008 RID: 102408 RVA: 0x00390FC7 File Offset: 0x0038F1C7
		// (set) Token: 0x06019009 RID: 102409 RVA: 0x00390FCF File Offset: 0x0038F1CF
		public TVarRefUnion Var { get; set; }

		// Token: 0x170078F3 RID: 30963
		// (get) Token: 0x0601900A RID: 102410 RVA: 0x00390FD8 File Offset: 0x0038F1D8
		// (set) Token: 0x0601900B RID: 102411 RVA: 0x00390FE0 File Offset: 0x0038F1E0
		public List<IMonsterHpPointTypeConfigT> TypeConfigs { get; set; }

		// Token: 0x170078F4 RID: 30964
		// (get) Token: 0x0601900C RID: 102412 RVA: 0x00390FE9 File Offset: 0x0038F1E9
		// (set) Token: 0x0601900D RID: 102413 RVA: 0x00390FF1 File Offset: 0x0038F1F1
		public List<IMonsterHpPointEntityConfigT> EntityConfigs { get; set; }

		// Token: 0x170078F5 RID: 30965
		// (get) Token: 0x0601900E RID: 102414 RVA: 0x00390FFA File Offset: 0x0038F1FA
		// (set) Token: 0x0601900F RID: 102415 RVA: 0x00391002 File Offset: 0x0038F202
		public bool IsStatisticsRecoveredHp { get; set; }

		// Token: 0x170078F6 RID: 30966
		// (get) Token: 0x06019010 RID: 102416 RVA: 0x0039100B File Offset: 0x0038F20B
		// (set) Token: 0x06019011 RID: 102417 RVA: 0x00391013 File Offset: 0x0038F213
		public byte NullMask { get; set; }

		// Token: 0x06019012 RID: 102418 RVA: 0x0039101C File Offset: 0x0038F21C
		public IQuestMonsterHealthScoreT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.TypeConfigs = null;
			this.EntityConfigs = null;
			this.IsStatisticsRecoveredHp = false;
			this.NullMask = 0;
		}
	}
}
