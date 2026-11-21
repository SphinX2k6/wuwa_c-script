using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B6A RID: 2922
	[NullableContext(2)]
	[Nullable(0)]
	public class IEntityScanFunction
	{
		// Token: 0x060042CF RID: 17103 RVA: 0x000A9B1B File Offset: 0x000A7D1B
		[NullableContext(0)]
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

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x060042D0 RID: 17104 RVA: 0x000A9B3A File Offset: 0x000A7D3A
		public virtual int ScanId
		{
			get
			{
				return this.Instance.ScanId;
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x060042D1 RID: 17105 RVA: 0x000A9B47 File Offset: 0x000A7D47
		public virtual bool IsConcealed
		{
			get
			{
				return this.Instance.IsConcealed;
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x060042D2 RID: 17106 RVA: 0x000A9B54 File Offset: 0x000A7D54
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

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x060042D3 RID: 17107 RVA: 0x000A9B88 File Offset: 0x000A7D88
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

		// Token: 0x040024EB RID: 9451
		private IEntityScanFunction Instance;

		// Token: 0x040024EC RID: 9452
		private IScanTraceEffect _TraceEffectCache;

		// Token: 0x040024ED RID: 9453
		private bool _TraceEffectInited;
	}
}
