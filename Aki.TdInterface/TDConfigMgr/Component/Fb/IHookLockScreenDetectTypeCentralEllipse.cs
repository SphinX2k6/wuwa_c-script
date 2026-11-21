using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE7 RID: 3047
	public class IHookLockScreenDetectTypeCentralEllipse : IHookLockScreenDetectTypeBase
	{
		// Token: 0x060045ED RID: 17901 RVA: 0x000B2506 File Offset: 0x000B0706
		public static IHookLockScreenDetectTypeCentralEllipse Create(IHookLockScreenDetectTypeCentralEllipse? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookLockScreenDetectTypeCentralEllipse
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x060045EE RID: 17902 RVA: 0x000B2525 File Offset: 0x000B0725
		public override EHookLockScreenDetectType Type
		{
			get
			{
				return (EHookLockScreenDetectType)this.Instance.Type;
			}
		}

		// Token: 0x0400273C RID: 10044
		private IHookLockScreenDetectTypeCentralEllipse Instance;
	}
}
