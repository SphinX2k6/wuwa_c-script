using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002308 RID: 8968
[NullableContext(1)]
[Nullable(0)]
public class BulletDataMain
{
	// Token: 0x0601620B RID: 90635 RVA: 0x0066E344 File Offset: 0x0066C544
	public BulletDataMain(SReBulletDataMain data, string bulletRowName, [Nullable(new byte[]
	{
		2,
		1
	})] List<BulletActionOverride> specialActionOverrides = null)
	{
		this.Data = data;
		this.BulletRowName = bulletRowName;
		this.BulletFName = data.子弹名称;
		this.BulletName = data.子弹名称.ToString();
		this.Base = new BulletDataBase(data.基础设置);
		this.Logic = new BulletDataLogic(data.逻辑设置.预设);
		this.Aimed = new BulletDataAimed(data.瞄准设置);
		this.Move = new BulletDataMove(data.移动设置);
		this.Render = new BulletDataRender(data.表现效果设置);
		this.TimeScale = new BulletDataTimeScale(data.时间膨胀);
		this.Execution = new BulletDataExecution(data.执行逻辑);
		this.Scale = new BulletDataScale(data.缩放设置);
		this.Summon = new BulletDataSummon(data.召唤实体);
		this.Children = new BulletDataChild[data.子子弹设置.Num()];
		for (int i = 0; i < data.子子弹设置.Num(); i++)
		{
			SReBulletDataChildren data2 = data.子子弹设置.Get(i);
			this.Children[i] = new BulletDataChild(data2);
		}
		this.Obstacle = new BulletDataObstacle(data.障碍检测);
		this.Interact = new BulletDataInteract(data.环境交互);
		this.SpecialActionOverrides = specialActionOverrides;
		this.SimpleBullet = BulletDataMain.CheckSimpleBullet(this);
	}

	// Token: 0x0601620C RID: 90636 RVA: 0x0066E4A8 File Offset: 0x0066C6A8
	private static bool CheckSimpleBullet(BulletDataMain data)
	{
		BulletDataBase @base = data.Base;
		if (@base.SpecialParams.Count > 0 || @base.BornPositionStandard != EPositionStandard.发射者位置 || @base.BlackboardKey != BulletDataMain.StrNone || !@base.CenterOffset.IsZero() || !@base.BornPositionRandom.IsZero() || !@base.Rotator.IsNearlyZero() || !@base.BornDistLimit.IsZero() || @base.CollisionActiveDuration > 0f || @base.CollisionActiveDelay > 0f || @base.HitType != 2 || @base.DaHitTypePreset != BulletDataMain.StrNone || @base.HitConditionTagId != 0 || @base.BanHitTagId != 0 || @base.VictimCount != -1 || @base.HitCountPerVictim != -1 || @base.HitCountMax != -1 || @base.Interval > 0f || @base.ShareCounter || @base.HitEffectWeakness == FNameUtil.EMPTY || !@base.AttackDirection.IsNearlyZero() || @base.DestroyOnSkillEnd || @base.BornRequireTagIds != null || @base.BornForbidTagIds != null || @base.ContinuesCollision || @base.StickGround || @base.IgnoreGradient || @base.SyncType != EBulletSyncTypeTs.Local || @base.TagId != 0)
		{
			return false;
		}
		if (data.Aimed.AimedCtrlDir)
		{
			return false;
		}
		if (data.Move.Speed > 0f || data.Move.FollowType != EBulletFollowType.固定位置)
		{
			return false;
		}
		BulletDataExecution execution = data.Execution;
		FGameplayTag fgameplayTag = execution.SendGameplayEventTagToAttackerOnStart;
		if (fgameplayTag.TagName.ToString().Length == 0)
		{
			fgameplayTag = execution.SendGameplayEventTagToAttacker;
			if (fgameplayTag.TagName.ToString().Length == 0)
			{
				fgameplayTag = execution.SendGameplayEventTagToVictim;
				if (fgameplayTag.TagName.ToString().Length == 0)
				{
					fgameplayTag = execution.SendGameplayEventTagToAttackerOnEnd;
					if (fgameplayTag.TagName.ToString().Length == 0 && execution.SendGeIdToAttacker.Length == 0 && execution.SendGeIdToVictim.Length == 0 && execution.EnergyRecoverGeIds.Length == 0 && execution.SendGeIdToRoleInGame.Length == 0 && execution.GeIdApplyToVictim.Length == 0 && (execution.GbDataList == null || execution.GbDataList.Count <= 0))
					{
						BulletDataScale scale = data.Scale;
						return scale.SizeScale == Vector.OneVectorProxy && scale.ScaleCurve == null && !scale.ShapeSwitch && data.Summon.EntityId <= 0 && data.Children.Length == 0 && data.Obstacle.Center.IsZero() && data.Obstacle.Radius <= 0f && !(data.Interact.SceneInteract != BulletDataMain.StrNone);
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0601620D RID: 90637 RVA: 0x0066E7A6 File Offset: 0x0066C9A6
	public bool CheckValid()
	{
		BulletDataLogic logic = this.Logic;
		if (((logic != null) ? logic.Data : null) == null)
		{
			return false;
		}
		this.CheckIsOverSizeForTrace();
		return true;
	}

	// Token: 0x0601620E RID: 90638 RVA: 0x0066E7C8 File Offset: 0x0066C9C8
	private bool CheckIsOverSizeForTrace()
	{
		switch (this.Base.Shape)
		{
		case global::EBulletShape.Cube:
			this.Base.IsOversizeForTrace = (this.Base.Size.GetMax() > 600.0);
			goto IL_FE;
		case global::EBulletShape.Sphere:
			this.Base.IsOversizeForTrace = (this.Base.Size.X > 600.0);
			goto IL_FE;
		case global::EBulletShape.Sector:
		case global::EBulletShape.Cylinder:
			this.Base.IsOversizeForTrace = (this.Base.Size.X > 600.0 || this.Base.Size.Z > 600.0);
			goto IL_FE;
		case global::EBulletShape.Ray:
		case global::EBulletShape.BigCube:
		case global::EBulletShape.BigSphere:
		case global::EBulletShape.BigSector:
		case global::EBulletShape.BigCylinder:
			goto IL_FE;
		}
		this.Base.IsOversizeForTrace = (this.Base.Size.GetMax() > 600.0);
		IL_FE:
		return this.Base.IsOversizeForTrace;
	}

	// Token: 0x0601620F RID: 90639 RVA: 0x0066E8E0 File Offset: 0x0066CAE0
	public void Preload()
	{
		this.Base.Preload();
		this.Logic.Preload();
		this.Move.Preload();
		this.Execution.Preload();
		this.Scale.Preload();
		this.Obstacle.Preload();
		this.Render.Preload();
	}

	// Token: 0x0400B9FC RID: 47612
	private const float TRACE_SIZE_MAX = 600f;

	// Token: 0x0400B9FD RID: 47613
	public SReBulletDataMain Data;

	// Token: 0x0400B9FE RID: 47614
	public string BulletRowName;

	// Token: 0x0400B9FF RID: 47615
	public FName BulletFName;

	// Token: 0x0400BA00 RID: 47616
	public string BulletName;

	// Token: 0x0400BA01 RID: 47617
	public readonly bool SimpleBullet;

	// Token: 0x0400BA02 RID: 47618
	public readonly BulletDataBase Base;

	// Token: 0x0400BA03 RID: 47619
	public readonly BulletDataLogic Logic;

	// Token: 0x0400BA04 RID: 47620
	public readonly BulletDataAimed Aimed;

	// Token: 0x0400BA05 RID: 47621
	public readonly BulletDataMove Move;

	// Token: 0x0400BA06 RID: 47622
	public readonly BulletDataRender Render;

	// Token: 0x0400BA07 RID: 47623
	public readonly BulletDataTimeScale TimeScale;

	// Token: 0x0400BA08 RID: 47624
	public readonly BulletDataExecution Execution;

	// Token: 0x0400BA09 RID: 47625
	public readonly BulletDataScale Scale;

	// Token: 0x0400BA0A RID: 47626
	public readonly BulletDataSummon Summon;

	// Token: 0x0400BA0B RID: 47627
	public readonly BulletDataChild[] Children;

	// Token: 0x0400BA0C RID: 47628
	public readonly BulletDataObstacle Obstacle;

	// Token: 0x0400BA0D RID: 47629
	public readonly BulletDataInteract Interact;

	// Token: 0x0400BA0E RID: 47630
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public readonly List<BulletActionOverride> SpecialActionOverrides;

	// Token: 0x0400BA0F RID: 47631
	private static readonly string StrNone = "None";
}
