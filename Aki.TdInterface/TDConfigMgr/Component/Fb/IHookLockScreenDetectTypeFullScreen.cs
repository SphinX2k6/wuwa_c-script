using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE8 RID: 3048
	public class IHookLockScreenDetectTypeFullScreen : IHookLockScreenDetectTypeBase
	{
		// Token: 0x060045F0 RID: 17904 RVA: 0x000B253A File Offset: 0x000B073A
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

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x060045F1 RID: 17905 RVA: 0x000B2559 File Offset: 0x000B0759
		public override EHookLockScreenDetectType Type
		{
			get
			{
				return (EHookLockScreenDetectType)this.Instance.Type;
			}
		}

		// Token: 0x0400273D RID: 10045
		private IHookLockScreenDetectTypeFullScreen Instance;
	}
}
