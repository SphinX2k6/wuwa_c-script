using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.UI.DebugDataLayer
{
	// Token: 0x02003D40 RID: 15680
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/UI/DebugDataLayer/WBP_DebugMPCTool.WBP_DebugMPCTool_C")]
	[UnrealStructLayout(1256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1256)]
	public class WBP_DebugMPCTool_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026163 RID: 156003 RVA: 0x0096B10C File Offset: 0x0096930C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WBP_DebugMPCTool_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/UI/DebugDataLayer/WBP_DebugMPCTool.WBP_DebugMPCTool_C");
			}
			return WBP_DebugMPCTool_C._ClassPtr;
		}

		// Token: 0x06026164 RID: 156004 RVA: 0x0096B130 File Offset: 0x00969330
		public WBP_DebugMPCTool_C() : this(BuiltinUtils.AllocNativeUObject(WBP_DebugMPCTool_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026165 RID: 156005 RVA: 0x0096B158 File Offset: 0x00969358
		[NullableContext(1)]
		public WBP_DebugMPCTool_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WBP_DebugMPCTool_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005058 RID: 20568
		// (get) Token: 0x06026166 RID: 156006 RVA: 0x0096B18B File Offset: 0x0096938B
		// (set) Token: 0x06026167 RID: 156007 RVA: 0x0096B19F File Offset: 0x0096939F
		public unsafe UButton Button_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugMPCTool_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugMPCTool_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005059 RID: 20569
		// (get) Token: 0x06026168 RID: 156008 RVA: 0x0096B1B4 File Offset: 0x009693B4
		// (set) Token: 0x06026169 RID: 156009 RVA: 0x0096B1C8 File Offset: 0x009693C8
		public unsafe USlider farcloud
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlider>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugMPCTool_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugMPCTool_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700505A RID: 20570
		// (get) Token: 0x0602616A RID: 156010 RVA: 0x0096B1DD File Offset: 0x009693DD
		// (set) Token: 0x0602616B RID: 156011 RVA: 0x0096B1F1 File Offset: 0x009693F1
		public unsafe UTextBlock farScale
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugMPCTool_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugMPCTool_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700505B RID: 20571
		// (get) Token: 0x0602616C RID: 156012 RVA: 0x0096B206 File Offset: 0x00969406
		// (set) Token: 0x0602616D RID: 156013 RVA: 0x0096B21A File Offset: 0x0096941A
		public unsafe UImage Image_50
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugMPCTool_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugMPCTool_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700505C RID: 20572
		// (get) Token: 0x0602616E RID: 156014 RVA: 0x0096B22F File Offset: 0x0096942F
		// (set) Token: 0x0602616F RID: 156015 RVA: 0x0096B243 File Offset: 0x00969443
		public unsafe USlider nearcloud
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlider>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugMPCTool_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugMPCTool_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700505D RID: 20573
		// (get) Token: 0x06026170 RID: 156016 RVA: 0x0096B258 File Offset: 0x00969458
		// (set) Token: 0x06026171 RID: 156017 RVA: 0x0096B26C File Offset: 0x0096946C
		public unsafe UTextBlock nearScale
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugMPCTool_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugMPCTool_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700505E RID: 20574
		// (get) Token: 0x06026172 RID: 156018 RVA: 0x0096B281 File Offset: 0x00969481
		// (set) Token: 0x06026173 RID: 156019 RVA: 0x0096B295 File Offset: 0x00969495
		public unsafe USlider Slider
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlider>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugMPCTool_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugMPCTool_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x1700505F RID: 20575
		// (get) Token: 0x06026174 RID: 156020 RVA: 0x0096B2AA File Offset: 0x009694AA
		// (set) Token: 0x06026175 RID: 156021 RVA: 0x0096B2BE File Offset: 0x009694BE
		public unsafe USlider Slider_11
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlider>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugMPCTool_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_DebugMPCTool_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005060 RID: 20576
		// (get) Token: 0x06026176 RID: 156022 RVA: 0x0096B2D4 File Offset: 0x009694D4
		// (set) Token: 0x06026177 RID: 156023 RVA: 0x0096B30D File Offset: 0x0096950D
		[Nullable(1)]
		public TArray<string> AllDataLayers
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AllDataLayers) == null)
				{
					result = (this._AllDataLayers = new TArray<string>(base.NativePtr + (IntPtr)WBP_DebugMPCTool_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AllDataLayers.CopyAssign(value);
			}
		}

		// Token: 0x06026178 RID: 156024 RVA: 0x0096B31C File Offset: 0x0096951C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Tick(FGeometry MyGeometry, float InDeltaTime)
		{
			WBP_DebugMPCTool_C.__Tick_FunctionParams* ptr = stackalloc WBP_DebugMPCTool_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(WBP_DebugMPCTool_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugMPCTool_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugMPCTool_C.__Tick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026179 RID: 156025 RVA: 0x0096B384 File Offset: 0x00969584
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void Tick_Implementation(FGeometry MyGeometry, float InDeltaTime)
		{
			WBP_DebugMPCTool_C.__Tick_FunctionParams* ptr = stackalloc WBP_DebugMPCTool_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(WBP_DebugMPCTool_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_DebugMPCTool_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_DebugMPCTool_C.__Tick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602617A RID: 156026 RVA: 0x0096B3ED File Offset: 0x009695ED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__WBP_DebugDataLayerTool_Button_1_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_DebugMPCTool_C.__BndEvt__WBP_DebugDataLayerTool_Button_1_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602617B RID: 156027 RVA: 0x0096B401 File Offset: 0x00969601
		protected WBP_DebugMPCTool_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013111 RID: 78097
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/UI/DebugDataLayer/WBP_DebugMPCTool.WBP_DebugMPCTool_C";

		// Token: 0x04013112 RID: 78098
		private static IntPtr _ClassPtr;

		// Token: 0x04013113 RID: 78099
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013114 RID: 78100
		internal static int __PropertyOffset_1;

		// Token: 0x04013115 RID: 78101
		internal static int __PropertyOffset_2;

		// Token: 0x04013116 RID: 78102
		internal static int __PropertyOffset_3;

		// Token: 0x04013117 RID: 78103
		internal static int __PropertyOffset_4;

		// Token: 0x04013118 RID: 78104
		internal static int __PropertyOffset_5;

		// Token: 0x04013119 RID: 78105
		internal static int __PropertyOffset_6;

		// Token: 0x0401311A RID: 78106
		internal static int __PropertyOffset_7;

		// Token: 0x0401311B RID: 78107
		internal static int __PropertyOffset_8;

		// Token: 0x0401311C RID: 78108
		internal static int __PropertyOffset_9;

		// Token: 0x0401311D RID: 78109
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AllDataLayers;

		// Token: 0x0401311E RID: 78110
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x0401311F RID: 78111
		private static IntPtr __BndEvt__WBP_DebugDataLayerTool_Button_1_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0200A097 RID: 41111
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected new ref struct __Tick_FunctionParams
		{
			// Token: 0x04031B94 RID: 203668
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04031B95 RID: 203669
			[FieldOffset(56)]
			public float InDeltaTime;
		}
	}
}
