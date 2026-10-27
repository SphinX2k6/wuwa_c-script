using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x020052A3 RID: 21155
	public class PhantomCardSkillData
	{
		// Token: 0x06036242 RID: 221762 RVA: 0x00CCF71F File Offset: 0x00CCD91F
		[NullableContext(1)]
		public void RefreshData(PhantomBattleCardSkillUnlockInfo skillInfo)
		{
			this.CardId = skillInfo.CardId;
			this.Unlock = skillInfo.Unlock;
			this.TargetNum = skillInfo.TargetNum;
			this.CurNum = skillInfo.CurNum;
		}

		// Token: 0x0401CA65 RID: 117349
		public int CardId;

		// Token: 0x0401CA66 RID: 117350
		public bool Unlock;

		// Token: 0x0401CA67 RID: 117351
		public int TargetNum;

		// Token: 0x0401CA68 RID: 117352
		public int CurNum;
	}
}
