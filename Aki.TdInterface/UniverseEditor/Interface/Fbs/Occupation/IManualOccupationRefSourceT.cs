using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004804 RID: 18436
	public class IManualOccupationRefSourceT
	{
		// Token: 0x17008096 RID: 32918
		// (get) Token: 0x0601B3ED RID: 111597 RVA: 0x003DC39E File Offset: 0x003DA59E
		// (set) Token: 0x0601B3EE RID: 111598 RVA: 0x003DC3A6 File Offset: 0x003DA5A6
		public ERefSourceType Type { get; set; }

		// Token: 0x0601B3EF RID: 111599 RVA: 0x003DC3AF File Offset: 0x003DA5AF
		public IManualOccupationRefSourceT()
		{
			this.Type = ERefSourceType.AwakeEntity;
		}
	}
}
