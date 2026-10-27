using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200221A RID: 8730
	[NullableContext(1)]
	[Nullable(0)]
	public class StartMotorCruise : ActionParams
	{
		// Token: 0x0600BFAA RID: 49066 RVA: 0x001B8964 File Offset: 0x001B6B64
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

		// Token: 0x0600BFAB RID: 49067 RVA: 0x001B899C File Offset: 0x001B6B9C
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

		// Token: 0x0600BFAC RID: 49068 RVA: 0x001B89AF File Offset: 0x001B6BAF
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

		// Token: 0x0600BFAD RID: 49069 RVA: 0x001B89C2 File Offset: 0x001B6BC2
		public StartMotorCruise_SetValue ToSetValue()
		{
			return new StartMotorCruise_SetValue
			{
				StartPoint = this.StartPoint,
				EndPoint = this.EndPoint,
				AllowSkip = this.AllowSkip
			};
		}

		// Token: 0x17003A12 RID: 14866
		// (get) Token: 0x0600BFAE RID: 49070 RVA: 0x001B89F0 File Offset: 0x001B6BF0
		// (set) Token: 0x0600BFAF RID: 49071 RVA: 0x001B8A51 File Offset: 0x001B6C51
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

		// Token: 0x17003A13 RID: 14867
		// (get) Token: 0x0600BFB0 RID: 49072 RVA: 0x001B8A68 File Offset: 0x001B6C68
		// (set) Token: 0x0600BFB1 RID: 49073 RVA: 0x001B8AC9 File Offset: 0x001B6CC9
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

		// Token: 0x17003A14 RID: 14868
		// (get) Token: 0x0600BFB2 RID: 49074 RVA: 0x001B8ADE File Offset: 0x001B6CDE
		// (set) Token: 0x0600BFB3 RID: 49075 RVA: 0x001B8B09 File Offset: 0x001B6D09
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

		// Token: 0x04007248 RID: 29256
		[Nullable(2)]
		protected new StartMotorCruise FbInstance;

		// Token: 0x04007249 RID: 29257
		[Nullable(2)]
		protected StartMotorCruise_SetValue PocoInterface;

		// Token: 0x0400724A RID: 29258
		private ISplineWayPoint _StartPointCache;

		// Token: 0x0400724B RID: 29259
		private bool _StartPointInited;

		// Token: 0x0400724C RID: 29260
		private ISplineWayPoint _EndPointCache;

		// Token: 0x0400724D RID: 29261
		private bool _EndPointInited;
	}
}
