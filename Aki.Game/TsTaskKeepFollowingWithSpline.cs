using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.KeepFollowing;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000063 RID: 99
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Custom/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Custom/TsTaskKeepFollowingWithSpline.TsTaskKeepFollowingWithSpline_C")]
public class TsTaskKeepFollowingWithSpline : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700009A RID: 154
	// (get) Token: 0x0600040B RID: 1035 RVA: 0x0001432C File Offset: 0x0001252C
	// (set) Token: 0x0600040C RID: 1036 RVA: 0x00014365 File Offset: 0x00012565
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<BP_KeepFollowingConfig_C> DataAssetPath
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<BP_KeepFollowingConfig_C> result;
			if ((result = this._DataAssetPath) == null)
			{
				result = (this._DataAssetPath = new TSoftObjectPtr<BP_KeepFollowingConfig_C>(base.NativePtr + (IntPtr)TsTaskKeepFollowingWithSpline.__PropertyOffset_DataAssetPath, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsTaskKeepFollowingWithSpline.__PropertyOffset_DataAssetPath, 1);
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x0600040D RID: 1037 RVA: 0x0001438A File Offset: 0x0001258A
	// (set) Token: 0x0600040E RID: 1038 RVA: 0x0001439A File Offset: 0x0001259A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SplinePbdataId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskKeepFollowingWithSpline.__PropertyOffset_SplinePbdataId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskKeepFollowingWithSpline.__PropertyOffset_SplinePbdataId) = value;
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x0600040F RID: 1039 RVA: 0x000143AB File Offset: 0x000125AB
	// (set) Token: 0x06000410 RID: 1040 RVA: 0x000143BB File Offset: 0x000125BB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int EnterRange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskKeepFollowingWithSpline.__PropertyOffset_EnterRange);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskKeepFollowingWithSpline.__PropertyOffset_EnterRange) = value;
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x06000411 RID: 1041 RVA: 0x000143CC File Offset: 0x000125CC
	// (set) Token: 0x06000412 RID: 1042 RVA: 0x000143DC File Offset: 0x000125DC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int ExitRange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskKeepFollowingWithSpline.__PropertyOffset_ExitRange);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskKeepFollowingWithSpline.__PropertyOffset_ExitRange) = value;
		}
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x000143F0 File Offset: 0x000125F0
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			TSoftObjectPtr<BP_KeepFollowingConfig_C> dataAssetPath = this.DataAssetPath;
			this.TsDataAssetPath = (((dataAssetPath != null) ? dataAssetPath.ToAssetPathName() : null) ?? "");
			this.TsSplinePbdataId = this.SplinePbdataId;
			this.TsEnterRange = this.EnterRange;
			this.TsExitRange = this.ExitRange;
		}
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x00014458 File Offset: 0x00012658
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskKeepFollowingWithSpline) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskKeepFollowingWithSpline.StaticClass(), out intPtr, out num))
		{
			this.ReceiveExecuteAI_Implementation(ownerController, controlledPawn);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x00014508 File Offset: 0x00012708
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ((ownerController != null) ? ownerController.GetClass().GetName() : null) ?? "Unknown");
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		string tsDataAssetPath = this.TsDataAssetPath;
		if (string.IsNullOrEmpty(tsDataAssetPath))
		{
			Log.Instance.Warn(ELogModule.BehaviorTree, ELogAuthor.CWZ, "DataAssetPath为空，无法启动持续跟随", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.FinishExecute(false);
			return;
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
		if (characterActorComponent == null)
		{
			Log.Instance.Warn(ELogModule.BehaviorTree, ELogAuthor.CWZ, "不存在玩家CharacterActorComponent，无法启动持续跟随", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		BaseMoveComponent moveComp;
		if (charActorComp == null)
		{
			moveComp = null;
		}
		else
		{
			Entity entity = charActorComp.Entity;
			moveComp = ((entity != null) ? entity.GetComponent<BaseMoveComponent>() : null);
		}
		this.MoveComp = moveComp;
		BaseMoveComponent moveComp2 = this.MoveComp;
		MoveToLocationController moveToLocationController = (moveComp2 != null) ? moveComp2.MoveController : null;
		if (moveToLocationController == null)
		{
			Log.Instance.Warn(ELogModule.BehaviorTree, ELogAuthor.CWZ, "MoveController无效，无法启动持续跟随", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.FinishExecute(false);
			return;
		}
		if (!this.HasStarted)
		{
			this.HasStarted = true;
			moveToLocationController.StartSplineKeepFollowingWithDataAssetPath(characterActorComponent, tsDataAssetPath, new SplineDistanceParams(this.TsSplinePbdataId, (float)this.TsEnterRange, (float)this.TsExitRange, (float)this.TsExitRange, false), null);
		}
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x00014684 File Offset: 0x00012884
	protected override void OnClear()
	{
		if (this.HasStarted)
		{
			this.HasStarted = false;
			BaseMoveComponent moveComp = this.MoveComp;
			if (moveComp == null)
			{
				return;
			}
			MoveToLocationController moveController = moveComp.MoveController;
			if (moveController == null)
			{
				return;
			}
			moveController.StopKeepHoldingHands();
		}
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x000146AF File Offset: 0x000128AF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskKeepFollowingWithSpline._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Custom/TsTaskKeepFollowingWithSpline.TsTaskKeepFollowingWithSpline_C");
		}
		return TsTaskKeepFollowingWithSpline._ClassPtr;
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x000146D4 File Offset: 0x000128D4
	public TsTaskKeepFollowingWithSpline() : this(BuiltinUtils.AllocNativeUObject(TsTaskKeepFollowingWithSpline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x000146FC File Offset: 0x000128FC
	public TsTaskKeepFollowingWithSpline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskKeepFollowingWithSpline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x0001472F File Offset: 0x0001292F
	protected TsTaskKeepFollowingWithSpline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x00014744 File Offset: 0x00012944
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040002C8 RID: 712
	private bool IsInitTsVariables;

	// Token: 0x040002C9 RID: 713
	private string TsDataAssetPath = "";

	// Token: 0x040002CA RID: 714
	public int TsSplinePbdataId;

	// Token: 0x040002CB RID: 715
	public int TsEnterRange;

	// Token: 0x040002CC RID: 716
	public int TsExitRange;

	// Token: 0x040002CD RID: 717
	private bool HasStarted;

	// Token: 0x040002CE RID: 718
	[Nullable(2)]
	private BaseMoveComponent MoveComp;

	// Token: 0x040002CF RID: 719
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Custom/TsTaskKeepFollowingWithSpline.TsTaskKeepFollowingWithSpline_C";

	// Token: 0x040002D0 RID: 720
	private static IntPtr _ClassPtr;

	// Token: 0x040002D1 RID: 721
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040002D2 RID: 722
	private static int __PropertyOffset_DataAssetPath;

	// Token: 0x040002D3 RID: 723
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<BP_KeepFollowingConfig_C> _DataAssetPath;

	// Token: 0x040002D4 RID: 724
	private static int __PropertyOffset_SplinePbdataId;

	// Token: 0x040002D5 RID: 725
	private static int __PropertyOffset_EnterRange;

	// Token: 0x040002D6 RID: 726
	private static int __PropertyOffset_ExitRange;
}
