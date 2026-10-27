using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x02003B46 RID: 15174
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionAudio.SSceneInteractionAudio")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 10)]
	public class SSceneInteractionAudio : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602195D RID: 137565 RVA: 0x008F0339 File Offset: 0x008EE539
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionAudio._ScriptStructPtr != 0) ? SSceneInteractionAudio._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionAudio.SSceneInteractionAudio", ref SSceneInteractionAudio._ScriptStructPtr);
		}

		// Token: 0x17003753 RID: 14163
		// (get) Token: 0x0602195E RID: 137566 RVA: 0x008F035D File Offset: 0x008EE55D
		// (set) Token: 0x0602195F RID: 137567 RVA: 0x008F0371 File Offset: 0x008EE571
		[Nullable(2)]
		public unsafe UAkAudioEvent AkEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionAudio.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionAudio.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17003754 RID: 14164
		// (get) Token: 0x06021960 RID: 137568 RVA: 0x008F0386 File Offset: 0x008EE586
		// (set) Token: 0x06021961 RID: 137569 RVA: 0x008F0396 File Offset: 0x008EE596
		public unsafe bool IsFollow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionAudio.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionAudio.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003755 RID: 14165
		// (get) Token: 0x06021962 RID: 137570 RVA: 0x008F03A7 File Offset: 0x008EE5A7
		// (set) Token: 0x06021963 RID: 137571 RVA: 0x008F03B7 File Offset: 0x008EE5B7
		public unsafe bool AutoMerge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionAudio.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionAudio.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021964 RID: 137572 RVA: 0x008F03C8 File Offset: 0x008EE5C8
		public SSceneInteractionAudio()
		{
		}

		// Token: 0x06021965 RID: 137573 RVA: 0x008F03D0 File Offset: 0x008EE5D0
		[NullableContext(1)]
		public SSceneInteractionAudio(UAkAudioEvent AkEvent, bool IsFollow, bool AutoMerge)
		{
			this.AkEvent = AkEvent;
			this.IsFollow = IsFollow;
			this.AutoMerge = AutoMerge;
		}

		// Token: 0x06021966 RID: 137574 RVA: 0x008F03ED File Offset: 0x008EE5ED
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionAudio.StaticStruct();
		}

		// Token: 0x06021967 RID: 137575 RVA: 0x008F03F9 File Offset: 0x008EE5F9
		[NullableContext(2)]
		public SSceneInteractionAudio(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021968 RID: 137576 RVA: 0x008F0403 File Offset: 0x008EE603
		public SSceneInteractionAudio(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021969 RID: 137577 RVA: 0x008F040E File Offset: 0x008EE60E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionAudio(Pointer, false, true);
		}

		// Token: 0x0602196A RID: 137578 RVA: 0x008F0418 File Offset: 0x008EE618
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionAudio(Pointer, MemoryOwner);
		}

		// Token: 0x040105FB RID: 67067
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionAudio.SSceneInteractionAudio";

		// Token: 0x040105FC RID: 67068
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040105FD RID: 67069
		internal static int __PropertyOffset_0;

		// Token: 0x040105FE RID: 67070
		internal static int __PropertyOffset_1;

		// Token: 0x040105FF RID: 67071
		internal static int __PropertyOffset_2;
	}
}
