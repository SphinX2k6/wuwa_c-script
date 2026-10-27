using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003ED8 RID: 16088
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_Audio.SCommonQte_Audio")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 444)]
	public class SCommonQte_Audio : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028AE1 RID: 166625 RVA: 0x009B20CC File Offset: 0x009B02CC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_Audio._ScriptStructPtr != 0) ? SCommonQte_Audio._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_Audio.SCommonQte_Audio", ref SCommonQte_Audio._ScriptStructPtr);
		}

		// Token: 0x17005F0E RID: 24334
		// (get) Token: 0x06028AE2 RID: 166626 RVA: 0x009B20F0 File Offset: 0x009B02F0
		// (set) Token: 0x06028AE3 RID: 166627 RVA: 0x009B210F File Offset: 0x009B030F
		public TSoftObjectPtr<UAkAudioEvent> AudioEventStart
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005F0F RID: 24335
		// (get) Token: 0x06028AE4 RID: 166628 RVA: 0x009B2134 File Offset: 0x009B0334
		// (set) Token: 0x06028AE5 RID: 166629 RVA: 0x009B2153 File Offset: 0x009B0353
		public TSoftObjectPtr<UAkAudioEvent> AudioEventSuccess
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005F10 RID: 24336
		// (get) Token: 0x06028AE6 RID: 166630 RVA: 0x009B2178 File Offset: 0x009B0378
		// (set) Token: 0x06028AE7 RID: 166631 RVA: 0x009B2197 File Offset: 0x009B0397
		public TSoftObjectPtr<UAkAudioEvent> AudioEventFail
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005F11 RID: 24337
		// (get) Token: 0x06028AE8 RID: 166632 RVA: 0x009B21BC File Offset: 0x009B03BC
		// (set) Token: 0x06028AE9 RID: 166633 RVA: 0x009B21DB File Offset: 0x009B03DB
		public TSoftObjectPtr<UAkAudioEvent> AudioEventPendingSuccess
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_3, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_3, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005F12 RID: 24338
		// (get) Token: 0x06028AEA RID: 166634 RVA: 0x009B2200 File Offset: 0x009B0400
		// (set) Token: 0x06028AEB RID: 166635 RVA: 0x009B221F File Offset: 0x009B041F
		public TSoftObjectPtr<UAkAudioEvent> AudioEventResponse
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_4, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_4, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005F13 RID: 24339
		// (get) Token: 0x06028AEC RID: 166636 RVA: 0x009B2244 File Offset: 0x009B0444
		// (set) Token: 0x06028AED RID: 166637 RVA: 0x009B2263 File Offset: 0x009B0463
		public TSoftObjectPtr<UAkAudioEvent> AudioEventProgress
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_5, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005F14 RID: 24340
		// (get) Token: 0x06028AEE RID: 166638 RVA: 0x009B2288 File Offset: 0x009B0488
		// (set) Token: 0x06028AEF RID: 166639 RVA: 0x009B22A7 File Offset: 0x009B04A7
		public TSoftObjectPtr<UAkAudioEvent> AudioEventRegress
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_6, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_6, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005F15 RID: 24341
		// (get) Token: 0x06028AF0 RID: 166640 RVA: 0x009B22CC File Offset: 0x009B04CC
		// (set) Token: 0x06028AF1 RID: 166641 RVA: 0x009B22EB File Offset: 0x009B04EB
		public TSoftObjectPtr<UAkAudioEvent> AudioEventResponseEnd
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_7, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_7, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005F16 RID: 24342
		// (get) Token: 0x06028AF2 RID: 166642 RVA: 0x009B2310 File Offset: 0x009B0510
		// (set) Token: 0x06028AF3 RID: 166643 RVA: 0x009B232F File Offset: 0x009B052F
		public TSoftObjectPtr<UAkAudioEvent> AudioEventReset
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_8, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_8, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005F17 RID: 24343
		// (get) Token: 0x06028AF4 RID: 166644 RVA: 0x009B2354 File Offset: 0x009B0554
		// (set) Token: 0x06028AF5 RID: 166645 RVA: 0x009B2364 File Offset: 0x009B0564
		public unsafe float AudioEventProgressFadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005F18 RID: 24344
		// (get) Token: 0x06028AF6 RID: 166646 RVA: 0x009B2375 File Offset: 0x009B0575
		// (set) Token: 0x06028AF7 RID: 166647 RVA: 0x009B2385 File Offset: 0x009B0585
		public unsafe float AudioEventRegressFadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005F19 RID: 24345
		// (get) Token: 0x06028AF8 RID: 166648 RVA: 0x009B2396 File Offset: 0x009B0596
		// (set) Token: 0x06028AF9 RID: 166649 RVA: 0x009B23A6 File Offset: 0x009B05A6
		public unsafe float AudioEventResponseFadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x06028AFA RID: 166650 RVA: 0x009B23B7 File Offset: 0x009B05B7
		public SCommonQte_Audio()
		{
		}

		// Token: 0x06028AFB RID: 166651 RVA: 0x009B23C0 File Offset: 0x009B05C0
		public SCommonQte_Audio(TSoftObjectPtr<UAkAudioEvent> AudioEventStart, TSoftObjectPtr<UAkAudioEvent> AudioEventSuccess, TSoftObjectPtr<UAkAudioEvent> AudioEventFail, TSoftObjectPtr<UAkAudioEvent> AudioEventPendingSuccess, TSoftObjectPtr<UAkAudioEvent> AudioEventResponse, TSoftObjectPtr<UAkAudioEvent> AudioEventProgress, TSoftObjectPtr<UAkAudioEvent> AudioEventRegress, TSoftObjectPtr<UAkAudioEvent> AudioEventResponseEnd, TSoftObjectPtr<UAkAudioEvent> AudioEventReset, float AudioEventProgressFadeOutTime, float AudioEventRegressFadeOutTime, float AudioEventResponseFadeOutTime)
		{
			this.AudioEventStart = AudioEventStart;
			this.AudioEventSuccess = AudioEventSuccess;
			this.AudioEventFail = AudioEventFail;
			this.AudioEventPendingSuccess = AudioEventPendingSuccess;
			this.AudioEventResponse = AudioEventResponse;
			this.AudioEventProgress = AudioEventProgress;
			this.AudioEventRegress = AudioEventRegress;
			this.AudioEventResponseEnd = AudioEventResponseEnd;
			this.AudioEventReset = AudioEventReset;
			this.AudioEventProgressFadeOutTime = AudioEventProgressFadeOutTime;
			this.AudioEventRegressFadeOutTime = AudioEventRegressFadeOutTime;
			this.AudioEventResponseFadeOutTime = AudioEventResponseFadeOutTime;
		}

		// Token: 0x06028AFC RID: 166652 RVA: 0x009B2430 File Offset: 0x009B0630
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte_Audio.StaticStruct();
		}

		// Token: 0x06028AFD RID: 166653 RVA: 0x009B243C File Offset: 0x009B063C
		[NullableContext(2)]
		public SCommonQte_Audio(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028AFE RID: 166654 RVA: 0x009B2446 File Offset: 0x009B0646
		public SCommonQte_Audio(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028AFF RID: 166655 RVA: 0x009B2451 File Offset: 0x009B0651
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte_Audio(Pointer, false, true);
		}

		// Token: 0x06028B00 RID: 166656 RVA: 0x009B245B File Offset: 0x009B065B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte_Audio(Pointer, MemoryOwner);
		}

		// Token: 0x04014CB3 RID: 85171
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_Audio.SCommonQte_Audio";

		// Token: 0x04014CB4 RID: 85172
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014CB5 RID: 85173
		internal static int __PropertyOffset_0;

		// Token: 0x04014CB6 RID: 85174
		internal static int __PropertyOffset_1;

		// Token: 0x04014CB7 RID: 85175
		internal static int __PropertyOffset_2;

		// Token: 0x04014CB8 RID: 85176
		internal static int __PropertyOffset_3;

		// Token: 0x04014CB9 RID: 85177
		internal static int __PropertyOffset_4;

		// Token: 0x04014CBA RID: 85178
		internal static int __PropertyOffset_5;

		// Token: 0x04014CBB RID: 85179
		internal static int __PropertyOffset_6;

		// Token: 0x04014CBC RID: 85180
		internal static int __PropertyOffset_7;

		// Token: 0x04014CBD RID: 85181
		internal static int __PropertyOffset_8;

		// Token: 0x04014CBE RID: 85182
		internal static int __PropertyOffset_9;

		// Token: 0x04014CBF RID: 85183
		internal static int __PropertyOffset_10;

		// Token: 0x04014CC0 RID: 85184
		internal static int __PropertyOffset_11;
	}
}
