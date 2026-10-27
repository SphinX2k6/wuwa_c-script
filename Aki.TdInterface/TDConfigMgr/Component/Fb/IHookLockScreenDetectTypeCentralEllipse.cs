using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B19 RID: 2841
	public class IHookLockScreenDetectTypeCentralEllipse : IHookLockScreenDetectTypeBase
	{
		// Token: 0x06004197 RID: 16791 RVA: 0x000A84DA File Offset: 0x000A66DA
		[NullableContext(1)]
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

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06004198 RID: 16792 RVA: 0x000A84F9 File Offset: 0x000A66F9
		public override EHookLockScreenDetectType Type
		{
			get
			{
				return (EHookLockScreenDetectType)this.Instance.Type;
			}
		}

		// Token: 0x040024F8 RID: 9464
		private IHookLockScreenDetectTypeCentralEllipse Instance;
	}
}
