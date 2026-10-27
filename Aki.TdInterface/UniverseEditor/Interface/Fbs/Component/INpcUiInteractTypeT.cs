using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200568D RID: 22157
	public class INpcUiInteractTypeT
	{
		// Token: 0x1700A4C8 RID: 42184
		// (get) Token: 0x06024F7D RID: 151421 RVA: 0x0051B112 File Offset: 0x00519312
		// (set) Token: 0x06024F7E RID: 151422 RVA: 0x0051B11A File Offset: 0x0051931A
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x06024F7F RID: 151423 RVA: 0x0051B123 File Offset: 0x00519323
		public INpcUiInteractTypeT()
		{
			this.Type = ENpcUiInteractType.HandInItem;
		}
	}
}
