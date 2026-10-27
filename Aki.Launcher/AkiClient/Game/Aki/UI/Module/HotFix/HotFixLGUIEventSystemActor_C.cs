using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.HotFix
{
	// Token: 0x0200001B RID: 27
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Module/HotFix/HotFixLGUIEventSystemActor.HotFixLGUIEventSystemActor_C")]
	[UnrealStructLayout(1144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1144)]
	public class HotFixLGUIEventSystemActor_C : ALGUIEventSystemActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00007815 File Offset: 0x00005A15
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (HotFixLGUIEventSystemActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Module/HotFix/HotFixLGUIEventSystemActor.HotFixLGUIEventSystemActor_C");
			}
			return HotFixLGUIEventSystemActor_C._ClassPtr;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000783C File Offset: 0x00005A3C
		public HotFixLGUIEventSystemActor_C() : this(BuiltinUtils.AllocNativeUObject(HotFixLGUIEventSystemActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00007864 File Offset: 0x00005A64
		[NullableContext(1)]
		public HotFixLGUIEventSystemActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(HotFixLGUIEventSystemActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00007897 File Offset: 0x00005A97
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000078AB File Offset: 0x00005AAB
		public unsafe ULGUI_TouchInputModule LGUI_TouchInputModule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUI_TouchInputModule>(base.NativePtr / (IntPtr)sizeof(void*) + HotFixLGUIEventSystemActor_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + HotFixLGUIEventSystemActor_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000078C0 File Offset: 0x00005AC0
		// (set) Token: 0x060000CB RID: 203 RVA: 0x000078D4 File Offset: 0x00005AD4
		public unsafe ULGUI_StandaloneInputModule LGUI_StandaloneInputModule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUI_StandaloneInputModule>(base.NativePtr / (IntPtr)sizeof(void*) + HotFixLGUIEventSystemActor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + HotFixLGUIEventSystemActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000078E9 File Offset: 0x00005AE9
		// (set) Token: 0x060000CD RID: 205 RVA: 0x000078FD File Offset: 0x00005AFD
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + HotFixLGUIEventSystemActor_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + HotFixLGUIEventSystemActor_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00007912 File Offset: 0x00005B12
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00007926 File Offset: 0x00005B26
		public unsafe ULGUI_PointerInputModule ValidInputModule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUI_PointerInputModule>(base.NativePtr / (IntPtr)sizeof(void*) + HotFixLGUIEventSystemActor_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + HotFixLGUIEventSystemActor_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000793C File Offset: 0x00005B3C
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00007975 File Offset: 0x00005B75
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
					result = (this._OnMiddleMouseScroll = new OnMiddleMouseScroll(base.NativePtr + (IntPtr)HotFixLGUIEventSystemActor_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)HotFixLGUIEventSystemActor_C.__PropertyOffset_4, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00007998 File Offset: 0x00005B98
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x000079D1 File Offset: 0x00005BD1
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
					result = (this._OnTouch = new OnTouch(base.NativePtr + (IntPtr)HotFixLGUIEventSystemActor_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)HotFixLGUIEventSystemActor_C.__PropertyOffset_5, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000079F4 File Offset: 0x00005BF4
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00007A2D File Offset: 0x00005C2D
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
					result = (this._OnTouchMove = new OnTouchMove(base.NativePtr + (IntPtr)HotFixLGUIEventSystemActor_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)HotFixLGUIEventSystemActor_C.__PropertyOffset_6, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00007A50 File Offset: 0x00005C50
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00007A89 File Offset: 0x00005C89
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
					result = (this._OnClickKey = new OnClickKey(base.NativePtr + (IntPtr)HotFixLGUIEventSystemActor_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)HotFixLGUIEventSystemActor_C.__PropertyOffset_7, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00007AAA File Offset: 0x00005CAA
		protected HotFixLGUIEventSystemActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400005B RID: 91
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Module/HotFix/HotFixLGUIEventSystemActor.HotFixLGUIEventSystemActor_C";

		// Token: 0x0400005C RID: 92
		private static IntPtr _ClassPtr;

		// Token: 0x0400005D RID: 93
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400005E RID: 94
		public static IntPtr __OnClickKey__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400005F RID: 95
		public static IntPtr __OnTouchMove__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04000060 RID: 96
		public static IntPtr __OnTouch__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04000061 RID: 97
		public static IntPtr __OnMiddleMouseScroll__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04000062 RID: 98
		internal static int __PropertyOffset_0;

		// Token: 0x04000063 RID: 99
		internal static int __PropertyOffset_1;

		// Token: 0x04000064 RID: 100
		internal static int __PropertyOffset_2;

		// Token: 0x04000065 RID: 101
		internal static int __PropertyOffset_3;

		// Token: 0x04000066 RID: 102
		internal static int __PropertyOffset_4;

		// Token: 0x04000067 RID: 103
		private OnMiddleMouseScroll _OnMiddleMouseScroll;

		// Token: 0x04000068 RID: 104
		internal static int __PropertyOffset_5;

		// Token: 0x04000069 RID: 105
		private OnTouch _OnTouch;

		// Token: 0x0400006A RID: 106
		internal static int __PropertyOffset_6;

		// Token: 0x0400006B RID: 107
		private OnTouchMove _OnTouchMove;

		// Token: 0x0400006C RID: 108
		internal static int __PropertyOffset_7;

		// Token: 0x0400006D RID: 109
		private OnClickKey _OnClickKey;
	}
}
