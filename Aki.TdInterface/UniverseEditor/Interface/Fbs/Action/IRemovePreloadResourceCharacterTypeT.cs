using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075E0 RID: 30176
	public class IRemovePreloadResourceCharacterTypeT
	{
		// Token: 0x1700DDCA RID: 56778
		// (get) Token: 0x06034F08 RID: 216840 RVA: 0x0071D076 File Offset: 0x0071B276
		// (set) Token: 0x06034F09 RID: 216841 RVA: 0x0071D07E File Offset: 0x0071B27E
		public ERemovePreloadResourceObjectType Type { get; set; }

		// Token: 0x06034F0A RID: 216842 RVA: 0x0071D087 File Offset: 0x0071B287
		public IRemovePreloadResourceCharacterTypeT()
		{
			this.Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
		}
	}
}
