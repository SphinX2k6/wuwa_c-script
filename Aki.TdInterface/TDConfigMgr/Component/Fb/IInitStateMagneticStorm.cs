using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A8C RID: 2700
	public class IInitStateMagneticStorm : IInitState
	{
		// Token: 0x06003E2B RID: 15915 RVA: 0x0009F4BE File Offset: 0x0009D6BE
		[NullableContext(1)]
		public static IInitStateMagneticStorm Create(IInitStateMagneticStorm? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateMagneticStorm
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06003E2C RID: 15916 RVA: 0x0009F4DD File Offset: 0x0009D6DD
		public override EInitStateType Type
		{
			get
			{
				return (EInitStateType)this.Instance.Type;
			}
		}

		// Token: 0x040022A5 RID: 8869
		private IInitStateMagneticStorm Instance;
	}
}
