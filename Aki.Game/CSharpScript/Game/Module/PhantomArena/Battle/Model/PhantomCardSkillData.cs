using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x02004273 RID: 17011
	public class PhantomCardSkillData
	{
		// Token: 0x0602B13D RID: 176445 RVA: 0x00C1CE47 File Offset: 0x00C1B047
		[NullableContext(1)]
		public void RefreshData(PhantomBattleCardSkillUnlockInfo skillInfo)
		{
			this.CardId = skillInfo.CardId;
			this.Unlock = skillInfo.Unlock;
			this.TargetNum = skillInfo.TargetNum;
			this.CurNum = skillInfo.CurNum;
		}

		// Token: 0x0401749A RID: 95386
		public int CardId;

		// Token: 0x0401749B RID: 95387
		public bool Unlock;

		// Token: 0x0401749C RID: 95388
		public int TargetNum;

		// Token: 0x0401749D RID: 95389
		public int CurNum;
	}
}
