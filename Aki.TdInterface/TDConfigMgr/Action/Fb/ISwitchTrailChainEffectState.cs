using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025EA RID: 9706
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwitchTrailChainEffectState : ISwitchEffectStateEffectBase
	{
		// Token: 0x0600DA1D RID: 55837 RVA: 0x002082F4 File Offset: 0x002064F4
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

		// Token: 0x1700400B RID: 16395
		// (get) Token: 0x0600DA1E RID: 55838 RVA: 0x00208313 File Offset: 0x00206513
		public override ESwitchEffectStateEffectType Type
		{
			get
			{
				return (ESwitchEffectStateEffectType)this.Instance.Type;
			}
		}

		// Token: 0x1700400C RID: 16396
		// (get) Token: 0x0600DA1F RID: 55839 RVA: 0x00208320 File Offset: 0x00206520
		public virtual int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x1700400D RID: 16397
		// (get) Token: 0x0600DA20 RID: 55840 RVA: 0x0020832D File Offset: 0x0020652D
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

		// Token: 0x0400791E RID: 31006
		private ISwitchTrailChainEffectState Instance;

		// Token: 0x0400791F RID: 31007
		private IBasePos2 _PosCache;

		// Token: 0x04007920 RID: 31008
		private bool _PosInited;
	}
}
