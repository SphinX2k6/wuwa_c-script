using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C76 RID: 23670
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventChangeNpcPerformState : LevelEventBase
	{
		// Token: 0x0603A18A RID: 237962 RVA: 0x0105F2E7 File Offset: 0x0105D4E7
		public LevelEventChangeNpcPerformState(int id) : base(id)
		{
		}

		// Token: 0x0603A18B RID: 237963 RVA: 0x0105F2FC File Offset: 0x0105D4FC
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ChangeNpcPerformState changeNpcPerformState = inParams as ChangeNpcPerformState;
			if (changeNpcPerformState == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YSQ, "执行行为LevelEventChangeNpcPerformState失败，参数错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.State = changeNpcPerformState.State;
			this.EntityId = changeNpcPerformState.EntityId;
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(changeNpcPerformState.EntityId);
			bool flag;
			if (entityByPbDataId == null)
			{
				flag = false;
			}
			else
			{
				WorldEntity entity = entityByPbDataId.Entity;
				flag = ((entity != null) ? new bool?(entity.IsInit) : null).GetValueOrDefault();
			}
			if (flag)
			{
				this.ExecuteWhenEntitiesReady();
				return;
			}
			base.CreateWaitEntityTask(changeNpcPerformState.EntityId);
		}

		// Token: 0x0603A18C RID: 237964 RVA: 0x0105F39C File Offset: 0x0105D59C
		protected override void ExecuteWhenEntitiesReady()
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.EntityId);
			bool flag;
			if (entityByPbDataId == null)
			{
				flag = true;
			}
			else
			{
				WorldEntity entity = entityByPbDataId.Entity;
				flag = !((entity != null) ? new bool?(entity.IsInit) : null).GetValueOrDefault();
			}
			if (flag)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YSQ, "执行行为LevelEventChangeNpcPerformState失败，实体没有Activate", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			entityByPbDataId.Entity.GetComponent<CommonNpcPerformComponent>().PerformGroupController.SwitchPerformState(this.State);
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A18D RID: 237965 RVA: 0x0105F42D File Offset: 0x0105D62D
		protected override void OnReset()
		{
			this.State = "";
			this.EntityId = 0;
		}

		// Token: 0x0401EB5B RID: 125787
		private string State = "";

		// Token: 0x0401EB5C RID: 125788
		private int EntityId;
	}
}
