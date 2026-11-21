using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DC5 RID: 11717
	public class IWaitMovieModeFixedTime : IEnterMovieModeDurationType
	{
		// Token: 0x0600FF1D RID: 65309 RVA: 0x0024C58E File Offset: 0x0024A78E
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

		// Token: 0x17005041 RID: 20545
		// (get) Token: 0x0600FF1E RID: 65310 RVA: 0x0024C5AD File Offset: 0x0024A7AD
		public override EEnterMovieModeDurationType Type
		{
			get
			{
				return (EEnterMovieModeDurationType)this.Instance.Type;
			}
		}

		// Token: 0x17005042 RID: 20546
		// (get) Token: 0x0600FF1F RID: 65311 RVA: 0x0024C5BA File Offset: 0x0024A7BA
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x04008B3D RID: 35645
		private IWaitMovieModeFixedTime Instance;
	}
}
