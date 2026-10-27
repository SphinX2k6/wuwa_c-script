using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024EC RID: 9452
	public class IBehaviorTreeFragmentContext : IVarContext
	{
		// Token: 0x0600D300 RID: 54016 RVA: 0x001F4B41 File Offset: 0x001F2D41
		[NullableContext(1)]
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

		// Token: 0x17003AEA RID: 15082
		// (get) Token: 0x0600D301 RID: 54017 RVA: 0x001F4B60 File Offset: 0x001F2D60
		public override EVarContext Type
		{
			get
			{
				return (EVarContext)this.Instance.Type;
			}
		}

		// Token: 0x17003AEB RID: 15083
		// (get) Token: 0x0600D302 RID: 54018 RVA: 0x001F4B6D File Offset: 0x001F2D6D
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040073B6 RID: 29622
		private IBehaviorTreeFragmentContext Instance;
	}
}
