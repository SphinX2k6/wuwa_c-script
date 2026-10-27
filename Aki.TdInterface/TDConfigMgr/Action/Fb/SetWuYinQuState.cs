using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002674 RID: 9844
	[NullableContext(1)]
	[Nullable(0)]
	public class SetWuYinQuState : ActionParams
	{
		// Token: 0x0600DCA1 RID: 56481 RVA: 0x0020D046 File Offset: 0x0020B246
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

		// Token: 0x1700417B RID: 16763
		// (get) Token: 0x0600DCA2 RID: 56482 RVA: 0x0020D065 File Offset: 0x0020B265
		public virtual string WuYinQuName
		{
			get
			{
				return this.Instance.WuYinQuName;
			}
		}

		// Token: 0x1700417C RID: 16764
		// (get) Token: 0x0600DCA3 RID: 56483 RVA: 0x0020D072 File Offset: 0x0020B272
		public virtual EWuYinQuState State
		{
			get
			{
				return (EWuYinQuState)this.Instance.State;
			}
		}

		// Token: 0x04007A9E RID: 31390
		private ISetWuYinQuState Instance;
	}
}
