using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AEC RID: 10988
	public class IBlendAnimTypeBase
	{
		// Token: 0x0600F0CB RID: 61643 RVA: 0x0022F2D6 File Offset: 0x0022D4D6
		[NullableContext(1)]
		public static IBlendAnimTypeBase Create(IBlendAnimTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBlendAnimTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CB5 RID: 19637
		// (get) Token: 0x0600F0CC RID: 61644 RVA: 0x0022F2F5 File Offset: 0x0022D4F5
		public virtual EBlendAnimType Type
		{
			get
			{
				return (EBlendAnimType)this.Instance.Type;
			}
		}

		// Token: 0x04008478 RID: 33912
		private IBlendAnimTypeBase Instance;
	}
}
