using System;
using UnrealEngine;

// Token: 0x02002506 RID: 9478
public class GameplayCueAudioEvent : GameplayCueBase
{
	// Token: 0x06017745 RID: 96069 RVA: 0x006EB700 File Offset: 0x006E9900
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

	// Token: 0x06017746 RID: 96070 RVA: 0x006EB76C File Offset: 0x006E996C
	protected override void OnDestroy()
	{
		if (this.EventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.EventHandle, EAudioActionType.Stop, null);
		}
	}

	// Token: 0x0400C779 RID: 51065
	private int EventHandle;
}
