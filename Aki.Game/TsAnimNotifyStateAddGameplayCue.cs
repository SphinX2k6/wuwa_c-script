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
	// Token: 0x06000F33 RID: 3891 RVA: 0x000590A7 File Offset: 0x000572A7
	static TsAnimNotifyStateAddGameplayCue()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateAddGameplayCue.CreateStaticDefaultValue), new Action(TsAnimNotifyStateAddGameplayCue.ResetStaticDefaultValue));
	}

	// Token: 0x06000F34 RID: 3892 RVA: 0x000590C6 File Offset: 0x000572C6
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateAddGameplayCue.entityCueMap = new Dictionary<int, Dictionary<long, int>>();
	}

	// Token: 0x06000F35 RID: 3893 RVA: 0x000590D2 File Offset: 0x000572D2
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateAddGameplayCue.entityCueMap = null;
	}

	// Token: 0x17000276 RID: 630
	// (get) Token: 0x06000F36 RID: 3894 RVA: 0x000590DC File Offset: 0x000572DC
	// (set) Token: 0x06000F37 RID: 3895 RVA: 0x00059115 File Offset: 0x00057315
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

	// Token: 0x06000F38 RID: 3896 RVA: 0x00059124 File Offset: 0x00057324
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddGameplayCue) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateAddGameplayCue.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06000F39 RID: 3897 RVA: 0x000591E4 File Offset: 0x000573E4
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

	// Token: 0x06000F3A RID: 3898 RVA: 0x000592CC File Offset: 0x000574CC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddGameplayCue) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateAddGameplayCue.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06000F3B RID: 3899 RVA: 0x00059384 File Offset: 0x00057584
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

	// Token: 0x06000F3C RID: 3900 RVA: 0x00059454 File Offset: 0x00057654
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddGameplayCue) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateAddGameplayCue.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x000594E4 File Offset: 0x000576E4
	protected override string GetNotifyName_Implementation()
	{
		return "播放Buff特效";
	}

	// Token: 0x06000F3E RID: 3902 RVA: 0x000594EB File Offset: 0x000576EB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAddGameplayCue._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddGameplayCue.TsAnimNotifyStateAddGameplayCue_C");
		}
		return TsAnimNotifyStateAddGameplayCue._ClassPtr;
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x00059510 File Offset: 0x00057710
	public TsAnimNotifyStateAddGameplayCue() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddGameplayCue.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000F40 RID: 3904 RVA: 0x00059538 File Offset: 0x00057738
	public TsAnimNotifyStateAddGameplayCue(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddGameplayCue.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000F41 RID: 3905 RVA: 0x0005956B File Offset: 0x0005776B
	protected TsAnimNotifyStateAddGameplayCue(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000F42 RID: 3906 RVA: 0x00059574 File Offset: 0x00057774
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000F43 RID: 3907 RVA: 0x000595B0 File Offset: 0x000577B0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x000595E3 File Offset: 0x000577E3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C08 RID: 3080
	private static Dictionary<int, Dictionary<long, int>> entityCueMap;

	// Token: 0x04000C09 RID: 3081
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddGameplayCue.TsAnimNotifyStateAddGameplayCue_C";

	// Token: 0x04000C0A RID: 3082
	private static IntPtr _ClassPtr;

	// Token: 0x04000C0B RID: 3083
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C0C RID: 3084
	private static int __PropertyOffset_Buff特效Id列表;

	// Token: 0x04000C0D RID: 3085
	[Nullable(2)]
	private TArray<long> _Buff特效Id列表;
}
