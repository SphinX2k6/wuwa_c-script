using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020040B1 RID: 16561
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/SFootstepAkAudioEvent.SFootstepAkAudioEvent")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SFootstepAkAudioEvent : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602AC7E RID: 175230 RVA: 0x009EB35F File Offset: 0x009E955F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFootstepAkAudioEvent._ScriptStructPtr != 0) ? SFootstepAkAudioEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Role/Common/Data/Structure/SFootstepAkAudioEvent.SFootstepAkAudioEvent", ref SFootstepAkAudioEvent._ScriptStructPtr);
		}

		// Token: 0x1700697E RID: 27006
		// (get) Token: 0x0602AC7F RID: 175231 RVA: 0x009EB383 File Offset: 0x009E9583
		// (set) Token: 0x0602AC80 RID: 175232 RVA: 0x009EB397 File Offset: 0x009E9597
		public unsafe TEnumAsByte<EFootstepAkAudioEventType> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootstepAkAudioEvent.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootstepAkAudioEvent.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700697F RID: 27007
		// (get) Token: 0x0602AC81 RID: 175233 RVA: 0x009EB3AC File Offset: 0x009E95AC
		// (set) Token: 0x0602AC82 RID: 175234 RVA: 0x009EB3CB File Offset: 0x009E95CB
		[Nullable(1)]
		public TSoftObjectPtr<UAkAudioEvent> Event
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SFootstepAkAudioEvent.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SFootstepAkAudioEvent.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602AC83 RID: 175235 RVA: 0x009EB3F0 File Offset: 0x009E95F0
		public SFootstepAkAudioEvent()
		{
		}

		// Token: 0x0602AC84 RID: 175236 RVA: 0x009EB3F8 File Offset: 0x009E95F8
		public SFootstepAkAudioEvent(TEnumAsByte<EFootstepAkAudioEventType> Type, [Nullable(1)] TSoftObjectPtr<UAkAudioEvent> Event)
		{
			this.Type = Type;
			this.Event = Event;
		}

		// Token: 0x0602AC85 RID: 175237 RVA: 0x009EB40E File Offset: 0x009E960E
		protected override IntPtr GetUStructPtr()
		{
			return SFootstepAkAudioEvent.StaticStruct();
		}

		// Token: 0x0602AC86 RID: 175238 RVA: 0x009EB41A File Offset: 0x009E961A
		[NullableContext(2)]
		public SFootstepAkAudioEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602AC87 RID: 175239 RVA: 0x009EB424 File Offset: 0x009E9624
		public SFootstepAkAudioEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602AC88 RID: 175240 RVA: 0x009EB42F File Offset: 0x009E962F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFootstepAkAudioEvent(Pointer, false, true);
		}

		// Token: 0x0602AC89 RID: 175241 RVA: 0x009EB439 File Offset: 0x009E9639
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFootstepAkAudioEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04016250 RID: 90704
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/SFootstepAkAudioEvent.SFootstepAkAudioEvent";

		// Token: 0x04016251 RID: 90705
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016252 RID: 90706
		internal static int __PropertyOffset_0;

		// Token: 0x04016253 RID: 90707
		internal static int __PropertyOffset_1;
	}
}
