using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02004455 RID: 17493
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/HoudiniNiagara/HoudiniEvent.HoudiniEvent")]
	[UnrealStructLayout(68, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 68)]
	public class HoudiniEvent : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D44F RID: 185423 RVA: 0x00A381E2 File Offset: 0x00A363E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (HoudiniEvent._ScriptStructPtr != 0) ? HoudiniEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/HoudiniNiagara/HoudiniEvent.HoudiniEvent", ref HoudiniEvent._ScriptStructPtr);
		}

		// Token: 0x170072CD RID: 29389
		// (get) Token: 0x0602D450 RID: 185424 RVA: 0x00A38206 File Offset: 0x00A36406
		// (set) Token: 0x0602D451 RID: 185425 RVA: 0x00A3821A File Offset: 0x00A3641A
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)HoudiniEvent.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)HoudiniEvent.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170072CE RID: 29390
		// (get) Token: 0x0602D452 RID: 185426 RVA: 0x00A3822F File Offset: 0x00A3642F
		// (set) Token: 0x0602D453 RID: 185427 RVA: 0x00A38243 File Offset: 0x00A36443
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)HoudiniEvent.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)HoudiniEvent.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170072CF RID: 29391
		// (get) Token: 0x0602D454 RID: 185428 RVA: 0x00A38258 File Offset: 0x00A36458
		// (set) Token: 0x0602D455 RID: 185429 RVA: 0x00A3826C File Offset: 0x00A3646C
		public unsafe FVector Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)HoudiniEvent.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)HoudiniEvent.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170072D0 RID: 29392
		// (get) Token: 0x0602D456 RID: 185430 RVA: 0x00A38284 File Offset: 0x00A36484
		// (set) Token: 0x0602D457 RID: 185431 RVA: 0x00A382C7 File Offset: 0x00A364C7
		public FNiagaraID RibbonID
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraID result;
				if ((result = this._RibbonID) == null)
				{
					result = (this._RibbonID = new FNiagaraID(base.NativePtr + (IntPtr)HoudiniEvent.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraID.StaticStruct(), base.NativePtr + (IntPtr)HoudiniEvent.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170072D1 RID: 29393
		// (get) Token: 0x0602D458 RID: 185432 RVA: 0x00A382E8 File Offset: 0x00A364E8
		// (set) Token: 0x0602D459 RID: 185433 RVA: 0x00A382F8 File Offset: 0x00A364F8
		public unsafe float NormalizedAge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)HoudiniEvent.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)HoudiniEvent.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170072D2 RID: 29394
		// (get) Token: 0x0602D45A RID: 185434 RVA: 0x00A38309 File Offset: 0x00A36509
		// (set) Token: 0x0602D45B RID: 185435 RVA: 0x00A38319 File Offset: 0x00A36519
		public unsafe float RandomNormalizedFloat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)HoudiniEvent.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)HoudiniEvent.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170072D3 RID: 29395
		// (get) Token: 0x0602D45C RID: 185436 RVA: 0x00A3832A File Offset: 0x00A3652A
		// (set) Token: 0x0602D45D RID: 185437 RVA: 0x00A3833E File Offset: 0x00A3653E
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)HoudiniEvent.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)HoudiniEvent.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170072D4 RID: 29396
		// (get) Token: 0x0602D45E RID: 185438 RVA: 0x00A38353 File Offset: 0x00A36553
		// (set) Token: 0x0602D45F RID: 185439 RVA: 0x00A38363 File Offset: 0x00A36563
		public unsafe float Impulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)HoudiniEvent.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)HoudiniEvent.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x0602D460 RID: 185440 RVA: 0x00A38374 File Offset: 0x00A36574
		public HoudiniEvent()
		{
		}

		// Token: 0x0602D461 RID: 185441 RVA: 0x00A3837C File Offset: 0x00A3657C
		public HoudiniEvent(FVector Position, FVector Velocity, FVector Acceleration, FNiagaraID RibbonID, float NormalizedAge, float RandomNormalizedFloat, FVector Normal, float Impulse)
		{
			this.Position = Position;
			this.Velocity = Velocity;
			this.Acceleration = Acceleration;
			this.RibbonID = RibbonID;
			this.NormalizedAge = NormalizedAge;
			this.RandomNormalizedFloat = RandomNormalizedFloat;
			this.Normal = Normal;
			this.Impulse = Impulse;
		}

		// Token: 0x0602D462 RID: 185442 RVA: 0x00A383CC File Offset: 0x00A365CC
		protected override IntPtr GetUStructPtr()
		{
			return HoudiniEvent.StaticStruct();
		}

		// Token: 0x0602D463 RID: 185443 RVA: 0x00A383D8 File Offset: 0x00A365D8
		[NullableContext(2)]
		public HoudiniEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D464 RID: 185444 RVA: 0x00A383E2 File Offset: 0x00A365E2
		public HoudiniEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D465 RID: 185445 RVA: 0x00A383ED File Offset: 0x00A365ED
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new HoudiniEvent(Pointer, false, true);
		}

		// Token: 0x0602D466 RID: 185446 RVA: 0x00A383F7 File Offset: 0x00A365F7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new HoudiniEvent(Pointer, MemoryOwner);
		}

		// Token: 0x0401817C RID: 98684
		public const string __ObjectPath = "/HoudiniNiagara/HoudiniEvent.HoudiniEvent";

		// Token: 0x0401817D RID: 98685
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401817E RID: 98686
		internal static int __PropertyOffset_0;

		// Token: 0x0401817F RID: 98687
		internal static int __PropertyOffset_1;

		// Token: 0x04018180 RID: 98688
		internal static int __PropertyOffset_2;

		// Token: 0x04018181 RID: 98689
		internal static int __PropertyOffset_3;

		// Token: 0x04018182 RID: 98690
		[Nullable(2)]
		private FNiagaraID _RibbonID;

		// Token: 0x04018183 RID: 98691
		internal static int __PropertyOffset_4;

		// Token: 0x04018184 RID: 98692
		internal static int __PropertyOffset_5;

		// Token: 0x04018185 RID: 98693
		internal static int __PropertyOffset_6;

		// Token: 0x04018186 RID: 98694
		internal static int __PropertyOffset_7;
	}
}
