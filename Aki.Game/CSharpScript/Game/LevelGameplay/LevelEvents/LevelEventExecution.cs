using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C9D RID: 23709
	public class LevelEventExecution : LevelEventBase
	{
		// Token: 0x0603A247 RID: 238151 RVA: 0x01065866 File Offset: 0x01063A66
		public LevelEventExecution(int id) : base(id)
		{
		}

		// Token: 0x0603A248 RID: 238152 RVA: 0x01065870 File Offset: 0x01063A70
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (context.Type.GetValueOrDefault() != EGeneralContextType.Entity)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			EntityContext entityContext = context as EntityContext;
			Entity entity = EntitySystem.Instance.Get(entityContext.EntityId.Value);
			if (entity == null || !entity.Valid)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			this.EntityId = entityContext.EntityId.Value;
			this.HandleExecutionSuccess();
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A249 RID: 238153 RVA: 0x010658EC File Offset: 0x01063AEC
		private void HandleExecutionSuccess()
		{
			Entity entity = EntitySystem.Instance.Get(this.EntityId);
			if (entity == null)
			{
				return;
			}
			ExecutionComponent component = entity.GetComponent<ExecutionComponent>();
			if (component == null)
			{
				global::Log.Instance.Error(ELogModule.Battle, ELogAuthor.YZ, "Can not find ExecutionComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			component.StartExecution();
		}

		// Token: 0x0603A24A RID: 238154 RVA: 0x0106593A File Offset: 0x01063B3A
		protected override void OnReset()
		{
			this.EntityId = 0;
		}

		// Token: 0x0401EB9C RID: 125852
		private int EntityId;
	}
}
