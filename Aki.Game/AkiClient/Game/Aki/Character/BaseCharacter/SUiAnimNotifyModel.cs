using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004339 RID: 17209
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SUiAnimNotifyModel.SUiAnimNotifyModel")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 185)]
	public class SUiAnimNotifyModel : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CA24 RID: 182820 RVA: 0x00A247FF File Offset: 0x00A229FF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SUiAnimNotifyModel._ScriptStructPtr != 0) ? SUiAnimNotifyModel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SUiAnimNotifyModel.SUiAnimNotifyModel", ref SUiAnimNotifyModel._ScriptStructPtr);
		}

		// Token: 0x1700704B RID: 28747
		// (get) Token: 0x0602CA25 RID: 182821 RVA: 0x00A24823 File Offset: 0x00A22A23
		// (set) Token: 0x0602CA26 RID: 182822 RVA: 0x00A24837 File Offset: 0x00A22A37
		public unsafe string SocketName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SUiAnimNotifyModel.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SUiAnimNotifyModel.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x1700704C RID: 28748
		// (get) Token: 0x0602CA27 RID: 182823 RVA: 0x00A2484C File Offset: 0x00A22A4C
		// (set) Token: 0x0602CA28 RID: 182824 RVA: 0x00A24860 File Offset: 0x00A22A60
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiAnimNotifyModel.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiAnimNotifyModel.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700704D RID: 28749
		// (get) Token: 0x0602CA29 RID: 182825 RVA: 0x00A24875 File Offset: 0x00A22A75
		// (set) Token: 0x0602CA2A RID: 182826 RVA: 0x00A24894 File Offset: 0x00A22A94
		public TSoftObjectPtr<USkeletalMesh> ModelSoft
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)SUiAnimNotifyModel.__PropertyOffset_2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SUiAnimNotifyModel.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700704E RID: 28750
		// (get) Token: 0x0602CA2B RID: 182827 RVA: 0x00A248B9 File Offset: 0x00A22AB9
		// (set) Token: 0x0602CA2C RID: 182828 RVA: 0x00A248C9 File Offset: 0x00A22AC9
		public unsafe int ModelIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiAnimNotifyModel.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiAnimNotifyModel.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700704F RID: 28751
		// (get) Token: 0x0602CA2D RID: 182829 RVA: 0x00A248DA File Offset: 0x00A22ADA
		// (set) Token: 0x0602CA2E RID: 182830 RVA: 0x00A248F9 File Offset: 0x00A22AF9
		public TSoftObjectPtr<PD_CharacterControllerData_C> MaterialData
		{
			get
			{
				return new TSoftObjectPtr<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)SUiAnimNotifyModel.__PropertyOffset_4, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SUiAnimNotifyModel.__PropertyOffset_4, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17007050 RID: 28752
		// (get) Token: 0x0602CA2F RID: 182831 RVA: 0x00A2491E File Offset: 0x00A22B1E
		// (set) Token: 0x0602CA30 RID: 182832 RVA: 0x00A24932 File Offset: 0x00A22B32
		public unsafe string MaterialTypeName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SUiAnimNotifyModel.__PropertyOffset_5)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SUiAnimNotifyModel.__PropertyOffset_5)), value);
			}
		}

		// Token: 0x17007051 RID: 28753
		// (get) Token: 0x0602CA31 RID: 182833 RVA: 0x00A24947 File Offset: 0x00A22B47
		// (set) Token: 0x0602CA32 RID: 182834 RVA: 0x00A2495B File Offset: 0x00A22B5B
		[Nullable(0)]
		public unsafe TEnumAsByte<EPerformanceRoleState> AnimState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SUiAnimNotifyModel.__PropertyOffset_6);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SUiAnimNotifyModel.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x0602CA33 RID: 182835 RVA: 0x00A24970 File Offset: 0x00A22B70
		public SUiAnimNotifyModel()
		{
		}

		// Token: 0x0602CA34 RID: 182836 RVA: 0x00A24978 File Offset: 0x00A22B78
		public SUiAnimNotifyModel(string SocketName, FTransform Transform, TSoftObjectPtr<USkeletalMesh> ModelSoft, int ModelIndex, TSoftObjectPtr<PD_CharacterControllerData_C> MaterialData, string MaterialTypeName, [Nullable(0)] TEnumAsByte<EPerformanceRoleState> AnimState)
		{
			this.SocketName = SocketName;
			this.Transform = Transform;
			this.ModelSoft = ModelSoft;
			this.ModelIndex = ModelIndex;
			this.MaterialData = MaterialData;
			this.MaterialTypeName = MaterialTypeName;
			this.AnimState = AnimState;
		}

		// Token: 0x0602CA35 RID: 182837 RVA: 0x00A249B5 File Offset: 0x00A22BB5
		protected override IntPtr GetUStructPtr()
		{
			return SUiAnimNotifyModel.StaticStruct();
		}

		// Token: 0x0602CA36 RID: 182838 RVA: 0x00A249C1 File Offset: 0x00A22BC1
		[NullableContext(2)]
		public SUiAnimNotifyModel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CA37 RID: 182839 RVA: 0x00A249CB File Offset: 0x00A22BCB
		public SUiAnimNotifyModel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CA38 RID: 182840 RVA: 0x00A249D6 File Offset: 0x00A22BD6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SUiAnimNotifyModel(Pointer, false, true);
		}

		// Token: 0x0602CA39 RID: 182841 RVA: 0x00A249E0 File Offset: 0x00A22BE0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SUiAnimNotifyModel(Pointer, MemoryOwner);
		}

		// Token: 0x04017872 RID: 96370
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SUiAnimNotifyModel.SUiAnimNotifyModel";

		// Token: 0x04017873 RID: 96371
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017874 RID: 96372
		internal static int __PropertyOffset_0;

		// Token: 0x04017875 RID: 96373
		internal static int __PropertyOffset_1;

		// Token: 0x04017876 RID: 96374
		internal static int __PropertyOffset_2;

		// Token: 0x04017877 RID: 96375
		internal static int __PropertyOffset_3;

		// Token: 0x04017878 RID: 96376
		internal static int __PropertyOffset_4;

		// Token: 0x04017879 RID: 96377
		internal static int __PropertyOffset_5;

		// Token: 0x0401787A RID: 96378
		internal static int __PropertyOffset_6;
	}
}
