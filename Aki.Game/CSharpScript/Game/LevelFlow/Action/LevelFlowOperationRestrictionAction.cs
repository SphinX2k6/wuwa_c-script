using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.OperationRestrict;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006111 RID: 24849
	public class LevelFlowOperationRestrictionAction : LevelFlowActionBase
	{
		// Token: 0x0603B8E2 RID: 243938 RVA: 0x010E3958 File Offset: 0x010E1B58
		[NullableContext(1)]
		public LevelFlowOperationRestrictionAction Init([Nullable(2)] SetPlayerOperationRestriction param)
		{
			this.RestrictionParam = param;
			return this;
		}

		// Token: 0x0603B8E3 RID: 243939 RVA: 0x010E3964 File Offset: 0x010E1B64
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

		// Token: 0x0401F681 RID: 128641
		[Nullable(2)]
		private SetPlayerOperationRestriction RestrictionParam;
	}
}
