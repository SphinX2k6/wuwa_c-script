using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000038 RID: 56
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckInbound.TsDecoratorCheckInbound_C")]
public class TsDecoratorCheckInbound : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000054 RID: 84
	// (get) Token: 0x06000201 RID: 513 RVA: 0x0000A08C File Offset: 0x0000828C
	// (set) Token: 0x06000202 RID: 514 RVA: 0x0000A0C5 File Offset: 0x000082C5
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<string, float> SocketHeight
	{
		get
		{
			base.FastCheckIsValid();
			TMap<string, float> result;
			if ((result = this._SocketHeight) == null)
			{
				result = (this._SocketHeight = new TMap<string, float>(base.NativePtr + (IntPtr)TsDecoratorCheckInbound.__PropertyOffset_SocketHeight, this));
			}
			return result;
		}
		set
		{
			this.SocketHeight.CopyAssign(value);
		}
	}

	// Token: 0x06000203 RID: 515 RVA: 0x0000A0D3 File Offset: 0x000082D3
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.LastCheckResult = true;
			this.LastCheckTimeStamp = 0.0;
			this.InitData();
		}
	}

	// Token: 0x06000204 RID: 516 RVA: 0x0000A108 File Offset: 0x00008308
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorCheckInbound) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorCheckInbound.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000205 RID: 517 RVA: 0x0000A1C0 File Offset: 0x000083C0
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		if ((ownerController as TsAiController).AiController == null)
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
		this.InitTraceElement();
		if (Time.Instance.WorldTime < this.LastCheckTimeStamp + 200.0)
		{
			return this.LastCheckResult;
		}
		this.LastCheckTimeStamp = Time.Instance.WorldTime;
		USkeletalMeshComponent skeletalMesh = (ownerController as TsAiController).AiController.CharActorComp.SkeletalMesh;
		Vector vector = Vector.Create();
		bool flag = true;
		foreach (KeyValuePair<string, float> keyValuePair in this.SocketHeightInternal)
		{
			string text;
			float num;
			keyValuePair.Deconstruct(out text, out num);
			string key = text;
			float height = num;
			Vector vector2 = vector;
			FVectorDouble fvectorDouble = skeletalMesh.D_GetSocketLocation(FNameUtil.GetDynamicFName(key).Value);
			vector2.FromUeVector(fvectorDouble);
			flag = (flag && this.CheckInbound(vector, height));
		}
		this.LastCheckResult = flag;
		return flag;
	}

	// Token: 0x06000206 RID: 518 RVA: 0x0000A2FC File Offset: 0x000084FC
	private void InitTraceElement()
	{
		if (this.TsTraceElement == null)
		{
			this.TsTraceElement = new UTraceLineElement();
			this.TsTraceElement.bIsSingle = true;
			this.TsTraceElement.bIgnoreSelf = true;
			this.TsTraceElement.SetTraceTypeQuery(KuroTraceTypeQuery.Visible);
		}
		this.TsTraceElement.WorldContextObject = this.GetWorld();
	}

	// Token: 0x06000207 RID: 519 RVA: 0x0000A358 File Offset: 0x00008558
	private void InitData()
	{
		if (this.SocketHeightInternal == null)
		{
			int num = this.SocketHeight.Num();
			this.SocketHeightInternal = new Dictionary<string, float>(num);
			if (num > 0)
			{
				foreach (KeyValuePair<string, float> keyValuePair in this.SocketHeight)
				{
					string text;
					float num2;
					keyValuePair.Deconstruct(out text, out num2);
					string key = text;
					float value = num2;
					this.SocketHeightInternal.Add(key, value);
				}
			}
		}
	}

	// Token: 0x06000208 RID: 520 RVA: 0x0000A3E8 File Offset: 0x000085E8
	private bool CheckInbound(Vector location, float height)
	{
		TraceElementCommon.Instance.SetStartLocation(this.TsTraceElement, location);
		Vector vector = Vector.Create();
		Vector.DownVectorProxy.Multiply((double)height, vector);
		vector.AdditionEqual(location);
		TraceElementCommon.Instance.SetEndLocation(this.TsTraceElement, vector);
		return TraceElementCommon.Instance.LineTrace(this.TsTraceElement, "TsDecoratorCheckInbound") && this.TsTraceElement.HitResult.bBlockingHit;
	}

	// Token: 0x06000209 RID: 521 RVA: 0x0000A45F File Offset: 0x0000865F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckInbound._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckInbound.TsDecoratorCheckInbound_C");
		}
		return TsDecoratorCheckInbound._ClassPtr;
	}

	// Token: 0x0600020A RID: 522 RVA: 0x0000A484 File Offset: 0x00008684
	public TsDecoratorCheckInbound() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckInbound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600020B RID: 523 RVA: 0x0000A4AC File Offset: 0x000086AC
	public TsDecoratorCheckInbound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckInbound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600020C RID: 524 RVA: 0x0000A4DF File Offset: 0x000086DF
	protected TsDecoratorCheckInbound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600020D RID: 525 RVA: 0x0000A4E8 File Offset: 0x000086E8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000156 RID: 342
	private const string PROFILE_KEY = "TsDecoratorCheckInbound";

	// Token: 0x04000157 RID: 343
	private const int MIN_CEHCK_TIME_INTERVAL = 200;

	// Token: 0x04000158 RID: 344
	private bool IsInitTsVariables;

	// Token: 0x04000159 RID: 345
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<string, float> SocketHeightInternal;

	// Token: 0x0400015A RID: 346
	[Nullable(2)]
	private UTraceLineElement TsTraceElement;

	// Token: 0x0400015B RID: 347
	private bool LastCheckResult;

	// Token: 0x0400015C RID: 348
	private double LastCheckTimeStamp;

	// Token: 0x0400015D RID: 349
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckInbound.TsDecoratorCheckInbound_C";

	// Token: 0x0400015E RID: 350
	private static IntPtr _ClassPtr;

	// Token: 0x0400015F RID: 351
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000160 RID: 352
	private static int __PropertyOffset_SocketHeight;

	// Token: 0x04000161 RID: 353
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<string, float> _SocketHeight;
}
