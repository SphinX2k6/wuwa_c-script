using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Character
{
	// Token: 0x02003231 RID: 12849
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Character/EEnterExitPerformVehicleMontage.EEnterExitPerformVehicleMontage")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class EEnterExitPerformVehicleMontage : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020139 RID: 131385 RVA: 0x0093CA45 File Offset: 0x0093AC45
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (EEnterExitPerformVehicleMontage._ScriptStructPtr != 0) ? EEnterExitPerformVehicleMontage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Character/EEnterExitPerformVehicleMontage.EEnterExitPerformVehicleMontage", ref EEnterExitPerformVehicleMontage._ScriptStructPtr);
		}

		// Token: 0x17003D27 RID: 15655
		// (get) Token: 0x0602013A RID: 131386 RVA: 0x0093CA69 File Offset: 0x0093AC69
		// (set) Token: 0x0602013B RID: 131387 RVA: 0x0093CA79 File Offset: 0x0093AC79
		public unsafe bool IsEnter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_IsEnter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_IsEnter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D28 RID: 15656
		// (get) Token: 0x0602013C RID: 131388 RVA: 0x0093CA8A File Offset: 0x0093AC8A
		// (set) Token: 0x0602013D RID: 131389 RVA: 0x0093CA9E File Offset: 0x0093AC9E
		public unsafe TEnumAsByte<EEnterExitPerformVehicle_Gender> Gender
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_Gender);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_Gender) = value;
			}
		}

		// Token: 0x17003D29 RID: 15657
		// (get) Token: 0x0602013E RID: 131390 RVA: 0x0093CAB3 File Offset: 0x0093ACB3
		// (set) Token: 0x0602013F RID: 131391 RVA: 0x0093CAC7 File Offset: 0x0093ACC7
		public unsafe TEnumAsByte<EEnterExitPerformVehicle_Direction> Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_Direction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_Direction) = value;
			}
		}

		// Token: 0x17003D2A RID: 15658
		// (get) Token: 0x06020140 RID: 131392 RVA: 0x0093CADC File Offset: 0x0093ACDC
		// (set) Token: 0x06020141 RID: 131393 RVA: 0x0093CAFB File Offset: 0x0093ACFB
		[Nullable(1)]
		public TSoftObjectPtr<UAnimMontage> Montage
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_Montage, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_Montage, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003D2B RID: 15659
		// (get) Token: 0x06020142 RID: 131394 RVA: 0x0093CB20 File Offset: 0x0093AD20
		// (set) Token: 0x06020143 RID: 131395 RVA: 0x0093CB3F File Offset: 0x0093AD3F
		[Nullable(1)]
		public TSoftObjectPtr<UAnimMontage> AdditiveMontage
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_AdditiveMontage, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)EEnterExitPerformVehicleMontage.__PropertyOffset_AdditiveMontage, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06020144 RID: 131396 RVA: 0x0093CB64 File Offset: 0x0093AD64
		public EEnterExitPerformVehicleMontage()
		{
		}

		// Token: 0x06020145 RID: 131397 RVA: 0x0093CB6C File Offset: 0x0093AD6C
		protected override IntPtr GetUStructPtr()
		{
			return EEnterExitPerformVehicleMontage.StaticStruct();
		}

		// Token: 0x06020146 RID: 131398 RVA: 0x0093CB78 File Offset: 0x0093AD78
		[NullableContext(2)]
		public EEnterExitPerformVehicleMontage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020147 RID: 131399 RVA: 0x0093CB82 File Offset: 0x0093AD82
		public EEnterExitPerformVehicleMontage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020148 RID: 131400 RVA: 0x0093CB8D File Offset: 0x0093AD8D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new EEnterExitPerformVehicleMontage(Pointer, false, true);
		}

		// Token: 0x06020149 RID: 131401 RVA: 0x0093CB97 File Offset: 0x0093AD97
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new EEnterExitPerformVehicleMontage(Pointer, MemoryOwner);
		}

		// Token: 0x040113FB RID: 70651
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Character/EEnterExitPerformVehicleMontage.EEnterExitPerformVehicleMontage";

		// Token: 0x040113FC RID: 70652
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040113FD RID: 70653
		internal static int __PropertyOffset_IsEnter;

		// Token: 0x040113FE RID: 70654
		internal static int __PropertyOffset_Gender;

		// Token: 0x040113FF RID: 70655
		internal static int __PropertyOffset_Direction;

		// Token: 0x04011400 RID: 70656
		internal static int __PropertyOffset_Montage;

		// Token: 0x04011401 RID: 70657
		internal static int __PropertyOffset_AdditiveMontage;
	}
}
