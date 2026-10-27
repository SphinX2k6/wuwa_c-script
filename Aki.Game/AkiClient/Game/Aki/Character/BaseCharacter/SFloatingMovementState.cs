using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004313 RID: 17171
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SFloatingMovementState.SFloatingMovementState")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class SFloatingMovementState : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C6B5 RID: 181941 RVA: 0x00A1F550 File Offset: 0x00A1D750
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFloatingMovementState._ScriptStructPtr != 0) ? SFloatingMovementState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SFloatingMovementState.SFloatingMovementState", ref SFloatingMovementState._ScriptStructPtr);
		}

		// Token: 0x17006F29 RID: 28457
		// (get) Token: 0x0602C6B6 RID: 181942 RVA: 0x00A1F574 File Offset: 0x00A1D774
		// (set) Token: 0x0602C6B7 RID: 181943 RVA: 0x00A1F588 File Offset: 0x00A1D788
		[Nullable(0)]
		public unsafe TEnumAsByte<EFloatingMovementType> Mode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_0);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006F2A RID: 28458
		// (get) Token: 0x0602C6B8 RID: 181944 RVA: 0x00A1F5A0 File Offset: 0x00A1D7A0
		// (set) Token: 0x0602C6B9 RID: 181945 RVA: 0x00A1F5E3 File Offset: 0x00A1D7E3
		public FGameplayTagContainer MovementTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._MovementTagList) == null)
				{
					result = (this._MovementTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006F2B RID: 28459
		// (get) Token: 0x0602C6BA RID: 181946 RVA: 0x00A1F604 File Offset: 0x00A1D804
		// (set) Token: 0x0602C6BB RID: 181947 RVA: 0x00A1F647 File Offset: 0x00A1D847
		public FGameplayTagContainer BannedMovementTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._BannedMovementTagList) == null)
				{
					result = (this._BannedMovementTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006F2C RID: 28460
		// (get) Token: 0x0602C6BC RID: 181948 RVA: 0x00A1F668 File Offset: 0x00A1D868
		// (set) Token: 0x0602C6BD RID: 181949 RVA: 0x00A1F6AB File Offset: 0x00A1D8AB
		public FGameplayTagContainer MoveTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._MoveTagList) == null)
				{
					result = (this._MoveTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006F2D RID: 28461
		// (get) Token: 0x0602C6BE RID: 181950 RVA: 0x00A1F6CC File Offset: 0x00A1D8CC
		// (set) Token: 0x0602C6BF RID: 181951 RVA: 0x00A1F70F File Offset: 0x00A1D90F
		public FGameplayTagContainer StandTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._StandTagList) == null)
				{
					result = (this._StandTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602C6C0 RID: 181952 RVA: 0x00A1F730 File Offset: 0x00A1D930
		public SFloatingMovementState()
		{
		}

		// Token: 0x0602C6C1 RID: 181953 RVA: 0x00A1F738 File Offset: 0x00A1D938
		public SFloatingMovementState([Nullable(0)] TEnumAsByte<EFloatingMovementType> Mode, FGameplayTagContainer MovementTagList, FGameplayTagContainer BannedMovementTagList, FGameplayTagContainer MoveTagList, FGameplayTagContainer StandTagList)
		{
			this.Mode = Mode;
			this.MovementTagList = MovementTagList;
			this.BannedMovementTagList = BannedMovementTagList;
			this.MoveTagList = MoveTagList;
			this.StandTagList = StandTagList;
		}

		// Token: 0x0602C6C2 RID: 181954 RVA: 0x00A1F765 File Offset: 0x00A1D965
		protected override IntPtr GetUStructPtr()
		{
			return SFloatingMovementState.StaticStruct();
		}

		// Token: 0x0602C6C3 RID: 181955 RVA: 0x00A1F771 File Offset: 0x00A1D971
		[NullableContext(2)]
		public SFloatingMovementState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C6C4 RID: 181956 RVA: 0x00A1F77B File Offset: 0x00A1D97B
		public SFloatingMovementState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C6C5 RID: 181957 RVA: 0x00A1F786 File Offset: 0x00A1D986
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFloatingMovementState(Pointer, false, true);
		}

		// Token: 0x0602C6C6 RID: 181958 RVA: 0x00A1F790 File Offset: 0x00A1D990
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFloatingMovementState(Pointer, MemoryOwner);
		}

		// Token: 0x040176B3 RID: 95923
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SFloatingMovementState.SFloatingMovementState";

		// Token: 0x040176B4 RID: 95924
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040176B5 RID: 95925
		internal static int __PropertyOffset_0;

		// Token: 0x040176B6 RID: 95926
		internal static int __PropertyOffset_1;

		// Token: 0x040176B7 RID: 95927
		[Nullable(2)]
		private FGameplayTagContainer _MovementTagList;

		// Token: 0x040176B8 RID: 95928
		internal static int __PropertyOffset_2;

		// Token: 0x040176B9 RID: 95929
		[Nullable(2)]
		private FGameplayTagContainer _BannedMovementTagList;

		// Token: 0x040176BA RID: 95930
		internal static int __PropertyOffset_3;

		// Token: 0x040176BB RID: 95931
		[Nullable(2)]
		private FGameplayTagContainer _MoveTagList;

		// Token: 0x040176BC RID: 95932
		internal static int __PropertyOffset_4;

		// Token: 0x040176BD RID: 95933
		[Nullable(2)]
		private FGameplayTagContainer _StandTagList;
	}
}
