using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuickTimeAction;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C7 RID: 455
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyQta.TsAnimNotifyQta_C")]
public class TsAnimNotifyQta : UKuroAnimNotify, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700048C RID: 1164
	// (get) Token: 0x06001C6F RID: 7279 RVA: 0x00090EE7 File Offset: 0x0008F0E7
	// (set) Token: 0x06001C70 RID: 7280 RVA: 0x00090EF7 File Offset: 0x0008F0F7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int QtaId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyQta.__PropertyOffset_QtaId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyQta.__PropertyOffset_QtaId) = value;
		}
	}

	// Token: 0x1700048D RID: 1165
	// (get) Token: 0x06001C71 RID: 7281 RVA: 0x00090F08 File Offset: 0x0008F108
	// (set) Token: 0x06001C72 RID: 7282 RVA: 0x00090F18 File Offset: 0x0008F118
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 当前实体为玩家控制时才触发
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyQta.__PropertyOffset_当前实体为玩家控制时才触发) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyQta.__PropertyOffset_当前实体为玩家控制时才触发) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700048E RID: 1166
	// (get) Token: 0x06001C73 RID: 7283 RVA: 0x00090F29 File Offset: 0x0008F129
	// (set) Token: 0x06001C74 RID: 7284 RVA: 0x00090F3D File Offset: 0x0008F13D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag 存在Tag时才触发
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyQta.__PropertyOffset_存在Tag时才触发);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyQta.__PropertyOffset_存在Tag时才触发) = value;
		}
	}

	// Token: 0x1700048F RID: 1167
	// (get) Token: 0x06001C75 RID: 7285 RVA: 0x00090F52 File Offset: 0x0008F152
	// (set) Token: 0x06001C76 RID: 7286 RVA: 0x00090F62 File Offset: 0x0008F162
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 开始时直接结束其它Qta
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyQta.__PropertyOffset_开始时直接结束其它Qta) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyQta.__PropertyOffset_开始时直接结束其它Qta) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001C77 RID: 7287 RVA: 0x00090F74 File Offset: 0x0008F174
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

	// Token: 0x06001C78 RID: 7288 RVA: 0x00091014 File Offset: 0x0008F214
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (this.当前实体为玩家控制时才触发 && (characterActorComponent == null || !characterActorComponent.Valid || !characterActorComponent.IsAutonomousProxy))
		{
			return false;
		}
		if (!string.IsNullOrEmpty(this.存在Tag时才触发.TagName.ToString()) && this.存在Tag时才触发.TagName != "None")
		{
			BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent == null || !baseTagComponent.HasTag(this.存在Tag时才触发.TagId()))
			{
				return false;
			}
		}
		EntityHandle handleByEntity = CharacterModel.Instance.GetHandleByEntity(entity);
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		long? num = (baseBuffComponent != null) ? baseBuffComponent.CreateAnimNotifyContent(animation.GetName(), base.exportIndex) : null;
		if (handleByEntity != null && num != null)
		{
			if (this.开始时直接结束其它Qta)
			{
				QtaController.Instance.StopCurrentQta();
			}
			QtaController.Instance.StartQta(this.QtaId, null, EQtaSource.AnimNotify, new IQtaExtraParams
			{
				MessageId = new long?(num.Value),
				EntityHandle = handleByEntity
			});
		}
		return true;
	}

	// Token: 0x06001C79 RID: 7289 RVA: 0x0009115C File Offset: 0x0008F35C
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

	// Token: 0x06001C7A RID: 7290 RVA: 0x000911D7 File Offset: 0x0008F3D7
	protected override string GetNotifyName_Implementation()
	{
		return "特殊交互QTA";
	}

	// Token: 0x06001C7B RID: 7291 RVA: 0x000911DE File Offset: 0x0008F3DE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyQta._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyQta.TsAnimNotifyQta_C");
		}
		return TsAnimNotifyQta._ClassPtr;
	}

	// Token: 0x06001C7C RID: 7292 RVA: 0x00091204 File Offset: 0x0008F404
	public TsAnimNotifyQta() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyQta.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C7D RID: 7293 RVA: 0x0009122C File Offset: 0x0008F42C
	public TsAnimNotifyQta(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyQta.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C7E RID: 7294 RVA: 0x0009125F File Offset: 0x0008F45F
	protected TsAnimNotifyQta(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C7F RID: 7295 RVA: 0x00091268 File Offset: 0x0008F468
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C80 RID: 7296 RVA: 0x0009129B File Offset: 0x0008F49B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011E7 RID: 4583
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyQta.TsAnimNotifyQta_C";

	// Token: 0x040011E8 RID: 4584
	private static IntPtr _ClassPtr;

	// Token: 0x040011E9 RID: 4585
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011EA RID: 4586
	private static int __PropertyOffset_QtaId;

	// Token: 0x040011EB RID: 4587
	private static int __PropertyOffset_当前实体为玩家控制时才触发;

	// Token: 0x040011EC RID: 4588
	private static int __PropertyOffset_存在Tag时才触发;

	// Token: 0x040011ED RID: 4589
	private static int __PropertyOffset_开始时直接结束其它Qta;
}
