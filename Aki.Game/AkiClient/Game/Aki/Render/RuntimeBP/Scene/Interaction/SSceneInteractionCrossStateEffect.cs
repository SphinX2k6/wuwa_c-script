using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x020030C1 RID: 12481
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionCrossStateEffect.SSceneInteractionCrossStateEffect")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class SSceneInteractionCrossStateEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E019 RID: 122905 RVA: 0x00908427 File Offset: 0x00906627
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionCrossStateEffect._ScriptStructPtr != 0) ? SSceneInteractionCrossStateEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionCrossStateEffect.SSceneInteractionCrossStateEffect", ref SSceneInteractionCrossStateEffect._ScriptStructPtr);
		}

		// Token: 0x17003187 RID: 12679
		// (get) Token: 0x0601E01A RID: 122906 RVA: 0x0090844B File Offset: 0x0090664B
		// (set) Token: 0x0601E01B RID: 122907 RVA: 0x0090845F File Offset: 0x0090665F
		[Nullable(2)]
		public unsafe BP_EffectActor_C Effect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_EffectActor_C>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionCrossStateEffect.__PropertyOffset_Effect);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionCrossStateEffect.__PropertyOffset_Effect, value);
			}
		}

		// Token: 0x17003188 RID: 12680
		// (get) Token: 0x0601E01C RID: 122908 RVA: 0x00908474 File Offset: 0x00906674
		// (set) Token: 0x0601E01D RID: 122909 RVA: 0x00908484 File Offset: 0x00906684
		public unsafe int EffectExtraState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionCrossStateEffect.__PropertyOffset_EffectExtraState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionCrossStateEffect.__PropertyOffset_EffectExtraState) = value;
			}
		}

		// Token: 0x0601E01E RID: 122910 RVA: 0x00908495 File Offset: 0x00906695
		public SSceneInteractionCrossStateEffect()
		{
		}

		// Token: 0x0601E01F RID: 122911 RVA: 0x0090849D File Offset: 0x0090669D
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionCrossStateEffect.StaticStruct();
		}

		// Token: 0x0601E020 RID: 122912 RVA: 0x009084A9 File Offset: 0x009066A9
		[NullableContext(2)]
		public SSceneInteractionCrossStateEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E021 RID: 122913 RVA: 0x009084B3 File Offset: 0x009066B3
		public SSceneInteractionCrossStateEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E022 RID: 122914 RVA: 0x009084BE File Offset: 0x009066BE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionCrossStateEffect(Pointer, false, true);
		}

		// Token: 0x0601E023 RID: 122915 RVA: 0x009084C8 File Offset: 0x009066C8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionCrossStateEffect(Pointer, MemoryOwner);
		}

		// Token: 0x0400FDB2 RID: 64946
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionCrossStateEffect.SSceneInteractionCrossStateEffect";

		// Token: 0x0400FDB3 RID: 64947
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FDB4 RID: 64948
		internal static int __PropertyOffset_Effect;

		// Token: 0x0400FDB5 RID: 64949
		internal static int __PropertyOffset_EffectExtraState;
	}
}
