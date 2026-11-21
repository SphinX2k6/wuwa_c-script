using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EC7 RID: 3783
	public class RoadNetworkNavigationComponent : IComponentBase
	{
		// Token: 0x06005542 RID: 21826 RVA: 0x000D184A File Offset: 0x000CFA4A
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

		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x06005543 RID: 21827 RVA: 0x000D186C File Offset: 0x000CFA6C
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

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x06005544 RID: 21828 RVA: 0x000D18A4 File Offset: 0x000CFAA4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x06005545 RID: 21829 RVA: 0x000D18BC File Offset: 0x000CFABC
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

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x06005546 RID: 21830 RVA: 0x000D18F2 File Offset: 0x000CFAF2
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

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x06005547 RID: 21831 RVA: 0x000D1926 File Offset: 0x000CFB26
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

		// Token: 0x040030B6 RID: 12470
		private IRoadNetworkNavigationComponent Instance;

		// Token: 0x040030B7 RID: 12471
		[Nullable(2)]
		private ITrafficNavigationConfig _BasicConfigCache;

		// Token: 0x040030B8 RID: 12472
		private bool _BasicConfigInited;

		// Token: 0x040030B9 RID: 12473
		[Nullable(2)]
		private IObstacleDetectionConfig _ObstacleConfigCache;

		// Token: 0x040030BA RID: 12474
		private bool _ObstacleConfigInited;
	}
}
