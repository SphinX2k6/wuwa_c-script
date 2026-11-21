using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D7 RID: 21463
	public class IAnimalModelConfigT
	{
		// Token: 0x170097E6 RID: 38886
		// (get) Token: 0x06021887 RID: 137351 RVA: 0x0049FDF2 File Offset: 0x0049DFF2
		// (set) Token: 0x06021888 RID: 137352 RVA: 0x0049FDFA File Offset: 0x0049DFFA
		public EAnimalModelType Type { get; set; }

		// Token: 0x06021889 RID: 137353 RVA: 0x0049FE03 File Offset: 0x0049E003
		public IAnimalModelConfigT()
		{
			this.Type = EAnimalModelType.Mesh;
		}
	}
}
