using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004393 RID: 17299
	public class IAwakeEntityRefSourceT
	{
		// Token: 0x17007A49 RID: 31305
		// (get) Token: 0x06019BDB RID: 105435 RVA: 0x003AF924 File Offset: 0x003ADB24
		// (set) Token: 0x06019BDC RID: 105436 RVA: 0x003AF92C File Offset: 0x003ADB2C
		public ERefSourceType Type { get; set; }

		// Token: 0x17007A4A RID: 31306
		// (get) Token: 0x06019BDD RID: 105437 RVA: 0x003AF935 File Offset: 0x003ADB35
		// (set) Token: 0x06019BDE RID: 105438 RVA: 0x003AF93D File Offset: 0x003ADB3D
		public int EntityId { get; set; }

		// Token: 0x06019BDF RID: 105439 RVA: 0x003AF946 File Offset: 0x003ADB46
		public IAwakeEntityRefSourceT()
		{
			this.Type = ERefSourceType.AwakeEntity;
			this.EntityId = 0;
		}
	}
}
