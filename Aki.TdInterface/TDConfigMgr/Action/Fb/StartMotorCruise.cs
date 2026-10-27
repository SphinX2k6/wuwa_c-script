using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AA7 RID: 10919
	[NullableContext(1)]
	[Nullable(0)]
	public class StartMotorCruise : ActionParams
	{
		// Token: 0x0600EFBF RID: 61375 RVA: 0x0022D7BF File Offset: 0x0022B9BF
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

		// Token: 0x17004C33 RID: 19507
		// (get) Token: 0x0600EFC0 RID: 61376 RVA: 0x0022D7DE File Offset: 0x0022B9DE
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

		// Token: 0x17004C34 RID: 19508
		// (get) Token: 0x0600EFC1 RID: 61377 RVA: 0x0022D812 File Offset: 0x0022BA12
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

		// Token: 0x17004C35 RID: 19509
		// (get) Token: 0x0600EFC2 RID: 61378 RVA: 0x0022D846 File Offset: 0x0022BA46
		public virtual bool AllowSkip
		{
			get
			{
				return this.Instance.AllowSkip;
			}
		}

		// Token: 0x040083E5 RID: 33765
		private IStartMotorCruise Instance;

		// Token: 0x040083E6 RID: 33766
		[Nullable(2)]
		private ISplineWayPoint _StartPointCache;

		// Token: 0x040083E7 RID: 33767
		private bool _StartPointInited;

		// Token: 0x040083E8 RID: 33768
		[Nullable(2)]
		private ISplineWayPoint _EndPointCache;

		// Token: 0x040083E9 RID: 33769
		private bool _EndPointInited;
	}
}
