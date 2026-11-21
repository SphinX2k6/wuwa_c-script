using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.UiNavigation.Struct
{
	// Token: 0x0200315F RID: 12639
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/UiNavigation/Struct/SNavigationDynamicListenerConfig.SNavigationDynamicListenerConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 25)]
	public class SNavigationDynamicListenerConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F206 RID: 127494 RVA: 0x0092713C File Offset: 0x0092533C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNavigationDynamicListenerConfig._ScriptStructPtr != 0) ? SNavigationDynamicListenerConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiNavigation/Struct/SNavigationDynamicListenerConfig.SNavigationDynamicListenerConfig", ref SNavigationDynamicListenerConfig._ScriptStructPtr);
		}

		// Token: 0x17003786 RID: 14214
		// (get) Token: 0x0601F207 RID: 127495 RVA: 0x00927160 File Offset: 0x00925360
		// (set) Token: 0x0601F208 RID: 127496 RVA: 0x00927170 File Offset: 0x00925370
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationDynamicListenerConfig.__PropertyOffset_Index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationDynamicListenerConfig.__PropertyOffset_Index) = value;
			}
		}

		// Token: 0x17003787 RID: 14215
		// (get) Token: 0x0601F209 RID: 127497 RVA: 0x00927181 File Offset: 0x00925381
		// (set) Token: 0x0601F20A RID: 127498 RVA: 0x00927195 File Offset: 0x00925395
		public unsafe AActor LayoutActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationDynamicListenerConfig.__PropertyOffset_LayoutActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationDynamicListenerConfig.__PropertyOffset_LayoutActor, value);
			}
		}

		// Token: 0x17003788 RID: 14216
		// (get) Token: 0x0601F20B RID: 127499 RVA: 0x009271AA File Offset: 0x009253AA
		// (set) Token: 0x0601F20C RID: 127500 RVA: 0x009271BE File Offset: 0x009253BE
		public unsafe AActor ScrollActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationDynamicListenerConfig.__PropertyOffset_ScrollActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationDynamicListenerConfig.__PropertyOffset_ScrollActor, value);
			}
		}

		// Token: 0x17003789 RID: 14217
		// (get) Token: 0x0601F20D RID: 127501 RVA: 0x009271D3 File Offset: 0x009253D3
		// (set) Token: 0x0601F20E RID: 127502 RVA: 0x009271E3 File Offset: 0x009253E3
		public unsafe bool NeedWaitRegister
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationDynamicListenerConfig.__PropertyOffset_NeedWaitRegister) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationDynamicListenerConfig.__PropertyOffset_NeedWaitRegister) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F20F RID: 127503 RVA: 0x009271F4 File Offset: 0x009253F4
		public SNavigationDynamicListenerConfig()
		{
		}

		// Token: 0x0601F210 RID: 127504 RVA: 0x009271FC File Offset: 0x009253FC
		protected override IntPtr GetUStructPtr()
		{
			return SNavigationDynamicListenerConfig.StaticStruct();
		}

		// Token: 0x0601F211 RID: 127505 RVA: 0x00927208 File Offset: 0x00925408
		public SNavigationDynamicListenerConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F212 RID: 127506 RVA: 0x00927212 File Offset: 0x00925412
		public SNavigationDynamicListenerConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F213 RID: 127507 RVA: 0x0092721D File Offset: 0x0092541D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNavigationDynamicListenerConfig(Pointer, false, true);
		}

		// Token: 0x0601F214 RID: 127508 RVA: 0x00927227 File Offset: 0x00925427
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNavigationDynamicListenerConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04010A2F RID: 68143
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/UiNavigation/Struct/SNavigationDynamicListenerConfig.SNavigationDynamicListenerConfig";

		// Token: 0x04010A30 RID: 68144
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010A31 RID: 68145
		internal static int __PropertyOffset_Index;

		// Token: 0x04010A32 RID: 68146
		internal static int __PropertyOffset_LayoutActor;

		// Token: 0x04010A33 RID: 68147
		internal static int __PropertyOffset_ScrollActor;

		// Token: 0x04010A34 RID: 68148
		internal static int __PropertyOffset_NeedWaitRegister;
	}
}
