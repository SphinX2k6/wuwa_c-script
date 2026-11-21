using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B46 RID: 2886
	public class IInteractEntityPartBindBase
	{
		// Token: 0x060041F1 RID: 16881 RVA: 0x000A7B86 File Offset: 0x000A5D86
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

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x060041F2 RID: 16882 RVA: 0x000A7BA5 File Offset: 0x000A5DA5
		public virtual EInteractEntityPartBindType Type
		{
			get
			{
				return (EInteractEntityPartBindType)this.Instance.Type;
			}
		}

		// Token: 0x04002481 RID: 9345
		private IInteractEntityPartBindBase Instance;
	}
}
