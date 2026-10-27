using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F6D RID: 16237
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SLockOnPart.SLockOnPart")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SLockOnPart : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029668 RID: 169576 RVA: 0x009C3560 File Offset: 0x009C1760
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SLockOnPart._ScriptStructPtr != 0) ? SLockOnPart._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SLockOnPart.SLockOnPart", ref SLockOnPart._ScriptStructPtr);
		}

		// Token: 0x17006306 RID: 25350
		// (get) Token: 0x06029669 RID: 169577 RVA: 0x009C3584 File Offset: 0x009C1784
		// (set) Token: 0x0602966A RID: 169578 RVA: 0x009C3598 File Offset: 0x009C1798
		public unsafe string BoneName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnPart.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnPart.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006307 RID: 25351
		// (get) Token: 0x0602966B RID: 169579 RVA: 0x009C35AD File Offset: 0x009C17AD
		// (set) Token: 0x0602966C RID: 169580 RVA: 0x009C35BD File Offset: 0x009C17BD
		public unsafe bool SoftLockValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnPart.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnPart.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006308 RID: 25352
		// (get) Token: 0x0602966D RID: 169581 RVA: 0x009C35CE File Offset: 0x009C17CE
		// (set) Token: 0x0602966E RID: 169582 RVA: 0x009C35DE File Offset: 0x009C17DE
		public unsafe bool HardLockValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnPart.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnPart.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006309 RID: 25353
		// (get) Token: 0x0602966F RID: 169583 RVA: 0x009C35EF File Offset: 0x009C17EF
		// (set) Token: 0x06029670 RID: 169584 RVA: 0x009C3603 File Offset: 0x009C1803
		public unsafe string AimPartBoneName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnPart.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnPart.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x1700630A RID: 25354
		// (get) Token: 0x06029671 RID: 169585 RVA: 0x009C3618 File Offset: 0x009C1818
		// (set) Token: 0x06029672 RID: 169586 RVA: 0x009C362C File Offset: 0x009C182C
		public unsafe string EnablePartName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnPart.__PropertyOffset_4)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnPart.__PropertyOffset_4)), value);
			}
		}

		// Token: 0x06029673 RID: 169587 RVA: 0x009C3641 File Offset: 0x009C1841
		public SLockOnPart()
		{
		}

		// Token: 0x06029674 RID: 169588 RVA: 0x009C3649 File Offset: 0x009C1849
		public SLockOnPart(string BoneName, bool SoftLockValid, bool HardLockValid, string AimPartBoneName, string EnablePartName)
		{
			this.BoneName = BoneName;
			this.SoftLockValid = SoftLockValid;
			this.HardLockValid = HardLockValid;
			this.AimPartBoneName = AimPartBoneName;
			this.EnablePartName = EnablePartName;
		}

		// Token: 0x06029675 RID: 169589 RVA: 0x009C3676 File Offset: 0x009C1876
		protected override IntPtr GetUStructPtr()
		{
			return SLockOnPart.StaticStruct();
		}

		// Token: 0x06029676 RID: 169590 RVA: 0x009C3682 File Offset: 0x009C1882
		[NullableContext(2)]
		public SLockOnPart(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029677 RID: 169591 RVA: 0x009C368C File Offset: 0x009C188C
		public SLockOnPart(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029678 RID: 169592 RVA: 0x009C3697 File Offset: 0x009C1897
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SLockOnPart(Pointer, false, true);
		}

		// Token: 0x06029679 RID: 169593 RVA: 0x009C36A1 File Offset: 0x009C18A1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SLockOnPart(Pointer, MemoryOwner);
		}

		// Token: 0x0401536D RID: 86893
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SLockOnPart.SLockOnPart";

		// Token: 0x0401536E RID: 86894
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401536F RID: 86895
		internal static int __PropertyOffset_0;

		// Token: 0x04015370 RID: 86896
		internal static int __PropertyOffset_1;

		// Token: 0x04015371 RID: 86897
		internal static int __PropertyOffset_2;

		// Token: 0x04015372 RID: 86898
		internal static int __PropertyOffset_3;

		// Token: 0x04015373 RID: 86899
		internal static int __PropertyOffset_4;
	}
}
