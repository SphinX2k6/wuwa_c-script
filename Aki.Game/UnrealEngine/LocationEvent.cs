using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200445D RID: 17501
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Niagara/DefaultAssets/Structs/LocationEvent.LocationEvent")]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class LocationEvent : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D4AF RID: 185519 RVA: 0x00A3898E File Offset: 0x00A36B8E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (LocationEvent._ScriptStructPtr != 0) ? LocationEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Niagara/DefaultAssets/Structs/LocationEvent.LocationEvent", ref LocationEvent._ScriptStructPtr);
		}

		// Token: 0x170072E5 RID: 29413
		// (get) Token: 0x0602D4B0 RID: 185520 RVA: 0x00A389B2 File Offset: 0x00A36BB2
		// (set) Token: 0x0602D4B1 RID: 185521 RVA: 0x00A389C6 File Offset: 0x00A36BC6
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)LocationEvent.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)LocationEvent.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170072E6 RID: 29414
		// (get) Token: 0x0602D4B2 RID: 185522 RVA: 0x00A389DB File Offset: 0x00A36BDB
		// (set) Token: 0x0602D4B3 RID: 185523 RVA: 0x00A389EF File Offset: 0x00A36BEF
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)LocationEvent.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)LocationEvent.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170072E7 RID: 29415
		// (get) Token: 0x0602D4B4 RID: 185524 RVA: 0x00A38A04 File Offset: 0x00A36C04
		// (set) Token: 0x0602D4B5 RID: 185525 RVA: 0x00A38A18 File Offset: 0x00A36C18
		public unsafe FVector Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)LocationEvent.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)LocationEvent.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170072E8 RID: 29416
		// (get) Token: 0x0602D4B6 RID: 185526 RVA: 0x00A38A30 File Offset: 0x00A36C30
		// (set) Token: 0x0602D4B7 RID: 185527 RVA: 0x00A38A73 File Offset: 0x00A36C73
		public FNiagaraID RibbonID
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraID result;
				if ((result = this._RibbonID) == null)
				{
					result = (this._RibbonID = new FNiagaraID(base.NativePtr + (IntPtr)LocationEvent.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraID.StaticStruct(), base.NativePtr + (IntPtr)LocationEvent.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170072E9 RID: 29417
		// (get) Token: 0x0602D4B8 RID: 185528 RVA: 0x00A38A94 File Offset: 0x00A36C94
		// (set) Token: 0x0602D4B9 RID: 185529 RVA: 0x00A38AA4 File Offset: 0x00A36CA4
		public unsafe float NormalizedAge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)LocationEvent.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)LocationEvent.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170072EA RID: 29418
		// (get) Token: 0x0602D4BA RID: 185530 RVA: 0x00A38AB5 File Offset: 0x00A36CB5
		// (set) Token: 0x0602D4BB RID: 185531 RVA: 0x00A38AC5 File Offset: 0x00A36CC5
		public unsafe float RandomNormalizedFloat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)LocationEvent.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)LocationEvent.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x0602D4BC RID: 185532 RVA: 0x00A38AD6 File Offset: 0x00A36CD6
		public LocationEvent()
		{
		}

		// Token: 0x0602D4BD RID: 185533 RVA: 0x00A38ADE File Offset: 0x00A36CDE
		public LocationEvent(FVector Position, FVector Velocity, FVector Acceleration, FNiagaraID RibbonID, float NormalizedAge, float RandomNormalizedFloat)
		{
			this.Position = Position;
			this.Velocity = Velocity;
			this.Acceleration = Acceleration;
			this.RibbonID = RibbonID;
			this.NormalizedAge = NormalizedAge;
			this.RandomNormalizedFloat = RandomNormalizedFloat;
		}

		// Token: 0x0602D4BE RID: 185534 RVA: 0x00A38B13 File Offset: 0x00A36D13
		protected override IntPtr GetUStructPtr()
		{
			return LocationEvent.StaticStruct();
		}

		// Token: 0x0602D4BF RID: 185535 RVA: 0x00A38B1F File Offset: 0x00A36D1F
		[NullableContext(2)]
		public LocationEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D4C0 RID: 185536 RVA: 0x00A38B29 File Offset: 0x00A36D29
		public LocationEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D4C1 RID: 185537 RVA: 0x00A38B34 File Offset: 0x00A36D34
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new LocationEvent(Pointer, false, true);
		}

		// Token: 0x0602D4C2 RID: 185538 RVA: 0x00A38B3E File Offset: 0x00A36D3E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new LocationEvent(Pointer, MemoryOwner);
		}

		// Token: 0x040181B7 RID: 98743
		public const string __ObjectPath = "/Niagara/DefaultAssets/Structs/LocationEvent.LocationEvent";

		// Token: 0x040181B8 RID: 98744
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040181B9 RID: 98745
		internal static int __PropertyOffset_0;

		// Token: 0x040181BA RID: 98746
		internal static int __PropertyOffset_1;

		// Token: 0x040181BB RID: 98747
		internal static int __PropertyOffset_2;

		// Token: 0x040181BC RID: 98748
		internal static int __PropertyOffset_3;

		// Token: 0x040181BD RID: 98749
		[Nullable(2)]
		private FNiagaraID _RibbonID;

		// Token: 0x040181BE RID: 98750
		internal static int __PropertyOffset_4;

		// Token: 0x040181BF RID: 98751
		internal static int __PropertyOffset_5;
	}
}
