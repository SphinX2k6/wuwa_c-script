using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DCB RID: 3531
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadNetworkNavigationComponent : IComponentBase
	{
		// Token: 0x0600501D RID: 20509 RVA: 0x000C5FFA File Offset: 0x000C41FA
		public static RoadNetworkNavigationComponent Create(IRoadNetworkNavigationComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RoadNetworkNavigationComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x0600501E RID: 20510 RVA: 0x000C601C File Offset: 0x000C421C
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x0600501F RID: 20511 RVA: 0x000C6054 File Offset: 0x000C4254
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x06005020 RID: 20512 RVA: 0x000C606C File Offset: 0x000C426C
		public virtual bool? KeepSelf
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepSelf);
			}
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x06005021 RID: 20513 RVA: 0x000C60A2 File Offset: 0x000C42A2
		public virtual ITrafficNavigationConfig BasicConfig
		{
			get
			{
				if (this._BasicConfigInited)
				{
					return this._BasicConfigCache;
				}
				this._BasicConfigInited = true;
				this._BasicConfigCache = ITrafficNavigationConfig.Create(this.Instance.BasicConfig);
				return this._BasicConfigCache;
			}
		}

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06005022 RID: 20514 RVA: 0x000C60D6 File Offset: 0x000C42D6
		public virtual IObstacleDetectionConfig ObstacleConfig
		{
			get
			{
				if (this._ObstacleConfigInited)
				{
					return this._ObstacleConfigCache;
				}
				this._ObstacleConfigInited = true;
				this._ObstacleConfigCache = IObstacleDetectionConfig.Create(this.Instance.ObstacleConfig);
				return this._ObstacleConfigCache;
			}
		}

		// Token: 0x04002DF0 RID: 11760
		private IRoadNetworkNavigationComponent Instance;

		// Token: 0x04002DF1 RID: 11761
		[Nullable(2)]
		private ITrafficNavigationConfig _BasicConfigCache;

		// Token: 0x04002DF2 RID: 11762
		private bool _BasicConfigInited;

		// Token: 0x04002DF3 RID: 11763
		[Nullable(2)]
		private IObstacleDetectionConfig _ObstacleConfigCache;

		// Token: 0x04002DF4 RID: 11764
		private bool _ObstacleConfigInited;
	}
}
