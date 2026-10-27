using System;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C40 RID: 27712
	public class LevelConditionCheckGravityFlipEntityDirectionSameAsPlayerInfo : CodeCondition
	{
		// Token: 0x170099AE RID: 39342
		// (get) Token: 0x060444DA RID: 279770 RVA: 0x010D3952 File Offset: 0x010D1B52
		public override ECodeCondition CodeType
		{
			get
			{
				return ECodeCondition.CheckGravityFlipEntityDirectionSameAsPlayer;
			}
		}

		// Token: 0x0402399C RID: 145820
		public int EntityId;
	}
}
