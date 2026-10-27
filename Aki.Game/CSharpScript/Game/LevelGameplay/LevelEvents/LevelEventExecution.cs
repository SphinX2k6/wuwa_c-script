using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B25 RID: 27429
	public class LevelEventExecution : LevelEventBase
	{
		// Token: 0x060440F5 RID: 278773 RVA: 0x010BBFDA File Offset: 0x010BA1DA
		public LevelEventExecution(int id) : base(id)
		{
		}

		// Token: 0x060440F6 RID: 278774 RVA: 0x010BBFE4 File Offset: 0x010BA1E4
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

		// Token: 0x060440F7 RID: 278775 RVA: 0x010BC060 File Offset: 0x010BA260
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

		// Token: 0x060440F8 RID: 278776 RVA: 0x010BC0AE File Offset: 0x010BA2AE
		protected override void OnReset()
		{
			this.EntityId = 0;
		}

		// Token: 0x040238FA RID: 145658
		private int EntityId;
	}
}
