using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F4F RID: 24399
	public class ISpawnConfigTypeT
	{
		// Token: 0x1700B4B9 RID: 46265
		// (get) Token: 0x0602901C RID: 167964 RVA: 0x0059A0F6 File Offset: 0x005982F6
		// (set) Token: 0x0602901D RID: 167965 RVA: 0x0059A0FE File Offset: 0x005982FE
		public ESpawnConfigType Type { get; set; }

		// Token: 0x0602901E RID: 167966 RVA: 0x0059A107 File Offset: 0x00598307
		public ISpawnConfigTypeT()
		{
			this.Type = ESpawnConfigType.TemplateMatrix;
		}
	}
}
