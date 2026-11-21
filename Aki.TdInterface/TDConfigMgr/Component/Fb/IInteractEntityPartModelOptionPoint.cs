using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B48 RID: 2888
	public class IInteractEntityPartModelOptionPoint
	{
		// Token: 0x060041F8 RID: 16888 RVA: 0x000A7BFB File Offset: 0x000A5DFB
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

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x060041F9 RID: 16889 RVA: 0x000A7C1A File Offset: 0x000A5E1A
		public virtual string UiStyle
		{
			get
			{
				return this.Instance.UiStyle;
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x060041FA RID: 16890 RVA: 0x000A7C27 File Offset: 0x000A5E27
		public virtual string BindName
		{
			get
			{
				return this.Instance.BindName;
			}
		}

		// Token: 0x04002483 RID: 9347
		private IInteractEntityPartModelOptionPoint Instance;
	}
}
