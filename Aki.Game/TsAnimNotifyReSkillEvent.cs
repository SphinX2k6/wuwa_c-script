using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Tools;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Extension;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D3 RID: 467
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyReSkillEvent.TsAnimNotifyReSkillEvent_C")]
public class TsAnimNotifyReSkillEvent : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004BF RID: 1215
	// (get) Token: 0x06001D7A RID: 7546 RVA: 0x00099278 File Offset: 0x00097478
	// (set) Token: 0x06001D7B RID: 7547 RVA: 0x0009928C File Offset: 0x0009748C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName 子弹数据名
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_子弹数据名);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_子弹数据名) = value;
		}
	}

	// Token: 0x170004C0 RID: 1216
	// (get) Token: 0x06001D7C RID: 7548 RVA: 0x000992A1 File Offset: 0x000974A1
	// (set) Token: 0x06001D7D RID: 7549 RVA: 0x000992B5 File Offset: 0x000974B5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector 子弹出生位置偏移
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_子弹出生位置偏移);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_子弹出生位置偏移) = value;
		}
	}

	// Token: 0x170004C1 RID: 1217
	// (get) Token: 0x06001D7E RID: 7550 RVA: 0x000992CA File Offset: 0x000974CA
	// (set) Token: 0x06001D7F RID: 7551 RVA: 0x000992DE File Offset: 0x000974DE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FRotator 子弹初速度偏移
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_子弹初速度偏移);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_子弹初速度偏移) = value;
		}
	}

	// Token: 0x170004C2 RID: 1218
	// (get) Token: 0x06001D80 RID: 7552 RVA: 0x000992F4 File Offset: 0x000974F4
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> 子弹id数组
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._子弹id数组) == null)
			{
				result = (this._子弹id数组 = new TArray<string>(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_子弹id数组, this));
			}
			return result;
		}
	}

	// Token: 0x170004C3 RID: 1219
	// (get) Token: 0x06001D81 RID: 7553 RVA: 0x00099330 File Offset: 0x00097530
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<FVector> 子弹出生位置偏移数组
	{
		get
		{
			base.FastCheckIsValid();
			TArray<FVector> result;
			if ((result = this._子弹出生位置偏移数组) == null)
			{
				result = (this._子弹出生位置偏移数组 = new TArray<FVector>(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_子弹出生位置偏移数组, this));
			}
			return result;
		}
	}

	// Token: 0x170004C4 RID: 1220
	// (get) Token: 0x06001D82 RID: 7554 RVA: 0x0009936C File Offset: 0x0009756C
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<FRotator> 子弹初速度偏移数组
	{
		get
		{
			base.FastCheckIsValid();
			TArray<FRotator> result;
			if ((result = this._子弹初速度偏移数组) == null)
			{
				result = (this._子弹初速度偏移数组 = new TArray<FRotator>(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_子弹初速度偏移数组, this));
			}
			return result;
		}
	}

	// Token: 0x170004C5 RID: 1221
	// (get) Token: 0x06001D83 RID: 7555 RVA: 0x000993A5 File Offset: 0x000975A5
	// (set) Token: 0x06001D84 RID: 7556 RVA: 0x000993B5 File Offset: 0x000975B5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 使用子弹id数组
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_使用子弹id数组) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_使用子弹id数组) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004C6 RID: 1222
	// (get) Token: 0x06001D85 RID: 7557 RVA: 0x000993C6 File Offset: 0x000975C6
	// (set) Token: 0x06001D86 RID: 7558 RVA: 0x000993D6 File Offset: 0x000975D6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 使用召唤者子弹
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_使用召唤者子弹) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_使用召唤者子弹) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004C7 RID: 1223
	// (get) Token: 0x06001D87 RID: 7559 RVA: 0x000993E8 File Offset: 0x000975E8
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<float> 随机子弹权重数组
	{
		get
		{
			base.FastCheckIsValid();
			TArray<float> result;
			if ((result = this._随机子弹权重数组) == null)
			{
				result = (this._随机子弹权重数组 = new TArray<float>(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_随机子弹权重数组, this));
			}
			return result;
		}
	}

	// Token: 0x170004C8 RID: 1224
	// (get) Token: 0x06001D88 RID: 7560 RVA: 0x00099421 File Offset: 0x00097621
	// (set) Token: 0x06001D89 RID: 7561 RVA: 0x00099431 File Offset: 0x00097631
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 传入当前实体位置
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_传入当前实体位置) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_传入当前实体位置) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004C9 RID: 1225
	// (get) Token: 0x06001D8A RID: 7562 RVA: 0x00099442 File Offset: 0x00097642
	// (set) Token: 0x06001D8B RID: 7563 RVA: 0x00099456 File Offset: 0x00097656
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName 骨骼名字
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_骨骼名字);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_骨骼名字) = value;
		}
	}

	// Token: 0x170004CA RID: 1226
	// (get) Token: 0x06001D8C RID: 7564 RVA: 0x0009946B File Offset: 0x0009766B
	// (set) Token: 0x06001D8D RID: 7565 RVA: 0x0009947F File Offset: 0x0009767F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName 指定Tag的Component
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_指定Tag的Component);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_指定Tag的Component) = value;
		}
	}

	// Token: 0x170004CB RID: 1227
	// (get) Token: 0x06001D8E RID: 7566 RVA: 0x00099494 File Offset: 0x00097694
	// (set) Token: 0x06001D8F RID: 7567 RVA: 0x000994A4 File Offset: 0x000976A4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 通知实体子弹动画帧事件
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_通知实体子弹动画帧事件) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyReSkillEvent.__PropertyOffset_通知实体子弹动画帧事件) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001D90 RID: 7568 RVA: 0x000994B8 File Offset: 0x000976B8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent MeshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyReSkillEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyReSkillEvent.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(MeshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((MeshComp != null) ? MeshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001D91 RID: 7569 RVA: 0x00099570 File Offset: 0x00097770
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase animation)
	{
		AActor owner = MeshComp.GetOwner();
		if (owner is TsBaseCharacter || owner is TsBaseVehicle)
		{
			TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
			Entity entity;
			if ((entity = ((tsBaseCharacter != null) ? tsBaseCharacter.GetEntityNoBlueprint() : null)) == null)
			{
				TsBaseVehicle tsBaseVehicle = owner as TsBaseVehicle;
				entity = ((tsBaseVehicle != null) ? tsBaseVehicle.GetEntityNoBlueprint() : null);
			}
			Entity entity2 = entity;
			if (entity2 == null || !entity2.Valid)
			{
				return false;
			}
			BaseBuffComponent component = entity2.GetComponent<BaseBuffComponent>();
			long? preContextId = (component != null) ? component.CreateAnimNotifyContent(animation.GetName(), base.exportIndex) : null;
			FTransformDouble initTransform = this.GetInitTransform(owner);
			if (this.使用召唤者子弹)
			{
				long summonerId = entity2.GetComponent<CreatureDataComponent>().GetSummonerId();
				if (summonerId <= 0L)
				{
					return false;
				}
				EntityHandle entity3 = CreatureModel.Instance.GetEntity(summonerId);
				entity2 = ((entity3 != null) ? entity3.Entity : null);
				owner = entity2.GetComponent<CharacterActorComponent>().Actor;
				if (entity2 == null || !entity2.Valid)
				{
					return false;
				}
				if (!(owner is TsBaseCharacter))
				{
					return false;
				}
			}
			BaseSkillComponent component2 = entity2.GetComponent<BaseSkillComponent>();
			if (component2 == null || !component2.Valid)
			{
				return false;
			}
			int currentMontageCorrespondingSkillId = component2.GetCurrentMontageCorrespondingSkillId();
			int skillId = (currentMontageCorrespondingSkillId != 0) ? currentMontageCorrespondingSkillId : component2.GetSkillIdWithGroupId(1);
			FVectorDouble? extraTargetLocation = component2.GetExtraTargetLocation(skillId);
			if (this.使用子弹id数组)
			{
				int num = this.子弹id数组.Num();
				int randomIndex = this.GetRandomIndex();
				int num2 = this.子弹出生位置偏移数组.Num();
				int num3 = this.子弹初速度偏移数组.Num();
				if (randomIndex >= 0 && randomIndex < num)
				{
					if (!this.CanCreateBullet(owner, animation, randomIndex))
					{
						return false;
					}
					FVector? locationOffset = null;
					FRotator? beginRotatorOffset = null;
					if (num2 > randomIndex)
					{
						locationOffset = new FVector?(this.子弹出生位置偏移数组.Get(randomIndex));
					}
					if (num3 > randomIndex)
					{
						beginRotatorOffset = new FRotator?(this.子弹初速度偏移数组.Get(randomIndex));
					}
					if (this.通知实体子弹动画帧事件)
					{
						EventSystem.Instance.EmitWithTarget(entity2, EEventName.PreBulletCreateFromAnimNotify);
					}
					int p = this.CreateBulletFromAN(entity2, this.子弹id数组.Get(randomIndex), new FTransformDouble?(initTransform), skillId, false, preContextId, extraTargetLocation, locationOffset, beginRotatorOffset);
					if (this.通知实体子弹动画帧事件)
					{
						EventSystem.Instance.EmitWithTarget<int>(entity2, EEventName.PostBulletCreateFromAnimNotify, p);
					}
				}
				else
				{
					for (int i = 0; i < num; i++)
					{
						if (this.CanCreateBullet(owner, animation, i))
						{
							FVector? locationOffset2 = null;
							FRotator? beginRotatorOffset2 = null;
							if (num2 > i)
							{
								locationOffset2 = new FVector?(this.子弹出生位置偏移数组.Get(i));
							}
							if (num3 > i)
							{
								beginRotatorOffset2 = new FRotator?(this.子弹初速度偏移数组.Get(i));
							}
							if (this.通知实体子弹动画帧事件)
							{
								EventSystem.Instance.EmitWithTarget(entity2, EEventName.PreBulletCreateFromAnimNotify);
							}
							int p2 = this.CreateBulletFromAN(entity2, this.子弹id数组.Get(i), new FTransformDouble?(initTransform), skillId, false, preContextId, extraTargetLocation, locationOffset2, beginRotatorOffset2);
							if (this.通知实体子弹动画帧事件)
							{
								EventSystem.Instance.EmitWithTarget<int>(entity2, EEventName.PostBulletCreateFromAnimNotify, p2);
							}
						}
					}
				}
			}
			else
			{
				if (!this.CanCreateBullet(owner, animation, 0))
				{
					return false;
				}
				if (this.通知实体子弹动画帧事件)
				{
					EventSystem.Instance.EmitWithTarget(entity2, EEventName.PreBulletCreateFromAnimNotify);
				}
				int p3 = this.CreateBulletFromAN(entity2, this.子弹数据名.ToString(), new FTransformDouble?(initTransform), skillId, false, preContextId, extraTargetLocation, new FVector?(this.子弹出生位置偏移), new FRotator?(this.子弹初速度偏移));
				if (this.通知实体子弹动画帧事件)
				{
					EventSystem.Instance.EmitWithTarget<int>(entity2, EEventName.PostBulletCreateFromAnimNotify, p3);
				}
			}
			return true;
		}
		else
		{
			if (this.使用子弹id数组 ? (this.子弹id数组.Num() <= 0) : FNameUtil.IsNothing(this.子弹数据名))
			{
				return false;
			}
			BP_EWorldType worldType = UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldType(owner.GetWorld());
			if (worldType != BP_EWorldType.Editor && worldType != BP_EWorldType.EditorPreview)
			{
				return false;
			}
			UObject outerObject = UKismetSystemLibrary.GetOuterObject(this);
			string path = UKismetSystemLibrary.GetPathName(outerObject);
			ResourceSystem.Instance.LoadTypeAsync(EBpTypeName.BPL_BulletPreview.ToEnumString(), delegate
			{
				if (!this.使用子弹id数组)
				{
					AActor aactor = null;
					BPL_BulletPreview_C.ShowBulletPreview(path, this.子弹数据名, owner, MeshComp, owner.GetWorld(), ref aactor);
					return;
				}
				TArray<string> 子弹id数组 = this.子弹id数组;
				int num4 = 子弹id数组.Num();
				int randomIndex2 = this.GetRandomIndex();
				if (randomIndex2 >= 0 && randomIndex2 < num4)
				{
					AActor aactor2 = null;
					BPL_BulletPreview_C.ShowBulletPreview(path, new FName(子弹id数组.Get(randomIndex2)), owner, MeshComp, owner.GetWorld(), ref aactor2);
					return;
				}
				for (int j = 0; j < num4; j++)
				{
					AActor aactor3 = null;
					BPL_BulletPreview_C.ShowBulletPreview(path, new FName(子弹id数组.Get(j)), owner, MeshComp, owner.GetWorld(), ref aactor3);
				}
			}, "js_undefined");
			return false;
		}
	}

	// Token: 0x06001D92 RID: 7570 RVA: 0x000999C8 File Offset: 0x00097BC8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyReSkillEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyReSkillEvent.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001D93 RID: 7571 RVA: 0x00099A58 File Offset: 0x00097C58
	protected override string GetNotifyName_Implementation()
	{
		return "添加子弹";
	}

	// Token: 0x06001D94 RID: 7572 RVA: 0x00099A60 File Offset: 0x00097C60
	private FTransformDouble GetInitTransform(AActor actor)
	{
		if (!this.传入当前实体位置)
		{
			return new FTransformDouble();
		}
		USceneComponent usceneComponent = null;
		bool flag = !FNameUtil.IsNothing(this.指定Tag的Component);
		if (flag)
		{
			TArray<UActorComponent> componentsByTag = actor.GetComponentsByTag(USceneComponent.StaticClass(), this.指定Tag的Component);
			if (componentsByTag.Num() > 0)
			{
				usceneComponent = (componentsByTag.Get(0) as USceneComponent);
			}
		}
		else
		{
			TsBaseCharacter tsBaseCharacter = actor as TsBaseCharacter;
			USkeletalMeshComponent uskeletalMeshComponent;
			if ((uskeletalMeshComponent = ((tsBaseCharacter != null) ? tsBaseCharacter.Mesh : null)) == null)
			{
				TsBaseVehicle tsBaseVehicle = actor as TsBaseVehicle;
				uskeletalMeshComponent = ((tsBaseVehicle != null) ? tsBaseVehicle.Mesh : null);
			}
			usceneComponent = uskeletalMeshComponent;
		}
		if (usceneComponent != null && usceneComponent.IsValid())
		{
			if (!FNameUtil.IsNothing(this.骨骼名字))
			{
				if (usceneComponent.DoesSocketExist(this.骨骼名字))
				{
					return usceneComponent.D_GetSocketTransform(this.骨骼名字, ERelativeTransformSpace.RTS_World);
				}
			}
			else if (flag)
			{
				return usceneComponent.D_K2_GetComponentToWorld();
			}
		}
		TsBaseCharacter tsBaseCharacter2 = actor as TsBaseCharacter;
		if (tsBaseCharacter2 == null)
		{
			return (actor as TsBaseVehicle).D_GetTransform();
		}
		return tsBaseCharacter2.D_GetTransform();
	}

	// Token: 0x06001D95 RID: 7573 RVA: 0x00099B40 File Offset: 0x00097D40
	private int GetRandomIndex()
	{
		int num = this.随机子弹权重数组.Num();
		if (num <= 0)
		{
			return -1;
		}
		if (num != this.子弹id数组.Num())
		{
			Log.Instance.Error(ELogModule.Bullet, ELogAuthor.HXY, "随机子弹权重数量对不上！", default(ReadOnlySpan<ValueTuple<string, object>>));
			return -1;
		}
		float num2 = 0f;
		for (int i = 0; i < num; i++)
		{
			float num3 = this.随机子弹权重数组.Get(i);
			if (num3 > 0f)
			{
				num2 += num3;
			}
		}
		float num4 = (float)(new Random().NextDouble() * (double)num2);
		for (int j = 0; j < num; j++)
		{
			float num5 = this.随机子弹权重数组.Get(j);
			if (num5 > 0f)
			{
				num4 -= num5;
				if (num4 <= 0f)
				{
					return j;
				}
			}
		}
		return -1;
	}

	// Token: 0x06001D96 RID: 7574 RVA: 0x00099C06 File Offset: 0x00097E06
	protected virtual bool CanCreateBullet(AActor owner, UAnimSequenceBase animation, int index)
	{
		return true;
	}

	// Token: 0x06001D97 RID: 7575 RVA: 0x00099C0C File Offset: 0x00097E0C
	protected virtual int CreateBulletFromAN(Entity ownerEntity, string bulletRowName, FTransformDouble? initialTransform, int skillId, bool needSync, long? preContextId, FVectorDouble? targetLocation = null, FVector? locationOffset = null, FRotator? beginRotatorOffset = null)
	{
		long? skillContextId = BulletUtil.GetSkillContextId(ownerEntity, skillId);
		BulletController.BulletCreateParams bulletCreateParams = new BulletController.BulletCreateParams();
		bulletCreateParams.SkillId = skillId;
		bulletCreateParams.SkillContextId = new long?(skillContextId.GetValueOrDefault());
		bulletCreateParams.SyncType = (needSync ? EBulletSyncType.SyncCreate : EBulletSyncType.Local);
		bulletCreateParams.InitTargetLocation = targetLocation;
		bulletCreateParams.LocationOffset = locationOffset;
		bulletCreateParams.BeginRotatorOffset = beginRotatorOffset;
		BaseSkillComponent component = ownerEntity.GetComponent<BaseSkillComponent>();
		ISkillBattleContext battleContext;
		if (component == null)
		{
			battleContext = null;
		}
		else
		{
			Skill skill = component.GetSkill(skillId);
			battleContext = ((skill != null) ? skill.BattleContext : null);
		}
		bulletCreateParams.BattleContext = battleContext;
		BulletController.BulletCreateParams bulletCreateParams2 = bulletCreateParams;
		BulletEntity bulletEntity = BulletController.Instance.CreateBulletCustomTarget(ownerEntity, bulletRowName, initialTransform, bulletCreateParams2, preContextId, EBulletCreateSource.Skill);
		if (bulletEntity == null)
		{
			return 0;
		}
		return bulletEntity.Id;
	}

	// Token: 0x06001D98 RID: 7576 RVA: 0x00099CAA File Offset: 0x00097EAA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyReSkillEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyReSkillEvent.TsAnimNotifyReSkillEvent_C");
		}
		return TsAnimNotifyReSkillEvent._ClassPtr;
	}

	// Token: 0x06001D99 RID: 7577 RVA: 0x00099CD0 File Offset: 0x00097ED0
	public TsAnimNotifyReSkillEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyReSkillEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D9A RID: 7578 RVA: 0x00099CF8 File Offset: 0x00097EF8
	public TsAnimNotifyReSkillEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyReSkillEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D9B RID: 7579 RVA: 0x00099D2B File Offset: 0x00097F2B
	protected TsAnimNotifyReSkillEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D9C RID: 7580 RVA: 0x00099D34 File Offset: 0x00097F34
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D9D RID: 7581 RVA: 0x00099D67 File Offset: 0x00097F67
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001255 RID: 4693
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyReSkillEvent.TsAnimNotifyReSkillEvent_C";

	// Token: 0x04001256 RID: 4694
	private static IntPtr _ClassPtr;

	// Token: 0x04001257 RID: 4695
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001258 RID: 4696
	private static int __PropertyOffset_子弹数据名;

	// Token: 0x04001259 RID: 4697
	private static int __PropertyOffset_子弹出生位置偏移;

	// Token: 0x0400125A RID: 4698
	private static int __PropertyOffset_子弹初速度偏移;

	// Token: 0x0400125B RID: 4699
	private static int __PropertyOffset_子弹id数组;

	// Token: 0x0400125C RID: 4700
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _子弹id数组;

	// Token: 0x0400125D RID: 4701
	private static int __PropertyOffset_子弹出生位置偏移数组;

	// Token: 0x0400125E RID: 4702
	[Nullable(2)]
	private TArray<FVector> _子弹出生位置偏移数组;

	// Token: 0x0400125F RID: 4703
	private static int __PropertyOffset_子弹初速度偏移数组;

	// Token: 0x04001260 RID: 4704
	[Nullable(2)]
	private TArray<FRotator> _子弹初速度偏移数组;

	// Token: 0x04001261 RID: 4705
	private static int __PropertyOffset_使用子弹id数组;

	// Token: 0x04001262 RID: 4706
	private static int __PropertyOffset_使用召唤者子弹;

	// Token: 0x04001263 RID: 4707
	private static int __PropertyOffset_随机子弹权重数组;

	// Token: 0x04001264 RID: 4708
	[Nullable(2)]
	private TArray<float> _随机子弹权重数组;

	// Token: 0x04001265 RID: 4709
	private static int __PropertyOffset_传入当前实体位置;

	// Token: 0x04001266 RID: 4710
	private static int __PropertyOffset_骨骼名字;

	// Token: 0x04001267 RID: 4711
	private static int __PropertyOffset_指定Tag的Component;

	// Token: 0x04001268 RID: 4712
	private static int __PropertyOffset_通知实体子弹动画帧事件;
}
