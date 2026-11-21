using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003121 RID: 12577
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcHookPart.SNpcHookPart")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class SNpcHookPart : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EDC8 RID: 126408 RVA: 0x0091FCFD File Offset: 0x0091DEFD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNpcHookPart._ScriptStructPtr != 0) ? SNpcHookPart._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcHookPart.SNpcHookPart", ref SNpcHookPart._ScriptStructPtr);
		}

		// Token: 0x170035F8 RID: 13816
		// (get) Token: 0x0601EDC9 RID: 126409 RVA: 0x0091FD21 File Offset: 0x0091DF21
		// (set) Token: 0x0601EDCA RID: 126410 RVA: 0x0091FD35 File Offset: 0x0091DF35
		[Nullable(2)]
		public unsafe USkeletalMesh Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + SNpcHookPart.__PropertyOffset_Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNpcHookPart.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x170035F9 RID: 13817
		// (get) Token: 0x0601EDCB RID: 126411 RVA: 0x0091FD4A File Offset: 0x0091DF4A
		// (set) Token: 0x0601EDCC RID: 126412 RVA: 0x0091FD5E File Offset: 0x0091DF5E
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNpcHookPart.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNpcHookPart.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x170035FA RID: 13818
		// (get) Token: 0x0601EDCD RID: 126413 RVA: 0x0091FD74 File Offset: 0x0091DF74
		// (set) Token: 0x0601EDCE RID: 126414 RVA: 0x0091FDB7 File Offset: 0x0091DFB7
		public TArray<FMorphTargetPreviewItem> MorphTargets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMorphTargetPreviewItem> result;
				if ((result = this._MorphTargets) == null)
				{
					result = (this._MorphTargets = new TArray<FMorphTargetPreviewItem>(base.NativePtr + (IntPtr)SNpcHookPart.__PropertyOffset_MorphTargets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MorphTargets.CopyAssign(value);
			}
		}

		// Token: 0x170035FB RID: 13819
		// (get) Token: 0x0601EDCF RID: 126415 RVA: 0x0091FDC8 File Offset: 0x0091DFC8
		// (set) Token: 0x0601EDD0 RID: 126416 RVA: 0x0091FE0B File Offset: 0x0091E00B
		public TArray<SNpcHookPartMaterial> MaterialInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPartMaterial> result;
				if ((result = this._MaterialInfos) == null)
				{
					result = (this._MaterialInfos = new TArray<SNpcHookPartMaterial>(base.NativePtr + (IntPtr)SNpcHookPart.__PropertyOffset_MaterialInfos, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialInfos.CopyAssign(value);
			}
		}

		// Token: 0x0601EDD1 RID: 126417 RVA: 0x0091FE19 File Offset: 0x0091E019
		public SNpcHookPart()
		{
		}

		// Token: 0x0601EDD2 RID: 126418 RVA: 0x0091FE21 File Offset: 0x0091E021
		protected override IntPtr GetUStructPtr()
		{
			return SNpcHookPart.StaticStruct();
		}

		// Token: 0x0601EDD3 RID: 126419 RVA: 0x0091FE2D File Offset: 0x0091E02D
		[NullableContext(2)]
		public SNpcHookPart(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EDD4 RID: 126420 RVA: 0x0091FE37 File Offset: 0x0091E037
		public SNpcHookPart(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EDD5 RID: 126421 RVA: 0x0091FE42 File Offset: 0x0091E042
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNpcHookPart(Pointer, false, true);
		}

		// Token: 0x0601EDD6 RID: 126422 RVA: 0x0091FE4C File Offset: 0x0091E04C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNpcHookPart(Pointer, MemoryOwner);
		}

		// Token: 0x0401068D RID: 67213
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcHookPart.SNpcHookPart";

		// Token: 0x0401068E RID: 67214
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401068F RID: 67215
		internal static int __PropertyOffset_Mesh;

		// Token: 0x04010690 RID: 67216
		internal static int __PropertyOffset_Transform;

		// Token: 0x04010691 RID: 67217
		internal static int __PropertyOffset_MorphTargets;

		// Token: 0x04010692 RID: 67218
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMorphTargetPreviewItem> _MorphTargets;

		// Token: 0x04010693 RID: 67219
		internal static int __PropertyOffset_MaterialInfos;

		// Token: 0x04010694 RID: 67220
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPartMaterial> _MaterialInfos;
	}
}
