using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B94 RID: 11156
	public class AdjustPlayerCamera : ActionParams
	{
		// Token: 0x0600F5F9 RID: 62969 RVA: 0x0023D85B File Offset: 0x0023BA5B
		public static AdjustPlayerCamera Create(IAdjustPlayerCamera? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AdjustPlayerCamera
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B7F RID: 19327
		// (get) Token: 0x0600F5FA RID: 62970 RVA: 0x0023D87A File Offset: 0x0023BA7A
		public virtual IAdjustPlayerCameraType Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = ActionReadHelper.ReadAdjustPlayerCamera_Option(this.Instance);
				return this._OptionCache;
			}
		}

		// Token: 0x040086E0 RID: 34528
		private IAdjustPlayerCamera Instance;

		// Token: 0x040086E1 RID: 34529
		private IAdjustPlayerCameraType _OptionCache;

		// Token: 0x040086E2 RID: 34530
		private bool _OptionInited;
	}
}
