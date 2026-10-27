using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000104 RID: 260
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddGameplayCue.TsAnimNotifyStateAddGameplayCue_C")]
public class TsAnimNotifyStateAddGameplayCue : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06000F2D RID: 3885 RVA: 0x0005811F File Offset: 0x0005631F
	static TsAnimNotifyStateAddGameplayCue()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateAddGameplayCue.CreateStaticDefaultValue), new Action(TsAnimNotifyStateAddGameplayCue.ResetStaticDefaultValue));
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x0005813E File Offset: 0x0005633E
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateAddGameplayCue.entityCueMap = new Dictionary<int, Dictionary<long, int>>();
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x0005814A File Offset: 0x0005634A
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateAddGameplayCue.entityCueMap = null;
	}

	// Token: 0x17000273 RID: 627
	// (get) Token: 0x06000F30 RID: 3888 RVA: 0x00058154 File Offset: 0x00056354
	// (set) Token: 0x06000F31 RID: 3889 RVA: 0x0005818D File Offset: 0x0005638D
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<long> Buff特效Id列表
	{
		get
		{
			base.FastCheckIsValid();
			TArray<long> result;
			if ((result = this._Buff特效Id列表) == null)
			{
				result = (this._Buff特效Id列表 = new TArray<long>(base.NativePtr + (IntPtr)TsAnimNotifyStateAddGameplayCue.__PropertyOffset_Buff特效Id列表, this));
			}
			return result;
		}
		set
		{
			this.Buff特效Id列表.CopyAssign(value);
		}
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x0005819C File Offset: 0x0005639C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x00058244 File Offset: 0x00056444
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		CharacterActorComponent characterActorComponent = (tsBaseCharacter != null) ? tsBaseCharacter.CharacterActorComponent : null;
		if (characterActorComponent == null || !characterActorComponent.Valid)
		{
			return false;
		}
		Entity entity = characterActorComponent.Entity;
		CharacterGameplayCueComponent characterGameplayCueComponent = (entity != null) ? entity.GetComponent<CharacterGameplayCueComponent>() : null;
		if (characterGameplayCueComponent == null)
		{
			return false;
		}
		if (this.Buff特效Id列表 != null)
		{
			Dictionary<long, int> dictionary;
			if (!TsAnimNotifyStateAddGameplayCue.entityCueMap.TryGetValue(entity.Id, out dictionary))
			{
				dictionary = new Dictionary<long, int>();
				TsAnimNotifyStateAddGameplayCue.entityCueMap.Add(entity.Id, dictionary);
			}
			for (int i = 0; i < this.Buff特效Id列表.Num(); i++)
			{
				long num = this.Buff特效Id列表.Get(i);
				int num2 = characterGameplayCueComponent.AddCue(num, null);
				if (num2 != 0)
				{
					int num3;
					if (dictionary.TryGetValue(num, out num3))
					{
						characterGameplayCueComponent.RemoveCueByHandle((long)num3);
					}
					dictionary[num] = num2;
				}
			}
		}
		return true;
	}

	// Token: 0x06000F34 RID: 3892 RVA: 0x0005832C File Offset: 0x0005652C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
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

	// Token: 0x06000F35 RID: 3893 RVA: 0x000583CC File Offset: 0x000565CC
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		CharacterActorComponent characterActorComponent = (tsBaseCharacter != null) ? tsBaseCharacter.CharacterActorComponent : null;
		if (characterActorComponent == null || !characterActorComponent.Valid)
		{
			return false;
		}
		Entity entity = characterActorComponent.Entity;
		CharacterGameplayCueComponent characterGameplayCueComponent = (entity != null) ? entity.GetComponent<CharacterGameplayCueComponent>() : null;
		if (characterGameplayCueComponent == null)
		{
			return false;
		}
		Dictionary<long, int> dictionary;
		if (this.Buff特效Id列表 != null && TsAnimNotifyStateAddGameplayCue.entityCueMap.TryGetValue(entity.Id, out dictionary))
		{
			for (int i = 0; i < this.Buff特效Id列表.Num(); i++)
			{
				long key = this.Buff特效Id列表.Get(i);
				int num;
				if (dictionary.TryGetValue(key, out num))
				{
					characterGameplayCueComponent.RemoveCueByHandle((long)num);
					dictionary.Remove(key);
				}
			}
			if (dictionary.Count == 0)
			{
				TsAnimNotifyStateAddGameplayCue.entityCueMap.Remove(entity.Id);
			}
		}
		return true;
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x0005849C File Offset: 0x0005669C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x06000F37 RID: 3895 RVA: 0x00058517 File Offset: 0x00056717
	protected override string GetNotifyName_Implementation()
	{
		return "播放Buff特效";
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x0005851E File Offset: 0x0005671E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAddGameplayCue._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddGameplayCue.TsAnimNotifyStateAddGameplayCue_C");
		}
		return TsAnimNotifyStateAddGameplayCue._ClassPtr;
	}

	// Token: 0x06000F39 RID: 3897 RVA: 0x00058544 File Offset: 0x00056744
	public TsAnimNotifyStateAddGameplayCue() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddGameplayCue.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000F3A RID: 3898 RVA: 0x0005856C File Offset: 0x0005676C
	public TsAnimNotifyStateAddGameplayCue(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddGameplayCue.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000F3B RID: 3899 RVA: 0x0005859F File Offset: 0x0005679F
	protected TsAnimNotifyStateAddGameplayCue(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000F3C RID: 3900 RVA: 0x000585A8 File Offset: 0x000567A8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x000585E4 File Offset: 0x000567E4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000F3E RID: 3902 RVA: 0x00058617 File Offset: 0x00056817
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C00 RID: 3072
	private static Dictionary<int, Dictionary<long, int>> entityCueMap;

	// Token: 0x04000C01 RID: 3073
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddGameplayCue.TsAnimNotifyStateAddGameplayCue_C";

	// Token: 0x04000C02 RID: 3074
	private static IntPtr _ClassPtr;

	// Token: 0x04000C03 RID: 3075
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C04 RID: 3076
	private static int __PropertyOffset_Buff特效Id列表;

	// Token: 0x04000C05 RID: 3077
	[Nullable(2)]
	private TArray<long> _Buff特效Id列表;
}
