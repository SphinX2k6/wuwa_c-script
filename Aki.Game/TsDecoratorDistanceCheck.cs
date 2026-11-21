using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000021 RID: 33
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorDistanceCheck.TsDecoratorDistanceCheck_C")]
public class TsDecoratorDistanceCheck : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000013 RID: 19
	// (get) Token: 0x060000B8 RID: 184 RVA: 0x00004BDB File Offset: 0x00002DDB
	// (set) Token: 0x060000B9 RID: 185 RVA: 0x00004BEF File Offset: 0x00002DEF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<EArithmeticKeyOperation> CheckType
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorDistanceCheck.__PropertyOffset_CheckType);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorDistanceCheck.__PropertyOffset_CheckType) = value;
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060000BA RID: 186 RVA: 0x00004C04 File Offset: 0x00002E04
	// (set) Token: 0x060000BB RID: 187 RVA: 0x00004C14 File Offset: 0x00002E14
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SourcePbDataId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorDistanceCheck.__PropertyOffset_SourcePbDataId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorDistanceCheck.__PropertyOffset_SourcePbDataId) = value;
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x060000BC RID: 188 RVA: 0x00004C25 File Offset: 0x00002E25
	// (set) Token: 0x060000BD RID: 189 RVA: 0x00004C35 File Offset: 0x00002E35
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int TargetPbDataId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorDistanceCheck.__PropertyOffset_TargetPbDataId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorDistanceCheck.__PropertyOffset_TargetPbDataId) = value;
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x060000BE RID: 190 RVA: 0x00004C46 File Offset: 0x00002E46
	// (set) Token: 0x060000BF RID: 191 RVA: 0x00004C56 File Offset: 0x00002E56
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Distance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorDistanceCheck.__PropertyOffset_Distance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorDistanceCheck.__PropertyOffset_Distance) = value;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x060000C0 RID: 192 RVA: 0x00004C67 File Offset: 0x00002E67
	// (set) Token: 0x060000C1 RID: 193 RVA: 0x00004C77 File Offset: 0x00002E77
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IgnoreZ
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorDistanceCheck.__PropertyOffset_IgnoreZ) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorDistanceCheck.__PropertyOffset_IgnoreZ) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x060000C2 RID: 194 RVA: 0x00004C88 File Offset: 0x00002E88
	// (set) Token: 0x060000C3 RID: 195 RVA: 0x00004C98 File Offset: 0x00002E98
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Tolerance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorDistanceCheck.__PropertyOffset_Tolerance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorDistanceCheck.__PropertyOffset_Tolerance) = value;
		}
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00004CAC File Offset: 0x00002EAC
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsCheckType = this.CheckType;
			this.TsSourcePbDataId = this.SourcePbDataId;
			this.TsTargetPbDataId = this.TargetPbDataId;
			this.TsDistance = this.Distance;
			this.TsIgnoreZ = this.IgnoreZ;
			this.TsTolerance = this.Tolerance;
		}
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00004D1C File Offset: 0x00002F1C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorDistanceCheck) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorDistanceCheck.StaticClass(), out intPtr, out num))
		{
			return this.PerformConditionCheckAI_Implementation(ownerController, controlledPawn);
		}
		UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* ptr = stackalloc UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00004DD4 File Offset: 0x00002FD4
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		AiController aiController = (ownerController as TsAiController).AiController;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.InitTsVariables();
		BaseActorComponent actorCompByConfig = this.GetActorCompByConfig(this.TsSourcePbDataId, aiController);
		BaseActorComponent actorCompByConfig2 = this.GetActorCompByConfig(this.TsTargetPbDataId, aiController);
		if (!actorCompByConfig || !actorCompByConfig2)
		{
			return false;
		}
		double num = this.NeedBias ? ((double)this.TsTolerance) : 0.0001;
		double num2 = this.TsIgnoreZ ? Vector.Dist2D(actorCompByConfig.ActorLocationProxy, actorCompByConfig2.ActorLocationProxy) : Vector.Dist(actorCompByConfig.ActorLocationProxy, actorCompByConfig2.ActorLocationProxy);
		bool flag = false;
		switch (this.TsCheckType)
		{
		case EArithmeticKeyOperation.Equal:
			flag = (Math.Abs((double)this.TsDistance - num2) <= num);
			break;
		case EArithmeticKeyOperation.NotEqual:
			flag = (Math.Abs((double)this.TsDistance - num2) > num);
			break;
		case EArithmeticKeyOperation.Less:
			flag = (num2 < (double)this.TsDistance + num);
			break;
		case EArithmeticKeyOperation.LessOrEqual:
			flag = (num2 <= (double)this.TsDistance + num);
			break;
		case EArithmeticKeyOperation.Greater:
			flag = (num2 > (double)this.TsDistance - num);
			break;
		case EArithmeticKeyOperation.GreaterOrEqual:
			flag = (num2 >= (double)this.TsDistance - num);
			break;
		}
		this.NeedBias = flag;
		return flag;
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00004F50 File Offset: 0x00003150
	[NullableContext(1)]
	[return: Nullable(2)]
	private BaseActorComponent GetActorCompByConfig(int configId, AiController aiController)
	{
		switch (configId)
		{
		case -2:
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null)
			{
				return null;
			}
			return baseCharacter.CharacterActorComponent;
		}
		case -1:
			if (aiController == null)
			{
				return null;
			}
			return aiController.CharActorComp;
		case 0:
			return null;
		default:
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.TsTargetPbDataId);
			WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
			if (worldEntity == null)
			{
				return null;
			}
			return worldEntity.GetComponent<BaseActorComponent>();
		}
		}
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00004FBA File Offset: 0x000031BA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorDistanceCheck._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorDistanceCheck.TsDecoratorDistanceCheck_C");
		}
		return TsDecoratorDistanceCheck._ClassPtr;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00004FE0 File Offset: 0x000031E0
	public TsDecoratorDistanceCheck() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDistanceCheck.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00005008 File Offset: 0x00003208
	[NullableContext(1)]
	public TsDecoratorDistanceCheck(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDistanceCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060000CB RID: 203 RVA: 0x0000503B File Offset: 0x0000323B
	protected TsDecoratorDistanceCheck(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00005050 File Offset: 0x00003250
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000063 RID: 99
	private const int SELF_TOKEN_ID = -1;

	// Token: 0x04000064 RID: 100
	private const int PLAYER_TOKEN_ID = -2;

	// Token: 0x04000065 RID: 101
	private const int DEFAULT_TOLERANCE = 20;

	// Token: 0x04000066 RID: 102
	private bool IsInitTsVariables;

	// Token: 0x04000067 RID: 103
	private EArithmeticKeyOperation TsCheckType;

	// Token: 0x04000068 RID: 104
	private int TsSourcePbDataId;

	// Token: 0x04000069 RID: 105
	private int TsTargetPbDataId;

	// Token: 0x0400006A RID: 106
	private float TsDistance;

	// Token: 0x0400006B RID: 107
	private bool TsIgnoreZ;

	// Token: 0x0400006C RID: 108
	private float TsTolerance = 20f;

	// Token: 0x0400006D RID: 109
	private bool NeedBias;

	// Token: 0x0400006E RID: 110
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorDistanceCheck.TsDecoratorDistanceCheck_C";

	// Token: 0x0400006F RID: 111
	private static IntPtr _ClassPtr;

	// Token: 0x04000070 RID: 112
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000071 RID: 113
	private static int __PropertyOffset_CheckType;

	// Token: 0x04000072 RID: 114
	private static int __PropertyOffset_SourcePbDataId;

	// Token: 0x04000073 RID: 115
	private static int __PropertyOffset_TargetPbDataId;

	// Token: 0x04000074 RID: 116
	private static int __PropertyOffset_Distance;

	// Token: 0x04000075 RID: 117
	private static int __PropertyOffset_IgnoreZ;

	// Token: 0x04000076 RID: 118
	private static int __PropertyOffset_Tolerance;
}
