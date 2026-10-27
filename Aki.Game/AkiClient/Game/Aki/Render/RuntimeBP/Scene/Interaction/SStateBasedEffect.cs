using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.StateMachineEffect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x02003B51 RID: 15185
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SStateBasedEffect.SStateBasedEffect")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class SStateBasedEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021A33 RID: 137779 RVA: 0x008F19AB File Offset: 0x008EFBAB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SStateBasedEffect._ScriptStructPtr != 0) ? SStateBasedEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SStateBasedEffect.SStateBasedEffect", ref SStateBasedEffect._ScriptStructPtr);
		}

		// Token: 0x17003792 RID: 14226
		// (get) Token: 0x06021A34 RID: 137780 RVA: 0x008F19CF File Offset: 0x008EFBCF
		// (set) Token: 0x06021A35 RID: 137781 RVA: 0x008F19E3 File Offset: 0x008EFBE3
		[Nullable(2)]
		public unsafe BP_StateMachineEffectBase_C StateBasedEffect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_StateMachineEffectBase_C>(base.NativePtr / (IntPtr)sizeof(void*) + SStateBasedEffect.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SStateBasedEffect.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06021A36 RID: 137782 RVA: 0x008F19F8 File Offset: 0x008EFBF8
		public SStateBasedEffect()
		{
		}

		// Token: 0x06021A37 RID: 137783 RVA: 0x008F1A00 File Offset: 0x008EFC00
		[NullableContext(1)]
		public SStateBasedEffect(BP_StateMachineEffectBase_C StateBasedEffect)
		{
			this.StateBasedEffect = StateBasedEffect;
		}

		// Token: 0x06021A38 RID: 137784 RVA: 0x008F1A0F File Offset: 0x008EFC0F
		protected override IntPtr GetUStructPtr()
		{
			return SStateBasedEffect.StaticStruct();
		}

		// Token: 0x06021A39 RID: 137785 RVA: 0x008F1A1B File Offset: 0x008EFC1B
		[NullableContext(2)]
		public SStateBasedEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021A3A RID: 137786 RVA: 0x008F1A25 File Offset: 0x008EFC25
		public SStateBasedEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021A3B RID: 137787 RVA: 0x008F1A30 File Offset: 0x008EFC30
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SStateBasedEffect(Pointer, false, true);
		}

		// Token: 0x06021A3C RID: 137788 RVA: 0x008F1A3A File Offset: 0x008EFC3A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SStateBasedEffect(Pointer, MemoryOwner);
		}

		// Token: 0x04010673 RID: 67187
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SStateBasedEffect.SStateBasedEffect";

		// Token: 0x04010674 RID: 67188
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010675 RID: 67189
		internal static int __PropertyOffset_0;
	}
}
