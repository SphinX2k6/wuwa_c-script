using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.StateMachineEffect
{
	// Token: 0x02003ACB RID: 15051
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/StateMachineEffect/SStateBasedEffectFloatCurveSection.SStateBasedEffectFloatCurveSection")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 368)]
	public class SStateBasedEffectFloatCurveSection : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060206C4 RID: 132804 RVA: 0x008D253A File Offset: 0x008D073A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SStateBasedEffectFloatCurveSection._ScriptStructPtr != 0) ? SStateBasedEffectFloatCurveSection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/StateMachineEffect/SStateBasedEffectFloatCurveSection.SStateBasedEffectFloatCurveSection", ref SStateBasedEffectFloatCurveSection._ScriptStructPtr);
		}

		// Token: 0x170030AF RID: 12463
		// (get) Token: 0x060206C5 RID: 132805 RVA: 0x008D2560 File Offset: 0x008D0760
		// (set) Token: 0x060206C6 RID: 132806 RVA: 0x008D25A3 File Offset: 0x008D07A3
		public SEffectStateFloatCurve DefaultCurveInfo
		{
			get
			{
				base.FastCheckIsValid();
				SEffectStateFloatCurve result;
				if ((result = this._DefaultCurveInfo) == null)
				{
					result = (this._DefaultCurveInfo = new SEffectStateFloatCurve(base.NativePtr + (IntPtr)SStateBasedEffectFloatCurveSection.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SEffectStateFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)SStateBasedEffectFloatCurveSection.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170030B0 RID: 12464
		// (get) Token: 0x060206C7 RID: 132807 RVA: 0x008D25C4 File Offset: 0x008D07C4
		// (set) Token: 0x060206C8 RID: 132808 RVA: 0x008D2607 File Offset: 0x008D0807
		public TMap<int, SEffectStateFloatCurve> OverrideSectionCurveInfo
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, SEffectStateFloatCurve> result;
				if ((result = this._OverrideSectionCurveInfo) == null)
				{
					result = (this._OverrideSectionCurveInfo = new TMap<int, SEffectStateFloatCurve>(base.NativePtr + (IntPtr)SStateBasedEffectFloatCurveSection.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OverrideSectionCurveInfo.CopyAssign(value);
			}
		}

		// Token: 0x060206C9 RID: 132809 RVA: 0x008D2615 File Offset: 0x008D0815
		public SStateBasedEffectFloatCurveSection()
		{
		}

		// Token: 0x060206CA RID: 132810 RVA: 0x008D261D File Offset: 0x008D081D
		public SStateBasedEffectFloatCurveSection(SEffectStateFloatCurve DefaultCurveInfo, TMap<int, SEffectStateFloatCurve> OverrideSectionCurveInfo)
		{
			this.DefaultCurveInfo = DefaultCurveInfo;
			this.OverrideSectionCurveInfo = OverrideSectionCurveInfo;
		}

		// Token: 0x060206CB RID: 132811 RVA: 0x008D2633 File Offset: 0x008D0833
		protected override IntPtr GetUStructPtr()
		{
			return SStateBasedEffectFloatCurveSection.StaticStruct();
		}

		// Token: 0x060206CC RID: 132812 RVA: 0x008D263F File Offset: 0x008D083F
		[NullableContext(2)]
		public SStateBasedEffectFloatCurveSection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060206CD RID: 132813 RVA: 0x008D2649 File Offset: 0x008D0849
		public SStateBasedEffectFloatCurveSection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060206CE RID: 132814 RVA: 0x008D2654 File Offset: 0x008D0854
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SStateBasedEffectFloatCurveSection(Pointer, false, true);
		}

		// Token: 0x060206CF RID: 132815 RVA: 0x008D265E File Offset: 0x008D085E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SStateBasedEffectFloatCurveSection(Pointer, MemoryOwner);
		}

		// Token: 0x0400FB36 RID: 64310
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/StateMachineEffect/SStateBasedEffectFloatCurveSection.SStateBasedEffectFloatCurveSection";

		// Token: 0x0400FB37 RID: 64311
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FB38 RID: 64312
		internal static int __PropertyOffset_0;

		// Token: 0x0400FB39 RID: 64313
		[Nullable(2)]
		private SEffectStateFloatCurve _DefaultCurveInfo;

		// Token: 0x0400FB3A RID: 64314
		internal static int __PropertyOffset_1;

		// Token: 0x0400FB3B RID: 64315
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, SEffectStateFloatCurve> _OverrideSectionCurveInfo;
	}
}
