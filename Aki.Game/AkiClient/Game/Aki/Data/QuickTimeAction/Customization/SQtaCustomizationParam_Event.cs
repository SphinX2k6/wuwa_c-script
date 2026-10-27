using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x02003EBD RID: 16061
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_Event.SQtaCustomizationParam_Event")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class SQtaCustomizationParam_Event : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060289D8 RID: 166360 RVA: 0x009B08F1 File Offset: 0x009AEAF1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaCustomizationParam_Event._ScriptStructPtr != 0) ? SQtaCustomizationParam_Event._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_Event.SQtaCustomizationParam_Event", ref SQtaCustomizationParam_Event._ScriptStructPtr);
		}

		// Token: 0x17005EB9 RID: 24249
		// (get) Token: 0x060289D9 RID: 166361 RVA: 0x009B0915 File Offset: 0x009AEB15
		// (set) Token: 0x060289DA RID: 166362 RVA: 0x009B0929 File Offset: 0x009AEB29
		public unsafe FGameplayTag EventTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_Event.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_Event.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005EBA RID: 24250
		// (get) Token: 0x060289DB RID: 166363 RVA: 0x009B093E File Offset: 0x009AEB3E
		// (set) Token: 0x060289DC RID: 166364 RVA: 0x009B094E File Offset: 0x009AEB4E
		public unsafe float Param1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_Event.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_Event.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005EBB RID: 24251
		// (get) Token: 0x060289DD RID: 166365 RVA: 0x009B095F File Offset: 0x009AEB5F
		// (set) Token: 0x060289DE RID: 166366 RVA: 0x009B096F File Offset: 0x009AEB6F
		public unsafe float Param2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_Event.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_Event.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x060289DF RID: 166367 RVA: 0x009B0980 File Offset: 0x009AEB80
		public SQtaCustomizationParam_Event()
		{
		}

		// Token: 0x060289E0 RID: 166368 RVA: 0x009B0988 File Offset: 0x009AEB88
		public SQtaCustomizationParam_Event(FGameplayTag EventTag, float Param1, float Param2)
		{
			this.EventTag = EventTag;
			this.Param1 = Param1;
			this.Param2 = Param2;
		}

		// Token: 0x060289E1 RID: 166369 RVA: 0x009B09A5 File Offset: 0x009AEBA5
		protected override IntPtr GetUStructPtr()
		{
			return SQtaCustomizationParam_Event.StaticStruct();
		}

		// Token: 0x060289E2 RID: 166370 RVA: 0x009B09B1 File Offset: 0x009AEBB1
		[NullableContext(2)]
		public SQtaCustomizationParam_Event(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060289E3 RID: 166371 RVA: 0x009B09BB File Offset: 0x009AEBBB
		public SQtaCustomizationParam_Event(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060289E4 RID: 166372 RVA: 0x009B09C6 File Offset: 0x009AEBC6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaCustomizationParam_Event(Pointer, false, true);
		}

		// Token: 0x060289E5 RID: 166373 RVA: 0x009B09D0 File Offset: 0x009AEBD0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaCustomizationParam_Event(Pointer, MemoryOwner);
		}

		// Token: 0x04014BB2 RID: 84914
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_Event.SQtaCustomizationParam_Event";

		// Token: 0x04014BB3 RID: 84915
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014BB4 RID: 84916
		internal static int __PropertyOffset_0;

		// Token: 0x04014BB5 RID: 84917
		internal static int __PropertyOffset_1;

		// Token: 0x04014BB6 RID: 84918
		internal static int __PropertyOffset_2;
	}
}
