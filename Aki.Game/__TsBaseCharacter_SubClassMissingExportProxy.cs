using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200388B RID: 14475
public class __TsBaseCharacter_SubClassMissingExportProxy : __TsBaseCharacter_InheritProxy
{
	// Token: 0x0601E9D6 RID: 125398 RVA: 0x00893F8C File Offset: 0x0089218C
	[NullableContext(1)]
	protected __TsBaseCharacter_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseCharacter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E9D7 RID: 125399 RVA: 0x00893FBF File Offset: 0x008921BF
	protected __TsBaseCharacter_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E9D8 RID: 125400 RVA: 0x00893FC8 File Offset: 0x008921C8
	public unsafe override void BindGameplayEnableState(ref bool gameplayEnable)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("BindGameplayEnableState"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBaseCharacter.__BindGameplayEnableState_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBaseCharacter.__BindGameplayEnableState_FunctionParams*)ptr + 15L / (long)sizeof(TsBaseCharacter.__BindGameplayEnableState_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->gameplayEnable = gameplayEnable;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E9D9 RID: 125401 RVA: 0x00894040 File Offset: 0x00892240
	public unsafe override int GetEntityId()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetEntityId"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBaseCharacter.__GetEntityId_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBaseCharacter.__GetEntityId_FunctionParams*)ptr + 15L / (long)sizeof(TsBaseCharacter.__GetEntityId_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		int _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601E9DA RID: 125402 RVA: 0x008940B8 File Offset: 0x008922B8
	public unsafe override void Initialize()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("Initialize"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E9DB RID: 125403 RVA: 0x00894128 File Offset: 0x00892328
	public unsafe override void SetDitherEffect(float dither, ECharacterDitherType ditherType)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetDitherEffect"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBaseCharacter.__SetDitherEffect_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBaseCharacter.__SetDitherEffect_FunctionParams*)ptr + 15L / (long)sizeof(TsBaseCharacter.__SetDitherEffect_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->dither = dither;
			*(&ptr2->ditherType) = (byte)ditherType;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E9DC RID: 125404 RVA: 0x008941A8 File Offset: 0x008923A8
	public unsafe override void FightCommand(bool isInAir)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("FightCommand"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBaseCharacter.__FightCommand_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBaseCharacter.__FightCommand_FunctionParams*)ptr + 15L / (long)sizeof(TsBaseCharacter.__FightCommand_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->isInAir = isInAir;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}
}
