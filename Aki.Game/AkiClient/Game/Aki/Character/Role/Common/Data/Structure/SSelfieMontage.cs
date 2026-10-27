using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020040B2 RID: 16562
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/SSelfieMontage.SSelfieMontage")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SSelfieMontage : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602AC8A RID: 175242 RVA: 0x009EB442 File Offset: 0x009E9642
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSelfieMontage._ScriptStructPtr != 0) ? SSelfieMontage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Role/Common/Data/Structure/SSelfieMontage.SSelfieMontage", ref SSelfieMontage._ScriptStructPtr);
		}

		// Token: 0x17006980 RID: 27008
		// (get) Token: 0x0602AC8B RID: 175243 RVA: 0x009EB466 File Offset: 0x009E9666
		// (set) Token: 0x0602AC8C RID: 175244 RVA: 0x009EB476 File Offset: 0x009E9676
		public unsafe int ConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSelfieMontage.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSelfieMontage.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006981 RID: 27009
		// (get) Token: 0x0602AC8D RID: 175245 RVA: 0x009EB487 File Offset: 0x009E9687
		// (set) Token: 0x0602AC8E RID: 175246 RVA: 0x009EB49B File Offset: 0x009E969B
		public unsafe TEnumAsByte<ESelfieMontageType> MontageType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSelfieMontage.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSelfieMontage.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006982 RID: 27010
		// (get) Token: 0x0602AC8F RID: 175247 RVA: 0x009EB4B0 File Offset: 0x009E96B0
		// (set) Token: 0x0602AC90 RID: 175248 RVA: 0x009EB4CF File Offset: 0x009E96CF
		[Nullable(1)]
		public TSoftObjectPtr<UAnimMontage> MontageRef
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)SSelfieMontage.__PropertyOffset_2, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SSelfieMontage.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602AC91 RID: 175249 RVA: 0x009EB4F4 File Offset: 0x009E96F4
		public SSelfieMontage()
		{
		}

		// Token: 0x0602AC92 RID: 175250 RVA: 0x009EB4FC File Offset: 0x009E96FC
		public SSelfieMontage(int ConfigId, TEnumAsByte<ESelfieMontageType> MontageType, [Nullable(1)] TSoftObjectPtr<UAnimMontage> MontageRef)
		{
			this.ConfigId = ConfigId;
			this.MontageType = MontageType;
			this.MontageRef = MontageRef;
		}

		// Token: 0x0602AC93 RID: 175251 RVA: 0x009EB519 File Offset: 0x009E9719
		protected override IntPtr GetUStructPtr()
		{
			return SSelfieMontage.StaticStruct();
		}

		// Token: 0x0602AC94 RID: 175252 RVA: 0x009EB525 File Offset: 0x009E9725
		[NullableContext(2)]
		public SSelfieMontage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602AC95 RID: 175253 RVA: 0x009EB52F File Offset: 0x009E972F
		public SSelfieMontage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602AC96 RID: 175254 RVA: 0x009EB53A File Offset: 0x009E973A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSelfieMontage(Pointer, false, true);
		}

		// Token: 0x0602AC97 RID: 175255 RVA: 0x009EB544 File Offset: 0x009E9744
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSelfieMontage(Pointer, MemoryOwner);
		}

		// Token: 0x04016254 RID: 90708
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/SSelfieMontage.SSelfieMontage";

		// Token: 0x04016255 RID: 90709
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016256 RID: 90710
		internal static int __PropertyOffset_0;

		// Token: 0x04016257 RID: 90711
		internal static int __PropertyOffset_1;

		// Token: 0x04016258 RID: 90712
		internal static int __PropertyOffset_2;
	}
}
