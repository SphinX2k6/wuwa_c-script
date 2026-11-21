using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x0200320E RID: 12814
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SLockOnPart.SLockOnPart")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SLockOnPart : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FEEB RID: 130795 RVA: 0x009394A8 File Offset: 0x009376A8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SLockOnPart._ScriptStructPtr != 0) ? SLockOnPart._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SLockOnPart.SLockOnPart", ref SLockOnPart._ScriptStructPtr);
		}

		// Token: 0x17003C42 RID: 15426
		// (get) Token: 0x0601FEEC RID: 130796 RVA: 0x009394CC File Offset: 0x009376CC
		// (set) Token: 0x0601FEED RID: 130797 RVA: 0x009394E0 File Offset: 0x009376E0
		public unsafe string BoneName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnPart.__PropertyOffset_BoneName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnPart.__PropertyOffset_BoneName)), value);
			}
		}

		// Token: 0x17003C43 RID: 15427
		// (get) Token: 0x0601FEEE RID: 130798 RVA: 0x009394F5 File Offset: 0x009376F5
		// (set) Token: 0x0601FEEF RID: 130799 RVA: 0x00939505 File Offset: 0x00937705
		public unsafe bool SoftLockValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnPart.__PropertyOffset_SoftLockValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnPart.__PropertyOffset_SoftLockValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C44 RID: 15428
		// (get) Token: 0x0601FEF0 RID: 130800 RVA: 0x00939516 File Offset: 0x00937716
		// (set) Token: 0x0601FEF1 RID: 130801 RVA: 0x00939526 File Offset: 0x00937726
		public unsafe bool HardLockValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnPart.__PropertyOffset_HardLockValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnPart.__PropertyOffset_HardLockValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C45 RID: 15429
		// (get) Token: 0x0601FEF2 RID: 130802 RVA: 0x00939537 File Offset: 0x00937737
		// (set) Token: 0x0601FEF3 RID: 130803 RVA: 0x0093954B File Offset: 0x0093774B
		public unsafe string AimPartBoneName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnPart.__PropertyOffset_AimPartBoneName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnPart.__PropertyOffset_AimPartBoneName)), value);
			}
		}

		// Token: 0x17003C46 RID: 15430
		// (get) Token: 0x0601FEF4 RID: 130804 RVA: 0x00939560 File Offset: 0x00937760
		// (set) Token: 0x0601FEF5 RID: 130805 RVA: 0x00939574 File Offset: 0x00937774
		public unsafe string EnablePartName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnPart.__PropertyOffset_EnablePartName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnPart.__PropertyOffset_EnablePartName)), value);
			}
		}

		// Token: 0x0601FEF6 RID: 130806 RVA: 0x00939589 File Offset: 0x00937789
		public SLockOnPart()
		{
		}

		// Token: 0x0601FEF7 RID: 130807 RVA: 0x00939591 File Offset: 0x00937791
		protected override IntPtr GetUStructPtr()
		{
			return SLockOnPart.StaticStruct();
		}

		// Token: 0x0601FEF8 RID: 130808 RVA: 0x0093959D File Offset: 0x0093779D
		[NullableContext(2)]
		public SLockOnPart(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FEF9 RID: 130809 RVA: 0x009395A7 File Offset: 0x009377A7
		public SLockOnPart(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FEFA RID: 130810 RVA: 0x009395B2 File Offset: 0x009377B2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SLockOnPart(Pointer, false, true);
		}

		// Token: 0x0601FEFB RID: 130811 RVA: 0x009395BC File Offset: 0x009377BC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SLockOnPart(Pointer, MemoryOwner);
		}

		// Token: 0x04011261 RID: 70241
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SLockOnPart.SLockOnPart";

		// Token: 0x04011262 RID: 70242
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011263 RID: 70243
		internal static int __PropertyOffset_BoneName;

		// Token: 0x04011264 RID: 70244
		internal static int __PropertyOffset_SoftLockValid;

		// Token: 0x04011265 RID: 70245
		internal static int __PropertyOffset_HardLockValid;

		// Token: 0x04011266 RID: 70246
		internal static int __PropertyOffset_AimPartBoneName;

		// Token: 0x04011267 RID: 70247
		internal static int __PropertyOffset_EnablePartName;
	}
}
