using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CFE RID: 11518
	public class IStopGuestCartethyia : IStopGuestUiAnimationType
	{
		// Token: 0x0600FC12 RID: 64530 RVA: 0x00247802 File Offset: 0x00245A02
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

		// Token: 0x17004EC4 RID: 20164
		// (get) Token: 0x0600FC13 RID: 64531 RVA: 0x00247821 File Offset: 0x00245A21
		public override EGuestUiAnimationType Type
		{
			get
			{
				return (EGuestUiAnimationType)this.Instance.Type;
			}
		}

		// Token: 0x040089A8 RID: 35240
		private IStopGuestCartethyia Instance;
	}
}
