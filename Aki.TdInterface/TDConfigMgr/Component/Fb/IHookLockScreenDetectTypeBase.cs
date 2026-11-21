using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE6 RID: 3046
	public class IHookLockScreenDetectTypeBase
	{
		// Token: 0x060045EA RID: 17898 RVA: 0x000B24D2 File Offset: 0x000B06D2
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

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x060045EB RID: 17899 RVA: 0x000B24F1 File Offset: 0x000B06F1
		public virtual EHookLockScreenDetectType Type
		{
			get
			{
				return (EHookLockScreenDetectType)this.Instance.Type;
			}
		}

		// Token: 0x0400273B RID: 10043
		private IHookLockScreenDetectTypeBase Instance;
	}
}
