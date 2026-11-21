using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A51 RID: 10833
	public class IActorInitialEffect
	{
		// Token: 0x0600EF38 RID: 61240 RVA: 0x00231040 File Offset: 0x0022F240
		public static IActorInitialEffect Create(IActorInitialEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorInitialEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004744 RID: 18244
		// (get) Token: 0x0600EF39 RID: 61241 RVA: 0x00231060 File Offset: 0x0022F260
		public virtual List<int> EffectIds
		{
			get
			{
				if (this._EffectIdsInited)
				{
					return this._EffectIdsCache;
				}
				this._EffectIdsInited = true;
				int effectIdsLength = this.Instance.EffectIdsLength;
				this._EffectIdsCache = new List<int>(effectIdsLength);
				for (int i = 0; i < effectIdsLength; i++)
				{
					this._EffectIdsCache.Add(this.Instance.EffectIds(i));
				}
				return this._EffectIdsCache;
			}
		}

		// Token: 0x17004745 RID: 18245
		// (get) Token: 0x0600EF3A RID: 61242 RVA: 0x002310C4 File Offset: 0x0022F2C4
		[Nullable(2)]
		public virtual List<int> EffectIdsMaleVariant
		{
			[NullableContext(2)]
			get
			{
				if (this._EffectIdsMaleVariantInited)
				{
					return this._EffectIdsMaleVariantCache;
				}
				this._EffectIdsMaleVariantInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int effectIdsMaleVariantLength = this.Instance.EffectIdsMaleVariantLength;
				this._EffectIdsMaleVariantCache = new List<int>(effectIdsMaleVariantLength);
				for (int i = 0; i < effectIdsMaleVariantLength; i++)
				{
					this._EffectIdsMaleVariantCache.Add(this.Instance.EffectIdsMaleVariant(i));
				}
				return this._EffectIdsMaleVariantCache;
			}
		}

		// Token: 0x04008369 RID: 33641
		private IActorInitialEffect Instance;

		// Token: 0x0400836A RID: 33642
		private List<int> _EffectIdsCache;

		// Token: 0x0400836B RID: 33643
		private bool _EffectIdsInited;

		// Token: 0x0400836C RID: 33644
		[Nullable(2)]
		private List<int> _EffectIdsMaleVariantCache;

		// Token: 0x0400836D RID: 33645
		private bool _EffectIdsMaleVariantInited;
	}
}
