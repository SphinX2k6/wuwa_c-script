using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006AFE RID: 27390
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventChangeNpcPerformState : LevelEventBase
	{
		// Token: 0x06044038 RID: 278584 RVA: 0x010B5A4B File Offset: 0x010B3C4B
		public LevelEventChangeNpcPerformState(int id) : base(id)
		{
		}

		// Token: 0x06044039 RID: 278585 RVA: 0x010B5A60 File Offset: 0x010B3C60
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

		// Token: 0x0604403A RID: 278586 RVA: 0x010B5B00 File Offset: 0x010B3D00
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

		// Token: 0x0604403B RID: 278587 RVA: 0x010B5B91 File Offset: 0x010B3D91
		protected override void OnReset()
		{
			this.State = "";
			this.EntityId = 0;
		}

		// Token: 0x040238B9 RID: 145593
		private string State = "";

		// Token: 0x040238BA RID: 145594
		private int EntityId;
	}
}
