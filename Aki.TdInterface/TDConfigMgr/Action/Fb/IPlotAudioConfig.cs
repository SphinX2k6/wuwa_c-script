using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002890 RID: 10384
	[NullableContext(2)]
	[Nullable(0)]
	public class IPlotAudioConfig
	{
		// Token: 0x0600E75F RID: 59231 RVA: 0x002238C2 File Offset: 0x00221AC2
		[NullableContext(0)]
		public static IPlotAudioConfig Create(IPlotAudioConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlotAudioConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042ED RID: 17133
		// (get) Token: 0x0600E760 RID: 59232 RVA: 0x002238E1 File Offset: 0x00221AE1
		public virtual IPlotVoiceFadeOutOnInterrupt VoiceFadeOutOnInterrupt
		{
			get
			{
				if (this._VoiceFadeOutOnInterruptInited)
				{
					return this._VoiceFadeOutOnInterruptCache;
				}
				this._VoiceFadeOutOnInterruptInited = true;
				this._VoiceFadeOutOnInterruptCache = IPlotVoiceFadeOutOnInterrupt.Create(this.Instance.VoiceFadeOutOnInterrupt);
				return this._VoiceFadeOutOnInterruptCache;
			}
		}

		// Token: 0x04007F68 RID: 32616
		private IPlotAudioConfig Instance;

		// Token: 0x04007F69 RID: 32617
		private IPlotVoiceFadeOutOnInterrupt _VoiceFadeOutOnInterruptCache;

		// Token: 0x04007F6A RID: 32618
		private bool _VoiceFadeOutOnInterruptInited;
	}
}
