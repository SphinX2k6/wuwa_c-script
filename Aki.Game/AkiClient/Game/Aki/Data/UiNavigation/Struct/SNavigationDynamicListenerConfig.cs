using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.UiNavigation.Struct
{
	// Token: 0x02003E88 RID: 16008
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/UiNavigation/Struct/SNavigationDynamicListenerConfig.SNavigationDynamicListenerConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 25)]
	public class SNavigationDynamicListenerConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602869F RID: 165535 RVA: 0x009AC089 File Offset: 0x009AA289
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNavigationDynamicListenerConfig._ScriptStructPtr != 0) ? SNavigationDynamicListenerConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiNavigation/Struct/SNavigationDynamicListenerConfig.SNavigationDynamicListenerConfig", ref SNavigationDynamicListenerConfig._ScriptStructPtr);
		}

		// Token: 0x17005D9C RID: 23964
		// (get) Token: 0x060286A0 RID: 165536 RVA: 0x009AC0AD File Offset: 0x009AA2AD
		// (set) Token: 0x060286A1 RID: 165537 RVA: 0x009AC0BD File Offset: 0x009AA2BD
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationDynamicListenerConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationDynamicListenerConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005D9D RID: 23965
		// (get) Token: 0x060286A2 RID: 165538 RVA: 0x009AC0CE File Offset: 0x009AA2CE
		// (set) Token: 0x060286A3 RID: 165539 RVA: 0x009AC0E2 File Offset: 0x009AA2E2
		public unsafe AActor LayoutActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationDynamicListenerConfig.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationDynamicListenerConfig.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005D9E RID: 23966
		// (get) Token: 0x060286A4 RID: 165540 RVA: 0x009AC0F7 File Offset: 0x009AA2F7
		// (set) Token: 0x060286A5 RID: 165541 RVA: 0x009AC10B File Offset: 0x009AA30B
		public unsafe AActor ScrollActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationDynamicListenerConfig.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationDynamicListenerConfig.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005D9F RID: 23967
		// (get) Token: 0x060286A6 RID: 165542 RVA: 0x009AC120 File Offset: 0x009AA320
		// (set) Token: 0x060286A7 RID: 165543 RVA: 0x009AC130 File Offset: 0x009AA330
		public unsafe bool NeedWaitRegister
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationDynamicListenerConfig.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationDynamicListenerConfig.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x060286A8 RID: 165544 RVA: 0x009AC141 File Offset: 0x009AA341
		public SNavigationDynamicListenerConfig()
		{
		}

		// Token: 0x060286A9 RID: 165545 RVA: 0x009AC149 File Offset: 0x009AA349
		[NullableContext(1)]
		public SNavigationDynamicListenerConfig(int Index, AActor LayoutActor, AActor ScrollActor, bool NeedWaitRegister)
		{
			this.Index = Index;
			this.LayoutActor = LayoutActor;
			this.ScrollActor = ScrollActor;
			this.NeedWaitRegister = NeedWaitRegister;
		}

		// Token: 0x060286AA RID: 165546 RVA: 0x009AC16E File Offset: 0x009AA36E
		protected override IntPtr GetUStructPtr()
		{
			return SNavigationDynamicListenerConfig.StaticStruct();
		}

		// Token: 0x060286AB RID: 165547 RVA: 0x009AC17A File Offset: 0x009AA37A
		public SNavigationDynamicListenerConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060286AC RID: 165548 RVA: 0x009AC184 File Offset: 0x009AA384
		public SNavigationDynamicListenerConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060286AD RID: 165549 RVA: 0x009AC18F File Offset: 0x009AA38F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNavigationDynamicListenerConfig(Pointer, false, true);
		}

		// Token: 0x060286AE RID: 165550 RVA: 0x009AC199 File Offset: 0x009AA399
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNavigationDynamicListenerConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040149AE RID: 84398
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/UiNavigation/Struct/SNavigationDynamicListenerConfig.SNavigationDynamicListenerConfig";

		// Token: 0x040149AF RID: 84399
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040149B0 RID: 84400
		internal static int __PropertyOffset_0;

		// Token: 0x040149B1 RID: 84401
		internal static int __PropertyOffset_1;

		// Token: 0x040149B2 RID: 84402
		internal static int __PropertyOffset_2;

		// Token: 0x040149B3 RID: 84403
		internal static int __PropertyOffset_3;
	}
}
