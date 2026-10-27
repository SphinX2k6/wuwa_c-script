using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;

// Token: 0x02003510 RID: 13584
[NullableContext(2)]
[Nullable(0)]
public class ScenePlayerData
{
	// Token: 0x0601DC5D RID: 121949 RVA: 0x00857AE7 File Offset: 0x00855CE7
	public ScenePlayerData(int playerId, int areaId)
	{
		this.PlayerId = playerId;
		this.AreaId = areaId;
		this.Location = Vector.Create();
	}

	// Token: 0x0601DC5E RID: 121950 RVA: 0x00857B08 File Offset: 0x00855D08
	public void Clear()
	{
		this.PlayerId = 0;
		this.Location = null;
		if (this.TimerNumber != null)
		{
			TimerSystem.Instance.Remove(this.TimerNumber);
		}
	}

	// Token: 0x0601DC5F RID: 121951 RVA: 0x00857B31 File Offset: 0x00855D31
	public void SetTimerStart()
	{
		if (this.TimerNumber != null)
		{
			return;
		}
		this.TimerNumber = TimerSystem.Instance.Forever(delegate(float _)
		{
			this.SetLocation();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x0601DC60 RID: 121952 RVA: 0x00857B65 File Offset: 0x00855D65
	public int GetPlayerId()
	{
		return this.PlayerId;
	}

	// Token: 0x0601DC61 RID: 121953 RVA: 0x00857B6D File Offset: 0x00855D6D
	public void SetRemoteSceneLoading(bool isFinish)
	{
		this.RemoteSceneLoading = isFinish;
	}

	// Token: 0x0601DC62 RID: 121954 RVA: 0x00857B76 File Offset: 0x00855D76
	public bool IsRemoteSceneLoading()
	{
		return this.RemoteSceneLoading;
	}

	// Token: 0x0601DC63 RID: 121955 RVA: 0x00857B80 File Offset: 0x00855D80
	public void SetLocation()
	{
		SceneTeamPlayer teamPlayerData = SceneTeamModel.Instance.GetTeamPlayerData(this.PlayerId);
		long? num;
		if (teamPlayerData == null)
		{
			num = null;
		}
		else
		{
			SceneTeamGroup currentGroup = teamPlayerData.GetCurrentGroup();
			if (currentGroup == null)
			{
				num = null;
			}
			else
			{
				SceneTeamRole currentRole = currentGroup.GetCurrentRole();
				num = ((currentRole != null) ? new long?(currentRole.CreatureDataId) : null);
			}
		}
		long? num2 = num;
		if (num2 == null)
		{
			return;
		}
		EntityHandle entity = CreatureModel.Instance.GetEntity(num2.Value);
		Vector vector;
		if (entity == null)
		{
			vector = null;
		}
		else
		{
			WorldEntity entity2 = entity.Entity;
			if (entity2 == null)
			{
				vector = null;
			}
			else
			{
				CharacterActorComponent component = entity2.GetComponent<CharacterActorComponent>();
				vector = ((component != null) ? component.ActorLocationProxy : null);
			}
		}
		Vector vector2 = vector;
		if (vector2 == null)
		{
			EventSystem.Instance.Emit<int, bool>(EEventName.ScenePlayerMarkItemStateChange, this.PlayerId, false);
			return;
		}
		this.Location.X = vector2.X;
		this.Location.Y = vector2.Y;
		this.Location.Z = vector2.Z;
		EventSystem.Instance.Emit<int, Vector>(EEventName.ScenePlayerLocationChanged, this.PlayerId, this.Location);
	}

	// Token: 0x0601DC64 RID: 121956 RVA: 0x00857C89 File Offset: 0x00855E89
	public Vector GetLocation()
	{
		if (CreatureModel.Instance.GetPlayerId() != this.PlayerId)
		{
			return this.Location;
		}
		if (Global.BaseCharacter == null)
		{
			return null;
		}
		CharacterActorComponent characterActorComponent = Global.BaseCharacter.CharacterActorComponent;
		if (characterActorComponent == null)
		{
			return null;
		}
		return characterActorComponent.ActorLocationProxy;
	}

	// Token: 0x0601DC65 RID: 121957 RVA: 0x00857CC2 File Offset: 0x00855EC2
	public int GetAreaId()
	{
		return this.AreaId;
	}

	// Token: 0x0601DC66 RID: 121958 RVA: 0x00857CCA File Offset: 0x00855ECA
	public void SetAreaId(int areaId)
	{
		this.AreaId = areaId;
		this.SetLocation();
	}

	// Token: 0x0400E9AC RID: 59820
	private int PlayerId;

	// Token: 0x0400E9AD RID: 59821
	private int AreaId;

	// Token: 0x0400E9AE RID: 59822
	private Vector Location;

	// Token: 0x0400E9AF RID: 59823
	private bool RemoteSceneLoading;

	// Token: 0x0400E9B0 RID: 59824
	private TimerHandle TimerNumber;

	// Token: 0x0400E9B1 RID: 59825
	private const int TIME_INTERVAL = 1000;
}
