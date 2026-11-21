using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B29 RID: 11049
	public class IItemInspectFinishEffect
	{
		// Token: 0x0600F30D RID: 62221 RVA: 0x00237C53 File Offset: 0x00235E53
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

		// Token: 0x17004969 RID: 18793
		// (get) Token: 0x0600F30E RID: 62222 RVA: 0x00237C72 File Offset: 0x00235E72
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

		// Token: 0x1700496A RID: 18794
		// (get) Token: 0x0600F30F RID: 62223 RVA: 0x00237CA4 File Offset: 0x00235EA4
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

		// Token: 0x0400855D RID: 34141
		private IItemInspectFinishEffect Instance;

		// Token: 0x0400855E RID: 34142
		private List<IInteractEffect> _EffectListCache;

		// Token: 0x0400855F RID: 34143
		private bool _EffectListInited;
	}
}
