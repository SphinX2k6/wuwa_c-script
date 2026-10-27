using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A7D RID: 2685
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractEntityPartPrefabOptionPoint
	{
		// Token: 0x06003DCB RID: 15819 RVA: 0x0009E602 File Offset: 0x0009C802
		public static IInteractEntityPartPrefabOptionPoint Create(IInteractEntityPartPrefabOptionPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractEntityPartPrefabOptionPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06003DCC RID: 15820 RVA: 0x0009E621 File Offset: 0x0009C821
		public virtual string UiStyle
		{
			get
			{
				return this.Instance.UiStyle;
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06003DCD RID: 15821 RVA: 0x0009E62E File Offset: 0x0009C82E
		public virtual string BindName
		{
			get
			{
				return this.Instance.BindName;
			}
		}

		// Token: 0x04002266 RID: 8806
		private IInteractEntityPartPrefabOptionPoint Instance;
	}
}
