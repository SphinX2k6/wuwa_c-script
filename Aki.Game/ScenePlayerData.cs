using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;

// Token: 0x02002A85 RID: 10885
[NullableContext(2)]
[Nullable(0)]
public class ScenePlayerData
{
	// Token: 0x0601B977 RID: 113015 RVA: 0x008800B3 File Offset: 0x0087E2B3
	public ScenePlayerData(int playerId, int areaId)
	{
		this.PlayerId = playerId;
		this.AreaId = areaId;
		this.Location = Vector.Create();
	}

	// Token: 0x0601B978 RID: 113016 RVA: 0x008800D4 File Offset: 0x0087E2D4
	public void Clear()
	{
		this.PlayerId = 0;
		this.Location = null;
		if (this.TimerNumber != null)
		{
			TimerSystem.Instance.Remove(this.TimerNumber);
		}
	}

	// Token: 0x0601B979 RID: 113017 RVA: 0x008800FD File Offset: 0x0087E2FD
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

	// Token: 0x0601B97A RID: 113018 RVA: 0x00880131 File Offset: 0x0087E331
	public int GetPlayerId()
	{
		return this.PlayerId;
	}

	// Token: 0x0601B97B RID: 113019 RVA: 0x00880139 File Offset: 0x0087E339
	public void SetRemoteSceneLoading(bool isFinish)
	{
		this.RemoteSceneLoading = isFinish;
	}

	// Token: 0x0601B97C RID: 113020 RVA: 0x00880142 File Offset: 0x0087E342
	public bool IsRemoteSceneLoading()
	{
		return this.RemoteSceneLoading;
	}

	// Token: 0x0601B97D RID: 113021 RVA: 0x0088014C File Offset: 0x0087E34C
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

	// Token: 0x0601B97E RID: 113022 RVA: 0x00880255 File Offset: 0x0087E455
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

	// Token: 0x0601B97F RID: 113023 RVA: 0x0088028E File Offset: 0x0087E48E
	public int GetAreaId()
	{
		return this.AreaId;
	}

	// Token: 0x0601B980 RID: 113024 RVA: 0x00880296 File Offset: 0x0087E496
	public void SetAreaId(int areaId)
	{
		this.AreaId = areaId;
		this.SetLocation();
	}

	// Token: 0x0400EE67 RID: 61031
	private int PlayerId;

	// Token: 0x0400EE68 RID: 61032
	private int AreaId;

	// Token: 0x0400EE69 RID: 61033
	private Vector Location;

	// Token: 0x0400EE6A RID: 61034
	private bool RemoteSceneLoading;

	// Token: 0x0400EE6B RID: 61035
	private TimerHandle TimerNumber;

	// Token: 0x0400EE6C RID: 61036
	private const int TIME_INTERVAL = 1000;
}
