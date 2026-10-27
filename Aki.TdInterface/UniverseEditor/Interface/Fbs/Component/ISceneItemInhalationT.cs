using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C5 RID: 22725
	public class ISceneItemInhalationT
	{
		// Token: 0x1700AA28 RID: 43560
		// (get) Token: 0x0602659E RID: 157086 RVA: 0x005490B6 File Offset: 0x005472B6
		// (set) Token: 0x0602659F RID: 157087 RVA: 0x005490BE File Offset: 0x005472BE
		public EInhalationPerformanceType Type { get; set; }

		// Token: 0x060265A0 RID: 157088 RVA: 0x005490C7 File Offset: 0x005472C7
		public ISceneItemInhalationT()
		{
			this.Type = EInhalationPerformanceType.Role;
		}
	}
}
