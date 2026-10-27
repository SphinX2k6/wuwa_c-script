using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.UI.DebugDataLayer
{
	// Token: 0x02003D3E RID: 15678
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/UI/DebugDataLayer/WBP_DebugDataLayerListEntry.WBP_DebugDataLayerListEntry_C")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1232)]
	public class WBP_DebugDataLayerListEntry_C : UUserWidget, IUnrealUObject, IUnrealObject, IUserObjectListEntry, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06026136 RID: 155958 RVA: 0x0096AB3A File Offset: 0x00968D3A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WBP_DebugDataLayerListEntry_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/UI/DebugDataLayer/WBP_DebugDataLayerListEntry.WBP_DebugDataLayerListEntry_C");
			}
			return WBP_DebugDataLayerListEntry_C._ClassPtr;
		}

		// Token: 0x06026137 RID: 155959 RVA: 0x0096AB5E File Offset: 0x00968D5E
		int IUserObjectListEntry.InterfaceOffset()
		{
			return WBP_DebugDataLayerListEntry_C.__InterfaceOffset_IUserObjectListEntry;
		}

		// Token: 0x06026138 RID: 155960 RVA: 0x0096AB68 File Offset: 0x00968D68
		public WBP_DebugDataLayerListEntry_C() : this(BuiltinUtils.AllocNativeUObject(WBP_DebugDataLayerListEntry_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026139 RID: 155961 RVA: 0x0096AB90 File Offset: 0x00968D90
		[NullableContext(1)]
		public WBP_DebugDataLayerListEntry_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WBP_DebugDataLayerListEntry_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700504D RID: 20557
		// (get) Token: 0x0602613A RID: 155962 RVA: 0x0096ABC3 File Offset: 0x00968DC3
		// (set) Token: 0x0602613B RID: 155963 RVA: 0x0096ABD7 File Offset: 0x00968DD7
		public unsafe UButton BtnClose
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerListEntry_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerListEntry_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700504E RID: 20558
		// (get) Token: 0x0602613C RID: 155964 RVA: 0x0096ABEC File Offset: 0x00968DEC
		// (set) Token: 0x0602613D RID: 155965 RVA: 0x0096AC00 File Offset: 0x00968E00
		public unsafe UButton BtnShow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerListEntry_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerListEntry_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700504F RID: 20559
		// (get) Token: 0x0602613E RID: 155966 RVA: 0x0096AC15 File Offset: 0x00968E15
		// (set) Token: 0x0602613F RID: 155967 RVA: 0x0096AC29 File Offset: 0x00968E29
		public unsafe UTextBlock DataLayerName
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerListEntry_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerListEntry_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005050 RID: 20560
		// (get) Token: 0x06026140 RID: 155968 RVA: 0x0096AC3E File Offset: 0x00968E3E
		// (set) Token: 0x06026141 RID: 155969 RVA: 0x0096AC52 File Offset: 0x00968E52
		public unsafe UTextBlock DataLayerState
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerListEntry_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerListEntry_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005051 RID: 20561
		// (get) Token: 0x06026142 RID: 155970 RVA: 0x0096AC67 File Offset: 0x00968E67
		// (set) Token: 0x06026143 RID: 155971 RVA: 0x0096AC7B File Offset: 0x00968E7B
		public unsafe UImage Image_86
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerListEntry_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerListEntry_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005052 RID: 20562
		// (get) Token: 0x06026144 RID: 155972 RVA: 0x0096AC90 File Offset: 0x00968E90
		// (set) Token: 0x06026145 RID: 155973 RVA: 0x0096ACA0 File Offset: 0x00968EA0
		public unsafe bool HasOverrideProperties
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_DebugDataLayerListEntry_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_DebugDataLayerListEntry_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005053 RID: 20563
		// (get) Token: 0x06026146 RID: 155974 RVA: 0x0096ACB1 File Offset: 0x00968EB1
		// (set) Token: 0x06026147 RID: 155975 RVA: 0x0096ACC5 File Offset: 0x00968EC5
		public unsafe DebugDataLayerObject_C DebugDataLayerObject
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<DebugDataLayerObject_C>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerListEntry_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugDataLayerListEntry_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x06026148 RID: 155976 RVA: 0x0096ACDA File Offset: 0x00968EDA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdatePanel()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugDataLayerListEntry_C.__UpdatePanel_NativeFunctionPtr, null);
		}

		// Token: 0x06026149 RID: 155977 RVA: 0x0096ACF0 File Offset: 0x00968EF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetItemInfo(bool IsOverrideType, FPostprocessGIDebugInfo InputPostInfo)
		{
			WBP_DebugDataLayerListEntry_C.__SetItemInfo_FunctionParams* ptr = stackalloc WBP_DebugDataLayerListEntry_C.__SetItemInfo_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(WBP_DebugDataLayerListEntry_C.__SetItemInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugDataLayerListEntry_C.__SetItemInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsOverrideType = IsOverrideType;
			if (InputPostInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPostprocessGIDebugInfo.StaticStruct(), &ptr->InputPostInfo, InputPostInfo.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugDataLayerListEntry_C.__SetItemInfo_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(WBP_DebugDataLayerListEntry_C.__SetItemInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602614A RID: 155978 RVA: 0x0096AD6C File Offset: 0x00968F6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BP_OnEntryReleased()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugDataLayerListEntry_C.__BP_OnEntryReleased_NativeFunctionPtr, null);
		}

		// Token: 0x0602614B RID: 155979 RVA: 0x0096AD80 File Offset: 0x00968F80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BP_OnEntryReleased_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_DebugDataLayerListEntry_C.__BP_OnEntryReleased_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602614C RID: 155980 RVA: 0x0096AD98 File Offset: 0x00968F98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BP_OnItemExpansionChanged(bool bIsExpanded)
		{
			WBP_DebugDataLayerListEntry_C.__BP_OnItemExpansionChanged_FunctionParams* ptr = stackalloc WBP_DebugDataLayerListEntry_C.__BP_OnItemExpansionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(WBP_DebugDataLayerListEntry_C.__BP_OnItemExpansionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugDataLayerListEntry_C.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsExpanded = bIsExpanded;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugDataLayerListEntry_C.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602614D RID: 155981 RVA: 0x0096ADE0 File Offset: 0x00968FE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BP_OnItemExpansionChanged_Implementation(bool bIsExpanded)
		{
			WBP_DebugDataLayerListEntry_C.__BP_OnItemExpansionChanged_FunctionParams* ptr = stackalloc WBP_DebugDataLayerListEntry_C.__BP_OnItemExpansionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(WBP_DebugDataLayerListEntry_C.__BP_OnItemExpansionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugDataLayerListEntry_C.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsExpanded = bIsExpanded;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_DebugDataLayerListEntry_C.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602614E RID: 155982 RVA: 0x0096AE28 File Offset: 0x00969028
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BP_OnItemSelectionChanged(bool bIsSelected)
		{
			WBP_DebugDataLayerListEntry_C.__BP_OnItemSelectionChanged_FunctionParams* ptr = stackalloc WBP_DebugDataLayerListEntry_C.__BP_OnItemSelectionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(WBP_DebugDataLayerListEntry_C.__BP_OnItemSelectionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugDataLayerListEntry_C.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsSelected = bIsSelected;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugDataLayerListEntry_C.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602614F RID: 155983 RVA: 0x0096AE70 File Offset: 0x00969070
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BP_OnItemSelectionChanged_Implementation(bool bIsSelected)
		{
			WBP_DebugDataLayerListEntry_C.__BP_OnItemSelectionChanged_FunctionParams* ptr = stackalloc WBP_DebugDataLayerListEntry_C.__BP_OnItemSelectionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(WBP_DebugDataLayerListEntry_C.__BP_OnItemSelectionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugDataLayerListEntry_C.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsSelected = bIsSelected;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_DebugDataLayerListEntry_C.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026150 RID: 155984 RVA: 0x0096AEB8 File Offset: 0x009690B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnListItemObjectSet(UObject ListItemObject)
		{
			WBP_DebugDataLayerListEntry_C.__OnListItemObjectSet_FunctionParams* ptr = stackalloc WBP_DebugDataLayerListEntry_C.__OnListItemObjectSet_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(WBP_DebugDataLayerListEntry_C.__OnListItemObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugDataLayerListEntry_C.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ListItemObject = ((ListItemObject != null) ? ListItemObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugDataLayerListEntry_C.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026151 RID: 155985 RVA: 0x0096AF10 File Offset: 0x00969110
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnListItemObjectSet_Implementation(UObject ListItemObject)
		{
			WBP_DebugDataLayerListEntry_C.__OnListItemObjectSet_FunctionParams* ptr = stackalloc WBP_DebugDataLayerListEntry_C.__OnListItemObjectSet_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(WBP_DebugDataLayerListEntry_C.__OnListItemObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugDataLayerListEntry_C.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ListItemObject = ((ListItemObject != null) ? ListItemObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_DebugDataLayerListEntry_C.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026152 RID: 155986 RVA: 0x0096AF66 File Offset: 0x00969166
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__WBP_DebugDataLayerListEntry_BtnShow_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugDataLayerListEntry_C.__BndEvt__WBP_DebugDataLayerListEntry_BtnShow_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026153 RID: 155987 RVA: 0x0096AF7A File Offset: 0x0096917A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__WBP_DebugDataLayerListEntry_BtnClose_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugDataLayerListEntry_C.__BndEvt__WBP_DebugDataLayerListEntry_BtnClose_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06026154 RID: 155988 RVA: 0x0096AF8E File Offset: 0x0096918E
		protected WBP_DebugDataLayerListEntry_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130F4 RID: 78068
		internal static int __InterfaceOffset_IUserObjectListEntry;

		// Token: 0x040130F5 RID: 78069
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/UI/DebugDataLayer/WBP_DebugDataLayerListEntry.WBP_DebugDataLayerListEntry_C";

		// Token: 0x040130F6 RID: 78070
		private static IntPtr _ClassPtr;

		// Token: 0x040130F7 RID: 78071
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130F8 RID: 78072
		internal static int __PropertyOffset_1;

		// Token: 0x040130F9 RID: 78073
		internal static int __PropertyOffset_2;

		// Token: 0x040130FA RID: 78074
		internal static int __PropertyOffset_3;

		// Token: 0x040130FB RID: 78075
		internal static int __PropertyOffset_4;

		// Token: 0x040130FC RID: 78076
		internal static int __PropertyOffset_5;

		// Token: 0x040130FD RID: 78077
		internal static int __PropertyOffset_6;

		// Token: 0x040130FE RID: 78078
		internal static int __PropertyOffset_7;

		// Token: 0x040130FF RID: 78079
		private static IntPtr __UpdatePanel_NativeFunctionPtr;

		// Token: 0x04013100 RID: 78080
		private static IntPtr __SetItemInfo_NativeFunctionPtr;

		// Token: 0x04013101 RID: 78081
		private static IntPtr __BP_OnEntryReleased_NativeFunctionPtr;

		// Token: 0x04013102 RID: 78082
		private static IntPtr __BP_OnItemExpansionChanged_NativeFunctionPtr;

		// Token: 0x04013103 RID: 78083
		private static IntPtr __BP_OnItemSelectionChanged_NativeFunctionPtr;

		// Token: 0x04013104 RID: 78084
		private static IntPtr __OnListItemObjectSet_NativeFunctionPtr;

		// Token: 0x04013105 RID: 78085
		private static IntPtr __BndEvt__WBP_DebugDataLayerListEntry_BtnShow_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013106 RID: 78086
		private static IntPtr __BndEvt__WBP_DebugDataLayerListEntry_BtnClose_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0200A093 RID: 41107
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __SetItemInfo_FunctionParams
		{
			// Token: 0x04031B8F RID: 203663
			[FieldOffset(0)]
			public bool IsOverrideType;

			// Token: 0x04031B90 RID: 203664
			[FieldOffset(8)]
			public byte InputPostInfo;
		}

		// Token: 0x0200A094 RID: 41108
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __BP_OnItemExpansionChanged_FunctionParams
		{
			// Token: 0x04031B91 RID: 203665
			[FieldOffset(0)]
			public bool bIsExpanded;
		}

		// Token: 0x0200A095 RID: 41109
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __BP_OnItemSelectionChanged_FunctionParams
		{
			// Token: 0x04031B92 RID: 203666
			[FieldOffset(0)]
			public bool bIsSelected;
		}

		// Token: 0x0200A096 RID: 41110
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnListItemObjectSet_FunctionParams
		{
			// Token: 0x04031B93 RID: 203667
			[FieldOffset(0)]
			public IntPtr ListItemObject;
		}
	}
}
