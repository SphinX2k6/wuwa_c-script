using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020030DE RID: 12510
[NullableContext(1)]
[Nullable(0)]
public class LockOnDebugData
{
	// Token: 0x0601ACA7 RID: 109735 RVA: 0x0073A4E3 File Offset: 0x007386E3
	public LockOnDebugData(LockOnInfo info)
	{
		this.Info = info;
	}

	// Token: 0x0601ACA8 RID: 109736 RVA: 0x0073A500 File Offset: 0x00738700
	public void DrawDebug(Entity me)
	{
		Entity entity = EntitySystem.Instance.Get<Entity>(this.Info.EntityHandle.Id);
		if (!string.IsNullOrEmpty(this.Info.SocketName))
		{
			Vector targetLocation = this.TargetLocation;
			FVectorDouble location = this.GetSkillBoneTransform(entity, this.Info.SocketName).GetLocation();
			targetLocation.DeepCopy(location);
		}
		else
		{
			this.TargetLocation.DeepCopy(entity.GetComponent<BaseActorComponent>().ActorLocationProxy);
		}
		FLinearColor? flinearColor = null;
		switch (this.ColorType)
		{
		case EColorType.Red:
			flinearColor = new FLinearColor?(LockOnDebugData.RedColor);
			break;
		case EColorType.Green:
			flinearColor = new FLinearColor?(LockOnDebugData.GreenColor);
			break;
		case EColorType.Black:
			flinearColor = new FLinearColor?(LockOnDebugData.BlackColor);
			break;
		}
		UObject world = GlobalData.World;
		BaseActorComponent component = me.GetComponent<BaseActorComponent>();
		UKismetSystemLibrary.D_DrawDebugArrow(world, (component != null) ? component.ActorLocationProxy.ToUeVector(false) : new FVectorDouble(), this.TargetLocation.ToUeVector(false), 15f, flinearColor ?? LockOnDebugData.GreenColor, 0f, 0f);
		if (!string.IsNullOrEmpty(this.ShowTip))
		{
			Vector vector = Vector.Create(this.TargetLocation.X, this.TargetLocation.Y, this.TargetLocation.Z);
			vector.Z += this.GetDebugTextOffset(entity);
			UKismetSystemLibrary.D_DrawDebugString(GlobalData.World, vector.ToUeVector(false), this.ShowTip, null, new FLinearColor?(flinearColor ?? LockOnDebugData.GreenColor), 0f);
		}
	}

	// Token: 0x0601ACA9 RID: 109737 RVA: 0x0073A6AC File Offset: 0x007388AC
	[NullableContext(2)]
	private double GetDebugTextOffset(Entity target)
	{
		object obj;
		if (target == null)
		{
			obj = null;
		}
		else
		{
			CharacterActorComponent component = target.GetComponent<CharacterActorComponent>();
			obj = ((component != null) ? component.Actor : null);
		}
		object obj2 = obj;
		float? num;
		if (obj2 == null)
		{
			num = null;
		}
		else
		{
			UCapsuleComponent capsuleComponent = obj2.CapsuleComponent;
			num = ((capsuleComponent != null) ? new float?(capsuleComponent.GetScaledCapsuleHalfHeight()) : null);
		}
		float? num2 = num;
		float valueOrDefault = num2.GetValueOrDefault();
		if (valueOrDefault > 0f)
		{
			return (double)valueOrDefault + 50.0;
		}
		return 120.0;
	}

	// Token: 0x0601ACAA RID: 109738 RVA: 0x0073A728 File Offset: 0x00738928
	private FTransformDouble GetSkillBoneTransform(Entity target, string bone)
	{
		CharacterActorComponent component = target.GetComponent<CharacterActorComponent>();
		TsBaseCharacter tsBaseCharacter = (component != null) ? component.Actor : null;
		if (tsBaseCharacter == null || !tsBaseCharacter.IsValid() || string.IsNullOrEmpty(bone))
		{
			return MathUtils.Instance.DefaultTransformDouble;
		}
		USkeletalMeshComponent mesh = tsBaseCharacter.Mesh;
		FName? dynamicFName = FNameUtil.GetDynamicFName(bone);
		if (mesh != null && dynamicFName != null && mesh.DoesSocketExist(dynamicFName.Value))
		{
			return mesh.D_GetSocketTransform(dynamicFName.Value, ERelativeTransformSpace.RTS_World);
		}
		return MathUtils.Instance.DefaultTransformDouble;
	}

	// Token: 0x0400CEE8 RID: 52968
	[Nullable(2)]
	public string ShowTip;

	// Token: 0x0400CEE9 RID: 52969
	public EColorType ColorType;

	// Token: 0x0400CEEA RID: 52970
	private readonly Vector TargetLocation = Vector.Create();

	// Token: 0x0400CEEB RID: 52971
	private static readonly FLinearColor RedColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x0400CEEC RID: 52972
	private static readonly FLinearColor GreenColor = new FLinearColor(0f, 1f, 0f, 1f);

	// Token: 0x0400CEED RID: 52973
	private static readonly FLinearColor BlackColor = new FLinearColor(0f, 0f, 0f, 1f);

	// Token: 0x0400CEEE RID: 52974
	private readonly LockOnInfo Info;
}
