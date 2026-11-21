using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Framework
{
	// Token: 0x02003061 RID: 12385
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1160)]
	public class LGUIEventSystemActor_C : ALGUIEventSystemActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D698 RID: 120472 RVA: 0x008F5180 File Offset: 0x008F3380
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (LGUIEventSystemActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C");
			}
			return LGUIEventSystemActor_C._ClassPtr;
		}

		// Token: 0x0601D699 RID: 120473 RVA: 0x008F51A4 File Offset: 0x008F33A4
		public LGUIEventSystemActor_C() : this(BuiltinUtils.AllocNativeUObject(LGUIEventSystemActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D69A RID: 120474 RVA: 0x008F51CC File Offset: 0x008F33CC
		[NullableContext(1)]
		public LGUIEventSystemActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LGUIEventSystemActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002EC0 RID: 11968
		// (get) Token: 0x0601D69B RID: 120475 RVA: 0x008F51FF File Offset: 0x008F33FF
		// (set) Token: 0x0601D69C RID: 120476 RVA: 0x008F5213 File Offset: 0x008F3413
		public unsafe ULGUI_TouchInputModule LGUI_TouchInputModule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUI_TouchInputModule>(base.NativePtr / (IntPtr)sizeof(void*) + LGUIEventSystemActor_C.__PropertyOffset_LGUI_TouchInputModule);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + LGUIEventSystemActor_C.__PropertyOffset_LGUI_TouchInputModule, value);
			}
		}

		// Token: 0x17002EC1 RID: 11969
		// (get) Token: 0x0601D69D RID: 120477 RVA: 0x008F5228 File Offset: 0x008F3428
		// (set) Token: 0x0601D69E RID: 120478 RVA: 0x008F523C File Offset: 0x008F343C
		public unsafe ULGUI_StandaloneInputModule LGUI_StandaloneInputModule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUI_StandaloneInputModule>(base.NativePtr / (IntPtr)sizeof(void*) + LGUIEventSystemActor_C.__PropertyOffset_LGUI_StandaloneInputModule);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + LGUIEventSystemActor_C.__PropertyOffset_LGUI_StandaloneInputModule, value);
			}
		}

		// Token: 0x17002EC2 RID: 11970
		// (get) Token: 0x0601D69F RID: 120479 RVA: 0x008F5251 File Offset: 0x008F3451
		// (set) Token: 0x0601D6A0 RID: 120480 RVA: 0x008F5265 File Offset: 0x008F3465
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + LGUIEventSystemActor_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + LGUIEventSystemActor_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17002EC3 RID: 11971
		// (get) Token: 0x0601D6A1 RID: 120481 RVA: 0x008F527A File Offset: 0x008F347A
		// (set) Token: 0x0601D6A2 RID: 120482 RVA: 0x008F528E File Offset: 0x008F348E
		public unsafe ULGUI_PointerInputModule ValidInputModule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUI_PointerInputModule>(base.NativePtr / (IntPtr)sizeof(void*) + LGUIEventSystemActor_C.__PropertyOffset_ValidInputModule);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + LGUIEventSystemActor_C.__PropertyOffset_ValidInputModule, value);
			}
		}

		// Token: 0x17002EC4 RID: 11972
		// (get) Token: 0x0601D6A3 RID: 120483 RVA: 0x008F52A4 File Offset: 0x008F34A4
		// (set) Token: 0x0601D6A4 RID: 120484 RVA: 0x008F52DD File Offset: 0x008F34DD
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
					result = (this._OnMiddleMouseScroll = new OnMiddleMouseScroll(base.NativePtr + (IntPtr)LGUIEventSystemActor_C.__PropertyOffset_OnMiddleMouseScroll, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)LGUIEventSystemActor_C.__PropertyOffset_OnMiddleMouseScroll, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EC5 RID: 11973
		// (get) Token: 0x0601D6A5 RID: 120485 RVA: 0x008F5300 File Offset: 0x008F3500
		// (set) Token: 0x0601D6A6 RID: 120486 RVA: 0x008F5339 File Offset: 0x008F3539
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
					result = (this._OnTouch = new OnTouch(base.NativePtr + (IntPtr)LGUIEventSystemActor_C.__PropertyOffset_OnTouch, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)LGUIEventSystemActor_C.__PropertyOffset_OnTouch, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EC6 RID: 11974
		// (get) Token: 0x0601D6A7 RID: 120487 RVA: 0x008F535C File Offset: 0x008F355C
		// (set) Token: 0x0601D6A8 RID: 120488 RVA: 0x008F5395 File Offset: 0x008F3595
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
					result = (this._OnTouchMove = new OnTouchMove(base.NativePtr + (IntPtr)LGUIEventSystemActor_C.__PropertyOffset_OnTouchMove, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)LGUIEventSystemActor_C.__PropertyOffset_OnTouchMove, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EC7 RID: 11975
		// (get) Token: 0x0601D6A9 RID: 120489 RVA: 0x008F53B8 File Offset: 0x008F35B8
		// (set) Token: 0x0601D6AA RID: 120490 RVA: 0x008F53F1 File Offset: 0x008F35F1
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
					result = (this._OnClickKey = new OnClickKey(base.NativePtr + (IntPtr)LGUIEventSystemActor_C.__PropertyOffset_OnClickKey, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)LGUIEventSystemActor_C.__PropertyOffset_OnClickKey, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601D6AB RID: 120491 RVA: 0x008F5414 File Offset: 0x008F3614
		[SkipLocalsInit]
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

		// Token: 0x0601D6AC RID: 120492 RVA: 0x008F5488 File Offset: 0x008F3688
		[SkipLocalsInit]
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

		// Token: 0x0601D6AD RID: 120493 RVA: 0x008F54FC File Offset: 0x008F36FC
		[SkipLocalsInit]
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

		// Token: 0x0601D6AE RID: 120494 RVA: 0x008F5570 File Offset: 0x008F3770
		[SkipLocalsInit]
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

		// Token: 0x0601D6AF RID: 120495 RVA: 0x008F55E4 File Offset: 0x008F37E4
		[SkipLocalsInit]
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

		// Token: 0x0601D6B0 RID: 120496 RVA: 0x008F5658 File Offset: 0x008F3858
		[SkipLocalsInit]
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

		// Token: 0x0601D6B1 RID: 120497 RVA: 0x008F56CC File Offset: 0x008F38CC
		[SkipLocalsInit]
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

		// Token: 0x0601D6B2 RID: 120498 RVA: 0x008F5740 File Offset: 0x008F3940
		[SkipLocalsInit]
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

		// Token: 0x0601D6B3 RID: 120499 RVA: 0x008F57B4 File Offset: 0x008F39B4
		[SkipLocalsInit]
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

		// Token: 0x0601D6B4 RID: 120500 RVA: 0x008F5828 File Offset: 0x008F3A28
		[SkipLocalsInit]
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

		// Token: 0x0601D6B5 RID: 120501 RVA: 0x008F589C File Offset: 0x008F3A9C
		[SkipLocalsInit]
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

		// Token: 0x0601D6B6 RID: 120502 RVA: 0x008F5910 File Offset: 0x008F3B10
		[SkipLocalsInit]
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

		// Token: 0x0601D6B7 RID: 120503 RVA: 0x008F5984 File Offset: 0x008F3B84
		[SkipLocalsInit]
		public unsafe virtual void InpTchEvt_Moved(ETouchIndex FingerIndex, FVector Location)
		{
			LGUIEventSystemActor_C.__InpTchEvt_Moved_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpTchEvt_Moved_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpTchEvt_Moved_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpTchEvt_Moved_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpTchEvt_Moved_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D6B8 RID: 120504 RVA: 0x008F59D8 File Offset: 0x008F3BD8
		[SkipLocalsInit]
		public unsafe virtual void InpTchEvt_Released(ETouchIndex FingerIndex, FVector Location)
		{
			LGUIEventSystemActor_C.__InpTchEvt_Released_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpTchEvt_Released_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpTchEvt_Released_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpTchEvt_Released_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpTchEvt_Released_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D6B9 RID: 120505 RVA: 0x008F5A2C File Offset: 0x008F3C2C
		[SkipLocalsInit]
		public unsafe virtual void InpTchEvt_Pressed(ETouchIndex FingerIndex, FVector Location)
		{
			LGUIEventSystemActor_C.__InpTchEvt_Pressed_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpTchEvt_Pressed_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpTchEvt_Pressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpTchEvt_Pressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpTchEvt_Pressed_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D6BA RID: 120506 RVA: 0x008F5A80 File Offset: 0x008F3C80
		[SkipLocalsInit]
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

		// Token: 0x0601D6BB RID: 120507 RVA: 0x008F5AF4 File Offset: 0x008F3CF4
		[SkipLocalsInit]
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

		// Token: 0x0601D6BC RID: 120508 RVA: 0x008F5B68 File Offset: 0x008F3D68
		[SkipLocalsInit]
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

		// Token: 0x0601D6BD RID: 120509 RVA: 0x008F5BDC File Offset: 0x008F3DDC
		[SkipLocalsInit]
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

		// Token: 0x0601D6BE RID: 120510 RVA: 0x008F5C50 File Offset: 0x008F3E50
		[SkipLocalsInit]
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

		// Token: 0x0601D6BF RID: 120511 RVA: 0x008F5CC4 File Offset: 0x008F3EC4
		[SkipLocalsInit]
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

		// Token: 0x0601D6C0 RID: 120512 RVA: 0x008F5D38 File Offset: 0x008F3F38
		[SkipLocalsInit]
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

		// Token: 0x0601D6C1 RID: 120513 RVA: 0x008F5DAC File Offset: 0x008F3FAC
		[SkipLocalsInit]
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

		// Token: 0x0601D6C2 RID: 120514 RVA: 0x008F5E20 File Offset: 0x008F4020
		[SkipLocalsInit]
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

		// Token: 0x0601D6C3 RID: 120515 RVA: 0x008F5E94 File Offset: 0x008F4094
		[SkipLocalsInit]
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

		// Token: 0x0601D6C4 RID: 120516 RVA: 0x008F5F08 File Offset: 0x008F4108
		[SkipLocalsInit]
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

		// Token: 0x0601D6C5 RID: 120517 RVA: 0x008F5F7C File Offset: 0x008F417C
		[SkipLocalsInit]
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

		// Token: 0x0601D6C6 RID: 120518 RVA: 0x008F5FF0 File Offset: 0x008F41F0
		[SkipLocalsInit]
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

		// Token: 0x0601D6C7 RID: 120519 RVA: 0x008F6064 File Offset: 0x008F4264
		[SkipLocalsInit]
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

		// Token: 0x0601D6C8 RID: 120520 RVA: 0x008F60D8 File Offset: 0x008F42D8
		[SkipLocalsInit]
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

		// Token: 0x0601D6C9 RID: 120521 RVA: 0x008F614C File Offset: 0x008F434C
		[SkipLocalsInit]
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

		// Token: 0x0601D6CA RID: 120522 RVA: 0x008F61BE File Offset: 0x008F43BE
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601D6CB RID: 120523 RVA: 0x008F61D2 File Offset: 0x008F43D2
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, LGUIEventSystemActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601D6CC RID: 120524 RVA: 0x008F61E8 File Offset: 0x008F43E8
		[SkipLocalsInit]
		public unsafe virtual void InpAxisKeyEvt_MouseWheelAxis_K2Node_InputAxisKeyEvent_0(float AxisValue)
		{
			LGUIEventSystemActor_C.__InpAxisKeyEvt_MouseWheelAxis_K2Node_InputAxisKeyEvent_0_FunctionParams* ptr = stackalloc LGUIEventSystemActor_C.__InpAxisKeyEvt_MouseWheelAxis_K2Node_InputAxisKeyEvent_0_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(LGUIEventSystemActor_C.__InpAxisKeyEvt_MouseWheelAxis_K2Node_InputAxisKeyEvent_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(LGUIEventSystemActor_C.__InpAxisKeyEvt_MouseWheelAxis_K2Node_InputAxisKeyEvent_0_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AxisValue = AxisValue;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, LGUIEventSystemActor_C.__InpAxisKeyEvt_MouseWheelAxis_K2Node_InputAxisKeyEvent_0_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D6CD RID: 120525 RVA: 0x008F622E File Offset: 0x008F442E
		protected LGUIEventSystemActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7A4 RID: 63396
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C";

		// Token: 0x0400F7A5 RID: 63397
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7A6 RID: 63398
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7A7 RID: 63399
		public static IntPtr __OnClickKey__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F7A8 RID: 63400
		public static IntPtr __OnTouchMove__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F7A9 RID: 63401
		public static IntPtr __OnTouch__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F7AA RID: 63402
		public static IntPtr __OnMiddleMouseScroll__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F7AB RID: 63403
		internal static int __PropertyOffset_LGUI_TouchInputModule;

		// Token: 0x0400F7AC RID: 63404
		internal static int __PropertyOffset_LGUI_StandaloneInputModule;

		// Token: 0x0400F7AD RID: 63405
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400F7AE RID: 63406
		internal static int __PropertyOffset_ValidInputModule;

		// Token: 0x0400F7AF RID: 63407
		internal static int __PropertyOffset_OnMiddleMouseScroll;

		// Token: 0x0400F7B0 RID: 63408
		private OnMiddleMouseScroll _OnMiddleMouseScroll;

		// Token: 0x0400F7B1 RID: 63409
		internal static int __PropertyOffset_OnTouch;

		// Token: 0x0400F7B2 RID: 63410
		private OnTouch _OnTouch;

		// Token: 0x0400F7B3 RID: 63411
		internal static int __PropertyOffset_OnTouchMove;

		// Token: 0x0400F7B4 RID: 63412
		private OnTouchMove _OnTouchMove;

		// Token: 0x0400F7B5 RID: 63413
		internal static int __PropertyOffset_OnClickKey;

		// Token: 0x0400F7B6 RID: 63414
		private OnClickKey _OnClickKey;

		// Token: 0x0400F7B7 RID: 63415
		private static IntPtr __InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_27_NativeFunctionPtr;

		// Token: 0x0400F7B8 RID: 63416
		private static IntPtr __InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_26_NativeFunctionPtr;

		// Token: 0x0400F7B9 RID: 63417
		private static IntPtr __InpActEvt_Down_K2Node_InputKeyEvent_25_NativeFunctionPtr;

		// Token: 0x0400F7BA RID: 63418
		private static IntPtr __InpActEvt_Down_K2Node_InputKeyEvent_24_NativeFunctionPtr;

		// Token: 0x0400F7BB RID: 63419
		private static IntPtr __InpActEvt_Up_K2Node_InputKeyEvent_23_NativeFunctionPtr;

		// Token: 0x0400F7BC RID: 63420
		private static IntPtr __InpActEvt_Up_K2Node_InputKeyEvent_22_NativeFunctionPtr;

		// Token: 0x0400F7BD RID: 63421
		private static IntPtr __InpActEvt_Right_K2Node_InputKeyEvent_21_NativeFunctionPtr;

		// Token: 0x0400F7BE RID: 63422
		private static IntPtr __InpActEvt_Right_K2Node_InputKeyEvent_20_NativeFunctionPtr;

		// Token: 0x0400F7BF RID: 63423
		private static IntPtr __InpActEvt_Left_K2Node_InputKeyEvent_19_NativeFunctionPtr;

		// Token: 0x0400F7C0 RID: 63424
		private static IntPtr __InpActEvt_Left_K2Node_InputKeyEvent_18_NativeFunctionPtr;

		// Token: 0x0400F7C1 RID: 63425
		private static IntPtr __InpActEvt_Enter_K2Node_InputKeyEvent_17_NativeFunctionPtr;

		// Token: 0x0400F7C2 RID: 63426
		private static IntPtr __InpActEvt_Enter_K2Node_InputKeyEvent_16_NativeFunctionPtr;

		// Token: 0x0400F7C3 RID: 63427
		private static IntPtr __InpTchEvt_Moved_NativeFunctionPtr;

		// Token: 0x0400F7C4 RID: 63428
		private static IntPtr __InpTchEvt_Released_NativeFunctionPtr;

		// Token: 0x0400F7C5 RID: 63429
		private static IntPtr __InpTchEvt_Pressed_NativeFunctionPtr;

		// Token: 0x0400F7C6 RID: 63430
		private static IntPtr __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_15_NativeFunctionPtr;

		// Token: 0x0400F7C7 RID: 63431
		private static IntPtr __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_14_NativeFunctionPtr;

		// Token: 0x0400F7C8 RID: 63432
		private static IntPtr __InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_13_NativeFunctionPtr;

		// Token: 0x0400F7C9 RID: 63433
		private static IntPtr __InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_12_NativeFunctionPtr;

		// Token: 0x0400F7CA RID: 63434
		private static IntPtr __InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_11_NativeFunctionPtr;

		// Token: 0x0400F7CB RID: 63435
		private static IntPtr __InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_10_NativeFunctionPtr;

		// Token: 0x0400F7CC RID: 63436
		private static IntPtr __InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_9_NativeFunctionPtr;

		// Token: 0x0400F7CD RID: 63437
		private static IntPtr __InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_8_NativeFunctionPtr;

		// Token: 0x0400F7CE RID: 63438
		private static IntPtr __InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_7_NativeFunctionPtr;

		// Token: 0x0400F7CF RID: 63439
		private static IntPtr __InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_6_NativeFunctionPtr;

		// Token: 0x0400F7D0 RID: 63440
		private static IntPtr __InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_NativeFunctionPtr;

		// Token: 0x0400F7D1 RID: 63441
		private static IntPtr __InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_NativeFunctionPtr;

		// Token: 0x0400F7D2 RID: 63442
		private static IntPtr __InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_NativeFunctionPtr;

		// Token: 0x0400F7D3 RID: 63443
		private static IntPtr __InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_NativeFunctionPtr;

		// Token: 0x0400F7D4 RID: 63444
		private static IntPtr __InpActEvt_AnyKey_K2Node_InputKeyEvent_1_NativeFunctionPtr;

		// Token: 0x0400F7D5 RID: 63445
		private static IntPtr __InpActEvt_AnyKey_K2Node_InputKeyEvent_0_NativeFunctionPtr;

		// Token: 0x0400F7D6 RID: 63446
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F7D7 RID: 63447
		private static IntPtr __InpAxisKeyEvt_MouseWheelAxis_K2Node_InputAxisKeyEvent_0_NativeFunctionPtr;

		// Token: 0x02008CE8 RID: 36072
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_27_FunctionParams
		{
			// Token: 0x0402C832 RID: 182322
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CE9 RID: 36073
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_FaceButton_Bottom_K2Node_InputKeyEvent_26_FunctionParams
		{
			// Token: 0x0402C833 RID: 182323
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CEA RID: 36074
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Down_K2Node_InputKeyEvent_25_FunctionParams
		{
			// Token: 0x0402C834 RID: 182324
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CEB RID: 36075
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Down_K2Node_InputKeyEvent_24_FunctionParams
		{
			// Token: 0x0402C835 RID: 182325
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CEC RID: 36076
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Up_K2Node_InputKeyEvent_23_FunctionParams
		{
			// Token: 0x0402C836 RID: 182326
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CED RID: 36077
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Up_K2Node_InputKeyEvent_22_FunctionParams
		{
			// Token: 0x0402C837 RID: 182327
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CEE RID: 36078
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Right_K2Node_InputKeyEvent_21_FunctionParams
		{
			// Token: 0x0402C838 RID: 182328
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CEF RID: 36079
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Right_K2Node_InputKeyEvent_20_FunctionParams
		{
			// Token: 0x0402C839 RID: 182329
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CF0 RID: 36080
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Left_K2Node_InputKeyEvent_19_FunctionParams
		{
			// Token: 0x0402C83A RID: 182330
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CF1 RID: 36081
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Left_K2Node_InputKeyEvent_18_FunctionParams
		{
			// Token: 0x0402C83B RID: 182331
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CF2 RID: 36082
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Enter_K2Node_InputKeyEvent_17_FunctionParams
		{
			// Token: 0x0402C83C RID: 182332
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CF3 RID: 36083
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Enter_K2Node_InputKeyEvent_16_FunctionParams
		{
			// Token: 0x0402C83D RID: 182333
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CF4 RID: 36084
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InpTchEvt_Moved_FunctionParams
		{
			// Token: 0x0402C83E RID: 182334
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x0402C83F RID: 182335
			[FieldOffset(4)]
			public FVector Location;
		}

		// Token: 0x02008CF5 RID: 36085
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InpTchEvt_Released_FunctionParams
		{
			// Token: 0x0402C840 RID: 182336
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x0402C841 RID: 182337
			[FieldOffset(4)]
			public FVector Location;
		}

		// Token: 0x02008CF6 RID: 36086
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InpTchEvt_Pressed_FunctionParams
		{
			// Token: 0x0402C842 RID: 182338
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x0402C843 RID: 182339
			[FieldOffset(4)]
			public FVector Location;
		}

		// Token: 0x02008CF7 RID: 36087
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_15_FunctionParams
		{
			// Token: 0x0402C844 RID: 182340
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CF8 RID: 36088
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_14_FunctionParams
		{
			// Token: 0x0402C845 RID: 182341
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CF9 RID: 36089
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_13_FunctionParams
		{
			// Token: 0x0402C846 RID: 182342
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CFA RID: 36090
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_LeftStick_Left_K2Node_InputKeyEvent_12_FunctionParams
		{
			// Token: 0x0402C847 RID: 182343
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CFB RID: 36091
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_11_FunctionParams
		{
			// Token: 0x0402C848 RID: 182344
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CFC RID: 36092
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_LeftStick_Right_K2Node_InputKeyEvent_10_FunctionParams
		{
			// Token: 0x0402C849 RID: 182345
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CFD RID: 36093
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_9_FunctionParams
		{
			// Token: 0x0402C84A RID: 182346
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CFE RID: 36094
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_LeftStick_Up_K2Node_InputKeyEvent_8_FunctionParams
		{
			// Token: 0x0402C84B RID: 182347
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008CFF RID: 36095
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_7_FunctionParams
		{
			// Token: 0x0402C84C RID: 182348
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008D00 RID: 36096
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Gamepad_LeftStick_Down_K2Node_InputKeyEvent_6_FunctionParams
		{
			// Token: 0x0402C84D RID: 182349
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008D01 RID: 36097
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_FunctionParams
		{
			// Token: 0x0402C84E RID: 182350
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008D02 RID: 36098
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_FunctionParams
		{
			// Token: 0x0402C84F RID: 182351
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008D03 RID: 36099
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_FunctionParams
		{
			// Token: 0x0402C850 RID: 182352
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008D04 RID: 36100
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_FunctionParams
		{
			// Token: 0x0402C851 RID: 182353
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008D05 RID: 36101
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_AnyKey_K2Node_InputKeyEvent_1_FunctionParams
		{
			// Token: 0x0402C852 RID: 182354
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008D06 RID: 36102
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_AnyKey_K2Node_InputKeyEvent_0_FunctionParams
		{
			// Token: 0x0402C853 RID: 182355
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02008D07 RID: 36103
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InpAxisKeyEvt_MouseWheelAxis_K2Node_InputAxisKeyEvent_0_FunctionParams
		{
			// Token: 0x0402C854 RID: 182356
			[FieldOffset(0)]
			public float AxisValue;
		}
	}
}
