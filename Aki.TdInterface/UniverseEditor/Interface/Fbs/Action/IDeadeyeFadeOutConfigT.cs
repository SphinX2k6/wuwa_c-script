using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006553 RID: 25939
	public class IDeadeyeFadeOutConfigT
	{
		// Token: 0x1700C0D3 RID: 49363
		// (get) Token: 0x0602D026 RID: 184358 RVA: 0x0062D8BA File Offset: 0x0062BABA
		// (set) Token: 0x0602D027 RID: 184359 RVA: 0x0062D8C2 File Offset: 0x0062BAC2
		public float TransitionTime { get; set; }

		// Token: 0x0602D028 RID: 184360 RVA: 0x0062D8CB File Offset: 0x0062BACB
		public IDeadeyeFadeOutConfigT()
		{
			this.TransitionTime = 0f;
		}
	}
}
