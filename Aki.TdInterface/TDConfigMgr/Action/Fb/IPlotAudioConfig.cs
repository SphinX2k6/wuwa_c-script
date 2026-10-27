using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025D1 RID: 9681
	[NullableContext(2)]
	[Nullable(0)]
	public class IPlotAudioConfig
	{
		// Token: 0x0600D997 RID: 55703 RVA: 0x0020720E File Offset: 0x0020540E
		[NullableContext(1)]
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

		// Token: 0x17003FB7 RID: 16311
		// (get) Token: 0x0600D998 RID: 55704 RVA: 0x0020722D File Offset: 0x0020542D
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

		// Token: 0x040078D1 RID: 30929
		private IPlotAudioConfig Instance;

		// Token: 0x040078D2 RID: 30930
		private IPlotVoiceFadeOutOnInterrupt _VoiceFadeOutOnInterruptCache;

		// Token: 0x040078D3 RID: 30931
		private bool _VoiceFadeOutOnInterruptInited;
	}
}
