using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB1 RID: 28081
	public class IProgramSpecialConfigBaseT
	{
		// Token: 0x1700D166 RID: 53606
		// (get) Token: 0x060319A5 RID: 203173 RVA: 0x006B8AD6 File Offset: 0x006B6CD6
		// (set) Token: 0x060319A6 RID: 203174 RVA: 0x006B8ADE File Offset: 0x006B6CDE
		public EPlayMovieProgramSpecialConfigType Type { get; set; }

		// Token: 0x060319A7 RID: 203175 RVA: 0x006B8AE7 File Offset: 0x006B6CE7
		public IProgramSpecialConfigBaseT()
		{
			this.Type = EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial;
		}
	}
}
