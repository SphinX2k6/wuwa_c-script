using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200277F RID: 10111
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorInitialEffect
	{
		// Token: 0x0600E11A RID: 57626 RVA: 0x002142AC File Offset: 0x002124AC
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

		// Token: 0x170043DE RID: 17374
		// (get) Token: 0x0600E11B RID: 57627 RVA: 0x002142CC File Offset: 0x002124CC
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

		// Token: 0x170043DF RID: 17375
		// (get) Token: 0x0600E11C RID: 57628 RVA: 0x00214330 File Offset: 0x00212530
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

		// Token: 0x04007CB3 RID: 31923
		private IActorInitialEffect Instance;

		// Token: 0x04007CB4 RID: 31924
		private List<int> _EffectIdsCache;

		// Token: 0x04007CB5 RID: 31925
		private bool _EffectIdsInited;

		// Token: 0x04007CB6 RID: 31926
		[Nullable(2)]
		private List<int> _EffectIdsMaleVariantCache;

		// Token: 0x04007CB7 RID: 31927
		private bool _EffectIdsMaleVariantInited;
	}
}
