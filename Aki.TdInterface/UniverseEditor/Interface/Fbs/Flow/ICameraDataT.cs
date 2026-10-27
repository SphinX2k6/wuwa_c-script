using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004728 RID: 18216
	public class ICameraDataT
	{
		// Token: 0x17008290 RID: 33424
		// (get) Token: 0x0601BFD5 RID: 114645 RVA: 0x003F7706 File Offset: 0x003F5906
		// (set) Token: 0x0601BFD6 RID: 114646 RVA: 0x003F770E File Offset: 0x003F590E
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17008291 RID: 33425
		// (get) Token: 0x0601BFD7 RID: 114647 RVA: 0x003F7717 File Offset: 0x003F5917
		// (set) Token: 0x0601BFD8 RID: 114648 RVA: 0x003F771F File Offset: 0x003F591F
		public IVectorInfoT Rot { get; set; }

		// Token: 0x0601BFD9 RID: 114649 RVA: 0x003F7728 File Offset: 0x003F5928
		public ICameraDataT()
		{
			this.Pos = null;
			this.Rot = null;
		}
	}
}
