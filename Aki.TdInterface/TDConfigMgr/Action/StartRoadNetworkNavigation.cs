using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200221C RID: 8732
	[NullableContext(1)]
	[Nullable(0)]
	public class StartRoadNetworkNavigation : ActionParams
	{
		// Token: 0x0600BFB6 RID: 49078 RVA: 0x001B8B28 File Offset: 0x001B6D28
		private StartRoadNetworkNavigation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("StartRoadNetworkNavigation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			StartRoadNetworkNavigation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new StartRoadNetworkNavigation_SetValue());
			}
			return result;
		}

		// Token: 0x0600BFB7 RID: 49079 RVA: 0x001B8B60 File Offset: 0x001B6D60
		public static StartRoadNetworkNavigation Create([Nullable(2)] StartRoadNetworkNavigation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StartRoadNetworkNavigation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BFB8 RID: 49080 RVA: 0x001B8B73 File Offset: 0x001B6D73
		public static StartRoadNetworkNavigation CreateFromSetValue([Nullable(2)] StartRoadNetworkNavigation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new StartRoadNetworkNavigation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BFB9 RID: 49081 RVA: 0x001B8B86 File Offset: 0x001B6D86
		public StartRoadNetworkNavigation_SetValue ToSetValue()
		{
			return new StartRoadNetworkNavigation_SetValue
			{
				Target = this.Target,
				Start = this.Start,
				End = this.End
			};
		}

		// Token: 0x17003A15 RID: 14869
		// (get) Token: 0x0600BFBA RID: 49082 RVA: 0x001B8BB4 File Offset: 0x001B6DB4
		// (set) Token: 0x0600BFBB RID: 49083 RVA: 0x001B8C15 File Offset: 0x001B6E15
		public virtual ISceneItemRoadNetworkNavigation Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				if (this.FbInstance != null)
				{
					this._TargetCache = ISceneItemRoadNetworkNavigation.Create(this.FbInstance.Target);
				}
				else
				{
					StartRoadNetworkNavigation_SetValue pocoInterface = this.PocoInterface;
					this._TargetCache = ((pocoInterface != null) ? pocoInterface.Target : null);
				}
				return this._TargetCache;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
				this._TargetInited = false;
			}
		}

		// Token: 0x17003A16 RID: 14870
		// (get) Token: 0x0600BFBC RID: 49084 RVA: 0x001B8C2C File Offset: 0x001B6E2C
		// (set) Token: 0x0600BFBD RID: 49085 RVA: 0x001B8C8D File Offset: 0x001B6E8D
		public virtual ISplineWayPoint Start
		{
			get
			{
				if (this._StartInited)
				{
					return this._StartCache;
				}
				this._StartInited = true;
				if (this.FbInstance != null)
				{
					this._StartCache = ISplineWayPoint.Create(this.FbInstance.Start);
				}
				else
				{
					StartRoadNetworkNavigation_SetValue pocoInterface = this.PocoInterface;
					this._StartCache = ((pocoInterface != null) ? pocoInterface.Start : null);
				}
				return this._StartCache;
			}
			set
			{
				this.GetOrCreatePoco().Start = value;
				this._StartInited = false;
			}
		}

		// Token: 0x17003A17 RID: 14871
		// (get) Token: 0x0600BFBE RID: 49086 RVA: 0x001B8CA4 File Offset: 0x001B6EA4
		// (set) Token: 0x0600BFBF RID: 49087 RVA: 0x001B8D05 File Offset: 0x001B6F05
		public virtual ISplineWayPoint End
		{
			get
			{
				if (this._EndInited)
				{
					return this._EndCache;
				}
				this._EndInited = true;
				if (this.FbInstance != null)
				{
					this._EndCache = ISplineWayPoint.Create(this.FbInstance.End);
				}
				else
				{
					StartRoadNetworkNavigation_SetValue pocoInterface = this.PocoInterface;
					this._EndCache = ((pocoInterface != null) ? pocoInterface.End : null);
				}
				return this._EndCache;
			}
			set
			{
				this.GetOrCreatePoco().End = value;
				this._EndInited = false;
			}
		}

		// Token: 0x04007251 RID: 29265
		[Nullable(2)]
		protected new StartRoadNetworkNavigation FbInstance;

		// Token: 0x04007252 RID: 29266
		[Nullable(2)]
		protected StartRoadNetworkNavigation_SetValue PocoInterface;

		// Token: 0x04007253 RID: 29267
		private ISceneItemRoadNetworkNavigation _TargetCache;

		// Token: 0x04007254 RID: 29268
		private bool _TargetInited;

		// Token: 0x04007255 RID: 29269
		private ISplineWayPoint _StartCache;

		// Token: 0x04007256 RID: 29270
		private bool _StartInited;

		// Token: 0x04007257 RID: 29271
		private ISplineWayPoint _EndCache;

		// Token: 0x04007258 RID: 29272
		private bool _EndInited;
	}
}
