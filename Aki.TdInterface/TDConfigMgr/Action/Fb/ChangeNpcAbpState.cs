using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D8F RID: 11663
	public class ChangeNpcAbpState : ActionParams
	{
		// Token: 0x0600FE46 RID: 65094 RVA: 0x0024AFB7 File Offset: 0x002491B7
		public static ChangeNpcAbpState Create(IChangeNpcAbpState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeNpcAbpState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FD6 RID: 20438
		// (get) Token: 0x0600FE47 RID: 65095 RVA: 0x0024AFD6 File Offset: 0x002491D6
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004FD7 RID: 20439
		// (get) Token: 0x0600FE48 RID: 65096 RVA: 0x0024AFE3 File Offset: 0x002491E3
		public virtual string AbpState
		{
			get
			{
				return this.Instance.AbpState;
			}
		}

		// Token: 0x04008ACB RID: 35531
		private IChangeNpcAbpState Instance;
	}
}
