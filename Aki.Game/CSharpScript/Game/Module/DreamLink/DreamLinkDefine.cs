using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005A93 RID: 23187
	public class DreamLinkDefine : IStaticVariableResetter
	{
		// Token: 0x0603AC07 RID: 240647 RVA: 0x00DFEE5E File Offset: 0x00DFD05E
		static DreamLinkDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DreamLinkDefine.CreateStaticDefaultValue), new Action(DreamLinkDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0603AC08 RID: 240648 RVA: 0x00DFEE7D File Offset: 0x00DFD07D
		public static void CreateStaticDefaultValue()
		{
			Dictionary<SignState, EActivityTaskState> dictionary = new Dictionary<SignState, EActivityTaskState>();
			dictionary[SignState.Lock] = EActivityTaskState.Active;
			dictionary[SignState.Unlock] = EActivityTaskState.FinishedAndUnclaimed;
			dictionary[SignState.IsReceive] = EActivityTaskState.FinishedAndClaimed;
			DreamLinkDefine.signStateResolver = dictionary;
		}

		// Token: 0x0603AC09 RID: 240649 RVA: 0x00DFEEA1 File Offset: 0x00DFD0A1
		public static void ResetStaticDefaultValue()
		{
			DreamLinkDefine.signStateResolver = null;
		}

		// Token: 0x0401EA76 RID: 125558
		public const int CHANGE_STATE_FINISH_COUNT = 3;

		// Token: 0x0401EA77 RID: 125559
		public const int BOSS_INST_ROLE_COUNT = 3;

		// Token: 0x0401EA78 RID: 125560
		public const int WORLD_RUN_ENDING_ID = 3020;

		// Token: 0x0401EA79 RID: 125561
		[Nullable(2)]
		public static Dictionary<SignState, EActivityTaskState> signStateResolver;
	}
}
