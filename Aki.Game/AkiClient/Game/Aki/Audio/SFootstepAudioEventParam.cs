using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x02003400 RID: 13312
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Audio/SFootstepAudioEventParam.SFootstepAudioEventParam")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class SFootstepAudioEventParam : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021C99 RID: 138393 RVA: 0x0096B1B8 File Offset: 0x009693B8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFootstepAudioEventParam._ScriptStructPtr != 0) ? SFootstepAudioEventParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Audio/SFootstepAudioEventParam.SFootstepAudioEventParam", ref SFootstepAudioEventParam._ScriptStructPtr);
		}

		// Token: 0x1700460E RID: 17934
		// (get) Token: 0x06021C9A RID: 138394 RVA: 0x0096B1DC File Offset: 0x009693DC
		// (set) Token: 0x06021C9B RID: 138395 RVA: 0x0096B21F File Offset: 0x0096941F
		[Nullable(1)]
		public FHitResult 碰撞信息
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FHitResult result;
				if ((result = this._碰撞信息) == null)
				{
					result = (this._碰撞信息 = new FHitResult(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_碰撞信息, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_碰撞信息, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700460F RID: 17935
		// (get) Token: 0x06021C9C RID: 138396 RVA: 0x0096B240 File Offset: 0x00969440
		// (set) Token: 0x06021C9D RID: 138397 RVA: 0x0096B250 File Offset: 0x00969450
		public unsafe bool 状态_地面_Walk
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_状态_地面_Walk) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_状态_地面_Walk) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004610 RID: 17936
		// (get) Token: 0x06021C9E RID: 138398 RVA: 0x0096B261 File Offset: 0x00969461
		// (set) Token: 0x06021C9F RID: 138399 RVA: 0x0096B271 File Offset: 0x00969471
		public unsafe bool 状态_地面_Run
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_状态_地面_Run) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_状态_地面_Run) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004611 RID: 17937
		// (get) Token: 0x06021CA0 RID: 138400 RVA: 0x0096B282 File Offset: 0x00969482
		// (set) Token: 0x06021CA1 RID: 138401 RVA: 0x0096B292 File Offset: 0x00969492
		public unsafe bool 状态_地面_Sprint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_状态_地面_Sprint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_状态_地面_Sprint) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004612 RID: 17938
		// (get) Token: 0x06021CA2 RID: 138402 RVA: 0x0096B2A3 File Offset: 0x009694A3
		// (set) Token: 0x06021CA3 RID: 138403 RVA: 0x0096B2B3 File Offset: 0x009694B3
		public unsafe bool 状态_跑停_WalkStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_状态_跑停_WalkStop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_状态_跑停_WalkStop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004613 RID: 17939
		// (get) Token: 0x06021CA4 RID: 138404 RVA: 0x0096B2C4 File Offset: 0x009694C4
		// (set) Token: 0x06021CA5 RID: 138405 RVA: 0x0096B2D4 File Offset: 0x009694D4
		public unsafe bool 状态_跑停_RunStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_状态_跑停_RunStop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_状态_跑停_RunStop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004614 RID: 17940
		// (get) Token: 0x06021CA6 RID: 138406 RVA: 0x0096B2E5 File Offset: 0x009694E5
		// (set) Token: 0x06021CA7 RID: 138407 RVA: 0x0096B2F5 File Offset: 0x009694F5
		public unsafe bool 状态_跑停_SprintStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_状态_跑停_SprintStop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_状态_跑停_SprintStop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004615 RID: 17941
		// (get) Token: 0x06021CA8 RID: 138408 RVA: 0x0096B306 File Offset: 0x00969506
		// (set) Token: 0x06021CA9 RID: 138409 RVA: 0x0096B31A File Offset: 0x0096951A
		public unsafe FVector 缓存角色位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_缓存角色位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_缓存角色位置) = value;
			}
		}

		// Token: 0x17004616 RID: 17942
		// (get) Token: 0x06021CAA RID: 138410 RVA: 0x0096B32F File Offset: 0x0096952F
		// (set) Token: 0x06021CAB RID: 138411 RVA: 0x0096B343 File Offset: 0x00969543
		public unsafe UAkAudioEvent WalkAkAudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + SFootstepAudioEventParam.__PropertyOffset_WalkAkAudioEvent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SFootstepAudioEventParam.__PropertyOffset_WalkAkAudioEvent, value);
			}
		}

		// Token: 0x17004617 RID: 17943
		// (get) Token: 0x06021CAC RID: 138412 RVA: 0x0096B358 File Offset: 0x00969558
		// (set) Token: 0x06021CAD RID: 138413 RVA: 0x0096B36C File Offset: 0x0096956C
		public unsafe UAkAudioEvent RunAkAudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + SFootstepAudioEventParam.__PropertyOffset_RunAkAudioEvent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SFootstepAudioEventParam.__PropertyOffset_RunAkAudioEvent, value);
			}
		}

		// Token: 0x17004618 RID: 17944
		// (get) Token: 0x06021CAE RID: 138414 RVA: 0x0096B381 File Offset: 0x00969581
		// (set) Token: 0x06021CAF RID: 138415 RVA: 0x0096B395 File Offset: 0x00969595
		public unsafe UAkAudioEvent SprintAkAudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + SFootstepAudioEventParam.__PropertyOffset_SprintAkAudioEvent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SFootstepAudioEventParam.__PropertyOffset_SprintAkAudioEvent, value);
			}
		}

		// Token: 0x17004619 RID: 17945
		// (get) Token: 0x06021CB0 RID: 138416 RVA: 0x0096B3AA File Offset: 0x009695AA
		// (set) Token: 0x06021CB1 RID: 138417 RVA: 0x0096B3BE File Offset: 0x009695BE
		public unsafe UAkAudioEvent FallbackAkAudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + SFootstepAudioEventParam.__PropertyOffset_FallbackAkAudioEvent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SFootstepAudioEventParam.__PropertyOffset_FallbackAkAudioEvent, value);
			}
		}

		// Token: 0x06021CB2 RID: 138418 RVA: 0x0096B3D3 File Offset: 0x009695D3
		public SFootstepAudioEventParam()
		{
		}

		// Token: 0x06021CB3 RID: 138419 RVA: 0x0096B3DB File Offset: 0x009695DB
		protected override IntPtr GetUStructPtr()
		{
			return SFootstepAudioEventParam.StaticStruct();
		}

		// Token: 0x06021CB4 RID: 138420 RVA: 0x0096B3E7 File Offset: 0x009695E7
		public SFootstepAudioEventParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021CB5 RID: 138421 RVA: 0x0096B3F1 File Offset: 0x009695F1
		public SFootstepAudioEventParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021CB6 RID: 138422 RVA: 0x0096B3FC File Offset: 0x009695FC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFootstepAudioEventParam(Pointer, false, true);
		}

		// Token: 0x06021CB7 RID: 138423 RVA: 0x0096B406 File Offset: 0x00969606
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFootstepAudioEventParam(Pointer, MemoryOwner);
		}

		// Token: 0x04012A15 RID: 76309
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Audio/SFootstepAudioEventParam.SFootstepAudioEventParam";

		// Token: 0x04012A16 RID: 76310
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012A17 RID: 76311
		internal static int __PropertyOffset_碰撞信息;

		// Token: 0x04012A18 RID: 76312
		private FHitResult _碰撞信息;

		// Token: 0x04012A19 RID: 76313
		internal static int __PropertyOffset_状态_地面_Walk;

		// Token: 0x04012A1A RID: 76314
		internal static int __PropertyOffset_状态_地面_Run;

		// Token: 0x04012A1B RID: 76315
		internal static int __PropertyOffset_状态_地面_Sprint;

		// Token: 0x04012A1C RID: 76316
		internal static int __PropertyOffset_状态_跑停_WalkStop;

		// Token: 0x04012A1D RID: 76317
		internal static int __PropertyOffset_状态_跑停_RunStop;

		// Token: 0x04012A1E RID: 76318
		internal static int __PropertyOffset_状态_跑停_SprintStop;

		// Token: 0x04012A1F RID: 76319
		internal static int __PropertyOffset_缓存角色位置;

		// Token: 0x04012A20 RID: 76320
		internal static int __PropertyOffset_WalkAkAudioEvent;

		// Token: 0x04012A21 RID: 76321
		internal static int __PropertyOffset_RunAkAudioEvent;

		// Token: 0x04012A22 RID: 76322
		internal static int __PropertyOffset_SprintAkAudioEvent;

		// Token: 0x04012A23 RID: 76323
		internal static int __PropertyOffset_FallbackAkAudioEvent;
	}
}
