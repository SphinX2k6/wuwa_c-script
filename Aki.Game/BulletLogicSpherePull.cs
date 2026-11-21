using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02002335 RID: 9013
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicSpherePull : BulletLogicController<LogicDataSpherePull, object>
{
	// Token: 0x060162F5 RID: 90869 RVA: 0x00675000 File Offset: 0x00673200
	public BulletLogicSpherePull(LogicDataSpherePull bulletLogicBase, Entity bullet) : base(bulletLogicBase, bullet)
	{
		base.NeedTick = true;
		this.BulletInfo = (bullet as BulletEntity).GetBulletInfo();
		this.MoveTime = bulletLogicBase.MoveTime;
		this.SpherePullParams = new SpherePullTarget
		{
			Center = this.TargetCenter,
			Radius = bulletLogicBase.SphereRadius,
			GroundHeight = 0f,
			GravityDirection = this.GravityDirection,
			Curve = CurveUtils.CreateCurveByStruct(bulletLogicBase.VelocityCurve)
		};
		this.GroundHeightOffset = bulletLogicBase.GroundHeightOffset;
	}

	// Token: 0x060162F6 RID: 90870 RVA: 0x006750D8 File Offset: 0x006732D8
	public override void OnInit()
	{
		bool openMoveLog = BulletConstant.Instance.OpenMoveLog;
		BaseActorComponent attackerActorComp = this.BulletInfo.AttackerActorComp;
		if (attackerActorComp != null)
		{
			this.GravityDirection.DeepCopy(attackerActorComp.ActorGravityDirectProxy);
		}
	}

	// Token: 0x060162F7 RID: 90871 RVA: 0x00675110 File Offset: 0x00673310
	protected override void Update(float deltaTime)
	{
		bool openMoveLog = BulletConstant.Instance.OpenMoveLog;
		foreach (Entity item in this.BulletInfo.CollisionInfo.CharacterEntityMap.Keys)
		{
			this.CharacterInArea.Add(item);
		}
		this.TargetCenter.DeepCopy(this.BulletInfo.ActorComponent.ActorLocationProxy);
		this.SpherePullParams.GroundHeight = (float)GravityUtils.Instance.GetZnInGravity(this.GravityDirection, this.TargetCenter) + this.GroundHeightOffset;
		float deltaSeconds = deltaTime * 0.001f;
		foreach (Entity characterEntity in this.CharacterInArea)
		{
			this.UpdateCharacterSpherePull(characterEntity, deltaSeconds);
		}
	}

	// Token: 0x060162F8 RID: 90872 RVA: 0x00675214 File Offset: 0x00673414
	private void UpdateCharacterSpherePull(Entity characterEntity, float deltaSeconds)
	{
		CharacterMoveComponent characterMoveComponent = (characterEntity != null) ? characterEntity.GetComponent<CharacterMoveComponent>() : null;
		if (characterMoveComponent == null || !characterMoveComponent.Valid)
		{
			return;
		}
		SpherePullPoint spherePullPoint;
		if (!this.PullStates.TryGetValue(characterEntity, out spherePullPoint))
		{
			spherePullPoint = new SpherePullPoint();
			spherePullPoint.Begin(this.MoveTime, characterMoveComponent.ActorComp);
			this.PullStates.Add(characterEntity, spherePullPoint);
			if (BulletConstant.Instance.OpenMoveLog)
			{
			}
		}
		else if (BulletConstant.Instance.OpenMoveLog)
		{
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, this.TargetCenter.ToUeVector(false), 10f, 10, new FLinearColor?(ColorUtils.LinearGreen), 3f, 3f);
		}
		spherePullPoint.Advance(deltaSeconds, this.SpherePullParams);
	}

	// Token: 0x060162F9 RID: 90873 RVA: 0x006752D0 File Offset: 0x006734D0
	public override void OnBulletDestroy()
	{
		foreach (KeyValuePair<Entity, SpherePullPoint> keyValuePair in this.PullStates)
		{
			Entity entity;
			SpherePullPoint spherePullPoint;
			keyValuePair.Deconstruct(out entity, out spherePullPoint);
			spherePullPoint.OnEnd();
			bool openMoveLog = BulletConstant.Instance.OpenMoveLog;
		}
		this.PullStates.Clear();
		this.CharacterInArea.Clear();
	}

	// Token: 0x0400BB10 RID: 47888
	private const int DEBUG_SEGMENTS = 10;

	// Token: 0x0400BB11 RID: 47889
	private const float DEBUG_DURATION = 3f;

	// Token: 0x0400BB12 RID: 47890
	private const float DEBUG_THICKNESS = 3f;

	// Token: 0x0400BB13 RID: 47891
	[Nullable(2)]
	private readonly BulletInfo BulletInfo;

	// Token: 0x0400BB14 RID: 47892
	private readonly float MoveTime;

	// Token: 0x0400BB15 RID: 47893
	private readonly float GroundHeightOffset;

	// Token: 0x0400BB16 RID: 47894
	private readonly HashSet<Entity> CharacterInArea = new HashSet<Entity>();

	// Token: 0x0400BB17 RID: 47895
	private readonly Dictionary<Entity, SpherePullPoint> PullStates = new Dictionary<Entity, SpherePullPoint>();

	// Token: 0x0400BB18 RID: 47896
	private readonly Vector TargetCenter = Vector.Create();

	// Token: 0x0400BB19 RID: 47897
	private readonly Vector GravityDirection = Vector.Create(0.0, 0.0, -1.0);

	// Token: 0x0400BB1A RID: 47898
	private readonly SpherePullTarget SpherePullParams;
}
