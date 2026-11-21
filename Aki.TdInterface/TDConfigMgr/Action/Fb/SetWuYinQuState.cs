using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002933 RID: 10547
	public class SetWuYinQuState : ActionParams
	{
		// Token: 0x0600EA6D RID: 60013 RVA: 0x00229756 File Offset: 0x00227956
		public static SetWuYinQuState Create(ISetWuYinQuState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetWuYinQuState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044B5 RID: 17589
		// (get) Token: 0x0600EA6E RID: 60014 RVA: 0x00229775 File Offset: 0x00227975
		public virtual string WuYinQuName
		{
			get
			{
				return this.Instance.WuYinQuName;
			}
		}

		// Token: 0x170044B6 RID: 17590
		// (get) Token: 0x0600EA6F RID: 60015 RVA: 0x00229782 File Offset: 0x00227982
		public virtual EWuYinQuState State
		{
			get
			{
				return (EWuYinQuState)this.Instance.State;
			}
		}

		// Token: 0x04008135 RID: 33077
		private ISetWuYinQuState Instance;
	}
}
