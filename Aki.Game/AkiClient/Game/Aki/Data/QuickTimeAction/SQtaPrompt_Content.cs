using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003EB4 RID: 16052
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/SQtaPrompt_Content.SQtaPrompt_Content")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class SQtaPrompt_Content : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602898E RID: 166286 RVA: 0x009B018E File Offset: 0x009AE38E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaPrompt_Content._ScriptStructPtr != 0) ? SQtaPrompt_Content._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/SQtaPrompt_Content.SQtaPrompt_Content", ref SQtaPrompt_Content._ScriptStructPtr);
		}

		// Token: 0x17005EAA RID: 24234
		// (get) Token: 0x0602898F RID: 166287 RVA: 0x009B01B4 File Offset: 0x009AE3B4
		// (set) Token: 0x06028990 RID: 166288 RVA: 0x009B01F7 File Offset: 0x009AE3F7
		public TArray<long> Cue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._Cue) == null)
				{
					result = (this._Cue = new TArray<long>(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Cue.CopyAssign(value);
			}
		}

		// Token: 0x17005EAB RID: 24235
		// (get) Token: 0x06028991 RID: 166289 RVA: 0x009B0205 File Offset: 0x009AE405
		// (set) Token: 0x06028992 RID: 166290 RVA: 0x009B0224 File Offset: 0x009AE424
		public TSoftObjectPtr<EffectScreenPlayData_C> ScreenEffectType1
		{
			get
			{
				return new TSoftObjectPtr<EffectScreenPlayData_C>(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005EAC RID: 24236
		// (get) Token: 0x06028993 RID: 166291 RVA: 0x009B0249 File Offset: 0x009AE449
		// (set) Token: 0x06028994 RID: 166292 RVA: 0x009B0268 File Offset: 0x009AE468
		public TSoftObjectPtr<EffectModelPostProcess> ScreenEffectType2
		{
			get
			{
				return new TSoftObjectPtr<EffectModelPostProcess>(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005EAD RID: 24237
		// (get) Token: 0x06028995 RID: 166293 RVA: 0x009B028D File Offset: 0x009AE48D
		// (set) Token: 0x06028996 RID: 166294 RVA: 0x009B02AC File Offset: 0x009AE4AC
		public TSoftClassPtr<UMatineeCameraShake> CameraShake
		{
			get
			{
				return new TSoftClassPtr<UMatineeCameraShake>(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_3, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_3, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005EAE RID: 24238
		// (get) Token: 0x06028997 RID: 166295 RVA: 0x009B02D1 File Offset: 0x009AE4D1
		// (set) Token: 0x06028998 RID: 166296 RVA: 0x009B02F0 File Offset: 0x009AE4F0
		public TSoftObjectPtr<UKuroForceFeedbackEffect> GamepadShake
		{
			get
			{
				return new TSoftObjectPtr<UKuroForceFeedbackEffect>(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_4, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_4, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005EAF RID: 24239
		// (get) Token: 0x06028999 RID: 166297 RVA: 0x009B0315 File Offset: 0x009AE515
		// (set) Token: 0x0602899A RID: 166298 RVA: 0x009B0334 File Offset: 0x009AE534
		public TSoftObjectPtr<UAkAudioEvent> Audio
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_5, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SQtaPrompt_Content.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602899B RID: 166299 RVA: 0x009B0359 File Offset: 0x009AE559
		public SQtaPrompt_Content()
		{
		}

		// Token: 0x0602899C RID: 166300 RVA: 0x009B0361 File Offset: 0x009AE561
		public SQtaPrompt_Content(TArray<long> Cue, TSoftObjectPtr<EffectScreenPlayData_C> ScreenEffectType1, TSoftObjectPtr<EffectModelPostProcess> ScreenEffectType2, TSoftClassPtr<UMatineeCameraShake> CameraShake, TSoftObjectPtr<UKuroForceFeedbackEffect> GamepadShake, TSoftObjectPtr<UAkAudioEvent> Audio)
		{
			this.Cue = Cue;
			this.ScreenEffectType1 = ScreenEffectType1;
			this.ScreenEffectType2 = ScreenEffectType2;
			this.CameraShake = CameraShake;
			this.GamepadShake = GamepadShake;
			this.Audio = Audio;
		}

		// Token: 0x0602899D RID: 166301 RVA: 0x009B0396 File Offset: 0x009AE596
		protected override IntPtr GetUStructPtr()
		{
			return SQtaPrompt_Content.StaticStruct();
		}

		// Token: 0x0602899E RID: 166302 RVA: 0x009B03A2 File Offset: 0x009AE5A2
		[NullableContext(2)]
		public SQtaPrompt_Content(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602899F RID: 166303 RVA: 0x009B03AC File Offset: 0x009AE5AC
		public SQtaPrompt_Content(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060289A0 RID: 166304 RVA: 0x009B03B7 File Offset: 0x009AE5B7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaPrompt_Content(Pointer, false, true);
		}

		// Token: 0x060289A1 RID: 166305 RVA: 0x009B03C1 File Offset: 0x009AE5C1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaPrompt_Content(Pointer, MemoryOwner);
		}

		// Token: 0x04014B82 RID: 84866
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/SQtaPrompt_Content.SQtaPrompt_Content";

		// Token: 0x04014B83 RID: 84867
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014B84 RID: 84868
		internal static int __PropertyOffset_0;

		// Token: 0x04014B85 RID: 84869
		[Nullable(2)]
		private TArray<long> _Cue;

		// Token: 0x04014B86 RID: 84870
		internal static int __PropertyOffset_1;

		// Token: 0x04014B87 RID: 84871
		internal static int __PropertyOffset_2;

		// Token: 0x04014B88 RID: 84872
		internal static int __PropertyOffset_3;

		// Token: 0x04014B89 RID: 84873
		internal static int __PropertyOffset_4;

		// Token: 0x04014B8A RID: 84874
		internal static int __PropertyOffset_5;
	}
}
