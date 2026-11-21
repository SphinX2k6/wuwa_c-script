using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A6F RID: 19055
	public class DreamLinkDefine : IStaticVariableResetter
	{
		// Token: 0x0602FB50 RID: 195408 RVA: 0x00D4F3C6 File Offset: 0x00D4D5C6
		static DreamLinkDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DreamLinkDefine.CreateStaticDefaultValue), new Action(DreamLinkDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0602FB51 RID: 195409 RVA: 0x00D4F3E5 File Offset: 0x00D4D5E5
		public static void CreateStaticDefaultValue()
		{
			Dictionary<SignState, EActivityTaskState> dictionary = new Dictionary<SignState, EActivityTaskState>();
			dictionary[SignState.Lock] = EActivityTaskState.Active;
			dictionary[SignState.Unlock] = EActivityTaskState.FinishedAndUnclaimed;
			dictionary[SignState.IsReceive] = EActivityTaskState.FinishedAndClaimed;
			DreamLinkDefine.signStateResolver = dictionary;
		}

		// Token: 0x0602FB52 RID: 195410 RVA: 0x00D4F409 File Offset: 0x00D4D609
		public static void ResetStaticDefaultValue()
		{
			DreamLinkDefine.signStateResolver = null;
		}

		// Token: 0x0401951D RID: 103709
		public const int CHANGE_STATE_FINISH_COUNT = 3;

		// Token: 0x0401951E RID: 103710
		public const int BOSS_INST_ROLE_COUNT = 3;

		// Token: 0x0401951F RID: 103711
		public const int WORLD_RUN_ENDING_ID = 3020;

		// Token: 0x04019520 RID: 103712
		[Nullable(2)]
		public static Dictionary<SignState, EActivityTaskState> signStateResolver;
	}
}
