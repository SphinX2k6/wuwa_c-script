using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006862 RID: 26722
	public class IFoxPutDownT
	{
		// Token: 0x1700C67F RID: 50815
		// (get) Token: 0x0602E995 RID: 190869 RVA: 0x0065B26E File Offset: 0x0065946E
		// (set) Token: 0x0602E996 RID: 190870 RVA: 0x0065B276 File Offset: 0x00659476
		public ELeisureInteract Type { get; set; }

		// Token: 0x0602E997 RID: 190871 RVA: 0x0065B27F File Offset: 0x0065947F
		public IFoxPutDownT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
