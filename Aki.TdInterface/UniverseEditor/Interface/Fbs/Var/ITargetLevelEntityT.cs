using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EE4 RID: 16100
	public class ITargetLevelEntityT
	{
		// Token: 0x17006D06 RID: 27910
		// (get) Token: 0x06015D46 RID: 89414 RVA: 0x00323FD4 File Offset: 0x003221D4
		// (set) Token: 0x06015D47 RID: 89415 RVA: 0x00323FDC File Offset: 0x003221DC
		public ETargetType Type { get; set; }

		// Token: 0x17006D07 RID: 27911
		// (get) Token: 0x06015D48 RID: 89416 RVA: 0x00323FE5 File Offset: 0x003221E5
		// (set) Token: 0x06015D49 RID: 89417 RVA: 0x00323FED File Offset: 0x003221ED
		public int Id { get; set; }

		// Token: 0x06015D4A RID: 89418 RVA: 0x00323FF6 File Offset: 0x003221F6
		public ITargetLevelEntityT()
		{
			this.Type = ETargetType.Player;
			this.Id = 0;
		}
	}
}
