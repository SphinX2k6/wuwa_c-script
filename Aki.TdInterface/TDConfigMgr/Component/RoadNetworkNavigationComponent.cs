using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000879 RID: 2169
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadNetworkNavigationComponent : IComponentBase
	{
		// Token: 0x06003031 RID: 12337 RVA: 0x0007C124 File Offset: 0x0007A324
		private RoadNetworkNavigationComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RoadNetworkNavigationComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RoadNetworkNavigationComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RoadNetworkNavigationComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x0007C15C File Offset: 0x0007A35C
		public static RoadNetworkNavigationComponent Create([Nullable(2)] RoadNetworkNavigationComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RoadNetworkNavigationComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003033 RID: 12339 RVA: 0x0007C16F File Offset: 0x0007A36F
		public static RoadNetworkNavigationComponent CreateFromSetValue([Nullable(2)] RoadNetworkNavigationComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RoadNetworkNavigationComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x0007C184 File Offset: 0x0007A384
		public new RoadNetworkNavigationComponent_SetValue ToSetValue()
		{
			return new RoadNetworkNavigationComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				KeepSelf = this.KeepSelf,
				BasicConfig = this.BasicConfig,
				ObstacleConfig = this.ObstacleConfig
			};
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x06003035 RID: 12341 RVA: 0x0007C1D4 File Offset: 0x0007A3D4
		// (set) Token: 0x06003036 RID: 12342 RVA: 0x0007C20E File Offset: 0x0007A40E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				RoadNetworkNavigationComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06003037 RID: 12343 RVA: 0x0007C21C File Offset: 0x0007A41C
		// (set) Token: 0x06003038 RID: 12344 RVA: 0x0007C246 File Offset: 0x0007A446
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06003039 RID: 12345 RVA: 0x0007C254 File Offset: 0x0007A454
		// (set) Token: 0x0600303A RID: 12346 RVA: 0x0007C28E File Offset: 0x0007A48E
		public virtual bool? KeepSelf
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepSelf;
				}
				RoadNetworkNavigationComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepSelf;
			}
			set
			{
				this.GetOrCreatePoco().KeepSelf = value;
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x0600303B RID: 12347 RVA: 0x0007C29C File Offset: 0x0007A49C
		// (set) Token: 0x0600303C RID: 12348 RVA: 0x0007C2FD File Offset: 0x0007A4FD
		public virtual ITrafficNavigationConfig BasicConfig
		{
			get
			{
				if (this._BasicConfigInited)
				{
					return this._BasicConfigCache;
				}
				this._BasicConfigInited = true;
				if (this.FbInstance != null)
				{
					this._BasicConfigCache = ITrafficNavigationConfig.Create(this.FbInstance.BasicConfig);
				}
				else
				{
					RoadNetworkNavigationComponent_SetValue pocoInterface = this.PocoInterface;
					this._BasicConfigCache = ((pocoInterface != null) ? pocoInterface.BasicConfig : null);
				}
				return this._BasicConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().BasicConfig = value;
				this._BasicConfigInited = false;
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x0600303D RID: 12349 RVA: 0x0007C314 File Offset: 0x0007A514
		// (set) Token: 0x0600303E RID: 12350 RVA: 0x0007C375 File Offset: 0x0007A575
		public virtual IObstacleDetectionConfig ObstacleConfig
		{
			get
			{
				if (this._ObstacleConfigInited)
				{
					return this._ObstacleConfigCache;
				}
				this._ObstacleConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ObstacleConfigCache = IObstacleDetectionConfig.Create(this.FbInstance.ObstacleConfig);
				}
				else
				{
					RoadNetworkNavigationComponent_SetValue pocoInterface = this.PocoInterface;
					this._ObstacleConfigCache = ((pocoInterface != null) ? pocoInterface.ObstacleConfig : null);
				}
				return this._ObstacleConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().ObstacleConfig = value;
				this._ObstacleConfigInited = false;
			}
		}

		// Token: 0x04001FB6 RID: 8118
		[Nullable(2)]
		protected new RoadNetworkNavigationComponent FbInstance;

		// Token: 0x04001FB7 RID: 8119
		[Nullable(2)]
		protected new RoadNetworkNavigationComponent_SetValue PocoInterface;

		// Token: 0x04001FB8 RID: 8120
		private ITrafficNavigationConfig _BasicConfigCache;

		// Token: 0x04001FB9 RID: 8121
		private bool _BasicConfigInited;

		// Token: 0x04001FBA RID: 8122
		private IObstacleDetectionConfig _ObstacleConfigCache;

		// Token: 0x04001FBB RID: 8123
		private bool _ObstacleConfigInited;
	}
}
