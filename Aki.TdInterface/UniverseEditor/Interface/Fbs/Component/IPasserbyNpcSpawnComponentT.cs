using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CC7 RID: 23751
	public class IPasserbyNpcSpawnComponentT
	{
		// Token: 0x1700AE77 RID: 44663
		// (get) Token: 0x060276A5 RID: 161445 RVA: 0x005652BF File Offset: 0x005634BF
		// (set) Token: 0x060276A6 RID: 161446 RVA: 0x005652C7 File Offset: 0x005634C7
		public bool Disabled { get; set; }

		// Token: 0x1700AE78 RID: 44664
		// (get) Token: 0x060276A7 RID: 161447 RVA: 0x005652D0 File Offset: 0x005634D0
		// (set) Token: 0x060276A8 RID: 161448 RVA: 0x005652D8 File Offset: 0x005634D8
		public TPasserbyNpcMoveUnion MoveConfig { get; set; }

		// Token: 0x1700AE79 RID: 44665
		// (get) Token: 0x060276A9 RID: 161449 RVA: 0x005652E1 File Offset: 0x005634E1
		// (set) Token: 0x060276AA RID: 161450 RVA: 0x005652E9 File Offset: 0x005634E9
		public TPasserbyNpcSpawnUnion SpawnConfig { get; set; }

		// Token: 0x1700AE7A RID: 44666
		// (get) Token: 0x060276AB RID: 161451 RVA: 0x005652F2 File Offset: 0x005634F2
		// (set) Token: 0x060276AC RID: 161452 RVA: 0x005652FA File Offset: 0x005634FA
		public IPasserbyNpcTemplateSourceT SourceConfig { get; set; }

		// Token: 0x1700AE7B RID: 44667
		// (get) Token: 0x060276AD RID: 161453 RVA: 0x00565303 File Offset: 0x00563503
		// (set) Token: 0x060276AE RID: 161454 RVA: 0x0056530B File Offset: 0x0056350B
		public string NpcMaterialDa { get; set; }

		// Token: 0x1700AE7C RID: 44668
		// (get) Token: 0x060276AF RID: 161455 RVA: 0x00565314 File Offset: 0x00563514
		// (set) Token: 0x060276B0 RID: 161456 RVA: 0x0056531C File Offset: 0x0056351C
		public IPasserbyNpcPerformanceT BornPerformance { get; set; }

		// Token: 0x1700AE7D RID: 44669
		// (get) Token: 0x060276B1 RID: 161457 RVA: 0x00565325 File Offset: 0x00563525
		// (set) Token: 0x060276B2 RID: 161458 RVA: 0x0056532D File Offset: 0x0056352D
		public IPasserbyNpcPerformanceT DestroyPerformance { get; set; }

		// Token: 0x1700AE7E RID: 44670
		// (get) Token: 0x060276B3 RID: 161459 RVA: 0x00565336 File Offset: 0x00563536
		// (set) Token: 0x060276B4 RID: 161460 RVA: 0x0056533E File Offset: 0x0056353E
		public IPasserbyNpcDeviceGradeConfigT DeviceGradeConfig { get; set; }

		// Token: 0x1700AE7F RID: 44671
		// (get) Token: 0x060276B5 RID: 161461 RVA: 0x00565347 File Offset: 0x00563547
		// (set) Token: 0x060276B6 RID: 161462 RVA: 0x0056534F File Offset: 0x0056354F
		public IConditionGroupT VisibleConditions { get; set; }

		// Token: 0x1700AE80 RID: 44672
		// (get) Token: 0x060276B7 RID: 161463 RVA: 0x00565358 File Offset: 0x00563558
		// (set) Token: 0x060276B8 RID: 161464 RVA: 0x00565360 File Offset: 0x00563560
		public byte NullMask { get; set; }

		// Token: 0x060276B9 RID: 161465 RVA: 0x0056536C File Offset: 0x0056356C
		public IPasserbyNpcSpawnComponentT()
		{
			this.Disabled = false;
			this.MoveConfig = null;
			this.SpawnConfig = null;
			this.SourceConfig = null;
			this.NpcMaterialDa = null;
			this.BornPerformance = null;
			this.DestroyPerformance = null;
			this.DeviceGradeConfig = null;
			this.VisibleConditions = null;
			this.NullMask = 0;
		}
	}
}
