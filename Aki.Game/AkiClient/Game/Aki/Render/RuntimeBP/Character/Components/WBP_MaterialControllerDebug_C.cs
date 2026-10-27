using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Components
{
	// Token: 0x02003E2F RID: 15919
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Components/WBP_MaterialControllerDebug.WBP_MaterialControllerDebug_C")]
	[UnrealStructLayout(1288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1282)]
	public class WBP_MaterialControllerDebug_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027ED0 RID: 163536 RVA: 0x0099F740 File Offset: 0x0099D940
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WBP_MaterialControllerDebug_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Components/WBP_MaterialControllerDebug.WBP_MaterialControllerDebug_C");
			}
			return WBP_MaterialControllerDebug_C._ClassPtr;
		}

		// Token: 0x06027ED1 RID: 163537 RVA: 0x0099F764 File Offset: 0x0099D964
		public WBP_MaterialControllerDebug_C() : this(BuiltinUtils.AllocNativeUObject(WBP_MaterialControllerDebug_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027ED2 RID: 163538 RVA: 0x0099F78C File Offset: 0x0099D98C
		[NullableContext(1)]
		public WBP_MaterialControllerDebug_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WBP_MaterialControllerDebug_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005AC4 RID: 23236
		// (get) Token: 0x06027ED3 RID: 163539 RVA: 0x0099F7BF File Offset: 0x0099D9BF
		// (set) Token: 0x06027ED4 RID: 163540 RVA: 0x0099F7D3 File Offset: 0x0099D9D3
		public unsafe UButton Button_122
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005AC5 RID: 23237
		// (get) Token: 0x06027ED5 RID: 163541 RVA: 0x0099F7E8 File Offset: 0x0099D9E8
		// (set) Token: 0x06027ED6 RID: 163542 RVA: 0x0099F7FC File Offset: 0x0099D9FC
		public unsafe UButton Button_368
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005AC6 RID: 23238
		// (get) Token: 0x06027ED7 RID: 163543 RVA: 0x0099F811 File Offset: 0x0099DA11
		// (set) Token: 0x06027ED8 RID: 163544 RVA: 0x0099F825 File Offset: 0x0099DA25
		public unsafe UButton Button_453
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005AC7 RID: 23239
		// (get) Token: 0x06027ED9 RID: 163545 RVA: 0x0099F83A File Offset: 0x0099DA3A
		// (set) Token: 0x06027EDA RID: 163546 RVA: 0x0099F84E File Offset: 0x0099DA4E
		public unsafe UButton Button_575
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005AC8 RID: 23240
		// (get) Token: 0x06027EDB RID: 163547 RVA: 0x0099F863 File Offset: 0x0099DA63
		// (set) Token: 0x06027EDC RID: 163548 RVA: 0x0099F877 File Offset: 0x0099DA77
		public unsafe UComboBoxString CharacterSelector
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UComboBoxString>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005AC9 RID: 23241
		// (get) Token: 0x06027EDD RID: 163549 RVA: 0x0099F88C File Offset: 0x0099DA8C
		// (set) Token: 0x06027EDE RID: 163550 RVA: 0x0099F8A0 File Offset: 0x0099DAA0
		public unsafe UButton CloseButton
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005ACA RID: 23242
		// (get) Token: 0x06027EDF RID: 163551 RVA: 0x0099F8B5 File Offset: 0x0099DAB5
		// (set) Token: 0x06027EE0 RID: 163552 RVA: 0x0099F8C9 File Offset: 0x0099DAC9
		public unsafe UImage Image_105
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17005ACB RID: 23243
		// (get) Token: 0x06027EE1 RID: 163553 RVA: 0x0099F8DE File Offset: 0x0099DADE
		// (set) Token: 0x06027EE2 RID: 163554 RVA: 0x0099F8F2 File Offset: 0x0099DAF2
		public unsafe UImage Image_Mask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005ACC RID: 23244
		// (get) Token: 0x06027EE3 RID: 163555 RVA: 0x0099F907 File Offset: 0x0099DB07
		// (set) Token: 0x06027EE4 RID: 163556 RVA: 0x0099F91B File Offset: 0x0099DB1B
		public unsafe UMultiLineEditableTextBox MaterialEffects
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMultiLineEditableTextBox>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17005ACD RID: 23245
		// (get) Token: 0x06027EE5 RID: 163557 RVA: 0x0099F930 File Offset: 0x0099DB30
		// (set) Token: 0x06027EE6 RID: 163558 RVA: 0x0099F944 File Offset: 0x0099DB44
		public unsafe UMultiLineEditableTextBox SectionEffect
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMultiLineEditableTextBox>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17005ACE RID: 23246
		// (get) Token: 0x06027EE7 RID: 163559 RVA: 0x0099F959 File Offset: 0x0099DB59
		// (set) Token: 0x06027EE8 RID: 163560 RVA: 0x0099F96D File Offset: 0x0099DB6D
		public unsafe UMultiLineEditableTextBox SectionList
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMultiLineEditableTextBox>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17005ACF RID: 23247
		// (get) Token: 0x06027EE9 RID: 163561 RVA: 0x0099F982 File Offset: 0x0099DB82
		// (set) Token: 0x06027EEA RID: 163562 RVA: 0x0099F996 File Offset: 0x0099DB96
		public unsafe UWidgetSwitcher WidgetSwitcher_248
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidgetSwitcher>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17005AD0 RID: 23248
		// (get) Token: 0x06027EEB RID: 163563 RVA: 0x0099F9AB File Offset: 0x0099DBAB
		// (set) Token: 0x06027EEC RID: 163564 RVA: 0x0099F9BF File Offset: 0x0099DBBF
		public unsafe UComboBoxString 选取方式Combox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UComboBoxString>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_MaterialControllerDebug_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17005AD1 RID: 23249
		// (get) Token: 0x06027EED RID: 163565 RVA: 0x0099F9D4 File Offset: 0x0099DBD4
		// (set) Token: 0x06027EEE RID: 163566 RVA: 0x0099F9E4 File Offset: 0x0099DBE4
		public unsafe bool 跟踪换人
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_MaterialControllerDebug_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_MaterialControllerDebug_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005AD2 RID: 23250
		// (get) Token: 0x06027EEF RID: 163567 RVA: 0x0099F9F5 File Offset: 0x0099DBF5
		// (set) Token: 0x06027EF0 RID: 163568 RVA: 0x0099FA05 File Offset: 0x0099DC05
		public unsafe bool 鼠标选择
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_MaterialControllerDebug_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_MaterialControllerDebug_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x06027EF1 RID: 163569 RVA: 0x0099FA18 File Offset: 0x0099DC18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetSectionInfo([Nullable(new byte[]
		{
			2,
			1
		})] TMap<string, SMaterialDebugInfo> SectionInfo)
		{
			WBP_MaterialControllerDebug_C.__SetSectionInfo_FunctionParams* ptr = stackalloc WBP_MaterialControllerDebug_C.__SetSectionInfo_FunctionParams[(UIntPtr)351] + 15L / (long)sizeof(WBP_MaterialControllerDebug_C.__SetSectionInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_MaterialControllerDebug_C.__SetSectionInfo_NativeFunctionPtr, (void*)ptr, 1);
			if (SectionInfo != null)
			{
				SectionInfo.CopyTo(&ptr->SectionInfo, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_MaterialControllerDebug_C.__SetSectionInfo_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(WBP_MaterialControllerDebug_C.__SetSectionInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027EF2 RID: 163570 RVA: 0x0099FA84 File Offset: 0x0099DC84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCurrentCharacter(ref TsBaseCharacter Character)
		{
			WBP_MaterialControllerDebug_C.__GetCurrentCharacter_FunctionParams* ptr = stackalloc WBP_MaterialControllerDebug_C.__GetCurrentCharacter_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(WBP_MaterialControllerDebug_C.__GetCurrentCharacter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_MaterialControllerDebug_C.__GetCurrentCharacter_NativeFunctionPtr, (void*)ptr, 1);
			ref WBP_MaterialControllerDebug_C.__GetCurrentCharacter_FunctionParams ptr2 = ref *ptr;
			TsBaseCharacter tsBaseCharacter = Character;
			ptr2.Character = ((tsBaseCharacter != null) ? tsBaseCharacter.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_MaterialControllerDebug_C.__GetCurrentCharacter_NativeFunctionPtr, (void*)ptr);
			Character = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(ptr->Character);
		}

		// Token: 0x06027EF3 RID: 163571 RVA: 0x0099FAE8 File Offset: 0x0099DCE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(1)]
		public unsafe virtual FEventReply On_Image_Mask_MouseButtonDown_0(FGeometry MyGeometry, in FPointerEvent MouseEvent)
		{
			WBP_MaterialControllerDebug_C.__On_Image_Mask_MouseButtonDown_0_FunctionParams* ptr = stackalloc WBP_MaterialControllerDebug_C.__On_Image_Mask_MouseButtonDown_0_FunctionParams[(UIntPtr)575] + 15L / (long)sizeof(WBP_MaterialControllerDebug_C.__On_Image_Mask_MouseButtonDown_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_MaterialControllerDebug_C.__On_Image_Mask_MouseButtonDown_0_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			if (MouseEvent != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPointerEvent.StaticStruct(), &ptr->MouseEvent, MouseEvent.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_MaterialControllerDebug_C.__On_Image_Mask_MouseButtonDown_0_NativeFunctionPtr, (void*)ptr);
			FEventReply result = new FEventReply(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(WBP_MaterialControllerDebug_C.__On_Image_Mask_MouseButtonDown_0_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06027EF4 RID: 163572 RVA: 0x0099FB90 File Offset: 0x0099DD90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateDebugInfo(TsBaseCharacter Character)
		{
			WBP_MaterialControllerDebug_C.__UpdateDebugInfo_FunctionParams* ptr = stackalloc WBP_MaterialControllerDebug_C.__UpdateDebugInfo_FunctionParams[(UIntPtr)223] + 15L / (long)sizeof(WBP_MaterialControllerDebug_C.__UpdateDebugInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_MaterialControllerDebug_C.__UpdateDebugInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_MaterialControllerDebug_C.__UpdateDebugInfo_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027EF5 RID: 163573 RVA: 0x0099FBE8 File Offset: 0x0099DDE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void WhenRoleChange()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_MaterialControllerDebug_C.__WhenRoleChange_NativeFunctionPtr, null);
		}

		// Token: 0x06027EF6 RID: 163574 RVA: 0x0099FBFC File Offset: 0x0099DDFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CharacterSelectorInit([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> Options)
		{
			WBP_MaterialControllerDebug_C.__CharacterSelectorInit_FunctionParams* ptr = stackalloc WBP_MaterialControllerDebug_C.__CharacterSelectorInit_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(WBP_MaterialControllerDebug_C.__CharacterSelectorInit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_MaterialControllerDebug_C.__CharacterSelectorInit_NativeFunctionPtr, (void*)ptr, 1);
			TArray<string> tarray = Options;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Options);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_MaterialControllerDebug_C.__CharacterSelectorInit_NativeFunctionPtr, (void*)ptr);
			TArray<string> tarray2 = Options;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Options);
			}
			UnrealReflectionUtils.DestroyStruct(WBP_MaterialControllerDebug_C.__CharacterSelectorInit_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027EF7 RID: 163575 RVA: 0x0099FC74 File Offset: 0x0099DE74
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CharacterSelectorDelete(string Option)
		{
			WBP_MaterialControllerDebug_C.__CharacterSelectorDelete_FunctionParams* ptr = stackalloc WBP_MaterialControllerDebug_C.__CharacterSelectorDelete_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(WBP_MaterialControllerDebug_C.__CharacterSelectorDelete_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_MaterialControllerDebug_C.__CharacterSelectorDelete_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Option), Option);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_MaterialControllerDebug_C.__CharacterSelectorDelete_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(WBP_MaterialControllerDebug_C.__CharacterSelectorDelete_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027EF8 RID: 163576 RVA: 0x0099FCD4 File Offset: 0x0099DED4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CharacterSelectorAdd(string Option)
		{
			WBP_MaterialControllerDebug_C.__CharacterSelectorAdd_FunctionParams* ptr = stackalloc WBP_MaterialControllerDebug_C.__CharacterSelectorAdd_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(WBP_MaterialControllerDebug_C.__CharacterSelectorAdd_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_MaterialControllerDebug_C.__CharacterSelectorAdd_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Option), Option);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_MaterialControllerDebug_C.__CharacterSelectorAdd_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(WBP_MaterialControllerDebug_C.__CharacterSelectorAdd_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027EF9 RID: 163577 RVA: 0x0099FD34 File Offset: 0x0099DF34
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_MaterialControllerDebug_选取方式Combox_K2Node_ComponentBoundEvent_1_OnSelectionChangedEvent__DelegateSignature(string SelectedItem, ESelectInfo SelectionType)
		{
			WBP_MaterialControllerDebug_C.__BndEvt__BP_MaterialControllerDebug_选取方式Combox_K2Node_ComponentBoundEvent_1_OnSelectionChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc WBP_MaterialControllerDebug_C.__BndEvt__BP_MaterialControllerDebug_选取方式Combox_K2Node_ComponentBoundEvent_1_OnSelectionChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(WBP_MaterialControllerDebug_C.__BndEvt__BP_MaterialControllerDebug_选取方式Combox_K2Node_ComponentBoundEvent_1_OnSelectionChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_MaterialControllerDebug_C.__BndEvt__BP_MaterialControllerDebug_选取方式Combox_K2Node_ComponentBoundEvent_1_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SelectedItem), SelectedItem);
			ptr->SelectionType = SelectionType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_MaterialControllerDebug_C.__BndEvt__BP_MaterialControllerDebug_选取方式Combox_K2Node_ComponentBoundEvent_1_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(WBP_MaterialControllerDebug_C.__BndEvt__BP_MaterialControllerDebug_选取方式Combox_K2Node_ComponentBoundEvent_1_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027EFA RID: 163578 RVA: 0x0099FD9D File Offset: 0x0099DF9D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBegin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_MaterialControllerDebug_C.__OnBegin_NativeFunctionPtr, null);
		}

		// Token: 0x06027EFB RID: 163579 RVA: 0x0099FDB1 File Offset: 0x0099DFB1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnEnd_1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_MaterialControllerDebug_C.__OnEnd_1_NativeFunctionPtr, null);
		}

		// Token: 0x06027EFC RID: 163580 RVA: 0x0099FDC5 File Offset: 0x0099DFC5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__BP_MaterialControllerDebug_CloseButton_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_MaterialControllerDebug_C.__BndEvt__BP_MaterialControllerDebug_CloseButton_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06027EFD RID: 163581 RVA: 0x0099FDDC File Offset: 0x0099DFDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Tick(FGeometry MyGeometry, float InDeltaTime)
		{
			WBP_MaterialControllerDebug_C.__Tick_FunctionParams* ptr = stackalloc WBP_MaterialControllerDebug_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(WBP_MaterialControllerDebug_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_MaterialControllerDebug_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_MaterialControllerDebug_C.__Tick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027EFE RID: 163582 RVA: 0x0099FE44 File Offset: 0x0099E044
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void Tick_Implementation(FGeometry MyGeometry, float InDeltaTime)
		{
			WBP_MaterialControllerDebug_C.__Tick_FunctionParams* ptr = stackalloc WBP_MaterialControllerDebug_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(WBP_MaterialControllerDebug_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_MaterialControllerDebug_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_MaterialControllerDebug_C.__Tick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027EFF RID: 163583 RVA: 0x0099FEAD File Offset: 0x0099E0AD
		protected WBP_MaterialControllerDebug_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014434 RID: 82996
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Components/WBP_MaterialControllerDebug.WBP_MaterialControllerDebug_C";

		// Token: 0x04014435 RID: 82997
		private static IntPtr _ClassPtr;

		// Token: 0x04014436 RID: 82998
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014437 RID: 82999
		internal static int __PropertyOffset_1;

		// Token: 0x04014438 RID: 83000
		internal static int __PropertyOffset_2;

		// Token: 0x04014439 RID: 83001
		internal static int __PropertyOffset_3;

		// Token: 0x0401443A RID: 83002
		internal static int __PropertyOffset_4;

		// Token: 0x0401443B RID: 83003
		internal static int __PropertyOffset_5;

		// Token: 0x0401443C RID: 83004
		internal static int __PropertyOffset_6;

		// Token: 0x0401443D RID: 83005
		internal static int __PropertyOffset_7;

		// Token: 0x0401443E RID: 83006
		internal static int __PropertyOffset_8;

		// Token: 0x0401443F RID: 83007
		internal static int __PropertyOffset_9;

		// Token: 0x04014440 RID: 83008
		internal static int __PropertyOffset_10;

		// Token: 0x04014441 RID: 83009
		internal static int __PropertyOffset_11;

		// Token: 0x04014442 RID: 83010
		internal static int __PropertyOffset_12;

		// Token: 0x04014443 RID: 83011
		internal static int __PropertyOffset_13;

		// Token: 0x04014444 RID: 83012
		internal static int __PropertyOffset_14;

		// Token: 0x04014445 RID: 83013
		internal static int __PropertyOffset_15;

		// Token: 0x04014446 RID: 83014
		private static IntPtr __SetSectionInfo_NativeFunctionPtr;

		// Token: 0x04014447 RID: 83015
		private static IntPtr __GetCurrentCharacter_NativeFunctionPtr;

		// Token: 0x04014448 RID: 83016
		private static IntPtr __On_Image_Mask_MouseButtonDown_0_NativeFunctionPtr;

		// Token: 0x04014449 RID: 83017
		private static IntPtr __UpdateDebugInfo_NativeFunctionPtr;

		// Token: 0x0401444A RID: 83018
		private static IntPtr __WhenRoleChange_NativeFunctionPtr;

		// Token: 0x0401444B RID: 83019
		private static IntPtr __CharacterSelectorInit_NativeFunctionPtr;

		// Token: 0x0401444C RID: 83020
		private static IntPtr __CharacterSelectorDelete_NativeFunctionPtr;

		// Token: 0x0401444D RID: 83021
		private static IntPtr __CharacterSelectorAdd_NativeFunctionPtr;

		// Token: 0x0401444E RID: 83022
		private static IntPtr __BndEvt__BP_MaterialControllerDebug_选取方式Combox_K2Node_ComponentBoundEvent_1_OnSelectionChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401444F RID: 83023
		private static IntPtr __OnBegin_NativeFunctionPtr;

		// Token: 0x04014450 RID: 83024
		private static IntPtr __OnEnd_1_NativeFunctionPtr;

		// Token: 0x04014451 RID: 83025
		private static IntPtr __BndEvt__BP_MaterialControllerDebug_CloseButton_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04014452 RID: 83026
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x0200A2A8 RID: 41640
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 336)]
		protected ref struct __SetSectionInfo_FunctionParams
		{
			// Token: 0x04031FCC RID: 204748
			[FieldOffset(0)]
			public byte SectionInfo;
		}

		// Token: 0x0200A2A9 RID: 41641
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetCurrentCharacter_FunctionParams
		{
			// Token: 0x04031FCD RID: 204749
			[FieldOffset(0)]
			public IntPtr Character;
		}

		// Token: 0x0200A2AA RID: 41642
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 560)]
		protected ref struct __On_Image_Mask_MouseButtonDown_0_FunctionParams
		{
			// Token: 0x04031FCE RID: 204750
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04031FCF RID: 204751
			[FieldOffset(56)]
			public byte MouseEvent;

			// Token: 0x04031FD0 RID: 204752
			[FieldOffset(176)]
			public byte __Result;
		}

		// Token: 0x0200A2AB RID: 41643
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __UpdateDebugInfo_FunctionParams
		{
			// Token: 0x04031FD1 RID: 204753
			[FieldOffset(0)]
			public IntPtr Character;
		}

		// Token: 0x0200A2AC RID: 41644
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __CharacterSelectorInit_FunctionParams
		{
			// Token: 0x04031FD2 RID: 204754
			[FieldOffset(0)]
			public byte Options;
		}

		// Token: 0x0200A2AD RID: 41645
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __CharacterSelectorDelete_FunctionParams
		{
			// Token: 0x04031FD3 RID: 204755
			[FieldOffset(0)]
			public FString Option;
		}

		// Token: 0x0200A2AE RID: 41646
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __CharacterSelectorAdd_FunctionParams
		{
			// Token: 0x04031FD4 RID: 204756
			[FieldOffset(0)]
			public FString Option;
		}

		// Token: 0x0200A2AF RID: 41647
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __BndEvt__BP_MaterialControllerDebug_选取方式Combox_K2Node_ComponentBoundEvent_1_OnSelectionChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031FD5 RID: 204757
			[FieldOffset(0)]
			public FString SelectedItem;

			// Token: 0x04031FD6 RID: 204758
			[FieldOffset(16)]
			public TEnumAsByte<ESelectInfo> SelectionType;
		}

		// Token: 0x0200A2B0 RID: 41648
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected new ref struct __Tick_FunctionParams
		{
			// Token: 0x04031FD7 RID: 204759
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04031FD8 RID: 204760
			[FieldOffset(56)]
			public float InDeltaTime;
		}
	}
}
