using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004315 RID: 17173
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SFollowMoveInfo.SFollowMoveInfo")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class SFollowMoveInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C6D1 RID: 181969 RVA: 0x00A1F85C File Offset: 0x00A1DA5C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFollowMoveInfo._ScriptStructPtr != 0) ? SFollowMoveInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SFollowMoveInfo.SFollowMoveInfo", ref SFollowMoveInfo._ScriptStructPtr);
		}

		// Token: 0x17006F2F RID: 28463
		// (get) Token: 0x0602C6D2 RID: 181970 RVA: 0x00A1F880 File Offset: 0x00A1DA80
		// (set) Token: 0x0602C6D3 RID: 181971 RVA: 0x00A1F894 File Offset: 0x00A1DA94
		public unsafe TEnumAsByte<EFollowTargetType> FollowTargetType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006F30 RID: 28464
		// (get) Token: 0x0602C6D4 RID: 181972 RVA: 0x00A1F8A9 File Offset: 0x00A1DAA9
		// (set) Token: 0x0602C6D5 RID: 181973 RVA: 0x00A1F8BD File Offset: 0x00A1DABD
		[Nullable(1)]
		public unsafe string EntityIdBlackboardKey
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SFollowMoveInfo.__PropertyOffset_1)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SFollowMoveInfo.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006F31 RID: 28465
		// (get) Token: 0x0602C6D6 RID: 181974 RVA: 0x00A1F8D2 File Offset: 0x00A1DAD2
		// (set) Token: 0x0602C6D7 RID: 181975 RVA: 0x00A1F8E6 File Offset: 0x00A1DAE6
		public unsafe FVector Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006F32 RID: 28466
		// (get) Token: 0x0602C6D8 RID: 181976 RVA: 0x00A1F8FB File Offset: 0x00A1DAFB
		// (set) Token: 0x0602C6D9 RID: 181977 RVA: 0x00A1F90B File Offset: 0x00A1DB0B
		public unsafe int MaxMoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006F33 RID: 28467
		// (get) Token: 0x0602C6DA RID: 181978 RVA: 0x00A1F91C File Offset: 0x00A1DB1C
		// (set) Token: 0x0602C6DB RID: 181979 RVA: 0x00A1F92C File Offset: 0x00A1DB2C
		public unsafe bool KeepDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F34 RID: 28468
		// (get) Token: 0x0602C6DC RID: 181980 RVA: 0x00A1F93D File Offset: 0x00A1DB3D
		// (set) Token: 0x0602C6DD RID: 181981 RVA: 0x00A1F94D File Offset: 0x00A1DB4D
		public unsafe int DistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006F35 RID: 28469
		// (get) Token: 0x0602C6DE RID: 181982 RVA: 0x00A1F95E File Offset: 0x00A1DB5E
		// (set) Token: 0x0602C6DF RID: 181983 RVA: 0x00A1F96E File Offset: 0x00A1DB6E
		public unsafe int DistanceMaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006F36 RID: 28470
		// (get) Token: 0x0602C6E0 RID: 181984 RVA: 0x00A1F97F File Offset: 0x00A1DB7F
		// (set) Token: 0x0602C6E1 RID: 181985 RVA: 0x00A1F98F File Offset: 0x00A1DB8F
		public unsafe int DistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006F37 RID: 28471
		// (get) Token: 0x0602C6E2 RID: 181986 RVA: 0x00A1F9A0 File Offset: 0x00A1DBA0
		// (set) Token: 0x0602C6E3 RID: 181987 RVA: 0x00A1F9B0 File Offset: 0x00A1DBB0
		public unsafe int DistanceForceMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x0602C6E4 RID: 181988 RVA: 0x00A1F9C1 File Offset: 0x00A1DBC1
		public SFollowMoveInfo()
		{
		}

		// Token: 0x0602C6E5 RID: 181989 RVA: 0x00A1F9CC File Offset: 0x00A1DBCC
		public SFollowMoveInfo(TEnumAsByte<EFollowTargetType> FollowTargetType, [Nullable(1)] string EntityIdBlackboardKey, FVector Offset, int MaxMoveSpeed, bool KeepDistanceMin, int DistanceMin, int DistanceMaxSpeed, int DistanceMax, int DistanceForceMove)
		{
			this.FollowTargetType = FollowTargetType;
			this.EntityIdBlackboardKey = EntityIdBlackboardKey;
			this.Offset = Offset;
			this.MaxMoveSpeed = MaxMoveSpeed;
			this.KeepDistanceMin = KeepDistanceMin;
			this.DistanceMin = DistanceMin;
			this.DistanceMaxSpeed = DistanceMaxSpeed;
			this.DistanceMax = DistanceMax;
			this.DistanceForceMove = DistanceForceMove;
		}

		// Token: 0x0602C6E6 RID: 181990 RVA: 0x00A1FA24 File Offset: 0x00A1DC24
		protected override IntPtr GetUStructPtr()
		{
			return SFollowMoveInfo.StaticStruct();
		}

		// Token: 0x0602C6E7 RID: 181991 RVA: 0x00A1FA30 File Offset: 0x00A1DC30
		[NullableContext(2)]
		public SFollowMoveInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C6E8 RID: 181992 RVA: 0x00A1FA3A File Offset: 0x00A1DC3A
		public SFollowMoveInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C6E9 RID: 181993 RVA: 0x00A1FA45 File Offset: 0x00A1DC45
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFollowMoveInfo(Pointer, false, true);
		}

		// Token: 0x0602C6EA RID: 181994 RVA: 0x00A1FA4F File Offset: 0x00A1DC4F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFollowMoveInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040176C2 RID: 95938
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SFollowMoveInfo.SFollowMoveInfo";

		// Token: 0x040176C3 RID: 95939
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040176C4 RID: 95940
		internal static int __PropertyOffset_0;

		// Token: 0x040176C5 RID: 95941
		internal static int __PropertyOffset_1;

		// Token: 0x040176C6 RID: 95942
		internal static int __PropertyOffset_2;

		// Token: 0x040176C7 RID: 95943
		internal static int __PropertyOffset_3;

		// Token: 0x040176C8 RID: 95944
		internal static int __PropertyOffset_4;

		// Token: 0x040176C9 RID: 95945
		internal static int __PropertyOffset_5;

		// Token: 0x040176CA RID: 95946
		internal static int __PropertyOffset_6;

		// Token: 0x040176CB RID: 95947
		internal static int __PropertyOffset_7;

		// Token: 0x040176CC RID: 95948
		internal static int __PropertyOffset_8;
	}
}
