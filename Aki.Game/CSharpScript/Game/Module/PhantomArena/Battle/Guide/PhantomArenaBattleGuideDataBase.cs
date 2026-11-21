using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x02004275 RID: 17013
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class PhantomArenaBattleGuideDataBase<[Nullable(0)] T> : IPhantomArenaTabViewModelBase where T : IBvbPlayerOperationType
	{
		// Token: 0x170056A6 RID: 22182
		// (get) Token: 0x0602B146 RID: 176454 RVA: 0x00C1CE81 File Offset: 0x00C1B081
		// (set) Token: 0x0602B147 RID: 176455 RVA: 0x00C1CE89 File Offset: 0x00C1B089
		public string Tips { get; set; }

		// Token: 0x170056A7 RID: 22183
		// (get) Token: 0x0602B148 RID: 176456 RVA: 0x00C1CE92 File Offset: 0x00C1B092
		// (set) Token: 0x0602B149 RID: 176457 RVA: 0x00C1CE9A File Offset: 0x00C1B09A
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x0602B14A RID: 176458 RVA: 0x00C1CEA3 File Offset: 0x00C1B0A3
		public PhantomArenaBattleGuideDataBase(EBvbPlayerOperationType type, BvbPlayerOperationConstraint param)
		{
			this.Type = type;
			this.Param = param;
			this.Tips = this.Param.TidPromptTxt;
			this.Data = (T)((object)this.Param.EnableOperation);
		}

		// Token: 0x0602B14B RID: 176459
		public abstract bool CheckCanExecute(params object[] params_);

		// Token: 0x0602B14C RID: 176460 RVA: 0x00C1CEE0 File Offset: 0x00C1B0E0
		public virtual void CacheGuideData(params object[] params_)
		{
		}

		// Token: 0x0602B14D RID: 176461 RVA: 0x00C1CEE2 File Offset: 0x00C1B0E2
		public virtual bool CheckCanFinishGuide(params object[] params_)
		{
			return true;
		}

		// Token: 0x0401749E RID: 95390
		protected T Data;

		// Token: 0x040174A1 RID: 95393
		protected BvbPlayerOperationConstraint Param;
	}
}
