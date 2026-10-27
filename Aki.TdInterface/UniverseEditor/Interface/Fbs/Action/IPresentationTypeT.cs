using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DAB RID: 28075
	public class IPresentationTypeT
	{
		// Token: 0x1700D161 RID: 53601
		// (get) Token: 0x06031987 RID: 203143 RVA: 0x006B8862 File Offset: 0x006B6A62
		// (set) Token: 0x06031988 RID: 203144 RVA: 0x006B886A File Offset: 0x006B6A6A
		public EResetPresentationType Type { get; set; }

		// Token: 0x06031989 RID: 203145 RVA: 0x006B8873 File Offset: 0x006B6A73
		public IPresentationTypeT()
		{
			this.Type = EResetPresentationType.Failure;
		}
	}
}
