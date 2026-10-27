using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C2D RID: 3117
	[NullableContext(1)]
	[Nullable(0)]
	public class ExtraRangeComponent : IComponentBase
	{
		// Token: 0x06004765 RID: 18277 RVA: 0x000B3C62 File Offset: 0x000B1E62
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

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x06004766 RID: 18278 RVA: 0x000B3C84 File Offset: 0x000B1E84
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

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x06004767 RID: 18279 RVA: 0x000B3CBC File Offset: 0x000B1EBC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x06004768 RID: 18280 RVA: 0x000B3CD4 File Offset: 0x000B1ED4
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

		// Token: 0x04002888 RID: 10376
		private IExtraRangeComponent Instance;

		// Token: 0x04002889 RID: 10377
		private List<ISunSpiritBlockExtraRange> _ExtraRangeConfigsCache;

		// Token: 0x0400288A RID: 10378
		private bool _ExtraRangeConfigsInited;
	}
}
