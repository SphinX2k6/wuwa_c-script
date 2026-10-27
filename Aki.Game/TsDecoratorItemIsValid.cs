using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.NewWorld.SceneItem.Util;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000049 RID: 73
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorItemIsValid.TsDecoratorItemIsValid_C")]
public class TsDecoratorItemIsValid : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000068 RID: 104
	// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000CB0B File Offset: 0x0000AD0B
	// (set) Token: 0x060002B5 RID: 693 RVA: 0x0000CB1F File Offset: 0x0000AD1F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ItemBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorItemIsValid.__PropertyOffset_ItemBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorItemIsValid.__PropertyOffset_ItemBlackboardKey)), value);
		}
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x0000CB34 File Offset: 0x0000AD34
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsItemBlackboardKey = this.ItemBlackboardKey;
		}
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x0000CB58 File Offset: 0x0000AD58
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

	// Token: 0x060002B8 RID: 696 RVA: 0x0000CBF8 File Offset: 0x0000ADF8
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
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		int? intValueByEntity = BlackboardController.Instance.GetIntValueByEntity(charActorComp.Entity.Id, this.TsItemBlackboardKey);
		Entity entity = EntitySystem.Instance.Get(intValueByEntity.GetValueOrDefault());
		if (entity == null)
		{
			return false;
		}
		SceneItemAiInteractionComponent component = entity.GetComponent<SceneItemAiInteractionComponent>();
		return (component == null || !component.IsSearchByOther(charActorComp.Entity.Id)) && SceneItemUtility.GetBaseItemActor(entity) != null && entity.Active;
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorItemIsValid._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorItemIsValid.TsDecoratorItemIsValid_C");
		}
		return TsDecoratorItemIsValid._ClassPtr;
	}

	// Token: 0x060002BA RID: 698 RVA: 0x0000CCE4 File Offset: 0x0000AEE4
	public TsDecoratorItemIsValid() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorItemIsValid.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060002BB RID: 699 RVA: 0x0000CD0C File Offset: 0x0000AF0C
	public TsDecoratorItemIsValid(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorItemIsValid.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060002BC RID: 700 RVA: 0x0000CD3F File Offset: 0x0000AF3F
	protected TsDecoratorItemIsValid(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060002BD RID: 701 RVA: 0x0000CD54 File Offset: 0x0000AF54
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040001C6 RID: 454
	private bool IsInitTsVariables;

	// Token: 0x040001C7 RID: 455
	private string TsItemBlackboardKey = "";

	// Token: 0x040001C8 RID: 456
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorItemIsValid.TsDecoratorItemIsValid_C";

	// Token: 0x040001C9 RID: 457
	private static IntPtr _ClassPtr;

	// Token: 0x040001CA RID: 458
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040001CB RID: 459
	private static int __PropertyOffset_ItemBlackboardKey;
}
