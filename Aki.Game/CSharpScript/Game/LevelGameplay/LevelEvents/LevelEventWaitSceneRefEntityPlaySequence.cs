using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006BB7 RID: 27575
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventWaitSceneRefEntityPlaySequence : LevelEventBase
	{
		// Token: 0x06044337 RID: 279351 RVA: 0x010CFCB9 File Offset: 0x010CDEB9
		public LevelEventWaitSceneRefEntityPlaySequence(int id) : base(id)
		{
		}

		// Token: 0x06044338 RID: 279352 RVA: 0x010CFCD0 File Offset: 0x010CDED0
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			WaitUntilLevelSequenceReachMark waitUntilLevelSequenceReachMark = inParams as WaitUntilLevelSequenceReachMark;
			if (waitUntilLevelSequenceReachMark == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YSQ, "执行行为LevelEventWaitSceneRefEntityPlaySequence失败，参数错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.PbDataId = waitUntilLevelSequenceReachMark.EntityId;
			this.Mark = waitUntilLevelSequenceReachMark.Mark;
			this.EntityReady = false;
			base.CreateWaitEntityTask(waitUntilLevelSequenceReachMark.EntityId);
			if (this.CheckEntityPlaySequenceFinished(waitUntilLevelSequenceReachMark.EntityId, waitUntilLevelSequenceReachMark.Mark))
			{
				base.FinishExecute(true, false, true);
			}
		}

		// Token: 0x06044339 RID: 279353 RVA: 0x010CFD4C File Offset: 0x010CDF4C
		protected override void ExecuteWhenEntitiesReady()
		{
			this.EntityReady = true;
		}

		// Token: 0x0604433A RID: 279354 RVA: 0x010CFD55 File Offset: 0x010CDF55
		protected override void OnTick(float deltaTime)
		{
			if (this.CheckEntityPlaySequenceFinished(this.PbDataId, this.Mark))
			{
				base.FinishExecute(true, false, true);
			}
		}

		// Token: 0x0604433B RID: 279355 RVA: 0x010CFD74 File Offset: 0x010CDF74
		private bool CheckEntityPlaySequenceFinished(int pbDataId, string mark)
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
			bool flag;
			if (entityByPbDataId == null)
			{
				flag = true;
			}
			else
			{
				WorldEntity entity = entityByPbDataId.Entity;
				flag = !((entity != null) ? new bool?(entity.Valid) : null).GetValueOrDefault();
			}
			if (flag || !this.EntityReady)
			{
				return true;
			}
			SceneItemReferenceComponent component = entityByPbDataId.Entity.GetComponent<SceneItemReferenceComponent>();
			if (component == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.GeneralLogicTree;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "LevelEventWaitSceneRefEntityPlaySequence:找不到实体身上的SceneItemReferenceComponent组件";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pbDataId", pbDataId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return true;
			}
			return component.IsPlayToMarkFinished(mark);
		}

		// Token: 0x0402397F RID: 145791
		private int PbDataId;

		// Token: 0x04023980 RID: 145792
		private string Mark = "";

		// Token: 0x04023981 RID: 145793
		private bool EntityReady;
	}
}
