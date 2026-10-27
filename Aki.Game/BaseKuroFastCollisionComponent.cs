using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02003131 RID: 12593
[NullableContext(1)]
[Nullable(0)]
public class BaseKuroFastCollisionComponent : EntityComponent
{
	// Token: 0x0601B107 RID: 110855 RVA: 0x0075A948 File Offset: 0x00758B48
	protected override bool OnStart()
	{
		EventSystem.Instance.Add(EEventName.BulletPatternEnvironmentChanged, new Action<bool>(this.OnEnvironmentChanged));
		if (BulletPatternComponent.GetKuroFastCollisionAlgorithm() != null)
		{
			this.StartKuroFastCollision();
		}
		return true;
	}

	// Token: 0x0601B108 RID: 110856 RVA: 0x0075A974 File Offset: 0x00758B74
	protected override bool OnEnd()
	{
		this.StopKuroFastCollision();
		EventSystem.Instance.Remove(EEventName.BulletPatternEnvironmentChanged, new Action<bool>(this.OnEnvironmentChanged));
		return true;
	}

	// Token: 0x0601B109 RID: 110857 RVA: 0x0075A999 File Offset: 0x00758B99
	protected virtual void OnStartKuroFastCollision()
	{
	}

	// Token: 0x0601B10A RID: 110858 RVA: 0x0075A99B File Offset: 0x00758B9B
	protected virtual void OnStopKuroFastCollision()
	{
	}

	// Token: 0x0601B10B RID: 110859 RVA: 0x0075A99D File Offset: 0x00758B9D
	private void StartKuroFastCollision()
	{
		this.RegisterAllShapes();
		this.OnStartKuroFastCollision();
	}

	// Token: 0x0601B10C RID: 110860 RVA: 0x0075A9AB File Offset: 0x00758BAB
	private void StopKuroFastCollision()
	{
		this.UnregisterAllShapes();
		this.OnStopKuroFastCollision();
	}

	// Token: 0x0601B10D RID: 110861 RVA: 0x0075A9BC File Offset: 0x00758BBC
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

	// Token: 0x0601B10E RID: 110862 RVA: 0x0075AA48 File Offset: 0x00758C48
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

	// Token: 0x0601B10F RID: 110863 RVA: 0x0075AABC File Offset: 0x00758CBC
	private void OnEnvironmentChanged(bool isStart)
	{
		if (isStart)
		{
			this.StartKuroFastCollision();
			return;
		}
		this.StopKuroFastCollision();
	}

	// Token: 0x0601B110 RID: 110864 RVA: 0x0075AAD0 File Offset: 0x00758CD0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseKuroFastCollisionComponent baseKuroFastCollisionComponent = (BaseKuroFastCollisionComponent)componentTemplate;
		return !base.CanResetComponentProperty("RegisteredShapes") || baseKuroFastCollisionComponent.RegisteredShapes == null || base.CheckClearObject(EntityComponentSystem.ClearObject<List<UShapeComponent>>(this.RegisteredShapes), "RegisteredShapes");
	}

	// Token: 0x0400D289 RID: 53897
	private readonly List<UShapeComponent> RegisteredShapes = new List<UShapeComponent>();
}
