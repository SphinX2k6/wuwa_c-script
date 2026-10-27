using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Character
{
	// Token: 0x02003FA8 RID: 16296
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Character/EEnterExitPerformVehicleMontage.EEnterExitPerformVehicleMontage")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class EEnterExitPerformVehicleMontage : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029A10 RID: 170512 RVA: 0x009C90B0 File Offset: 0x009C72B0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (EEnterExitPerformVehicleMontage._ScriptStructPtr != 0) ? EEnterExitPerformVehicleMontage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Character/EEnterExitPerformVehicleMontage.EEnterExitPerformVehicleMontage", ref EEnterExitPerformVehicleMontage._ScriptStructPtr);
		}

		// Token: 0x17006446 RID: 25670
		// (get) Token: 0x06029A11 RID: 170513 RVA: 0x009C90D4 File Offset: 0x009C72D4
		// (set) Token: 0x06029A12 RID: 170514 RVA: 0x009C90E4 File Offset: 0x009C72E4
		public unsafe bool IsEnter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006447 RID: 25671
		// (get) Token: 0x06029A13 RID: 170515 RVA: 0x009C90F5 File Offset: 0x009C72F5
		// (set) Token: 0x06029A14 RID: 170516 RVA: 0x009C9109 File Offset: 0x009C7309
		public unsafe TEnumAsByte<EEnterExitPerformVehicle_Gender> Gender
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006448 RID: 25672
		// (get) Token: 0x06029A15 RID: 170517 RVA: 0x009C911E File Offset: 0x009C731E
		// (set) Token: 0x06029A16 RID: 170518 RVA: 0x009C9132 File Offset: 0x009C7332
		public unsafe TEnumAsByte<EEnterExitPerformVehicle_Direction> Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006449 RID: 25673
		// (get) Token: 0x06029A17 RID: 170519 RVA: 0x009C9147 File Offset: 0x009C7347
		// (set) Token: 0x06029A18 RID: 170520 RVA: 0x009C9166 File Offset: 0x009C7366
		[Nullable(1)]
		public TSoftObjectPtr<UAnimMontage> Montage
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_3, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_3, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700644A RID: 25674
		// (get) Token: 0x06029A19 RID: 170521 RVA: 0x009C918B File Offset: 0x009C738B
		// (set) Token: 0x06029A1A RID: 170522 RVA: 0x009C91AA File Offset: 0x009C73AA
		[Nullable(1)]
		public TSoftObjectPtr<UAnimMontage> AdditiveMontage
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_4, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_4, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06029A1B RID: 170523 RVA: 0x009C91CF File Offset: 0x009C73CF
		public EEnterExitPerformVehicleMontage()
		{
		}

		// Token: 0x06029A1C RID: 170524 RVA: 0x009C91D7 File Offset: 0x009C73D7
		public EEnterExitPerformVehicleMontage(bool IsEnter, TEnumAsByte<EEnterExitPerformVehicle_Gender> Gender, TEnumAsByte<EEnterExitPerformVehicle_Direction> Direction, [Nullable(1)] TSoftObjectPtr<UAnimMontage> Montage, [Nullable(1)] TSoftObjectPtr<UAnimMontage> AdditiveMontage)
		{
			this.IsEnter = IsEnter;
			this.Gender = Gender;
			this.Direction = Direction;
			this.Montage = Montage;
			this.AdditiveMontage = AdditiveMontage;
		}

		// Token: 0x06029A1D RID: 170525 RVA: 0x009C9204 File Offset: 0x009C7404
		protected override IntPtr GetUStructPtr()
		{
			return EEnterExitPerformVehicleMontage.StaticStruct();
		}

		// Token: 0x06029A1E RID: 170526 RVA: 0x009C9210 File Offset: 0x009C7410
		[NullableContext(2)]
		public EEnterExitPerformVehicleMontage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029A1F RID: 170527 RVA: 0x009C921A File Offset: 0x009C741A
		public EEnterExitPerformVehicleMontage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029A20 RID: 170528 RVA: 0x009C9225 File Offset: 0x009C7425
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new EEnterExitPerformVehicleMontage(Pointer, false, true);
		}

		// Token: 0x06029A21 RID: 170529 RVA: 0x009C922F File Offset: 0x009C742F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new EEnterExitPerformVehicleMontage(Pointer, MemoryOwner);
		}

		// Token: 0x040155D6 RID: 87510
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Character/EEnterExitPerformVehicleMontage.EEnterExitPerformVehicleMontage";

		// Token: 0x040155D7 RID: 87511
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040155D8 RID: 87512
		internal static int __PropertyOffset_0;

		// Token: 0x040155D9 RID: 87513
		internal static int __PropertyOffset_1;

		// Token: 0x040155DA RID: 87514
		internal static int __PropertyOffset_2;

		// Token: 0x040155DB RID: 87515
		internal static int __PropertyOffset_3;

		// Token: 0x040155DC RID: 87516
		internal static int __PropertyOffset_4;
	}
}
