using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002696 RID: 9878
	public class IHonamiStoryCustomLoading : ISpecialCustomLoadingOption
	{
		// Token: 0x0600DD20 RID: 56608 RVA: 0x0020DCCC File Offset: 0x0020BECC
		[NullableContext(1)]
		public static IHonamiStoryCustomLoading Create(IHonamiStoryCustomLoading? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHonamiStoryCustomLoading
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041B6 RID: 16822
		// (get) Token: 0x0600DD21 RID: 56609 RVA: 0x0020DCEB File Offset: 0x0020BEEB
		public override ESpecialCustomLoadingType Type
		{
			get
			{
				return (ESpecialCustomLoadingType)this.Instance.Type;
			}
		}

		// Token: 0x170041B7 RID: 16823
		// (get) Token: 0x0600DD22 RID: 56610 RVA: 0x0020DCF8 File Offset: 0x0020BEF8
		public virtual int LoadingId
		{
			get
			{
				return this.Instance.LoadingId;
			}
		}

		// Token: 0x04007AD0 RID: 31440
		private IHonamiStoryCustomLoading Instance;
	}
}
