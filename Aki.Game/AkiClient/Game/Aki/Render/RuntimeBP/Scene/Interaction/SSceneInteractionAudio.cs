using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x020030C0 RID: 12480
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionAudio.SSceneInteractionAudio")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 10)]
	public class SSceneInteractionAudio : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E00C RID: 122892 RVA: 0x0090835C File Offset: 0x0090655C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionAudio._ScriptStructPtr != 0) ? SSceneInteractionAudio._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionAudio.SSceneInteractionAudio", ref SSceneInteractionAudio._ScriptStructPtr);
		}

		// Token: 0x17003184 RID: 12676
		// (get) Token: 0x0601E00D RID: 122893 RVA: 0x00908380 File Offset: 0x00906580
		// (set) Token: 0x0601E00E RID: 122894 RVA: 0x00908394 File Offset: 0x00906594
		[Nullable(2)]
		public unsafe UAkAudioEvent AkEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionAudio.__PropertyOffset_AkEvent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionAudio.__PropertyOffset_AkEvent, value);
			}
		}

		// Token: 0x17003185 RID: 12677
		// (get) Token: 0x0601E00F RID: 122895 RVA: 0x009083A9 File Offset: 0x009065A9
		// (set) Token: 0x0601E010 RID: 122896 RVA: 0x009083B9 File Offset: 0x009065B9
		public unsafe bool IsFollow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionAudio.__PropertyOffset_IsFollow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionAudio.__PropertyOffset_IsFollow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003186 RID: 12678
		// (get) Token: 0x0601E011 RID: 122897 RVA: 0x009083CA File Offset: 0x009065CA
		// (set) Token: 0x0601E012 RID: 122898 RVA: 0x009083DA File Offset: 0x009065DA
		public unsafe bool AutoMerge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionAudio.__PropertyOffset_AutoMerge) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionAudio.__PropertyOffset_AutoMerge) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601E013 RID: 122899 RVA: 0x009083EB File Offset: 0x009065EB
		public SSceneInteractionAudio()
		{
		}

		// Token: 0x0601E014 RID: 122900 RVA: 0x009083F3 File Offset: 0x009065F3
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionAudio.StaticStruct();
		}

		// Token: 0x0601E015 RID: 122901 RVA: 0x009083FF File Offset: 0x009065FF
		[NullableContext(2)]
		public SSceneInteractionAudio(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E016 RID: 122902 RVA: 0x00908409 File Offset: 0x00906609
		public SSceneInteractionAudio(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E017 RID: 122903 RVA: 0x00908414 File Offset: 0x00906614
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionAudio(Pointer, false, true);
		}

		// Token: 0x0601E018 RID: 122904 RVA: 0x0090841E File Offset: 0x0090661E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionAudio(Pointer, MemoryOwner);
		}

		// Token: 0x0400FDAD RID: 64941
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionAudio.SSceneInteractionAudio";

		// Token: 0x0400FDAE RID: 64942
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FDAF RID: 64943
		internal static int __PropertyOffset_AkEvent;

		// Token: 0x0400FDB0 RID: 64944
		internal static int __PropertyOffset_IsFollow;

		// Token: 0x0400FDB1 RID: 64945
		internal static int __PropertyOffset_AutoMerge;
	}
}
