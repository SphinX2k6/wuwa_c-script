using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BAA RID: 2986
	public class IGramophoneAudioControl : IAudioControlType
	{
		// Token: 0x06004445 RID: 17477 RVA: 0x000AD231 File Offset: 0x000AB431
		public static IGramophoneAudioControl Create(IGramophoneAudioControl? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGramophoneAudioControl
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06004446 RID: 17478 RVA: 0x000AD250 File Offset: 0x000AB450
		public override EAudioControlType Type
		{
			get
			{
				return (EAudioControlType)this.Instance.Type;
			}
		}

		// Token: 0x040025C9 RID: 9673
		private IGramophoneAudioControl Instance;
	}
}
