using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200510F RID: 20751
	public class IEffectAreaModeT
	{
		// Token: 0x17009735 RID: 38709
		// (get) Token: 0x06021704 RID: 136964 RVA: 0x004A47D6 File Offset: 0x004A29D6
		// (set) Token: 0x06021705 RID: 136965 RVA: 0x004A47DE File Offset: 0x004A29DE
		public EEffectAreaType Type { get; set; }

		// Token: 0x06021706 RID: 136966 RVA: 0x004A47E7 File Offset: 0x004A29E7
		public IEffectAreaModeT()
		{
			this.Type = EEffectAreaType.BuffArea;
		}
	}
}
