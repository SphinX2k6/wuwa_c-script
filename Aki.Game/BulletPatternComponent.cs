using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x0200269B RID: 9883
public class BulletPatternComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x06018C63 RID: 101475 RVA: 0x00786516 File Offset: 0x00784716
	static BulletPatternComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletPatternComponent.CreateStaticDefaultValue), new Action(BulletPatternComponent.ResetStaticDefaultValue));
	}

	// Token: 0x06018C64 RID: 101476 RVA: 0x00786535 File Offset: 0x00784735
	[NullableContext(2)]
	public static UKuroFastCollisionAlgorithm GetKuroFastCollisionAlgorithm()
	{
		return BulletPatternComponent.Algorithm;
	}

	// Token: 0x17002752 RID: 10066
	// (get) Token: 0x06018C65 RID: 101477 RVA: 0x0078653C File Offset: 0x0078473C
	public bool HasBulletPatternSkill
	{
		get
		{
			return this.HasBulletPatternSkillInternal;
		}
	}

	// Token: 0x06018C66 RID: 101478 RVA: 0x00786544 File Offset: 0x00784744
	protected override bool OnStart()
	{
		BaseSkillComponent component = base.Entity.GetComponent<BaseSkillComponent>();
		this.HasBulletPatternSkillInternal = (((component != null) ? component.DtKuroBulletInfo : null) != null);
		if (this.HasBulletPatternSkillInternal)
		{
			this.StartBulletPatternEnvironment();
		}
		return true;
	}

	// Token: 0x06018C67 RID: 101479 RVA: 0x00786581 File Offset: 0x00784781
	protected override bool OnEnd()
	{
		if (this.HasBulletPatternSkillInternal)
		{
			this.StopBulletPatternEnvironment();
		}
		return true;
	}

	// Token: 0x06018C68 RID: 101480 RVA: 0x00786594 File Offset: 0x00784794
	private void StartBulletPatternEnvironment()
	{
		if (++BulletPatternComponent.ActiveInstanceCount == 1 && BulletModel.Instance.GetKuroBulletWorld() == null)
		{
			BulletPatternComponent.Algorithm = KuroFastCollisionController.Instance.CreateAlgorithm(UKuroFastCollisionAlgorithm_Grid.StaticClass().ToWeakClass(), true);
			BulletModel.Instance.StartKuroBulletWorld(BulletPatternComponent.Algorithm, true);
			UBulletWorld kuroBulletWorld = BulletModel.Instance.GetKuroBulletWorld();
			CharacterActorComponent component = base.Entity.GetComponent<CharacterActorComponent>();
			FVectorDouble? fvectorDouble = (component != null) ? new FVectorDouble?(component.ActorLocation) : null;
			if (fvectorDouble != null && kuroBulletWorld != null)
			{
				kuroBulletWorld.EnableFlatGroundByAbovePoint(fvectorDouble.Value);
			}
			EventSystem.Instance.Emit<bool>(EEventName.BulletPatternEnvironmentChanged, true);
		}
	}

	// Token: 0x06018C69 RID: 101481 RVA: 0x0078664C File Offset: 0x0078484C
	private void StopBulletPatternEnvironment()
	{
		if (--BulletPatternComponent.ActiveInstanceCount == 0 && BulletPatternComponent.Algorithm != null)
		{
			KuroFastCollisionController.Instance.DestroyAlgorithm(BulletPatternComponent.Algorithm);
			BulletModel.Instance.StopKuroBulletWorld();
			EventSystem.Instance.Emit<bool>(EEventName.BulletPatternEnvironmentChanged, false);
			BulletPatternComponent.Algorithm = null;
		}
	}

	// Token: 0x06018C6A RID: 101482 RVA: 0x0078669F File Offset: 0x0078489F
	public static void CreateStaticDefaultValue()
	{
		BulletPatternComponent.Algorithm = null;
		BulletPatternComponent.ActiveInstanceCount = 0;
	}

	// Token: 0x06018C6B RID: 101483 RVA: 0x007866AD File Offset: 0x007848AD
	public static void ResetStaticDefaultValue()
	{
		BulletPatternComponent.Algorithm = null;
		BulletPatternComponent.ActiveInstanceCount = 0;
	}

	// Token: 0x06018C6C RID: 101484 RVA: 0x007866BC File Offset: 0x007848BC
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BulletPatternComponent bulletPatternComponent = (BulletPatternComponent)componentTemplate;
		this.HasBulletPatternSkillInternal = bulletPatternComponent.HasBulletPatternSkillInternal;
		return true;
	}

	// Token: 0x17002753 RID: 10067
	// (get) Token: 0x06018C6D RID: 101485 RVA: 0x007866E8 File Offset: 0x007848E8
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002754 RID: 10068
	// (get) Token: 0x06018C6E RID: 101486 RVA: 0x007866EB File Offset: 0x007848EB
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400D731 RID: 55089
	[Nullable(2)]
	private static UKuroFastCollisionAlgorithm Algorithm;

	// Token: 0x0400D732 RID: 55090
	private static int ActiveInstanceCount;

	// Token: 0x0400D733 RID: 55091
	private bool HasBulletPatternSkillInternal;
}
