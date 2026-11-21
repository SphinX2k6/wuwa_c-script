using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FEA RID: 20458
	public class ICheckPreloadCompleteObjectTypeT
	{
		// Token: 0x17009261 RID: 37473
		// (get) Token: 0x0601FEC3 RID: 130755 RVA: 0x0046EBDA File Offset: 0x0046CDDA
		// (set) Token: 0x0601FEC4 RID: 130756 RVA: 0x0046EBE2 File Offset: 0x0046CDE2
		public ECheckPreloadCompleteObjectType Type { get; set; }

		// Token: 0x0601FEC5 RID: 130757 RVA: 0x0046EBEB File Offset: 0x0046CDEB
		public ICheckPreloadCompleteObjectTypeT()
		{
			this.Type = ECheckPreloadCompleteObjectType.PreloadLinkResource;
		}
	}
}
