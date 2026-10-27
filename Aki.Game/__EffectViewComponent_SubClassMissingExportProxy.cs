using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039B3 RID: 14771
public class __EffectViewComponent_SubClassMissingExportProxy : __EffectViewComponent_InheritProxy
{
	// Token: 0x0601EE4F RID: 126543 RVA: 0x008A0860 File Offset: 0x0089EA60
	[NullableContext(1)]
	protected __EffectViewComponent_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectViewComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE50 RID: 126544 RVA: 0x008A0893 File Offset: 0x0089EA93
	protected __EffectViewComponent_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EE51 RID: 126545 RVA: 0x008A089C File Offset: 0x0089EA9C
	public unsafe override void EditorTick(float deltaSecond)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("EditorTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		EffectViewComponent.__EditorTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((EffectViewComponent.__EditorTick_FunctionParams*)ptr + 15L / (long)sizeof(EffectViewComponent.__EditorTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->deltaSecond = deltaSecond;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EE52 RID: 126546 RVA: 0x008A0914 File Offset: 0x0089EB14
	public unsafe override void SetAutoPlay(bool autoPlay)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetAutoPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		EffectViewComponent.__SetAutoPlay_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((EffectViewComponent.__SetAutoPlay_FunctionParams*)ptr + 15L / (long)sizeof(EffectViewComponent.__SetAutoPlay_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->autoPlay = autoPlay;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EE53 RID: 126547 RVA: 0x008A098C File Offset: 0x0089EB8C
	public unsafe override void Play()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("Play"), out num);
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

	// Token: 0x0601EE54 RID: 126548 RVA: 0x008A09FC File Offset: 0x0089EBFC
	public unsafe override void Stop(bool immediately)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("Stop"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		EffectViewComponent.__Stop_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((EffectViewComponent.__Stop_FunctionParams*)ptr + 15L / (long)sizeof(EffectViewComponent.__Stop_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->immediately = immediately;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}
}
