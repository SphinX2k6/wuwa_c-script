using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007239 RID: 29241
	public class ISummonVehicleT
	{
		// Token: 0x1700D8FE RID: 55550
		// (get) Token: 0x06033DD8 RID: 212440 RVA: 0x006FA66D File Offset: 0x006F886D
		// (set) Token: 0x06033DD9 RID: 212441 RVA: 0x006FA675 File Offset: 0x006F8875
		public ESummonEntityType Type { get; set; }

		// Token: 0x1700D8FF RID: 55551
		// (get) Token: 0x06033DDA RID: 212442 RVA: 0x006FA67E File Offset: 0x006F887E
		// (set) Token: 0x06033DDB RID: 212443 RVA: 0x006FA686 File Offset: 0x006F8886
		public string TemplateId { get; set; }

		// Token: 0x1700D900 RID: 55552
		// (get) Token: 0x06033DDC RID: 212444 RVA: 0x006FA68F File Offset: 0x006F888F
		// (set) Token: 0x06033DDD RID: 212445 RVA: 0x006FA697 File Offset: 0x006F8897
		public int PositionEntityId { get; set; }

		// Token: 0x06033DDE RID: 212446 RVA: 0x006FA6A0 File Offset: 0x006F88A0
		public ISummonVehicleT()
		{
			this.Type = ESummonEntityType.Vehicle;
			this.TemplateId = null;
			this.PositionEntityId = 0;
		}
	}
}
