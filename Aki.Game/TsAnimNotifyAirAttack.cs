using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000191 RID: 401
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAirAttack.TsAnimNotifyAirAttack_C")]
public class TsAnimNotifyAirAttack : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000423 RID: 1059
	// (get) Token: 0x06001988 RID: 6536 RVA: 0x00086D37 File Offset: 0x00084F37
	// (set) Token: 0x06001989 RID: 6537 RVA: 0x00086D47 File Offset: 0x00084F47
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

	// Token: 0x17000424 RID: 1060
	// (get) Token: 0x0600198A RID: 6538 RVA: 0x00086D58 File Offset: 0x00084F58
	// (set) Token: 0x0600198B RID: 6539 RVA: 0x00086D68 File Offset: 0x00084F68
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

	// Token: 0x17000425 RID: 1061
	// (get) Token: 0x0600198C RID: 6540 RVA: 0x00086D79 File Offset: 0x00084F79
	// (set) Token: 0x0600198D RID: 6541 RVA: 0x00086D89 File Offset: 0x00084F89
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

	// Token: 0x17000426 RID: 1062
	// (get) Token: 0x0600198E RID: 6542 RVA: 0x00086D9A File Offset: 0x00084F9A
	// (set) Token: 0x0600198F RID: 6543 RVA: 0x00086DAA File Offset: 0x00084FAA
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

	// Token: 0x17000427 RID: 1063
	// (get) Token: 0x06001990 RID: 6544 RVA: 0x00086DBB File Offset: 0x00084FBB
	// (set) Token: 0x06001991 RID: 6545 RVA: 0x00086DCB File Offset: 0x00084FCB
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

	// Token: 0x17000428 RID: 1064
	// (get) Token: 0x06001992 RID: 6546 RVA: 0x00086DDC File Offset: 0x00084FDC
	// (set) Token: 0x06001993 RID: 6547 RVA: 0x00086DEC File Offset: 0x00084FEC
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

	// Token: 0x17000429 RID: 1065
	// (get) Token: 0x06001994 RID: 6548 RVA: 0x00086DFD File Offset: 0x00084FFD
	// (set) Token: 0x06001995 RID: 6549 RVA: 0x00086E0D File Offset: 0x0008500D
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

	// Token: 0x06001996 RID: 6550 RVA: 0x00086E20 File Offset: 0x00085020
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
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

	// Token: 0x06001997 RID: 6551 RVA: 0x00086EC0 File Offset: 0x000850C0
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

	// Token: 0x06001998 RID: 6552 RVA: 0x00087258 File Offset: 0x00085458
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

	// Token: 0x06001999 RID: 6553 RVA: 0x000872D3 File Offset: 0x000854D3
	protected override string GetNotifyName_Implementation()
	{
		return "空中攻击位移";
	}

	// Token: 0x0600199A RID: 6554 RVA: 0x000872DC File Offset: 0x000854DC
	private void Draw(Vector start, Vector end)
	{
		if (!this.DrawDebug)
		{
			return;
		}
		UKismetSystemLibrary.D_DrawDebugArrow(GlobalData.World, start.ToUeVector(false), end.ToUeVector(false), 15f, new FLinearColor(1f, 0f, 0f, 1f), 5f, 5f);
	}

	// Token: 0x0600199B RID: 6555 RVA: 0x00087334 File Offset: 0x00085534
	private bool IsHit(Vector start, Vector end)
	{
		UTraceLineElement staticLineTrace = SkillUtils.GetStaticLineTrace();
		TraceElementCommon.Instance.SetStartLocation(staticLineTrace, start);
		TraceElementCommon.Instance.SetEndLocation(staticLineTrace, end);
		return TraceElementCommon.Instance.LineTrace(staticLineTrace, "TsAnimNotifyAirAttack.IsHit") && staticLineTrace.HitResult.bBlockingHit;
	}

	// Token: 0x0600199C RID: 6556 RVA: 0x00087380 File Offset: 0x00085580
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

	// Token: 0x0600199D RID: 6557 RVA: 0x00087404 File Offset: 0x00085604
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

	// Token: 0x0600199E RID: 6558 RVA: 0x000874DE File Offset: 0x000856DE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyAirAttack._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAirAttack.TsAnimNotifyAirAttack_C");
		}
		return TsAnimNotifyAirAttack._ClassPtr;
	}

	// Token: 0x0600199F RID: 6559 RVA: 0x00087504 File Offset: 0x00085704
	public TsAnimNotifyAirAttack() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAirAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060019A0 RID: 6560 RVA: 0x0008752C File Offset: 0x0008572C
	public TsAnimNotifyAirAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAirAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060019A1 RID: 6561 RVA: 0x0008755F File Offset: 0x0008575F
	protected TsAnimNotifyAirAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060019A2 RID: 6562 RVA: 0x0008758C File Offset: 0x0008578C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060019A3 RID: 6563 RVA: 0x000875BF File Offset: 0x000857BF
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010C7 RID: 4295
	private readonly Vector TempVector1 = Vector.Create();

	// Token: 0x040010C8 RID: 4296
	private readonly Vector TempVector2 = Vector.Create();

	// Token: 0x040010C9 RID: 4297
	private readonly Vector TempVector3 = Vector.Create();

	// Token: 0x040010CA RID: 4298
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAirAttack.TsAnimNotifyAirAttack_C";

	// Token: 0x040010CB RID: 4299
	private static IntPtr _ClassPtr;

	// Token: 0x040010CC RID: 4300
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010CD RID: 4301
	private static int __PropertyOffset_Speed;

	// Token: 0x040010CE RID: 4302
	private static int __PropertyOffset_Offset;

	// Token: 0x040010CF RID: 4303
	private static int __PropertyOffset_MaxDistance;

	// Token: 0x040010D0 RID: 4304
	private static int __PropertyOffset_MinTan;

	// Token: 0x040010D1 RID: 4305
	private static int __PropertyOffset_MaxTan;

	// Token: 0x040010D2 RID: 4306
	private static int __PropertyOffset_MaxTime;

	// Token: 0x040010D3 RID: 4307
	private static int __PropertyOffset_DrawDebug;
}
