using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.RhythmGame
{
	// Token: 0x02003F34 RID: 16180
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/RhythmGame/RhythmGameFreeFlyCameraConfig.RhythmGameFreeFlyCameraConfig")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class RhythmGameFreeFlyCameraConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602926F RID: 168559 RVA: 0x009BD132 File Offset: 0x009BB332
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (RhythmGameFreeFlyCameraConfig._ScriptStructPtr != 0) ? RhythmGameFreeFlyCameraConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/RhythmGame/RhythmGameFreeFlyCameraConfig.RhythmGameFreeFlyCameraConfig", ref RhythmGameFreeFlyCameraConfig._ScriptStructPtr);
		}

		// Token: 0x170061CE RID: 25038
		// (get) Token: 0x06029270 RID: 168560 RVA: 0x009BD156 File Offset: 0x009BB356
		// (set) Token: 0x06029271 RID: 168561 RVA: 0x009BD16A File Offset: 0x009BB36A
		public unsafe FVectorDouble TargetLoc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170061CF RID: 25039
		// (get) Token: 0x06029272 RID: 168562 RVA: 0x009BD17F File Offset: 0x009BB37F
		// (set) Token: 0x06029273 RID: 168563 RVA: 0x009BD193 File Offset: 0x009BB393
		public unsafe FRotator TargetRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170061D0 RID: 25040
		// (get) Token: 0x06029274 RID: 168564 RVA: 0x009BD1A8 File Offset: 0x009BB3A8
		// (set) Token: 0x06029275 RID: 168565 RVA: 0x009BD1B8 File Offset: 0x009BB3B8
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170061D1 RID: 25041
		// (get) Token: 0x06029276 RID: 168566 RVA: 0x009BD1C9 File Offset: 0x009BB3C9
		// (set) Token: 0x06029277 RID: 168567 RVA: 0x009BD1D9 File Offset: 0x009BB3D9
		public unsafe float ChangeInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170061D2 RID: 25042
		// (get) Token: 0x06029278 RID: 168568 RVA: 0x009BD1EA File Offset: 0x009BB3EA
		// (set) Token: 0x06029279 RID: 168569 RVA: 0x009BD1FA File Offset: 0x009BB3FA
		public unsafe float InterpDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170061D3 RID: 25043
		// (get) Token: 0x0602927A RID: 168570 RVA: 0x009BD20B File Offset: 0x009BB40B
		// (set) Token: 0x0602927B RID: 168571 RVA: 0x009BD21B File Offset: 0x009BB41B
		public unsafe float EnterTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170061D4 RID: 25044
		// (get) Token: 0x0602927C RID: 168572 RVA: 0x009BD22C File Offset: 0x009BB42C
		// (set) Token: 0x0602927D RID: 168573 RVA: 0x009BD23C File Offset: 0x009BB43C
		public unsafe float ExitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x0602927E RID: 168574 RVA: 0x009BD24D File Offset: 0x009BB44D
		public RhythmGameFreeFlyCameraConfig()
		{
		}

		// Token: 0x0602927F RID: 168575 RVA: 0x009BD255 File Offset: 0x009BB455
		public RhythmGameFreeFlyCameraConfig(FVectorDouble TargetLoc, FRotator TargetRot, float Radius, float ChangeInterval, float InterpDuration, float EnterTime, float ExitTime)
		{
			this.TargetLoc = TargetLoc;
			this.TargetRot = TargetRot;
			this.Radius = Radius;
			this.ChangeInterval = ChangeInterval;
			this.InterpDuration = InterpDuration;
			this.EnterTime = EnterTime;
			this.ExitTime = ExitTime;
		}

		// Token: 0x06029280 RID: 168576 RVA: 0x009BD292 File Offset: 0x009BB492
		protected override IntPtr GetUStructPtr()
		{
			return RhythmGameFreeFlyCameraConfig.StaticStruct();
		}

		// Token: 0x06029281 RID: 168577 RVA: 0x009BD29E File Offset: 0x009BB49E
		[NullableContext(2)]
		public RhythmGameFreeFlyCameraConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029282 RID: 168578 RVA: 0x009BD2A8 File Offset: 0x009BB4A8
		public RhythmGameFreeFlyCameraConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029283 RID: 168579 RVA: 0x009BD2B3 File Offset: 0x009BB4B3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new RhythmGameFreeFlyCameraConfig(Pointer, false, true);
		}

		// Token: 0x06029284 RID: 168580 RVA: 0x009BD2BD File Offset: 0x009BB4BD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new RhythmGameFreeFlyCameraConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04015126 RID: 86310
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/RhythmGame/RhythmGameFreeFlyCameraConfig.RhythmGameFreeFlyCameraConfig";

		// Token: 0x04015127 RID: 86311
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015128 RID: 86312
		internal static int __PropertyOffset_0;

		// Token: 0x04015129 RID: 86313
		internal static int __PropertyOffset_1;

		// Token: 0x0401512A RID: 86314
		internal static int __PropertyOffset_2;

		// Token: 0x0401512B RID: 86315
		internal static int __PropertyOffset_3;

		// Token: 0x0401512C RID: 86316
		internal static int __PropertyOffset_4;

		// Token: 0x0401512D RID: 86317
		internal static int __PropertyOffset_5;

		// Token: 0x0401512E RID: 86318
		internal static int __PropertyOffset_6;
	}
}
