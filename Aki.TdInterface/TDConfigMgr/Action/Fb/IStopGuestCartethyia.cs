using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A11 RID: 10769
	public class IStopGuestCartethyia : IStopGuestUiAnimationType
	{
		// Token: 0x0600ED7B RID: 60795 RVA: 0x00229E7E File Offset: 0x0022807E
		[NullableContext(1)]
		public static IStopGuestCartethyia Create(IStopGuestCartethyia? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopGuestCartethyia
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B1B RID: 19227
		// (get) Token: 0x0600ED7C RID: 60796 RVA: 0x00229E9D File Offset: 0x0022809D
		public override EGuestUiAnimationType Type
		{
			get
			{
				return (EGuestUiAnimationType)this.Instance.Type;
			}
		}

		// Token: 0x040082B7 RID: 33463
		private IStopGuestCartethyia Instance;
	}
}
