using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000195 RID: 405
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAirAttack.TsAnimNotifyAirAttack_C")]
public class TsAnimNotifyAirAttack : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000445 RID: 1093
	// (get) Token: 0x06001A25 RID: 6693 RVA: 0x0008D0FF File Offset: 0x0008B2FF
	// (set) Token: 0x06001A26 RID: 6694 RVA: 0x0008D10F File Offset: 0x0008B30F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Speed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyAirAttack.__PropertyOffset_Speed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyAirAttack.__PropertyOffset_Speed) = value;
		}
	}

	// Token: 0x17000446 RID: 1094
	// (get) Token: 0x06001A27 RID: 6695 RVA: 0x0008D120 File Offset: 0x0008B320
	// (set) Token: 0x06001A28 RID: 6696 RVA: 0x0008D130 File Offset: 0x0008B330
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Offset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyAirAttack.__PropertyOffset_Offset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyAirAttack.__PropertyOffset_Offset) = value;
		}
	}

	// Token: 0x17000447 RID: 1095
	// (get) Token: 0x06001A29 RID: 6697 RVA: 0x0008D141 File Offset: 0x0008B341
	// (set) Token: 0x06001A2A RID: 6698 RVA: 0x0008D151 File Offset: 0x0008B351
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyAirAttack.__PropertyOffset_MaxDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyAirAttack.__PropertyOffset_MaxDistance) = value;
		}
	}

	// Token: 0x17000448 RID: 1096
	// (get) Token: 0x06001A2B RID: 6699 RVA: 0x0008D162 File Offset: 0x0008B362
	// (set) Token: 0x06001A2C RID: 6700 RVA: 0x0008D172 File Offset: 0x0008B372
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MinTan
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyAirAttack.__PropertyOffset_MinTan);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyAirAttack.__PropertyOffset_MinTan) = value;
		}
	}

	// Token: 0x17000449 RID: 1097
	// (get) Token: 0x06001A2D RID: 6701 RVA: 0x0008D183 File Offset: 0x0008B383
	// (set) Token: 0x06001A2E RID: 6702 RVA: 0x0008D193 File Offset: 0x0008B393
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxTan
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyAirAttack.__PropertyOffset_MaxTan);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyAirAttack.__PropertyOffset_MaxTan) = value;
		}
	}

	// Token: 0x1700044A RID: 1098
	// (get) Token: 0x06001A2F RID: 6703 RVA: 0x0008D1A4 File Offset: 0x0008B3A4
	// (set) Token: 0x06001A30 RID: 6704 RVA: 0x0008D1B4 File Offset: 0x0008B3B4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyAirAttack.__PropertyOffset_MaxTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyAirAttack.__PropertyOffset_MaxTime) = value;
		}
	}

	// Token: 0x1700044B RID: 1099
	// (get) Token: 0x06001A31 RID: 6705 RVA: 0x0008D1C5 File Offset: 0x0008B3C5
	// (set) Token: 0x06001A32 RID: 6706 RVA: 0x0008D1D5 File Offset: 0x0008B3D5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DrawDebug
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyAirAttack.__PropertyOffset_DrawDebug) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyAirAttack.__PropertyOffset_DrawDebug) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001A33 RID: 6707 RVA: 0x0008D1E8 File Offset: 0x0008B3E8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyAirAttack) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyAirAttack.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001A34 RID: 6708 RVA: 0x0008D2A0 File Offset: 0x0008B4A0
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		BaseMoveComponent baseMoveComponent = (characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<BaseMoveComponent>() : null;
		BaseAbilityComponent baseAbilityComponent = (characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<BaseAbilityComponent>() : null;
		if (characterActorComponent == null || baseMoveComponent == null || baseAbilityComponent == null)
		{
			return false;
		}
		if (this.Speed <= 0f)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity entity = characterActorComponent.Entity;
			string message = "下落攻击速度配置必须大于0";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("速度", this.Speed);
			instance.Error(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (this.MaxDistance < 0f)
		{
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Skill;
			Entity entity2 = characterActorComponent.Entity;
			string message2 = "下落攻击最大距离配置必须大于0";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("最大距离", this.MaxDistance);
			instance2.Error(flag2, entity2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		BaseSkillComponent component = characterActorComponent.Entity.GetComponent<BaseSkillComponent>();
		EntityHandle entityHandle = (component != null) ? component.SkillTarget : null;
		if (entityHandle == null || !entityHandle.Valid)
		{
			this.SetVerticalSpeed(baseMoveComponent, baseAbilityComponent);
			return true;
		}
		BaseActorComponent component2 = entityHandle.Entity.GetComponent<BaseActorComponent>();
		Vector actorLocationProxy = component2.ActorLocationProxy;
		CharacterActorComponent characterActorComponent2 = component2 as CharacterActorComponent;
		if (characterActorComponent2 != null)
		{
			baseMoveComponent.GravityUp.Multiply((double)characterActorComponent2.ScaledHalfHeight, this.TempVector1);
			actorLocationProxy.Subtraction(this.TempVector1, this.TempVector1);
		}
		else
		{
			this.TempVector1.DeepCopy(actorLocationProxy);
		}
		Vector actorLocationProxy2 = characterActorComponent.ActorLocationProxy;
		baseMoveComponent.GravityUp.Multiply((double)characterActorComponent.ScaledHalfHeight, this.TempVector2);
		actorLocationProxy2.Subtraction(this.TempVector2, this.TempVector2);
		double distSquared2dForActor = GravityUtils.Instance.GetDistSquared2dForActor(characterActorComponent, this.TempVector1, this.TempVector2);
		this.TempVector1.SubtractionEqual(this.TempVector2);
		double num = Math.Sqrt(this.TempVector1.SizeSquared() - distSquared2dForActor);
		double num2 = Math.Sqrt(distSquared2dForActor);
		num2 -= (double)this.Offset;
		num2 = MathUtils.Instance.Clamp(num2, 0.0, (double)this.MaxDistance);
		double num3 = Math.Atan2(num2, num);
		float num4 = MathUtils.Instance.Clamp(this.MinTan, 0f, 90f) * 0.017453292f;
		float num5 = MathUtils.Instance.Clamp(this.MaxTan, 0f, 90f) * 0.017453292f;
		num3 = MathUtils.Instance.Clamp(num3, (double)num4, (double)num5);
		Vector actorForwardProxy = characterActorComponent.ActorForwardProxy;
		double num6 = num * Math.Tan(num3);
		actorForwardProxy.Multiply(num6, this.TempVector1);
		baseMoveComponent.GravityDirect.Multiply(num, this.TempVector3);
		this.TempVector3.AdditionEqual(this.TempVector1);
		this.TempVector3.AdditionEqual(this.TempVector2);
		this.Draw(this.TempVector2, this.TempVector3);
		double inB = (double)this.Speed * Math.Tan(num3);
		actorForwardProxy.Multiply(inB, this.TempVector1);
		float speed = this.Speed;
		baseMoveComponent.GravityDirect.Multiply((double)speed, this.TempVector3);
		this.TempVector3.Addition(this.TempVector1, this.TempVector1);
		this.TempVector1.Multiply((double)this.MaxTime, this.TempVector3);
		this.TempVector2.Addition(this.TempVector3, this.TempVector3);
		if (!this.IsHit(this.TempVector2, this.TempVector3))
		{
			this.SetVerticalSpeed(baseMoveComponent, baseAbilityComponent);
			return true;
		}
		this.SetSlopeSpeed(baseMoveComponent, baseAbilityComponent, num3, num6, num, this.TempVector1);
		return true;
	}

	// Token: 0x06001A35 RID: 6709 RVA: 0x0008D638 File Offset: 0x0008B838
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyAirAttack) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyAirAttack.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001A36 RID: 6710 RVA: 0x0008D6C8 File Offset: 0x0008B8C8
	protected override string GetNotifyName_Implementation()
	{
		return "空中攻击位移";
	}

	// Token: 0x06001A37 RID: 6711 RVA: 0x0008D6D0 File Offset: 0x0008B8D0
	private void Draw(Vector start, Vector end)
	{
		if (!this.DrawDebug)
		{
			return;
		}
		UKismetSystemLibrary.D_DrawDebugArrow(GlobalData.World, start.ToUeVector(false), end.ToUeVector(false), 15f, new FLinearColor(1f, 0f, 0f, 1f), 5f, 5f);
	}

	// Token: 0x06001A38 RID: 6712 RVA: 0x0008D728 File Offset: 0x0008B928
	private bool IsHit(Vector start, Vector end)
	{
		UTraceLineElement staticLineTrace = SkillUtils.GetStaticLineTrace();
		TraceElementCommon.Instance.SetStartLocation(staticLineTrace, start);
		TraceElementCommon.Instance.SetEndLocation(staticLineTrace, end);
		return TraceElementCommon.Instance.LineTrace(staticLineTrace, "TsAnimNotifyAirAttack.IsHit") && staticLineTrace.HitResult.bBlockingHit;
	}

	// Token: 0x06001A39 RID: 6713 RVA: 0x0008D774 File Offset: 0x0008B974
	private void SetVerticalSpeed(BaseMoveComponent moveComp, BaseAbilityComponent abilityComp)
	{
		moveComp.GravityDirect.Multiply((double)this.Speed, this.TempVector1);
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
		Entity entity = moveComp.Entity;
		string message = "空中攻击（垂直）";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("速度", this.TempVector1);
		instance.Info(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		moveComp.SetForceSpeed(this.TempVector1);
		abilityComp.SendGameplayEventToActor(GameplayTagUtils.GetGameplayTagById(GameplayTagDefine.EGameplayTagId["角色.Common.下落攻击状态.垂直下落攻击"]).Value, null);
	}

	// Token: 0x06001A3A RID: 6714 RVA: 0x0008D7F8 File Offset: 0x0008B9F8
	private unsafe void SetSlopeSpeed(BaseMoveComponent moveComp, BaseAbilityComponent abilityComp, double angle, double dist2dFinal, double deltaHeight, Vector speed)
	{
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
		Entity entity = moveComp.Entity;
		string message = "空中攻击（斜向）";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("夹角", angle * 57.295780181884766);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("水平距离", dist2dFinal);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("高度差", deltaHeight);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("速度向量", speed);
		instance.Info(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		moveComp.SetForceSpeed(speed);
		abilityComp.SendGameplayEventToActor(GameplayTagUtils.GetGameplayTagById(GameplayTagDefine.EGameplayTagId["角色.Common.下落攻击状态.斜向下落攻击"]).Value, null);
	}

	// Token: 0x06001A3B RID: 6715 RVA: 0x0008D8D2 File Offset: 0x0008BAD2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyAirAttack._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAirAttack.TsAnimNotifyAirAttack_C");
		}
		return TsAnimNotifyAirAttack._ClassPtr;
	}

	// Token: 0x06001A3C RID: 6716 RVA: 0x0008D8F8 File Offset: 0x0008BAF8
	public TsAnimNotifyAirAttack() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAirAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A3D RID: 6717 RVA: 0x0008D920 File Offset: 0x0008BB20
	public TsAnimNotifyAirAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAirAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A3E RID: 6718 RVA: 0x0008D953 File Offset: 0x0008BB53
	protected TsAnimNotifyAirAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A3F RID: 6719 RVA: 0x0008D980 File Offset: 0x0008BB80
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001A40 RID: 6720 RVA: 0x0008D9B3 File Offset: 0x0008BBB3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400110A RID: 4362
	private readonly Vector TempVector1 = Vector.Create();

	// Token: 0x0400110B RID: 4363
	private readonly Vector TempVector2 = Vector.Create();

	// Token: 0x0400110C RID: 4364
	private readonly Vector TempVector3 = Vector.Create();

	// Token: 0x0400110D RID: 4365
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAirAttack.TsAnimNotifyAirAttack_C";

	// Token: 0x0400110E RID: 4366
	private static IntPtr _ClassPtr;

	// Token: 0x0400110F RID: 4367
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001110 RID: 4368
	private static int __PropertyOffset_Speed;

	// Token: 0x04001111 RID: 4369
	private static int __PropertyOffset_Offset;

	// Token: 0x04001112 RID: 4370
	private static int __PropertyOffset_MaxDistance;

	// Token: 0x04001113 RID: 4371
	private static int __PropertyOffset_MinTan;

	// Token: 0x04001114 RID: 4372
	private static int __PropertyOffset_MaxTan;

	// Token: 0x04001115 RID: 4373
	private static int __PropertyOffset_MaxTime;

	// Token: 0x04001116 RID: 4374
	private static int __PropertyOffset_DrawDebug;
}
