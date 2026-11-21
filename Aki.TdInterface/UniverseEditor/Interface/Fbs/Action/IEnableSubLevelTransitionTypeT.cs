using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D05 RID: 27909
	public class IEnableSubLevelTransitionTypeT
	{
		// Token: 0x1700CCC8 RID: 52424
		// (get) Token: 0x0603021E RID: 197150 RVA: 0x0068BEB6 File Offset: 0x0068A0B6
		// (set) Token: 0x0603021F RID: 197151 RVA: 0x0068BEBE File Offset: 0x0068A0BE
		public EEnableSubLevelTransitionType Type { get; set; }

		// Token: 0x06030220 RID: 197152 RVA: 0x0068BEC7 File Offset: 0x0068A0C7
		public IEnableSubLevelTransitionTypeT()
		{
			this.Type = EEnableSubLevelTransitionType.SceneCapture;
		}
	}
}
