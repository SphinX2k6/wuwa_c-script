using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Common.Struct
{
	// Token: 0x02003FA3 RID: 16291
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Common/Struct/SCharacterLocationsAndRadius.SCharacterLocationsAndRadius")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class SCharacterLocationsAndRadius : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060299E0 RID: 170464 RVA: 0x009C8C27 File Offset: 0x009C6E27
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCharacterLocationsAndRadius._ScriptStructPtr != 0) ? SCharacterLocationsAndRadius._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Common/Struct/SCharacterLocationsAndRadius.SCharacterLocationsAndRadius", ref SCharacterLocationsAndRadius._ScriptStructPtr);
		}

		// Token: 0x1700643A RID: 25658
		// (get) Token: 0x060299E1 RID: 170465 RVA: 0x009C8C4C File Offset: 0x009C6E4C
		// (set) Token: 0x060299E2 RID: 170466 RVA: 0x009C8C8F File Offset: 0x009C6E8F
		public TArray<FVectorDouble> Locations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._Locations) == null)
				{
					result = (this._Locations = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)SCharacterLocationsAndRadius.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Locations.CopyAssign(value);
			}
		}

		// Token: 0x1700643B RID: 25659
		// (get) Token: 0x060299E3 RID: 170467 RVA: 0x009C8CA0 File Offset: 0x009C6EA0
		// (set) Token: 0x060299E4 RID: 170468 RVA: 0x009C8CE3 File Offset: 0x009C6EE3
		public TArray<float> Radius
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Radius) == null)
				{
					result = (this._Radius = new TArray<float>(base.NativePtr + (IntPtr)SCharacterLocationsAndRadius.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Radius.CopyAssign(value);
			}
		}

		// Token: 0x1700643C RID: 25660
		// (get) Token: 0x060299E5 RID: 170469 RVA: 0x009C8CF4 File Offset: 0x009C6EF4
		// (set) Token: 0x060299E6 RID: 170470 RVA: 0x009C8D37 File Offset: 0x009C6F37
		public TArray<float> HalfHeight
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._HalfHeight) == null)
				{
					result = (this._HalfHeight = new TArray<float>(base.NativePtr + (IntPtr)SCharacterLocationsAndRadius.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HalfHeight.CopyAssign(value);
			}
		}

		// Token: 0x060299E7 RID: 170471 RVA: 0x009C8D45 File Offset: 0x009C6F45
		public SCharacterLocationsAndRadius()
		{
		}

		// Token: 0x060299E8 RID: 170472 RVA: 0x009C8D4D File Offset: 0x009C6F4D
		public SCharacterLocationsAndRadius(TArray<FVectorDouble> Locations, TArray<float> Radius, TArray<float> HalfHeight)
		{
			this.Locations = Locations;
			this.Radius = Radius;
			this.HalfHeight = HalfHeight;
		}

		// Token: 0x060299E9 RID: 170473 RVA: 0x009C8D6A File Offset: 0x009C6F6A
		protected override IntPtr GetUStructPtr()
		{
			return SCharacterLocationsAndRadius.StaticStruct();
		}

		// Token: 0x060299EA RID: 170474 RVA: 0x009C8D76 File Offset: 0x009C6F76
		[NullableContext(2)]
		public SCharacterLocationsAndRadius(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060299EB RID: 170475 RVA: 0x009C8D80 File Offset: 0x009C6F80
		public SCharacterLocationsAndRadius(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060299EC RID: 170476 RVA: 0x009C8D8B File Offset: 0x009C6F8B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCharacterLocationsAndRadius(Pointer, false, true);
		}

		// Token: 0x060299ED RID: 170477 RVA: 0x009C8D95 File Offset: 0x009C6F95
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCharacterLocationsAndRadius(Pointer, MemoryOwner);
		}

		// Token: 0x040155B2 RID: 87474
		public const string __ObjectPath = "/Game/Aki/Data/Common/Struct/SCharacterLocationsAndRadius.SCharacterLocationsAndRadius";

		// Token: 0x040155B3 RID: 87475
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040155B4 RID: 87476
		internal static int __PropertyOffset_0;

		// Token: 0x040155B5 RID: 87477
		[Nullable(2)]
		private TArray<FVectorDouble> _Locations;

		// Token: 0x040155B6 RID: 87478
		internal static int __PropertyOffset_1;

		// Token: 0x040155B7 RID: 87479
		[Nullable(2)]
		private TArray<float> _Radius;

		// Token: 0x040155B8 RID: 87480
		internal static int __PropertyOffset_2;

		// Token: 0x040155B9 RID: 87481
		[Nullable(2)]
		private TArray<float> _HalfHeight;
	}
}
