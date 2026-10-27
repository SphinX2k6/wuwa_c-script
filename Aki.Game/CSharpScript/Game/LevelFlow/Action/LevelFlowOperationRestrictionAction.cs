using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.OperationRestrict;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F90 RID: 28560
	public class LevelFlowOperationRestrictionAction : LevelFlowActionBase
	{
		// Token: 0x06045734 RID: 284468 RVA: 0x01139B54 File Offset: 0x01137D54
		[NullableContext(1)]
		public LevelFlowOperationRestrictionAction Init([Nullable(2)] SetPlayerOperationRestriction param)
		{
			this.RestrictionParam = param;
			return this;
		}

		// Token: 0x06045735 RID: 284469 RVA: 0x01139B60 File Offset: 0x01137D60
		protected override void OnExecute()
		{
			EventSystem.Instance.Emit<string>(EEventName.ForceReleaseInput, "Set Player Operation Action");
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelFlow;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "关卡事件-设置玩家操作限制";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("配置param:", this.RestrictionParam);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			OperationRestrictUtils.Instance.SetOperationRestrictByOption(this.RestrictionParam);
			base.FinishExecute(true);
		}

		// Token: 0x040243CC RID: 148428
		[Nullable(2)]
		private SetPlayerOperationRestriction RestrictionParam;
	}
}
