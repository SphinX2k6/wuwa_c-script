using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Fight.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

// Token: 0x020027D7 RID: 10199
[NullableContext(1)]
[Nullable(0)]
public class AimPart
{
	// Token: 0x06019A2B RID: 105003 RVA: 0x007E3441 File Offset: 0x007E1641
	public AimPart(BaseActorComponent ownerBase)
	{
		this.OwnerBase = ownerBase;
	}

	// Token: 0x06019A2C RID: 105004 RVA: 0x007E347C File Offset: 0x007E167C
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

	// Token: 0x06019A2D RID: 105005 RVA: 0x007E351C File Offset: 0x007E171C
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

	// Token: 0x06019A2E RID: 105006 RVA: 0x007E3604 File Offset: 0x007E1804
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

	// Token: 0x06019A2F RID: 105007 RVA: 0x007E3650 File Offset: 0x007E1850
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

	// Token: 0x0400E0B8 RID: 57528
	[StaticVariableRuleIgnore]
	private static readonly Transform TmpTrans = Transform.Create();

	// Token: 0x0400E0B9 RID: 57529
	public FName BoneName = FNameUtil.NONE;

	// Token: 0x0400E0BA RID: 57530
	public string BoneNameString = "";

	// Token: 0x0400E0BB RID: 57531
	public Vector Offset = Vector.Create();

	// Token: 0x0400E0BC RID: 57532
	public float RadiusIn;

	// Token: 0x0400E0BD RID: 57533
	public float RadiusOut;

	// Token: 0x0400E0BE RID: 57534
	public float RadiusOutOnStart;

	// Token: 0x0400E0BF RID: 57535
	public float MobileCorrect;

	// Token: 0x0400E0C0 RID: 57536
	public float GamePadCorrect;

	// Token: 0x0400E0C1 RID: 57537
	public string IgnoreCollisionBoneName = "";

	// Token: 0x0400E0C2 RID: 57538
	[Nullable(2)]
	public CharacterActorComponent OwnerCharacter;

	// Token: 0x0400E0C3 RID: 57539
	[Nullable(2)]
	public SceneItemHitComponent SceneItemHit;

	// Token: 0x0400E0C4 RID: 57540
	public readonly BaseActorComponent OwnerBase;
}
