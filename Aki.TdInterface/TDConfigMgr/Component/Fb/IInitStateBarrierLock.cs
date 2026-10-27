using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A8E RID: 2702
	public class IInitStateBarrierLock : IInitState
	{
		// Token: 0x06003E31 RID: 15921 RVA: 0x0009F526 File Offset: 0x0009D726
		[NullableContext(1)]
		public static IInitStateBarrierLock Create(IInitStateBarrierLock? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateBarrierLock
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06003E32 RID: 15922 RVA: 0x0009F545 File Offset: 0x0009D745
		public override EInitStateType Type
		{
			get
			{
				return (EInitStateType)this.Instance.Type;
			}
		}

		// Token: 0x040022A7 RID: 8871
		private IInitStateBarrierLock Instance;
	}
}
