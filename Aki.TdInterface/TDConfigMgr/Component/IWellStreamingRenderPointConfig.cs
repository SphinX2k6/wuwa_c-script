using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007E1 RID: 2017
	[NullableContext(1)]
	[Nullable(0)]
	public class IWellStreamingRenderPointConfig
	{
		// Token: 0x06002BCF RID: 11215 RVA: 0x00072208 File Offset: 0x00070408
		private IWellStreamingRenderPointConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWellStreamingRenderPointConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWellStreamingRenderPointConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWellStreamingRenderPointConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x00072240 File Offset: 0x00070440
		public static IWellStreamingRenderPointConfig Create([Nullable(2)] IWellStreamingRenderPointConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWellStreamingRenderPointConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x00072253 File Offset: 0x00070453
		public static IWellStreamingRenderPointConfig CreateFromSetValue([Nullable(2)] IWellStreamingRenderPointConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWellStreamingRenderPointConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x00072268 File Offset: 0x00070468
		public IWellStreamingRenderPointConfig_SetValue ToSetValue()
		{
			return new IWellStreamingRenderPointConfig_SetValue
			{
				TargetConfig = this.TargetConfig,
				RtSize = this.RtSize,
				IsRenderStreamingPointEntity = this.IsRenderStreamingPointEntity,
				RtRenderRefPosActorKey = this.RtRenderRefPosActorKey,
				FallbackCubeMapTexturePath = this.FallbackCubeMapTexturePath
			};
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06002BD3 RID: 11219 RVA: 0x000722B8 File Offset: 0x000704B8
		// (set) Token: 0x06002BD4 RID: 11220 RVA: 0x00072319 File Offset: 0x00070519
		public virtual IPortalRenderConfig TargetConfig
		{
			get
			{
				if (this._TargetConfigInited)
				{
					return this._TargetConfigCache;
				}
				this._TargetConfigInited = true;
				if (this.FbInstance != null)
				{
					this._TargetConfigCache = IPortalRenderConfig.Create(this.FbInstance.TargetConfig);
				}
				else
				{
					IWellStreamingRenderPointConfig_SetValue pocoInterface = this.PocoInterface;
					this._TargetConfigCache = ((pocoInterface != null) ? pocoInterface.TargetConfig : null);
				}
				return this._TargetConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().TargetConfig = value;
				this._TargetConfigInited = false;
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06002BD5 RID: 11221 RVA: 0x00072330 File Offset: 0x00070530
		// (set) Token: 0x06002BD6 RID: 11222 RVA: 0x00072391 File Offset: 0x00070591
		public virtual IRtSize RtSize
		{
			get
			{
				if (this._RtSizeInited)
				{
					return this._RtSizeCache;
				}
				this._RtSizeInited = true;
				if (this.FbInstance != null)
				{
					this._RtSizeCache = IRtSize.Create(this.FbInstance.RtSize);
				}
				else
				{
					IWellStreamingRenderPointConfig_SetValue pocoInterface = this.PocoInterface;
					this._RtSizeCache = ((pocoInterface != null) ? pocoInterface.RtSize : null);
				}
				return this._RtSizeCache;
			}
			set
			{
				this.GetOrCreatePoco().RtSize = value;
				this._RtSizeInited = false;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06002BD7 RID: 11223 RVA: 0x000723A8 File Offset: 0x000705A8
		// (set) Token: 0x06002BD8 RID: 11224 RVA: 0x000723E2 File Offset: 0x000705E2
		public virtual bool? IsRenderStreamingPointEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsRenderStreamingPointEntity;
				}
				IWellStreamingRenderPointConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsRenderStreamingPointEntity;
			}
			set
			{
				this.GetOrCreatePoco().IsRenderStreamingPointEntity = value;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06002BD9 RID: 11225 RVA: 0x000723F0 File Offset: 0x000705F0
		// (set) Token: 0x06002BDA RID: 11226 RVA: 0x00072417 File Offset: 0x00070617
		[Nullable(2)]
		public virtual string RtRenderRefPosActorKey
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RtRenderRefPosActorKey;
				}
				IWellStreamingRenderPointConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RtRenderRefPosActorKey;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().RtRenderRefPosActorKey = value;
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06002BDB RID: 11227 RVA: 0x00072425 File Offset: 0x00070625
		// (set) Token: 0x06002BDC RID: 11228 RVA: 0x00072450 File Offset: 0x00070650
		public virtual string FallbackCubeMapTexturePath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FallbackCubeMapTexturePath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.FallbackCubeMapTexturePath;
			}
			set
			{
				this.GetOrCreatePoco().FallbackCubeMapTexturePath = value;
			}
		}

		// Token: 0x04001D11 RID: 7441
		[Nullable(2)]
		protected IWellStreamingRenderPointConfig FbInstance;

		// Token: 0x04001D12 RID: 7442
		[Nullable(2)]
		protected IWellStreamingRenderPointConfig_SetValue PocoInterface;

		// Token: 0x04001D13 RID: 7443
		private IPortalRenderConfig _TargetConfigCache;

		// Token: 0x04001D14 RID: 7444
		private bool _TargetConfigInited;

		// Token: 0x04001D15 RID: 7445
		private IRtSize _RtSizeCache;

		// Token: 0x04001D16 RID: 7446
		private bool _RtSizeInited;
	}
}
