using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AE0 RID: 2784
	public class IGramophoneAudioControl : IAudioControlType
	{
		// Token: 0x0600401B RID: 16411 RVA: 0x000A3C3D File Offset: 0x000A1E3D
		[NullableContext(1)]
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

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x0600401C RID: 16412 RVA: 0x000A3C5C File Offset: 0x000A1E5C
		public override EAudioControlType Type
		{
			get
			{
				return (EAudioControlType)this.Instance.Type;
			}
		}

		// Token: 0x040023AD RID: 9133
		private IGramophoneAudioControl Instance;
	}
}
