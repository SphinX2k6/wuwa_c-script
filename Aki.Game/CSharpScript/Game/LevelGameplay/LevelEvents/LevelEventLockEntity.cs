using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Common.Component;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CB5 RID: 23733
	public class LevelEventLockEntity : LevelEventBase
	{
		// Token: 0x0603A2A7 RID: 238247 RVA: 0x010681E7 File Offset: 0x010663E7
		public LevelEventLockEntity(int id) : base(id)
		{
		}

		// Token: 0x0603A2A8 RID: 238248 RVA: 0x010681F0 File Offset: 0x010663F0
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (context.Type.GetValueOrDefault() != EGeneralContextType.Entity || !(context as EntityContext).ClientExecuteActions)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			this.Config = (inParams as LockEntity);
			base.CreateWaitEntityTask(this.Config.EntityIds);
		}

		// Token: 0x0603A2A9 RID: 238249 RVA: 0x01068240 File Offset: 0x01066440
		protected override void ExecuteWhenEntitiesReady()
		{
			foreach (int pbDataId in this.Config.EntityIds)
			{
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
				if (entityByPbDataId != null && entityByPbDataId.IsInit)
				{
					LevelTagComponent component = entityByPbDataId.Entity.GetComponent<LevelTagComponent>();
					if (component != null)
					{
						component.AddServerTagByIdLocal(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.锁定"], "LevelEventLockEntity");
					}
				}
			}
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A2AA RID: 238250 RVA: 0x010682E4 File Offset: 0x010664E4
		protected override void OnReset()
		{
			this.Config = null;
		}

		// Token: 0x0401EBB5 RID: 125877
		[Nullable(2)]
		private LockEntity Config;
	}
}
