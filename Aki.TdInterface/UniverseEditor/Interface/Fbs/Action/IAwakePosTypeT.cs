using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200683F RID: 26687
	public class IAwakePosTypeT
	{
		// Token: 0x1700C43E RID: 50238
		// (get) Token: 0x0602D9DB RID: 186843 RVA: 0x0063DB7E File Offset: 0x0063BD7E
		// (set) Token: 0x0602D9DC RID: 186844 RVA: 0x0063DB86 File Offset: 0x0063BD86
		public EAwakePosType Type { get; set; }

		// Token: 0x0602D9DD RID: 186845 RVA: 0x0063DB8F File Offset: 0x0063BD8F
		public IAwakePosTypeT()
		{
			this.Type = EAwakePosType.TransformVar;
		}
	}
}
