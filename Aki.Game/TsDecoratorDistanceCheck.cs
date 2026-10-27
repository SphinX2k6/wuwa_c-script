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
	// (get) Token: 0x060000B8 RID: 184 RVA: 0x00004A77 File Offset: 0x00002C77
	// (set) Token: 0x060000B9 RID: 185 RVA: 0x00004A8B File Offset: 0x00002C8B
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
	// (get) Token: 0x060000BA RID: 186 RVA: 0x00004AA0 File Offset: 0x00002CA0
	// (set) Token: 0x060000BB RID: 187 RVA: 0x00004AB0 File Offset: 0x00002CB0
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
	// (get) Token: 0x060000BC RID: 188 RVA: 0x00004AC1 File Offset: 0x00002CC1
	// (set) Token: 0x060000BD RID: 189 RVA: 0x00004AD1 File Offset: 0x00002CD1
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
	// (get) Token: 0x060000BE RID: 190 RVA: 0x00004AE2 File Offset: 0x00002CE2
	// (set) Token: 0x060000BF RID: 191 RVA: 0x00004AF2 File Offset: 0x00002CF2
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
	// (get) Token: 0x060000C0 RID: 192 RVA: 0x00004B03 File Offset: 0x00002D03
	// (set) Token: 0x060000C1 RID: 193 RVA: 0x00004B13 File Offset: 0x00002D13
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
	// (get) Token: 0x060000C2 RID: 194 RVA: 0x00004B24 File Offset: 0x00002D24
	// (set) Token: 0x060000C3 RID: 195 RVA: 0x00004B34 File Offset: 0x00002D34
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

	// Token: 0x060000C4 RID: 196 RVA: 0x00004B48 File Offset: 0x00002D48
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

	// Token: 0x060000C5 RID: 197 RVA: 0x00004BB8 File Offset: 0x00002DB8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("PerformConditionCheckAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00004C58 File Offset: 0x00002E58
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

	// Token: 0x060000C7 RID: 199 RVA: 0x00004DD4 File Offset: 0x00002FD4
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

	// Token: 0x060000C8 RID: 200 RVA: 0x00004E3E File Offset: 0x0000303E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorDistanceCheck._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorDistanceCheck.TsDecoratorDistanceCheck_C");
		}
		return TsDecoratorDistanceCheck._ClassPtr;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00004E64 File Offset: 0x00003064
	public TsDecoratorDistanceCheck() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDistanceCheck.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00004E8C File Offset: 0x0000308C
	[NullableContext(1)]
	public TsDecoratorDistanceCheck(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDistanceCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00004EBF File Offset: 0x000030BF
	protected TsDecoratorDistanceCheck(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00004ED4 File Offset: 0x000030D4
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
