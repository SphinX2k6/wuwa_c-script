using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B79 RID: 11129
	[NullableContext(2)]
	[Nullable(0)]
	public class ISpringArmSoftZoneConfig
	{
		// Token: 0x0600F480 RID: 62592 RVA: 0x0023A692 File Offset: 0x00238892
		[NullableContext(0)]
		public static ISpringArmSoftZoneConfig Create(ISpringArmSoftZoneConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpringArmSoftZoneConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A3C RID: 19004
		// (get) Token: 0x0600F481 RID: 62593 RVA: 0x0023A6B1 File Offset: 0x002388B1
		public virtual ISingleAxisSpringArmSoftZoneConfig LeftRightConfig
		{
			get
			{
				if (this._LeftRightConfigInited)
				{
					return this._LeftRightConfigCache;
				}
				this._LeftRightConfigInited = true;
				this._LeftRightConfigCache = ISingleAxisSpringArmSoftZoneConfig.Create(this.Instance.LeftRightConfig);
				return this._LeftRightConfigCache;
			}
		}

		// Token: 0x17004A3D RID: 19005
		// (get) Token: 0x0600F482 RID: 62594 RVA: 0x0023A6E5 File Offset: 0x002388E5
		public virtual ISingleAxisSpringArmSoftZoneConfig ForwardBackConfig
		{
			get
			{
				if (this._ForwardBackConfigInited)
				{
					return this._ForwardBackConfigCache;
				}
				this._ForwardBackConfigInited = true;
				this._ForwardBackConfigCache = ISingleAxisSpringArmSoftZoneConfig.Create(this.Instance.ForwardBackConfig);
				return this._ForwardBackConfigCache;
			}
		}

		// Token: 0x17004A3E RID: 19006
		// (get) Token: 0x0600F483 RID: 62595 RVA: 0x0023A719 File Offset: 0x00238919
		public virtual ISingleAxisSpringArmSoftZoneConfig UpDownConfig
		{
			get
			{
				if (this._UpDownConfigInited)
				{
					return this._UpDownConfigCache;
				}
				this._UpDownConfigInited = true;
				this._UpDownConfigCache = ISingleAxisSpringArmSoftZoneConfig.Create(this.Instance.UpDownConfig);
				return this._UpDownConfigCache;
			}
		}

		// Token: 0x04008613 RID: 34323
		private ISpringArmSoftZoneConfig Instance;

		// Token: 0x04008614 RID: 34324
		private ISingleAxisSpringArmSoftZoneConfig _LeftRightConfigCache;

		// Token: 0x04008615 RID: 34325
		private bool _LeftRightConfigInited;

		// Token: 0x04008616 RID: 34326
		private ISingleAxisSpringArmSoftZoneConfig _ForwardBackConfigCache;

		// Token: 0x04008617 RID: 34327
		private bool _ForwardBackConfigInited;

		// Token: 0x04008618 RID: 34328
		private ISingleAxisSpringArmSoftZoneConfig _UpDownConfigCache;

		// Token: 0x04008619 RID: 34329
		private bool _UpDownConfigInited;
	}
}
