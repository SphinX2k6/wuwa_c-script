using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006BB0 RID: 27568
	public class LevelEventUnlockDungeonEntry : LevelEventBase
	{
		// Token: 0x0604431B RID: 279323 RVA: 0x010CECA4 File Offset: 0x010CCEA4
		public LevelEventUnlockDungeonEntry(int id) : base(id)
		{
		}

		// Token: 0x0604431C RID: 279324 RVA: 0x010CECB0 File Offset: 0x010CCEB0
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			global::Log.Instance.Info(ELogModule.InstanceDungeon, ELogAuthor.LJQ, "注意，该行为已经废弃，通知程序处理", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}
}
