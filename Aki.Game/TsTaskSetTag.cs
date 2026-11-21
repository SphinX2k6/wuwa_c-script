using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000BE RID: 190
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSetTag.TsTaskSetTag_C")]
public class TsTaskSetTag : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000203 RID: 515
	// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x0003775B File Offset: 0x0003595B
	// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x0003776F File Offset: 0x0003596F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag GameplayTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSetTag.__PropertyOffset_GameplayTag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSetTag.__PropertyOffset_GameplayTag) = value;
		}
	}

	// Token: 0x17000204 RID: 516
	// (get) Token: 0x06000AFA RID: 2810 RVA: 0x00037784 File Offset: 0x00035984
	// (set) Token: 0x06000AFB RID: 2811 RVA: 0x00037798 File Offset: 0x00035998
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ActorTag
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSetTag.__PropertyOffset_ActorTag)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSetTag.__PropertyOffset_ActorTag)), value);
		}
	}

	// Token: 0x17000205 RID: 517
	// (get) Token: 0x06000AFC RID: 2812 RVA: 0x000377AD File Offset: 0x000359AD
	// (set) Token: 0x06000AFD RID: 2813 RVA: 0x000377C1 File Offset: 0x000359C1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string TargetKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSetTag.__PropertyOffset_TargetKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSetTag.__PropertyOffset_TargetKey)), value);
		}
	}

	// Token: 0x17000206 RID: 518
	// (get) Token: 0x06000AFE RID: 2814 RVA: 0x000377D6 File Offset: 0x000359D6
	// (set) Token: 0x06000AFF RID: 2815 RVA: 0x000377E6 File Offset: 0x000359E6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsCommonTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSetTag.__PropertyOffset_IsCommonTag) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSetTag.__PropertyOffset_IsCommonTag) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000207 RID: 519
	// (get) Token: 0x06000B00 RID: 2816 RVA: 0x000377F7 File Offset: 0x000359F7
	// (set) Token: 0x06000B01 RID: 2817 RVA: 0x00037807 File Offset: 0x00035A07
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsAdd
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSetTag.__PropertyOffset_IsAdd) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSetTag.__PropertyOffset_IsAdd) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000208 RID: 520
	// (get) Token: 0x06000B02 RID: 2818 RVA: 0x00037818 File Offset: 0x00035A18
	// (set) Token: 0x06000B03 RID: 2819 RVA: 0x00037828 File Offset: 0x00035A28
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool SetToPlayer
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSetTag.__PropertyOffset_SetToPlayer) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSetTag.__PropertyOffset_SetToPlayer) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x0003783C File Offset: 0x00035A3C
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsGameplayTag = new FGameplayTag?(this.GameplayTag);
			this.TsActorTag = FNameUtil.GetDynamicFName(this.ActorTag);
			this.TsTargetKey = this.TargetKey;
			this.TsIsCommonTag = this.IsCommonTag;
			this.TsIsAdd = this.IsAdd;
			this.TsSetToPlayer = this.SetToPlayer;
		}
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x000378B4 File Offset: 0x00035AB4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskSetTag) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskSetTag.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x0003796C File Offset: 0x00035B6C
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		this.InitTsVariables();
		if (this.TsGameplayTag == null && this.TsActorTag == null)
		{
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null || !charActorComp.Valid)
		{
			base.FinishExecute(false);
			return;
		}
		Entity entity = charActorComp.Entity;
		if (this.TsSetToPlayer)
		{
			entity = Global.BaseCharacter.CharacterActorComponent.Entity;
		}
		else if (this.TsTargetKey != "")
		{
			int? num = BlackboardController.Instance.GetIntValueByWorld(this.TsTargetKey);
			if (num == null || num.Value == 0)
			{
				num = BlackboardController.Instance.GetEntityIdByEntity(charActorComp.Entity.Id, this.TsTargetKey);
			}
			if (num != null && num.Value != 0)
			{
				entity = EntitySystem.Instance.Get(num.Value);
			}
			else
			{
				entity = null;
			}
		}
		if (entity == null)
		{
			base.FinishExecute(false);
			return;
		}
		if (this.TsGameplayTag != null)
		{
			this.SetGameplayTag(entity);
		}
		else
		{
			BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
			if (component != null)
			{
				TArray<FName> tags = component.Owner.Tags;
				TArray<FName> tarray = tags;
				FName value = this.TsActorTag.Value;
				int num2 = tarray.FindIndex(value);
				if (this.TsIsAdd && num2 < 0)
				{
					tags.Add(this.TsActorTag.Value);
				}
				else if (num2 > -1)
				{
					tags.RemoveAt(num2);
				}
			}
		}
		base.FinishExecute(true);
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x00037B38 File Offset: 0x00035D38
	private void SetGameplayTag(Entity entity)
	{
		if (this.TsIsCommonTag)
		{
			LevelTagComponent component = entity.GetComponent<LevelTagComponent>();
			if (component != null)
			{
				int num = this.TsGameplayTag.Value.TagId();
				bool flag = component.HasTag(num);
				if (this.TsIsAdd && !flag)
				{
					component.AddTag(new int?(num));
				}
				else if (!this.TsIsAdd && flag)
				{
					component.RemoveTag(new int?(num));
				}
			}
		}
		BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
		if (component2 != null)
		{
			int num2 = this.TsGameplayTag.Value.TagId();
			bool flag2 = component2.HasTag(num2);
			if (this.TsIsAdd && !flag2)
			{
				component2.AddTag(new int?(num2));
				return;
			}
			if (!this.TsIsAdd && flag2)
			{
				component2.RemoveTag(new int?(num2));
			}
		}
	}

	// Token: 0x06000B08 RID: 2824 RVA: 0x00037BFF File Offset: 0x00035DFF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskSetTag._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSetTag.TsTaskSetTag_C");
		}
		return TsTaskSetTag._ClassPtr;
	}

	// Token: 0x06000B09 RID: 2825 RVA: 0x00037C24 File Offset: 0x00035E24
	public TsTaskSetTag() : this(BuiltinUtils.AllocNativeUObject(TsTaskSetTag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000B0A RID: 2826 RVA: 0x00037C4C File Offset: 0x00035E4C
	public TsTaskSetTag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSetTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x00037C7F File Offset: 0x00035E7F
	protected TsTaskSetTag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x00037C94 File Offset: 0x00035E94
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000898 RID: 2200
	private bool IsInitTsVariables;

	// Token: 0x04000899 RID: 2201
	private FGameplayTag? TsGameplayTag;

	// Token: 0x0400089A RID: 2202
	private FName? TsActorTag;

	// Token: 0x0400089B RID: 2203
	private string TsTargetKey = "";

	// Token: 0x0400089C RID: 2204
	private bool TsIsCommonTag;

	// Token: 0x0400089D RID: 2205
	private bool TsIsAdd;

	// Token: 0x0400089E RID: 2206
	private bool TsSetToPlayer;

	// Token: 0x0400089F RID: 2207
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSetTag.TsTaskSetTag_C";

	// Token: 0x040008A0 RID: 2208
	private static IntPtr _ClassPtr;

	// Token: 0x040008A1 RID: 2209
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040008A2 RID: 2210
	private static int __PropertyOffset_GameplayTag;

	// Token: 0x040008A3 RID: 2211
	private static int __PropertyOffset_ActorTag;

	// Token: 0x040008A4 RID: 2212
	private static int __PropertyOffset_TargetKey;

	// Token: 0x040008A5 RID: 2213
	private static int __PropertyOffset_IsCommonTag;

	// Token: 0x040008A6 RID: 2214
	private static int __PropertyOffset_IsAdd;

	// Token: 0x040008A7 RID: 2215
	private static int __PropertyOffset_SetToPlayer;
}
