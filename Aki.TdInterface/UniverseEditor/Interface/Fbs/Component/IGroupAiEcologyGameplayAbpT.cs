using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058BA RID: 22714
	public class IGroupAiEcologyGameplayAbpT
	{
		// Token: 0x1700A4B4 RID: 42164
		// (get) Token: 0x06024DFF RID: 151039 RVA: 0x00510706 File Offset: 0x0050E906
		// (set) Token: 0x06024E00 RID: 151040 RVA: 0x0051070E File Offset: 0x0050E90E
		public EGroupAiEcologyGameplayType GameplayType { get; set; }

		// Token: 0x06024E01 RID: 151041 RVA: 0x00510717 File Offset: 0x0050E917
		public IGroupAiEcologyGameplayAbpT()
		{
			this.GameplayType = EGroupAiEcologyGameplayType.FloatParade;
		}
	}
}
