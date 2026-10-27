using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058EC RID: 22764
	public class ISceneTextTypeBaseT
	{
		// Token: 0x1700AA93 RID: 43667
		// (get) Token: 0x06026738 RID: 157496 RVA: 0x0054C652 File Offset: 0x0054A852
		// (set) Token: 0x06026739 RID: 157497 RVA: 0x0054C65A File Offset: 0x0054A85A
		public ESceneTextType Type { get; set; }

		// Token: 0x0602673A RID: 157498 RVA: 0x0054C663 File Offset: 0x0054A863
		public ISceneTextTypeBaseT()
		{
			this.Type = ESceneTextType.SubtitleWithVoice;
		}
	}
}
