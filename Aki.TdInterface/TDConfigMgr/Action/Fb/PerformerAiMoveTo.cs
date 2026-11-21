using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C77 RID: 11383
	public class PerformerAiMoveTo : ActionParams
	{
		// Token: 0x0600FA12 RID: 64018 RVA: 0x00244B1F File Offset: 0x00242D1F
		public static PerformerAiMoveTo Create(IPerformerAiMoveTo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PerformerAiMoveTo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DD2 RID: 19922
		// (get) Token: 0x0600FA13 RID: 64019 RVA: 0x00244B3E File Offset: 0x00242D3E
		public virtual IPerformerAiMoveConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadPerformerAiMoveTo_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x17004DD3 RID: 19923
		// (get) Token: 0x0600FA14 RID: 64020 RVA: 0x00244B70 File Offset: 0x00242D70
		public virtual float? StopDistance
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.StopDistance);
			}
		}

		// Token: 0x040088A1 RID: 34977
		private IPerformerAiMoveTo Instance;

		// Token: 0x040088A2 RID: 34978
		private IPerformerAiMoveConfig _ConfigCache;

		// Token: 0x040088A3 RID: 34979
		private bool _ConfigInited;
	}
}
