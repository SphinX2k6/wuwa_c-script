using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B1A RID: 2842
	public class IHookLockScreenDetectTypeFullScreen : IHookLockScreenDetectTypeBase
	{
		// Token: 0x0600419A RID: 16794 RVA: 0x000A850E File Offset: 0x000A670E
		[NullableContext(1)]
		public static IHookLockScreenDetectTypeFullScreen Create(IHookLockScreenDetectTypeFullScreen? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookLockScreenDetectTypeFullScreen
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x0600419B RID: 16795 RVA: 0x000A852D File Offset: 0x000A672D
		public override EHookLockScreenDetectType Type
		{
			get
			{
				return (EHookLockScreenDetectType)this.Instance.Type;
			}
		}

		// Token: 0x040024F9 RID: 9465
		private IHookLockScreenDetectTypeFullScreen Instance;
	}
}
