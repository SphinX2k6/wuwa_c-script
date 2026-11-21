using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x0200318A RID: 12682
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_Progress.SQtaCustomizationParam_Progress")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SQtaCustomizationParam_Progress : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F47D RID: 128125 RVA: 0x0092A467 File Offset: 0x00928667
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaCustomizationParam_Progress._ScriptStructPtr != 0) ? SQtaCustomizationParam_Progress._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_Progress.SQtaCustomizationParam_Progress", ref SQtaCustomizationParam_Progress._ScriptStructPtr);
		}

		// Token: 0x1700386C RID: 14444
		// (get) Token: 0x0601F47E RID: 128126 RVA: 0x0092A48B File Offset: 0x0092868B
		// (set) Token: 0x0601F47F RID: 128127 RVA: 0x0092A49B File Offset: 0x0092869B
		public unsafe float InitProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_Progress.__PropertyOffset_InitProgress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_Progress.__PropertyOffset_InitProgress) = value;
			}
		}

		// Token: 0x1700386D RID: 14445
		// (get) Token: 0x0601F480 RID: 128128 RVA: 0x0092A4AC File Offset: 0x009286AC
		// (set) Token: 0x0601F481 RID: 128129 RVA: 0x0092A4BC File Offset: 0x009286BC
		public unsafe float MaxProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_Progress.__PropertyOffset_MaxProgress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_Progress.__PropertyOffset_MaxProgress) = value;
			}
		}

		// Token: 0x1700386E RID: 14446
		// (get) Token: 0x0601F482 RID: 128130 RVA: 0x0092A4CD File Offset: 0x009286CD
		// (set) Token: 0x0601F483 RID: 128131 RVA: 0x0092A4DD File Offset: 0x009286DD
		public unsafe float AutoSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_Progress.__PropertyOffset_AutoSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_Progress.__PropertyOffset_AutoSpeed) = value;
			}
		}

		// Token: 0x1700386F RID: 14447
		// (get) Token: 0x0601F484 RID: 128132 RVA: 0x0092A4EE File Offset: 0x009286EE
		// (set) Token: 0x0601F485 RID: 128133 RVA: 0x0092A4FE File Offset: 0x009286FE
		public unsafe float AdditionSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_Progress.__PropertyOffset_AdditionSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_Progress.__PropertyOffset_AdditionSpeed) = value;
			}
		}

		// Token: 0x0601F486 RID: 128134 RVA: 0x0092A50F File Offset: 0x0092870F
		public SQtaCustomizationParam_Progress()
		{
		}

		// Token: 0x0601F487 RID: 128135 RVA: 0x0092A517 File Offset: 0x00928717
		protected override IntPtr GetUStructPtr()
		{
			return SQtaCustomizationParam_Progress.StaticStruct();
		}

		// Token: 0x0601F488 RID: 128136 RVA: 0x0092A523 File Offset: 0x00928723
		[NullableContext(2)]
		public SQtaCustomizationParam_Progress(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F489 RID: 128137 RVA: 0x0092A52D File Offset: 0x0092872D
		public SQtaCustomizationParam_Progress(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F48A RID: 128138 RVA: 0x0092A538 File Offset: 0x00928738
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaCustomizationParam_Progress(Pointer, false, true);
		}

		// Token: 0x0601F48B RID: 128139 RVA: 0x0092A542 File Offset: 0x00928742
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaCustomizationParam_Progress(Pointer, MemoryOwner);
		}

		// Token: 0x04010BDC RID: 68572
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_Progress.SQtaCustomizationParam_Progress";

		// Token: 0x04010BDD RID: 68573
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010BDE RID: 68574
		internal static int __PropertyOffset_InitProgress;

		// Token: 0x04010BDF RID: 68575
		internal static int __PropertyOffset_MaxProgress;

		// Token: 0x04010BE0 RID: 68576
		internal static int __PropertyOffset_AutoSpeed;

		// Token: 0x04010BE1 RID: 68577
		internal static int __PropertyOffset_AdditionSpeed;
	}
}
