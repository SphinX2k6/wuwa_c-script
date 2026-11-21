using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F5E RID: 24414
	public class ISpawnMonsterConfigT
	{
		// Token: 0x1700B4D5 RID: 46293
		// (get) Token: 0x060290A3 RID: 168099 RVA: 0x0059B3BD File Offset: 0x005995BD
		// (set) Token: 0x060290A4 RID: 168100 RVA: 0x0059B3C5 File Offset: 0x005995C5
		public int Id { get; set; }

		// Token: 0x1700B4D6 RID: 46294
		// (get) Token: 0x060290A5 RID: 168101 RVA: 0x0059B3CE File Offset: 0x005995CE
		// (set) Token: 0x060290A6 RID: 168102 RVA: 0x0059B3D6 File Offset: 0x005995D6
		public float DelayTime { get; set; }

		// Token: 0x1700B4D7 RID: 46295
		// (get) Token: 0x060290A7 RID: 168103 RVA: 0x0059B3DF File Offset: 0x005995DF
		// (set) Token: 0x060290A8 RID: 168104 RVA: 0x0059B3E7 File Offset: 0x005995E7
		public List<int> TargetsToAwake { get; set; }

		// Token: 0x1700B4D8 RID: 46296
		// (get) Token: 0x060290A9 RID: 168105 RVA: 0x0059B3F0 File Offset: 0x005995F0
		// (set) Token: 0x060290AA RID: 168106 RVA: 0x0059B3F8 File Offset: 0x005995F8
		public TSpawnMonsterCompleteConditionUnion CompleteCondition { get; set; }

		// Token: 0x1700B4D9 RID: 46297
		// (get) Token: 0x060290AB RID: 168107 RVA: 0x0059B401 File Offset: 0x00599601
		// (set) Token: 0x060290AC RID: 168108 RVA: 0x0059B409 File Offset: 0x00599609
		public ISpawnMonsterPreDependOnPrecedingT PreCondition { get; set; }

		// Token: 0x1700B4DA RID: 46298
		// (get) Token: 0x060290AD RID: 168109 RVA: 0x0059B412 File Offset: 0x00599612
		// (set) Token: 0x060290AE RID: 168110 RVA: 0x0059B41A File Offset: 0x0059961A
		public byte NullMask { get; set; }

		// Token: 0x060290AF RID: 168111 RVA: 0x0059B423 File Offset: 0x00599623
		public ISpawnMonsterConfigT()
		{
			this.Id = 0;
			this.DelayTime = 0f;
			this.TargetsToAwake = null;
			this.CompleteCondition = null;
			this.PreCondition = null;
			this.NullMask = 0;
		}
	}
}
