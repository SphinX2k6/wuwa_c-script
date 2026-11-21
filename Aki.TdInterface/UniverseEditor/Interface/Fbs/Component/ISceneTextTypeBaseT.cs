using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EF9 RID: 24313
	public class ISceneTextTypeBaseT
	{
		// Token: 0x1700B3C7 RID: 46023
		// (get) Token: 0x06028CA2 RID: 167074 RVA: 0x005932BE File Offset: 0x005914BE
		// (set) Token: 0x06028CA3 RID: 167075 RVA: 0x005932C6 File Offset: 0x005914C6
		public ESceneTextType Type { get; set; }

		// Token: 0x06028CA4 RID: 167076 RVA: 0x005932CF File Offset: 0x005914CF
		public ISceneTextTypeBaseT()
		{
			this.Type = ESceneTextType.SubtitleWithVoice;
		}
	}
}
