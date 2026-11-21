using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x020030C8 RID: 12488
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SScenePropertyEffect.SScenePropertyEffect")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SScenePropertyEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E0AE RID: 123054 RVA: 0x0090936E File Offset: 0x0090756E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SScenePropertyEffect._ScriptStructPtr != 0) ? SScenePropertyEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SScenePropertyEffect.SScenePropertyEffect", ref SScenePropertyEffect._ScriptStructPtr);
		}

		// Token: 0x170031B9 RID: 12729
		// (get) Token: 0x0601E0AF RID: 123055 RVA: 0x00909394 File Offset: 0x00907594
		// (set) Token: 0x0601E0B0 RID: 123056 RVA: 0x009093D7 File Offset: 0x009075D7
		public SSceneInteractionMaterialController Material
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionMaterialController result;
				if ((result = this._Material) == null)
				{
					result = (this._Material = new SSceneInteractionMaterialController(base.NativePtr + (IntPtr)SScenePropertyEffect.__PropertyOffset_Material, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionMaterialController.StaticStruct(), base.NativePtr + (IntPtr)SScenePropertyEffect.__PropertyOffset_Material, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031BA RID: 12730
		// (get) Token: 0x0601E0B1 RID: 123057 RVA: 0x009093F8 File Offset: 0x009075F8
		// (set) Token: 0x0601E0B2 RID: 123058 RVA: 0x0090940C File Offset: 0x0090760C
		[Nullable(2)]
		public unsafe BP_EffectActor_C Effect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_EffectActor_C>(base.NativePtr / (IntPtr)sizeof(void*) + SScenePropertyEffect.__PropertyOffset_Effect);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SScenePropertyEffect.__PropertyOffset_Effect, value);
			}
		}

		// Token: 0x0601E0B3 RID: 123059 RVA: 0x00909421 File Offset: 0x00907621
		public SScenePropertyEffect()
		{
		}

		// Token: 0x0601E0B4 RID: 123060 RVA: 0x00909429 File Offset: 0x00907629
		protected override IntPtr GetUStructPtr()
		{
			return SScenePropertyEffect.StaticStruct();
		}

		// Token: 0x0601E0B5 RID: 123061 RVA: 0x00909435 File Offset: 0x00907635
		[NullableContext(2)]
		public SScenePropertyEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E0B6 RID: 123062 RVA: 0x0090943F File Offset: 0x0090763F
		public SScenePropertyEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E0B7 RID: 123063 RVA: 0x0090944A File Offset: 0x0090764A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SScenePropertyEffect(Pointer, false, true);
		}

		// Token: 0x0601E0B8 RID: 123064 RVA: 0x00909454 File Offset: 0x00907654
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SScenePropertyEffect(Pointer, MemoryOwner);
		}

		// Token: 0x0400FE0D RID: 65037
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SScenePropertyEffect.SScenePropertyEffect";

		// Token: 0x0400FE0E RID: 65038
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FE0F RID: 65039
		internal static int __PropertyOffset_Material;

		// Token: 0x0400FE10 RID: 65040
		[Nullable(2)]
		private SSceneInteractionMaterialController _Material;

		// Token: 0x0400FE11 RID: 65041
		internal static int __PropertyOffset_Effect;
	}
}
