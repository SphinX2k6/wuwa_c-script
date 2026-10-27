using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EAF RID: 7855
	[NullableContext(2)]
	[Nullable(0)]
	public class ISpringArmSoftZoneConfig
	{
		// Token: 0x0600A806 RID: 43014 RVA: 0x0017B7A8 File Offset: 0x001799A8
		[NullableContext(1)]
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

		// Token: 0x0600A807 RID: 43015 RVA: 0x0017B7E0 File Offset: 0x001799E0
		[NullableContext(1)]
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

		// Token: 0x0600A808 RID: 43016 RVA: 0x0017B7F3 File Offset: 0x001799F3
		[NullableContext(1)]
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

		// Token: 0x0600A809 RID: 43017 RVA: 0x0017B806 File Offset: 0x00179A06
		[NullableContext(1)]
		public ISpringArmSoftZoneConfig_SetValue ToSetValue()
		{
			return new ISpringArmSoftZoneConfig_SetValue
			{
				LeftRightConfig = this.LeftRightConfig,
				ForwardBackConfig = this.ForwardBackConfig,
				UpDownConfig = this.UpDownConfig
			};
		}

		// Token: 0x17003354 RID: 13140
		// (get) Token: 0x0600A80A RID: 43018 RVA: 0x0017B834 File Offset: 0x00179A34
		// (set) Token: 0x0600A80B RID: 43019 RVA: 0x0017B895 File Offset: 0x00179A95
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

		// Token: 0x17003355 RID: 13141
		// (get) Token: 0x0600A80C RID: 43020 RVA: 0x0017B8AC File Offset: 0x00179AAC
		// (set) Token: 0x0600A80D RID: 43021 RVA: 0x0017B90D File Offset: 0x00179B0D
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

		// Token: 0x17003356 RID: 13142
		// (get) Token: 0x0600A80E RID: 43022 RVA: 0x0017B924 File Offset: 0x00179B24
		// (set) Token: 0x0600A80F RID: 43023 RVA: 0x0017B985 File Offset: 0x00179B85
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

		// Token: 0x04006421 RID: 25633
		protected ISpringArmSoftZoneConfig FbInstance;

		// Token: 0x04006422 RID: 25634
		protected ISpringArmSoftZoneConfig_SetValue PocoInterface;

		// Token: 0x04006423 RID: 25635
		[Nullable(1)]
		private ISingleAxisSpringArmSoftZoneConfig _LeftRightConfigCache;

		// Token: 0x04006424 RID: 25636
		private bool _LeftRightConfigInited;

		// Token: 0x04006425 RID: 25637
		[Nullable(1)]
		private ISingleAxisSpringArmSoftZoneConfig _ForwardBackConfigCache;

		// Token: 0x04006426 RID: 25638
		private bool _ForwardBackConfigInited;

		// Token: 0x04006427 RID: 25639
		[Nullable(1)]
		private ISingleAxisSpringArmSoftZoneConfig _UpDownConfigCache;

		// Token: 0x04006428 RID: 25640
		private bool _UpDownConfigInited;
	}
}
