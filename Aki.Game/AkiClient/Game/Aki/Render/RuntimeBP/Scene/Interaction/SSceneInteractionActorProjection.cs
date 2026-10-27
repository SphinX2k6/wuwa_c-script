using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x02003B44 RID: 15172
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionActorProjection.SSceneInteractionActorProjection")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SSceneInteractionActorProjection : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021941 RID: 137537 RVA: 0x008F0064 File Offset: 0x008EE264
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionActorProjection._ScriptStructPtr != 0) ? SSceneInteractionActorProjection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionActorProjection.SSceneInteractionActorProjection", ref SSceneInteractionActorProjection._ScriptStructPtr);
		}

		// Token: 0x1700374D RID: 14157
		// (get) Token: 0x06021942 RID: 137538 RVA: 0x008F0088 File Offset: 0x008EE288
		// (set) Token: 0x06021943 RID: 137539 RVA: 0x008F00CB File Offset: 0x008EE2CB
		public TArray<bool> IsProjection
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._IsProjection) == null)
				{
					result = (this._IsProjection = new TArray<bool>(base.NativePtr + (IntPtr)SSceneInteractionActorProjection.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IsProjection.CopyAssign(value);
			}
		}

		// Token: 0x1700374E RID: 14158
		// (get) Token: 0x06021944 RID: 137540 RVA: 0x008F00DC File Offset: 0x008EE2DC
		// (set) Token: 0x06021945 RID: 137541 RVA: 0x008F011F File Offset: 0x008EE31F
		public TArray<FTransform> Transform
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._Transform) == null)
				{
					result = (this._Transform = new TArray<FTransform>(base.NativePtr + (IntPtr)SSceneInteractionActorProjection.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Transform.CopyAssign(value);
			}
		}

		// Token: 0x1700374F RID: 14159
		// (get) Token: 0x06021946 RID: 137542 RVA: 0x008F012D File Offset: 0x008EE32D
		// (set) Token: 0x06021947 RID: 137543 RVA: 0x008F0141 File Offset: 0x008EE341
		[Nullable(2)]
		public unsafe ItemMaterialControllerActorData MaterialController
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ItemMaterialControllerActorData>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionActorProjection.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionActorProjection.__PropertyOffset_2, value);
			}
		}

		// Token: 0x06021948 RID: 137544 RVA: 0x008F0156 File Offset: 0x008EE356
		public SSceneInteractionActorProjection()
		{
		}

		// Token: 0x06021949 RID: 137545 RVA: 0x008F015E File Offset: 0x008EE35E
		public SSceneInteractionActorProjection(TArray<bool> IsProjection, TArray<FTransform> Transform, ItemMaterialControllerActorData MaterialController)
		{
			this.IsProjection = IsProjection;
			this.Transform = Transform;
			this.MaterialController = MaterialController;
		}

		// Token: 0x0602194A RID: 137546 RVA: 0x008F017B File Offset: 0x008EE37B
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionActorProjection.StaticStruct();
		}

		// Token: 0x0602194B RID: 137547 RVA: 0x008F0187 File Offset: 0x008EE387
		[NullableContext(2)]
		public SSceneInteractionActorProjection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602194C RID: 137548 RVA: 0x008F0191 File Offset: 0x008EE391
		public SSceneInteractionActorProjection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602194D RID: 137549 RVA: 0x008F019C File Offset: 0x008EE39C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionActorProjection(Pointer, false, true);
		}

		// Token: 0x0602194E RID: 137550 RVA: 0x008F01A6 File Offset: 0x008EE3A6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionActorProjection(Pointer, MemoryOwner);
		}

		// Token: 0x040105EC RID: 67052
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionActorProjection.SSceneInteractionActorProjection";

		// Token: 0x040105ED RID: 67053
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040105EE RID: 67054
		internal static int __PropertyOffset_0;

		// Token: 0x040105EF RID: 67055
		[Nullable(2)]
		private TArray<bool> _IsProjection;

		// Token: 0x040105F0 RID: 67056
		internal static int __PropertyOffset_1;

		// Token: 0x040105F1 RID: 67057
		[Nullable(2)]
		private TArray<FTransform> _Transform;

		// Token: 0x040105F2 RID: 67058
		internal static int __PropertyOffset_2;
	}
}
