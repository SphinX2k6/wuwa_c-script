using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A8D RID: 2701
	public class IInitStateWuYinQu : IInitState
	{
		// Token: 0x06003E2E RID: 15918 RVA: 0x0009F4F2 File Offset: 0x0009D6F2
		[NullableContext(1)]
		public static IInitStateWuYinQu Create(IInitStateWuYinQu? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateWuYinQu
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06003E2F RID: 15919 RVA: 0x0009F511 File Offset: 0x0009D711
		public override EInitStateType Type
		{
			get
			{
				return (EInitStateType)this.Instance.Type;
			}
		}

		// Token: 0x040022A6 RID: 8870
		private IInitStateWuYinQu Instance;
	}
}
