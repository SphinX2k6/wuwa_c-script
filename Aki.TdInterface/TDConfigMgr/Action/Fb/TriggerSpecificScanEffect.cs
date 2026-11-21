using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D2A RID: 11562
	public class TriggerSpecificScanEffect : ActionParams
	{
		// Token: 0x0600FCB6 RID: 64694 RVA: 0x0024888B File Offset: 0x00246A8B
		public static TriggerSpecificScanEffect Create(ITriggerSpecificScanEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TriggerSpecificScanEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F10 RID: 20240
		// (get) Token: 0x0600FCB7 RID: 64695 RVA: 0x002488AA File Offset: 0x00246AAA
		public virtual ISpecificScanEffect ScanEffect
		{
			get
			{
				if (this._ScanEffectInited)
				{
					return this._ScanEffectCache;
				}
				this._ScanEffectInited = true;
				this._ScanEffectCache = ActionReadHelper.ReadTriggerSpecificScanEffect_ScanEffect(this.Instance);
				return this._ScanEffectCache;
			}
		}

		// Token: 0x040089FC RID: 35324
		private ITriggerSpecificScanEffect Instance;

		// Token: 0x040089FD RID: 35325
		private ISpecificScanEffect _ScanEffectCache;

		// Token: 0x040089FE RID: 35326
		private bool _ScanEffectInited;
	}
}
