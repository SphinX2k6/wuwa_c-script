using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02004E76 RID: 20086
	[NullableContext(1)]
	[Nullable(0)]
	public class EventVolumeInfo
	{
		// Token: 0x060328FD RID: 207101 RVA: 0x00E2FAEA File Offset: 0x00E2DCEA
		public EventVolumeInfo(int handle, string eventName, AActor owner)
		{
			this.Handle = handle;
			this.Event = eventName;
			this.Owner = owner;
		}

		// Token: 0x060328FE RID: 207102 RVA: 0x00E2FB1C File Offset: 0x00E2DD1C
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

		// Token: 0x0401AD05 RID: 109829
		public int Volume = -1;

		// Token: 0x0401AD06 RID: 109830
		public int Handle;

		// Token: 0x0401AD07 RID: 109831
		public string Event = "";

		// Token: 0x0401AD08 RID: 109832
		[Nullable(2)]
		public AActor Owner;
	}
}
