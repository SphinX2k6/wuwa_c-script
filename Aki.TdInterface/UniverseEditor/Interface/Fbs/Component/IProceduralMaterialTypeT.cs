using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D92 RID: 23954
	public class IProceduralMaterialTypeT
	{
		// Token: 0x1700B04F RID: 45135
		// (get) Token: 0x06027E55 RID: 163413 RVA: 0x00574F0A File Offset: 0x0057310A
		// (set) Token: 0x06027E56 RID: 163414 RVA: 0x00574F12 File Offset: 0x00573112
		public EProceduralMaterialType Type { get; set; }

		// Token: 0x06027E57 RID: 163415 RVA: 0x00574F1B File Offset: 0x0057311B
		public IProceduralMaterialTypeT()
		{
			this.Type = EProceduralMaterialType.CustomPrimitiveData;
		}
	}
}
