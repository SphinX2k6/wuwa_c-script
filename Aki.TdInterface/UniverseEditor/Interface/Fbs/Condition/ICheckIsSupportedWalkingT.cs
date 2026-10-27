using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A9D RID: 19101
	public class ICheckIsSupportedWalkingT
	{
		// Token: 0x17008A67 RID: 35431
		// (get) Token: 0x0601DF74 RID: 122740 RVA: 0x004350A8 File Offset: 0x004332A8
		// (set) Token: 0x0601DF75 RID: 122741 RVA: 0x004350B0 File Offset: 0x004332B0
		public ECondition Type { get; set; }

		// Token: 0x17008A68 RID: 35432
		// (get) Token: 0x0601DF76 RID: 122742 RVA: 0x004350B9 File Offset: 0x004332B9
		// (set) Token: 0x0601DF77 RID: 122743 RVA: 0x004350C1 File Offset: 0x004332C1
		public bool IsSupported { get; set; }

		// Token: 0x0601DF78 RID: 122744 RVA: 0x004350CA File Offset: 0x004332CA
		public ICheckIsSupportedWalkingT()
		{
			this.Type = ECondition.CompareVar;
			this.IsSupported = false;
		}
	}
}
