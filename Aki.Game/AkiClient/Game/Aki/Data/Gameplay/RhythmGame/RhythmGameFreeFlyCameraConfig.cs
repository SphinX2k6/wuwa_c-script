using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.RhythmGame
{
	// Token: 0x020031DF RID: 12767
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/RhythmGame/RhythmGameFreeFlyCameraConfig.RhythmGameFreeFlyCameraConfig")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class RhythmGameFreeFlyCameraConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FB7A RID: 129914 RVA: 0x0093418B File Offset: 0x0093238B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (RhythmGameFreeFlyCameraConfig._ScriptStructPtr != 0) ? RhythmGameFreeFlyCameraConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/RhythmGame/RhythmGameFreeFlyCameraConfig.RhythmGameFreeFlyCameraConfig", ref RhythmGameFreeFlyCameraConfig._ScriptStructPtr);
		}

		// Token: 0x17003B1A RID: 15130
		// (get) Token: 0x0601FB7B RID: 129915 RVA: 0x009341AF File Offset: 0x009323AF
		// (set) Token: 0x0601FB7C RID: 129916 RVA: 0x009341C3 File Offset: 0x009323C3
		public unsafe FVectorDouble TargetLoc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_TargetLoc);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_TargetLoc) = value;
			}
		}

		// Token: 0x17003B1B RID: 15131
		// (get) Token: 0x0601FB7D RID: 129917 RVA: 0x009341D8 File Offset: 0x009323D8
		// (set) Token: 0x0601FB7E RID: 129918 RVA: 0x009341EC File Offset: 0x009323EC
		public unsafe FRotator TargetRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_TargetRot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_TargetRot) = value;
			}
		}

		// Token: 0x17003B1C RID: 15132
		// (get) Token: 0x0601FB7F RID: 129919 RVA: 0x00934201 File Offset: 0x00932401
		// (set) Token: 0x0601FB80 RID: 129920 RVA: 0x00934211 File Offset: 0x00932411
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17003B1D RID: 15133
		// (get) Token: 0x0601FB81 RID: 129921 RVA: 0x00934222 File Offset: 0x00932422
		// (set) Token: 0x0601FB82 RID: 129922 RVA: 0x00934232 File Offset: 0x00932432
		public unsafe float ChangeInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_ChangeInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_ChangeInterval) = value;
			}
		}

		// Token: 0x17003B1E RID: 15134
		// (get) Token: 0x0601FB83 RID: 129923 RVA: 0x00934243 File Offset: 0x00932443
		// (set) Token: 0x0601FB84 RID: 129924 RVA: 0x00934253 File Offset: 0x00932453
		public unsafe float InterpDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_InterpDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_InterpDuration) = value;
			}
		}

		// Token: 0x17003B1F RID: 15135
		// (get) Token: 0x0601FB85 RID: 129925 RVA: 0x00934264 File Offset: 0x00932464
		// (set) Token: 0x0601FB86 RID: 129926 RVA: 0x00934274 File Offset: 0x00932474
		public unsafe float EnterTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_EnterTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_EnterTime) = value;
			}
		}

		// Token: 0x17003B20 RID: 15136
		// (get) Token: 0x0601FB87 RID: 129927 RVA: 0x00934285 File Offset: 0x00932485
		// (set) Token: 0x0601FB88 RID: 129928 RVA: 0x00934295 File Offset: 0x00932495
		public unsafe float ExitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_ExitTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)RhythmGameFreeFlyCameraConfig.__PropertyOffset_ExitTime) = value;
			}
		}

		// Token: 0x0601FB89 RID: 129929 RVA: 0x009342A6 File Offset: 0x009324A6
		public RhythmGameFreeFlyCameraConfig()
		{
		}

		// Token: 0x0601FB8A RID: 129930 RVA: 0x009342AE File Offset: 0x009324AE
		protected override IntPtr GetUStructPtr()
		{
			return RhythmGameFreeFlyCameraConfig.StaticStruct();
		}

		// Token: 0x0601FB8B RID: 129931 RVA: 0x009342BA File Offset: 0x009324BA
		[NullableContext(2)]
		public RhythmGameFreeFlyCameraConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FB8C RID: 129932 RVA: 0x009342C4 File Offset: 0x009324C4
		public RhythmGameFreeFlyCameraConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FB8D RID: 129933 RVA: 0x009342CF File Offset: 0x009324CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new RhythmGameFreeFlyCameraConfig(Pointer, false, true);
		}

		// Token: 0x0601FB8E RID: 129934 RVA: 0x009342D9 File Offset: 0x009324D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new RhythmGameFreeFlyCameraConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401104F RID: 69711
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/RhythmGame/RhythmGameFreeFlyCameraConfig.RhythmGameFreeFlyCameraConfig";

		// Token: 0x04011050 RID: 69712
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011051 RID: 69713
		internal static int __PropertyOffset_TargetLoc;

		// Token: 0x04011052 RID: 69714
		internal static int __PropertyOffset_TargetRot;

		// Token: 0x04011053 RID: 69715
		internal static int __PropertyOffset_Radius;

		// Token: 0x04011054 RID: 69716
		internal static int __PropertyOffset_ChangeInterval;

		// Token: 0x04011055 RID: 69717
		internal static int __PropertyOffset_InterpDuration;

		// Token: 0x04011056 RID: 69718
		internal static int __PropertyOffset_EnterTime;

		// Token: 0x04011057 RID: 69719
		internal static int __PropertyOffset_ExitTime;
	}
}
