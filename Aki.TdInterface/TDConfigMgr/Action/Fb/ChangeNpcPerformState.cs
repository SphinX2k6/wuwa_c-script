using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200266E RID: 9838
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeNpcPerformState : ActionParams
	{
		// Token: 0x0600DC83 RID: 56451 RVA: 0x0020CDC2 File Offset: 0x0020AFC2
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

		// Token: 0x17004169 RID: 16745
		// (get) Token: 0x0600DC84 RID: 56452 RVA: 0x0020CDE1 File Offset: 0x0020AFE1
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x1700416A RID: 16746
		// (get) Token: 0x0600DC85 RID: 56453 RVA: 0x0020CDEE File Offset: 0x0020AFEE
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x04007A96 RID: 31382
		private IChangeNpcPerformState Instance;
	}
}
