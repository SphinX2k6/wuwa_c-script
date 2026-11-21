using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.Guide;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C70 RID: 23664
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventBvbPlayerOperationConstraint : LevelEventBase, IPhantomArenaGuideFunc
	{
		// Token: 0x0603A16A RID: 237930 RVA: 0x0105B838 File Offset: 0x01059A38
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			BvbPlayerOperationConstraint bvbPlayerOperationConstraint = inParams as BvbPlayerOperationConstraint;
			if (bvbPlayerOperationConstraint == null)
			{
				return;
			}
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.PhantomArenaBattleView);
			if (viewByName != null)
			{
				PhantomArenaBattleProxy phantomArenaBattleProxy = viewByName.OpenParam as PhantomArenaBattleProxy;
				phantomArenaBattleProxy.GuideManager.RegisterGuideInterface(this);
				phantomArenaBattleProxy.GuideManager.RegisterBehaviorTreeGuideData(bvbPlayerOperationConstraint);
			}
		}

		// Token: 0x0603A16B RID: 237931 RVA: 0x0105B885 File Offset: 0x01059A85
		public void FinishCurrentGuide()
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A16C RID: 237932 RVA: 0x0105B890 File Offset: 0x01059A90
		public void ExitCurrentGuide()
		{
			base.FinishExecute(false, false, true);
		}

		// Token: 0x0603A16D RID: 237933 RVA: 0x0105B89B File Offset: 0x01059A9B
		public LevelEventBvbPlayerOperationConstraint(int id) : base(id)
		{
		}

		// Token: 0x0401EB46 RID: 125766
		private Action FinishCurrentGuide1;

		// Token: 0x0401EB47 RID: 125767
		private Action ExitCurrentGuide1;
	}
}
