using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.UI.Module.Common.View.Widget;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.UI.DebugPostProcess
{
	// Token: 0x02003D3C RID: 15676
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/UI/DebugPostProcess/WBP_DebugPostProcess.WBP_DebugPostProcess_C")]
	[UnrealStructLayout(1248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1244)]
	public class WBP_DebugPostProcess_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026112 RID: 155922 RVA: 0x0096A708 File Offset: 0x00968908
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WBP_DebugPostProcess_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/UI/DebugPostProcess/WBP_DebugPostProcess.WBP_DebugPostProcess_C");
			}
			return WBP_DebugPostProcess_C._ClassPtr;
		}

		// Token: 0x06026113 RID: 155923 RVA: 0x0096A72C File Offset: 0x0096892C
		public WBP_DebugPostProcess_C() : this(BuiltinUtils.AllocNativeUObject(WBP_DebugPostProcess_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026114 RID: 155924 RVA: 0x0096A754 File Offset: 0x00968954
		[NullableContext(1)]
		public WBP_DebugPostProcess_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WBP_DebugPostProcess_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005042 RID: 20546
		// (get) Token: 0x06026115 RID: 155925 RVA: 0x0096A787 File Offset: 0x00968987
		// (set) Token: 0x06026116 RID: 155926 RVA: 0x0096A79B File Offset: 0x0096899B
		public unsafe KuroImage_C BG
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<KuroImage_C>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcess_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcess_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005043 RID: 20547
		// (get) Token: 0x06026117 RID: 155927 RVA: 0x0096A7B0 File Offset: 0x009689B0
		// (set) Token: 0x06026118 RID: 155928 RVA: 0x0096A7C4 File Offset: 0x009689C4
		public unsafe UButton BtnClose
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcess_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcess_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005044 RID: 20548
		// (get) Token: 0x06026119 RID: 155929 RVA: 0x0096A7D9 File Offset: 0x009689D9
		// (set) Token: 0x0602611A RID: 155930 RVA: 0x0096A7ED File Offset: 0x009689ED
		public unsafe UButton Button_46
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcess_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcess_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005045 RID: 20549
		// (get) Token: 0x0602611B RID: 155931 RVA: 0x0096A802 File Offset: 0x00968A02
		// (set) Token: 0x0602611C RID: 155932 RVA: 0x0096A816 File Offset: 0x00968A16
		public unsafe UCheckBox CheckIsAutoRefresh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCheckBox>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcess_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcess_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005046 RID: 20550
		// (get) Token: 0x0602611D RID: 155933 RVA: 0x0096A82B File Offset: 0x00968A2B
		// (set) Token: 0x0602611E RID: 155934 RVA: 0x0096A83F File Offset: 0x00968A3F
		public unsafe UComboBoxString ComboBoxString_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UComboBoxString>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcess_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcess_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005047 RID: 20551
		// (get) Token: 0x0602611F RID: 155935 RVA: 0x0096A854 File Offset: 0x00968A54
		// (set) Token: 0x06026120 RID: 155936 RVA: 0x0096A868 File Offset: 0x00968A68
		public unsafe UListView ListInfo
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UListView>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcess_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcess_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005048 RID: 20552
		// (get) Token: 0x06026121 RID: 155937 RVA: 0x0096A87D File Offset: 0x00968A7D
		// (set) Token: 0x06026122 RID: 155938 RVA: 0x0096A891 File Offset: 0x00968A91
		public unsafe KuroImage_C TitleBG
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<KuroImage_C>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcess_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcess_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17005049 RID: 20553
		// (get) Token: 0x06026123 RID: 155939 RVA: 0x0096A8A6 File Offset: 0x00968AA6
		// (set) Token: 0x06026124 RID: 155940 RVA: 0x0096A8BA File Offset: 0x00968ABA
		public unsafe UWidgetSwitcher WidgetSwitcher_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidgetSwitcher>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcess_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugPostProcess_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x1700504A RID: 20554
		// (get) Token: 0x06026125 RID: 155941 RVA: 0x0096A8CF File Offset: 0x00968ACF
		// (set) Token: 0x06026126 RID: 155942 RVA: 0x0096A8DF File Offset: 0x00968ADF
		public unsafe float Timer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_DebugPostProcess_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_DebugPostProcess_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x06026127 RID: 155943 RVA: 0x0096A8F0 File Offset: 0x00968AF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugPostProcess_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x06026128 RID: 155944 RVA: 0x0096A904 File Offset: 0x00968B04
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual FText Get_TxtPostProcessCount_ToolTipText_0()
		{
			WBP_DebugPostProcess_C.__Get_TxtPostProcessCount_ToolTipText_0_FunctionParams* ptr = stackalloc WBP_DebugPostProcess_C.__Get_TxtPostProcessCount_ToolTipText_0_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(WBP_DebugPostProcess_C.__Get_TxtPostProcessCount_ToolTipText_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugPostProcess_C.__Get_TxtPostProcessCount_ToolTipText_0_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugPostProcess_C.__Get_TxtPostProcessCount_ToolTipText_0_NativeFunctionPtr, (void*)ptr);
			FText result = new FText(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(WBP_DebugPostProcess_C.__Get_TxtPostProcessCount_ToolTipText_0_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06026129 RID: 155945 RVA: 0x0096A962 File Offset: 0x00968B62
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__WBP_DebugPostProcess_BtnClose_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugPostProcess_C.__BndEvt__WBP_DebugPostProcess_BtnClose_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602612A RID: 155946 RVA: 0x0096A978 File Offset: 0x00968B78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Tick(FGeometry MyGeometry, float InDeltaTime)
		{
			WBP_DebugPostProcess_C.__Tick_FunctionParams* ptr = stackalloc WBP_DebugPostProcess_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(WBP_DebugPostProcess_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugPostProcess_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugPostProcess_C.__Tick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602612B RID: 155947 RVA: 0x0096A9E0 File Offset: 0x00968BE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void Tick_Implementation(FGeometry MyGeometry, float InDeltaTime)
		{
			WBP_DebugPostProcess_C.__Tick_FunctionParams* ptr = stackalloc WBP_DebugPostProcess_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(WBP_DebugPostProcess_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugPostProcess_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_DebugPostProcess_C.__Tick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602612C RID: 155948 RVA: 0x0096AA49 File Offset: 0x00968C49
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__WBP_DebugPostProcess_Button_46_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugPostProcess_C.__BndEvt__WBP_DebugPostProcess_Button_46_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602612D RID: 155949 RVA: 0x0096AA5D File Offset: 0x00968C5D
		protected WBP_DebugPostProcess_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130DE RID: 78046
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/UI/DebugPostProcess/WBP_DebugPostProcess.WBP_DebugPostProcess_C";

		// Token: 0x040130DF RID: 78047
		private static IntPtr _ClassPtr;

		// Token: 0x040130E0 RID: 78048
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130E1 RID: 78049
		internal static int __PropertyOffset_1;

		// Token: 0x040130E2 RID: 78050
		internal static int __PropertyOffset_2;

		// Token: 0x040130E3 RID: 78051
		internal static int __PropertyOffset_3;

		// Token: 0x040130E4 RID: 78052
		internal static int __PropertyOffset_4;

		// Token: 0x040130E5 RID: 78053
		internal static int __PropertyOffset_5;

		// Token: 0x040130E6 RID: 78054
		internal static int __PropertyOffset_6;

		// Token: 0x040130E7 RID: 78055
		internal static int __PropertyOffset_7;

		// Token: 0x040130E8 RID: 78056
		internal static int __PropertyOffset_8;

		// Token: 0x040130E9 RID: 78057
		internal static int __PropertyOffset_9;

		// Token: 0x040130EA RID: 78058
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x040130EB RID: 78059
		private static IntPtr __Get_TxtPostProcessCount_ToolTipText_0_NativeFunctionPtr;

		// Token: 0x040130EC RID: 78060
		private static IntPtr __BndEvt__WBP_DebugPostProcess_BtnClose_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040130ED RID: 78061
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x040130EE RID: 78062
		private static IntPtr __BndEvt__WBP_DebugPostProcess_Button_46_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0200A091 RID: 41105
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Get_TxtPostProcessCount_ToolTipText_0_FunctionParams
		{
			// Token: 0x04031B8C RID: 203660
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200A092 RID: 41106
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected new ref struct __Tick_FunctionParams
		{
			// Token: 0x04031B8D RID: 203661
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04031B8E RID: 203662
			[FieldOffset(56)]
			public float InDeltaTime;
		}
	}
}
