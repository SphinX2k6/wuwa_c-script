using System;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DB5 RID: 23989
	public class LevelConditionCheckCharacterTagInfo : CodeCondition
	{
		// Token: 0x17006EAD RID: 28333
		// (get) Token: 0x0603A62A RID: 239146 RVA: 0x0107D7D6 File Offset: 0x0107B9D6
		public override ECodeCondition CodeType
		{
			get
			{
				return ECodeCondition.CheckCharacterTag;
			}
		}

		// Token: 0x0401EC37 RID: 126007
		public int TagId;

		// Token: 0x0401EC38 RID: 126008
		public bool IsContain;
	}
}
