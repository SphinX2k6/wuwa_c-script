using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002791 RID: 10129
	public class IBehaviorTreeFragmentContext : IVarContext
	{
		// Token: 0x0600E056 RID: 57430 RVA: 0x002103D9 File Offset: 0x0020E5D9
		public static IBehaviorTreeFragmentContext Create(IBehaviorTreeFragmentContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBehaviorTreeFragmentContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DE2 RID: 15842
		// (get) Token: 0x0600E057 RID: 57431 RVA: 0x002103F8 File Offset: 0x0020E5F8
		public override EVarContext Type
		{
			get
			{
				return (EVarContext)this.Instance.Type;
			}
		}

		// Token: 0x17003DE3 RID: 15843
		// (get) Token: 0x0600E058 RID: 57432 RVA: 0x00210405 File Offset: 0x0020E605
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04007A03 RID: 31235
		private IBehaviorTreeFragmentContext Instance;
	}
}
