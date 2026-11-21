using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E3D RID: 20029
	public class ICheckAtlasUnlockedT
	{
		// Token: 0x17008EAC RID: 36524
		// (get) Token: 0x0601EFAB RID: 126891 RVA: 0x00453995 File Offset: 0x00451B95
		// (set) Token: 0x0601EFAC RID: 126892 RVA: 0x0045399D File Offset: 0x00451B9D
		public ECondition Type { get; set; }

		// Token: 0x17008EAD RID: 36525
		// (get) Token: 0x0601EFAD RID: 126893 RVA: 0x004539A6 File Offset: 0x00451BA6
		// (set) Token: 0x0601EFAE RID: 126894 RVA: 0x004539AE File Offset: 0x00451BAE
		public TUnlockAtlasSystemOptionV2Union Atlas { get; set; }

		// Token: 0x17008EAE RID: 36526
		// (get) Token: 0x0601EFAF RID: 126895 RVA: 0x004539B7 File Offset: 0x00451BB7
		// (set) Token: 0x0601EFB0 RID: 126896 RVA: 0x004539BF File Offset: 0x00451BBF
		public bool Unlocked { get; set; }

		// Token: 0x0601EFB1 RID: 126897 RVA: 0x004539C8 File Offset: 0x00451BC8
		public ICheckAtlasUnlockedT()
		{
			this.Type = ECondition.CompareVar;
			this.Atlas = null;
			this.Unlocked = false;
		}
	}
}
