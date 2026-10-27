using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001F71 RID: 8049
[NullableContext(1)]
[Nullable(0)]
internal sealed class IdleGazeAwarenessData
{
	// Token: 0x0600F9A9 RID: 63913 RVA: 0x003C81D0 File Offset: 0x003C63D0
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

	// Token: 0x0600F9AA RID: 63914 RVA: 0x003C823C File Offset: 0x003C643C
	public void Reset()
	{
		this.TotalPlayerGazeTime = 0f;
	}

	// Token: 0x0600F9AB RID: 63915 RVA: 0x003C824C File Offset: 0x003C644C
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

	// Token: 0x0600F9AC RID: 63916 RVA: 0x003C8396 File Offset: 0x003C6596
	[Conditional("DEBUG")]
	public void DebugDraw()
	{
	}

	// Token: 0x0600F9AD RID: 63917 RVA: 0x003C8398 File Offset: 0x003C6598
	[Conditional("DEBUG")]
	private void DrawDebugFan(Vector origin, Vector direction, float length, float angle, FLinearColor color)
	{
	}

	// Token: 0x0600F9AE RID: 63918 RVA: 0x003C839C File Offset: 0x003C659C
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

	// Token: 0x0600F9AF RID: 63919 RVA: 0x003C840D File Offset: 0x003C660D
	public bool CheckPlayerGazeTime(float time)
	{
		return this.TotalPlayerGazeTime >= time;
	}

	// Token: 0x0600F9B0 RID: 63920 RVA: 0x003C841B File Offset: 0x003C661B
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

	// Token: 0x04007462 RID: 29794
	public int EntityId;

	// Token: 0x04007463 RID: 29795
	public float AwarenessAngle;

	// Token: 0x04007464 RID: 29796
	public float AwarenessDistance;

	// Token: 0x04007465 RID: 29797
	public float AwarenessHeight;

	// Token: 0x04007466 RID: 29798
	public float PlayerGazeAngle;

	// Token: 0x04007467 RID: 29799
	public bool EnableDebugDraw;

	// Token: 0x04007468 RID: 29800
	public float TotalPlayerGazeTime;

	// Token: 0x04007469 RID: 29801
	public Vector TempVector1 = Vector.Create();

	// Token: 0x0400746A RID: 29802
	public Vector TempVector2 = Vector.Create();

	// Token: 0x0400746B RID: 29803
	public Vector TempVector3 = Vector.Create();
}
