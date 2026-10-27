using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02005E91 RID: 24209
	[NullableContext(1)]
	[Nullable(0)]
	public class EventVolumeInfo
	{
		// Token: 0x0603D96D RID: 252269 RVA: 0x00EDE55A File Offset: 0x00EDC75A
		public EventVolumeInfo(int handle, string eventName, AActor owner)
		{
			this.Handle = handle;
			this.Event = eventName;
			this.Owner = owner;
		}

		// Token: 0x0603D96E RID: 252270 RVA: 0x00EDE58C File Offset: 0x00EDC78C
		public void OnChangeVolume(int volume, RoleVolumeInfo info)
		{
			AActor owner = this.Owner;
			if (owner == null || !owner.IsValid() || this.Volume == volume)
			{
				return;
			}
			this.Volume = volume;
			AudioSystem.Instance.SetRtpcValue("role_skill_music_volume", (float)volume, new SetRtpcValueArgs?(new SetRtpcValueArgs
			{
				Actor = this.Owner,
				TransitionDuration = new int?(2000),
				TransitionFadeCurve = new EAudioFadeCurve?(EAudioFadeCurve.SCurve)
			}));
		}

		// Token: 0x0402023E RID: 131646
		public int Volume = -1;

		// Token: 0x0402023F RID: 131647
		public int Handle;

		// Token: 0x04020240 RID: 131648
		public string Event = "";

		// Token: 0x04020241 RID: 131649
		[Nullable(2)]
		public AActor Owner;
	}
}
