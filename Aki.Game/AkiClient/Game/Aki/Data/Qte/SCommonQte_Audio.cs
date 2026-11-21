using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x0200319D RID: 12701
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_Audio.SCommonQte_Audio")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 444)]
	public class SCommonQte_Audio : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F511 RID: 128273 RVA: 0x0092B1A0 File Offset: 0x009293A0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_Audio._ScriptStructPtr != 0) ? SCommonQte_Audio._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_Audio.SCommonQte_Audio", ref SCommonQte_Audio._ScriptStructPtr);
		}

		// Token: 0x1700389A RID: 14490
		// (get) Token: 0x0601F512 RID: 128274 RVA: 0x0092B1C4 File Offset: 0x009293C4
		// (set) Token: 0x0601F513 RID: 128275 RVA: 0x0092B1E3 File Offset: 0x009293E3
		public TSoftObjectPtr<UAkAudioEvent> AudioEventStart
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventStart, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventStart, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700389B RID: 14491
		// (get) Token: 0x0601F514 RID: 128276 RVA: 0x0092B208 File Offset: 0x00929408
		// (set) Token: 0x0601F515 RID: 128277 RVA: 0x0092B227 File Offset: 0x00929427
		public TSoftObjectPtr<UAkAudioEvent> AudioEventSuccess
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventSuccess, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventSuccess, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700389C RID: 14492
		// (get) Token: 0x0601F516 RID: 128278 RVA: 0x0092B24C File Offset: 0x0092944C
		// (set) Token: 0x0601F517 RID: 128279 RVA: 0x0092B26B File Offset: 0x0092946B
		public TSoftObjectPtr<UAkAudioEvent> AudioEventFail
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventFail, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventFail, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700389D RID: 14493
		// (get) Token: 0x0601F518 RID: 128280 RVA: 0x0092B290 File Offset: 0x00929490
		// (set) Token: 0x0601F519 RID: 128281 RVA: 0x0092B2AF File Offset: 0x009294AF
		public TSoftObjectPtr<UAkAudioEvent> AudioEventPendingSuccess
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventPendingSuccess, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventPendingSuccess, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700389E RID: 14494
		// (get) Token: 0x0601F51A RID: 128282 RVA: 0x0092B2D4 File Offset: 0x009294D4
		// (set) Token: 0x0601F51B RID: 128283 RVA: 0x0092B2F3 File Offset: 0x009294F3
		public TSoftObjectPtr<UAkAudioEvent> AudioEventResponse
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventResponse, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventResponse, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700389F RID: 14495
		// (get) Token: 0x0601F51C RID: 128284 RVA: 0x0092B318 File Offset: 0x00929518
		// (set) Token: 0x0601F51D RID: 128285 RVA: 0x0092B337 File Offset: 0x00929537
		public TSoftObjectPtr<UAkAudioEvent> AudioEventProgress
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventProgress, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventProgress, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170038A0 RID: 14496
		// (get) Token: 0x0601F51E RID: 128286 RVA: 0x0092B35C File Offset: 0x0092955C
		// (set) Token: 0x0601F51F RID: 128287 RVA: 0x0092B37B File Offset: 0x0092957B
		public TSoftObjectPtr<UAkAudioEvent> AudioEventRegress
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventRegress, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventRegress, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170038A1 RID: 14497
		// (get) Token: 0x0601F520 RID: 128288 RVA: 0x0092B3A0 File Offset: 0x009295A0
		// (set) Token: 0x0601F521 RID: 128289 RVA: 0x0092B3BF File Offset: 0x009295BF
		public TSoftObjectPtr<UAkAudioEvent> AudioEventResponseEnd
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventResponseEnd, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventResponseEnd, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170038A2 RID: 14498
		// (get) Token: 0x0601F522 RID: 128290 RVA: 0x0092B3E4 File Offset: 0x009295E4
		// (set) Token: 0x0601F523 RID: 128291 RVA: 0x0092B403 File Offset: 0x00929603
		public TSoftObjectPtr<UAkAudioEvent> AudioEventReset
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventReset, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventReset, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170038A3 RID: 14499
		// (get) Token: 0x0601F524 RID: 128292 RVA: 0x0092B428 File Offset: 0x00929628
		// (set) Token: 0x0601F525 RID: 128293 RVA: 0x0092B438 File Offset: 0x00929638
		public unsafe float AudioEventProgressFadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventProgressFadeOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventProgressFadeOutTime) = value;
			}
		}

		// Token: 0x170038A4 RID: 14500
		// (get) Token: 0x0601F526 RID: 128294 RVA: 0x0092B449 File Offset: 0x00929649
		// (set) Token: 0x0601F527 RID: 128295 RVA: 0x0092B459 File Offset: 0x00929659
		public unsafe float AudioEventRegressFadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventRegressFadeOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventRegressFadeOutTime) = value;
			}
		}

		// Token: 0x170038A5 RID: 14501
		// (get) Token: 0x0601F528 RID: 128296 RVA: 0x0092B46A File Offset: 0x0092966A
		// (set) Token: 0x0601F529 RID: 128297 RVA: 0x0092B47A File Offset: 0x0092967A
		public unsafe float AudioEventResponseFadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventResponseFadeOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_Audio.__PropertyOffset_AudioEventResponseFadeOutTime) = value;
			}
		}

		// Token: 0x0601F52A RID: 128298 RVA: 0x0092B48B File Offset: 0x0092968B
		public SCommonQte_Audio()
		{
		}

		// Token: 0x0601F52B RID: 128299 RVA: 0x0092B493 File Offset: 0x00929693
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte_Audio.StaticStruct();
		}

		// Token: 0x0601F52C RID: 128300 RVA: 0x0092B49F File Offset: 0x0092969F
		[NullableContext(2)]
		public SCommonQte_Audio(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F52D RID: 128301 RVA: 0x0092B4A9 File Offset: 0x009296A9
		public SCommonQte_Audio(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F52E RID: 128302 RVA: 0x0092B4B4 File Offset: 0x009296B4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte_Audio(Pointer, false, true);
		}

		// Token: 0x0601F52F RID: 128303 RVA: 0x0092B4BE File Offset: 0x009296BE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte_Audio(Pointer, MemoryOwner);
		}

		// Token: 0x04010C9A RID: 68762
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_Audio.SCommonQte_Audio";

		// Token: 0x04010C9B RID: 68763
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010C9C RID: 68764
		internal static int __PropertyOffset_AudioEventStart;

		// Token: 0x04010C9D RID: 68765
		internal static int __PropertyOffset_AudioEventSuccess;

		// Token: 0x04010C9E RID: 68766
		internal static int __PropertyOffset_AudioEventFail;

		// Token: 0x04010C9F RID: 68767
		internal static int __PropertyOffset_AudioEventPendingSuccess;

		// Token: 0x04010CA0 RID: 68768
		internal static int __PropertyOffset_AudioEventResponse;

		// Token: 0x04010CA1 RID: 68769
		internal static int __PropertyOffset_AudioEventProgress;

		// Token: 0x04010CA2 RID: 68770
		internal static int __PropertyOffset_AudioEventRegress;

		// Token: 0x04010CA3 RID: 68771
		internal static int __PropertyOffset_AudioEventResponseEnd;

		// Token: 0x04010CA4 RID: 68772
		internal static int __PropertyOffset_AudioEventReset;

		// Token: 0x04010CA5 RID: 68773
		internal static int __PropertyOffset_AudioEventProgressFadeOutTime;

		// Token: 0x04010CA6 RID: 68774
		internal static int __PropertyOffset_AudioEventRegressFadeOutTime;

		// Token: 0x04010CA7 RID: 68775
		internal static int __PropertyOffset_AudioEventResponseFadeOutTime;
	}
}
