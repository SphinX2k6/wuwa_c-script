using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028FD RID: 10493
	public class DestroyQuestItem : ActionParams
	{
		// Token: 0x0600E975 RID: 59765 RVA: 0x002279EE File Offset: 0x00225BEE
		public static DestroyQuestItem Create(IDestroyQuestItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyQuestItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004429 RID: 17449
		// (get) Token: 0x0600E976 RID: 59766 RVA: 0x00227A0D File Offset: 0x00225C0D
		public virtual int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x1700442A RID: 17450
		// (get) Token: 0x0600E977 RID: 59767 RVA: 0x00227A1A File Offset: 0x00225C1A
		public virtual int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x1700442B RID: 17451
		// (get) Token: 0x0600E978 RID: 59768 RVA: 0x00227A27 File Offset: 0x00225C27
		public virtual bool IsAll
		{
			get
			{
				return this.Instance.IsAll;
			}
		}

		// Token: 0x040080AD RID: 32941
		private IDestroyQuestItem Instance;
	}
}
