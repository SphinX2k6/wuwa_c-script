using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005196 RID: 20886
	public class IEntityMatchConfigT
	{
		// Token: 0x1700989B RID: 39067
		// (get) Token: 0x06021C9D RID: 138397 RVA: 0x004B0026 File Offset: 0x004AE226
		// (set) Token: 0x06021C9E RID: 138398 RVA: 0x004B002E File Offset: 0x004AE22E
		public EEntityMatchType Type { get; set; }

		// Token: 0x06021C9F RID: 138399 RVA: 0x004B0037 File Offset: 0x004AE237
		public IEntityMatchConfigT()
		{
			this.Type = EEntityMatchType.Player;
		}
	}
}
