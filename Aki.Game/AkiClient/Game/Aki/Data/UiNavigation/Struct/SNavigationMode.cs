using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.UiNavigation.Struct
{
	// Token: 0x02003161 RID: 12641
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/UiNavigation/Struct/SNavigationMode.SNavigationMode")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SNavigationMode : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F240 RID: 127552 RVA: 0x00927568 File Offset: 0x00925768
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNavigationMode._ScriptStructPtr != 0) ? SNavigationMode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiNavigation/Struct/SNavigationMode.SNavigationMode", ref SNavigationMode._ScriptStructPtr);
		}

		// Token: 0x1700379C RID: 14236
		// (get) Token: 0x0601F241 RID: 127553 RVA: 0x0092758C File Offset: 0x0092578C
		// (set) Token: 0x0601F242 RID: 127554 RVA: 0x0092759C File Offset: 0x0092579C
		public unsafe EUISelectableNavigationMode TopMode
		{
			get
			{
				return (EUISelectableNavigationMode)(*(base.NativePtr + (IntPtr)SNavigationMode.__PropertyOffset_TopMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationMode.__PropertyOffset_TopMode) = (byte)value;
			}
		}

		// Token: 0x1700379D RID: 14237
		// (get) Token: 0x0601F243 RID: 127555 RVA: 0x009275AD File Offset: 0x009257AD
		// (set) Token: 0x0601F244 RID: 127556 RVA: 0x009275C1 File Offset: 0x009257C1
		public unsafe AActor TopActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationMode.__PropertyOffset_TopActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationMode.__PropertyOffset_TopActor, value);
			}
		}

		// Token: 0x1700379E RID: 14238
		// (get) Token: 0x0601F245 RID: 127557 RVA: 0x009275D6 File Offset: 0x009257D6
		// (set) Token: 0x0601F246 RID: 127558 RVA: 0x009275E6 File Offset: 0x009257E6
		public unsafe EUISelectableNavigationMode DownMode
		{
			get
			{
				return (EUISelectableNavigationMode)(*(base.NativePtr + (IntPtr)SNavigationMode.__PropertyOffset_DownMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationMode.__PropertyOffset_DownMode) = (byte)value;
			}
		}

		// Token: 0x1700379F RID: 14239
		// (get) Token: 0x0601F247 RID: 127559 RVA: 0x009275F7 File Offset: 0x009257F7
		// (set) Token: 0x0601F248 RID: 127560 RVA: 0x0092760B File Offset: 0x0092580B
		public unsafe AActor DownActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationMode.__PropertyOffset_DownActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationMode.__PropertyOffset_DownActor, value);
			}
		}

		// Token: 0x170037A0 RID: 14240
		// (get) Token: 0x0601F249 RID: 127561 RVA: 0x00927620 File Offset: 0x00925820
		// (set) Token: 0x0601F24A RID: 127562 RVA: 0x00927630 File Offset: 0x00925830
		public unsafe EUISelectableNavigationMode LeftMode
		{
			get
			{
				return (EUISelectableNavigationMode)(*(base.NativePtr + (IntPtr)SNavigationMode.__PropertyOffset_LeftMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationMode.__PropertyOffset_LeftMode) = (byte)value;
			}
		}

		// Token: 0x170037A1 RID: 14241
		// (get) Token: 0x0601F24B RID: 127563 RVA: 0x00927641 File Offset: 0x00925841
		// (set) Token: 0x0601F24C RID: 127564 RVA: 0x00927655 File Offset: 0x00925855
		public unsafe AActor LeftActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationMode.__PropertyOffset_LeftActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationMode.__PropertyOffset_LeftActor, value);
			}
		}

		// Token: 0x170037A2 RID: 14242
		// (get) Token: 0x0601F24D RID: 127565 RVA: 0x0092766A File Offset: 0x0092586A
		// (set) Token: 0x0601F24E RID: 127566 RVA: 0x0092767A File Offset: 0x0092587A
		public unsafe EUISelectableNavigationMode RightMode
		{
			get
			{
				return (EUISelectableNavigationMode)(*(base.NativePtr + (IntPtr)SNavigationMode.__PropertyOffset_RightMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationMode.__PropertyOffset_RightMode) = (byte)value;
			}
		}

		// Token: 0x170037A3 RID: 14243
		// (get) Token: 0x0601F24F RID: 127567 RVA: 0x0092768B File Offset: 0x0092588B
		// (set) Token: 0x0601F250 RID: 127568 RVA: 0x0092769F File Offset: 0x0092589F
		public unsafe AActor RightActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationMode.__PropertyOffset_RightActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNavigationMode.__PropertyOffset_RightActor, value);
			}
		}

		// Token: 0x0601F251 RID: 127569 RVA: 0x009276B4 File Offset: 0x009258B4
		public SNavigationMode()
		{
		}

		// Token: 0x0601F252 RID: 127570 RVA: 0x009276BC File Offset: 0x009258BC
		protected override IntPtr GetUStructPtr()
		{
			return SNavigationMode.StaticStruct();
		}

		// Token: 0x0601F253 RID: 127571 RVA: 0x009276C8 File Offset: 0x009258C8
		public SNavigationMode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F254 RID: 127572 RVA: 0x009276D2 File Offset: 0x009258D2
		public SNavigationMode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F255 RID: 127573 RVA: 0x009276DD File Offset: 0x009258DD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNavigationMode(Pointer, false, true);
		}

		// Token: 0x0601F256 RID: 127574 RVA: 0x009276E7 File Offset: 0x009258E7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNavigationMode(Pointer, MemoryOwner);
		}

		// Token: 0x04010A4B RID: 68171
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/UiNavigation/Struct/SNavigationMode.SNavigationMode";

		// Token: 0x04010A4C RID: 68172
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010A4D RID: 68173
		internal static int __PropertyOffset_TopMode;

		// Token: 0x04010A4E RID: 68174
		internal static int __PropertyOffset_TopActor;

		// Token: 0x04010A4F RID: 68175
		internal static int __PropertyOffset_DownMode;

		// Token: 0x04010A50 RID: 68176
		internal static int __PropertyOffset_DownActor;

		// Token: 0x04010A51 RID: 68177
		internal static int __PropertyOffset_LeftMode;

		// Token: 0x04010A52 RID: 68178
		internal static int __PropertyOffset_LeftActor;

		// Token: 0x04010A53 RID: 68179
		internal static int __PropertyOffset_RightMode;

		// Token: 0x04010A54 RID: 68180
		internal static int __PropertyOffset_RightActor;
	}
}
