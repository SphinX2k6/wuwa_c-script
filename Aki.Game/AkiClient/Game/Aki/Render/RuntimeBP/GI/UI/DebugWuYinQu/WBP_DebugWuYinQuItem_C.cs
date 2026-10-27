using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.UI.DebugWuYinQu
{
	// Token: 0x02003D38 RID: 15672
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/UI/DebugWuYinQu/WBP_DebugWuYinQuItem.WBP_DebugWuYinQuItem_C")]
	[UnrealStructLayout(1192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1192)]
	public class WBP_DebugWuYinQuItem_C : UUserWidget, IUnrealUObject, IUnrealObject, IUserObjectListEntry, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060260BA RID: 155834 RVA: 0x00969B2C File Offset: 0x00967D2C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WBP_DebugWuYinQuItem_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/UI/DebugWuYinQu/WBP_DebugWuYinQuItem.WBP_DebugWuYinQuItem_C");
			}
			return WBP_DebugWuYinQuItem_C._ClassPtr;
		}

		// Token: 0x060260BB RID: 155835 RVA: 0x00969B50 File Offset: 0x00967D50
		int IUserObjectListEntry.InterfaceOffset()
		{
			return WBP_DebugWuYinQuItem_C.__InterfaceOffset_IUserObjectListEntry;
		}

		// Token: 0x060260BC RID: 155836 RVA: 0x00969B58 File Offset: 0x00967D58
		public WBP_DebugWuYinQuItem_C() : this(BuiltinUtils.AllocNativeUObject(WBP_DebugWuYinQuItem_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260BD RID: 155837 RVA: 0x00969B80 File Offset: 0x00967D80
		[NullableContext(1)]
		public WBP_DebugWuYinQuItem_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WBP_DebugWuYinQuItem_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700502A RID: 20522
		// (get) Token: 0x060260BE RID: 155838 RVA: 0x00969BB3 File Offset: 0x00967DB3
		// (set) Token: 0x060260BF RID: 155839 RVA: 0x00969BC7 File Offset: 0x00967DC7
		[Nullable(2)]
		public unsafe UButton Button_100
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugWuYinQuItem_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugWuYinQuItem_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700502B RID: 20523
		// (get) Token: 0x060260C0 RID: 155840 RVA: 0x00969BDC File Offset: 0x00967DDC
		// (set) Token: 0x060260C1 RID: 155841 RVA: 0x00969BF0 File Offset: 0x00967DF0
		[Nullable(2)]
		public unsafe UImage Image_76
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugWuYinQuItem_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugWuYinQuItem_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x060260C2 RID: 155842 RVA: 0x00969C05 File Offset: 0x00967E05
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BP_OnEntryReleased()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugWuYinQuItem_C.__BP_OnEntryReleased_NativeFunctionPtr, null);
		}

		// Token: 0x060260C3 RID: 155843 RVA: 0x00969C19 File Offset: 0x00967E19
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BP_OnEntryReleased_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_DebugWuYinQuItem_C.__BP_OnEntryReleased_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060260C4 RID: 155844 RVA: 0x00969C30 File Offset: 0x00967E30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BP_OnItemExpansionChanged(bool bIsExpanded)
		{
			WBP_DebugWuYinQuItem_C.__BP_OnItemExpansionChanged_FunctionParams* ptr = stackalloc WBP_DebugWuYinQuItem_C.__BP_OnItemExpansionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(WBP_DebugWuYinQuItem_C.__BP_OnItemExpansionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugWuYinQuItem_C.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsExpanded = bIsExpanded;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugWuYinQuItem_C.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060260C5 RID: 155845 RVA: 0x00969C78 File Offset: 0x00967E78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BP_OnItemExpansionChanged_Implementation(bool bIsExpanded)
		{
			WBP_DebugWuYinQuItem_C.__BP_OnItemExpansionChanged_FunctionParams* ptr = stackalloc WBP_DebugWuYinQuItem_C.__BP_OnItemExpansionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(WBP_DebugWuYinQuItem_C.__BP_OnItemExpansionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugWuYinQuItem_C.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsExpanded = bIsExpanded;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_DebugWuYinQuItem_C.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060260C6 RID: 155846 RVA: 0x00969CC0 File Offset: 0x00967EC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BP_OnItemSelectionChanged(bool bIsSelected)
		{
			WBP_DebugWuYinQuItem_C.__BP_OnItemSelectionChanged_FunctionParams* ptr = stackalloc WBP_DebugWuYinQuItem_C.__BP_OnItemSelectionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(WBP_DebugWuYinQuItem_C.__BP_OnItemSelectionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugWuYinQuItem_C.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsSelected = bIsSelected;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugWuYinQuItem_C.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060260C7 RID: 155847 RVA: 0x00969D08 File Offset: 0x00967F08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BP_OnItemSelectionChanged_Implementation(bool bIsSelected)
		{
			WBP_DebugWuYinQuItem_C.__BP_OnItemSelectionChanged_FunctionParams* ptr = stackalloc WBP_DebugWuYinQuItem_C.__BP_OnItemSelectionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(WBP_DebugWuYinQuItem_C.__BP_OnItemSelectionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugWuYinQuItem_C.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsSelected = bIsSelected;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_DebugWuYinQuItem_C.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060260C8 RID: 155848 RVA: 0x00969D50 File Offset: 0x00967F50
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnListItemObjectSet(UObject ListItemObject)
		{
			WBP_DebugWuYinQuItem_C.__OnListItemObjectSet_FunctionParams* ptr = stackalloc WBP_DebugWuYinQuItem_C.__OnListItemObjectSet_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(WBP_DebugWuYinQuItem_C.__OnListItemObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugWuYinQuItem_C.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ListItemObject = ((ListItemObject != null) ? ListItemObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugWuYinQuItem_C.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060260C9 RID: 155849 RVA: 0x00969DA8 File Offset: 0x00967FA8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnListItemObjectSet_Implementation(UObject ListItemObject)
		{
			WBP_DebugWuYinQuItem_C.__OnListItemObjectSet_FunctionParams* ptr = stackalloc WBP_DebugWuYinQuItem_C.__OnListItemObjectSet_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(WBP_DebugWuYinQuItem_C.__OnListItemObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugWuYinQuItem_C.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ListItemObject = ((ListItemObject != null) ? ListItemObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_DebugWuYinQuItem_C.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060260CA RID: 155850 RVA: 0x00969DFE File Offset: 0x00967FFE
		protected WBP_DebugWuYinQuItem_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130A9 RID: 77993
		internal static int __InterfaceOffset_IUserObjectListEntry;

		// Token: 0x040130AA RID: 77994
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/UI/DebugWuYinQu/WBP_DebugWuYinQuItem.WBP_DebugWuYinQuItem_C";

		// Token: 0x040130AB RID: 77995
		private static IntPtr _ClassPtr;

		// Token: 0x040130AC RID: 77996
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130AD RID: 77997
		internal static int __PropertyOffset_1;

		// Token: 0x040130AE RID: 77998
		internal static int __PropertyOffset_2;

		// Token: 0x040130AF RID: 77999
		private static IntPtr __BP_OnEntryReleased_NativeFunctionPtr;

		// Token: 0x040130B0 RID: 78000
		private static IntPtr __BP_OnItemExpansionChanged_NativeFunctionPtr;

		// Token: 0x040130B1 RID: 78001
		private static IntPtr __BP_OnItemSelectionChanged_NativeFunctionPtr;

		// Token: 0x040130B2 RID: 78002
		private static IntPtr __OnListItemObjectSet_NativeFunctionPtr;

		// Token: 0x0200A089 RID: 41097
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __BP_OnItemExpansionChanged_FunctionParams
		{
			// Token: 0x04031B82 RID: 203650
			[FieldOffset(0)]
			public bool bIsExpanded;
		}

		// Token: 0x0200A08A RID: 41098
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __BP_OnItemSelectionChanged_FunctionParams
		{
			// Token: 0x04031B83 RID: 203651
			[FieldOffset(0)]
			public bool bIsSelected;
		}

		// Token: 0x0200A08B RID: 41099
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnListItemObjectSet_FunctionParams
		{
			// Token: 0x04031B84 RID: 203652
			[FieldOffset(0)]
			public IntPtr ListItemObject;
		}
	}
}
