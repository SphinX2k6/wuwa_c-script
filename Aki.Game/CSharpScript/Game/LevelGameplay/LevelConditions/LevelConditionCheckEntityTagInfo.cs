using System;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C3E RID: 27710
	public class LevelConditionCheckEntityTagInfo : CodeCondition
	{
		// Token: 0x170099AC RID: 39340
		// (get) Token: 0x060444D6 RID: 279766 RVA: 0x010D393C File Offset: 0x010D1B3C
		public override ECodeCondition CodeType
		{
			get
			{
				return ECodeCondition.CheckEntityTag;
			}
		}

		// Token: 0x04023998 RID: 145816
		public int TagId;

		// Token: 0x04023999 RID: 145817
		public int EntityId;

		// Token: 0x0402399A RID: 145818
		public bool IsContain;
	}
}
