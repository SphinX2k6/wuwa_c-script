using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006101 RID: 24833
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelFlowChangeEntityState : LevelFlowActionBase
	{
		// Token: 0x0603B881 RID: 243841 RVA: 0x010E0F87 File Offset: 0x010DF187
		[NullableContext(1)]
		public LevelFlowChangeEntityState Init(ChangeEntityState param)
		{
			this.Params = param;
			return this;
		}

		// Token: 0x0603B882 RID: 243842 RVA: 0x010E0F94 File Offset: 0x010DF194
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

		// Token: 0x0603B883 RID: 243843 RVA: 0x010E10AC File Offset: 0x010DF2AC
		protected override void ExecuteWhenEntitiesReady()
		{
			foreach (int pbDataId in this.EntityIds)
			{
				LevelGeneralCommons.PrechangeStateTag(pbDataId, this.StateId, "ShowInRefSequence");
			}
			base.FinishExecute(true);
		}

		// Token: 0x0401F662 RID: 128610
		private ChangeEntityState Params;

		// Token: 0x0401F663 RID: 128611
		private int StateId;

		// Token: 0x0401F664 RID: 128612
		private List<int> EntityIds;
	}
}
