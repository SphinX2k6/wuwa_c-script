using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001433 RID: 5171
[NullableContext(1)]
[Nullable(0)]
internal sealed class IdleGazeAwarenessData
{
	// Token: 0x0600CDC8 RID: 52680 RVA: 0x003D3CBC File Offset: 0x003D1EBC
	public IdleGazeAwarenessData(int entityId, float awarenessAngle, float awarenessDistance, float awarenessHeight, float playerGazeAngle, bool enableDebugDraw)
	{
		this.EntityId = entityId;
		this.AwarenessAngle = awarenessAngle;
		this.AwarenessDistance = awarenessDistance;
		this.AwarenessHeight = awarenessHeight;
		this.PlayerGazeAngle = playerGazeAngle;
		this.EnableDebugDraw = enableDebugDraw;
		this.TotalPlayerGazeTime = 0f;
	}

	// Token: 0x0600CDC9 RID: 52681 RVA: 0x003D3D28 File Offset: 0x003D1F28
	public void Reset()
	{
		this.TotalPlayerGazeTime = 0f;
	}

	// Token: 0x0600CDCA RID: 52682 RVA: 0x003D3D38 File Offset: 0x003D1F38
	public bool GazeAwarenessCheck()
	{
		Entity entity = EntitySystem.Instance.Get(this.EntityId);
		BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
		if (baseActorComponent == null || !baseActorComponent.Valid)
		{
			return false;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
		CharacterActorComponent characterActorComponent = (worldEntity != null) ? worldEntity.GetComponent<CharacterActorComponent>() : null;
		if (characterActorComponent == null || !characterActorComponent.Valid)
		{
			return false;
		}
		this.TempVector1.DeepCopy(baseActorComponent.ActorLocationProxy);
		this.TempVector2.DeepCopy(characterActorComponent.ActorLocationProxy);
		this.TempVector1.Subtraction(this.TempVector2, this.TempVector3);
		if (this.TempVector3.SizeSquared2D() > (double)(this.AwarenessDistance * this.AwarenessDistance))
		{
			return false;
		}
		if (Math.Abs(this.TempVector3.Z) > (double)this.AwarenessHeight)
		{
			return false;
		}
		this.TempVector1.DeepCopy(baseActorComponent.ActorForwardProxy);
		if (Math.Abs(this.GetYawAngleDelta(this.TempVector1, this.TempVector3)) > this.AwarenessAngle * 0.5f)
		{
			return false;
		}
		this.TempVector2.DeepCopy(characterActorComponent.ActorForwardProxy);
		return Math.Abs(this.GetYawAngleDelta(this.TempVector2, this.TempVector3)) <= this.PlayerGazeAngle * 0.5f;
	}

	// Token: 0x0600CDCB RID: 52683 RVA: 0x003D3E82 File Offset: 0x003D2082
	[Conditional("DEBUG")]
	public void DebugDraw()
	{
	}

	// Token: 0x0600CDCC RID: 52684 RVA: 0x003D3E84 File Offset: 0x003D2084
	[Conditional("DEBUG")]
	private void DrawDebugFan(Vector origin, Vector direction, float length, float angle, FLinearColor color)
	{
	}

	// Token: 0x0600CDCD RID: 52685 RVA: 0x003D3E88 File Offset: 0x003D2088
	public float GetYawAngleDelta(Vector forward, Vector target)
	{
		double num = Math.Atan2(forward.Y, forward.X);
		double num2 = Math.Atan2(target.Y, target.X) - num;
		if (num2 > 3.141592653589793)
		{
			num2 -= 6.283185307179586;
		}
		else if (num2 < -3.141592653589793)
		{
			num2 += 6.283185307179586;
		}
		return (float)(num2 * 57.295780181884766);
	}

	// Token: 0x0600CDCE RID: 52686 RVA: 0x003D3EF9 File Offset: 0x003D20F9
	public bool CheckPlayerGazeTime(float time)
	{
		return this.TotalPlayerGazeTime >= time;
	}

	// Token: 0x0600CDCF RID: 52687 RVA: 0x003D3F07 File Offset: 0x003D2107
	public void Tick(float delta)
	{
		bool enableDebugDraw = this.EnableDebugDraw;
		if (this.GazeAwarenessCheck())
		{
			this.TotalPlayerGazeTime += delta;
			return;
		}
		this.TotalPlayerGazeTime = 0f;
	}

	// Token: 0x04007543 RID: 30019
	public int EntityId;

	// Token: 0x04007544 RID: 30020
	public float AwarenessAngle;

	// Token: 0x04007545 RID: 30021
	public float AwarenessDistance;

	// Token: 0x04007546 RID: 30022
	public float AwarenessHeight;

	// Token: 0x04007547 RID: 30023
	public float PlayerGazeAngle;

	// Token: 0x04007548 RID: 30024
	public bool EnableDebugDraw;

	// Token: 0x04007549 RID: 30025
	public float TotalPlayerGazeTime;

	// Token: 0x0400754A RID: 30026
	public Vector TempVector1 = Vector.Create();

	// Token: 0x0400754B RID: 30027
	public Vector TempVector2 = Vector.Create();

	// Token: 0x0400754C RID: 30028
	public Vector TempVector3 = Vector.Create();
}
