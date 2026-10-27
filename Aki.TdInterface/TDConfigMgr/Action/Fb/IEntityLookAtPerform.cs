using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A65 RID: 10853
	[NullableContext(2)]
	[Nullable(0)]
	public class IEntityLookAtPerform
	{
		// Token: 0x0600EEB5 RID: 61109 RVA: 0x0022BB62 File Offset: 0x00229D62
		[NullableContext(1)]
		public static IEntityLookAtPerform Create(IEntityLookAtPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityLookAtPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BAD RID: 19373
		// (get) Token: 0x0600EEB6 RID: 61110 RVA: 0x0022BB81 File Offset: 0x00229D81
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004BAE RID: 19374
		// (get) Token: 0x0600EEB7 RID: 61111 RVA: 0x0022BB90 File Offset: 0x00229D90
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

		// Token: 0x17004BAF RID: 19375
		// (get) Token: 0x0600EEB8 RID: 61112 RVA: 0x0022BBC8 File Offset: 0x00229DC8
		public virtual int? OverlapMontageId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.OverlapMontageId);
			}
		}

		// Token: 0x17004BB0 RID: 19376
		// (get) Token: 0x0600EEB9 RID: 61113 RVA: 0x0022BBFE File Offset: 0x00229DFE
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

		// Token: 0x0400834F RID: 33615
		private IEntityLookAtPerform Instance;

		// Token: 0x04008350 RID: 33616
		private ILookAtPerformOverlapMontageConfig _OverlapMontageConfigCache;

		// Token: 0x04008351 RID: 33617
		private bool _OverlapMontageConfigInited;
	}
}
