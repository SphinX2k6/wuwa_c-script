using System;

// Token: 0x0200250D RID: 9485
public class GameplayCueCharacterAudioEvent : GameplayCueBase
{
	// Token: 0x0601777D RID: 96125 RVA: 0x006EBDD4 File Offset: 0x006E9FD4
	protected override void OnCreate()
	{
		this.IsForbidTeammate = (this.CueConfig.ParametersLength > 0 && this.CueConfig.Parameters(0) == "1");
		if (this.IsForbidTeammate)
		{
			WorldEntity entity = this.EntityHandle.Entity;
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			int playerId = CreatureModel.Instance.GetPlayerId();
			int? num = (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPlayerId()) : null;
			this.DisableByTeammate = !(playerId == num.GetValueOrDefault() & num != null);
		}
		else
		{
			this.DisableByTeammate = false;
		}
		if (this.DisableByTeammate)
		{
			return;
		}
		WorldEntity entity2 = this.EntityHandle.Entity;
		if (entity2 != null && entity2.Active)
		{
			this.PlayAudio(GameplayCueCharacterAudioEvent.EAudioIndex.StartAtActive);
			this.HasStartAtActive = true;
			return;
		}
		this.PlayAudio(GameplayCueCharacterAudioEvent.EAudioIndex.StartAtInactive);
	}

	// Token: 0x0601777E RID: 96126 RVA: 0x006EBEAF File Offset: 0x006EA0AF
	public override void OnEnable()
	{
		if (this.DisableByTeammate)
		{
			return;
		}
		if (!this.HasStartAtActive)
		{
			this.HasStartAtActive = true;
			if (this.PlayAudio(GameplayCueCharacterAudioEvent.EAudioIndex.EnableAtFirstActive))
			{
				return;
			}
		}
		this.PlayAudio(GameplayCueCharacterAudioEvent.EAudioIndex.Enable);
	}

	// Token: 0x0601777F RID: 96127 RVA: 0x006EBEDB File Offset: 0x006EA0DB
	public override void OnDisable()
	{
		if (this.DisableByTeammate)
		{
			return;
		}
		this.PlayAudio(GameplayCueCharacterAudioEvent.EAudioIndex.Disable);
	}

	// Token: 0x06017780 RID: 96128 RVA: 0x006EBEEE File Offset: 0x006EA0EE
	protected override void OnDestroy()
	{
		if (this.DisableByTeammate)
		{
			return;
		}
		WorldEntity entity = this.EntityHandle.Entity;
		this.PlayAudio((entity != null && entity.Active) ? GameplayCueCharacterAudioEvent.EAudioIndex.StopAtActive : GameplayCueCharacterAudioEvent.EAudioIndex.StopAtInactive);
	}

	// Token: 0x06017781 RID: 96129 RVA: 0x006EBF20 File Offset: 0x006EA120
	private bool PlayAudio(GameplayCueCharacterAudioEvent.EAudioIndex index)
	{
		string text = (index < (GameplayCueCharacterAudioEvent.EAudioIndex)this.CueConfig.ParametersLength) ? this.CueConfig.Parameters((int)index) : null;
		if (string.IsNullOrEmpty(text))
		{
			return false;
		}
		WorldEntity entity = this.EntityHandle.Entity;
		CharacterAudioComponent characterAudioComponent = (entity != null) ? entity.GetComponent<CharacterAudioComponent>() : null;
		if (characterAudioComponent == null)
		{
			return false;
		}
		if (this.IsForbidTeammate)
		{
			AudioSystem.Instance.PostEvent(text);
		}
		else
		{
			AudioSystem.Instance.PostEvent(text, characterAudioComponent.GetAkComponent(null), null);
		}
		return true;
	}

	// Token: 0x0400C793 RID: 51091
	private bool HasStartAtActive;

	// Token: 0x0400C794 RID: 51092
	private bool IsForbidTeammate;

	// Token: 0x0400C795 RID: 51093
	private bool DisableByTeammate;

	// Token: 0x02008837 RID: 34871
	private enum EAudioIndex
	{
		// Token: 0x0402B91F RID: 178463
		StartAtActive = 1,
		// Token: 0x0402B920 RID: 178464
		StartAtInactive,
		// Token: 0x0402B921 RID: 178465
		StopAtActive,
		// Token: 0x0402B922 RID: 178466
		StopAtInactive,
		// Token: 0x0402B923 RID: 178467
		Enable,
		// Token: 0x0402B924 RID: 178468
		Disable,
		// Token: 0x0402B925 RID: 178469
		EnableAtFirstActive
	}
}
