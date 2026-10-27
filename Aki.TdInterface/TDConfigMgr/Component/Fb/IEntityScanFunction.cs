using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AA0 RID: 2720
	[NullableContext(2)]
	[Nullable(0)]
	public class IEntityScanFunction
	{
		// Token: 0x06003EA5 RID: 16037 RVA: 0x000A0527 File Offset: 0x0009E727
		[NullableContext(1)]
		public static IEntityScanFunction Create(IEntityScanFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityScanFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06003EA6 RID: 16038 RVA: 0x000A0546 File Offset: 0x0009E746
		public virtual int ScanId
		{
			get
			{
				return this.Instance.ScanId;
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06003EA7 RID: 16039 RVA: 0x000A0553 File Offset: 0x0009E753
		public virtual bool IsConcealed
		{
			get
			{
				return this.Instance.IsConcealed;
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06003EA8 RID: 16040 RVA: 0x000A0560 File Offset: 0x0009E760
		public virtual IScanTraceEffect TraceEffect
		{
			get
			{
				if (this._TraceEffectInited)
				{
					return this._TraceEffectCache;
				}
				this._TraceEffectInited = true;
				this._TraceEffectCache = IScanTraceEffect.Create(this.Instance.TraceEffect);
				return this._TraceEffectCache;
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06003EA9 RID: 16041 RVA: 0x000A0594 File Offset: 0x0009E794
		public virtual ESpecificScanType? SpecificScanType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new ESpecificScanType?((ESpecificScanType)this.Instance.SpecificScanType);
			}
		}

		// Token: 0x040022CF RID: 8911
		private IEntityScanFunction Instance;

		// Token: 0x040022D0 RID: 8912
		private IScanTraceEffect _TraceEffectCache;

		// Token: 0x040022D1 RID: 8913
		private bool _TraceEffectInited;
	}
}
