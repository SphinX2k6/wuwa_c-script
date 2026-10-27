using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.KeepFollowing;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000061 RID: 97
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Custom/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Custom/TsTaskKeepFollowing.TsTaskKeepFollowing_C")]
public class TsTaskKeepFollowing : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000095 RID: 149
	// (get) Token: 0x060003EE RID: 1006 RVA: 0x000132D4 File Offset: 0x000114D4
	// (set) Token: 0x060003EF RID: 1007 RVA: 0x0001330D File Offset: 0x0001150D
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<BP_KeepFollowingConfig_C> DataAssetPath
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<BP_KeepFollowingConfig_C> result;
			if ((result = this._DataAssetPath) == null)
			{
				result = (this._DataAssetPath = new TSoftObjectPtr<BP_KeepFollowingConfig_C>(base.NativePtr + (IntPtr)TsTaskKeepFollowing.__PropertyOffset_DataAssetPath, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsTaskKeepFollowing.__PropertyOffset_DataAssetPath, 1);
		}
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00013332 File Offset: 0x00011532
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			TSoftObjectPtr<BP_KeepFollowingConfig_C> dataAssetPath = this.DataAssetPath;
			this.TsDataAssetPath = (((dataAssetPath != null) ? dataAssetPath.ToAssetPathName() : null) ?? "");
		}
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x0001336C File Offset: 0x0001156C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveExecuteAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x00013408 File Offset: 0x00011608
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
			moveToLocationController.StartKeepFollowingWithDataAssetPath(characterActorComponent, tsDataAssetPath, null, false, null, null);
		}
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x00013578 File Offset: 0x00011778
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

	// Token: 0x060003F4 RID: 1012 RVA: 0x000135A3 File Offset: 0x000117A3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskKeepFollowing._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Custom/TsTaskKeepFollowing.TsTaskKeepFollowing_C");
		}
		return TsTaskKeepFollowing._ClassPtr;
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x000135C8 File Offset: 0x000117C8
	public TsTaskKeepFollowing() : this(BuiltinUtils.AllocNativeUObject(TsTaskKeepFollowing.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x000135F0 File Offset: 0x000117F0
	public TsTaskKeepFollowing(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskKeepFollowing.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x00013623 File Offset: 0x00011823
	protected TsTaskKeepFollowing(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x00013638 File Offset: 0x00011838
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040002B0 RID: 688
	private bool IsInitTsVariables;

	// Token: 0x040002B1 RID: 689
	private string TsDataAssetPath = "";

	// Token: 0x040002B2 RID: 690
	private bool HasStarted;

	// Token: 0x040002B3 RID: 691
	[Nullable(2)]
	private BaseMoveComponent MoveComp;

	// Token: 0x040002B4 RID: 692
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Custom/TsTaskKeepFollowing.TsTaskKeepFollowing_C";

	// Token: 0x040002B5 RID: 693
	private static IntPtr _ClassPtr;

	// Token: 0x040002B6 RID: 694
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040002B7 RID: 695
	private static int __PropertyOffset_DataAssetPath;

	// Token: 0x040002B8 RID: 696
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<BP_KeepFollowingConfig_C> _DataAssetPath;
}
