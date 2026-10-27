using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050FD RID: 20733
	public class IDynamicSpawnMonsterConfigT
	{
		// Token: 0x17009708 RID: 38664
		// (get) Token: 0x0602165A RID: 136794 RVA: 0x004A35A6 File Offset: 0x004A17A6
		// (set) Token: 0x0602165B RID: 136795 RVA: 0x004A35AE File Offset: 0x004A17AE
		public int Id { get; set; }

		// Token: 0x17009709 RID: 38665
		// (get) Token: 0x0602165C RID: 136796 RVA: 0x004A35B7 File Offset: 0x004A17B7
		// (set) Token: 0x0602165D RID: 136797 RVA: 0x004A35BF File Offset: 0x004A17BF
		public float DelayTime { get; set; }

		// Token: 0x1700970A RID: 38666
		// (get) Token: 0x0602165E RID: 136798 RVA: 0x004A35C8 File Offset: 0x004A17C8
		// (set) Token: 0x0602165F RID: 136799 RVA: 0x004A35D0 File Offset: 0x004A17D0
		public TSpawnMonsterCompleteConditionUnion CompleteCondition { get; set; }

		// Token: 0x1700970B RID: 38667
		// (get) Token: 0x06021660 RID: 136800 RVA: 0x004A35D9 File Offset: 0x004A17D9
		// (set) Token: 0x06021661 RID: 136801 RVA: 0x004A35E1 File Offset: 0x004A17E1
		public ISpawnMonsterPreDependOnPrecedingT PreCondition { get; set; }

		// Token: 0x1700970C RID: 38668
		// (get) Token: 0x06021662 RID: 136802 RVA: 0x004A35EA File Offset: 0x004A17EA
		// (set) Token: 0x06021663 RID: 136803 RVA: 0x004A35F2 File Offset: 0x004A17F2
		public float Interval { get; set; }

		// Token: 0x1700970D RID: 38669
		// (get) Token: 0x06021664 RID: 136804 RVA: 0x004A35FB File Offset: 0x004A17FB
		// (set) Token: 0x06021665 RID: 136805 RVA: 0x004A3603 File Offset: 0x004A1803
		public IRandomPoolChooseT MonsterChooseType { get; set; }

		// Token: 0x1700970E RID: 38670
		// (get) Token: 0x06021666 RID: 136806 RVA: 0x004A360C File Offset: 0x004A180C
		// (set) Token: 0x06021667 RID: 136807 RVA: 0x004A3614 File Offset: 0x004A1814
		public ISpawnMonsterPointT PointChooseType { get; set; }

		// Token: 0x1700970F RID: 38671
		// (get) Token: 0x06021668 RID: 136808 RVA: 0x004A361D File Offset: 0x004A181D
		// (set) Token: 0x06021669 RID: 136809 RVA: 0x004A3625 File Offset: 0x004A1825
		public byte NullMask { get; set; }

		// Token: 0x0602166A RID: 136810 RVA: 0x004A3630 File Offset: 0x004A1830
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
