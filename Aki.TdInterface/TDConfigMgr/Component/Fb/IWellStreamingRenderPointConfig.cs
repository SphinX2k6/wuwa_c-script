using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E39 RID: 3641
	[NullableContext(1)]
	[Nullable(0)]
	public class IWellStreamingRenderPointConfig
	{
		// Token: 0x06005245 RID: 21061 RVA: 0x000CAA46 File Offset: 0x000C8C46
		public static IWellStreamingRenderPointConfig Create(IWellStreamingRenderPointConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWellStreamingRenderPointConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x06005246 RID: 21062 RVA: 0x000CAA65 File Offset: 0x000C8C65
		public virtual IPortalRenderConfig TargetConfig
		{
			get
			{
				if (this._TargetConfigInited)
				{
					return this._TargetConfigCache;
				}
				this._TargetConfigInited = true;
				this._TargetConfigCache = IPortalRenderConfig.Create(this.Instance.TargetConfig);
				return this._TargetConfigCache;
			}
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x06005247 RID: 21063 RVA: 0x000CAA99 File Offset: 0x000C8C99
		public virtual IRtSize RtSize
		{
			get
			{
				if (this._RtSizeInited)
				{
					return this._RtSizeCache;
				}
				this._RtSizeInited = true;
				this._RtSizeCache = IRtSize.Create(this.Instance.RtSize);
				return this._RtSizeCache;
			}
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x06005248 RID: 21064 RVA: 0x000CAAD0 File Offset: 0x000C8CD0
		public virtual bool? IsRenderStreamingPointEntity
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsRenderStreamingPointEntity);
			}
		}

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x06005249 RID: 21065 RVA: 0x000CAB06 File Offset: 0x000C8D06
		[Nullable(2)]
		public virtual string RtRenderRefPosActorKey
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.RtRenderRefPosActorKey;
			}
		}

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x0600524A RID: 21066 RVA: 0x000CAB13 File Offset: 0x000C8D13
		public virtual string FallbackCubeMapTexturePath
		{
			get
			{
				return this.Instance.FallbackCubeMapTexturePath;
			}
		}

		// Token: 0x04002F68 RID: 12136
		private IWellStreamingRenderPointConfig Instance;

		// Token: 0x04002F69 RID: 12137
		[Nullable(2)]
		private IPortalRenderConfig _TargetConfigCache;

		// Token: 0x04002F6A RID: 12138
		private bool _TargetConfigInited;

		// Token: 0x04002F6B RID: 12139
		[Nullable(2)]
		private IRtSize _RtSizeCache;

		// Token: 0x04002F6C RID: 12140
		private bool _RtSizeInited;
	}
}
