using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004137 RID: 16695
	public class ISpecialGamePlayConfigT
	{
		// Token: 0x17007643 RID: 30275
		// (get) Token: 0x060187CC RID: 100300 RVA: 0x00387B8A File Offset: 0x00385D8A
		// (set) Token: 0x060187CD RID: 100301 RVA: 0x00387B92 File Offset: 0x00385D92
		public ESpecialGamePlayConfigType Type { get; set; }

		// Token: 0x060187CE RID: 100302 RVA: 0x00387B9B File Offset: 0x00385D9B
		public ISpecialGamePlayConfigT()
		{
			this.Type = ESpecialGamePlayConfigType.Stalking;
		}
	}
}
