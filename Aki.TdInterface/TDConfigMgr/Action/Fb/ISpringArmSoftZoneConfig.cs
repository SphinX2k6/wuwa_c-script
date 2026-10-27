using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028A4 RID: 10404
	[NullableContext(2)]
	[Nullable(0)]
	public class ISpringArmSoftZoneConfig
	{
		// Token: 0x0600E651 RID: 58961 RVA: 0x0021D712 File Offset: 0x0021B912
		[NullableContext(1)]
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

		// Token: 0x170046CB RID: 18123
		// (get) Token: 0x0600E652 RID: 58962 RVA: 0x0021D731 File Offset: 0x0021B931
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

		// Token: 0x170046CC RID: 18124
		// (get) Token: 0x0600E653 RID: 58963 RVA: 0x0021D765 File Offset: 0x0021B965
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

		// Token: 0x170046CD RID: 18125
		// (get) Token: 0x0600E654 RID: 58964 RVA: 0x0021D799 File Offset: 0x0021B999
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

		// Token: 0x04007F54 RID: 32596
		private ISpringArmSoftZoneConfig Instance;

		// Token: 0x04007F55 RID: 32597
		private ISingleAxisSpringArmSoftZoneConfig _LeftRightConfigCache;

		// Token: 0x04007F56 RID: 32598
		private bool _LeftRightConfigInited;

		// Token: 0x04007F57 RID: 32599
		private ISingleAxisSpringArmSoftZoneConfig _ForwardBackConfigCache;

		// Token: 0x04007F58 RID: 32600
		private bool _ForwardBackConfigInited;

		// Token: 0x04007F59 RID: 32601
		private ISingleAxisSpringArmSoftZoneConfig _UpDownConfigCache;

		// Token: 0x04007F5A RID: 32602
		private bool _UpDownConfigInited;
	}
}
