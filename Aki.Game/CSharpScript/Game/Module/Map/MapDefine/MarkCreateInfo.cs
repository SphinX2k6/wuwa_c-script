using System;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004558 RID: 17752
	public class MarkCreateInfo
	{
		// Token: 0x17005A1E RID: 23070
		// (get) Token: 0x0602CBBA RID: 183226 RVA: 0x00C871C4 File Offset: 0x00C853C4
		// (set) Token: 0x0602CBBB RID: 183227 RVA: 0x00C871CC File Offset: 0x00C853CC
		public virtual EMarkCreateType CreateType { get; protected set; }

		// Token: 0x0602CBBC RID: 183228 RVA: 0x00C871D5 File Offset: 0x00C853D5
		public MarkCreateInfo(EMarkCreateType createType)
		{
			this.CreateType = createType;
		}
	}
}
