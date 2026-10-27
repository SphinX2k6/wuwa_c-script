using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x02004438 RID: 17464
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Audio/SFootstepAudioEventParam.SFootstepAudioEventParam")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class SFootstepAudioEventParam : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D32A RID: 185130 RVA: 0x00A35E8A File Offset: 0x00A3408A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFootstepAudioEventParam._ScriptStructPtr != 0) ? SFootstepAudioEventParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Audio/SFootstepAudioEventParam.SFootstepAudioEventParam", ref SFootstepAudioEventParam._ScriptStructPtr);
		}

		// Token: 0x1700727E RID: 29310
		// (get) Token: 0x0602D32B RID: 185131 RVA: 0x00A35EB0 File Offset: 0x00A340B0
		// (set) Token: 0x0602D32C RID: 185132 RVA: 0x00A35EF3 File Offset: 0x00A340F3
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
					result = (this._碰撞信息 = new FHitResult(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700727F RID: 29311
		// (get) Token: 0x0602D32D RID: 185133 RVA: 0x00A35F14 File Offset: 0x00A34114
		// (set) Token: 0x0602D32E RID: 185134 RVA: 0x00A35F24 File Offset: 0x00A34124
		public unsafe bool 状态_地面_Walk
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007280 RID: 29312
		// (get) Token: 0x0602D32F RID: 185135 RVA: 0x00A35F35 File Offset: 0x00A34135
		// (set) Token: 0x0602D330 RID: 185136 RVA: 0x00A35F45 File Offset: 0x00A34145
		public unsafe bool 状态_地面_Run
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007281 RID: 29313
		// (get) Token: 0x0602D331 RID: 185137 RVA: 0x00A35F56 File Offset: 0x00A34156
		// (set) Token: 0x0602D332 RID: 185138 RVA: 0x00A35F66 File Offset: 0x00A34166
		public unsafe bool 状态_地面_Sprint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007282 RID: 29314
		// (get) Token: 0x0602D333 RID: 185139 RVA: 0x00A35F77 File Offset: 0x00A34177
		// (set) Token: 0x0602D334 RID: 185140 RVA: 0x00A35F87 File Offset: 0x00A34187
		public unsafe bool 状态_跑停_WalkStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007283 RID: 29315
		// (get) Token: 0x0602D335 RID: 185141 RVA: 0x00A35F98 File Offset: 0x00A34198
		// (set) Token: 0x0602D336 RID: 185142 RVA: 0x00A35FA8 File Offset: 0x00A341A8
		public unsafe bool 状态_跑停_RunStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007284 RID: 29316
		// (get) Token: 0x0602D337 RID: 185143 RVA: 0x00A35FB9 File Offset: 0x00A341B9
		// (set) Token: 0x0602D338 RID: 185144 RVA: 0x00A35FC9 File Offset: 0x00A341C9
		public unsafe bool 状态_跑停_SprintStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007285 RID: 29317
		// (get) Token: 0x0602D339 RID: 185145 RVA: 0x00A35FDA File Offset: 0x00A341DA
		// (set) Token: 0x0602D33A RID: 185146 RVA: 0x00A35FEE File Offset: 0x00A341EE
		public unsafe FVector 缓存角色位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootstepAudioEventParam.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17007286 RID: 29318
		// (get) Token: 0x0602D33B RID: 185147 RVA: 0x00A36003 File Offset: 0x00A34203
		// (set) Token: 0x0602D33C RID: 185148 RVA: 0x00A36017 File Offset: 0x00A34217
		public unsafe UAkAudioEvent WalkAkAudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + SFootstepAudioEventParam.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SFootstepAudioEventParam.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17007287 RID: 29319
		// (get) Token: 0x0602D33D RID: 185149 RVA: 0x00A3602C File Offset: 0x00A3422C
		// (set) Token: 0x0602D33E RID: 185150 RVA: 0x00A36040 File Offset: 0x00A34240
		public unsafe UAkAudioEvent RunAkAudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + SFootstepAudioEventParam.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SFootstepAudioEventParam.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17007288 RID: 29320
		// (get) Token: 0x0602D33F RID: 185151 RVA: 0x00A36055 File Offset: 0x00A34255
		// (set) Token: 0x0602D340 RID: 185152 RVA: 0x00A36069 File Offset: 0x00A34269
		public unsafe UAkAudioEvent SprintAkAudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + SFootstepAudioEventParam.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SFootstepAudioEventParam.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17007289 RID: 29321
		// (get) Token: 0x0602D341 RID: 185153 RVA: 0x00A3607E File Offset: 0x00A3427E
		// (set) Token: 0x0602D342 RID: 185154 RVA: 0x00A36092 File Offset: 0x00A34292
		public unsafe UAkAudioEvent FallbackAkAudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + SFootstepAudioEventParam.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SFootstepAudioEventParam.__PropertyOffset_11, value);
			}
		}

		// Token: 0x0602D343 RID: 185155 RVA: 0x00A360A7 File Offset: 0x00A342A7
		public SFootstepAudioEventParam()
		{
		}

		// Token: 0x0602D344 RID: 185156 RVA: 0x00A360B0 File Offset: 0x00A342B0
		[NullableContext(1)]
		public SFootstepAudioEventParam(FHitResult 碰撞信息, bool 状态_地面_Walk, bool 状态_地面_Run, bool 状态_地面_Sprint, bool 状态_跑停_WalkStop, bool 状态_跑停_RunStop, bool 状态_跑停_SprintStop, FVector 缓存角色位置, UAkAudioEvent WalkAkAudioEvent, UAkAudioEvent RunAkAudioEvent, UAkAudioEvent SprintAkAudioEvent, UAkAudioEvent FallbackAkAudioEvent)
		{
			this.碰撞信息 = 碰撞信息;
			this.状态_地面_Walk = 状态_地面_Walk;
			this.状态_地面_Run = 状态_地面_Run;
			this.状态_地面_Sprint = 状态_地面_Sprint;
			this.状态_跑停_WalkStop = 状态_跑停_WalkStop;
			this.状态_跑停_RunStop = 状态_跑停_RunStop;
			this.状态_跑停_SprintStop = 状态_跑停_SprintStop;
			this.缓存角色位置 = 缓存角色位置;
			this.WalkAkAudioEvent = WalkAkAudioEvent;
			this.RunAkAudioEvent = RunAkAudioEvent;
			this.SprintAkAudioEvent = SprintAkAudioEvent;
			this.FallbackAkAudioEvent = FallbackAkAudioEvent;
		}

		// Token: 0x0602D345 RID: 185157 RVA: 0x00A36120 File Offset: 0x00A34320
		protected override IntPtr GetUStructPtr()
		{
			return SFootstepAudioEventParam.StaticStruct();
		}

		// Token: 0x0602D346 RID: 185158 RVA: 0x00A3612C File Offset: 0x00A3432C
		public SFootstepAudioEventParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D347 RID: 185159 RVA: 0x00A36136 File Offset: 0x00A34336
		public SFootstepAudioEventParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D348 RID: 185160 RVA: 0x00A36141 File Offset: 0x00A34341
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFootstepAudioEventParam(Pointer, false, true);
		}

		// Token: 0x0602D349 RID: 185161 RVA: 0x00A3614B File Offset: 0x00A3434B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFootstepAudioEventParam(Pointer, MemoryOwner);
		}

		// Token: 0x04018068 RID: 98408
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Audio/SFootstepAudioEventParam.SFootstepAudioEventParam";

		// Token: 0x04018069 RID: 98409
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401806A RID: 98410
		internal static int __PropertyOffset_0;

		// Token: 0x0401806B RID: 98411
		private FHitResult _碰撞信息;

		// Token: 0x0401806C RID: 98412
		internal static int __PropertyOffset_1;

		// Token: 0x0401806D RID: 98413
		internal static int __PropertyOffset_2;

		// Token: 0x0401806E RID: 98414
		internal static int __PropertyOffset_3;

		// Token: 0x0401806F RID: 98415
		internal static int __PropertyOffset_4;

		// Token: 0x04018070 RID: 98416
		internal static int __PropertyOffset_5;

		// Token: 0x04018071 RID: 98417
		internal static int __PropertyOffset_6;

		// Token: 0x04018072 RID: 98418
		internal static int __PropertyOffset_7;

		// Token: 0x04018073 RID: 98419
		internal static int __PropertyOffset_8;

		// Token: 0x04018074 RID: 98420
		internal static int __PropertyOffset_9;

		// Token: 0x04018075 RID: 98421
		internal static int __PropertyOffset_10;

		// Token: 0x04018076 RID: 98422
		internal static int __PropertyOffset_11;
	}
}
