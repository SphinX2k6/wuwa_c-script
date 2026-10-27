using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AEA RID: 10986
	public class IBlendAnimTargetBase
	{
		// Token: 0x0600F0C5 RID: 61637 RVA: 0x0022F26E File Offset: 0x0022D46E
		[NullableContext(1)]
		public static IBlendAnimTargetBase Create(IBlendAnimTargetBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBlendAnimTargetBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CB3 RID: 19635
		// (get) Token: 0x0600F0C6 RID: 61638 RVA: 0x0022F28D File Offset: 0x0022D48D
		public virtual EBlendAnimTarget Type
		{
			get
			{
				return (EBlendAnimTarget)this.Instance.Type;
			}
		}

		// Token: 0x04008476 RID: 33910
		private IBlendAnimTargetBase Instance;
	}
}
