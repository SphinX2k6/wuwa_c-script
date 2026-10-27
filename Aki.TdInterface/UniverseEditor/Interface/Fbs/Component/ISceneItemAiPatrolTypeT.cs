using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058B0 RID: 22704
	public class ISceneItemAiPatrolTypeT
	{
		// Token: 0x1700AA01 RID: 43521
		// (get) Token: 0x060264EC RID: 156908 RVA: 0x00547BF2 File Offset: 0x00545DF2
		// (set) Token: 0x060264ED RID: 156909 RVA: 0x00547BFA File Offset: 0x00545DFA
		public ESceneItemAiPatrolType Type { get; set; }

		// Token: 0x060264EE RID: 156910 RVA: 0x00547C03 File Offset: 0x00545E03
		public ISceneItemAiPatrolTypeT()
		{
			this.Type = ESceneItemAiPatrolType.ByGameTime;
		}
	}
}
