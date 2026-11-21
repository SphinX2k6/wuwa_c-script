using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x02003188 RID: 12680
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_BgBar.SQtaCustomizationParam_BgBar")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class SQtaCustomizationParam_BgBar : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F463 RID: 128099 RVA: 0x0092A28D File Offset: 0x0092848D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaCustomizationParam_BgBar._ScriptStructPtr != 0) ? SQtaCustomizationParam_BgBar._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_BgBar.SQtaCustomizationParam_BgBar", ref SQtaCustomizationParam_BgBar._ScriptStructPtr);
		}

		// Token: 0x17003866 RID: 14438
		// (get) Token: 0x0601F464 RID: 128100 RVA: 0x0092A2B1 File Offset: 0x009284B1
		// (set) Token: 0x0601F465 RID: 128101 RVA: 0x0092A2C1 File Offset: 0x009284C1
		public unsafe float Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_BgBar.__PropertyOffset_Angle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_BgBar.__PropertyOffset_Angle) = value;
			}
		}

		// Token: 0x17003867 RID: 14439
		// (get) Token: 0x0601F466 RID: 128102 RVA: 0x0092A2D2 File Offset: 0x009284D2
		// (set) Token: 0x0601F467 RID: 128103 RVA: 0x0092A2E6 File Offset: 0x009284E6
		public unsafe FLinearColor Anchor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomizationParam_BgBar.__PropertyOffset_Anchor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomizationParam_BgBar.__PropertyOffset_Anchor) = value;
			}
		}

		// Token: 0x17003868 RID: 14440
		// (get) Token: 0x0601F468 RID: 128104 RVA: 0x0092A2FC File Offset: 0x009284FC
		// (set) Token: 0x0601F469 RID: 128105 RVA: 0x0092A33F File Offset: 0x0092853F
		public SQtaCustomizationParam_Progress Progress
		{
			get
			{
				base.FastCheckIsValid();
				SQtaCustomizationParam_Progress result;
				if ((result = this._Progress) == null)
				{
					result = (this._Progress = new SQtaCustomizationParam_Progress(base.NativePtr + (IntPtr)SQtaCustomizationParam_BgBar.__PropertyOffset_Progress, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaCustomizationParam_Progress.StaticStruct(), base.NativePtr + (IntPtr)SQtaCustomizationParam_BgBar.__PropertyOffset_Progress, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F46A RID: 128106 RVA: 0x0092A360 File Offset: 0x00928560
		public SQtaCustomizationParam_BgBar()
		{
		}

		// Token: 0x0601F46B RID: 128107 RVA: 0x0092A368 File Offset: 0x00928568
		protected override IntPtr GetUStructPtr()
		{
			return SQtaCustomizationParam_BgBar.StaticStruct();
		}

		// Token: 0x0601F46C RID: 128108 RVA: 0x0092A374 File Offset: 0x00928574
		[NullableContext(2)]
		public SQtaCustomizationParam_BgBar(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F46D RID: 128109 RVA: 0x0092A37E File Offset: 0x0092857E
		public SQtaCustomizationParam_BgBar(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F46E RID: 128110 RVA: 0x0092A389 File Offset: 0x00928589
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaCustomizationParam_BgBar(Pointer, false, true);
		}

		// Token: 0x0601F46F RID: 128111 RVA: 0x0092A393 File Offset: 0x00928593
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaCustomizationParam_BgBar(Pointer, MemoryOwner);
		}

		// Token: 0x04010BD1 RID: 68561
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomizationParam_BgBar.SQtaCustomizationParam_BgBar";

		// Token: 0x04010BD2 RID: 68562
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010BD3 RID: 68563
		internal static int __PropertyOffset_Angle;

		// Token: 0x04010BD4 RID: 68564
		internal static int __PropertyOffset_Anchor;

		// Token: 0x04010BD5 RID: 68565
		internal static int __PropertyOffset_Progress;

		// Token: 0x04010BD6 RID: 68566
		[Nullable(2)]
		private SQtaCustomizationParam_Progress _Progress;
	}
}
