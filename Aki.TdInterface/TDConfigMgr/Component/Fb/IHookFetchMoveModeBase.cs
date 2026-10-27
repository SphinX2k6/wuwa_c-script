using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B21 RID: 2849
	public class IHookFetchMoveModeBase
	{
		// Token: 0x060041CC RID: 16844 RVA: 0x000A8C8E File Offset: 0x000A6E8E
		[NullableContext(1)]
		public static IHookFetchMoveModeBase Create(IHookFetchMoveModeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookFetchMoveModeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x060041CD RID: 16845 RVA: 0x000A8CAD File Offset: 0x000A6EAD
		public virtual EHookFetchMoveMode Type
		{
			get
			{
				return (EHookFetchMoveMode)this.Instance.Type;
			}
		}

		// Token: 0x0400251A RID: 9498
		private IHookFetchMoveModeBase Instance;
	}
}
