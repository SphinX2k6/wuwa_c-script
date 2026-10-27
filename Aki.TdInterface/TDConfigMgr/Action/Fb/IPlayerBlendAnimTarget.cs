using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AEB RID: 10987
	public class IPlayerBlendAnimTarget : IBlendAnimTargetBase
	{
		// Token: 0x0600F0C8 RID: 61640 RVA: 0x0022F2A2 File Offset: 0x0022D4A2
		[NullableContext(1)]
		public static IPlayerBlendAnimTarget Create(IPlayerBlendAnimTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerBlendAnimTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CB4 RID: 19636
		// (get) Token: 0x0600F0C9 RID: 61641 RVA: 0x0022F2C1 File Offset: 0x0022D4C1
		public override EBlendAnimTarget Type
		{
			get
			{
				return (EBlendAnimTarget)this.Instance.Type;
			}
		}

		// Token: 0x04008477 RID: 33911
		private IPlayerBlendAnimTarget Instance;
	}
}
