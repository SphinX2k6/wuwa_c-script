using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002485 RID: 9349
	public class StartMotorCruise : ActionParams
	{
		// Token: 0x0600CB68 RID: 52072 RVA: 0x001D0030 File Offset: 0x001CE230
		private StartMotorCruise_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("StartMotorCruise 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			StartMotorCruise_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new StartMotorCruise_SetValue());
			}
			return result;
		}

		// Token: 0x0600CB69 RID: 52073 RVA: 0x001D0068 File Offset: 0x001CE268
		public static StartMotorCruise Create([Nullable(2)] StartMotorCruise instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StartMotorCruise
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CB6A RID: 52074 RVA: 0x001D007B File Offset: 0x001CE27B
		public static StartMotorCruise CreateFromSetValue([Nullable(2)] StartMotorCruise_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new StartMotorCruise
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CB6B RID: 52075 RVA: 0x001D008E File Offset: 0x001CE28E
		public StartMotorCruise_SetValue ToSetValue()
		{
			return new StartMotorCruise_SetValue
			{
				StartPoint = this.StartPoint,
				EndPoint = this.EndPoint,
				AllowSkip = this.AllowSkip
			};
		}

		// Token: 0x17003D08 RID: 15624
		// (get) Token: 0x0600CB6C RID: 52076 RVA: 0x001D00BC File Offset: 0x001CE2BC
		// (set) Token: 0x0600CB6D RID: 52077 RVA: 0x001D011D File Offset: 0x001CE31D
		public virtual ISplineWayPoint StartPoint
		{
			get
			{
				if (this._StartPointInited)
				{
					return this._StartPointCache;
				}
				this._StartPointInited = true;
				if (this.FbInstance != null)
				{
					this._StartPointCache = ISplineWayPoint.Create(this.FbInstance.StartPoint);
				}
				else
				{
					StartMotorCruise_SetValue pocoInterface = this.PocoInterface;
					this._StartPointCache = ((pocoInterface != null) ? pocoInterface.StartPoint : null);
				}
				return this._StartPointCache;
			}
			set
			{
				this.GetOrCreatePoco().StartPoint = value;
				this._StartPointInited = false;
			}
		}

		// Token: 0x17003D09 RID: 15625
		// (get) Token: 0x0600CB6E RID: 52078 RVA: 0x001D0134 File Offset: 0x001CE334
		// (set) Token: 0x0600CB6F RID: 52079 RVA: 0x001D0195 File Offset: 0x001CE395
		public virtual ISplineWayPoint EndPoint
		{
			get
			{
				if (this._EndPointInited)
				{
					return this._EndPointCache;
				}
				this._EndPointInited = true;
				if (this.FbInstance != null)
				{
					this._EndPointCache = ISplineWayPoint.Create(this.FbInstance.EndPoint);
				}
				else
				{
					StartMotorCruise_SetValue pocoInterface = this.PocoInterface;
					this._EndPointCache = ((pocoInterface != null) ? pocoInterface.EndPoint : null);
				}
				return this._EndPointCache;
			}
			set
			{
				this.GetOrCreatePoco().EndPoint = value;
				this._EndPointInited = false;
			}
		}

		// Token: 0x17003D0A RID: 15626
		// (get) Token: 0x0600CB70 RID: 52080 RVA: 0x001D01AA File Offset: 0x001CE3AA
		// (set) Token: 0x0600CB71 RID: 52081 RVA: 0x001D01D5 File Offset: 0x001CE3D5
		public virtual bool AllowSkip
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AllowSkip;
				}
				return this.PocoInterface != null && this.PocoInterface.AllowSkip;
			}
			set
			{
				this.GetOrCreatePoco().AllowSkip = value;
			}
		}

		// Token: 0x04007892 RID: 30866
		[Nullable(2)]
		protected new StartMotorCruise FbInstance;

		// Token: 0x04007893 RID: 30867
		[Nullable(2)]
		protected StartMotorCruise_SetValue PocoInterface;

		// Token: 0x04007894 RID: 30868
		private ISplineWayPoint _StartPointCache;

		// Token: 0x04007895 RID: 30869
		private bool _StartPointInited;

		// Token: 0x04007896 RID: 30870
		private ISplineWayPoint _EndPointCache;

		// Token: 0x04007897 RID: 30871
		private bool _EndPointInited;
	}
}
