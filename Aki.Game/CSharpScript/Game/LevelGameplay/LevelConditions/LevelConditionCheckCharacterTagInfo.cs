using System;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C3C RID: 27708
	public class LevelConditionCheckCharacterTagInfo : CodeCondition
	{
		// Token: 0x170099AA RID: 39338
		// (get) Token: 0x060444D2 RID: 279762 RVA: 0x010D3926 File Offset: 0x010D1B26
		public override ECodeCondition CodeType
		{
			get
			{
				return ECodeCondition.CheckCharacterTag;
			}
		}

		// Token: 0x04023995 RID: 145813
		public int TagId;

		// Token: 0x04023996 RID: 145814
		public bool IsContain;
	}
}
