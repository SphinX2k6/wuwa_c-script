using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A7A RID: 2682
	public class IInteractStyleBase
	{
		// Token: 0x06003DBE RID: 15806 RVA: 0x0009E4E2 File Offset: 0x0009C6E2
		[NullableContext(1)]
		public static IInteractStyleBase Create(IInteractStyleBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractStyleBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06003DBF RID: 15807 RVA: 0x0009E501 File Offset: 0x0009C701
		public virtual EInteractStyleType Type
		{
			get
			{
				return (EInteractStyleType)this.Instance.Type;
			}
		}

		// Token: 0x04002261 RID: 8801
		private IInteractStyleBase Instance;
	}
}
