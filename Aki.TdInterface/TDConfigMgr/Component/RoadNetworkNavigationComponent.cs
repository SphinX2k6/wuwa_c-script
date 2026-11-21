using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200091C RID: 2332
	public class RoadNetworkNavigationComponent : IComponentBase
	{
		// Token: 0x0600336D RID: 13165 RVA: 0x0008360C File Offset: 0x0008180C
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

		// Token: 0x0600336E RID: 13166 RVA: 0x00083644 File Offset: 0x00081844
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

		// Token: 0x0600336F RID: 13167 RVA: 0x00083657 File Offset: 0x00081857
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

		// Token: 0x06003370 RID: 13168 RVA: 0x0008366C File Offset: 0x0008186C
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

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06003371 RID: 13169 RVA: 0x000836BC File Offset: 0x000818BC
		// (set) Token: 0x06003372 RID: 13170 RVA: 0x000836F6 File Offset: 0x000818F6
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

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06003373 RID: 13171 RVA: 0x00083704 File Offset: 0x00081904
		// (set) Token: 0x06003374 RID: 13172 RVA: 0x0008372E File Offset: 0x0008192E
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

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06003375 RID: 13173 RVA: 0x0008373C File Offset: 0x0008193C
		// (set) Token: 0x06003376 RID: 13174 RVA: 0x00083776 File Offset: 0x00081976
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

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06003377 RID: 13175 RVA: 0x00083784 File Offset: 0x00081984
		// (set) Token: 0x06003378 RID: 13176 RVA: 0x000837E5 File Offset: 0x000819E5
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

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06003379 RID: 13177 RVA: 0x000837FC File Offset: 0x000819FC
		// (set) Token: 0x0600337A RID: 13178 RVA: 0x0008385D File Offset: 0x00081A5D
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

		// Token: 0x040021C8 RID: 8648
		[Nullable(2)]
		protected new RoadNetworkNavigationComponent FbInstance;

		// Token: 0x040021C9 RID: 8649
		[Nullable(2)]
		protected new RoadNetworkNavigationComponent_SetValue PocoInterface;

		// Token: 0x040021CA RID: 8650
		private ITrafficNavigationConfig _BasicConfigCache;

		// Token: 0x040021CB RID: 8651
		private bool _BasicConfigInited;

		// Token: 0x040021CC RID: 8652
		private IObstacleDetectionConfig _ObstacleConfigCache;

		// Token: 0x040021CD RID: 8653
		private bool _ObstacleConfigInited;
	}
}
