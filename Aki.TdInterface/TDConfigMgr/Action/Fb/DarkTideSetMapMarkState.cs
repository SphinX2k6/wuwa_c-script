using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A7E RID: 10878
	public class DarkTideSetMapMarkState : ActionParams
	{
		// Token: 0x0600F013 RID: 61459 RVA: 0x00232DA9 File Offset: 0x00230FA9
		public static DarkTideSetMapMarkState Create(IDarkTideSetMapMarkState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DarkTideSetMapMarkState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047C5 RID: 18373
		// (get) Token: 0x0600F014 RID: 61460 RVA: 0x00232DC8 File Offset: 0x00230FC8
		public virtual int MapMarkId
		{
			get
			{
				return this.Instance.MapMarkId;
			}
		}

		// Token: 0x170047C6 RID: 18374
		// (get) Token: 0x0600F015 RID: 61461 RVA: 0x00232DD5 File Offset: 0x00230FD5
		public virtual EDarkTideMapMarkStateType StateType
		{
			get
			{
				return (EDarkTideMapMarkStateType)this.Instance.StateType;
			}
		}

		// Token: 0x04008402 RID: 33794
		private IDarkTideSetMapMarkState Instance;
	}
}
