using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A9B RID: 27291
	public class IMechStuntLevelFlyT
	{
		// Token: 0x1700CA91 RID: 51857
		// (get) Token: 0x0602FD38 RID: 195896 RVA: 0x00681C56 File Offset: 0x0067FE56
		// (set) Token: 0x0602FD39 RID: 195897 RVA: 0x00681C5E File Offset: 0x0067FE5E
		public EMechStuntType Type { get; set; }

		// Token: 0x0602FD3A RID: 195898 RVA: 0x00681C67 File Offset: 0x0067FE67
		public IMechStuntLevelFlyT()
		{
			this.Type = EMechStuntType.Dive;
		}
	}
}
