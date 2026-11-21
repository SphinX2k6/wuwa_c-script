using System;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DB7 RID: 23991
	public class LevelConditionCheckEntityTagInfo : CodeCondition
	{
		// Token: 0x17006EAF RID: 28335
		// (get) Token: 0x0603A62E RID: 239150 RVA: 0x0107D7EC File Offset: 0x0107B9EC
		public override ECodeCondition CodeType
		{
			get
			{
				return ECodeCondition.CheckEntityTag;
			}
		}

		// Token: 0x0401EC3A RID: 126010
		public int TagId;

		// Token: 0x0401EC3B RID: 126011
		public int EntityId;

		// Token: 0x0401EC3C RID: 126012
		public bool IsContain;
	}
}
