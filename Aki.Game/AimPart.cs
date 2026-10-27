using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Fight.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

// Token: 0x02003268 RID: 12904
[NullableContext(1)]
[Nullable(0)]
public class AimPart
{
	// Token: 0x0601BE50 RID: 114256 RVA: 0x007BBB68 File Offset: 0x007B9D68
	public AimPart(BaseActorComponent ownerBase)
	{
		this.OwnerBase = ownerBase;
	}

	// Token: 0x0601BE51 RID: 114257 RVA: 0x007BBBA4 File Offset: 0x007B9DA4
	public void Init(SAimPart config)
	{
		this.OwnerCharacter = (this.OwnerBase as CharacterActorComponent);
		this.BoneNameString = config.BoneName;
		Vector offset = this.Offset;
		FVector offset2 = config.Offset;
		FVectorDouble fvectorDouble = offset2;
		offset.DeepCopy(fvectorDouble);
		this.IgnoreCollisionBoneName = config.忽略的骨骼碰撞;
		this.BoneName = new FName(this.BoneNameString);
		this.RadiusIn = config.RadiusIn;
		this.RadiusOut = config.RadiusOut;
		this.RadiusOutOnStart = config.RadiusOutOnStart;
		this.MobileCorrect = config.MobileCorrect;
		this.GamePadCorrect = config.GamePadCorrect;
	}

	// Token: 0x0601BE52 RID: 114258 RVA: 0x007BBC44 File Offset: 0x007B9E44
	public void InitSceneItem(IAimPart config)
	{
		this.SceneItemHit = this.OwnerBase.Entity.GetComponent<SceneItemHitComponent>();
		this.BoneNameString = (config.BoneName ?? "");
		this.Offset.X = (double)config.Offset.X.GetValueOrDefault();
		this.Offset.Y = (double)config.Offset.Y.GetValueOrDefault();
		this.Offset.Z = (double)config.Offset.Z.GetValueOrDefault();
		this.BoneName = new FName(this.BoneNameString);
		this.RadiusIn = (float)config.RadiusIn;
		this.RadiusOut = (float)config.RadiusOut;
		this.RadiusOutOnStart = (float)config.RadiusOutOnStart;
		this.MobileCorrect = config.MobileCorrect;
		this.GamePadCorrect = config.GamePadCorrect;
	}

	// Token: 0x0601BE53 RID: 114259 RVA: 0x007BBD2C File Offset: 0x007B9F2C
	public float GetRadius(bool onStart)
	{
		float num = onStart ? this.RadiusOutOnStart : this.RadiusOut;
		if (Info.Instance.IsInGamepad())
		{
			num *= this.GamePadCorrect;
		}
		else if (Info.Instance.IsInTouch())
		{
			num *= this.MobileCorrect;
		}
		return num;
	}

	// Token: 0x0601BE54 RID: 114260 RVA: 0x007BBD78 File Offset: 0x007B9F78
	public bool GetAimPointLocation(Vector @out)
	{
		if (this.OwnerCharacter != null)
		{
			Transform tmpTrans = AimPart.TmpTrans;
			FTransformDouble ftransformDouble = this.OwnerCharacter.Actor.Mesh.D_GetSocketTransform(this.BoneName, ERelativeTransformSpace.RTS_World);
			tmpTrans.FromUeTransform(ftransformDouble);
		}
		else
		{
			if (this.SceneItemHit == null)
			{
				return false;
			}
			if (string.IsNullOrEmpty(this.BoneNameString))
			{
				AActor owner = this.OwnerBase.Owner;
				if (owner == null)
				{
					return false;
				}
				Transform tmpTrans2 = AimPart.TmpTrans;
				FTransformDouble ftransformDouble = owner.D_GetTransform();
				tmpTrans2.FromUeTransform(ftransformDouble);
			}
			else
			{
				SceneItemActorComponent sceneItemActorComponent = this.OwnerBase as SceneItemActorComponent;
				AActor aactor = (sceneItemActorComponent != null) ? sceneItemActorComponent.GetActorInSceneInteraction(this.BoneNameString) : null;
				if (aactor == null)
				{
					aactor = this.OwnerBase.Owner;
					if (aactor == null)
					{
						return false;
					}
				}
				Transform tmpTrans3 = AimPart.TmpTrans;
				FTransformDouble ftransformDouble = aactor.D_GetTransform();
				tmpTrans3.FromUeTransform(ftransformDouble);
			}
		}
		AimPart.TmpTrans.TransformPosition(this.Offset, @out);
		return true;
	}

	// Token: 0x0400DC19 RID: 56345
	[StaticVariableRuleIgnore]
	private static readonly Transform TmpTrans = Transform.Create();

	// Token: 0x0400DC1A RID: 56346
	public FName BoneName = FNameUtil.NONE;

	// Token: 0x0400DC1B RID: 56347
	public string BoneNameString = "";

	// Token: 0x0400DC1C RID: 56348
	public Vector Offset = Vector.Create();

	// Token: 0x0400DC1D RID: 56349
	public float RadiusIn;

	// Token: 0x0400DC1E RID: 56350
	public float RadiusOut;

	// Token: 0x0400DC1F RID: 56351
	public float RadiusOutOnStart;

	// Token: 0x0400DC20 RID: 56352
	public float MobileCorrect;

	// Token: 0x0400DC21 RID: 56353
	public float GamePadCorrect;

	// Token: 0x0400DC22 RID: 56354
	public string IgnoreCollisionBoneName = "";

	// Token: 0x0400DC23 RID: 56355
	[Nullable(2)]
	public CharacterActorComponent OwnerCharacter;

	// Token: 0x0400DC24 RID: 56356
	[Nullable(2)]
	public SceneItemHitComponent SceneItemHit;

	// Token: 0x0400DC25 RID: 56357
	public readonly BaseActorComponent OwnerBase;
}
