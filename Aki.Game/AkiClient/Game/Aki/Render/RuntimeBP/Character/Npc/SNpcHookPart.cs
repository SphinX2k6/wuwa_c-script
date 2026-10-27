using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003E04 RID: 15876
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcHookPart.SNpcHookPart")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class SNpcHookPart : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027B79 RID: 162681 RVA: 0x00999943 File Offset: 0x00997B43
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNpcHookPart._ScriptStructPtr != 0) ? SNpcHookPart._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcHookPart.SNpcHookPart", ref SNpcHookPart._ScriptStructPtr);
		}

		// Token: 0x170059A2 RID: 22946
		// (get) Token: 0x06027B7A RID: 162682 RVA: 0x00999967 File Offset: 0x00997B67
		// (set) Token: 0x06027B7B RID: 162683 RVA: 0x0099997B File Offset: 0x00997B7B
		[Nullable(2)]
		public unsafe USkeletalMesh Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + SNpcHookPart.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNpcHookPart.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170059A3 RID: 22947
		// (get) Token: 0x06027B7C RID: 162684 RVA: 0x00999990 File Offset: 0x00997B90
		// (set) Token: 0x06027B7D RID: 162685 RVA: 0x009999A4 File Offset: 0x00997BA4
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNpcHookPart.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNpcHookPart.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170059A4 RID: 22948
		// (get) Token: 0x06027B7E RID: 162686 RVA: 0x009999BC File Offset: 0x00997BBC
		// (set) Token: 0x06027B7F RID: 162687 RVA: 0x009999FF File Offset: 0x00997BFF
		public TArray<FMorphTargetPreviewItem> MorphTargets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMorphTargetPreviewItem> result;
				if ((result = this._MorphTargets) == null)
				{
					result = (this._MorphTargets = new TArray<FMorphTargetPreviewItem>(base.NativePtr + (IntPtr)SNpcHookPart.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MorphTargets.CopyAssign(value);
			}
		}

		// Token: 0x170059A5 RID: 22949
		// (get) Token: 0x06027B80 RID: 162688 RVA: 0x00999A10 File Offset: 0x00997C10
		// (set) Token: 0x06027B81 RID: 162689 RVA: 0x00999A53 File Offset: 0x00997C53
		public TArray<SNpcHookPartMaterial> MaterialInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPartMaterial> result;
				if ((result = this._MaterialInfos) == null)
				{
					result = (this._MaterialInfos = new TArray<SNpcHookPartMaterial>(base.NativePtr + (IntPtr)SNpcHookPart.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialInfos.CopyAssign(value);
			}
		}

		// Token: 0x06027B82 RID: 162690 RVA: 0x00999A61 File Offset: 0x00997C61
		public SNpcHookPart()
		{
		}

		// Token: 0x06027B83 RID: 162691 RVA: 0x00999A69 File Offset: 0x00997C69
		public SNpcHookPart(USkeletalMesh Mesh, FTransform Transform, TArray<FMorphTargetPreviewItem> MorphTargets, TArray<SNpcHookPartMaterial> MaterialInfos)
		{
			this.Mesh = Mesh;
			this.Transform = Transform;
			this.MorphTargets = MorphTargets;
			this.MaterialInfos = MaterialInfos;
		}

		// Token: 0x06027B84 RID: 162692 RVA: 0x00999A8E File Offset: 0x00997C8E
		protected override IntPtr GetUStructPtr()
		{
			return SNpcHookPart.StaticStruct();
		}

		// Token: 0x06027B85 RID: 162693 RVA: 0x00999A9A File Offset: 0x00997C9A
		[NullableContext(2)]
		public SNpcHookPart(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027B86 RID: 162694 RVA: 0x00999AA4 File Offset: 0x00997CA4
		public SNpcHookPart(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027B87 RID: 162695 RVA: 0x00999AAF File Offset: 0x00997CAF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNpcHookPart(Pointer, false, true);
		}

		// Token: 0x06027B88 RID: 162696 RVA: 0x00999AB9 File Offset: 0x00997CB9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNpcHookPart(Pointer, MemoryOwner);
		}

		// Token: 0x040141C5 RID: 82373
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcHookPart.SNpcHookPart";

		// Token: 0x040141C6 RID: 82374
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040141C7 RID: 82375
		internal static int __PropertyOffset_0;

		// Token: 0x040141C8 RID: 82376
		internal static int __PropertyOffset_1;

		// Token: 0x040141C9 RID: 82377
		internal static int __PropertyOffset_2;

		// Token: 0x040141CA RID: 82378
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMorphTargetPreviewItem> _MorphTargets;

		// Token: 0x040141CB RID: 82379
		internal static int __PropertyOffset_3;

		// Token: 0x040141CC RID: 82380
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPartMaterial> _MaterialInfos;
	}
}
