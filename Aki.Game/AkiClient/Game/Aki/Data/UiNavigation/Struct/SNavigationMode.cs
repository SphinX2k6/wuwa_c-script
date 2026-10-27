using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.UiNavigation.Struct
{
	// Token: 0x02003E8A RID: 16010
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/UiNavigation/Struct/SNavigationMode.SNavigationMode")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SNavigationMode : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060286DB RID: 165595 RVA: 0x009AC578 File Offset: 0x009AA778
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNavigationMode._ScriptStructPtr != 0) ? SNavigationMode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiNavigation/Struct/SNavigationMode.SNavigationMode", ref SNavigationMode._ScriptStructPtr);
		}

		// Token: 0x17005DB2 RID: 23986
		// (get) Token: 0x060286DC RID: 165596 RVA: 0x009AC59C File Offset: 0x009AA79C
		// (set) Token: 0x060286DD RID: 165597 RVA: 0x009AC5AC File Offset: 0x009AA7AC
		public unsafe EUISelectableNavigationMode TopMode
		{
			get
			{
				return (EUISelectableNavigationMode)(*(base.NativePtr + (IntPtr)SNavigationMode.__PropertyOffset_0));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationMode.__PropertyOffset_0) = (byte)value;
			}
		}

		// Token: 0x17005DB3 RID: 23987
		// (get) Token: 0x060286DE RID: 165598 RVA: 0x009AC5BD File Offset: 0x009AA7BD
		// (set) Token: 0x060286DF RID: 165599 RVA: 0x009AC5D1 File Offset: 0x009AA7D1
		public unsafe AActor TopActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationMode.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationMode.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005DB4 RID: 23988
		// (get) Token: 0x060286E0 RID: 165600 RVA: 0x009AC5E6 File Offset: 0x009AA7E6
		// (set) Token: 0x060286E1 RID: 165601 RVA: 0x009AC5F6 File Offset: 0x009AA7F6
		public unsafe EUISelectableNavigationMode DownMode
		{
			get
			{
				return (EUISelectableNavigationMode)(*(base.NativePtr + (IntPtr)SNavigationMode.__PropertyOffset_2));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationMode.__PropertyOffset_2) = (byte)value;
			}
		}

		// Token: 0x17005DB5 RID: 23989
		// (get) Token: 0x060286E2 RID: 165602 RVA: 0x009AC607 File Offset: 0x009AA807
		// (set) Token: 0x060286E3 RID: 165603 RVA: 0x009AC61B File Offset: 0x009AA81B
		public unsafe AActor DownActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationMode.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationMode.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005DB6 RID: 23990
		// (get) Token: 0x060286E4 RID: 165604 RVA: 0x009AC630 File Offset: 0x009AA830
		// (set) Token: 0x060286E5 RID: 165605 RVA: 0x009AC640 File Offset: 0x009AA840
		public unsafe EUISelectableNavigationMode LeftMode
		{
			get
			{
				return (EUISelectableNavigationMode)(*(base.NativePtr + (IntPtr)SNavigationMode.__PropertyOffset_4));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationMode.__PropertyOffset_4) = (byte)value;
			}
		}

		// Token: 0x17005DB7 RID: 23991
		// (get) Token: 0x060286E6 RID: 165606 RVA: 0x009AC651 File Offset: 0x009AA851
		// (set) Token: 0x060286E7 RID: 165607 RVA: 0x009AC665 File Offset: 0x009AA865
		public unsafe AActor LeftActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationMode.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationMode.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005DB8 RID: 23992
		// (get) Token: 0x060286E8 RID: 165608 RVA: 0x009AC67A File Offset: 0x009AA87A
		// (set) Token: 0x060286E9 RID: 165609 RVA: 0x009AC68A File Offset: 0x009AA88A
		public unsafe EUISelectableNavigationMode RightMode
		{
			get
			{
				return (EUISelectableNavigationMode)(*(base.NativePtr + (IntPtr)SNavigationMode.__PropertyOffset_6));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationMode.__PropertyOffset_6) = (byte)value;
			}
		}

		// Token: 0x17005DB9 RID: 23993
		// (get) Token: 0x060286EA RID: 165610 RVA: 0x009AC69B File Offset: 0x009AA89B
		// (set) Token: 0x060286EB RID: 165611 RVA: 0x009AC6AF File Offset: 0x009AA8AF
		public unsafe AActor RightActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationMode.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationMode.__PropertyOffset_7, value);
			}
		}

		// Token: 0x060286EC RID: 165612 RVA: 0x009AC6C4 File Offset: 0x009AA8C4
		public SNavigationMode()
		{
		}

		// Token: 0x060286ED RID: 165613 RVA: 0x009AC6CC File Offset: 0x009AA8CC
		[NullableContext(1)]
		public SNavigationMode(EUISelectableNavigationMode TopMode, AActor TopActor, EUISelectableNavigationMode DownMode, AActor DownActor, EUISelectableNavigationMode LeftMode, AActor LeftActor, EUISelectableNavigationMode RightMode, AActor RightActor)
		{
			this.TopMode = TopMode;
			this.TopActor = TopActor;
			this.DownMode = DownMode;
			this.DownActor = DownActor;
			this.LeftMode = LeftMode;
			this.LeftActor = LeftActor;
			this.RightMode = RightMode;
			this.RightActor = RightActor;
		}

		// Token: 0x060286EE RID: 165614 RVA: 0x009AC71C File Offset: 0x009AA91C
		protected override IntPtr GetUStructPtr()
		{
			return SNavigationMode.StaticStruct();
		}

		// Token: 0x060286EF RID: 165615 RVA: 0x009AC728 File Offset: 0x009AA928
		public SNavigationMode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060286F0 RID: 165616 RVA: 0x009AC732 File Offset: 0x009AA932
		public SNavigationMode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060286F1 RID: 165617 RVA: 0x009AC73D File Offset: 0x009AA93D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNavigationMode(Pointer, false, true);
		}

		// Token: 0x060286F2 RID: 165618 RVA: 0x009AC747 File Offset: 0x009AA947
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNavigationMode(Pointer, MemoryOwner);
		}

		// Token: 0x040149CA RID: 84426
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/UiNavigation/Struct/SNavigationMode.SNavigationMode";

		// Token: 0x040149CB RID: 84427
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040149CC RID: 84428
		internal static int __PropertyOffset_0;

		// Token: 0x040149CD RID: 84429
		internal static int __PropertyOffset_1;

		// Token: 0x040149CE RID: 84430
		internal static int __PropertyOffset_2;

		// Token: 0x040149CF RID: 84431
		internal static int __PropertyOffset_3;

		// Token: 0x040149D0 RID: 84432
		internal static int __PropertyOffset_4;

		// Token: 0x040149D1 RID: 84433
		internal static int __PropertyOffset_5;

		// Token: 0x040149D2 RID: 84434
		internal static int __PropertyOffset_6;

		// Token: 0x040149D3 RID: 84435
		internal static int __PropertyOffset_7;
	}
}
