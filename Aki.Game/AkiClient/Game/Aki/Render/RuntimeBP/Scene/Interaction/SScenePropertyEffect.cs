using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x02003B50 RID: 15184
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SScenePropertyEffect.SScenePropertyEffect")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SScenePropertyEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021A27 RID: 137767 RVA: 0x008F18A8 File Offset: 0x008EFAA8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SScenePropertyEffect._ScriptStructPtr != 0) ? SScenePropertyEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SScenePropertyEffect.SScenePropertyEffect", ref SScenePropertyEffect._ScriptStructPtr);
		}

		// Token: 0x17003790 RID: 14224
		// (get) Token: 0x06021A28 RID: 137768 RVA: 0x008F18CC File Offset: 0x008EFACC
		// (set) Token: 0x06021A29 RID: 137769 RVA: 0x008F190F File Offset: 0x008EFB0F
		public SSceneInteractionMaterialController Material
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionMaterialController result;
				if ((result = this._Material) == null)
				{
					result = (this._Material = new SSceneInteractionMaterialController(base.NativePtr + (IntPtr)SScenePropertyEffect.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionMaterialController.StaticStruct(), base.NativePtr + (IntPtr)SScenePropertyEffect.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003791 RID: 14225
		// (get) Token: 0x06021A2A RID: 137770 RVA: 0x008F1930 File Offset: 0x008EFB30
		// (set) Token: 0x06021A2B RID: 137771 RVA: 0x008F1944 File Offset: 0x008EFB44
		[Nullable(2)]
		public unsafe BP_EffectActor_C Effect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_EffectActor_C>(base.NativePtr / (IntPtr)sizeof(void*) + SScenePropertyEffect.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SScenePropertyEffect.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021A2C RID: 137772 RVA: 0x008F1959 File Offset: 0x008EFB59
		public SScenePropertyEffect()
		{
		}

		// Token: 0x06021A2D RID: 137773 RVA: 0x008F1961 File Offset: 0x008EFB61
		public SScenePropertyEffect(SSceneInteractionMaterialController Material, BP_EffectActor_C Effect)
		{
			this.Material = Material;
			this.Effect = Effect;
		}

		// Token: 0x06021A2E RID: 137774 RVA: 0x008F1977 File Offset: 0x008EFB77
		protected override IntPtr GetUStructPtr()
		{
			return SScenePropertyEffect.StaticStruct();
		}

		// Token: 0x06021A2F RID: 137775 RVA: 0x008F1983 File Offset: 0x008EFB83
		[NullableContext(2)]
		public SScenePropertyEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021A30 RID: 137776 RVA: 0x008F198D File Offset: 0x008EFB8D
		public SScenePropertyEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021A31 RID: 137777 RVA: 0x008F1998 File Offset: 0x008EFB98
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SScenePropertyEffect(Pointer, false, true);
		}

		// Token: 0x06021A32 RID: 137778 RVA: 0x008F19A2 File Offset: 0x008EFBA2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SScenePropertyEffect(Pointer, MemoryOwner);
		}

		// Token: 0x0401066E RID: 67182
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SScenePropertyEffect.SScenePropertyEffect";

		// Token: 0x0401066F RID: 67183
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010670 RID: 67184
		internal static int __PropertyOffset_0;

		// Token: 0x04010671 RID: 67185
		[Nullable(2)]
		private SSceneInteractionMaterialController _Material;

		// Token: 0x04010672 RID: 67186
		internal static int __PropertyOffset_1;
	}
}
