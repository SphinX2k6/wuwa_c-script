using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD1 RID: 10961
	public class IWaitMovieModeFixedTime : IEnterMovieModeDurationType
	{
		// Token: 0x0600F067 RID: 61543 RVA: 0x0022E882 File Offset: 0x0022CA82
		[NullableContext(1)]
		public static IWaitMovieModeFixedTime Create(IWaitMovieModeFixedTime? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaitMovieModeFixedTime
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C87 RID: 19591
		// (get) Token: 0x0600F068 RID: 61544 RVA: 0x0022E8A1 File Offset: 0x0022CAA1
		public override EEnterMovieModeDurationType Type
		{
			get
			{
				return (EEnterMovieModeDurationType)this.Instance.Type;
			}
		}

		// Token: 0x17004C88 RID: 19592
		// (get) Token: 0x0600F069 RID: 61545 RVA: 0x0022E8AE File Offset: 0x0022CAAE
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x04008439 RID: 33849
		private IWaitMovieModeFixedTime Instance;
	}
}
