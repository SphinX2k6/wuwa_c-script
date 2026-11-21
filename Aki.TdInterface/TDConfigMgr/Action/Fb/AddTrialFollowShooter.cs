using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C78 RID: 11384
	public class AddTrialFollowShooter : ActionParams
	{
		// Token: 0x0600FA16 RID: 64022 RVA: 0x00244BAE File Offset: 0x00242DAE
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

		// Token: 0x17004DD4 RID: 19924
		// (get) Token: 0x0600FA17 RID: 64023 RVA: 0x00244BCD File Offset: 0x00242DCD
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004DD5 RID: 19925
		// (get) Token: 0x0600FA18 RID: 64024 RVA: 0x00244BDA File Offset: 0x00242DDA
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

		// Token: 0x040088A4 RID: 34980
		private IAddTrialFollowShooter Instance;

		// Token: 0x040088A5 RID: 34981
		[Nullable(2)]
		private IActiveRange _ActiveRangeCache;

		// Token: 0x040088A6 RID: 34982
		private bool _ActiveRangeInited;
	}
}
