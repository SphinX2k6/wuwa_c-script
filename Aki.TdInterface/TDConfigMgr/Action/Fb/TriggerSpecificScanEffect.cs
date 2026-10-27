using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A3D RID: 10813
	[NullableContext(1)]
	[Nullable(0)]
	public class TriggerSpecificScanEffect : ActionParams
	{
		// Token: 0x0600EE1E RID: 60958 RVA: 0x0022AED7 File Offset: 0x002290D7
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

		// Token: 0x17004B66 RID: 19302
		// (get) Token: 0x0600EE1F RID: 60959 RVA: 0x0022AEF6 File Offset: 0x002290F6
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

		// Token: 0x04008309 RID: 33545
		private ITriggerSpecificScanEffect Instance;

		// Token: 0x0400830A RID: 33546
		private ISpecificScanEffect _ScanEffectCache;

		// Token: 0x0400830B RID: 33547
		private bool _ScanEffectInited;
	}
}
