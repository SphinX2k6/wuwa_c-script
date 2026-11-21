using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x02003189 RID: 12681
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_Event.SQtaCustomizationParam_Event")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class SQtaCustomizationParam_Event : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F470 RID: 128112 RVA: 0x0092A39C File Offset: 0x0092859C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaCustomizationParam_Event._ScriptStructPtr != 0) ? SQtaCustomizationParam_Event._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_Event.SQtaCustomizationParam_Event", ref SQtaCustomizationParam_Event._ScriptStructPtr);
		}

		// Token: 0x17003869 RID: 14441
		// (get) Token: 0x0601F471 RID: 128113 RVA: 0x0092A3C0 File Offset: 0x009285C0
		// (set) Token: 0x0601F472 RID: 128114 RVA: 0x0092A3D4 File Offset: 0x009285D4
		public unsafe FGameplayTag EventTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_Event.__PropertyOffset_EventTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_Event.__PropertyOffset_EventTag) = value;
			}
		}

		// Token: 0x1700386A RID: 14442
		// (get) Token: 0x0601F473 RID: 128115 RVA: 0x0092A3E9 File Offset: 0x009285E9
		// (set) Token: 0x0601F474 RID: 128116 RVA: 0x0092A3F9 File Offset: 0x009285F9
		public unsafe float Param1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_Event.__PropertyOffset_Param1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_Event.__PropertyOffset_Param1) = value;
			}
		}

		// Token: 0x1700386B RID: 14443
		// (get) Token: 0x0601F475 RID: 128117 RVA: 0x0092A40A File Offset: 0x0092860A
		// (set) Token: 0x0601F476 RID: 128118 RVA: 0x0092A41A File Offset: 0x0092861A
		public unsafe float Param2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_Event.__PropertyOffset_Param2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_Event.__PropertyOffset_Param2) = value;
			}
		}

		// Token: 0x0601F477 RID: 128119 RVA: 0x0092A42B File Offset: 0x0092862B
		public SQtaCustomizationParam_Event()
		{
		}

		// Token: 0x0601F478 RID: 128120 RVA: 0x0092A433 File Offset: 0x00928633
		protected override IntPtr GetUStructPtr()
		{
			return SQtaCustomizationParam_Event.StaticStruct();
		}

		// Token: 0x0601F479 RID: 128121 RVA: 0x0092A43F File Offset: 0x0092863F
		[NullableContext(2)]
		public SQtaCustomizationParam_Event(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F47A RID: 128122 RVA: 0x0092A449 File Offset: 0x00928649
		public SQtaCustomizationParam_Event(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F47B RID: 128123 RVA: 0x0092A454 File Offset: 0x00928654
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaCustomizationParam_Event(Pointer, false, true);
		}

		// Token: 0x0601F47C RID: 128124 RVA: 0x0092A45E File Offset: 0x0092865E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaCustomizationParam_Event(Pointer, MemoryOwner);
		}

		// Token: 0x04010BD7 RID: 68567
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_Event.SQtaCustomizationParam_Event";

		// Token: 0x04010BD8 RID: 68568
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010BD9 RID: 68569
		internal static int __PropertyOffset_EventTag;

		// Token: 0x04010BDA RID: 68570
		internal static int __PropertyOffset_Param1;

		// Token: 0x04010BDB RID: 68571
		internal static int __PropertyOffset_Param2;
	}
}
