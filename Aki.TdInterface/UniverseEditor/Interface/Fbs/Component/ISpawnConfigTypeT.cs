using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005942 RID: 22850
	public class ISpawnConfigTypeT
	{
		// Token: 0x1700AB85 RID: 43909
		// (get) Token: 0x06026AB2 RID: 158386 RVA: 0x0055348A File Offset: 0x0055168A
		// (set) Token: 0x06026AB3 RID: 158387 RVA: 0x00553492 File Offset: 0x00551692
		public ESpawnConfigType Type { get; set; }

		// Token: 0x06026AB4 RID: 158388 RVA: 0x0055349B File Offset: 0x0055169B
		public ISpawnConfigTypeT()
		{
			this.Type = ESpawnConfigType.TemplateMatrix;
		}
	}
}
