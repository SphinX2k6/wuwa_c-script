using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002487 RID: 9351
	public class StartRoadNetworkNavigation : ActionParams
	{
		// Token: 0x0600CB74 RID: 52084 RVA: 0x001D01F4 File Offset: 0x001CE3F4
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

		// Token: 0x0600CB75 RID: 52085 RVA: 0x001D022C File Offset: 0x001CE42C
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

		// Token: 0x0600CB76 RID: 52086 RVA: 0x001D023F File Offset: 0x001CE43F
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

		// Token: 0x0600CB77 RID: 52087 RVA: 0x001D0252 File Offset: 0x001CE452
		public StartRoadNetworkNavigation_SetValue ToSetValue()
		{
			return new StartRoadNetworkNavigation_SetValue
			{
				Target = this.Target,
				Start = this.Start,
				End = this.End
			};
		}

		// Token: 0x17003D0B RID: 15627
		// (get) Token: 0x0600CB78 RID: 52088 RVA: 0x001D0280 File Offset: 0x001CE480
		// (set) Token: 0x0600CB79 RID: 52089 RVA: 0x001D02E1 File Offset: 0x001CE4E1
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

		// Token: 0x17003D0C RID: 15628
		// (get) Token: 0x0600CB7A RID: 52090 RVA: 0x001D02F8 File Offset: 0x001CE4F8
		// (set) Token: 0x0600CB7B RID: 52091 RVA: 0x001D0359 File Offset: 0x001CE559
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

		// Token: 0x17003D0D RID: 15629
		// (get) Token: 0x0600CB7C RID: 52092 RVA: 0x001D0370 File Offset: 0x001CE570
		// (set) Token: 0x0600CB7D RID: 52093 RVA: 0x001D03D1 File Offset: 0x001CE5D1
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

		// Token: 0x0400789B RID: 30875
		[Nullable(2)]
		protected new StartRoadNetworkNavigation FbInstance;

		// Token: 0x0400789C RID: 30876
		[Nullable(2)]
		protected StartRoadNetworkNavigation_SetValue PocoInterface;

		// Token: 0x0400789D RID: 30877
		private ISceneItemRoadNetworkNavigation _TargetCache;

		// Token: 0x0400789E RID: 30878
		private bool _TargetInited;

		// Token: 0x0400789F RID: 30879
		private ISplineWayPoint _StartCache;

		// Token: 0x040078A0 RID: 30880
		private bool _StartInited;

		// Token: 0x040078A1 RID: 30881
		private ISplineWayPoint _EndCache;

		// Token: 0x040078A2 RID: 30882
		private bool _EndInited;
	}
}
