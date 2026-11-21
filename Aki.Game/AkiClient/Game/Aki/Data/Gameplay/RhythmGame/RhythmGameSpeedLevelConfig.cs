using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.RhythmGame
{
	// Token: 0x020031E1 RID: 12769
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/RhythmGame/RhythmGameSpeedLevelConfig.RhythmGameSpeedLevelConfig")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class RhythmGameSpeedLevelConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FB96 RID: 129942 RVA: 0x009343D8 File Offset: 0x009325D8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (RhythmGameSpeedLevelConfig._ScriptStructPtr != 0) ? RhythmGameSpeedLevelConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/RhythmGame/RhythmGameSpeedLevelConfig.RhythmGameSpeedLevelConfig", ref RhythmGameSpeedLevelConfig._ScriptStructPtr);
		}

		// Token: 0x17003B21 RID: 15137
		// (get) Token: 0x0601FB97 RID: 129943 RVA: 0x009343FC File Offset: 0x009325FC
		// (set) Token: 0x0601FB98 RID: 129944 RVA: 0x00934410 File Offset: 0x00932610
		public unsafe FVectorDouble Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_Pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_Pos) = value;
			}
		}

		// Token: 0x17003B22 RID: 15138
		// (get) Token: 0x0601FB99 RID: 129945 RVA: 0x00934425 File Offset: 0x00932625
		// (set) Token: 0x0601FB9A RID: 129946 RVA: 0x00934439 File Offset: 0x00932639
		public unsafe FRotator Rot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_Rot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_Rot) = value;
			}
		}

		// Token: 0x17003B23 RID: 15139
		// (get) Token: 0x0601FB9B RID: 129947 RVA: 0x0093444E File Offset: 0x0093264E
		// (set) Token: 0x0601FB9C RID: 129948 RVA: 0x0093445E File Offset: 0x0093265E
		public unsafe float Fov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_Fov);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_Fov) = value;
			}
		}

		// Token: 0x17003B24 RID: 15140
		// (get) Token: 0x0601FB9D RID: 129949 RVA: 0x0093446F File Offset: 0x0093266F
		// (set) Token: 0x0601FB9E RID: 129950 RVA: 0x0093447F File Offset: 0x0093267F
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x17003B25 RID: 15141
		// (get) Token: 0x0601FB9F RID: 129951 RVA: 0x00934490 File Offset: 0x00932690
		// (set) Token: 0x0601FBA0 RID: 129952 RVA: 0x009344AF File Offset: 0x009326AF
		public TSoftObjectPtr<UEffectModelGroup> FireEffectDa
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_FireEffectDa, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_FireEffectDa, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0601FBA1 RID: 129953 RVA: 0x009344D4 File Offset: 0x009326D4
		public RhythmGameSpeedLevelConfig()
		{
		}

		// Token: 0x0601FBA2 RID: 129954 RVA: 0x009344DC File Offset: 0x009326DC
		protected override IntPtr GetUStructPtr()
		{
			return RhythmGameSpeedLevelConfig.StaticStruct();
		}

		// Token: 0x0601FBA3 RID: 129955 RVA: 0x009344E8 File Offset: 0x009326E8
		[NullableContext(2)]
		public RhythmGameSpeedLevelConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FBA4 RID: 129956 RVA: 0x009344F2 File Offset: 0x009326F2
		public RhythmGameSpeedLevelConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FBA5 RID: 129957 RVA: 0x009344FD File Offset: 0x009326FD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new RhythmGameSpeedLevelConfig(Pointer, false, true);
		}

		// Token: 0x0601FBA6 RID: 129958 RVA: 0x00934507 File Offset: 0x00932707
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new RhythmGameSpeedLevelConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401105E RID: 69726
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/RhythmGame/RhythmGameSpeedLevelConfig.RhythmGameSpeedLevelConfig";

		// Token: 0x0401105F RID: 69727
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011060 RID: 69728
		internal static int __PropertyOffset_Pos;

		// Token: 0x04011061 RID: 69729
		internal static int __PropertyOffset_Rot;

		// Token: 0x04011062 RID: 69730
		internal static int __PropertyOffset_Fov;

		// Token: 0x04011063 RID: 69731
		internal static int __PropertyOffset_Speed;

		// Token: 0x04011064 RID: 69732
		internal static int __PropertyOffset_FireEffectDa;
	}
}
