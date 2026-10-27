using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A89 RID: 2697
	public class IInitState
	{
		// Token: 0x06003E1D RID: 15901 RVA: 0x0009F286 File Offset: 0x0009D486
		[NullableContext(1)]
		public static IInitState Create(IInitState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06003E1E RID: 15902 RVA: 0x0009F2A5 File Offset: 0x0009D4A5
		public virtual EInitStateType Type
		{
			get
			{
				return (EInitStateType)this.Instance.Type;
			}
		}

		// Token: 0x0400229C RID: 8860
		private IInitState Instance;
	}
}
