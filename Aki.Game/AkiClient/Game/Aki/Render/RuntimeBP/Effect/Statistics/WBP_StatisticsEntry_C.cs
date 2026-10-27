using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.UI.Module.Common.View.Widget;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Statistics
{
	// Token: 0x02003DC4 RID: 15812
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Statistics/WBP_StatisticsEntry.WBP_StatisticsEntry_C")]
	[UnrealStructLayout(1320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1320)]
	public class WBP_StatisticsEntry_C : UUserWidget, IUnrealUObject, IUnrealObject, IUserObjectListEntry, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602756A RID: 161130 RVA: 0x0098E6FF File Offset: 0x0098C8FF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WBP_StatisticsEntry_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Statistics/WBP_StatisticsEntry.WBP_StatisticsEntry_C");
			}
			return WBP_StatisticsEntry_C._ClassPtr;
		}

		// Token: 0x0602756B RID: 161131 RVA: 0x0098E723 File Offset: 0x0098C923
		int IUserObjectListEntry.InterfaceOffset()
		{
			return WBP_StatisticsEntry_C.__InterfaceOffset_IUserObjectListEntry;
		}

		// Token: 0x0602756C RID: 161132 RVA: 0x0098E72C File Offset: 0x0098C92C
		public WBP_StatisticsEntry_C() : this(BuiltinUtils.AllocNativeUObject(WBP_StatisticsEntry_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602756D RID: 161133 RVA: 0x0098E754 File Offset: 0x0098C954
		[NullableContext(1)]
		public WBP_StatisticsEntry_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WBP_StatisticsEntry_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005793 RID: 22419
		// (get) Token: 0x0602756E RID: 161134 RVA: 0x0098E787 File Offset: 0x0098C987
		// (set) Token: 0x0602756F RID: 161135 RVA: 0x0098E79B File Offset: 0x0098C99B
		public unsafe UButton Button_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_StatisticsEntry_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_StatisticsEntry_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005794 RID: 22420
		// (get) Token: 0x06027570 RID: 161136 RVA: 0x0098E7B0 File Offset: 0x0098C9B0
		// (set) Token: 0x06027571 RID: 161137 RVA: 0x0098E7C4 File Offset: 0x0098C9C4
		public unsafe KuroImage_C KuroImage_C_236
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<KuroImage_C>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_StatisticsEntry_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_StatisticsEntry_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005795 RID: 22421
		// (get) Token: 0x06027572 RID: 161138 RVA: 0x0098E7D9 File Offset: 0x0098C9D9
		// (set) Token: 0x06027573 RID: 161139 RVA: 0x0098E7ED File Offset: 0x0098C9ED
		public unsafe UTextBlock TextBlock
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_StatisticsEntry_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_StatisticsEntry_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005796 RID: 22422
		// (get) Token: 0x06027574 RID: 161140 RVA: 0x0098E802 File Offset: 0x0098CA02
		// (set) Token: 0x06027575 RID: 161141 RVA: 0x0098E816 File Offset: 0x0098CA16
		public unsafe UTextBlock TextBlock_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_StatisticsEntry_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_StatisticsEntry_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005797 RID: 22423
		// (get) Token: 0x06027576 RID: 161142 RVA: 0x0098E82B File Offset: 0x0098CA2B
		// (set) Token: 0x06027577 RID: 161143 RVA: 0x0098E83F File Offset: 0x0098CA3F
		public unsafe UTextBlock TextBlock_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_StatisticsEntry_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_StatisticsEntry_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005798 RID: 22424
		// (get) Token: 0x06027578 RID: 161144 RVA: 0x0098E854 File Offset: 0x0098CA54
		// (set) Token: 0x06027579 RID: 161145 RVA: 0x0098E868 File Offset: 0x0098CA68
		public unsafe UTextBlock TextBlock_20
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_StatisticsEntry_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_StatisticsEntry_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005799 RID: 22425
		// (get) Token: 0x0602757A RID: 161146 RVA: 0x0098E87D File Offset: 0x0098CA7D
		// (set) Token: 0x0602757B RID: 161147 RVA: 0x0098E891 File Offset: 0x0098CA91
		public unsafe UTextBlock TextBlock_139
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_StatisticsEntry_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_StatisticsEntry_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x1700579A RID: 22426
		// (get) Token: 0x0602757C RID: 161148 RVA: 0x0098E8A6 File Offset: 0x0098CAA6
		// (set) Token: 0x0602757D RID: 161149 RVA: 0x0098E8BA File Offset: 0x0098CABA
		[Nullable(1)]
		public unsafe string Name
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)WBP_StatisticsEntry_C.__PropertyOffset_8)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)WBP_StatisticsEntry_C.__PropertyOffset_8)), value);
			}
		}

		// Token: 0x1700579B RID: 22427
		// (get) Token: 0x0602757E RID: 161150 RVA: 0x0098E8CF File Offset: 0x0098CACF
		// (set) Token: 0x0602757F RID: 161151 RVA: 0x0098E8DF File Offset: 0x0098CADF
		public unsafe float ExistingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_StatisticsEntry_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_StatisticsEntry_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700579C RID: 22428
		// (get) Token: 0x06027580 RID: 161152 RVA: 0x0098E8F0 File Offset: 0x0098CAF0
		// (set) Token: 0x06027581 RID: 161153 RVA: 0x0098E900 File Offset: 0x0098CB00
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_StatisticsEntry_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_StatisticsEntry_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700579D RID: 22429
		// (get) Token: 0x06027582 RID: 161154 RVA: 0x0098E911 File Offset: 0x0098CB11
		// (set) Token: 0x06027583 RID: 161155 RVA: 0x0098E925 File Offset: 0x0098CB25
		[Nullable(1)]
		public unsafe string Author
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)WBP_StatisticsEntry_C.__PropertyOffset_11)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)WBP_StatisticsEntry_C.__PropertyOffset_11)), value);
			}
		}

		// Token: 0x1700579E RID: 22430
		// (get) Token: 0x06027584 RID: 161156 RVA: 0x0098E93A File Offset: 0x0098CB3A
		// (set) Token: 0x06027585 RID: 161157 RVA: 0x0098E94E File Offset: 0x0098CB4E
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_StatisticsEntry_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_StatisticsEntry_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700579F RID: 22431
		// (get) Token: 0x06027586 RID: 161158 RVA: 0x0098E963 File Offset: 0x0098CB63
		// (set) Token: 0x06027587 RID: 161159 RVA: 0x0098E973 File Offset: 0x0098CB73
		public unsafe int TickCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_StatisticsEntry_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_StatisticsEntry_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170057A0 RID: 22432
		// (get) Token: 0x06027588 RID: 161160 RVA: 0x0098E984 File Offset: 0x0098CB84
		// (set) Token: 0x06027589 RID: 161161 RVA: 0x0098E998 File Offset: 0x0098CB98
		public unsafe UEffectStatisticsEntryData_C Data
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectStatisticsEntryData_C>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_StatisticsEntry_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_StatisticsEntry_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x170057A1 RID: 22433
		// (get) Token: 0x0602758A RID: 161162 RVA: 0x0098E9AD File Offset: 0x0098CBAD
		// (set) Token: 0x0602758B RID: 161163 RVA: 0x0098E9C1 File Offset: 0x0098CBC1
		public unsafe FLinearColor TextColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_StatisticsEntry_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_StatisticsEntry_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x0602758C RID: 161164 RVA: 0x0098E9D6 File Offset: 0x0098CBD6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BP_OnEntryReleased()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_StatisticsEntry_C.__BP_OnEntryReleased_NativeFunctionPtr, null);
		}

		// Token: 0x0602758D RID: 161165 RVA: 0x0098E9EA File Offset: 0x0098CBEA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BP_OnEntryReleased_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_StatisticsEntry_C.__BP_OnEntryReleased_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602758E RID: 161166 RVA: 0x0098EA00 File Offset: 0x0098CC00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BP_OnItemExpansionChanged(bool bIsExpanded)
		{
			WBP_StatisticsEntry_C.__BP_OnItemExpansionChanged_FunctionParams* ptr = stackalloc WBP_StatisticsEntry_C.__BP_OnItemExpansionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(WBP_StatisticsEntry_C.__BP_OnItemExpansionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_StatisticsEntry_C.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsExpanded = bIsExpanded;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_StatisticsEntry_C.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602758F RID: 161167 RVA: 0x0098EA48 File Offset: 0x0098CC48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BP_OnItemExpansionChanged_Implementation(bool bIsExpanded)
		{
			WBP_StatisticsEntry_C.__BP_OnItemExpansionChanged_FunctionParams* ptr = stackalloc WBP_StatisticsEntry_C.__BP_OnItemExpansionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(WBP_StatisticsEntry_C.__BP_OnItemExpansionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_StatisticsEntry_C.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsExpanded = bIsExpanded;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_StatisticsEntry_C.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027590 RID: 161168 RVA: 0x0098EA90 File Offset: 0x0098CC90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BP_OnItemSelectionChanged(bool bIsSelected)
		{
			WBP_StatisticsEntry_C.__BP_OnItemSelectionChanged_FunctionParams* ptr = stackalloc WBP_StatisticsEntry_C.__BP_OnItemSelectionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(WBP_StatisticsEntry_C.__BP_OnItemSelectionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_StatisticsEntry_C.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsSelected = bIsSelected;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_StatisticsEntry_C.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027591 RID: 161169 RVA: 0x0098EAD8 File Offset: 0x0098CCD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BP_OnItemSelectionChanged_Implementation(bool bIsSelected)
		{
			WBP_StatisticsEntry_C.__BP_OnItemSelectionChanged_FunctionParams* ptr = stackalloc WBP_StatisticsEntry_C.__BP_OnItemSelectionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(WBP_StatisticsEntry_C.__BP_OnItemSelectionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_StatisticsEntry_C.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsSelected = bIsSelected;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_StatisticsEntry_C.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027592 RID: 161170 RVA: 0x0098EB20 File Offset: 0x0098CD20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnListItemObjectSet(UObject ListItemObject)
		{
			WBP_StatisticsEntry_C.__OnListItemObjectSet_FunctionParams* ptr = stackalloc WBP_StatisticsEntry_C.__OnListItemObjectSet_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(WBP_StatisticsEntry_C.__OnListItemObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_StatisticsEntry_C.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ListItemObject = ((ListItemObject != null) ? ListItemObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_StatisticsEntry_C.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027593 RID: 161171 RVA: 0x0098EB78 File Offset: 0x0098CD78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnListItemObjectSet_Implementation(UObject ListItemObject)
		{
			WBP_StatisticsEntry_C.__OnListItemObjectSet_FunctionParams* ptr = stackalloc WBP_StatisticsEntry_C.__OnListItemObjectSet_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(WBP_StatisticsEntry_C.__OnListItemObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_StatisticsEntry_C.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ListItemObject = ((ListItemObject != null) ? ListItemObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_StatisticsEntry_C.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027594 RID: 161172 RVA: 0x0098EBCE File Offset: 0x0098CDCE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__WBP_StatisticsEntry_Button_0_K2Node_ComponentBoundEvent_0_OnButtonReleasedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_StatisticsEntry_C.__BndEvt__WBP_StatisticsEntry_Button_0_K2Node_ComponentBoundEvent_0_OnButtonReleasedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06027595 RID: 161173 RVA: 0x0098EBE2 File Offset: 0x0098CDE2
		protected WBP_StatisticsEntry_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013DAB RID: 81323
		internal static int __InterfaceOffset_IUserObjectListEntry;

		// Token: 0x04013DAC RID: 81324
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Statistics/WBP_StatisticsEntry.WBP_StatisticsEntry_C";

		// Token: 0x04013DAD RID: 81325
		private static IntPtr _ClassPtr;

		// Token: 0x04013DAE RID: 81326
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013DAF RID: 81327
		internal static int __PropertyOffset_1;

		// Token: 0x04013DB0 RID: 81328
		internal static int __PropertyOffset_2;

		// Token: 0x04013DB1 RID: 81329
		internal static int __PropertyOffset_3;

		// Token: 0x04013DB2 RID: 81330
		internal static int __PropertyOffset_4;

		// Token: 0x04013DB3 RID: 81331
		internal static int __PropertyOffset_5;

		// Token: 0x04013DB4 RID: 81332
		internal static int __PropertyOffset_6;

		// Token: 0x04013DB5 RID: 81333
		internal static int __PropertyOffset_7;

		// Token: 0x04013DB6 RID: 81334
		internal static int __PropertyOffset_8;

		// Token: 0x04013DB7 RID: 81335
		internal static int __PropertyOffset_9;

		// Token: 0x04013DB8 RID: 81336
		internal static int __PropertyOffset_10;

		// Token: 0x04013DB9 RID: 81337
		internal static int __PropertyOffset_11;

		// Token: 0x04013DBA RID: 81338
		internal static int __PropertyOffset_12;

		// Token: 0x04013DBB RID: 81339
		internal static int __PropertyOffset_13;

		// Token: 0x04013DBC RID: 81340
		internal static int __PropertyOffset_14;

		// Token: 0x04013DBD RID: 81341
		internal static int __PropertyOffset_15;

		// Token: 0x04013DBE RID: 81342
		private static IntPtr __BP_OnEntryReleased_NativeFunctionPtr;

		// Token: 0x04013DBF RID: 81343
		private static IntPtr __BP_OnItemExpansionChanged_NativeFunctionPtr;

		// Token: 0x04013DC0 RID: 81344
		private static IntPtr __BP_OnItemSelectionChanged_NativeFunctionPtr;

		// Token: 0x04013DC1 RID: 81345
		private static IntPtr __OnListItemObjectSet_NativeFunctionPtr;

		// Token: 0x04013DC2 RID: 81346
		private static IntPtr __BndEvt__WBP_StatisticsEntry_Button_0_K2Node_ComponentBoundEvent_0_OnButtonReleasedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0200A215 RID: 41493
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __BP_OnItemExpansionChanged_FunctionParams
		{
			// Token: 0x04031E7F RID: 204415
			[FieldOffset(0)]
			public bool bIsExpanded;
		}

		// Token: 0x0200A216 RID: 41494
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __BP_OnItemSelectionChanged_FunctionParams
		{
			// Token: 0x04031E80 RID: 204416
			[FieldOffset(0)]
			public bool bIsSelected;
		}

		// Token: 0x0200A217 RID: 41495
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnListItemObjectSet_FunctionParams
		{
			// Token: 0x04031E81 RID: 204417
			[FieldOffset(0)]
			public IntPtr ListItemObject;
		}
	}
}
