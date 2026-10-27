using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058AD RID: 22701
	public class ISceneItemAiPatrolByGameTimeT
	{
		// Token: 0x1700A9FD RID: 43517
		// (get) Token: 0x060264D8 RID: 156888 RVA: 0x00547A54 File Offset: 0x00545C54
		// (set) Token: 0x060264D9 RID: 156889 RVA: 0x00547A5C File Offset: 0x00545C5C
		public ESceneItemAiPatrolType Type { get; set; }

		// Token: 0x1700A9FE RID: 43518
		// (get) Token: 0x060264DA RID: 156890 RVA: 0x00547A65 File Offset: 0x00545C65
		// (set) Token: 0x060264DB RID: 156891 RVA: 0x00547A6D File Offset: 0x00545C6D
		public int Spline { get; set; }

		// Token: 0x060264DC RID: 156892 RVA: 0x00547A76 File Offset: 0x00545C76
		public ISceneItemAiPatrolByGameTimeT()
		{
			this.Type = ESceneItemAiPatrolType.ByGameTime;
			this.Spline = 0;
		}
	}
}
