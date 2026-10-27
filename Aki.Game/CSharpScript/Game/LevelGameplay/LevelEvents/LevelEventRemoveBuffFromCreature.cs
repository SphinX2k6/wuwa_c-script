using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B5F RID: 27487
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventRemoveBuffFromCreature : LevelEventBase
	{
		// Token: 0x060441E9 RID: 279017 RVA: 0x010C49A3 File Offset: 0x010C2BA3
		public LevelEventRemoveBuffFromCreature(int id) : base(id)
		{
		}

		// Token: 0x060441EA RID: 279018 RVA: 0x010C49AC File Offset: 0x010C2BAC
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

		// Token: 0x060441EB RID: 279019 RVA: 0x010C4A94 File Offset: 0x010C2C94
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

		// Token: 0x060441EC RID: 279020 RVA: 0x010C4B88 File Offset: 0x010C2D88
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

		// Token: 0x0402393D RID: 145725
		[Nullable(2)]
		private RemoveBuffFromEntity EventParam;

		// Token: 0x0402393E RID: 145726
		[Nullable(2)]
		private List<int> EntityIds;
	}
}
