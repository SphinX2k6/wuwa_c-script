using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071F9 RID: 29177
	public class IModifyMediaConfigT
	{
		// Token: 0x1700D593 RID: 54675
		// (get) Token: 0x06032C24 RID: 207908 RVA: 0x006DB31E File Offset: 0x006D951E
		// (set) Token: 0x06032C25 RID: 207909 RVA: 0x006DB326 File Offset: 0x006D9526
		public EModifyActorMediaType Type { get; set; }

		// Token: 0x06032C26 RID: 207910 RVA: 0x006DB32F File Offset: 0x006D952F
		public IModifyMediaConfigT()
		{
			this.Type = EModifyActorMediaType.ChangeMediaPlayDA;
		}
	}
}
