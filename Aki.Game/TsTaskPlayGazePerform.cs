using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000AF RID: 175
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayGazePerform.TsTaskPlayGazePerform_C")]
public class TsTaskPlayGazePerform : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00031778 File Offset: 0x0002F978
	// (set) Token: 0x060009CA RID: 2506 RVA: 0x000317B1 File Offset: 0x0002F9B1
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UAnimMontage> PerceptionMontage
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UAnimMontage> result;
			if ((result = this._PerceptionMontage) == null)
			{
				result = (this._PerceptionMontage = new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)TsTaskPlayGazePerform.__PropertyOffset_PerceptionMontage, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsTaskPlayGazePerform.__PropertyOffset_PerceptionMontage, 1);
		}
	}

	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x060009CB RID: 2507 RVA: 0x000317D8 File Offset: 0x0002F9D8
	// (set) Token: 0x060009CC RID: 2508 RVA: 0x00031811 File Offset: 0x0002FA11
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UAnimMontage> TurnPerformLeft90
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UAnimMontage> result;
			if ((result = this._TurnPerformLeft90) == null)
			{
				result = (this._TurnPerformLeft90 = new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)TsTaskPlayGazePerform.__PropertyOffset_TurnPerformLeft90, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsTaskPlayGazePerform.__PropertyOffset_TurnPerformLeft90, 1);
		}
	}

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x060009CD RID: 2509 RVA: 0x00031838 File Offset: 0x0002FA38
	// (set) Token: 0x060009CE RID: 2510 RVA: 0x00031871 File Offset: 0x0002FA71
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UAnimMontage> TurnPerformLeft180
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UAnimMontage> result;
			if ((result = this._TurnPerformLeft180) == null)
			{
				result = (this._TurnPerformLeft180 = new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)TsTaskPlayGazePerform.__PropertyOffset_TurnPerformLeft180, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsTaskPlayGazePerform.__PropertyOffset_TurnPerformLeft180, 1);
		}
	}

	// Token: 0x170001BB RID: 443
	// (get) Token: 0x060009CF RID: 2511 RVA: 0x00031898 File Offset: 0x0002FA98
	// (set) Token: 0x060009D0 RID: 2512 RVA: 0x000318D1 File Offset: 0x0002FAD1
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UAnimMontage> TurnPerformRight90
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UAnimMontage> result;
			if ((result = this._TurnPerformRight90) == null)
			{
				result = (this._TurnPerformRight90 = new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)TsTaskPlayGazePerform.__PropertyOffset_TurnPerformRight90, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsTaskPlayGazePerform.__PropertyOffset_TurnPerformRight90, 1);
		}
	}

	// Token: 0x170001BC RID: 444
	// (get) Token: 0x060009D1 RID: 2513 RVA: 0x000318F8 File Offset: 0x0002FAF8
	// (set) Token: 0x060009D2 RID: 2514 RVA: 0x00031931 File Offset: 0x0002FB31
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UAnimMontage> TurnPerformRight180
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UAnimMontage> result;
			if ((result = this._TurnPerformRight180) == null)
			{
				result = (this._TurnPerformRight180 = new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)TsTaskPlayGazePerform.__PropertyOffset_TurnPerformRight180, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsTaskPlayGazePerform.__PropertyOffset_TurnPerformRight180, 1);
		}
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x00031958 File Offset: 0x0002FB58
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			TSoftObjectPtr<UAnimMontage> perceptionMontage = this.PerceptionMontage;
			this.TsPerceptionMontage = (((perceptionMontage != null) ? perceptionMontage.ToAssetPathName() : null) ?? "");
			TSoftObjectPtr<UAnimMontage> turnPerformLeft = this.TurnPerformLeft90;
			this.TsTurnPerformLeft90 = (((turnPerformLeft != null) ? turnPerformLeft.ToAssetPathName() : null) ?? "");
			TSoftObjectPtr<UAnimMontage> turnPerformLeft2 = this.TurnPerformLeft180;
			this.TsTurnPerformLeft180 = (((turnPerformLeft2 != null) ? turnPerformLeft2.ToAssetPathName() : null) ?? "");
			TSoftObjectPtr<UAnimMontage> turnPerformRight = this.TurnPerformRight90;
			this.TsTurnPerformRight90 = (((turnPerformRight != null) ? turnPerformRight.ToAssetPathName() : null) ?? "");
			TSoftObjectPtr<UAnimMontage> turnPerformRight2 = this.TurnPerformRight180;
			this.TsTurnPerformRight180 = (((turnPerformRight2 != null) ? turnPerformRight2.ToAssetPathName() : null) ?? "");
		}
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x00031A24 File Offset: 0x0002FC24
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

	// Token: 0x060009D5 RID: 2517 RVA: 0x00031AC0 File Offset: 0x0002FCC0
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		AiController aiController = this.GetAiController(ownerController);
		if (aiController == null)
		{
			this.LogInvalidController(ownerController);
			base.Finish(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		Entity entity = (charActorComp != null) ? charActorComp.Entity : null;
		if (charActorComp == null || !charActorComp.Valid || entity == null)
		{
			base.Finish(false);
			return;
		}
		CharacterCustomActionComponent component = entity.GetComponent<CharacterCustomActionComponent>();
		if (!this.CheckCustomActionComp(entity.Id, component))
		{
			base.Finish(false);
			return;
		}
		CharacterAnimationComponent component2 = entity.GetComponent<CharacterAnimationComponent>();
		if (!this.CheckAnimationComp(entity.Id, component2 != null && component2.Valid))
		{
			base.Finish(false);
			return;
		}
		this.AiActorComp = charActorComp;
		this.CustomActionComp = component;
		this.IsTaskRunning = true;
		if (this.HasMontage(this.TsPerceptionMontage))
		{
			component.AddCustomPlayMontage(this.TsPerceptionMontage, null, null, null, new Action(this.OnPerceptionFinished));
			return;
		}
		this.EnqueueTurnPerform();
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x00031BB5 File Offset: 0x0002FDB5
	protected override void OnAbort()
	{
		this.IsTaskRunning = false;
		CharacterCustomActionComponent customActionComp = this.CustomActionComp;
		if (customActionComp == null)
		{
			return;
		}
		customActionComp.AbortAllAction(false);
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x00031BCF File Offset: 0x0002FDCF
	protected override void OnClear()
	{
		this.CustomActionComp = null;
		this.AiActorComp = null;
		this.IsTaskRunning = false;
		Vector endForward = this.EndForward;
		if (endForward == null)
		{
			return;
		}
		endForward.Reset();
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x00031BF6 File Offset: 0x0002FDF6
	private void OnPerceptionFinished()
	{
		if (!this.IsTaskRunning)
		{
			return;
		}
		this.EnqueueTurnPerform();
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x00031C07 File Offset: 0x0002FE07
	private void OnTurnPerformFinished()
	{
		if (!this.IsTaskRunning)
		{
			return;
		}
		base.Finish(true);
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x00031C1C File Offset: 0x0002FE1C
	private void EnqueueTurnPerform()
	{
		if (!this.IsTaskRunning)
		{
			return;
		}
		string path = this.SelectTurnPerformPath();
		if (!this.HasMontage(path))
		{
			base.Finish(true);
			return;
		}
		this.UpdateFacingToPlayer();
		CharacterCustomActionComponent customActionComp = this.CustomActionComp;
		if (customActionComp == null)
		{
			return;
		}
		customActionComp.AddCustomPlayMontage(path, null, null, null, new Action(this.OnTurnPerformFinished));
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x00031C78 File Offset: 0x0002FE78
	private string SelectTurnPerformPath()
	{
		CharacterActorComponent aiActorComp = this.AiActorComp;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
		if (aiActorComp == null || !aiActorComp.Valid || (characterActorComponent == null || !characterActorComponent.Valid))
		{
			return "";
		}
		Vector vector = Vector.Create();
		characterActorComponent.ActorLocationProxy.Subtraction(aiActorComp.ActorLocationProxy, vector);
		vector.Z = 0.0;
		if (!vector.Normalize(1E-08))
		{
			return "";
		}
		float angleOffsetInGravityForActor = GravityUtils.Instance.GetAngleOffsetInGravityForActor(aiActorComp, aiActorComp.ActorForwardProxy, vector);
		bool flag = angleOffsetInGravityForActor < 0f;
		if (Math.Abs(angleOffsetInGravityForActor) >= 90f)
		{
			if (!flag)
			{
				return this.TsTurnPerformRight180;
			}
			return this.TsTurnPerformLeft180;
		}
		else
		{
			if (!flag)
			{
				return this.TsTurnPerformRight90;
			}
			return this.TsTurnPerformLeft90;
		}
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x00031D54 File Offset: 0x0002FF54
	private void UpdateFacingToPlayer()
	{
		CharacterActorComponent aiActorComp = this.AiActorComp;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
		if (aiActorComp == null || !aiActorComp.Valid || (characterActorComponent == null || !characterActorComponent.Valid))
		{
			return;
		}
		if (this.EndForward == null)
		{
			this.EndForward = Vector.Create();
		}
		characterActorComponent.ActorLocationProxy.Subtraction(aiActorComp.ActorLocationProxy, this.EndForward);
		this.EndForward.Z = 0.0;
		if (!this.EndForward.Normalize(1E-08))
		{
			return;
		}
		aiActorComp.SetInputFacing(this.EndForward, true);
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x00031E05 File Offset: 0x00030005
	private bool HasMontage(string path)
	{
		return path.Length > 0;
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x00031E10 File Offset: 0x00030010
	[NullableContext(2)]
	private AiController GetAiController(AAIController ownerController)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		if (tsAiController == null)
		{
			return null;
		}
		return tsAiController.AiController;
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x00031E30 File Offset: 0x00030030
	[NullableContext(2)]
	private void LogInvalidController(AAIController ownerController)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.BehaviorTree;
		ELogAuthor author = ELogAuthor.ZJL;
		string message = "错误的Controller类型";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ((ownerController != null) ? ownerController.GetClass().GetName() : null) ?? "undefined");
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x00031E80 File Offset: 0x00030080
	[NullableContext(2)]
	private bool CheckCustomActionComp(int entityId, CharacterCustomActionComponent customActionComp)
	{
		if (customActionComp != null && customActionComp.Valid)
		{
			return true;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.BehaviorTree;
		ELogAuthor author = ELogAuthor.ZJL;
		string message = "播放注视表演失败，缺少定制行为组件";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", entityId);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return false;
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x00031EC8 File Offset: 0x000300C8
	private bool CheckAnimationComp(int entityId, bool hasAnimationComp)
	{
		if (hasAnimationComp)
		{
			return true;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.BehaviorTree;
		ELogAuthor author = ELogAuthor.ZJL;
		string message = "播放注视表演失败，缺少动画组件";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", entityId);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return false;
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00031F07 File Offset: 0x00030107
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPlayGazePerform._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayGazePerform.TsTaskPlayGazePerform_C");
		}
		return TsTaskPlayGazePerform._ClassPtr;
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x00031F2C File Offset: 0x0003012C
	public TsTaskPlayGazePerform() : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayGazePerform.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x00031F54 File Offset: 0x00030154
	public TsTaskPlayGazePerform(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayGazePerform.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x00031F87 File Offset: 0x00030187
	protected TsTaskPlayGazePerform(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x00031FC8 File Offset: 0x000301C8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400078C RID: 1932
	private const float TURN_PERFORM_ANGLE_THRESHOLD = 90f;

	// Token: 0x0400078D RID: 1933
	private bool IsInitTsVariables;

	// Token: 0x0400078E RID: 1934
	private string TsPerceptionMontage = "";

	// Token: 0x0400078F RID: 1935
	private string TsTurnPerformLeft90 = "";

	// Token: 0x04000790 RID: 1936
	private string TsTurnPerformLeft180 = "";

	// Token: 0x04000791 RID: 1937
	private string TsTurnPerformRight90 = "";

	// Token: 0x04000792 RID: 1938
	private string TsTurnPerformRight180 = "";

	// Token: 0x04000793 RID: 1939
	[Nullable(2)]
	private CharacterCustomActionComponent CustomActionComp;

	// Token: 0x04000794 RID: 1940
	[Nullable(2)]
	private CharacterActorComponent AiActorComp;

	// Token: 0x04000795 RID: 1941
	private bool IsTaskRunning;

	// Token: 0x04000796 RID: 1942
	[Nullable(2)]
	private Vector EndForward;

	// Token: 0x04000797 RID: 1943
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayGazePerform.TsTaskPlayGazePerform_C";

	// Token: 0x04000798 RID: 1944
	private static IntPtr _ClassPtr;

	// Token: 0x04000799 RID: 1945
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400079A RID: 1946
	private static int __PropertyOffset_PerceptionMontage;

	// Token: 0x0400079B RID: 1947
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAnimMontage> _PerceptionMontage;

	// Token: 0x0400079C RID: 1948
	private static int __PropertyOffset_TurnPerformLeft90;

	// Token: 0x0400079D RID: 1949
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAnimMontage> _TurnPerformLeft90;

	// Token: 0x0400079E RID: 1950
	private static int __PropertyOffset_TurnPerformLeft180;

	// Token: 0x0400079F RID: 1951
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAnimMontage> _TurnPerformLeft180;

	// Token: 0x040007A0 RID: 1952
	private static int __PropertyOffset_TurnPerformRight90;

	// Token: 0x040007A1 RID: 1953
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAnimMontage> _TurnPerformRight90;

	// Token: 0x040007A2 RID: 1954
	private static int __PropertyOffset_TurnPerformRight180;

	// Token: 0x040007A3 RID: 1955
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAnimMontage> _TurnPerformRight180;
}
