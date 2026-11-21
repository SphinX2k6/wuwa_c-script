using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000884 RID: 2180
	public class IWellStreamingRenderPointConfig
	{
		// Token: 0x06002EFF RID: 12031 RVA: 0x0007956C File Offset: 0x0007776C
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

		// Token: 0x06002F00 RID: 12032 RVA: 0x000795A4 File Offset: 0x000777A4
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

		// Token: 0x06002F01 RID: 12033 RVA: 0x000795B7 File Offset: 0x000777B7
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

		// Token: 0x06002F02 RID: 12034 RVA: 0x000795CC File Offset: 0x000777CC
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

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06002F03 RID: 12035 RVA: 0x0007961C File Offset: 0x0007781C
		// (set) Token: 0x06002F04 RID: 12036 RVA: 0x0007967D File Offset: 0x0007787D
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

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06002F05 RID: 12037 RVA: 0x00079694 File Offset: 0x00077894
		// (set) Token: 0x06002F06 RID: 12038 RVA: 0x000796F5 File Offset: 0x000778F5
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

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06002F07 RID: 12039 RVA: 0x0007970C File Offset: 0x0007790C
		// (set) Token: 0x06002F08 RID: 12040 RVA: 0x00079746 File Offset: 0x00077946
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

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06002F09 RID: 12041 RVA: 0x00079754 File Offset: 0x00077954
		// (set) Token: 0x06002F0A RID: 12042 RVA: 0x0007977B File Offset: 0x0007797B
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

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06002F0B RID: 12043 RVA: 0x00079789 File Offset: 0x00077989
		// (set) Token: 0x06002F0C RID: 12044 RVA: 0x000797B4 File Offset: 0x000779B4
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

		// Token: 0x04001F1D RID: 7965
		[Nullable(2)]
		protected IWellStreamingRenderPointConfig FbInstance;

		// Token: 0x04001F1E RID: 7966
		[Nullable(2)]
		protected IWellStreamingRenderPointConfig_SetValue PocoInterface;

		// Token: 0x04001F1F RID: 7967
		private IPortalRenderConfig _TargetConfigCache;

		// Token: 0x04001F20 RID: 7968
		private bool _TargetConfigInited;

		// Token: 0x04001F21 RID: 7969
		private IRtSize _RtSizeCache;

		// Token: 0x04001F22 RID: 7970
		private bool _RtSizeInited;
	}
}
