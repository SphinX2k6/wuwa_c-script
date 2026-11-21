using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Game.Module;
using UnrealEngine;

// Token: 0x020022F0 RID: 8944
public class BulletActionSceneInteract : BulletActionBase
{
	// Token: 0x060160EA RID: 90346 RVA: 0x00668406 File Offset: 0x00666606
	public BulletActionSceneInteract(EBulletAction type) : base(type)
	{
	}

	// Token: 0x060160EB RID: 90347 RVA: 0x00668410 File Offset: 0x00666610
	protected override void OnExecute()
	{
		BulletDataMain bulletDataMain = this.BulletInfo.BulletDataMain;
		if (!bulletDataMain.Interact.IsSceneInteract || !SceneBattleInteractModel.Instance.Open)
		{
			this.IsFinish = true;
			return;
		}
		if (this.BulletInfo.CollisionInfo.CollisionComponent == null)
		{
			this.IsFinish = true;
			return;
		}
		BP_SceneBattleInteract_C bp_SceneBattleInteract_C = ResourceSystem.Instance.Load<BP_SceneBattleInteract_C>(bulletDataMain.Interact.SceneInteract.ToString(), "js_undefined");
		SceneBattleInteractEffect sceneBattleInteractEffect = SceneBattleInteractModel.Instance.CreateSceneBattleInteract(bp_SceneBattleInteract_C, this.GetRadius(), 0f);
		if (sceneBattleInteractEffect != null)
		{
			this.HandleId = sceneBattleInteractEffect.Id;
			sceneBattleInteractEffect.SetUpdateLocationFunc(new Action<Vector, FVectorDouble?>(this.UpdateLocation));
			sceneBattleInteractEffect.SetEnable(true, 0f);
			global::ESceneBattleInteractEntityType esceneBattleInteractEntityType = (global::ESceneBattleInteractEntityType)bp_SceneBattleInteract_C.EntityType;
			if (esceneBattleInteractEntityType == global::ESceneBattleInteractEntityType.Player || esceneBattleInteractEntityType == global::ESceneBattleInteractEntityType.Summoned)
			{
				Entity attacker = this.BulletInfo.Attacker;
				if (attacker != null && attacker.Valid)
				{
					if (esceneBattleInteractEntityType == global::ESceneBattleInteractEntityType.Summoned)
					{
						CreatureDataComponent attackerCreatureDataComp = this.BulletInfo.AttackerCreatureDataComp;
						long? num = (attackerCreatureDataComp != null) ? new long?(attackerCreatureDataComp.GetSummonerId()) : null;
						if (num != null)
						{
							int entityId = CreatureModel.Instance.GetEntityId(num.Value);
							sceneBattleInteractEffect.BindEntityId(entityId);
							return;
						}
					}
					else
					{
						sceneBattleInteractEffect.BindEntityId(attacker.Id);
					}
				}
			}
		}
	}

	// Token: 0x060160EC RID: 90348 RVA: 0x00668568 File Offset: 0x00666768
	[NullableContext(1)]
	private void UpdateLocation(Vector outVector, FVectorDouble? offset = null)
	{
		Vector collisionLocation = this.BulletInfo.GetCollisionLocation(false);
		if (offset == null)
		{
			outVector.FromUeVector(collisionLocation);
			return;
		}
		FTransformDouble collisionTransform = this.BulletInfo.CollisionInfo.CollisionTransform;
		FVectorDouble value = offset.Value;
		FVectorDouble fvectorDouble = collisionTransform.TransformVector(value);
		outVector.FromUeVector(fvectorDouble);
		outVector.AdditionEqual(collisionLocation);
	}

	// Token: 0x060160ED RID: 90349 RVA: 0x006685C8 File Offset: 0x006667C8
	private float GetRadius()
	{
		BulletDataMain bulletDataMain = this.BulletInfo.BulletDataMain;
		Vector size = this.BulletInfo.Size;
		float result = 0f;
		EBulletShape shape = bulletDataMain.Base.Shape;
		if (shape != EBulletShape.Cube)
		{
			if (shape - EBulletShape.Sphere <= 2)
			{
				result = (float)size.X;
			}
		}
		else
		{
			result = (float)size.GetMin();
		}
		return result;
	}

	// Token: 0x060160EE RID: 90350 RVA: 0x0066861B File Offset: 0x0066681B
	public override void Clear()
	{
		base.Clear();
		SceneBattleInteractModel.Instance.DestroySceneBattleInteract(this.HandleId);
	}

	// Token: 0x0400B955 RID: 47445
	private int HandleId;
}
