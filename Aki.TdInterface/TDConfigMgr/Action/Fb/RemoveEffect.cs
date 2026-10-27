using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025F2 RID: 9714
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoveEffect : ActionParams
	{
		// Token: 0x0600DA47 RID: 55879 RVA: 0x00208767 File Offset: 0x00206967
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

		// Token: 0x17004025 RID: 16421
		// (get) Token: 0x0600DA48 RID: 55880 RVA: 0x00208786 File Offset: 0x00206986
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

		// Token: 0x04007932 RID: 31026
		private IRemoveEffect Instance;

		// Token: 0x04007933 RID: 31027
		[Nullable(2)]
		private IRemoveScreenEffect _RemoveEffectConfigCache;

		// Token: 0x04007934 RID: 31028
		private bool _RemoveEffectConfigInited;
	}
}
