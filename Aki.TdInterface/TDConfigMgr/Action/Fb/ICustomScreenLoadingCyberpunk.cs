using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200269F RID: 9887
	public class ICustomScreenLoadingCyberpunk : ICustomScreenLoadingTypeBase
	{
		// Token: 0x0600DD45 RID: 56645 RVA: 0x0020E030 File Offset: 0x0020C230
		[NullableContext(1)]
		public static ICustomScreenLoadingCyberpunk Create(ICustomScreenLoadingCyberpunk? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenLoadingCyberpunk
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041C9 RID: 16841
		// (get) Token: 0x0600DD46 RID: 56646 RVA: 0x0020E04F File Offset: 0x0020C24F
		public override ECustomScreenLoading Type
		{
			get
			{
				return (ECustomScreenLoading)this.Instance.Type;
			}
		}

		// Token: 0x04007AE3 RID: 31459
		private ICustomScreenLoadingCyberpunk Instance;
	}
}
