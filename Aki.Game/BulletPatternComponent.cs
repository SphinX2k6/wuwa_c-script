using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x0200313B RID: 12603
public class BulletPatternComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x0601B1D5 RID: 111061 RVA: 0x0075FE2D File Offset: 0x0075E02D
	static BulletPatternComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletPatternComponent.CreateStaticDefaultValue), new Action(BulletPatternComponent.ResetStaticDefaultValue));
	}

	// Token: 0x0601B1D6 RID: 111062 RVA: 0x0075FE4C File Offset: 0x0075E04C
	[NullableContext(2)]
	public static UKuroFastCollisionAlgorithm GetKuroFastCollisionAlgorithm()
	{
		return BulletPatternComponent.Algorithm;
	}

	// Token: 0x17002590 RID: 9616
	// (get) Token: 0x0601B1D7 RID: 111063 RVA: 0x0075FE53 File Offset: 0x0075E053
	public bool HasBulletPatternSkill
	{
		get
		{
			return this.HasBulletPatternSkillInternal;
		}
	}

	// Token: 0x0601B1D8 RID: 111064 RVA: 0x0075FE5C File Offset: 0x0075E05C
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

	// Token: 0x0601B1D9 RID: 111065 RVA: 0x0075FE99 File Offset: 0x0075E099
	protected override bool OnEnd()
	{
		if (this.HasBulletPatternSkillInternal)
		{
			this.StopBulletPatternEnvironment();
		}
		return true;
	}

	// Token: 0x0601B1DA RID: 111066 RVA: 0x0075FEAC File Offset: 0x0075E0AC
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

	// Token: 0x0601B1DB RID: 111067 RVA: 0x0075FF64 File Offset: 0x0075E164
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

	// Token: 0x0601B1DC RID: 111068 RVA: 0x0075FFB7 File Offset: 0x0075E1B7
	public static void CreateStaticDefaultValue()
	{
		BulletPatternComponent.Algorithm = null;
		BulletPatternComponent.ActiveInstanceCount = 0;
	}

	// Token: 0x0601B1DD RID: 111069 RVA: 0x0075FFC5 File Offset: 0x0075E1C5
	public static void ResetStaticDefaultValue()
	{
		BulletPatternComponent.Algorithm = null;
		BulletPatternComponent.ActiveInstanceCount = 0;
	}

	// Token: 0x0601B1DE RID: 111070 RVA: 0x0075FFD4 File Offset: 0x0075E1D4
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BulletPatternComponent bulletPatternComponent = (BulletPatternComponent)componentTemplate;
		if (base.CanResetComponentProperty("HasBulletPatternSkillInternal"))
		{
			this.HasBulletPatternSkillInternal = bulletPatternComponent.HasBulletPatternSkillInternal;
		}
		return true;
	}

	// Token: 0x0400D2F9 RID: 54009
	[Nullable(2)]
	private static UKuroFastCollisionAlgorithm Algorithm;

	// Token: 0x0400D2FA RID: 54010
	private static int ActiveInstanceCount;

	// Token: 0x0400D2FB RID: 54011
	private bool HasBulletPatternSkillInternal;
}
