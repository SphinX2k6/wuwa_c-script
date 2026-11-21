using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x020030C6 RID: 12486
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionSequence.SSceneInteractionSequence")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SSceneInteractionSequence : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E07E RID: 123006 RVA: 0x00908DD9 File Offset: 0x00906FD9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionSequence._ScriptStructPtr != 0) ? SSceneInteractionSequence._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionSequence.SSceneInteractionSequence", ref SSceneInteractionSequence._ScriptStructPtr);
		}

		// Token: 0x170031A8 RID: 12712
		// (get) Token: 0x0601E07F RID: 123007 RVA: 0x00908DFD File Offset: 0x00906FFD
		// (set) Token: 0x0601E080 RID: 123008 RVA: 0x00908E11 File Offset: 0x00907011
		[Nullable(2)]
		public unsafe ULevelSequence Sequence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequence>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionSequence.__PropertyOffset_Sequence);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionSequence.__PropertyOffset_Sequence, value);
			}
		}

		// Token: 0x170031A9 RID: 12713
		// (get) Token: 0x0601E081 RID: 123009 RVA: 0x00908E26 File Offset: 0x00907026
		// (set) Token: 0x0601E082 RID: 123010 RVA: 0x00908E36 File Offset: 0x00907036
		public unsafe bool IsLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionSequence.__PropertyOffset_IsLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionSequence.__PropertyOffset_IsLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031AA RID: 12714
		// (get) Token: 0x0601E083 RID: 123011 RVA: 0x00908E47 File Offset: 0x00907047
		// (set) Token: 0x0601E084 RID: 123012 RVA: 0x00908E57 File Offset: 0x00907057
		public unsafe bool Reverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionSequence.__PropertyOffset_Reverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionSequence.__PropertyOffset_Reverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031AB RID: 12715
		// (get) Token: 0x0601E085 RID: 123013 RVA: 0x00908E68 File Offset: 0x00907068
		// (set) Token: 0x0601E086 RID: 123014 RVA: 0x00908E78 File Offset: 0x00907078
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionSequence.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionSequence.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x0601E087 RID: 123015 RVA: 0x00908E89 File Offset: 0x00907089
		public SSceneInteractionSequence()
		{
		}

		// Token: 0x0601E088 RID: 123016 RVA: 0x00908E91 File Offset: 0x00907091
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionSequence.StaticStruct();
		}

		// Token: 0x0601E089 RID: 123017 RVA: 0x00908E9D File Offset: 0x0090709D
		[NullableContext(2)]
		public SSceneInteractionSequence(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E08A RID: 123018 RVA: 0x00908EA7 File Offset: 0x009070A7
		public SSceneInteractionSequence(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E08B RID: 123019 RVA: 0x00908EB2 File Offset: 0x009070B2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionSequence(Pointer, false, true);
		}

		// Token: 0x0601E08C RID: 123020 RVA: 0x00908EBC File Offset: 0x009070BC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionSequence(Pointer, MemoryOwner);
		}

		// Token: 0x0400FDEC RID: 65004
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionSequence.SSceneInteractionSequence";

		// Token: 0x0400FDED RID: 65005
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FDEE RID: 65006
		internal static int __PropertyOffset_Sequence;

		// Token: 0x0400FDEF RID: 65007
		internal static int __PropertyOffset_IsLoop;

		// Token: 0x0400FDF0 RID: 65008
		internal static int __PropertyOffset_Reverse;

		// Token: 0x0400FDF1 RID: 65009
		internal static int __PropertyOffset_PlayRate;
	}
}
