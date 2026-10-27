using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200269E RID: 9886
	public class ICustomScreenLoadingTypeBase
	{
		// Token: 0x0600DD42 RID: 56642 RVA: 0x0020DFFC File Offset: 0x0020C1FC
		[NullableContext(1)]
		public static ICustomScreenLoadingTypeBase Create(ICustomScreenLoadingTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenLoadingTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041C8 RID: 16840
		// (get) Token: 0x0600DD43 RID: 56643 RVA: 0x0020E01B File Offset: 0x0020C21B
		public virtual ECustomScreenLoading Type
		{
			get
			{
				return (ECustomScreenLoading)this.Instance.Type;
			}
		}

		// Token: 0x04007AE2 RID: 31458
		private ICustomScreenLoadingTypeBase Instance;
	}
}
