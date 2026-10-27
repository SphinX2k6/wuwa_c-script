using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200578B RID: 22411
	public class IProceduralMaterialTypeT
	{
		// Token: 0x1700A72B RID: 42795
		// (get) Token: 0x06025935 RID: 153909 RVA: 0x0052ED7E File Offset: 0x0052CF7E
		// (set) Token: 0x06025936 RID: 153910 RVA: 0x0052ED86 File Offset: 0x0052CF86
		public EProceduralMaterialType Type { get; set; }

		// Token: 0x06025937 RID: 153911 RVA: 0x0052ED8F File Offset: 0x0052CF8F
		public IProceduralMaterialTypeT()
		{
			this.Type = EProceduralMaterialType.CustomPrimitiveData;
		}
	}
}
