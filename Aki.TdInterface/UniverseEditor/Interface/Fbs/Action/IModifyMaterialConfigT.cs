using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071F3 RID: 29171
	public class IModifyMaterialConfigT
	{
		// Token: 0x1700D58E RID: 54670
		// (get) Token: 0x06032C04 RID: 207876 RVA: 0x006DB05E File Offset: 0x006D925E
		// (set) Token: 0x06032C05 RID: 207877 RVA: 0x006DB066 File Offset: 0x006D9266
		public EModifyActorMaterialType Type { get; set; }

		// Token: 0x06032C06 RID: 207878 RVA: 0x006DB06F File Offset: 0x006D926F
		public IModifyMaterialConfigT()
		{
			this.Type = EModifyActorMaterialType.ChangeMaterialData;
		}
	}
}
