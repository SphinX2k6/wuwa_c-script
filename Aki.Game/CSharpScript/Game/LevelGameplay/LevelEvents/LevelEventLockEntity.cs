using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Common.Component;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B3D RID: 27453
	public class LevelEventLockEntity : LevelEventBase
	{
		// Token: 0x06044155 RID: 278869 RVA: 0x010BE76B File Offset: 0x010BC96B
		public LevelEventLockEntity(int id) : base(id)
		{
		}

		// Token: 0x06044156 RID: 278870 RVA: 0x010BE774 File Offset: 0x010BC974
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

		// Token: 0x06044157 RID: 278871 RVA: 0x010BE7C4 File Offset: 0x010BC9C4
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

		// Token: 0x06044158 RID: 278872 RVA: 0x010BE868 File Offset: 0x010BCA68
		protected override void OnReset()
		{
			this.Config = null;
		}

		// Token: 0x04023913 RID: 145683
		[Nullable(2)]
		private LockEntity Config;
	}
}
