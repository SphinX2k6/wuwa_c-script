using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D30 RID: 23856
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventWaitSceneRefEntityPlaySequence : LevelEventBase
	{
		// Token: 0x0603A48F RID: 238735 RVA: 0x01079C0D File Offset: 0x01077E0D
		public LevelEventWaitSceneRefEntityPlaySequence(int id) : base(id)
		{
		}

		// Token: 0x0603A490 RID: 238736 RVA: 0x01079C24 File Offset: 0x01077E24
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

		// Token: 0x0603A491 RID: 238737 RVA: 0x01079CA0 File Offset: 0x01077EA0
		protected override void ExecuteWhenEntitiesReady()
		{
			this.EntityReady = true;
		}

		// Token: 0x0603A492 RID: 238738 RVA: 0x01079CA9 File Offset: 0x01077EA9
		protected override void OnTick(float deltaTime)
		{
			if (this.CheckEntityPlaySequenceFinished(this.PbDataId, this.Mark))
			{
				base.FinishExecute(true, false, true);
			}
		}

		// Token: 0x0603A493 RID: 238739 RVA: 0x01079CC8 File Offset: 0x01077EC8
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

		// Token: 0x0401EC21 RID: 125985
		private int PbDataId;

		// Token: 0x0401EC22 RID: 125986
		private string Mark = "";

		// Token: 0x0401EC23 RID: 125987
		private bool EntityReady;
	}
}
