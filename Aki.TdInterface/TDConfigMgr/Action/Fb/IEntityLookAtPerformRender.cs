using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D5A RID: 11610
	[NullableContext(2)]
	[Nullable(0)]
	public class IEntityLookAtPerformRender
	{
		// Token: 0x0600FD71 RID: 64881 RVA: 0x00249946 File Offset: 0x00247B46
		[NullableContext(0)]
		public static IEntityLookAtPerformRender Create(IEntityLookAtPerformRender? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityLookAtPerformRender
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F6B RID: 20331
		// (get) Token: 0x0600FD72 RID: 64882 RVA: 0x00249965 File Offset: 0x00247B65
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004F6C RID: 20332
		// (get) Token: 0x0600FD73 RID: 64883 RVA: 0x00249974 File Offset: 0x00247B74
		public virtual int? FaceExpressionId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FaceExpressionId);
			}
		}

		// Token: 0x17004F6D RID: 20333
		// (get) Token: 0x0600FD74 RID: 64884 RVA: 0x002499AA File Offset: 0x00247BAA
		public virtual IMontageId OverlapMontageId
		{
			get
			{
				if (this._OverlapMontageIdInited)
				{
					return this._OverlapMontageIdCache;
				}
				this._OverlapMontageIdInited = true;
				this._OverlapMontageIdCache = IMontageId.Create(this.Instance.OverlapMontageId);
				return this._OverlapMontageIdCache;
			}
		}

		// Token: 0x17004F6E RID: 20334
		// (get) Token: 0x0600FD75 RID: 64885 RVA: 0x002499DE File Offset: 0x00247BDE
		public virtual ILookAtPerformOverlapMontageConfig OverlapMontageConfig
		{
			get
			{
				if (this._OverlapMontageConfigInited)
				{
					return this._OverlapMontageConfigCache;
				}
				this._OverlapMontageConfigInited = true;
				this._OverlapMontageConfigCache = ILookAtPerformOverlapMontageConfig.Create(this.Instance.OverlapMontageConfig);
				return this._OverlapMontageConfigCache;
			}
		}

		// Token: 0x04008A56 RID: 35414
		private IEntityLookAtPerformRender Instance;

		// Token: 0x04008A57 RID: 35415
		private IMontageId _OverlapMontageIdCache;

		// Token: 0x04008A58 RID: 35416
		private bool _OverlapMontageIdInited;

		// Token: 0x04008A59 RID: 35417
		private ILookAtPerformOverlapMontageConfig _OverlapMontageConfigCache;

		// Token: 0x04008A5A RID: 35418
		private bool _OverlapMontageConfigInited;
	}
}
