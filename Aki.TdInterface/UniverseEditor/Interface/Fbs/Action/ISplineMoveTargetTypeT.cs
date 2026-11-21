using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007966 RID: 31078
	public class ISplineMoveTargetTypeT
	{
		// Token: 0x1700E3EB RID: 58347
		// (get) Token: 0x06036BC0 RID: 224192 RVA: 0x007528D2 File Offset: 0x00750AD2
		// (set) Token: 0x06036BC1 RID: 224193 RVA: 0x007528DA File Offset: 0x00750ADA
		public ESplineMoveTargetType Type { get; set; }

		// Token: 0x06036BC2 RID: 224194 RVA: 0x007528E3 File Offset: 0x00750AE3
		public ISplineMoveTargetTypeT()
		{
			this.Type = ESplineMoveTargetType.Entity;
		}
	}
}
