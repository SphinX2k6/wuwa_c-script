using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A0E RID: 10766
	public class IPlayGuestCartethyia : IPlayGuestUiAnimationType
	{
		// Token: 0x0600ED71 RID: 60785 RVA: 0x00229DAE File Offset: 0x00227FAE
		[NullableContext(1)]
		public static IPlayGuestCartethyia Create(IPlayGuestCartethyia? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayGuestCartethyia
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B17 RID: 19223
		// (get) Token: 0x0600ED72 RID: 60786 RVA: 0x00229DCD File Offset: 0x00227FCD
		public override EGuestUiAnimationType Type
		{
			get
			{
				return (EGuestUiAnimationType)this.Instance.Type;
			}
		}

		// Token: 0x040082B2 RID: 33458
		private IPlayGuestCartethyia Instance;
	}
}
