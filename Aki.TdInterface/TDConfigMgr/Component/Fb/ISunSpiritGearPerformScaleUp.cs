using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EB9 RID: 3769
	[NullableContext(2)]
	[Nullable(0)]
	public class ISunSpiritGearPerformScaleUp : ISunSpiritGearPerformConfig
	{
		// Token: 0x060054F8 RID: 21752 RVA: 0x000D101E File Offset: 0x000CF21E
		[NullableContext(0)]
		public static ISunSpiritGearPerformScaleUp Create(ISunSpiritGearPerformScaleUp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritGearPerformScaleUp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x060054F9 RID: 21753 RVA: 0x000D103D File Offset: 0x000CF23D
		public override ESunSpiritGearPerformType Type
		{
			get
			{
				return (ESunSpiritGearPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x060054FA RID: 21754 RVA: 0x000D104A File Offset: 0x000CF24A
		public virtual float Scale
		{
			get
			{
				return this.Instance.Scale;
			}
		}

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x060054FB RID: 21755 RVA: 0x000D1057 File Offset: 0x000CF257
		public virtual IScaleUpSpiritPerformConfig ScaleUpPerformConfig
		{
			get
			{
				if (this._ScaleUpPerformConfigInited)
				{
					return this._ScaleUpPerformConfigCache;
				}
				this._ScaleUpPerformConfigInited = true;
				this._ScaleUpPerformConfigCache = IScaleUpSpiritPerformConfig.Create(this.Instance.ScaleUpPerformConfig);
				return this._ScaleUpPerformConfigCache;
			}
		}

		// Token: 0x0400308E RID: 12430
		private ISunSpiritGearPerformScaleUp Instance;

		// Token: 0x0400308F RID: 12431
		private IScaleUpSpiritPerformConfig _ScaleUpPerformConfigCache;

		// Token: 0x04003090 RID: 12432
		private bool _ScaleUpPerformConfigInited;
	}
}
