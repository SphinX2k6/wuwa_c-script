using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x020052A5 RID: 21157
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class PhantomArenaBattleGuideDataBase<[Nullable(0)] T> : IPhantomArenaTabViewModelBase where T : IBvbPlayerOperationType
	{
		// Token: 0x170082E6 RID: 33510
		// (get) Token: 0x0603624B RID: 221771 RVA: 0x00CCF759 File Offset: 0x00CCD959
		// (set) Token: 0x0603624C RID: 221772 RVA: 0x00CCF761 File Offset: 0x00CCD961
		public string Tips { get; set; }

		// Token: 0x170082E7 RID: 33511
		// (get) Token: 0x0603624D RID: 221773 RVA: 0x00CCF76A File Offset: 0x00CCD96A
		// (set) Token: 0x0603624E RID: 221774 RVA: 0x00CCF772 File Offset: 0x00CCD972
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x0603624F RID: 221775 RVA: 0x00CCF77B File Offset: 0x00CCD97B
		public PhantomArenaBattleGuideDataBase(EBvbPlayerOperationType type, BvbPlayerOperationConstraint param)
		{
			this.Type = type;
			this.Param = param;
			this.Tips = this.Param.TidPromptTxt;
			this.Data = (T)((object)this.Param.EnableOperation);
		}

		// Token: 0x06036250 RID: 221776
		public abstract bool CheckCanExecute(params object[] params_);

		// Token: 0x06036251 RID: 221777 RVA: 0x00CCF7B8 File Offset: 0x00CCD9B8
		public virtual void CacheGuideData(params object[] params_)
		{
		}

		// Token: 0x06036252 RID: 221778 RVA: 0x00CCF7BA File Offset: 0x00CCD9BA
		public virtual bool CheckCanFinishGuide(params object[] params_)
		{
			return true;
		}

		// Token: 0x0401CA69 RID: 117353
		protected T Data;

		// Token: 0x0401CA6C RID: 117356
		protected BvbPlayerOperationConstraint Param;
	}
}
