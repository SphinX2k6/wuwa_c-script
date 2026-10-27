using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DBD RID: 28093
	public class IProjectorPuzzleT
	{
		// Token: 0x1700D181 RID: 53633
		// (get) Token: 0x06031A09 RID: 203273 RVA: 0x006B958E File Offset: 0x006B778E
		// (set) Token: 0x06031A0A RID: 203274 RVA: 0x006B9596 File Offset: 0x006B7796
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x06031A0B RID: 203275 RVA: 0x006B959F File Offset: 0x006B779F
		public IProjectorPuzzleT()
		{
			this.Type = ESimpleGameplayType.Cipher;
		}
	}
}
