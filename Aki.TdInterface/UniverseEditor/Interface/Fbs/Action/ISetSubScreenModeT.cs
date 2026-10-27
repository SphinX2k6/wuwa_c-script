using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007083 RID: 28803
	public class ISetSubScreenModeT
	{
		// Token: 0x1700D60B RID: 54795
		// (get) Token: 0x06033002 RID: 208898 RVA: 0x006E1241 File Offset: 0x006DF441
		// (set) Token: 0x06033003 RID: 208899 RVA: 0x006E1249 File Offset: 0x006DF449
		public TSubScreenModeUnion Config { get; set; }

		// Token: 0x06033004 RID: 208900 RVA: 0x006E1252 File Offset: 0x006DF452
		public ISetSubScreenModeT()
		{
			this.Config = null;
		}
	}
}
