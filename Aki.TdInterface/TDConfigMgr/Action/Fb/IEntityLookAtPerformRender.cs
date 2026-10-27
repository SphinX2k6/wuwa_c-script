using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A66 RID: 10854
	[NullableContext(2)]
	[Nullable(0)]
	public class IEntityLookAtPerformRender
	{
		// Token: 0x0600EEBB RID: 61115 RVA: 0x0022BC3A File Offset: 0x00229E3A
		[NullableContext(1)]
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

		// Token: 0x17004BB1 RID: 19377
		// (get) Token: 0x0600EEBC RID: 61116 RVA: 0x0022BC59 File Offset: 0x00229E59
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004BB2 RID: 19378
		// (get) Token: 0x0600EEBD RID: 61117 RVA: 0x0022BC68 File Offset: 0x00229E68
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

		// Token: 0x17004BB3 RID: 19379
		// (get) Token: 0x0600EEBE RID: 61118 RVA: 0x0022BC9E File Offset: 0x00229E9E
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

		// Token: 0x17004BB4 RID: 19380
		// (get) Token: 0x0600EEBF RID: 61119 RVA: 0x0022BCD2 File Offset: 0x00229ED2
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

		// Token: 0x04008352 RID: 33618
		private IEntityLookAtPerformRender Instance;

		// Token: 0x04008353 RID: 33619
		private IMontageId _OverlapMontageIdCache;

		// Token: 0x04008354 RID: 33620
		private bool _OverlapMontageIdInited;

		// Token: 0x04008355 RID: 33621
		private ILookAtPerformOverlapMontageConfig _OverlapMontageConfigCache;

		// Token: 0x04008356 RID: 33622
		private bool _OverlapMontageConfigInited;
	}
}
