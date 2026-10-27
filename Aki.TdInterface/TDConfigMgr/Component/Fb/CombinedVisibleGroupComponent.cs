using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BFF RID: 3071
	[NullableContext(1)]
	[Nullable(0)]
	public class CombinedVisibleGroupComponent : IComponentBase
	{
		// Token: 0x06004689 RID: 18057 RVA: 0x000B223B File Offset: 0x000B043B
		public static CombinedVisibleGroupComponent Create(ICombinedVisibleGroupComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CombinedVisibleGroupComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x0600468A RID: 18058 RVA: 0x000B225C File Offset: 0x000B045C
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x0600468B RID: 18059 RVA: 0x000B2294 File Offset: 0x000B0494
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x0600468C RID: 18060 RVA: 0x000B22AC File Offset: 0x000B04AC
		public virtual List<int> AreaIds
		{
			get
			{
				if (this._AreaIdsInited)
				{
					return this._AreaIdsCache;
				}
				this._AreaIdsInited = true;
				int areaIdsLength = this.Instance.AreaIdsLength;
				this._AreaIdsCache = new List<int>(areaIdsLength);
				for (int i = 0; i < areaIdsLength; i++)
				{
					this._AreaIdsCache.Add(this.Instance.AreaIds(i));
				}
				return this._AreaIdsCache;
			}
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x0600468D RID: 18061 RVA: 0x000B2310 File Offset: 0x000B0510
		public virtual bool IncludeSubArea
		{
			get
			{
				return this.Instance.IncludeSubArea;
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x0600468E RID: 18062 RVA: 0x000B2320 File Offset: 0x000B0520
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x04002820 RID: 10272
		private ICombinedVisibleGroupComponent Instance;

		// Token: 0x04002821 RID: 10273
		private List<int> _AreaIdsCache;

		// Token: 0x04002822 RID: 10274
		private bool _AreaIdsInited;

		// Token: 0x04002823 RID: 10275
		private List<int> _EntityIdsCache;

		// Token: 0x04002824 RID: 10276
		private bool _EntityIdsInited;
	}
}
