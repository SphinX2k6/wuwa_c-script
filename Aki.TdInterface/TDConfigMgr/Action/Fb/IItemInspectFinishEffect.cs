using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002856 RID: 10326
	[NullableContext(1)]
	[Nullable(0)]
	public class IItemInspectFinishEffect
	{
		// Token: 0x0600E4E8 RID: 58600 RVA: 0x0021ADEF File Offset: 0x00218FEF
		public static IItemInspectFinishEffect Create(IItemInspectFinishEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemInspectFinishEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045FE RID: 17918
		// (get) Token: 0x0600E4E9 RID: 58601 RVA: 0x0021AE0E File Offset: 0x0021900E
		public virtual List<IInteractEffect> EffectList
		{
			get
			{
				if (this._EffectListInited)
				{
					return this._EffectListCache;
				}
				this._EffectListInited = true;
				this._EffectListCache = ActionReadHelper.ReadIItemInspectFinishEffect_EffectList(this.Instance);
				return this._EffectListCache;
			}
		}

		// Token: 0x170045FF RID: 17919
		// (get) Token: 0x0600E4EA RID: 58602 RVA: 0x0021AE40 File Offset: 0x00219040
		public virtual float? ProtectTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.ProtectTime);
			}
		}

		// Token: 0x04007EA0 RID: 32416
		private IItemInspectFinishEffect Instance;

		// Token: 0x04007EA1 RID: 32417
		private List<IInteractEffect> _EffectListCache;

		// Token: 0x04007EA2 RID: 32418
		private bool _EffectListInited;
	}
}
