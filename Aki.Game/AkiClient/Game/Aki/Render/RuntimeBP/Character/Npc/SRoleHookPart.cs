using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003E07 RID: 15879
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/SRoleHookPart.SRoleHookPart")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class SRoleHookPart : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027B9F RID: 162719 RVA: 0x00999C44 File Offset: 0x00997E44
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SRoleHookPart._ScriptStructPtr != 0) ? SRoleHookPart._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/Npc/SRoleHookPart.SRoleHookPart", ref SRoleHookPart._ScriptStructPtr);
		}

		// Token: 0x170059A9 RID: 22953
		// (get) Token: 0x06027BA0 RID: 162720 RVA: 0x00999C68 File Offset: 0x00997E68
		// (set) Token: 0x06027BA1 RID: 162721 RVA: 0x00999C7C File Offset: 0x00997E7C
		[Nullable(2)]
		public unsafe USkeletalMesh Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + SRoleHookPart.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SRoleHookPart.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170059AA RID: 22954
		// (get) Token: 0x06027BA2 RID: 162722 RVA: 0x00999C91 File Offset: 0x00997E91
		// (set) Token: 0x06027BA3 RID: 162723 RVA: 0x00999CA5 File Offset: 0x00997EA5
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleHookPart.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleHookPart.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170059AB RID: 22955
		// (get) Token: 0x06027BA4 RID: 162724 RVA: 0x00999CBC File Offset: 0x00997EBC
		// (set) Token: 0x06027BA5 RID: 162725 RVA: 0x00999CFF File Offset: 0x00997EFF
		public TArray<FMorphTargetPreviewItem> MorphTargets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMorphTargetPreviewItem> result;
				if ((result = this._MorphTargets) == null)
				{
					result = (this._MorphTargets = new TArray<FMorphTargetPreviewItem>(base.NativePtr + (IntPtr)SRoleHookPart.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MorphTargets.CopyAssign(value);
			}
		}

		// Token: 0x170059AC RID: 22956
		// (get) Token: 0x06027BA6 RID: 162726 RVA: 0x00999D10 File Offset: 0x00997F10
		// (set) Token: 0x06027BA7 RID: 162727 RVA: 0x00999D53 File Offset: 0x00997F53
		public TArray<SNpcHookPartMaterial> MaterialInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPartMaterial> result;
				if ((result = this._MaterialInfos) == null)
				{
					result = (this._MaterialInfos = new TArray<SNpcHookPartMaterial>(base.NativePtr + (IntPtr)SRoleHookPart.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialInfos.CopyAssign(value);
			}
		}

		// Token: 0x06027BA8 RID: 162728 RVA: 0x00999D61 File Offset: 0x00997F61
		public SRoleHookPart()
		{
		}

		// Token: 0x06027BA9 RID: 162729 RVA: 0x00999D69 File Offset: 0x00997F69
		public SRoleHookPart(USkeletalMesh Mesh, FTransform Transform, TArray<FMorphTargetPreviewItem> MorphTargets, TArray<SNpcHookPartMaterial> MaterialInfos)
		{
			this.Mesh = Mesh;
			this.Transform = Transform;
			this.MorphTargets = MorphTargets;
			this.MaterialInfos = MaterialInfos;
		}

		// Token: 0x06027BAA RID: 162730 RVA: 0x00999D8E File Offset: 0x00997F8E
		protected override IntPtr GetUStructPtr()
		{
			return SRoleHookPart.StaticStruct();
		}

		// Token: 0x06027BAB RID: 162731 RVA: 0x00999D9A File Offset: 0x00997F9A
		[NullableContext(2)]
		public SRoleHookPart(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027BAC RID: 162732 RVA: 0x00999DA4 File Offset: 0x00997FA4
		public SRoleHookPart(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027BAD RID: 162733 RVA: 0x00999DAF File Offset: 0x00997FAF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SRoleHookPart(Pointer, false, true);
		}

		// Token: 0x06027BAE RID: 162734 RVA: 0x00999DB9 File Offset: 0x00997FB9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SRoleHookPart(Pointer, MemoryOwner);
		}

		// Token: 0x040141D5 RID: 82389
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/SRoleHookPart.SRoleHookPart";

		// Token: 0x040141D6 RID: 82390
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040141D7 RID: 82391
		internal static int __PropertyOffset_0;

		// Token: 0x040141D8 RID: 82392
		internal static int __PropertyOffset_1;

		// Token: 0x040141D9 RID: 82393
		internal static int __PropertyOffset_2;

		// Token: 0x040141DA RID: 82394
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMorphTargetPreviewItem> _MorphTargets;

		// Token: 0x040141DB RID: 82395
		internal static int __PropertyOffset_3;

		// Token: 0x040141DC RID: 82396
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPartMaterial> _MaterialInfos;
	}
}
