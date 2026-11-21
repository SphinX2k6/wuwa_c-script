using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200718B RID: 29067
	public class IMainScreenT
	{
		// Token: 0x1700D4C8 RID: 54472
		// (get) Token: 0x06032886 RID: 206982 RVA: 0x006D43CE File Offset: 0x006D25CE
		// (set) Token: 0x06032887 RID: 206983 RVA: 0x006D43D6 File Offset: 0x006D25D6
		public EScreenType Type { get; set; }

		// Token: 0x06032888 RID: 206984 RVA: 0x006D43DF File Offset: 0x006D25DF
		public IMainScreenT()
		{
			this.Type = EScreenType.Main;
		}
	}
}
