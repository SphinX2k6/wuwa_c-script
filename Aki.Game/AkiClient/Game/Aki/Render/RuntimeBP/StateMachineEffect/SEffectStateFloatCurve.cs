using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.StateMachineEffect
{
	// Token: 0x02003AC8 RID: 15048
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/StateMachineEffect/SEffectStateFloatCurve.SEffectStateFloatCurve")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 288)]
	public class SEffectStateFloatCurve : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020696 RID: 132758 RVA: 0x008D206C File Offset: 0x008D026C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEffectStateFloatCurve._ScriptStructPtr != 0) ? SEffectStateFloatCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/StateMachineEffect/SEffectStateFloatCurve.SEffectStateFloatCurve", ref SEffectStateFloatCurve._ScriptStructPtr);
		}

		// Token: 0x170030A4 RID: 12452
		// (get) Token: 0x06020697 RID: 132759 RVA: 0x008D2090 File Offset: 0x008D0290
		// (set) Token: 0x06020698 RID: 132760 RVA: 0x008D20D3 File Offset: 0x008D02D3
		public FKuroCurveFloat PreFloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._PreFloatCurve) == null)
				{
					result = (this._PreFloatCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)SEffectStateFloatCurve.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)SEffectStateFloatCurve.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170030A5 RID: 12453
		// (get) Token: 0x06020699 RID: 132761 RVA: 0x008D20F4 File Offset: 0x008D02F4
		// (set) Token: 0x0602069A RID: 132762 RVA: 0x008D2137 File Offset: 0x008D0337
		public FKuroCurveFloat LoopFloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._LoopFloatCurve) == null)
				{
					result = (this._LoopFloatCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)SEffectStateFloatCurve.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)SEffectStateFloatCurve.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602069B RID: 132763 RVA: 0x008D2158 File Offset: 0x008D0358
		public SEffectStateFloatCurve()
		{
		}

		// Token: 0x0602069C RID: 132764 RVA: 0x008D2160 File Offset: 0x008D0360
		public SEffectStateFloatCurve(FKuroCurveFloat PreFloatCurve, FKuroCurveFloat LoopFloatCurve)
		{
			this.PreFloatCurve = PreFloatCurve;
			this.LoopFloatCurve = LoopFloatCurve;
		}

		// Token: 0x0602069D RID: 132765 RVA: 0x008D2176 File Offset: 0x008D0376
		protected override IntPtr GetUStructPtr()
		{
			return SEffectStateFloatCurve.StaticStruct();
		}

		// Token: 0x0602069E RID: 132766 RVA: 0x008D2182 File Offset: 0x008D0382
		[NullableContext(2)]
		public SEffectStateFloatCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602069F RID: 132767 RVA: 0x008D218C File Offset: 0x008D038C
		public SEffectStateFloatCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060206A0 RID: 132768 RVA: 0x008D2197 File Offset: 0x008D0397
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SEffectStateFloatCurve(Pointer, false, true);
		}

		// Token: 0x060206A1 RID: 132769 RVA: 0x008D21A1 File Offset: 0x008D03A1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SEffectStateFloatCurve(Pointer, MemoryOwner);
		}

		// Token: 0x0400FB1D RID: 64285
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/StateMachineEffect/SEffectStateFloatCurve.SEffectStateFloatCurve";

		// Token: 0x0400FB1E RID: 64286
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FB1F RID: 64287
		internal static int __PropertyOffset_0;

		// Token: 0x0400FB20 RID: 64288
		[Nullable(2)]
		private FKuroCurveFloat _PreFloatCurve;

		// Token: 0x0400FB21 RID: 64289
		internal static int __PropertyOffset_1;

		// Token: 0x0400FB22 RID: 64290
		[Nullable(2)]
		private FKuroCurveFloat _LoopFloatCurve;
	}
}
