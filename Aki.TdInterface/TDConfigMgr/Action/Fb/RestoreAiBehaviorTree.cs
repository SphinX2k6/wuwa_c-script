using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D73 RID: 11635
	public class RestoreAiBehaviorTree : ActionParams
	{
		// Token: 0x0600FDDB RID: 64987 RVA: 0x0024A5A5 File Offset: 0x002487A5
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

		// Token: 0x17004FA3 RID: 20387
		// (get) Token: 0x0600FDDC RID: 64988 RVA: 0x0024A5C4 File Offset: 0x002487C4
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x04008A9F RID: 35487
		private IRestoreAiBehaviorTree Instance;
	}
}
