using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B58 RID: 2904
	public class IInitStateBarrierLock : IInitState
	{
		// Token: 0x0600425A RID: 16986 RVA: 0x000A8ADE File Offset: 0x000A6CDE
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

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x0600425B RID: 16987 RVA: 0x000A8AFD File Offset: 0x000A6CFD
		public override EInitStateType Type
		{
			get
			{
				return (EInitStateType)this.Instance.Type;
			}
		}

		// Token: 0x040024C3 RID: 9411
		private IInitStateBarrierLock Instance;
	}
}
