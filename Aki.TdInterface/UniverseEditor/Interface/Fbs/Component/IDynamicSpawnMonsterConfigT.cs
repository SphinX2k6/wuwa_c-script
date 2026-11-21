using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005662 RID: 22114
	public class IDynamicSpawnMonsterConfigT
	{
		// Token: 0x17009EF5 RID: 40693
		// (get) Token: 0x060235AE RID: 144814 RVA: 0x004DD532 File Offset: 0x004DB732
		// (set) Token: 0x060235AF RID: 144815 RVA: 0x004DD53A File Offset: 0x004DB73A
		public int Id { get; set; }

		// Token: 0x17009EF6 RID: 40694
		// (get) Token: 0x060235B0 RID: 144816 RVA: 0x004DD543 File Offset: 0x004DB743
		// (set) Token: 0x060235B1 RID: 144817 RVA: 0x004DD54B File Offset: 0x004DB74B
		public float DelayTime { get; set; }

		// Token: 0x17009EF7 RID: 40695
		// (get) Token: 0x060235B2 RID: 144818 RVA: 0x004DD554 File Offset: 0x004DB754
		// (set) Token: 0x060235B3 RID: 144819 RVA: 0x004DD55C File Offset: 0x004DB75C
		public TSpawnMonsterCompleteConditionUnion CompleteCondition { get; set; }

		// Token: 0x17009EF8 RID: 40696
		// (get) Token: 0x060235B4 RID: 144820 RVA: 0x004DD565 File Offset: 0x004DB765
		// (set) Token: 0x060235B5 RID: 144821 RVA: 0x004DD56D File Offset: 0x004DB76D
		public ISpawnMonsterPreDependOnPrecedingT PreCondition { get; set; }

		// Token: 0x17009EF9 RID: 40697
		// (get) Token: 0x060235B6 RID: 144822 RVA: 0x004DD576 File Offset: 0x004DB776
		// (set) Token: 0x060235B7 RID: 144823 RVA: 0x004DD57E File Offset: 0x004DB77E
		public float Interval { get; set; }

		// Token: 0x17009EFA RID: 40698
		// (get) Token: 0x060235B8 RID: 144824 RVA: 0x004DD587 File Offset: 0x004DB787
		// (set) Token: 0x060235B9 RID: 144825 RVA: 0x004DD58F File Offset: 0x004DB78F
		public IRandomPoolChooseT MonsterChooseType { get; set; }

		// Token: 0x17009EFB RID: 40699
		// (get) Token: 0x060235BA RID: 144826 RVA: 0x004DD598 File Offset: 0x004DB798
		// (set) Token: 0x060235BB RID: 144827 RVA: 0x004DD5A0 File Offset: 0x004DB7A0
		public ISpawnMonsterPointT PointChooseType { get; set; }

		// Token: 0x17009EFC RID: 40700
		// (get) Token: 0x060235BC RID: 144828 RVA: 0x004DD5A9 File Offset: 0x004DB7A9
		// (set) Token: 0x060235BD RID: 144829 RVA: 0x004DD5B1 File Offset: 0x004DB7B1
		public byte NullMask { get; set; }

		// Token: 0x060235BE RID: 144830 RVA: 0x004DD5BC File Offset: 0x004DB7BC
		public IDynamicSpawnMonsterConfigT()
		{
			this.Id = 0;
			this.DelayTime = 0f;
			this.CompleteCondition = null;
			this.PreCondition = null;
			this.Interval = 0f;
			this.MonsterChooseType = null;
			this.PointChooseType = null;
			this.NullMask = 0;
		}
	}
}
