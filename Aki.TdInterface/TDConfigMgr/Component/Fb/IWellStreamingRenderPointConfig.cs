using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F35 RID: 3893
	public class IWellStreamingRenderPointConfig
	{
		// Token: 0x0600576C RID: 22380 RVA: 0x000D630E File Offset: 0x000D450E
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

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x0600576D RID: 22381 RVA: 0x000D632D File Offset: 0x000D452D
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

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x0600576E RID: 22382 RVA: 0x000D6361 File Offset: 0x000D4561
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

		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x0600576F RID: 22383 RVA: 0x000D6398 File Offset: 0x000D4598
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

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x06005770 RID: 22384 RVA: 0x000D63CE File Offset: 0x000D45CE
		[Nullable(2)]
		public virtual string RtRenderRefPosActorKey
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.RtRenderRefPosActorKey;
			}
		}

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x06005771 RID: 22385 RVA: 0x000D63DB File Offset: 0x000D45DB
		public virtual string FallbackCubeMapTexturePath
		{
			get
			{
				return this.Instance.FallbackCubeMapTexturePath;
			}
		}

		// Token: 0x04003230 RID: 12848
		private IWellStreamingRenderPointConfig Instance;

		// Token: 0x04003231 RID: 12849
		[Nullable(2)]
		private IPortalRenderConfig _TargetConfigCache;

		// Token: 0x04003232 RID: 12850
		private bool _TargetConfigInited;

		// Token: 0x04003233 RID: 12851
		[Nullable(2)]
		private IRtSize _RtSizeCache;

		// Token: 0x04003234 RID: 12852
		private bool _RtSizeInited;
	}
}
