using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020E8 RID: 8424
	[NullableContext(2)]
	[Nullable(0)]
	public class ISpringArmSoftZoneConfig
	{
		// Token: 0x0600B2D6 RID: 45782 RVA: 0x00191748 File Offset: 0x0018F948
		[NullableContext(0)]
		private ISpringArmSoftZoneConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpringArmSoftZoneConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpringArmSoftZoneConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpringArmSoftZoneConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600B2D7 RID: 45783 RVA: 0x00191780 File Offset: 0x0018F980
		[NullableContext(0)]
		public static ISpringArmSoftZoneConfig Create([Nullable(2)] ISpringArmSoftZoneConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpringArmSoftZoneConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B2D8 RID: 45784 RVA: 0x00191793 File Offset: 0x0018F993
		[NullableContext(0)]
		public static ISpringArmSoftZoneConfig CreateFromSetValue([Nullable(2)] ISpringArmSoftZoneConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpringArmSoftZoneConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B2D9 RID: 45785 RVA: 0x001917A6 File Offset: 0x0018F9A6
		[NullableContext(0)]
		public ISpringArmSoftZoneConfig_SetValue ToSetValue()
		{
			return new ISpringArmSoftZoneConfig_SetValue
			{
				LeftRightConfig = this.LeftRightConfig,
				ForwardBackConfig = this.ForwardBackConfig,
				UpDownConfig = this.UpDownConfig
			};
		}

		// Token: 0x1700361E RID: 13854
		// (get) Token: 0x0600B2DA RID: 45786 RVA: 0x001917D4 File Offset: 0x0018F9D4
		// (set) Token: 0x0600B2DB RID: 45787 RVA: 0x00191835 File Offset: 0x0018FA35
		public virtual ISingleAxisSpringArmSoftZoneConfig LeftRightConfig
		{
			get
			{
				if (this._LeftRightConfigInited)
				{
					return this._LeftRightConfigCache;
				}
				this._LeftRightConfigInited = true;
				if (this.FbInstance != null)
				{
					this._LeftRightConfigCache = ISingleAxisSpringArmSoftZoneConfig.Create(this.FbInstance.LeftRightConfig);
				}
				else
				{
					ISpringArmSoftZoneConfig_SetValue pocoInterface = this.PocoInterface;
					this._LeftRightConfigCache = ((pocoInterface != null) ? pocoInterface.LeftRightConfig : null);
				}
				return this._LeftRightConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().LeftRightConfig = value;
				this._LeftRightConfigInited = false;
			}
		}

		// Token: 0x1700361F RID: 13855
		// (get) Token: 0x0600B2DC RID: 45788 RVA: 0x0019184C File Offset: 0x0018FA4C
		// (set) Token: 0x0600B2DD RID: 45789 RVA: 0x001918AD File Offset: 0x0018FAAD
		public virtual ISingleAxisSpringArmSoftZoneConfig ForwardBackConfig
		{
			get
			{
				if (this._ForwardBackConfigInited)
				{
					return this._ForwardBackConfigCache;
				}
				this._ForwardBackConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ForwardBackConfigCache = ISingleAxisSpringArmSoftZoneConfig.Create(this.FbInstance.ForwardBackConfig);
				}
				else
				{
					ISpringArmSoftZoneConfig_SetValue pocoInterface = this.PocoInterface;
					this._ForwardBackConfigCache = ((pocoInterface != null) ? pocoInterface.ForwardBackConfig : null);
				}
				return this._ForwardBackConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().ForwardBackConfig = value;
				this._ForwardBackConfigInited = false;
			}
		}

		// Token: 0x17003620 RID: 13856
		// (get) Token: 0x0600B2DE RID: 45790 RVA: 0x001918C4 File Offset: 0x0018FAC4
		// (set) Token: 0x0600B2DF RID: 45791 RVA: 0x00191925 File Offset: 0x0018FB25
		public virtual ISingleAxisSpringArmSoftZoneConfig UpDownConfig
		{
			get
			{
				if (this._UpDownConfigInited)
				{
					return this._UpDownConfigCache;
				}
				this._UpDownConfigInited = true;
				if (this.FbInstance != null)
				{
					this._UpDownConfigCache = ISingleAxisSpringArmSoftZoneConfig.Create(this.FbInstance.UpDownConfig);
				}
				else
				{
					ISpringArmSoftZoneConfig_SetValue pocoInterface = this.PocoInterface;
					this._UpDownConfigCache = ((pocoInterface != null) ? pocoInterface.UpDownConfig : null);
				}
				return this._UpDownConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().UpDownConfig = value;
				this._UpDownConfigInited = false;
			}
		}

		// Token: 0x04006A0F RID: 27151
		protected ISpringArmSoftZoneConfig FbInstance;

		// Token: 0x04006A10 RID: 27152
		protected ISpringArmSoftZoneConfig_SetValue PocoInterface;

		// Token: 0x04006A11 RID: 27153
		[Nullable(0)]
		private ISingleAxisSpringArmSoftZoneConfig _LeftRightConfigCache;

		// Token: 0x04006A12 RID: 27154
		private bool _LeftRightConfigInited;

		// Token: 0x04006A13 RID: 27155
		[Nullable(0)]
		private ISingleAxisSpringArmSoftZoneConfig _ForwardBackConfigCache;

		// Token: 0x04006A14 RID: 27156
		private bool _ForwardBackConfigInited;

		// Token: 0x04006A15 RID: 27157
		[Nullable(0)]
		private ISingleAxisSpringArmSoftZoneConfig _UpDownConfigCache;

		// Token: 0x04006A16 RID: 27158
		private bool _UpDownConfigInited;
	}
}
