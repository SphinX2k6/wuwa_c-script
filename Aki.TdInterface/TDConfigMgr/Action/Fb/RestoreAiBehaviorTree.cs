using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A7F RID: 10879
	[NullableContext(1)]
	[Nullable(0)]
	public class RestoreAiBehaviorTree : ActionParams
	{
		// Token: 0x0600EF25 RID: 61221 RVA: 0x0022C899 File Offset: 0x0022AA99
		public static RestoreAiBehaviorTree Create(IRestoreAiBehaviorTree? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RestoreAiBehaviorTree
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BE9 RID: 19433
		// (get) Token: 0x0600EF26 RID: 61222 RVA: 0x0022C8B8 File Offset: 0x0022AAB8
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x0400839B RID: 33691
		private IRestoreAiBehaviorTree Instance;
	}
}
