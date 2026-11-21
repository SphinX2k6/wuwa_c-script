using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.StateMachineEffect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x020030C9 RID: 12489
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SStateBasedEffect.SStateBasedEffect")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class SStateBasedEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E0B9 RID: 123065 RVA: 0x0090945D File Offset: 0x0090765D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SStateBasedEffect._ScriptStructPtr != 0) ? SStateBasedEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SStateBasedEffect.SStateBasedEffect", ref SStateBasedEffect._ScriptStructPtr);
		}

		// Token: 0x170031BB RID: 12731
		// (get) Token: 0x0601E0BA RID: 123066 RVA: 0x00909481 File Offset: 0x00907681
		// (set) Token: 0x0601E0BB RID: 123067 RVA: 0x00909495 File Offset: 0x00907695
		[Nullable(2)]
		public unsafe BP_StateMachineEffectBase_C StateBasedEffect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_StateMachineEffectBase_C>(base.NativePtr / (IntPtr)sizeof(void*) + SStateBasedEffect.__PropertyOffset_StateBasedEffect);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SStateBasedEffect.__PropertyOffset_StateBasedEffect, value);
			}
		}

		// Token: 0x0601E0BC RID: 123068 RVA: 0x009094AA File Offset: 0x009076AA
		public SStateBasedEffect()
		{
		}

		// Token: 0x0601E0BD RID: 123069 RVA: 0x009094B2 File Offset: 0x009076B2
		protected override IntPtr GetUStructPtr()
		{
			return SStateBasedEffect.StaticStruct();
		}

		// Token: 0x0601E0BE RID: 123070 RVA: 0x009094BE File Offset: 0x009076BE
		[NullableContext(2)]
		public SStateBasedEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E0BF RID: 123071 RVA: 0x009094C8 File Offset: 0x009076C8
		public SStateBasedEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E0C0 RID: 123072 RVA: 0x009094D3 File Offset: 0x009076D3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SStateBasedEffect(Pointer, false, true);
		}

		// Token: 0x0601E0C1 RID: 123073 RVA: 0x009094DD File Offset: 0x009076DD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SStateBasedEffect(Pointer, MemoryOwner);
		}

		// Token: 0x0400FE12 RID: 65042
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SStateBasedEffect.SStateBasedEffect";

		// Token: 0x0400FE13 RID: 65043
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FE14 RID: 65044
		internal static int __PropertyOffset_StateBasedEffect;
	}
}
