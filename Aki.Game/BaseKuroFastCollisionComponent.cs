using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200268D RID: 9869
[NullableContext(1)]
[Nullable(0)]
public class BaseKuroFastCollisionComponent : EntityComponent
{
	// Token: 0x06018B6F RID: 101231 RVA: 0x00780CF0 File Offset: 0x0077EEF0
	protected override bool OnStart()
	{
		EventSystem.Instance.Add(EEventName.BulletPatternEnvironmentChanged, new Action<bool>(this.OnEnvironmentChanged));
		if (BulletPatternComponent.GetKuroFastCollisionAlgorithm() != null)
		{
			this.StartKuroFastCollision();
		}
		return true;
	}

	// Token: 0x06018B70 RID: 101232 RVA: 0x00780D1C File Offset: 0x0077EF1C
	protected override bool OnEnd()
	{
		this.StopKuroFastCollision();
		EventSystem.Instance.Remove(EEventName.BulletPatternEnvironmentChanged, new Action<bool>(this.OnEnvironmentChanged));
		return true;
	}

	// Token: 0x06018B71 RID: 101233 RVA: 0x00780D41 File Offset: 0x0077EF41
	protected virtual void OnStartKuroFastCollision()
	{
	}

	// Token: 0x06018B72 RID: 101234 RVA: 0x00780D43 File Offset: 0x0077EF43
	protected virtual void OnStopKuroFastCollision()
	{
	}

	// Token: 0x06018B73 RID: 101235 RVA: 0x00780D45 File Offset: 0x0077EF45
	private void StartKuroFastCollision()
	{
		this.RegisterAllShapes();
		this.OnStartKuroFastCollision();
	}

	// Token: 0x06018B74 RID: 101236 RVA: 0x00780D53 File Offset: 0x0077EF53
	private void StopKuroFastCollision()
	{
		this.UnregisterAllShapes();
		this.OnStopKuroFastCollision();
	}

	// Token: 0x06018B75 RID: 101237 RVA: 0x00780D64 File Offset: 0x0077EF64
	private void RegisterAllShapes()
	{
		this.UnregisterAllShapes();
		UKuroFastCollisionAlgorithm kuroFastCollisionAlgorithm = BulletPatternComponent.GetKuroFastCollisionAlgorithm();
		if (kuroFastCollisionAlgorithm == null)
		{
			return;
		}
		BaseCharacterComponent component = base.Entity.GetComponent<BaseCharacterComponent>();
		TsBaseCharacter tsBaseCharacter = (component != null) ? component.Actor : null;
		TArray<UActorComponent> tarray = (tsBaseCharacter != null) ? tsBaseCharacter.K2_GetComponentsByClass(UShapeComponent.StaticClass()) : null;
		int num = (tarray != null) ? tarray.Num() : 0;
		for (int i = 0; i < num; i++)
		{
			UShapeComponent ushapeComponent = tarray.Get(i) as UShapeComponent;
			if (ushapeComponent != null)
			{
				kuroFastCollisionAlgorithm.Add(ushapeComponent);
				this.RegisteredShapes.Add(ushapeComponent);
			}
		}
	}

	// Token: 0x06018B76 RID: 101238 RVA: 0x00780DF0 File Offset: 0x0077EFF0
	private void UnregisterAllShapes()
	{
		UKuroFastCollisionAlgorithm kuroFastCollisionAlgorithm = BulletPatternComponent.GetKuroFastCollisionAlgorithm();
		if (kuroFastCollisionAlgorithm == null)
		{
			this.RegisteredShapes.Clear();
			return;
		}
		foreach (UShapeComponent agent in this.RegisteredShapes)
		{
			kuroFastCollisionAlgorithm.Remove(agent);
		}
		this.RegisteredShapes.Clear();
	}

	// Token: 0x06018B77 RID: 101239 RVA: 0x00780E64 File Offset: 0x0077F064
	private void OnEnvironmentChanged(bool isStart)
	{
		if (isStart)
		{
			this.StartKuroFastCollision();
			return;
		}
		this.StopKuroFastCollision();
	}

	// Token: 0x06018B78 RID: 101240 RVA: 0x00780E76 File Offset: 0x0077F076
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		return base.ClearComponent(componentTemplate) && (((BaseKuroFastCollisionComponent)componentTemplate).RegisteredShapes == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.RegisteredShapes), "RegisteredShapes"));
	}

	// Token: 0x17002721 RID: 10017
	// (get) Token: 0x06018B79 RID: 101241 RVA: 0x00780EAB File Offset: 0x0077F0AB
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002722 RID: 10018
	// (get) Token: 0x06018B7A RID: 101242 RVA: 0x00780EAE File Offset: 0x0077F0AE
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400D6B3 RID: 54963
	private readonly List<UShapeComponent> RegisteredShapes = new List<UShapeComponent>();
}
