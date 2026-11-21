using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028B2 RID: 10418
	public class RemoveEffect : ActionParams
	{
		// Token: 0x0600E814 RID: 59412 RVA: 0x00224EBB File Offset: 0x002230BB
		public static RemoveEffect Create(IRemoveEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700435E RID: 17246
		// (get) Token: 0x0600E815 RID: 59413 RVA: 0x00224EDA File Offset: 0x002230DA
		public virtual IRemoveScreenEffect RemoveEffectConfig
		{
			get
			{
				if (this._RemoveEffectConfigInited)
				{
					return this._RemoveEffectConfigCache;
				}
				this._RemoveEffectConfigInited = true;
				this._RemoveEffectConfigCache = IRemoveScreenEffect.Create(this.Instance.RemoveEffectConfig);
				return this._RemoveEffectConfigCache;
			}
		}

		// Token: 0x04007FCC RID: 32716
		private IRemoveEffect Instance;

		// Token: 0x04007FCD RID: 32717
		[Nullable(2)]
		private IRemoveScreenEffect _RemoveEffectConfigCache;

		// Token: 0x04007FCE RID: 32718
		private bool _RemoveEffectConfigInited;
	}
}
