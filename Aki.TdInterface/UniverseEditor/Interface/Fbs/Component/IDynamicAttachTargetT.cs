using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005638 RID: 22072
	public class IDynamicAttachTargetT
	{
		// Token: 0x17009E84 RID: 40580
		// (get) Token: 0x060233F7 RID: 144375 RVA: 0x004D9972 File Offset: 0x004D7B72
		// (set) Token: 0x060233F8 RID: 144376 RVA: 0x004D997A File Offset: 0x004D7B7A
		public EAttachType Type { get; set; }

		// Token: 0x060233F9 RID: 144377 RVA: 0x004D9983 File Offset: 0x004D7B83
		public IDynamicAttachTargetT()
		{
			this.Type = EAttachType.Actor;
		}
	}
}
