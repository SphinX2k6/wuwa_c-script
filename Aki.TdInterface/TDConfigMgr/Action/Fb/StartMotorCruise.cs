using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D9B RID: 11675
	public class StartMotorCruise : ActionParams
	{
		// Token: 0x0600FE75 RID: 65141 RVA: 0x0024B4CB File Offset: 0x002496CB
		public static StartMotorCruise Create(IStartMotorCruise? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StartMotorCruise
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FED RID: 20461
		// (get) Token: 0x0600FE76 RID: 65142 RVA: 0x0024B4EA File Offset: 0x002496EA
		public virtual ISplineWayPoint StartPoint
		{
			get
			{
				if (this._StartPointInited)
				{
					return this._StartPointCache;
				}
				this._StartPointInited = true;
				this._StartPointCache = ISplineWayPoint.Create(this.Instance.StartPoint);
				return this._StartPointCache;
			}
		}

		// Token: 0x17004FEE RID: 20462
		// (get) Token: 0x0600FE77 RID: 65143 RVA: 0x0024B51E File Offset: 0x0024971E
		public virtual ISplineWayPoint EndPoint
		{
			get
			{
				if (this._EndPointInited)
				{
					return this._EndPointCache;
				}
				this._EndPointInited = true;
				this._EndPointCache = ISplineWayPoint.Create(this.Instance.EndPoint);
				return this._EndPointCache;
			}
		}

		// Token: 0x17004FEF RID: 20463
		// (get) Token: 0x0600FE78 RID: 65144 RVA: 0x0024B552 File Offset: 0x00249752
		public virtual bool AllowSkip
		{
			get
			{
				return this.Instance.AllowSkip;
			}
		}

		// Token: 0x04008AE9 RID: 35561
		private IStartMotorCruise Instance;

		// Token: 0x04008AEA RID: 35562
		[Nullable(2)]
		private ISplineWayPoint _StartPointCache;

		// Token: 0x04008AEB RID: 35563
		private bool _StartPointInited;

		// Token: 0x04008AEC RID: 35564
		[Nullable(2)]
		private ISplineWayPoint _EndPointCache;

		// Token: 0x04008AED RID: 35565
		private bool _EndPointInited;
	}
}
