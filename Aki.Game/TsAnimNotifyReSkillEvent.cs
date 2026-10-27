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

// Token: 0x020001CF RID: 463
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyReSkillEvent.TsAnimNotifyReSkillEvent_C")]
public class TsAnimNotifyReSkillEvent : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700049D RID: 1181
	// (get) Token: 0x06001CDD RID: 7389 RVA: 0x0009253C File Offset: 0x0009073C
	// (set) Token: 0x06001CDE RID: 7390 RVA: 0x00092550 File Offset: 0x00090750
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

	// Token: 0x1700049E RID: 1182
	// (get) Token: 0x06001CDF RID: 7391 RVA: 0x00092565 File Offset: 0x00090765
	// (set) Token: 0x06001CE0 RID: 7392 RVA: 0x00092579 File Offset: 0x00090779
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

	// Token: 0x1700049F RID: 1183
	// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x0009258E File Offset: 0x0009078E
	// (set) Token: 0x06001CE2 RID: 7394 RVA: 0x000925A2 File Offset: 0x000907A2
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

	// Token: 0x170004A0 RID: 1184
	// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x000925B8 File Offset: 0x000907B8
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

	// Token: 0x170004A1 RID: 1185
	// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x000925F4 File Offset: 0x000907F4
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

	// Token: 0x170004A2 RID: 1186
	// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x00092630 File Offset: 0x00090830
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

	// Token: 0x170004A3 RID: 1187
	// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x00092669 File Offset: 0x00090869
	// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x00092679 File Offset: 0x00090879
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

	// Token: 0x170004A4 RID: 1188
	// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x0009268A File Offset: 0x0009088A
	// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x0009269A File Offset: 0x0009089A
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

	// Token: 0x170004A5 RID: 1189
	// (get) Token: 0x06001CEA RID: 7402 RVA: 0x000926AC File Offset: 0x000908AC
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

	// Token: 0x170004A6 RID: 1190
	// (get) Token: 0x06001CEB RID: 7403 RVA: 0x000926E5 File Offset: 0x000908E5
	// (set) Token: 0x06001CEC RID: 7404 RVA: 0x000926F5 File Offset: 0x000908F5
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

	// Token: 0x170004A7 RID: 1191
	// (get) Token: 0x06001CED RID: 7405 RVA: 0x00092706 File Offset: 0x00090906
	// (set) Token: 0x06001CEE RID: 7406 RVA: 0x0009271A File Offset: 0x0009091A
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

	// Token: 0x170004A8 RID: 1192
	// (get) Token: 0x06001CEF RID: 7407 RVA: 0x0009272F File Offset: 0x0009092F
	// (set) Token: 0x06001CF0 RID: 7408 RVA: 0x00092743 File Offset: 0x00090943
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

	// Token: 0x170004A9 RID: 1193
	// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x00092758 File Offset: 0x00090958
	// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x00092768 File Offset: 0x00090968
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

	// Token: 0x06001CF3 RID: 7411 RVA: 0x0009277C File Offset: 0x0009097C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent MeshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((MeshComp != null) ? MeshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001CF4 RID: 7412 RVA: 0x0009281C File Offset: 0x00090A1C
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

	// Token: 0x06001CF5 RID: 7413 RVA: 0x00092C74 File Offset: 0x00090E74
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x06001CF6 RID: 7414 RVA: 0x00092CEF File Offset: 0x00090EEF
	protected override string GetNotifyName_Implementation()
	{
		return "添加子弹";
	}

	// Token: 0x06001CF7 RID: 7415 RVA: 0x00092CF8 File Offset: 0x00090EF8
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

	// Token: 0x06001CF8 RID: 7416 RVA: 0x00092DD8 File Offset: 0x00090FD8
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

	// Token: 0x06001CF9 RID: 7417 RVA: 0x00092E9E File Offset: 0x0009109E
	protected virtual bool CanCreateBullet(AActor owner, UAnimSequenceBase animation, int index)
	{
		return true;
	}

	// Token: 0x06001CFA RID: 7418 RVA: 0x00092EA4 File Offset: 0x000910A4
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

	// Token: 0x06001CFB RID: 7419 RVA: 0x00092F42 File Offset: 0x00091142
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyReSkillEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyReSkillEvent.TsAnimNotifyReSkillEvent_C");
		}
		return TsAnimNotifyReSkillEvent._ClassPtr;
	}

	// Token: 0x06001CFC RID: 7420 RVA: 0x00092F68 File Offset: 0x00091168
	public TsAnimNotifyReSkillEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyReSkillEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001CFD RID: 7421 RVA: 0x00092F90 File Offset: 0x00091190
	public TsAnimNotifyReSkillEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyReSkillEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001CFE RID: 7422 RVA: 0x00092FC3 File Offset: 0x000911C3
	protected TsAnimNotifyReSkillEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001CFF RID: 7423 RVA: 0x00092FCC File Offset: 0x000911CC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D00 RID: 7424 RVA: 0x00092FFF File Offset: 0x000911FF
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001212 RID: 4626
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyReSkillEvent.TsAnimNotifyReSkillEvent_C";

	// Token: 0x04001213 RID: 4627
	private static IntPtr _ClassPtr;

	// Token: 0x04001214 RID: 4628
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001215 RID: 4629
	private static int __PropertyOffset_子弹数据名;

	// Token: 0x04001216 RID: 4630
	private static int __PropertyOffset_子弹出生位置偏移;

	// Token: 0x04001217 RID: 4631
	private static int __PropertyOffset_子弹初速度偏移;

	// Token: 0x04001218 RID: 4632
	private static int __PropertyOffset_子弹id数组;

	// Token: 0x04001219 RID: 4633
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _子弹id数组;

	// Token: 0x0400121A RID: 4634
	private static int __PropertyOffset_子弹出生位置偏移数组;

	// Token: 0x0400121B RID: 4635
	[Nullable(2)]
	private TArray<FVector> _子弹出生位置偏移数组;

	// Token: 0x0400121C RID: 4636
	private static int __PropertyOffset_子弹初速度偏移数组;

	// Token: 0x0400121D RID: 4637
	[Nullable(2)]
	private TArray<FRotator> _子弹初速度偏移数组;

	// Token: 0x0400121E RID: 4638
	private static int __PropertyOffset_使用子弹id数组;

	// Token: 0x0400121F RID: 4639
	private static int __PropertyOffset_使用召唤者子弹;

	// Token: 0x04001220 RID: 4640
	private static int __PropertyOffset_随机子弹权重数组;

	// Token: 0x04001221 RID: 4641
	[Nullable(2)]
	private TArray<float> _随机子弹权重数组;

	// Token: 0x04001222 RID: 4642
	private static int __PropertyOffset_传入当前实体位置;

	// Token: 0x04001223 RID: 4643
	private static int __PropertyOffset_骨骼名字;

	// Token: 0x04001224 RID: 4644
	private static int __PropertyOffset_指定Tag的Component;

	// Token: 0x04001225 RID: 4645
	private static int __PropertyOffset_通知实体子弹动画帧事件;
}
