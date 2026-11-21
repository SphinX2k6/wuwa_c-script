using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004347 RID: 17223
	public class ILinkSystemConfigT
	{
		// Token: 0x170075DE RID: 30174
		// (get) Token: 0x060183E5 RID: 99301 RVA: 0x00374794 File Offset: 0x00372994
		// (set) Token: 0x060183E6 RID: 99302 RVA: 0x0037479C File Offset: 0x0037299C
		public EEnableSystemType Type { get; set; }

		// Token: 0x170075DF RID: 30175
		// (get) Token: 0x060183E7 RID: 99303 RVA: 0x003747A5 File Offset: 0x003729A5
		// (set) Token: 0x060183E8 RID: 99304 RVA: 0x003747AD File Offset: 0x003729AD
		public int LinkDataId { get; set; }

		// Token: 0x060183E9 RID: 99305 RVA: 0x003747B6 File Offset: 0x003729B6
		public ILinkSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.LinkDataId = 0;
		}
	}
}
