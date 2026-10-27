using System;

// Token: 0x02002FB9 RID: 12217
public class GameplayCueCharacterAudioEvent : GameplayCueBase
{
	// Token: 0x06019E6B RID: 106091 RVA: 0x006C5510 File Offset: 0x006C3710
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

	// Token: 0x06019E6C RID: 106092 RVA: 0x006C55EB File Offset: 0x006C37EB
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

	// Token: 0x06019E6D RID: 106093 RVA: 0x006C5617 File Offset: 0x006C3817
	public override void OnDisable()
	{
		if (this.DisableByTeammate)
		{
			return;
		}
		this.PlayAudio(GameplayCueCharacterAudioEvent.EAudioIndex.Disable);
	}

	// Token: 0x06019E6E RID: 106094 RVA: 0x006C562A File Offset: 0x006C382A
	protected override void OnDestroy()
	{
		if (this.DisableByTeammate)
		{
			return;
		}
		WorldEntity entity = this.EntityHandle.Entity;
		this.PlayAudio((entity != null && entity.Active) ? GameplayCueCharacterAudioEvent.EAudioIndex.StopAtActive : GameplayCueCharacterAudioEvent.EAudioIndex.StopAtInactive);
	}

	// Token: 0x06019E6F RID: 106095 RVA: 0x006C565C File Offset: 0x006C385C
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

	// Token: 0x0400C3EA RID: 50154
	private bool HasStartAtActive;

	// Token: 0x0400C3EB RID: 50155
	private bool IsForbidTeammate;

	// Token: 0x0400C3EC RID: 50156
	private bool DisableByTeammate;

	// Token: 0x02009616 RID: 38422
	private enum EAudioIndex
	{
		// Token: 0x04030292 RID: 197266
		StartAtActive = 1,
		// Token: 0x04030293 RID: 197267
		StartAtInactive,
		// Token: 0x04030294 RID: 197268
		StopAtActive,
		// Token: 0x04030295 RID: 197269
		StopAtInactive,
		// Token: 0x04030296 RID: 197270
		Enable,
		// Token: 0x04030297 RID: 197271
		Disable,
		// Token: 0x04030298 RID: 197272
		EnableAtFirstActive
	}
}
