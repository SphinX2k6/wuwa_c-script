using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Framework
{
	// Token: 0x02003A09 RID: 14857
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1160)]
	public class LGUIEventSystemActor_C : ALGUIEventSystemActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F235 RID: 127541 RVA: 0x008ACF60 File Offset: 0x008AB160
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (LGUIEventSystemActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C");
			}
			return LGUIEventSystemActor_C._ClassPtr;
		}

		// Token: 0x0601F236 RID: 127542 RVA: 0x008ACF84 File Offset: 0x008AB184
		public LGUIEventSystemActor_C() : this(BuiltinUtils.AllocNativeUObject(LGUIEventSystemActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F237 RID: 127543 RVA: 0x008ACFAC File Offset: 0x008AB1AC
		[NullableContext(1)]
		public LGUIEventSystemActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LGUIEventSystemActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A07 RID: 10759
		// (get) Token: 0x0601F238 RID: 127544 RVA: 0x008ACFDF File Offset: 0x008AB1DF
		// (set) Token: 0x0601F239 RID: 127545 RVA: 0x008ACFF3 File Offset: 0x008AB1F3
		public unsafe ULGUI_TouchInputModule LGUI_TouchInputModule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUI_TouchInputModule>(base.NativePtr / (IntPtr)sizeof(void*) + LGUIEventSystemActor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + LGUIEventSystemActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002A08 RID: 10760
		// (get) Token: 0x0601F23A RID: 127546 RVA: 0x008AD008 File Offset: 0x008AB208
		// (set) Token: 0x0601F23B RID: 127547 RVA: 0x008AD01C File Offset: 0x008AB21C
		public unsafe ULGUI_StandaloneInputModule LGUI_StandaloneInputModule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUI_StandaloneInputModule>(base.NativePtr / (IntPtr)sizeof(void*) + LGUIEventSystemActor_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + LGUIEventSystemActor_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002A09 RID: 10761
		// (get) Token: 0x0601F23C RID: 127548 RVA: 0x008AD031 File Offset: 0x008AB231
		// (set) Token: 0x0601F23D RID: 127549 RVA: 0x008AD045 File Offset: 0x008AB245
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + LGUIEventSystemActor_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + LGUIEventSystemActor_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002A0A RID: 10762
		// (get) Token: 0x0601F23E RID: 127550 RVA: 0x008AD05A File Offset: 0x008AB25A
		// (set) Token: 0x0601F23F RID: 127551 RVA: 0x008AD06E File Offset: 0x008AB26E
		public unsafe ULGUI_PointerInputModule ValidInputModule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUI_PointerInputModule>(base.NativePtr / (IntPtr)sizeof(void*) + LGUIEventSystemActor_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + LGUIEventSystemActor_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002A0B RID: 10763
		// (get) Token: 0x0601F240 RID: 127552 RVA: 0x008AD084 File Offset: 0x008AB284
		// (set) Token: 0x0601F241 RID: 127553 RVA: 0x008AD0BD File Offset: 0x008AB2BD
		[Nullable(1)]
		public OnMiddleMouseScroll OnMiddleMouseScroll
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnMiddleMouseScroll result;
				if ((result = this._OnMiddleMouseScroll) == null)
				{
					result = (this._OnMiddleMouseScroll = new OnMiddleMouseScroll(base.NativePtr + (IntPtr)LGUIEventSystemActor_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)LGUIEventSystemActor_C.__PropertyOffset_5, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002A0C RID: 10764
		// (get) Token: 0x0601F242 RID: 127554 RVA: 0x008AD0E0 File Offset: 0x008AB2E0
		// (set) Token: 0x0601F243 RID: 127555 RVA: 0x008AD119 File Offset: 0x008AB319
		[Nullable(1)]
		public OnTouch OnTouch
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnTouch result;
				if ((result = this._OnTouch) == null)
				{
					result = (this._OnTouch = new OnTouch(base.NativePtr + (IntPtr)LGUIEventSystemActor_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)LGUIEventSystemActor_C.__PropertyOffset_6, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002A0D RID: 10765
		// (get) Token: 0x0601F244 RID: 127556 RVA: 0x008AD13C File Offset: 0x008AB33C
		// (set) Token: 0x0601F245 RID: 127557 RVA: 0x008AD175 File Offset: 0x008AB375
		[Nullable(1)]
		public OnTouchMove OnTouchMove
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnTouchMove result;
				if ((result = this._OnTouchMove) == null)
				{
					result = (this._OnTouchMove = new OnTouchMove(base.NativePtr + (IntPtr)LGUIEventSystemActor_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)LGUIEventSystemActor_C.__PropertyOffset_7, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002A0E RID: 10766
		// (get) Token: 0x0601F246 RID: 127558 RVA: 0x008AD198 File Offset: 0x008AB398
		// (set) Token: 0x0601F247 RID: 127559 RVA: 0x008AD1D1 File Offset: 0x008AB3D1
		[Nullable(1)]
		public OnClickKey OnClickKey
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnClickKey result;
				if ((result = this._OnClickKey) == null)
				{
					result = (this._OnClickKey = new OnClickKey(base.NativePtr + (IntPtr)LGUIEventSystemActor_C.__PropertyOffset_8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)LGUIEventSystemActor_C.__PropertyOffset_8, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601F248 RID: 127560 RVA: 0x008AD1F4 File Offset: 0x008AB3F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_27(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_27_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_27_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_27_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_27_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_27_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_27_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F249 RID: 127561 RVA: 0x008AD268 File Offset: 0x008AB468
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_26(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_26_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_26_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_26_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_26_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_26_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_26_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F24A RID: 127562 RVA: 0x008AD2DC File Offset: 0x008AB4DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Down_K2Node_InputKeyEvent_25(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Down_K2Node_InputKeyEvent_25_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Down_K2Node_InputKeyEvent_25_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Down_K2Node_InputKeyEvent_25_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Down_K2Node_InputKeyEvent_25_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Down_K2Node_InputKeyEvent_25_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Down_K2Node_InputKeyEvent_25_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F24B RID: 127563 RVA: 0x008AD350 File Offset: 0x008AB550
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Down_K2Node_InputKeyEvent_24(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Down_K2Node_InputKeyEvent_24_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Down_K2Node_InputKeyEvent_24_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Down_K2Node_InputKeyEvent_24_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Down_K2Node_InputKeyEvent_24_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Down_K2Node_InputKeyEvent_24_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Down_K2Node_InputKeyEvent_24_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F24C RID: 127564 RVA: 0x008AD3C4 File Offset: 0x008AB5C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Up_K2Node_InputKeyEvent_23(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Up_K2Node_InputKeyEvent_23_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Up_K2Node_InputKeyEvent_23_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Up_K2Node_InputKeyEvent_23_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Up_K2Node_InputKeyEvent_23_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Up_K2Node_InputKeyEvent_23_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Up_K2Node_InputKeyEvent_23_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F24D RID: 127565 RVA: 0x008AD438 File Offset: 0x008AB638
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Up_K2Node_InputKeyEvent_22(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Up_K2Node_InputKeyEvent_22_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Up_K2Node_InputKeyEvent_22_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Up_K2Node_InputKeyEvent_22_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Up_K2Node_InputKeyEvent_22_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Up_K2Node_InputKeyEvent_22_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Up_K2Node_InputKeyEvent_22_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F24E RID: 127566 RVA: 0x008AD4AC File Offset: 0x008AB6AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Right_K2Node_InputKeyEvent_21(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Right_K2Node_InputKeyEvent_21_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Right_K2Node_InputKeyEvent_21_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Right_K2Node_InputKeyEvent_21_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Right_K2Node_InputKeyEvent_21_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Right_K2Node_InputKeyEvent_21_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Right_K2Node_InputKeyEvent_21_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F24F RID: 127567 RVA: 0x008AD520 File Offset: 0x008AB720
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Right_K2Node_InputKeyEvent_20(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Right_K2Node_InputKeyEvent_20_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Right_K2Node_InputKeyEvent_20_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Right_K2Node_InputKeyEvent_20_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Right_K2Node_InputKeyEvent_20_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Right_K2Node_InputKeyEvent_20_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Right_K2Node_InputKeyEvent_20_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F250 RID: 127568 RVA: 0x008AD594 File Offset: 0x008AB794
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Left_K2Node_InputKeyEvent_19(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Left_K2Node_InputKeyEvent_19_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Left_K2Node_InputKeyEvent_19_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Left_K2Node_InputKeyEvent_19_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Left_K2Node_InputKeyEvent_19_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Left_K2Node_InputKeyEvent_19_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Left_K2Node_InputKeyEvent_19_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F251 RID: 127569 RVA: 0x008AD608 File Offset: 0x008AB808
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Left_K2Node_InputKeyEvent_18(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Left_K2Node_InputKeyEvent_18_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Left_K2Node_InputKeyEvent_18_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Left_K2Node_InputKeyEvent_18_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Left_K2Node_InputKeyEvent_18_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Left_K2Node_InputKeyEvent_18_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Left_K2Node_InputKeyEvent_18_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F252 RID: 127570 RVA: 0x008AD67C File Offset: 0x008AB87C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Enter_K2Node_InputKeyEvent_17(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Enter_K2Node_InputKeyEvent_17_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Enter_K2Node_InputKeyEvent_17_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Enter_K2Node_InputKeyEvent_17_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Enter_K2Node_InputKeyEvent_17_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Enter_K2Node_InputKeyEvent_17_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Enter_K2Node_InputKeyEvent_17_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F253 RID: 127571 RVA: 0x008AD6F0 File Offset: 0x008AB8F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Enter_K2Node_InputKeyEvent_16(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Enter_K2Node_InputKeyEvent_16_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Enter_K2Node_InputKeyEvent_16_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Enter_K2Node_InputKeyEvent_16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Enter_K2Node_InputKeyEvent_16_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Enter_K2Node_InputKeyEvent_16_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Enter_K2Node_InputKeyEvent_16_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F254 RID: 127572 RVA: 0x008AD764 File Offset: 0x008AB964
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpTchEvt_Moved(ETouchIndex FingerIndex, FVector Location)
		{
			LGUIEventSystemActor_C.__InpTchEvt_Moved_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpTchEvt_Moved_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpTchEvt_Moved_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpTchEvt_Moved_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpTchEvt_Moved_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F255 RID: 127573 RVA: 0x008AD7B8 File Offset: 0x008AB9B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpTchEvt_Released(ETouchIndex FingerIndex, FVector Location)
		{
			LGUIEventSystemActor_C.__InpTchEvt_Released_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpTchEvt_Released_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpTchEvt_Released_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpTchEvt_Released_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpTchEvt_Released_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F256 RID: 127574 RVA: 0x008AD80C File Offset: 0x008ABA0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpTchEvt_Pressed(ETouchIndex FingerIndex, FVector Location)
		{
			LGUIEventSystemActor_C.__InpTchEvt_Pressed_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpTchEvt_Pressed_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpTchEvt_Pressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpTchEvt_Pressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpTchEvt_Pressed_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F257 RID: 127575 RVA: 0x008AD860 File Offset: 0x008ABA60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_15(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_15_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_15_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_15_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_15_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_15_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_15_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F258 RID: 127576 RVA: 0x008AD8D4 File Offset: 0x008ABAD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_14(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_14_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_14_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_14_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_14_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_14_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_14_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F259 RID: 127577 RVA: 0x008AD948 File Offset: 0x008ABB48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_13(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_13_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_13_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_13_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_13_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_13_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_13_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F25A RID: 127578 RVA: 0x008AD9BC File Offset: 0x008ABBBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_12(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_12_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_12_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_12_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_12_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_12_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_12_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F25B RID: 127579 RVA: 0x008ADA30 File Offset: 0x008ABC30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_11(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_11_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_11_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_11_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_11_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_11_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_11_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F25C RID: 127580 RVA: 0x008ADAA4 File Offset: 0x008ABCA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_10(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_10_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_10_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_10_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_10_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_10_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_10_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F25D RID: 127581 RVA: 0x008ADB18 File Offset: 0x008ABD18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_9(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_9_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_9_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_9_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_9_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_9_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_9_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F25E RID: 127582 RVA: 0x008ADB8C File Offset: 0x008ABD8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_8(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_8_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_8_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_8_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_8_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_8_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F25F RID: 127583 RVA: 0x008ADC00 File Offset: 0x008ABE00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_7(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_7_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_7_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_7_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_7_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_7_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_7_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F260 RID: 127584 RVA: 0x008ADC74 File Offset: 0x008ABE74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_6(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_6_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_6_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_6_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_6_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_6_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_6_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F261 RID: 127585 RVA: 0x008ADCE8 File Offset: 0x008ABEE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F262 RID: 127586 RVA: 0x008ADD5C File Offset: 0x008ABF5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F263 RID: 127587 RVA: 0x008ADDD0 File Offset: 0x008ABFD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F264 RID: 127588 RVA: 0x008ADE44 File Offset: 0x008AC044
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F265 RID: 127589 RVA: 0x008ADEB8 File Offset: 0x008AC0B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_AnyKey_K2Node_InputKeyEvent_1(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_AnyKey_K2Node_InputKeyEvent_1_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_AnyKey_K2Node_InputKeyEvent_1_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_AnyKey_K2Node_InputKeyEvent_1_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_AnyKey_K2Node_InputKeyEvent_1_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_AnyKey_K2Node_InputKeyEvent_1_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_AnyKey_K2Node_InputKeyEvent_1_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F266 RID: 127590 RVA: 0x008ADF2C File Offset: 0x008AC12C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_AnyKey_K2Node_InputKeyEvent_0(FKey Key)
		{
			LGUIEventSystemActor_C.__InpActEvt_AnyKey_K2Node_InputKeyEvent_0_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpActEvt_AnyKey_K2Node_InputKeyEvent_0_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpActEvt_AnyKey_K2Node_InputKeyEvent_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpActEvt_AnyKey_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpActEvt_AnyKey_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__InpActEvt_AnyKey_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F267 RID: 127591 RVA: 0x008ADF9E File Offset: 0x008AC19E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F268 RID: 127592 RVA: 0x008ADFB2 File Offset: 0x008AC1B2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, LGUIEventSystemActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F269 RID: 127593 RVA: 0x008ADFC8 File Offset: 0x008AC1C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpAxisKeyEvt_MouseWheelAxis_K2Node_InputAxisKeyEvent_0(float AxisValue)
		{
			LGUIEventSystemActor_C.__InpAxisKeyEvt_MouseWheelAxis_K2Node_InputAxisKeyEvent_0_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpAxisKeyEvt_MouseWheelAxis_K2Node_InputAxisKeyEvent_0_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpAxisKeyEvt_MouseWheelAxis_K2Node_InputAxisKeyEvent_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpAxisKeyEvt_MouseWheelAxis_K2Node_InputAxisKeyEvent_0_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AxisValue = AxisValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpAxisKeyEvt_MouseWheelAxis_K2Node_InputAxisKeyEvent_0_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F26A RID: 127594 RVA: 0x008AE00E File Offset: 0x008AC20E
		protected LGUIEventSystemActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EE82 RID: 61058
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C";

		// Token: 0x0400EE83 RID: 61059
		private static IntPtr _ClassPtr;

		// Token: 0x0400EE84 RID: 61060
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EE85 RID: 61061
		public static IntPtr __OnClickKey__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EE86 RID: 61062
		public static IntPtr __OnTouchMove__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EE87 RID: 61063
		public static IntPtr __OnTouch__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EE88 RID: 61064
		public static IntPtr __OnMiddleMouseScroll__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EE89 RID: 61065
		internal static int __PropertyOffset_1;

		// Token: 0x0400EE8A RID: 61066
		internal static int __PropertyOffset_2;

		// Token: 0x0400EE8B RID: 61067
		internal static int __PropertyOffset_3;

		// Token: 0x0400EE8C RID: 61068
		internal static int __PropertyOffset_4;

		// Token: 0x0400EE8D RID: 61069
		internal static int __PropertyOffset_5;

		// Token: 0x0400EE8E RID: 61070
		private OnMiddleMouseScroll _OnMiddleMouseScroll;

		// Token: 0x0400EE8F RID: 61071
		internal static int __PropertyOffset_6;

		// Token: 0x0400EE90 RID: 61072
		private OnTouch _OnTouch;

		// Token: 0x0400EE91 RID: 61073
		internal static int __PropertyOffset_7;

		// Token: 0x0400EE92 RID: 61074
		private OnTouchMove _OnTouchMove;

		// Token: 0x0400EE93 RID: 61075
		internal static int __PropertyOffset_8;

		// Token: 0x0400EE94 RID: 61076
		private OnClickKey _OnClickKey;

		// Token: 0x0400EE95 RID: 61077
		private static IntPtr __InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_27_NativeFunctionPtr;

		// Token: 0x0400EE96 RID: 61078
		private static IntPtr __InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_26_NativeFunctionPtr;

		// Token: 0x0400EE97 RID: 61079
		private static IntPtr __InpActEvt_Down_K2Node_InputKeyEvent_25_NativeFunctionPtr;

		// Token: 0x0400EE98 RID: 61080
		private static IntPtr __InpActEvt_Down_K2Node_InputKeyEvent_24_NativeFunctionPtr;

		// Token: 0x0400EE99 RID: 61081
		private static IntPtr __InpActEvt_Up_K2Node_InputKeyEvent_23_NativeFunctionPtr;

		// Token: 0x0400EE9A RID: 61082
		private static IntPtr __InpActEvt_Up_K2Node_InputKeyEvent_22_NativeFunctionPtr;

		// Token: 0x0400EE9B RID: 61083
		private static IntPtr __InpActEvt_Right_K2Node_InputKeyEvent_21_NativeFunctionPtr;

		// Token: 0x0400EE9C RID: 61084
		private static IntPtr __InpActEvt_Right_K2Node_InputKeyEvent_20_NativeFunctionPtr;

		// Token: 0x0400EE9D RID: 61085
		private static IntPtr __InpActEvt_Left_K2Node_InputKeyEvent_19_NativeFunctionPtr;

		// Token: 0x0400EE9E RID: 61086
		private static IntPtr __InpActEvt_Left_K2Node_InputKeyEvent_18_NativeFunctionPtr;

		// Token: 0x0400EE9F RID: 61087
		private static IntPtr __InpActEvt_Enter_K2Node_InputKeyEvent_17_NativeFunctionPtr;

		// Token: 0x0400EEA0 RID: 61088
		private static IntPtr __InpActEvt_Enter_K2Node_InputKeyEvent_16_NativeFunctionPtr;

		// Token: 0x0400EEA1 RID: 61089
		private static IntPtr __InpTchEvt_Moved_NativeFunctionPtr;

		// Token: 0x0400EEA2 RID: 61090
		private static IntPtr __InpTchEvt_Released_NativeFunctionPtr;

		// Token: 0x0400EEA3 RID: 61091
		private static IntPtr __InpTchEvt_Pressed_NativeFunctionPtr;

		// Token: 0x0400EEA4 RID: 61092
		private static IntPtr __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_15_NativeFunctionPtr;

		// Token: 0x0400EEA5 RID: 61093
		private static IntPtr __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_14_NativeFunctionPtr;

		// Token: 0x0400EEA6 RID: 61094
		private static IntPtr __InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_13_NativeFunctionPtr;

		// Token: 0x0400EEA7 RID: 61095
		private static IntPtr __InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_12_NativeFunctionPtr;

		// Token: 0x0400EEA8 RID: 61096
		private static IntPtr __InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_11_NativeFunctionPtr;

		// Token: 0x0400EEA9 RID: 61097
		private static IntPtr __InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_10_NativeFunctionPtr;

		// Token: 0x0400EEAA RID: 61098
		private static IntPtr __InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_9_NativeFunctionPtr;

		// Token: 0x0400EEAB RID: 61099
		private static IntPtr __InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_8_NativeFunctionPtr;

		// Token: 0x0400EEAC RID: 61100
		private static IntPtr __InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_7_NativeFunctionPtr;

		// Token: 0x0400EEAD RID: 61101
		private static IntPtr __InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_6_NativeFunctionPtr;

		// Token: 0x0400EEAE RID: 61102
		private static IntPtr __InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_NativeFunctionPtr;

		// Token: 0x0400EEAF RID: 61103
		private static IntPtr __InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_NativeFunctionPtr;

		// Token: 0x0400EEB0 RID: 61104
		private static IntPtr __InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_NativeFunctionPtr;

		// Token: 0x0400EEB1 RID: 61105
		private static IntPtr __InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_NativeFunctionPtr;

		// Token: 0x0400EEB2 RID: 61106
		private static IntPtr __InpActEvt_AnyKey_K2Node_InputKeyEvent_1_NativeFunctionPtr;

		// Token: 0x0400EEB3 RID: 61107
		private static IntPtr __InpActEvt_AnyKey_K2Node_InputKeyEvent_0_NativeFunctionPtr;

		// Token: 0x0400EEB4 RID: 61108
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400EEB5 RID: 61109
		private static IntPtr __InpAxisKeyEvt_MouseWheelAxis_K2Node_InputAxisKeyEvent_0_NativeFunctionPtr;

		// Token: 0x02009A39 RID: 39481
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_27_FunctionParams
		{
			// Token: 0x04030F6E RID: 200558
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A3A RID: 39482
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_26_FunctionParams
		{
			// Token: 0x04030F6F RID: 200559
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A3B RID: 39483
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Down_K2Node_InputKeyEvent_25_FunctionParams
		{
			// Token: 0x04030F70 RID: 200560
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A3C RID: 39484
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Down_K2Node_InputKeyEvent_24_FunctionParams
		{
			// Token: 0x04030F71 RID: 200561
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A3D RID: 39485
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Up_K2Node_InputKeyEvent_23_FunctionParams
		{
			// Token: 0x04030F72 RID: 200562
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A3E RID: 39486
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Up_K2Node_InputKeyEvent_22_FunctionParams
		{
			// Token: 0x04030F73 RID: 200563
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A3F RID: 39487
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Right_K2Node_InputKeyEvent_21_FunctionParams
		{
			// Token: 0x04030F74 RID: 200564
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A40 RID: 39488
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Right_K2Node_InputKeyEvent_20_FunctionParams
		{
			// Token: 0x04030F75 RID: 200565
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A41 RID: 39489
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Left_K2Node_InputKeyEvent_19_FunctionParams
		{
			// Token: 0x04030F76 RID: 200566
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A42 RID: 39490
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Left_K2Node_InputKeyEvent_18_FunctionParams
		{
			// Token: 0x04030F77 RID: 200567
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A43 RID: 39491
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Enter_K2Node_InputKeyEvent_17_FunctionParams
		{
			// Token: 0x04030F78 RID: 200568
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A44 RID: 39492
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Enter_K2Node_InputKeyEvent_16_FunctionParams
		{
			// Token: 0x04030F79 RID: 200569
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A45 RID: 39493
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InpTchEvt_Moved_FunctionParams
		{
			// Token: 0x04030F7A RID: 200570
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x04030F7B RID: 200571
			[FieldOffset(4)]
			public FVector Location;
		}

		// Token: 0x02009A46 RID: 39494
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InpTchEvt_Released_FunctionParams
		{
			// Token: 0x04030F7C RID: 200572
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x04030F7D RID: 200573
			[FieldOffset(4)]
			public FVector Location;
		}

		// Token: 0x02009A47 RID: 39495
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InpTchEvt_Pressed_FunctionParams
		{
			// Token: 0x04030F7E RID: 200574
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x04030F7F RID: 200575
			[FieldOffset(4)]
			public FVector Location;
		}

		// Token: 0x02009A48 RID: 39496
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_15_FunctionParams
		{
			// Token: 0x04030F80 RID: 200576
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A49 RID: 39497
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_14_FunctionParams
		{
			// Token: 0x04030F81 RID: 200577
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A4A RID: 39498
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_13_FunctionParams
		{
			// Token: 0x04030F82 RID: 200578
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A4B RID: 39499
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_12_FunctionParams
		{
			// Token: 0x04030F83 RID: 200579
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A4C RID: 39500
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_11_FunctionParams
		{
			// Token: 0x04030F84 RID: 200580
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A4D RID: 39501
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_10_FunctionParams
		{
			// Token: 0x04030F85 RID: 200581
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A4E RID: 39502
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_9_FunctionParams
		{
			// Token: 0x04030F86 RID: 200582
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A4F RID: 39503
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_8_FunctionParams
		{
			// Token: 0x04030F87 RID: 200583
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A50 RID: 39504
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_7_FunctionParams
		{
			// Token: 0x04030F88 RID: 200584
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A51 RID: 39505
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_6_FunctionParams
		{
			// Token: 0x04030F89 RID: 200585
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A52 RID: 39506
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_FunctionParams
		{
			// Token: 0x04030F8A RID: 200586
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A53 RID: 39507
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_FunctionParams
		{
			// Token: 0x04030F8B RID: 200587
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A54 RID: 39508
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_FunctionParams
		{
			// Token: 0x04030F8C RID: 200588
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A55 RID: 39509
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_FunctionParams
		{
			// Token: 0x04030F8D RID: 200589
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A56 RID: 39510
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_AnyKey_K2Node_InputKeyEvent_1_FunctionParams
		{
			// Token: 0x04030F8E RID: 200590
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A57 RID: 39511
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_AnyKey_K2Node_InputKeyEvent_0_FunctionParams
		{
			// Token: 0x04030F8F RID: 200591
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02009A58 RID: 39512
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InpAxisKeyEvt_MouseWheelAxis_K2Node_InputAxisKeyEvent_0_FunctionParams
		{
			// Token: 0x04030F90 RID: 200592
			[FieldOffset(0)]
			public float AxisValue;
		}
	}
}
