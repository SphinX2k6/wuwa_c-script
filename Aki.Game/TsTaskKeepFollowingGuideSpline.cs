using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.KeepFollowing;
using CSharpScript.Game;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000062 RID: 98
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Custom/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Custom/TsTaskKeepFollowingGuideSpline.TsTaskKeepFollowingGuideSpline_C")]
public class TsTaskKeepFollowingGuideSpline : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000096 RID: 150
	// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00013EC0 File Offset: 0x000120C0
	// (set) Token: 0x060003FA RID: 1018 RVA: 0x00013EF9 File Offset: 0x000120F9
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<BP_KeepFollowingConfig_C> DataAssetPath
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<BP_KeepFollowingConfig_C> result;
			if ((result = this._DataAssetPath) == null)
			{
				result = (this._DataAssetPath = new TSoftObjectPtr<BP_KeepFollowingConfig_C>(base.NativePtr + (IntPtr)TsTaskKeepFollowingGuideSpline.__PropertyOffset_DataAssetPath, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsTaskKeepFollowingGuideSpline.__PropertyOffset_DataAssetPath, 1);
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x060003FB RID: 1019 RVA: 0x00013F1E File Offset: 0x0001211E
	// (set) Token: 0x060003FC RID: 1020 RVA: 0x00013F2E File Offset: 0x0001212E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SplinePbdataId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskKeepFollowingGuideSpline.__PropertyOffset_SplinePbdataId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskKeepFollowingGuideSpline.__PropertyOffset_SplinePbdataId) = value;
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x060003FD RID: 1021 RVA: 0x00013F3F File Offset: 0x0001213F
	// (set) Token: 0x060003FE RID: 1022 RVA: 0x00013F4F File Offset: 0x0001214F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int WaitingRange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskKeepFollowingGuideSpline.__PropertyOffset_WaitingRange);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskKeepFollowingGuideSpline.__PropertyOffset_WaitingRange) = value;
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x060003FF RID: 1023 RVA: 0x00013F60 File Offset: 0x00012160
	// (set) Token: 0x06000400 RID: 1024 RVA: 0x00013F70 File Offset: 0x00012170
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool SingleLane
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskKeepFollowingGuideSpline.__PropertyOffset_SingleLane) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskKeepFollowingGuideSpline.__PropertyOffset_SingleLane) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x00013F84 File Offset: 0x00012184
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			TSoftObjectPtr<BP_KeepFollowingConfig_C> dataAssetPath = this.DataAssetPath;
			this.TsDataAssetPath = (((dataAssetPath != null) ? dataAssetPath.ToAssetPathName() : null) ?? "");
			this.TsSplinePbdataId = this.SplinePbdataId;
			this.TsWaitingRange = this.WaitingRange;
			this.TsSingleLane = this.SingleLane;
		}
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x00013FEC File Offset: 0x000121EC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskKeepFollowingGuideSpline) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskKeepFollowingGuideSpline.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000403 RID: 1027 RVA: 0x0001409C File Offset: 0x0001229C
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
			string message = "错误的Controller类型 ";
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
			moveToLocationController.StartSplineKeepFollowingWithDataAssetPath(characterActorComponent, tsDataAssetPath, new SplineDistanceParams(this.TsSplinePbdataId, 0f, 0f, (float)this.TsWaitingRange, this.TsSingleLane), delegate(ELevelEventState _)
			{
				if (this.HasStarted)
				{
					this.HasStarted = false;
					base.FinishExecute(true);
				}
			});
		}
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x00014224 File Offset: 0x00012424
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

	// Token: 0x06000405 RID: 1029 RVA: 0x0001424F File Offset: 0x0001244F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskKeepFollowingGuideSpline._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Custom/TsTaskKeepFollowingGuideSpline.TsTaskKeepFollowingGuideSpline_C");
		}
		return TsTaskKeepFollowingGuideSpline._ClassPtr;
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x00014274 File Offset: 0x00012474
	public TsTaskKeepFollowingGuideSpline() : this(BuiltinUtils.AllocNativeUObject(TsTaskKeepFollowingGuideSpline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x0001429C File Offset: 0x0001249C
	public TsTaskKeepFollowingGuideSpline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskKeepFollowingGuideSpline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x000142CF File Offset: 0x000124CF
	protected TsTaskKeepFollowingGuideSpline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x000142E4 File Offset: 0x000124E4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040002B9 RID: 697
	private bool IsInitTsVariables;

	// Token: 0x040002BA RID: 698
	private string TsDataAssetPath = "";

	// Token: 0x040002BB RID: 699
	public int TsSplinePbdataId;

	// Token: 0x040002BC RID: 700
	public int TsWaitingRange;

	// Token: 0x040002BD RID: 701
	private bool TsSingleLane;

	// Token: 0x040002BE RID: 702
	private bool HasStarted;

	// Token: 0x040002BF RID: 703
	[Nullable(2)]
	private BaseMoveComponent MoveComp;

	// Token: 0x040002C0 RID: 704
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Custom/TsTaskKeepFollowingGuideSpline.TsTaskKeepFollowingGuideSpline_C";

	// Token: 0x040002C1 RID: 705
	private static IntPtr _ClassPtr;

	// Token: 0x040002C2 RID: 706
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040002C3 RID: 707
	private static int __PropertyOffset_DataAssetPath;

	// Token: 0x040002C4 RID: 708
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<BP_KeepFollowingConfig_C> _DataAssetPath;

	// Token: 0x040002C5 RID: 709
	private static int __PropertyOffset_SplinePbdataId;

	// Token: 0x040002C6 RID: 710
	private static int __PropertyOffset_WaitingRange;

	// Token: 0x040002C7 RID: 711
	private static int __PropertyOffset_SingleLane;
}
