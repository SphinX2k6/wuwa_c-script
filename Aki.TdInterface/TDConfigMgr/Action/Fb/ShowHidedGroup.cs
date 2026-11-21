using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A6A RID: 10858
	public class ShowHidedGroup : ActionParams
	{
		// Token: 0x0600EFB9 RID: 61369 RVA: 0x002324DE File Offset: 0x002306DE
		public static ShowHidedGroup Create(IShowHidedGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowHidedGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004793 RID: 18323
		// (get) Token: 0x0600EFBA RID: 61370 RVA: 0x002324FD File Offset: 0x002306FD
		public virtual string GroupKey
		{
			get
			{
				return this.Instance.GroupKey;
			}
		}

		// Token: 0x17004794 RID: 18324
		// (get) Token: 0x0600EFBB RID: 61371 RVA: 0x0023250A File Offset: 0x0023070A
		public virtual bool DelayShow
		{
			get
			{
				return this.Instance.DelayShow;
			}
		}

		// Token: 0x040083D2 RID: 33746
		private IShowHidedGroup Instance;
	}
}
