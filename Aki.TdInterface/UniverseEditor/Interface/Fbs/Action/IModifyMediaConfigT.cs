using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC5 RID: 27333
	public class IModifyMediaConfigT
	{
		// Token: 0x1700CACB RID: 51915
		// (get) Token: 0x0602FE6E RID: 196206 RVA: 0x0068407A File Offset: 0x0068227A
		// (set) Token: 0x0602FE6F RID: 196207 RVA: 0x00684082 File Offset: 0x00682282
		public EModifyActorMediaType Type { get; set; }

		// Token: 0x0602FE70 RID: 196208 RVA: 0x0068408B File Offset: 0x0068228B
		public IModifyMediaConfigT()
		{
			this.Type = EModifyActorMediaType.ChangeMediaPlayDA;
		}
	}
}
