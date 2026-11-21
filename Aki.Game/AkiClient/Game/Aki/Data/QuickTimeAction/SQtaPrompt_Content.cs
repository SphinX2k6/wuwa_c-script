using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003181 RID: 12673
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/SQtaPrompt_Content.SQtaPrompt_Content")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class SQtaPrompt_Content : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F42E RID: 128046 RVA: 0x00929D48 File Offset: 0x00927F48
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaPrompt_Content._ScriptStructPtr != 0) ? SQtaPrompt_Content._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/SQtaPrompt_Content.SQtaPrompt_Content", ref SQtaPrompt_Content._ScriptStructPtr);
		}

		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x0601F42F RID: 128047 RVA: 0x00929D6C File Offset: 0x00927F6C
		// (set) Token: 0x0601F430 RID: 128048 RVA: 0x00929DAF File Offset: 0x00927FAF
		public TArray<long> Cue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._Cue) == null)
				{
					result = (this._Cue = new TArray<long>(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_Cue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Cue.CopyAssign(value);
			}
		}

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x0601F431 RID: 128049 RVA: 0x00929DBD File Offset: 0x00927FBD
		// (set) Token: 0x0601F432 RID: 128050 RVA: 0x00929DDC File Offset: 0x00927FDC
		public TSoftObjectPtr<EffectScreenPlayData_C> ScreenEffectType1
		{
			get
			{
				return new TSoftObjectPtr<EffectScreenPlayData_C>(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_ScreenEffectType1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_ScreenEffectType1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700385C RID: 14428
		// (get) Token: 0x0601F433 RID: 128051 RVA: 0x00929E01 File Offset: 0x00928001
		// (set) Token: 0x0601F434 RID: 128052 RVA: 0x00929E20 File Offset: 0x00928020
		public TSoftObjectPtr<EffectModelPostProcess> ScreenEffectType2
		{
			get
			{
				return new TSoftObjectPtr<EffectModelPostProcess>(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_ScreenEffectType2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_ScreenEffectType2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700385D RID: 14429
		// (get) Token: 0x0601F435 RID: 128053 RVA: 0x00929E45 File Offset: 0x00928045
		// (set) Token: 0x0601F436 RID: 128054 RVA: 0x00929E64 File Offset: 0x00928064
		public TSoftClassPtr<UMatineeCameraShake> CameraShake
		{
			get
			{
				return new TSoftClassPtr<UMatineeCameraShake>(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_CameraShake, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_CameraShake, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700385E RID: 14430
		// (get) Token: 0x0601F437 RID: 128055 RVA: 0x00929E89 File Offset: 0x00928089
		// (set) Token: 0x0601F438 RID: 128056 RVA: 0x00929EA8 File Offset: 0x009280A8
		public TSoftObjectPtr<UKuroForceFeedbackEffect> GamepadShake
		{
			get
			{
				return new TSoftObjectPtr<UKuroForceFeedbackEffect>(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_GamepadShake, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_GamepadShake, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700385F RID: 14431
		// (get) Token: 0x0601F439 RID: 128057 RVA: 0x00929ECD File Offset: 0x009280CD
		// (set) Token: 0x0601F43A RID: 128058 RVA: 0x00929EEC File Offset: 0x009280EC
		public TSoftObjectPtr<UAkAudioEvent> Audio
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_Audio, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_Audio, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0601F43B RID: 128059 RVA: 0x00929F11 File Offset: 0x00928111
		public SQtaPrompt_Content()
		{
		}

		// Token: 0x0601F43C RID: 128060 RVA: 0x00929F19 File Offset: 0x00928119
		protected override IntPtr GetUStructPtr()
		{
			return SQtaPrompt_Content.StaticStruct();
		}

		// Token: 0x0601F43D RID: 128061 RVA: 0x00929F25 File Offset: 0x00928125
		[NullableContext(2)]
		public SQtaPrompt_Content(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F43E RID: 128062 RVA: 0x00929F2F File Offset: 0x0092812F
		public SQtaPrompt_Content(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F43F RID: 128063 RVA: 0x00929F3A File Offset: 0x0092813A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaPrompt_Content(Pointer, false, true);
		}

		// Token: 0x0601F440 RID: 128064 RVA: 0x00929F44 File Offset: 0x00928144
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaPrompt_Content(Pointer, MemoryOwner);
		}

		// Token: 0x04010BAA RID: 68522
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/SQtaPrompt_Content.SQtaPrompt_Content";

		// Token: 0x04010BAB RID: 68523
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010BAC RID: 68524
		internal static int __PropertyOffset_Cue;

		// Token: 0x04010BAD RID: 68525
		[Nullable(2)]
		private TArray<long> _Cue;

		// Token: 0x04010BAE RID: 68526
		internal static int __PropertyOffset_ScreenEffectType1;

		// Token: 0x04010BAF RID: 68527
		internal static int __PropertyOffset_ScreenEffectType2;

		// Token: 0x04010BB0 RID: 68528
		internal static int __PropertyOffset_CameraShake;

		// Token: 0x04010BB1 RID: 68529
		internal static int __PropertyOffset_GamepadShake;

		// Token: 0x04010BB2 RID: 68530
		internal static int __PropertyOffset_Audio;
	}
}
