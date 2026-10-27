using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A7C RID: 2684
	public class IInteractEntityPartBindBase
	{
		// Token: 0x06003DC8 RID: 15816 RVA: 0x0009E5CE File Offset: 0x0009C7CE
		[NullableContext(1)]
		public static IInteractEntityPartBindBase Create(IInteractEntityPartBindBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractEntityPartBindBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06003DC9 RID: 15817 RVA: 0x0009E5ED File Offset: 0x0009C7ED
		public virtual EInteractEntityPartBindType Type
		{
			get
			{
				return (EInteractEntityPartBindType)this.Instance.Type;
			}
		}

		// Token: 0x04002265 RID: 8805
		private IInteractEntityPartBindBase Instance;
	}
}
