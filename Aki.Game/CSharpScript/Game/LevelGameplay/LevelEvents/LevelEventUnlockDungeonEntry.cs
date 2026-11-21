using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D29 RID: 23849
	public class LevelEventUnlockDungeonEntry : LevelEventBase
	{
		// Token: 0x0603A473 RID: 238707 RVA: 0x01078BBB File Offset: 0x01076DBB
		public LevelEventUnlockDungeonEntry(int id) : base(id)
		{
		}

		// Token: 0x0603A474 RID: 238708 RVA: 0x01078BC4 File Offset: 0x01076DC4
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			global::Log.Instance.Info(ELogModule.InstanceDungeon, ELogAuthor.LJQ, "注意，该行为已经废弃，通知程序处理", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}
}
