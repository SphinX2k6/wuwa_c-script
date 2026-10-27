using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002DAE RID: 11694
[NullableContext(1)]
[Nullable(0)]
public class BulletDataMain
{
	// Token: 0x06018963 RID: 100707 RVA: 0x0064855C File Offset: 0x0064675C
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

	// Token: 0x06018964 RID: 100708 RVA: 0x006486C0 File Offset: 0x006468C0
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

	// Token: 0x06018965 RID: 100709 RVA: 0x006489BE File Offset: 0x00646BBE
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

	// Token: 0x06018966 RID: 100710 RVA: 0x006489E0 File Offset: 0x00646BE0
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

	// Token: 0x06018967 RID: 100711 RVA: 0x00648AF8 File Offset: 0x00646CF8
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

	// Token: 0x0400B682 RID: 46722
	private const float TRACE_SIZE_MAX = 600f;

	// Token: 0x0400B683 RID: 46723
	public SReBulletDataMain Data;

	// Token: 0x0400B684 RID: 46724
	public string BulletRowName;

	// Token: 0x0400B685 RID: 46725
	public FName BulletFName;

	// Token: 0x0400B686 RID: 46726
	public string BulletName;

	// Token: 0x0400B687 RID: 46727
	public readonly bool SimpleBullet;

	// Token: 0x0400B688 RID: 46728
	public readonly BulletDataBase Base;

	// Token: 0x0400B689 RID: 46729
	public readonly BulletDataLogic Logic;

	// Token: 0x0400B68A RID: 46730
	public readonly BulletDataAimed Aimed;

	// Token: 0x0400B68B RID: 46731
	public readonly BulletDataMove Move;

	// Token: 0x0400B68C RID: 46732
	public readonly BulletDataRender Render;

	// Token: 0x0400B68D RID: 46733
	public readonly BulletDataTimeScale TimeScale;

	// Token: 0x0400B68E RID: 46734
	public readonly BulletDataExecution Execution;

	// Token: 0x0400B68F RID: 46735
	public readonly BulletDataScale Scale;

	// Token: 0x0400B690 RID: 46736
	public readonly BulletDataSummon Summon;

	// Token: 0x0400B691 RID: 46737
	public readonly BulletDataChild[] Children;

	// Token: 0x0400B692 RID: 46738
	public readonly BulletDataObstacle Obstacle;

	// Token: 0x0400B693 RID: 46739
	public readonly BulletDataInteract Interact;

	// Token: 0x0400B694 RID: 46740
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public readonly List<BulletActionOverride> SpecialActionOverrides;

	// Token: 0x0400B695 RID: 46741
	private static readonly string StrNone = "None";
}
