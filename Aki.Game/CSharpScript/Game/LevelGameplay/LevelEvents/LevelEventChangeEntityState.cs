using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006AFD RID: 27389
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelEventChangeEntityState : LevelEventBase
	{
		// Token: 0x06044034 RID: 278580 RVA: 0x010B5889 File Offset: 0x010B3A89
		public LevelEventChangeEntityState(int id) : base(id)
		{
		}

		// Token: 0x06044035 RID: 278581 RVA: 0x010B5894 File Offset: 0x010B3A94
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if ((context.Type.GetValueOrDefault() != EGeneralContextType.Entity || !(context as EntityContext).ClientExecuteActions) && (context.Type.GetValueOrDefault() != EGeneralContextType.Trigger || !(context as TriggerContext).IsClientTrigger))
			{
				base.FinishExecute(true, false, true);
				return;
			}
			this.Config = (inParams as ChangeEntityState);
			int? num = null;
			switch (this.Config.Type)
			{
			case EChangeEntityState.Directly:
				num = new int?(GameplayTagUtils.GetTagIdByName((this.Config as IChangeEntityStateDirectly).State));
				this.EntityIds = new List<int>
				{
					this.Config.EntityId
				};
				break;
			case EChangeEntityState.BatchDirectly:
			{
				IChangeEntityStateBatchDirectly changeEntityStateBatchDirectly = this.Config as IChangeEntityStateBatchDirectly;
				num = new int?(GameplayTagUtils.GetTagIdByName(changeEntityStateBatchDirectly.State));
				this.EntityIds = changeEntityStateBatchDirectly.EntityIds;
				break;
			}
			case EChangeEntityState.Loop:
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.FZX, "不支持的切换实体状态", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(true, false, true);
				return;
			}
			if (num == null)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			this.StateId = num.Value;
			base.CreateWaitEntityTask(this.EntityIds);
		}

		// Token: 0x06044036 RID: 278582 RVA: 0x010B59D0 File Offset: 0x010B3BD0
		protected override void ExecuteWhenEntitiesReady()
		{
			foreach (int pbDataId in this.EntityIds)
			{
				LevelGeneralCommons.PrechangeStateTag(pbDataId, this.StateId, "ShowInRefSequence");
			}
			base.FinishExecute(true, false, true);
		}

		// Token: 0x06044037 RID: 278583 RVA: 0x010B5A34 File Offset: 0x010B3C34
		protected override void OnReset()
		{
			this.Config = null;
			this.StateId = 0;
			this.EntityIds = null;
		}

		// Token: 0x040238B6 RID: 145590
		private ChangeEntityState Config;

		// Token: 0x040238B7 RID: 145591
		private int StateId;

		// Token: 0x040238B8 RID: 145592
		private List<int> EntityIds;
	}
}
