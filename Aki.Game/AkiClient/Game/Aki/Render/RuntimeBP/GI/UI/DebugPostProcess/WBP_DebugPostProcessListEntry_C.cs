using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.UI.DebugPostProcess
{
	// Token: 0x02003D3B RID: 15675
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/UI/DebugPostProcess/WBP_DebugPostProcessListEntry.WBP_DebugPostProcessListEntry_C")]
	[UnrealStructLayout(1480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1480)]
	public class WBP_DebugPostProcessListEntry_C : UUserWidget, IUnrealUObject, IUnrealObject, IUserObjectListEntry, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060260E4 RID: 155876 RVA: 0x0096A148 File Offset: 0x00968348
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WBP_DebugPostProcessListEntry_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/UI/DebugPostProcess/WBP_DebugPostProcessListEntry.WBP_DebugPostProcessListEntry_C");
			}
			return WBP_DebugPostProcessListEntry_C._ClassPtr;
		}

		// Token: 0x060260E5 RID: 155877 RVA: 0x0096A16C File Offset: 0x0096836C
		int IUserObjectListEntry.InterfaceOffset()
		{
			return WBP_DebugPostProcessListEntry_C.__InterfaceOffset_IUserObjectListEntry;
		}

		// Token: 0x060260E6 RID: 155878 RVA: 0x0096A174 File Offset: 0x00968374
		public WBP_DebugPostProcessListEntry_C() : this(BuiltinUtils.AllocNativeUObject(WBP_DebugPostProcessListEntry_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260E7 RID: 155879 RVA: 0x0096A19C File Offset: 0x0096839C
		[NullableContext(1)]
		public WBP_DebugPostProcessListEntry_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WBP_DebugPostProcessListEntry_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005032 RID: 20530
		// (get) Token: 0x060260E8 RID: 155880 RVA: 0x0096A1CF File Offset: 0x009683CF
		// (set) Token: 0x060260E9 RID: 155881 RVA: 0x0096A1E3 File Offset: 0x009683E3
		public unsafe UTextBlock ActorName
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005033 RID: 20531
		// (get) Token: 0x060260EA RID: 155882 RVA: 0x0096A1F8 File Offset: 0x009683F8
		// (set) Token: 0x060260EB RID: 155883 RVA: 0x0096A20C File Offset: 0x0096840C
		public unsafe UImage BG
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005034 RID: 20532
		// (get) Token: 0x060260EC RID: 155884 RVA: 0x0096A221 File Offset: 0x00968421
		// (set) Token: 0x060260ED RID: 155885 RVA: 0x0096A235 File Offset: 0x00968435
		public unsafe UTextBlock BlendWeight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005035 RID: 20533
		// (get) Token: 0x060260EE RID: 155886 RVA: 0x0096A24A File Offset: 0x0096844A
		// (set) Token: 0x060260EF RID: 155887 RVA: 0x0096A25E File Offset: 0x0096845E
		public unsafe UButton BtnDetail
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005036 RID: 20534
		// (get) Token: 0x060260F0 RID: 155888 RVA: 0x0096A273 File Offset: 0x00968473
		// (set) Token: 0x060260F1 RID: 155889 RVA: 0x0096A287 File Offset: 0x00968487
		public unsafe UButton BtnJump
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005037 RID: 20535
		// (get) Token: 0x060260F2 RID: 155890 RVA: 0x0096A29C File Offset: 0x0096849C
		// (set) Token: 0x060260F3 RID: 155891 RVA: 0x0096A2B0 File Offset: 0x009684B0
		public unsafe UTextBlock Component
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005038 RID: 20536
		// (get) Token: 0x060260F4 RID: 155892 RVA: 0x0096A2C5 File Offset: 0x009684C5
		// (set) Token: 0x060260F5 RID: 155893 RVA: 0x0096A2D9 File Offset: 0x009684D9
		public unsafe UTextBlock IsUnbound
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17005039 RID: 20537
		// (get) Token: 0x060260F6 RID: 155894 RVA: 0x0096A2EE File Offset: 0x009684EE
		// (set) Token: 0x060260F7 RID: 155895 RVA: 0x0096A302 File Offset: 0x00968502
		public unsafe UTextBlock IsVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x1700503A RID: 20538
		// (get) Token: 0x060260F8 RID: 155896 RVA: 0x0096A317 File Offset: 0x00968517
		// (set) Token: 0x060260F9 RID: 155897 RVA: 0x0096A32B File Offset: 0x0096852B
		public unsafe UTextBlock LBlendWeight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x1700503B RID: 20539
		// (get) Token: 0x060260FA RID: 155898 RVA: 0x0096A340 File Offset: 0x00968540
		// (set) Token: 0x060260FB RID: 155899 RVA: 0x0096A354 File Offset: 0x00968554
		public unsafe UTextBlock OverrideProperties
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x1700503C RID: 20540
		// (get) Token: 0x060260FC RID: 155900 RVA: 0x0096A369 File Offset: 0x00968569
		// (set) Token: 0x060260FD RID: 155901 RVA: 0x0096A37D File Offset: 0x0096857D
		public unsafe UTextBlock Pri
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x1700503D RID: 20541
		// (get) Token: 0x060260FE RID: 155902 RVA: 0x0096A392 File Offset: 0x00968592
		// (set) Token: 0x060260FF RID: 155903 RVA: 0x0096A3A6 File Offset: 0x009685A6
		public unsafe UTextBlock TxtPropertiesBlock
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x1700503E RID: 20542
		// (get) Token: 0x06026100 RID: 155904 RVA: 0x0096A3BB File Offset: 0x009685BB
		// (set) Token: 0x06026101 RID: 155905 RVA: 0x0096A3CF File Offset: 0x009685CF
		public unsafe UTextBlock WeatherDa
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x1700503F RID: 20543
		// (get) Token: 0x06026102 RID: 155906 RVA: 0x0096A3E4 File Offset: 0x009685E4
		// (set) Token: 0x06026103 RID: 155907 RVA: 0x0096A3F8 File Offset: 0x009685F8
		public unsafe UTextBlock WPri
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcessListEntry_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17005040 RID: 20544
		// (get) Token: 0x06026104 RID: 155908 RVA: 0x0096A40D File Offset: 0x0096860D
		// (set) Token: 0x06026105 RID: 155909 RVA: 0x0096A41D File Offset: 0x0096861D
		public unsafe bool HasOverrideProperties
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_DebugPostProcessListEntry_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_DebugPostProcessListEntry_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005041 RID: 20545
		// (get) Token: 0x06026106 RID: 155910 RVA: 0x0096A430 File Offset: 0x00968630
		// (set) Token: 0x06026107 RID: 155911 RVA: 0x0096A469 File Offset: 0x00968669
		[Nullable(1)]
		public FPostprocessGIDebugInfo PostInfo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPostprocessGIDebugInfo result;
				if ((result = this._PostInfo) == null)
				{
					result = (this._PostInfo = new FPostprocessGIDebugInfo(base.NativePtr + (IntPtr)WBP_DebugPostProcessListEntry_C.__PropertyOffset_16, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPostprocessGIDebugInfo.StaticStruct(), base.NativePtr + (IntPtr)WBP_DebugPostProcessListEntry_C.__PropertyOffset_16, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026108 RID: 155912 RVA: 0x0096A48C File Offset: 0x0096868C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetItemInfo(bool IsOverrideType, FPostprocessGIDebugInfo InputPostInfo)
		{
			WBP_DebugPostProcessListEntry_C.__SetItemInfo_FunctionParams* ptr = stackalloc WBP_DebugPostProcessListEntry_C.__SetItemInfo_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(WBP_DebugPostProcessListEntry_C.__SetItemInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugPostProcessListEntry_C.__SetItemInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsOverrideType = IsOverrideType;
			if (InputPostInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPostprocessGIDebugInfo.StaticStruct(), &ptr->InputPostInfo, InputPostInfo.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugPostProcessListEntry_C.__SetItemInfo_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(WBP_DebugPostProcessListEntry_C.__SetItemInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026109 RID: 155913 RVA: 0x0096A508 File Offset: 0x00968708
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BP_OnItemExpansionChanged(bool bIsExpanded)
		{
			WBP_DebugPostProcessListEntry_C.__BP_OnItemExpansionChanged_FunctionParams* ptr = stackalloc WBP_DebugPostProcessListEntry_C.__BP_OnItemExpansionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(WBP_DebugPostProcessListEntry_C.__BP_OnItemExpansionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugPostProcessListEntry_C.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsExpanded = bIsExpanded;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugPostProcessListEntry_C.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602610A RID: 155914 RVA: 0x0096A550 File Offset: 0x00968750
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BP_OnItemExpansionChanged_Implementation(bool bIsExpanded)
		{
			WBP_DebugPostProcessListEntry_C.__BP_OnItemExpansionChanged_FunctionParams* ptr = stackalloc WBP_DebugPostProcessListEntry_C.__BP_OnItemExpansionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(WBP_DebugPostProcessListEntry_C.__BP_OnItemExpansionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugPostProcessListEntry_C.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsExpanded = bIsExpanded;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_DebugPostProcessListEntry_C.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602610B RID: 155915 RVA: 0x0096A598 File Offset: 0x00968798
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BP_OnItemSelectionChanged(bool bIsSelected)
		{
			WBP_DebugPostProcessListEntry_C.__BP_OnItemSelectionChanged_FunctionParams* ptr = stackalloc WBP_DebugPostProcessListEntry_C.__BP_OnItemSelectionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(WBP_DebugPostProcessListEntry_C.__BP_OnItemSelectionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugPostProcessListEntry_C.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsSelected = bIsSelected;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugPostProcessListEntry_C.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602610C RID: 155916 RVA: 0x0096A5E0 File Offset: 0x009687E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BP_OnItemSelectionChanged_Implementation(bool bIsSelected)
		{
			WBP_DebugPostProcessListEntry_C.__BP_OnItemSelectionChanged_FunctionParams* ptr = stackalloc WBP_DebugPostProcessListEntry_C.__BP_OnItemSelectionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(WBP_DebugPostProcessListEntry_C.__BP_OnItemSelectionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugPostProcessListEntry_C.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsSelected = bIsSelected;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_DebugPostProcessListEntry_C.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602610D RID: 155917 RVA: 0x0096A628 File Offset: 0x00968828
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnListItemObjectSet(UObject ListItemObject)
		{
			WBP_DebugPostProcessListEntry_C.__OnListItemObjectSet_FunctionParams* ptr = stackalloc WBP_DebugPostProcessListEntry_C.__OnListItemObjectSet_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(WBP_DebugPostProcessListEntry_C.__OnListItemObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugPostProcessListEntry_C.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ListItemObject = ((ListItemObject != null) ? ListItemObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugPostProcessListEntry_C.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602610E RID: 155918 RVA: 0x0096A680 File Offset: 0x00968880
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnListItemObjectSet_Implementation(UObject ListItemObject)
		{
			WBP_DebugPostProcessListEntry_C.__OnListItemObjectSet_FunctionParams* ptr = stackalloc WBP_DebugPostProcessListEntry_C.__OnListItemObjectSet_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(WBP_DebugPostProcessListEntry_C.__OnListItemObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugPostProcessListEntry_C.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ListItemObject = ((ListItemObject != null) ? ListItemObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_DebugPostProcessListEntry_C.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602610F RID: 155919 RVA: 0x0096A6D6 File Offset: 0x009688D6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BP_OnEntryReleased()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugPostProcessListEntry_C.__BP_OnEntryReleased_NativeFunctionPtr, null);
		}

		// Token: 0x06026110 RID: 155920 RVA: 0x0096A6EA File Offset: 0x009688EA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BP_OnEntryReleased_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_DebugPostProcessListEntry_C.__BP_OnEntryReleased_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026111 RID: 155921 RVA: 0x0096A6FF File Offset: 0x009688FF
		protected WBP_DebugPostProcessListEntry_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130C4 RID: 78020
		internal static int __InterfaceOffset_IUserObjectListEntry;

		// Token: 0x040130C5 RID: 78021
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/UI/DebugPostProcess/WBP_DebugPostProcessListEntry.WBP_DebugPostProcessListEntry_C";

		// Token: 0x040130C6 RID: 78022
		private static IntPtr _ClassPtr;

		// Token: 0x040130C7 RID: 78023
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130C8 RID: 78024
		internal static int __PropertyOffset_1;

		// Token: 0x040130C9 RID: 78025
		internal static int __PropertyOffset_2;

		// Token: 0x040130CA RID: 78026
		internal static int __PropertyOffset_3;

		// Token: 0x040130CB RID: 78027
		internal static int __PropertyOffset_4;

		// Token: 0x040130CC RID: 78028
		internal static int __PropertyOffset_5;

		// Token: 0x040130CD RID: 78029
		internal static int __PropertyOffset_6;

		// Token: 0x040130CE RID: 78030
		internal static int __PropertyOffset_7;

		// Token: 0x040130CF RID: 78031
		internal static int __PropertyOffset_8;

		// Token: 0x040130D0 RID: 78032
		internal static int __PropertyOffset_9;

		// Token: 0x040130D1 RID: 78033
		internal static int __PropertyOffset_10;

		// Token: 0x040130D2 RID: 78034
		internal static int __PropertyOffset_11;

		// Token: 0x040130D3 RID: 78035
		internal static int __PropertyOffset_12;

		// Token: 0x040130D4 RID: 78036
		internal static int __PropertyOffset_13;

		// Token: 0x040130D5 RID: 78037
		internal static int __PropertyOffset_14;

		// Token: 0x040130D6 RID: 78038
		internal static int __PropertyOffset_15;

		// Token: 0x040130D7 RID: 78039
		internal static int __PropertyOffset_16;

		// Token: 0x040130D8 RID: 78040
		private FPostprocessGIDebugInfo _PostInfo;

		// Token: 0x040130D9 RID: 78041
		private static IntPtr __SetItemInfo_NativeFunctionPtr;

		// Token: 0x040130DA RID: 78042
		private static IntPtr __BP_OnItemExpansionChanged_NativeFunctionPtr;

		// Token: 0x040130DB RID: 78043
		private static IntPtr __BP_OnItemSelectionChanged_NativeFunctionPtr;

		// Token: 0x040130DC RID: 78044
		private static IntPtr __OnListItemObjectSet_NativeFunctionPtr;

		// Token: 0x040130DD RID: 78045
		private static IntPtr __BP_OnEntryReleased_NativeFunctionPtr;

		// Token: 0x0200A08D RID: 41101
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __SetItemInfo_FunctionParams
		{
			// Token: 0x04031B87 RID: 203655
			[FieldOffset(0)]
			public bool IsOverrideType;

			// Token: 0x04031B88 RID: 203656
			[FieldOffset(8)]
			public byte InputPostInfo;
		}

		// Token: 0x0200A08E RID: 41102
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __BP_OnItemExpansionChanged_FunctionParams
		{
			// Token: 0x04031B89 RID: 203657
			[FieldOffset(0)]
			public bool bIsExpanded;
		}

		// Token: 0x0200A08F RID: 41103
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __BP_OnItemSelectionChanged_FunctionParams
		{
			// Token: 0x04031B8A RID: 203658
			[FieldOffset(0)]
			public bool bIsSelected;
		}

		// Token: 0x0200A090 RID: 41104
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnListItemObjectSet_FunctionParams
		{
			// Token: 0x04031B8B RID: 203659
			[FieldOffset(0)]
			public IntPtr ListItemObject;
		}
	}
}
