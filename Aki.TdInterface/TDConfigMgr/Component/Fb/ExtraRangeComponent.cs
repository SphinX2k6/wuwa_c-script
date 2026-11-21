using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D00 RID: 3328
	public class ExtraRangeComponent : IComponentBase
	{
		// Token: 0x06004BD5 RID: 19413 RVA: 0x000BE012 File Offset: 0x000BC212
		public static ExtraRangeComponent Create(IExtraRangeComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExtraRangeComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x06004BD6 RID: 19414 RVA: 0x000BE034 File Offset: 0x000BC234
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

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x06004BD7 RID: 19415 RVA: 0x000BE06C File Offset: 0x000BC26C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x06004BD8 RID: 19416 RVA: 0x000BE084 File Offset: 0x000BC284
		public virtual List<ISunSpiritBlockExtraRange> ExtraRangeConfigs
		{
			get
			{
				if (this._ExtraRangeConfigsInited)
				{
					return this._ExtraRangeConfigsCache;
				}
				this._ExtraRangeConfigsInited = true;
				int extraRangeConfigsLength = this.Instance.ExtraRangeConfigsLength;
				this._ExtraRangeConfigsCache = new List<ISunSpiritBlockExtraRange>(extraRangeConfigsLength);
				for (int i = 0; i < extraRangeConfigsLength; i++)
				{
					this._ExtraRangeConfigsCache.Add(ISunSpiritBlockExtraRange.Create(this.Instance.ExtraRangeConfigs(i)));
				}
				return this._ExtraRangeConfigsCache;
			}
		}

		// Token: 0x04002ADD RID: 10973
		private IExtraRangeComponent Instance;

		// Token: 0x04002ADE RID: 10974
		private List<ISunSpiritBlockExtraRange> _ExtraRangeConfigsCache;

		// Token: 0x04002ADF RID: 10975
		private bool _ExtraRangeConfigsInited;
	}
}
