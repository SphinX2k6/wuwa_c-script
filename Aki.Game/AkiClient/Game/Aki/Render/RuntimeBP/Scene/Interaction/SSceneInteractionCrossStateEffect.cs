using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x02003B47 RID: 15175
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionCrossStateEffect.SSceneInteractionCrossStateEffect")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class SSceneInteractionCrossStateEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602196B RID: 137579 RVA: 0x008F0421 File Offset: 0x008EE621
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionCrossStateEffect._ScriptStructPtr != 0) ? SSceneInteractionCrossStateEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionCrossStateEffect.SSceneInteractionCrossStateEffect", ref SSceneInteractionCrossStateEffect._ScriptStructPtr);
		}

		// Token: 0x17003756 RID: 14166
		// (get) Token: 0x0602196C RID: 137580 RVA: 0x008F0445 File Offset: 0x008EE645
		// (set) Token: 0x0602196D RID: 137581 RVA: 0x008F0459 File Offset: 0x008EE659
		[Nullable(2)]
		public unsafe BP_EffectActor_C Effect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_EffectActor_C>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionCrossStateEffect.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionCrossStateEffect.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17003757 RID: 14167
		// (get) Token: 0x0602196E RID: 137582 RVA: 0x008F046E File Offset: 0x008EE66E
		// (set) Token: 0x0602196F RID: 137583 RVA: 0x008F047E File Offset: 0x008EE67E
		public unsafe int EffectExtraState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionCrossStateEffect.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionCrossStateEffect.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x06021970 RID: 137584 RVA: 0x008F048F File Offset: 0x008EE68F
		public SSceneInteractionCrossStateEffect()
		{
		}

		// Token: 0x06021971 RID: 137585 RVA: 0x008F0497 File Offset: 0x008EE697
		[NullableContext(1)]
		public SSceneInteractionCrossStateEffect(BP_EffectActor_C Effect, int EffectExtraState)
		{
			this.Effect = Effect;
			this.EffectExtraState = EffectExtraState;
		}

		// Token: 0x06021972 RID: 137586 RVA: 0x008F04AD File Offset: 0x008EE6AD
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionCrossStateEffect.StaticStruct();
		}

		// Token: 0x06021973 RID: 137587 RVA: 0x008F04B9 File Offset: 0x008EE6B9
		[NullableContext(2)]
		public SSceneInteractionCrossStateEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021974 RID: 137588 RVA: 0x008F04C3 File Offset: 0x008EE6C3
		public SSceneInteractionCrossStateEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021975 RID: 137589 RVA: 0x008F04CE File Offset: 0x008EE6CE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionCrossStateEffect(Pointer, false, true);
		}

		// Token: 0x06021976 RID: 137590 RVA: 0x008F04D8 File Offset: 0x008EE6D8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionCrossStateEffect(Pointer, MemoryOwner);
		}

		// Token: 0x04010600 RID: 67072
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionCrossStateEffect.SSceneInteractionCrossStateEffect";

		// Token: 0x04010601 RID: 67073
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010602 RID: 67074
		internal static int __PropertyOffset_0;

		// Token: 0x04010603 RID: 67075
		internal static int __PropertyOffset_1;
	}
}
