using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B89 RID: 23433
	public class INavMeshSourceTypeBaseT
	{
		// Token: 0x1700AB4C RID: 43852
		// (get) Token: 0x060269EE RID: 158190 RVA: 0x00549D6E File Offset: 0x00547F6E
		// (set) Token: 0x060269EF RID: 158191 RVA: 0x00549D76 File Offset: 0x00547F76
		public ENavMeshSourceType Type { get; set; }

		// Token: 0x060269F0 RID: 158192 RVA: 0x00549D7F File Offset: 0x00547F7F
		public INavMeshSourceTypeBaseT()
		{
			this.Type = ENavMeshSourceType.AkiEntitySource;
		}
	}
}
