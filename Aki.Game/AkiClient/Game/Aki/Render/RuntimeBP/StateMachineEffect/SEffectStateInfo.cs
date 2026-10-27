using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.StateMachineEffect
{
	// Token: 0x02003AC9 RID: 15049
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/StateMachineEffect/SEffectStateInfo.SEffectStateInfo")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 336)]
	public class SEffectStateInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060206A2 RID: 132770 RVA: 0x008D21AA File Offset: 0x008D03AA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEffectStateInfo._ScriptStructPtr != 0) ? SEffectStateInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/StateMachineEffect/SEffectStateInfo.SEffectStateInfo", ref SEffectStateInfo._ScriptStructPtr);
		}

		// Token: 0x170030A6 RID: 12454
		// (get) Token: 0x060206A3 RID: 132771 RVA: 0x008D21CE File Offset: 0x008D03CE
		// (set) Token: 0x060206A4 RID: 132772 RVA: 0x008D21DE File Offset: 0x008D03DE
		public unsafe float StateTransitionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEffectStateInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEffectStateInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170030A7 RID: 12455
		// (get) Token: 0x060206A5 RID: 132773 RVA: 0x008D21EF File Offset: 0x008D03EF
		// (set) Token: 0x060206A6 RID: 132774 RVA: 0x008D21FF File Offset: 0x008D03FF
		public unsafe float PreLoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEffectStateInfo.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEffectStateInfo.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170030A8 RID: 12456
		// (get) Token: 0x060206A7 RID: 132775 RVA: 0x008D2210 File Offset: 0x008D0410
		// (set) Token: 0x060206A8 RID: 132776 RVA: 0x008D2220 File Offset: 0x008D0420
		public unsafe float LoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEffectStateInfo.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEffectStateInfo.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170030A9 RID: 12457
		// (get) Token: 0x060206A9 RID: 132777 RVA: 0x008D2234 File Offset: 0x008D0434
		// (set) Token: 0x060206AA RID: 132778 RVA: 0x008D2277 File Offset: 0x008D0477
		public TMap<FName, SEffectStateFloatCurve> FloatInfos
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, SEffectStateFloatCurve> result;
				if ((result = this._FloatInfos) == null)
				{
					result = (this._FloatInfos = new TMap<FName, SEffectStateFloatCurve>(base.NativePtr + (IntPtr)SEffectStateInfo.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatInfos.CopyAssign(value);
			}
		}

		// Token: 0x170030AA RID: 12458
		// (get) Token: 0x060206AB RID: 132779 RVA: 0x008D2288 File Offset: 0x008D0488
		// (set) Token: 0x060206AC RID: 132780 RVA: 0x008D22CB File Offset: 0x008D04CB
		public TMap<FName, SEffectStateLinearColorCurve> LinearColorInfos
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, SEffectStateLinearColorCurve> result;
				if ((result = this._LinearColorInfos) == null)
				{
					result = (this._LinearColorInfos = new TMap<FName, SEffectStateLinearColorCurve>(base.NativePtr + (IntPtr)SEffectStateInfo.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LinearColorInfos.CopyAssign(value);
			}
		}

		// Token: 0x170030AB RID: 12459
		// (get) Token: 0x060206AD RID: 132781 RVA: 0x008D22DC File Offset: 0x008D04DC
		// (set) Token: 0x060206AE RID: 132782 RVA: 0x008D231F File Offset: 0x008D051F
		public TMap<FName, SStateBasedEffectFloatCurveSection> StaticMeshFloatInfo
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, SStateBasedEffectFloatCurveSection> result;
				if ((result = this._StaticMeshFloatInfo) == null)
				{
					result = (this._StaticMeshFloatInfo = new TMap<FName, SStateBasedEffectFloatCurveSection>(base.NativePtr + (IntPtr)SEffectStateInfo.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StaticMeshFloatInfo.CopyAssign(value);
			}
		}

		// Token: 0x170030AC RID: 12460
		// (get) Token: 0x060206AF RID: 132783 RVA: 0x008D2330 File Offset: 0x008D0530
		// (set) Token: 0x060206B0 RID: 132784 RVA: 0x008D2373 File Offset: 0x008D0573
		public TMap<FName, SStateBasedEffectLinearColorCurveSection> StaticMeshLinearColorInfo
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, SStateBasedEffectLinearColorCurveSection> result;
				if ((result = this._StaticMeshLinearColorInfo) == null)
				{
					result = (this._StaticMeshLinearColorInfo = new TMap<FName, SStateBasedEffectLinearColorCurveSection>(base.NativePtr + (IntPtr)SEffectStateInfo.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StaticMeshLinearColorInfo.CopyAssign(value);
			}
		}

		// Token: 0x060206B1 RID: 132785 RVA: 0x008D2381 File Offset: 0x008D0581
		public SEffectStateInfo()
		{
		}

		// Token: 0x060206B2 RID: 132786 RVA: 0x008D2389 File Offset: 0x008D0589
		public SEffectStateInfo(float StateTransitionTime, float PreLoopTime, float LoopTime, TMap<FName, SEffectStateFloatCurve> FloatInfos, TMap<FName, SEffectStateLinearColorCurve> LinearColorInfos, TMap<FName, SStateBasedEffectFloatCurveSection> StaticMeshFloatInfo, TMap<FName, SStateBasedEffectLinearColorCurveSection> StaticMeshLinearColorInfo)
		{
			this.StateTransitionTime = StateTransitionTime;
			this.PreLoopTime = PreLoopTime;
			this.LoopTime = LoopTime;
			this.FloatInfos = FloatInfos;
			this.LinearColorInfos = LinearColorInfos;
			this.StaticMeshFloatInfo = StaticMeshFloatInfo;
			this.StaticMeshLinearColorInfo = StaticMeshLinearColorInfo;
		}

		// Token: 0x060206B3 RID: 132787 RVA: 0x008D23C6 File Offset: 0x008D05C6
		protected override IntPtr GetUStructPtr()
		{
			return SEffectStateInfo.StaticStruct();
		}

		// Token: 0x060206B4 RID: 132788 RVA: 0x008D23D2 File Offset: 0x008D05D2
		[NullableContext(2)]
		public SEffectStateInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060206B5 RID: 132789 RVA: 0x008D23DC File Offset: 0x008D05DC
		public SEffectStateInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060206B6 RID: 132790 RVA: 0x008D23E7 File Offset: 0x008D05E7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SEffectStateInfo(Pointer, false, true);
		}

		// Token: 0x060206B7 RID: 132791 RVA: 0x008D23F1 File Offset: 0x008D05F1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SEffectStateInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400FB23 RID: 64291
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/StateMachineEffect/SEffectStateInfo.SEffectStateInfo";

		// Token: 0x0400FB24 RID: 64292
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FB25 RID: 64293
		internal static int __PropertyOffset_0;

		// Token: 0x0400FB26 RID: 64294
		internal static int __PropertyOffset_1;

		// Token: 0x0400FB27 RID: 64295
		internal static int __PropertyOffset_2;

		// Token: 0x0400FB28 RID: 64296
		internal static int __PropertyOffset_3;

		// Token: 0x0400FB29 RID: 64297
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, SEffectStateFloatCurve> _FloatInfos;

		// Token: 0x0400FB2A RID: 64298
		internal static int __PropertyOffset_4;

		// Token: 0x0400FB2B RID: 64299
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, SEffectStateLinearColorCurve> _LinearColorInfos;

		// Token: 0x0400FB2C RID: 64300
		internal static int __PropertyOffset_5;

		// Token: 0x0400FB2D RID: 64301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, SStateBasedEffectFloatCurveSection> _StaticMeshFloatInfo;

		// Token: 0x0400FB2E RID: 64302
		internal static int __PropertyOffset_6;

		// Token: 0x0400FB2F RID: 64303
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, SStateBasedEffectLinearColorCurveSection> _StaticMeshLinearColorInfo;
	}
}
