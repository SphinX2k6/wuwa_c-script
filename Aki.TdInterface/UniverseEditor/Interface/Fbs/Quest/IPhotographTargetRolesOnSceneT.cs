using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043D7 RID: 17367
	public class IPhotographTargetRolesOnSceneT
	{
		// Token: 0x170077A3 RID: 30627
		// (get) Token: 0x06018A9D RID: 101021 RVA: 0x00384536 File Offset: 0x00382736
		// (set) Token: 0x06018A9E RID: 101022 RVA: 0x0038453E File Offset: 0x0038273E
		public EPhotographTargetType Type { get; set; }

		// Token: 0x06018A9F RID: 101023 RVA: 0x00384547 File Offset: 0x00382747
		public IPhotographTargetRolesOnSceneT()
		{
			this.Type = EPhotographTargetType.Player;
		}
	}
}
