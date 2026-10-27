using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x02003EBE RID: 16062
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_Progress.SQtaCustomizationParam_Progress")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SQtaCustomizationParam_Progress : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060289E6 RID: 166374 RVA: 0x009B09D9 File Offset: 0x009AEBD9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaCustomizationParam_Progress._ScriptStructPtr != 0) ? SQtaCustomizationParam_Progress._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_Progress.SQtaCustomizationParam_Progress", ref SQtaCustomizationParam_Progress._ScriptStructPtr);
		}

		// Token: 0x17005EBC RID: 24252
		// (get) Token: 0x060289E7 RID: 166375 RVA: 0x009B09FD File Offset: 0x009AEBFD
		// (set) Token: 0x060289E8 RID: 166376 RVA: 0x009B0A0D File Offset: 0x009AEC0D
		public unsafe float InitProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_Progress.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_Progress.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005EBD RID: 24253
		// (get) Token: 0x060289E9 RID: 166377 RVA: 0x009B0A1E File Offset: 0x009AEC1E
		// (set) Token: 0x060289EA RID: 166378 RVA: 0x009B0A2E File Offset: 0x009AEC2E
		public unsafe float MaxProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_Progress.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_Progress.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005EBE RID: 24254
		// (get) Token: 0x060289EB RID: 166379 RVA: 0x009B0A3F File Offset: 0x009AEC3F
		// (set) Token: 0x060289EC RID: 166380 RVA: 0x009B0A4F File Offset: 0x009AEC4F
		public unsafe float AutoSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_Progress.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_Progress.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005EBF RID: 24255
		// (get) Token: 0x060289ED RID: 166381 RVA: 0x009B0A60 File Offset: 0x009AEC60
		// (set) Token: 0x060289EE RID: 166382 RVA: 0x009B0A70 File Offset: 0x009AEC70
		public unsafe float AdditionSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_Progress.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_Progress.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x060289EF RID: 166383 RVA: 0x009B0A81 File Offset: 0x009AEC81
		public SQtaCustomizationParam_Progress()
		{
		}

		// Token: 0x060289F0 RID: 166384 RVA: 0x009B0A89 File Offset: 0x009AEC89
		public SQtaCustomizationParam_Progress(float InitProgress, float MaxProgress, float AutoSpeed, float AdditionSpeed)
		{
			this.InitProgress = InitProgress;
			this.MaxProgress = MaxProgress;
			this.AutoSpeed = AutoSpeed;
			this.AdditionSpeed = AdditionSpeed;
		}

		// Token: 0x060289F1 RID: 166385 RVA: 0x009B0AAE File Offset: 0x009AECAE
		protected override IntPtr GetUStructPtr()
		{
			return SQtaCustomizationParam_Progress.StaticStruct();
		}

		// Token: 0x060289F2 RID: 166386 RVA: 0x009B0ABA File Offset: 0x009AECBA
		[NullableContext(2)]
		public SQtaCustomizationParam_Progress(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060289F3 RID: 166387 RVA: 0x009B0AC4 File Offset: 0x009AECC4
		public SQtaCustomizationParam_Progress(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060289F4 RID: 166388 RVA: 0x009B0ACF File Offset: 0x009AECCF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaCustomizationParam_Progress(Pointer, false, true);
		}

		// Token: 0x060289F5 RID: 166389 RVA: 0x009B0AD9 File Offset: 0x009AECD9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaCustomizationParam_Progress(Pointer, MemoryOwner);
		}

		// Token: 0x04014BB7 RID: 84919
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_Progress.SQtaCustomizationParam_Progress";

		// Token: 0x04014BB8 RID: 84920
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014BB9 RID: 84921
		internal static int __PropertyOffset_0;

		// Token: 0x04014BBA RID: 84922
		internal static int __PropertyOffset_1;

		// Token: 0x04014BBB RID: 84923
		internal static int __PropertyOffset_2;

		// Token: 0x04014BBC RID: 84924
		internal static int __PropertyOffset_3;
	}
}
