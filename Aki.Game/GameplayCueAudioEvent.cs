using System;
using UnrealEngine;

// Token: 0x02002FB2 RID: 12210
public class GameplayCueAudioEvent : GameplayCueBase
{
	// Token: 0x06019E34 RID: 106036 RVA: 0x006C4E54 File Offset: 0x006C3054
	protected override void OnCreate()
	{
		WorldEntity entity = this.EntityHandle.Entity;
		CharacterAudioComponent characterAudioComponent = (entity != null) ? entity.GetComponent<CharacterAudioComponent>() : null;
		if (characterAudioComponent == null || this.CueConfig.ParametersLength == 0)
		{
			return;
		}
		this.EventHandle = AudioSystem.Instance.PostEvent(this.CueConfig.Parameters(0), characterAudioComponent.GetAkComponent(null), null);
	}

	// Token: 0x06019E35 RID: 106037 RVA: 0x006C4EC0 File Offset: 0x006C30C0
	protected override void OnDestroy()
	{
		if (this.EventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.EventHandle, EAudioActionType.Stop, null);
		}
	}

	// Token: 0x0400C3D0 RID: 50128
	private int EventHandle;
}
