using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C75 RID: 23669
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelEventChangeEntityState : LevelEventBase
	{
		// Token: 0x0603A186 RID: 237958 RVA: 0x0105F125 File Offset: 0x0105D325
		public LevelEventChangeEntityState(int id) : base(id)
		{
		}

		// Token: 0x0603A187 RID: 237959 RVA: 0x0105F130 File Offset: 0x0105D330
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

		// Token: 0x0603A188 RID: 237960 RVA: 0x0105F26C File Offset: 0x0105D46C
		protected override void ExecuteWhenEntitiesReady()
		{
			foreach (int pbDataId in this.EntityIds)
			{
				LevelGeneralCommons.PrechangeStateTag(pbDataId, this.StateId, "ShowInRefSequence");
			}
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A189 RID: 237961 RVA: 0x0105F2D0 File Offset: 0x0105D4D0
		protected override void OnReset()
		{
			this.Config = null;
			this.StateId = 0;
			this.EntityIds = null;
		}

		// Token: 0x0401EB58 RID: 125784
		private ChangeEntityState Config;

		// Token: 0x0401EB59 RID: 125785
		private int StateId;

		// Token: 0x0401EB5A RID: 125786
		private List<int> EntityIds;
	}
}
