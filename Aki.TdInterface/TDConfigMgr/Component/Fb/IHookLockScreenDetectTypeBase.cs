using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B18 RID: 2840
	public class IHookLockScreenDetectTypeBase
	{
		// Token: 0x06004194 RID: 16788 RVA: 0x000A84A6 File Offset: 0x000A66A6
		[NullableContext(1)]
		public static IHookLockScreenDetectTypeBase Create(IHookLockScreenDetectTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookLockScreenDetectTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x06004195 RID: 16789 RVA: 0x000A84C5 File Offset: 0x000A66C5
		public virtual EHookLockScreenDetectType Type
		{
			get
			{
				return (EHookLockScreenDetectType)this.Instance.Type;
			}
		}

		// Token: 0x040024F7 RID: 9463
		private IHookLockScreenDetectTypeBase Instance;
	}
}
