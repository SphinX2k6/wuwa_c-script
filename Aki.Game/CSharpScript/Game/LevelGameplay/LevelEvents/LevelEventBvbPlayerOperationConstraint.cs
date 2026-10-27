using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.Guide;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006AF8 RID: 27384
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventBvbPlayerOperationConstraint : LevelEventBase, IPhantomArenaGuideFunc
	{
		// Token: 0x06044018 RID: 278552 RVA: 0x010B1F68 File Offset: 0x010B0168
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

		// Token: 0x06044019 RID: 278553 RVA: 0x010B1FB5 File Offset: 0x010B01B5
		public void FinishCurrentGuide()
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0604401A RID: 278554 RVA: 0x010B1FC0 File Offset: 0x010B01C0
		public void ExitCurrentGuide()
		{
			base.FinishExecute(false, false, true);
		}

		// Token: 0x0604401B RID: 278555 RVA: 0x010B1FCB File Offset: 0x010B01CB
		public LevelEventBvbPlayerOperationConstraint(int id) : base(id)
		{
		}

		// Token: 0x040238A4 RID: 145572
		private Action FinishCurrentGuide1;

		// Token: 0x040238A5 RID: 145573
		private Action ExitCurrentGuide1;
	}
}
