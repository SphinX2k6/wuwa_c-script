using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CD7 RID: 23767
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventRemoveBuffFromCreature : LevelEventBase
	{
		// Token: 0x0603A33B RID: 238395 RVA: 0x0106E573 File Offset: 0x0106C773
		public LevelEventRemoveBuffFromCreature(int id) : base(id)
		{
		}

		// Token: 0x0603A33C RID: 238396 RVA: 0x0106E57C File Offset: 0x0106C77C
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			RemoveBuffFromEntity removeBuffFromEntity = inParams as RemoveBuffFromEntity;
			if (removeBuffFromEntity == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.ZS, "参数类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false, false, true);
				return;
			}
			this.EventParam = removeBuffFromEntity;
			this.EntityIds = new List<int>();
			if (removeBuffFromEntity.EntityId != null)
			{
				this.EntityIds.Add(removeBuffFromEntity.EntityId.Value);
			}
			List<int> entityIds = removeBuffFromEntity.EntityIds;
			if (entityIds != null && entityIds.Count > 0)
			{
				foreach (int item in removeBuffFromEntity.EntityIds)
				{
					this.EntityIds.Add(item);
				}
			}
			base.CreateWaitEntityTask(this.EntityIds);
		}

		// Token: 0x0603A33D RID: 238397 RVA: 0x0106E664 File Offset: 0x0106C864
		protected override void ExecuteWhenEntitiesReady()
		{
			foreach (int pbDataId in this.EntityIds)
			{
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
				if (entityByPbDataId != null && entityByPbDataId.IsInit)
				{
					CharacterBuffComponent component = entityByPbDataId.Entity.GetComponent<CharacterBuffComponent>();
					foreach (long buffId in this.EventParam.BuffIds)
					{
						component.RemoveBuff(buffId, -1, "LevelEventRemoveBuffFromCreature", null, null, null);
					}
				}
			}
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A33E RID: 238398 RVA: 0x0106E758 File Offset: 0x0106C958
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			RemoveBuffFromEntity removeBuffFromEntity = inParams as RemoveBuffFromEntity;
			if (removeBuffFromEntity == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.ZS;
				string message = "执行行为时:参数类型错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EventType", this.Type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.FinishExecute(false, false, true);
				return;
			}
			this.EventParam = removeBuffFromEntity;
			this.EntityIds = new List<int>();
			if (removeBuffFromEntity.EntityId != null)
			{
				this.EntityIds.Add(removeBuffFromEntity.EntityId.Value);
			}
			List<int> entityIds = removeBuffFromEntity.EntityIds;
			if (entityIds != null && entityIds.Count > 0)
			{
				foreach (int item in removeBuffFromEntity.EntityIds)
				{
					this.EntityIds.Add(item);
				}
			}
			this.ExecuteWhenEntitiesReady();
		}

		// Token: 0x0401EBDF RID: 125919
		[Nullable(2)]
		private RemoveBuffFromEntity EventParam;

		// Token: 0x0401EBE0 RID: 125920
		[Nullable(2)]
		private List<int> EntityIds;
	}
}
