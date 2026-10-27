using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200011B RID: 283
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCaughtBinding.TsAnimNotifyStateCaughtBinding_C")]
public class TsAnimNotifyStateCaughtBinding : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x060010E8 RID: 4328 RVA: 0x0005FD9B File Offset: 0x0005DF9B
	static TsAnimNotifyStateCaughtBinding()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateCaughtBinding.CreateStaticDefaultValue), new Action(TsAnimNotifyStateCaughtBinding.ResetStaticDefaultValue));
	}

	// Token: 0x060010E9 RID: 4329 RVA: 0x0005FDBA File Offset: 0x0005DFBA
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateCaughtBinding._sphereTrace = null;
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x0005FDC2 File Offset: 0x0005DFC2
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateCaughtBinding._sphereTrace = null;
	}

	// Token: 0x170002B8 RID: 696
	// (get) Token: 0x060010EB RID: 4331 RVA: 0x0005FDCC File Offset: 0x0005DFCC
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> CaughtIds
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._CaughtIds) == null)
			{
				result = (this._CaughtIds = new TArray<string>(base.NativePtr + (IntPtr)TsAnimNotifyStateCaughtBinding.__PropertyOffset_CaughtIds, this));
			}
			return result;
		}
	}

	// Token: 0x170002B9 RID: 697
	// (get) Token: 0x060010EC RID: 4332 RVA: 0x0005FE05 File Offset: 0x0005E005
	// (set) Token: 0x060010ED RID: 4333 RVA: 0x0005FE15 File Offset: 0x0005E015
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float DetectionRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCaughtBinding.__PropertyOffset_DetectionRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCaughtBinding.__PropertyOffset_DetectionRadius) = value;
		}
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x0005FE28 File Offset: 0x0005E028
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x0005FED0 File Offset: 0x0005E0D0
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (entity == null)
		{
			return false;
		}
		CharacterBuffComponent component = entity.GetComponent<CharacterBuffComponent>();
		long? caughtBindingAnsInfo = (component != null) ? component.CreateAnimNotifyContent(animation.GetName(), base.exportIndex) : null;
		CharacterSkillComponent component2 = entity.GetComponent<CharacterSkillComponent>();
		CharacterCaughtNewComponent component3 = entity.GetComponent<CharacterCaughtNewComponent>();
		if (component3 != null)
		{
			if (this.DetectionRadius > 0f)
			{
				this.CheckPosition(component3);
			}
			component3.SetCaughtBindingAnsInfo(caughtBindingAnsInfo);
			CharacterCaughtNewComponent characterCaughtNewComponent = component3;
			TArray<string> caughtIds = this.CaughtIds;
			int? num;
			if (component2 == null)
			{
				num = null;
			}
			else
			{
				Skill currentSkill = component2.CurrentSkill;
				num = ((currentSkill != null) ? new int?(currentSkill.SkillId) : null);
			}
			int? num2 = num;
			characterCaughtNewComponent.BeginCaught(caughtIds, num2.GetValueOrDefault());
			return true;
		}
		return false;
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x0005FFA8 File Offset: 0x0005E1A8
	private void CheckPosition(CharacterCaughtNewComponent caughtComponent)
	{
		TsAnimNotifyStateCaughtBinding.InitTrace();
		for (int i = 0; i < this.CaughtIds.Num(); i++)
		{
			string key = this.CaughtIds.Get(i);
			CharacterActorComponent component = caughtComponent.Entity.GetComponent<CharacterActorComponent>();
			if (component == null)
			{
				return;
			}
			ValueTuple<Entity, long, float> valueTuple;
			if (!caughtComponent.PendingCaughtList.TryGetValue(key, out valueTuple))
			{
				return;
			}
			global::Vector actorLocationProxy = component.ActorLocationProxy;
			UTraceSphereElement sphereTrace = TsAnimNotifyStateCaughtBinding._sphereTrace;
			TraceElementCommon.Instance.SetStartLocation(sphereTrace, actorLocationProxy);
			TraceElementCommon.Instance.SetEndLocation(sphereTrace, actorLocationProxy);
			sphereTrace.Radius = this.DetectionRadius;
			if (!TraceElementCommon.Instance.SphereTrace(sphereTrace, "FightCameraLogicComponent_CheckCollision_ExecutionAdjust"))
			{
				return;
			}
			bool flag = false;
			UKuroHitResult hitResult = sphereTrace.HitResult;
			TArray<int> itemArray = hitResult.ItemArray;
			for (int j = 0; j < hitResult.GetHitCount(); j++)
			{
				int instanceIndex = itemArray.Get(j);
				if (UKuroCollisionLibrary.GetCollisionProfileName(hitResult.Components.Get(j), instanceIndex).ToString().Contains("InvisibleWall"))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return;
			}
			CreatureDataComponent component2 = valueTuple.Item1.GetComponent<CreatureDataComponent>();
			if (component2 != null && component2.GetEntityType() == EEntityType.Monster)
			{
				global::Vector vector = global::Vector.Create(component2.GetInitLocation());
				global::Vector inB = global::Vector.Create(actorLocationProxy);
				global::Vector vector2 = global::Vector.Create();
				vector.Subtraction(inB, vector2);
				vector2.Normalize(9.99999993922529E-09);
				vector2.Multiply((double)this.DetectionRadius, vector2);
				global::Vector vector3 = global::Vector.Create(component.ActorLocation).AdditionEqual(vector2);
				component.SetActorLocation(vector3.ToUeVector(false), "ExecutionAdjustMove", false);
				CharacterActorComponent component3 = valueTuple.Item1.GetComponent<CharacterActorComponent>();
				if (component3 == null)
				{
					return;
				}
				global::Vector vector4 = global::Vector.Create(component3.ActorLocation).AdditionEqual(vector2);
				component3.SetActorLocation(vector4.ToUeVector(false), "ExecutionAdjustMove", false);
			}
		}
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x000601A0 File Offset: 0x0005E3A0
	public static void InitTrace()
	{
		TsAnimNotifyStateCaughtBinding._sphereTrace = new UTraceSphereElement();
		TsAnimNotifyStateCaughtBinding._sphereTrace.bIsSingle = false;
		TsAnimNotifyStateCaughtBinding._sphereTrace.bIgnoreSelf = true;
		TsAnimNotifyStateCaughtBinding._sphereTrace.bTraceComplex = false;
		TsAnimNotifyStateCaughtBinding._sphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStatic);
		TsAnimNotifyStateCaughtBinding._sphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStaticIgnoreBullet);
		TsAnimNotifyStateCaughtBinding._sphereTrace.WorldContextObject = GlobalData.World;
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x00060208 File Offset: 0x0005E408
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
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

	// Token: 0x060010F3 RID: 4339 RVA: 0x000602A8 File Offset: 0x0005E4A8
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		if (tsBaseCharacter.CharacterActorComponent == null)
		{
			return false;
		}
		Entity entity = tsBaseCharacter.CharacterActorComponent.Entity;
		if (entity == null)
		{
			return false;
		}
		CharacterCaughtNewComponent component = entity.GetComponent<CharacterCaughtNewComponent>();
		if (component != null)
		{
			component.EndCaught();
			return true;
		}
		return false;
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x000602F4 File Offset: 0x0005E4F4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x060010F5 RID: 4341 RVA: 0x0006036F File Offset: 0x0005E56F
	protected override string GetNotifyName_Implementation()
	{
		return "抓取绑定";
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x00060376 File Offset: 0x0005E576
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateCaughtBinding._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCaughtBinding.TsAnimNotifyStateCaughtBinding_C");
		}
		return TsAnimNotifyStateCaughtBinding._ClassPtr;
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x0006039C File Offset: 0x0005E59C
	public TsAnimNotifyStateCaughtBinding() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCaughtBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060010F8 RID: 4344 RVA: 0x000603C4 File Offset: 0x0005E5C4
	public TsAnimNotifyStateCaughtBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCaughtBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x000603F7 File Offset: 0x0005E5F7
	protected TsAnimNotifyStateCaughtBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060010FA RID: 4346 RVA: 0x00060400 File Offset: 0x0005E600
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060010FB RID: 4347 RVA: 0x0006043C File Offset: 0x0005E63C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x0006046F File Offset: 0x0005E66F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CD4 RID: 3284
	private const string PROFILE_KEY = "FightCameraLogicComponent_CheckCollision_ExecutionAdjust";

	// Token: 0x04000CD5 RID: 3285
	private const string AIRWALL_PORFILENAME = "InvisibleWall";

	// Token: 0x04000CD6 RID: 3286
	[Nullable(2)]
	private static UTraceSphereElement _sphereTrace;

	// Token: 0x04000CD7 RID: 3287
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCaughtBinding.TsAnimNotifyStateCaughtBinding_C";

	// Token: 0x04000CD8 RID: 3288
	private static IntPtr _ClassPtr;

	// Token: 0x04000CD9 RID: 3289
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CDA RID: 3290
	private static int __PropertyOffset_CaughtIds;

	// Token: 0x04000CDB RID: 3291
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _CaughtIds;

	// Token: 0x04000CDC RID: 3292
	private static int __PropertyOffset_DetectionRadius;
}
