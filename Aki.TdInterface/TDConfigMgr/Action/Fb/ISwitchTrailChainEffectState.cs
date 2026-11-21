using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028A9 RID: 10409
	public class ISwitchTrailChainEffectState : ISwitchEffectStateEffectBase
	{
		// Token: 0x0600E7E6 RID: 59366 RVA: 0x002249E0 File Offset: 0x00222BE0
		public static ISwitchTrailChainEffectState Create(ISwitchTrailChainEffectState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchTrailChainEffectState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004342 RID: 17218
		// (get) Token: 0x0600E7E7 RID: 59367 RVA: 0x002249FF File Offset: 0x00222BFF
		public override ESwitchEffectStateEffectType Type
		{
			get
			{
				return (ESwitchEffectStateEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17004343 RID: 17219
		// (get) Token: 0x0600E7E8 RID: 59368 RVA: 0x00224A0C File Offset: 0x00222C0C
		public virtual int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x17004344 RID: 17220
		// (get) Token: 0x0600E7E9 RID: 59369 RVA: 0x00224A19 File Offset: 0x00222C19
		public virtual IBasePos2 Pos
		{
			get
			{
				if (this._PosInited)
				{
					return this._PosCache;
				}
				this._PosInited = true;
				this._PosCache = ActionReadHelper.ReadISwitchTrailChainEffectState_Pos(this.Instance);
				return this._PosCache;
			}
		}

		// Token: 0x04007FB5 RID: 32693
		private ISwitchTrailChainEffectState Instance;

		// Token: 0x04007FB6 RID: 32694
		private IBasePos2 _PosCache;

		// Token: 0x04007FB7 RID: 32695
		private bool _PosInited;
	}
}
