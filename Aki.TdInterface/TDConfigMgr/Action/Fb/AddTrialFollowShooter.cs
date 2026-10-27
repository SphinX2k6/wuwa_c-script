using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002991 RID: 10641
	[NullableContext(1)]
	[Nullable(0)]
	public class AddTrialFollowShooter : ActionParams
	{
		// Token: 0x0600EB98 RID: 60312 RVA: 0x00227422 File Offset: 0x00225622
		public static AddTrialFollowShooter Create(IAddTrialFollowShooter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AddTrialFollowShooter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A38 RID: 19000
		// (get) Token: 0x0600EB99 RID: 60313 RVA: 0x00227441 File Offset: 0x00225641
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004A39 RID: 19001
		// (get) Token: 0x0600EB9A RID: 60314 RVA: 0x0022744E File Offset: 0x0022564E
		public virtual IActiveRange ActiveRange
		{
			get
			{
				if (this._ActiveRangeInited)
				{
					return this._ActiveRangeCache;
				}
				this._ActiveRangeInited = true;
				this._ActiveRangeCache = IActiveRange.Create(this.Instance.ActiveRange);
				return this._ActiveRangeCache;
			}
		}

		// Token: 0x040081BF RID: 33215
		private IAddTrialFollowShooter Instance;

		// Token: 0x040081C0 RID: 33216
		[Nullable(2)]
		private IActiveRange _ActiveRangeCache;

		// Token: 0x040081C1 RID: 33217
		private bool _ActiveRangeInited;
	}
}
