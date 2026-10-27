using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F80 RID: 28544
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelFlowChangeEntityState : LevelFlowActionBase
	{
		// Token: 0x060456D3 RID: 284371 RVA: 0x01137183 File Offset: 0x01135383
		[NullableContext(1)]
		public LevelFlowChangeEntityState Init(ChangeEntityState param)
		{
			this.Params = param;
			return this;
		}

		// Token: 0x060456D4 RID: 284372 RVA: 0x01137190 File Offset: 0x01135390
		protected unsafe override void OnExecute()
		{
			ChangeEntityState @params = this.Params;
			EChangeEntityState? echangeEntityState = (@params != null) ? new EChangeEntityState?(@params.Type) : null;
			if (echangeEntityState != null)
			{
				switch (echangeEntityState.GetValueOrDefault())
				{
				case EChangeEntityState.Directly:
				{
					this.StateId = GameplayTagUtils.GetTagIdByName((@params as IChangeEntityStateDirectly).State);
					int num = 1;
					List<int> list = new List<int>(num);
					CollectionsMarshal.SetCount<int>(list, num);
					Span<int> span = CollectionsMarshal.AsSpan<int>(list);
					int index = 0;
					*span[index] = @params.EntityId;
					this.EntityIds = list;
					break;
				}
				case EChangeEntityState.BatchDirectly:
				{
					this.StateId = GameplayTagUtils.GetTagIdByName((@params as IChangeEntityStateBatchDirectly).State);
					IChangeEntityStateBatchDirectly changeEntityStateBatchDirectly = @params as IChangeEntityStateBatchDirectly;
					this.EntityIds = ((changeEntityStateBatchDirectly != null) ? changeEntityStateBatchDirectly.EntityIds : null);
					break;
				}
				case EChangeEntityState.Loop:
					global::Log.Instance.Error(ELogModule.LevelFlow, ELogAuthor.BB, "不支持的切换实体状态", default(ReadOnlySpan<ValueTuple<string, object>>));
					break;
				}
			}
			if (this.EntityIds != null)
			{
				base.CreateWaitEntityTask(this.EntityIds);
				return;
			}
			base.FinishExecute(true);
		}

		// Token: 0x060456D5 RID: 284373 RVA: 0x011372A8 File Offset: 0x011354A8
		protected override void ExecuteWhenEntitiesReady()
		{
			foreach (int pbDataId in this.EntityIds)
			{
				LevelGeneralCommons.PrechangeStateTag(pbDataId, this.StateId, "ShowInRefSequence");
			}
			base.FinishExecute(true);
		}

		// Token: 0x040243AD RID: 148397
		private ChangeEntityState Params;

		// Token: 0x040243AE RID: 148398
		private int StateId;

		// Token: 0x040243AF RID: 148399
		private List<int> EntityIds;
	}
}
