using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A7E RID: 2686
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractEntityPartModelOptionPoint
	{
		// Token: 0x06003DCF RID: 15823 RVA: 0x0009E643 File Offset: 0x0009C843
		public static IInteractEntityPartModelOptionPoint Create(IInteractEntityPartModelOptionPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractEntityPartModelOptionPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06003DD0 RID: 15824 RVA: 0x0009E662 File Offset: 0x0009C862
		public virtual string UiStyle
		{
			get
			{
				return this.Instance.UiStyle;
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06003DD1 RID: 15825 RVA: 0x0009E66F File Offset: 0x0009C86F
		public virtual string BindName
		{
			get
			{
				return this.Instance.BindName;
			}
		}

		// Token: 0x04002267 RID: 8807
		private IInteractEntityPartModelOptionPoint Instance;
	}
}
