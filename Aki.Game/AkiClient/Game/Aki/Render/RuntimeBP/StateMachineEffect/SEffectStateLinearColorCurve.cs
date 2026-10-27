using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.StateMachineEffect
{
	// Token: 0x02003ACA RID: 15050
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/StateMachineEffect/SEffectStateLinearColorCurve.SEffectStateLinearColorCurve")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1088)]
	public class SEffectStateLinearColorCurve : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060206B8 RID: 132792 RVA: 0x008D23FA File Offset: 0x008D05FA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEffectStateLinearColorCurve._ScriptStructPtr != 0) ? SEffectStateLinearColorCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/StateMachineEffect/SEffectStateLinearColorCurve.SEffectStateLinearColorCurve", ref SEffectStateLinearColorCurve._ScriptStructPtr);
		}

		// Token: 0x170030AD RID: 12461
		// (get) Token: 0x060206B9 RID: 132793 RVA: 0x008D2420 File Offset: 0x008D0620
		// (set) Token: 0x060206BA RID: 132794 RVA: 0x008D2463 File Offset: 0x008D0663
		public FKuroCurveLinearColor PreLinearColorCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._PreLinearColorCurve) == null)
				{
					result = (this._PreLinearColorCurve = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)SEffectStateLinearColorCurve.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)SEffectStateLinearColorCurve.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170030AE RID: 12462
		// (get) Token: 0x060206BB RID: 132795 RVA: 0x008D2484 File Offset: 0x008D0684
		// (set) Token: 0x060206BC RID: 132796 RVA: 0x008D24C7 File Offset: 0x008D06C7
		public FKuroCurveLinearColor LoopLinearColorCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._LoopLinearColorCurve) == null)
				{
					result = (this._LoopLinearColorCurve = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)SEffectStateLinearColorCurve.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)SEffectStateLinearColorCurve.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060206BD RID: 132797 RVA: 0x008D24E8 File Offset: 0x008D06E8
		public SEffectStateLinearColorCurve()
		{
		}

		// Token: 0x060206BE RID: 132798 RVA: 0x008D24F0 File Offset: 0x008D06F0
		public SEffectStateLinearColorCurve(FKuroCurveLinearColor PreLinearColorCurve, FKuroCurveLinearColor LoopLinearColorCurve)
		{
			this.PreLinearColorCurve = PreLinearColorCurve;
			this.LoopLinearColorCurve = LoopLinearColorCurve;
		}

		// Token: 0x060206BF RID: 132799 RVA: 0x008D2506 File Offset: 0x008D0706
		protected override IntPtr GetUStructPtr()
		{
			return SEffectStateLinearColorCurve.StaticStruct();
		}

		// Token: 0x060206C0 RID: 132800 RVA: 0x008D2512 File Offset: 0x008D0712
		[NullableContext(2)]
		public SEffectStateLinearColorCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060206C1 RID: 132801 RVA: 0x008D251C File Offset: 0x008D071C
		public SEffectStateLinearColorCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060206C2 RID: 132802 RVA: 0x008D2527 File Offset: 0x008D0727
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SEffectStateLinearColorCurve(Pointer, false, true);
		}

		// Token: 0x060206C3 RID: 132803 RVA: 0x008D2531 File Offset: 0x008D0731
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SEffectStateLinearColorCurve(Pointer, MemoryOwner);
		}

		// Token: 0x0400FB30 RID: 64304
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/StateMachineEffect/SEffectStateLinearColorCurve.SEffectStateLinearColorCurve";

		// Token: 0x0400FB31 RID: 64305
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FB32 RID: 64306
		internal static int __PropertyOffset_0;

		// Token: 0x0400FB33 RID: 64307
		[Nullable(2)]
		private FKuroCurveLinearColor _PreLinearColorCurve;

		// Token: 0x0400FB34 RID: 64308
		internal static int __PropertyOffset_1;

		// Token: 0x0400FB35 RID: 64309
		[Nullable(2)]
		private FKuroCurveLinearColor _LoopLinearColorCurve;
	}
}
