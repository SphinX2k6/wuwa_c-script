using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200292D RID: 10541
	public class ChangeNpcPerformState : ActionParams
	{
		// Token: 0x0600EA4F RID: 59983 RVA: 0x002294D2 File Offset: 0x002276D2
		public static ChangeNpcPerformState Create(IChangeNpcPerformState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeNpcPerformState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044A3 RID: 17571
		// (get) Token: 0x0600EA50 RID: 59984 RVA: 0x002294F1 File Offset: 0x002276F1
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170044A4 RID: 17572
		// (get) Token: 0x0600EA51 RID: 59985 RVA: 0x002294FE File Offset: 0x002276FE
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x0400812D RID: 33069
		private IChangeNpcPerformState Instance;
	}
}
