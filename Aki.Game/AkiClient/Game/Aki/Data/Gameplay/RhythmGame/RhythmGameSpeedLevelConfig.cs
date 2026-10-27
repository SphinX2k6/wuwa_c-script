using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.RhythmGame
{
	// Token: 0x02003F36 RID: 16182
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/RhythmGame/RhythmGameSpeedLevelConfig.RhythmGameSpeedLevelConfig")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class RhythmGameSpeedLevelConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602928C RID: 168588 RVA: 0x009BD3BC File Offset: 0x009BB5BC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (RhythmGameSpeedLevelConfig._ScriptStructPtr != 0) ? RhythmGameSpeedLevelConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/RhythmGame/RhythmGameSpeedLevelConfig.RhythmGameSpeedLevelConfig", ref RhythmGameSpeedLevelConfig._ScriptStructPtr);
		}

		// Token: 0x170061D5 RID: 25045
		// (get) Token: 0x0602928D RID: 168589 RVA: 0x009BD3E0 File Offset: 0x009BB5E0
		// (set) Token: 0x0602928E RID: 168590 RVA: 0x009BD3F4 File Offset: 0x009BB5F4
		public unsafe FVectorDouble Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170061D6 RID: 25046
		// (get) Token: 0x0602928F RID: 168591 RVA: 0x009BD409 File Offset: 0x009BB609
		// (set) Token: 0x06029290 RID: 168592 RVA: 0x009BD41D File Offset: 0x009BB61D
		public unsafe FRotator Rot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170061D7 RID: 25047
		// (get) Token: 0x06029291 RID: 168593 RVA: 0x009BD432 File Offset: 0x009BB632
		// (set) Token: 0x06029292 RID: 168594 RVA: 0x009BD442 File Offset: 0x009BB642
		public unsafe float Fov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170061D8 RID: 25048
		// (get) Token: 0x06029293 RID: 168595 RVA: 0x009BD453 File Offset: 0x009BB653
		// (set) Token: 0x06029294 RID: 168596 RVA: 0x009BD463 File Offset: 0x009BB663
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170061D9 RID: 25049
		// (get) Token: 0x06029295 RID: 168597 RVA: 0x009BD474 File Offset: 0x009BB674
		// (set) Token: 0x06029296 RID: 168598 RVA: 0x009BD493 File Offset: 0x009BB693
		public TSoftObjectPtr<UEffectModelGroup> FireEffectDa
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_4, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)RhythmGameSpeedLevelConfig.__PropertyOffset_4, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06029297 RID: 168599 RVA: 0x009BD4B8 File Offset: 0x009BB6B8
		public RhythmGameSpeedLevelConfig()
		{
		}

		// Token: 0x06029298 RID: 168600 RVA: 0x009BD4C0 File Offset: 0x009BB6C0
		public RhythmGameSpeedLevelConfig(FVectorDouble Pos, FRotator Rot, float Fov, float Speed, TSoftObjectPtr<UEffectModelGroup> FireEffectDa)
		{
			this.Pos = Pos;
			this.Rot = Rot;
			this.Fov = Fov;
			this.Speed = Speed;
			this.FireEffectDa = FireEffectDa;
		}

		// Token: 0x06029299 RID: 168601 RVA: 0x009BD4ED File Offset: 0x009BB6ED
		protected override IntPtr GetUStructPtr()
		{
			return RhythmGameSpeedLevelConfig.StaticStruct();
		}

		// Token: 0x0602929A RID: 168602 RVA: 0x009BD4F9 File Offset: 0x009BB6F9
		[NullableContext(2)]
		public RhythmGameSpeedLevelConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602929B RID: 168603 RVA: 0x009BD503 File Offset: 0x009BB703
		public RhythmGameSpeedLevelConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602929C RID: 168604 RVA: 0x009BD50E File Offset: 0x009BB70E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new RhythmGameSpeedLevelConfig(Pointer, false, true);
		}

		// Token: 0x0602929D RID: 168605 RVA: 0x009BD518 File Offset: 0x009BB718
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new RhythmGameSpeedLevelConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04015135 RID: 86325
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/RhythmGame/RhythmGameSpeedLevelConfig.RhythmGameSpeedLevelConfig";

		// Token: 0x04015136 RID: 86326
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015137 RID: 86327
		internal static int __PropertyOffset_0;

		// Token: 0x04015138 RID: 86328
		internal static int __PropertyOffset_1;

		// Token: 0x04015139 RID: 86329
		internal static int __PropertyOffset_2;

		// Token: 0x0401513A RID: 86330
		internal static int __PropertyOffset_3;

		// Token: 0x0401513B RID: 86331
		internal static int __PropertyOffset_4;
	}
}
