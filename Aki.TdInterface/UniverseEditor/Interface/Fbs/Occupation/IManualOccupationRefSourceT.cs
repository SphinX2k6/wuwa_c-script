using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043A2 RID: 17314
	public class IManualOccupationRefSourceT
	{
		// Token: 0x17007A61 RID: 31329
		// (get) Token: 0x06019C5F RID: 105567 RVA: 0x003B0976 File Offset: 0x003AEB76
		// (set) Token: 0x06019C60 RID: 105568 RVA: 0x003B097E File Offset: 0x003AEB7E
		public ERefSourceType Type { get; set; }

		// Token: 0x06019C61 RID: 105569 RVA: 0x003B0987 File Offset: 0x003AEB87
		public IManualOccupationRefSourceT()
		{
			this.Type = ERefSourceType.AwakeEntity;
		}
	}
}
