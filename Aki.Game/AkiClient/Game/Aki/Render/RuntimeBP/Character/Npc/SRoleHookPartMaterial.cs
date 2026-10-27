using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003E08 RID: 15880
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/SRoleHookPartMaterial.SRoleHookPartMaterial")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SRoleHookPartMaterial : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027BAF RID: 162735 RVA: 0x00999DC2 File Offset: 0x00997FC2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SRoleHookPartMaterial._ScriptStructPtr != 0) ? SRoleHookPartMaterial._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/Npc/SRoleHookPartMaterial.SRoleHookPartMaterial", ref SRoleHookPartMaterial._ScriptStructPtr);
		}

		// Token: 0x170059AD RID: 22957
		// (get) Token: 0x06027BB0 RID: 162736 RVA: 0x00999DE6 File Offset: 0x00997FE6
		// (set) Token: 0x06027BB1 RID: 162737 RVA: 0x00999DF6 File Offset: 0x00997FF6
		public unsafe int SlotID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleHookPartMaterial.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleHookPartMaterial.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170059AE RID: 22958
		// (get) Token: 0x06027BB2 RID: 162738 RVA: 0x00999E07 File Offset: 0x00998007
		// (set) Token: 0x06027BB3 RID: 162739 RVA: 0x00999E1B File Offset: 0x0099801B
		[Nullable(2)]
		public unsafe UMaterialInstance Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + SRoleHookPartMaterial.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SRoleHookPartMaterial.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06027BB4 RID: 162740 RVA: 0x00999E30 File Offset: 0x00998030
		public SRoleHookPartMaterial()
		{
		}

		// Token: 0x06027BB5 RID: 162741 RVA: 0x00999E38 File Offset: 0x00998038
		[NullableContext(1)]
		public SRoleHookPartMaterial(int SlotID, UMaterialInstance Material)
		{
			this.SlotID = SlotID;
			this.Material = Material;
		}

		// Token: 0x06027BB6 RID: 162742 RVA: 0x00999E4E File Offset: 0x0099804E
		protected override IntPtr GetUStructPtr()
		{
			return SRoleHookPartMaterial.StaticStruct();
		}

		// Token: 0x06027BB7 RID: 162743 RVA: 0x00999E5A File Offset: 0x0099805A
		[NullableContext(2)]
		public SRoleHookPartMaterial(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027BB8 RID: 162744 RVA: 0x00999E64 File Offset: 0x00998064
		public SRoleHookPartMaterial(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027BB9 RID: 162745 RVA: 0x00999E6F File Offset: 0x0099806F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SRoleHookPartMaterial(Pointer, false, true);
		}

		// Token: 0x06027BBA RID: 162746 RVA: 0x00999E79 File Offset: 0x00998079
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SRoleHookPartMaterial(Pointer, MemoryOwner);
		}

		// Token: 0x040141DD RID: 82397
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/SRoleHookPartMaterial.SRoleHookPartMaterial";

		// Token: 0x040141DE RID: 82398
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040141DF RID: 82399
		internal static int __PropertyOffset_0;

		// Token: 0x040141E0 RID: 82400
		internal static int __PropertyOffset_1;
	}
}
