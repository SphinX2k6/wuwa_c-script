using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059B8 RID: 22968
	public class IInteractAdditionalInfoT
	{
		// Token: 0x1700A6C0 RID: 42688
		// (get) Token: 0x06025745 RID: 153413 RVA: 0x005231B6 File Offset: 0x005213B6
		// (set) Token: 0x06025746 RID: 153414 RVA: 0x005231BE File Offset: 0x005213BE
		public EInteractAdditionalInfoType Type { get; set; }

		// Token: 0x06025747 RID: 153415 RVA: 0x005231C7 File Offset: 0x005213C7
		public IInteractAdditionalInfoT()
		{
			this.Type = EInteractAdditionalInfoType.FishingPoint;
		}
	}
}
