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
		// Token: 0x060000C5 RID: 197 RVA: 0x0000784D File Offset: 0x00005A4D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (HotFixLGUIEventSystemActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Module/HotFix/HotFixLGUIEventSystemActor.HotFixLGUIEventSystemActor_C");
			}
			return HotFixLGUIEventSystemActor_C._ClassPtr;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00007874 File Offset: 0x00005A74
		public HotFixLGUIEventSystemActor_C() : this(BuiltinUtils.AllocNativeUObject(HotFixLGUIEventSystemActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000789C File Offset: 0x00005A9C
		[NullableContext(1)]
		public HotFixLGUIEventSystemActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(HotFixLGUIEventSystemActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000078CF File Offset: 0x00005ACF
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000078E3 File Offset: 0x00005AE3
		public unsafe ULGUI_TouchInputModule LGUI_TouchInputModule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUI_TouchInputModule>(base.NativePtr / (IntPtr)sizeof(void*) + HotFixLGUIEventSystemActor_C.__PropertyOffset_LGUI_TouchInputModule);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + HotFixLGUIEventSystemActor_C.__PropertyOffset_LGUI_TouchInputModule, value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000078F8 File Offset: 0x00005AF8
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0000790C File Offset: 0x00005B0C
		public unsafe ULGUI_StandaloneInputModule LGUI_StandaloneInputModule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUI_StandaloneInputModule>(base.NativePtr / (IntPtr)sizeof(void*) + HotFixLGUIEventSystemActor_C.__PropertyOffset_LGUI_StandaloneInputModule);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + HotFixLGUIEventSystemActor_C.__PropertyOffset_LGUI_StandaloneInputModule, value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00007921 File Offset: 0x00005B21
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00007935 File Offset: 0x00005B35
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + HotFixLGUIEventSystemActor_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + HotFixLGUIEventSystemActor_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000794A File Offset: 0x00005B4A
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000795E File Offset: 0x00005B5E
		public unsafe ULGUI_PointerInputModule ValidInputModule
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUI_PointerInputModule>(base.NativePtr / (IntPtr)sizeof(void*) + HotFixLGUIEventSystemActor_C.__PropertyOffset_ValidInputModule);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + HotFixLGUIEventSystemActor_C.__PropertyOffset_ValidInputModule, value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00007974 File Offset: 0x00005B74
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x000079AD File Offset: 0x00005BAD
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
					result = (this._OnMiddleMouseScroll = new OnMiddleMouseScroll(base.NativePtr + (IntPtr)HotFixLGUIEventSystemActor_C.__PropertyOffset_OnMiddleMouseScroll, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)HotFixLGUIEventSystemActor_C.__PropertyOffset_OnMiddleMouseScroll, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000079D0 File Offset: 0x00005BD0
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00007A09 File Offset: 0x00005C09
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
					result = (this._OnTouch = new OnTouch(base.NativePtr + (IntPtr)HotFixLGUIEventSystemActor_C.__PropertyOffset_OnTouch, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)HotFixLGUIEventSystemActor_C.__PropertyOffset_OnTouch, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00007A2C File Offset: 0x00005C2C
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00007A65 File Offset: 0x00005C65
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
					result = (this._OnTouchMove = new OnTouchMove(base.NativePtr + (IntPtr)HotFixLGUIEventSystemActor_C.__PropertyOffset_OnTouchMove, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)HotFixLGUIEventSystemActor_C.__PropertyOffset_OnTouchMove, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00007A88 File Offset: 0x00005C88
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00007AC1 File Offset: 0x00005CC1
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
					result = (this._OnClickKey = new OnClickKey(base.NativePtr + (IntPtr)HotFixLGUIEventSystemActor_C.__PropertyOffset_OnClickKey, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)HotFixLGUIEventSystemActor_C.__PropertyOffset_OnClickKey, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00007AE2 File Offset: 0x00005CE2
		protected HotFixLGUIEventSystemActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400005C RID: 92
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Module/HotFix/HotFixLGUIEventSystemActor.HotFixLGUIEventSystemActor_C";

		// Token: 0x0400005D RID: 93
		private static IntPtr _ClassPtr;

		// Token: 0x0400005E RID: 94
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400005F RID: 95
		public static IntPtr __OnClickKey__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04000060 RID: 96
		public static IntPtr __OnTouchMove__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04000061 RID: 97
		public static IntPtr __OnTouch__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04000062 RID: 98
		public static IntPtr __OnMiddleMouseScroll__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04000063 RID: 99
		internal static int __PropertyOffset_LGUI_TouchInputModule;

		// Token: 0x04000064 RID: 100
		internal static int __PropertyOffset_LGUI_StandaloneInputModule;

		// Token: 0x04000065 RID: 101
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04000066 RID: 102
		internal static int __PropertyOffset_ValidInputModule;

		// Token: 0x04000067 RID: 103
		internal static int __PropertyOffset_OnMiddleMouseScroll;

		// Token: 0x04000068 RID: 104
		private OnMiddleMouseScroll _OnMiddleMouseScroll;

		// Token: 0x04000069 RID: 105
		internal static int __PropertyOffset_OnTouch;

		// Token: 0x0400006A RID: 106
		private OnTouch _OnTouch;

		// Token: 0x0400006B RID: 107
		internal static int __PropertyOffset_OnTouchMove;

		// Token: 0x0400006C RID: 108
		private OnTouchMove _OnTouchMove;

		// Token: 0x0400006D RID: 109
		internal static int __PropertyOffset_OnClickKey;

		// Token: 0x0400006E RID: 110
		private OnClickKey _OnClickKey;
	}
}
