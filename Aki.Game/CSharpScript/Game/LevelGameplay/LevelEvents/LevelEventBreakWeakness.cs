using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C6E RID: 23662
	public class LevelEventBreakWeakness : LevelEventBase
	{
		// Token: 0x0603A166 RID: 237926 RVA: 0x0105B6C5 File Offset: 0x010598C5
		public LevelEventBreakWeakness(int id) : base(id)
		{
		}

		// Token: 0x0603A167 RID: 237927 RVA: 0x0105B6D0 File Offset: 0x010598D0
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (context.Type.GetValueOrDefault() != EGeneralContextType.Entity)
			{
				global::Log.Instance.Info(ELogModule.Battle, ELogAuthor.CFT, "破弱交互类型不是EGeneralContextType.Entity，不往下执行", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false, false, true);
				return;
			}
			Entity entity = EntitySystem.Instance.Get((context as EntityContext).EntityId.Value);
			if (entity == null || !entity.Valid)
			{
				global::Log.Instance.Info(ELogModule.Battle, ELogAuthor.CFT, "破弱目标不存在或非法，不往下执行", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false, false, true);
				return;
			}
			global::Log.Instance.Info(ELogModule.Battle, ELogAuthor.CFT, "发送怪物开始破弱事件", default(ReadOnlySpan<ValueTuple<string, object>>));
			EventSystem.Instance.Emit<int>(EEventName.MonsterBeginBroken, entity.Id);
			base.FinishExecute(true, false, true);
		}
	}
}
