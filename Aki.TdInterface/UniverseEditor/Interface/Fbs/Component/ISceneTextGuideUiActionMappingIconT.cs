using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EED RID: 24301
	public class ISceneTextGuideUiActionMappingIconT
	{
		// Token: 0x1700B39C RID: 45980
		// (get) Token: 0x06028C0E RID: 166926 RVA: 0x0059205F File Offset: 0x0059025F
		// (set) Token: 0x06028C0F RID: 166927 RVA: 0x00592067 File Offset: 0x00590267
		public int Id { get; set; }

		// Token: 0x1700B39D RID: 45981
		// (get) Token: 0x06028C10 RID: 166928 RVA: 0x00592070 File Offset: 0x00590270
		// (set) Token: 0x06028C11 RID: 166929 RVA: 0x00592078 File Offset: 0x00590278
		public string ActionName { get; set; }

		// Token: 0x06028C12 RID: 166930 RVA: 0x00592081 File Offset: 0x00590281
		public ISceneTextGuideUiActionMappingIconT()
		{
			this.Id = 0;
			this.ActionName = null;
		}
	}
}
