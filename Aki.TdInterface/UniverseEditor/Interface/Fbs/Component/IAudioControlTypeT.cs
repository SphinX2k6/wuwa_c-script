using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053FB RID: 21499
	public class IAudioControlTypeT
	{
		// Token: 0x17009845 RID: 38981
		// (get) Token: 0x060219F5 RID: 137717 RVA: 0x004A2C4E File Offset: 0x004A0E4E
		// (set) Token: 0x060219F6 RID: 137718 RVA: 0x004A2C56 File Offset: 0x004A0E56
		public EAudioControlType Type { get; set; }

		// Token: 0x060219F7 RID: 137719 RVA: 0x004A2C5F File Offset: 0x004A0E5F
		public IAudioControlTypeT()
		{
			this.Type = EAudioControlType.Gramophone;
		}
	}
}
