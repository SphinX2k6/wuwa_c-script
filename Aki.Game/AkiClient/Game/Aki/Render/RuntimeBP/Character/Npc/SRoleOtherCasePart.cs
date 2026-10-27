using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003E09 RID: 15881
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/SRoleOtherCasePart.SRoleOtherCasePart")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SRoleOtherCasePart : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027BBB RID: 162747 RVA: 0x00999E82 File Offset: 0x00998082
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SRoleOtherCasePart._ScriptStructPtr != 0) ? SRoleOtherCasePart._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/Npc/SRoleOtherCasePart.SRoleOtherCasePart", ref SRoleOtherCasePart._ScriptStructPtr);
		}

		// Token: 0x170059AF RID: 22959
		// (get) Token: 0x06027BBC RID: 162748 RVA: 0x00999EA6 File Offset: 0x009980A6
		// (set) Token: 0x06027BBD RID: 162749 RVA: 0x00999EBA File Offset: 0x009980BA
		[Nullable(2)]
		public unsafe USkeletalMesh OtherCaseSkeletalMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + SRoleOtherCasePart.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SRoleOtherCasePart.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170059B0 RID: 22960
		// (get) Token: 0x06027BBE RID: 162750 RVA: 0x00999ECF File Offset: 0x009980CF
		// (set) Token: 0x06027BBF RID: 162751 RVA: 0x00999EDF File Offset: 0x009980DF
		public unsafe bool Vis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleOtherCasePart.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleOtherCasePart.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170059B1 RID: 22961
		// (get) Token: 0x06027BC0 RID: 162752 RVA: 0x00999EF0 File Offset: 0x009980F0
		// (set) Token: 0x06027BC1 RID: 162753 RVA: 0x00999F04 File Offset: 0x00998104
		public unsafe FName ParentTransformName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleOtherCasePart.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleOtherCasePart.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x06027BC2 RID: 162754 RVA: 0x00999F19 File Offset: 0x00998119
		public SRoleOtherCasePart()
		{
		}

		// Token: 0x06027BC3 RID: 162755 RVA: 0x00999F21 File Offset: 0x00998121
		[NullableContext(1)]
		public SRoleOtherCasePart(USkeletalMesh OtherCaseSkeletalMesh, bool Vis, FName ParentTransformName)
		{
			this.OtherCaseSkeletalMesh = OtherCaseSkeletalMesh;
			this.Vis = Vis;
			this.ParentTransformName = ParentTransformName;
		}

		// Token: 0x06027BC4 RID: 162756 RVA: 0x00999F3E File Offset: 0x0099813E
		protected override IntPtr GetUStructPtr()
		{
			return SRoleOtherCasePart.StaticStruct();
		}

		// Token: 0x06027BC5 RID: 162757 RVA: 0x00999F4A File Offset: 0x0099814A
		[NullableContext(2)]
		public SRoleOtherCasePart(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027BC6 RID: 162758 RVA: 0x00999F54 File Offset: 0x00998154
		public SRoleOtherCasePart(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027BC7 RID: 162759 RVA: 0x00999F5F File Offset: 0x0099815F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SRoleOtherCasePart(Pointer, false, true);
		}

		// Token: 0x06027BC8 RID: 162760 RVA: 0x00999F69 File Offset: 0x00998169
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SRoleOtherCasePart(Pointer, MemoryOwner);
		}

		// Token: 0x040141E1 RID: 82401
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/SRoleOtherCasePart.SRoleOtherCasePart";

		// Token: 0x040141E2 RID: 82402
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040141E3 RID: 82403
		internal static int __PropertyOffset_0;

		// Token: 0x040141E4 RID: 82404
		internal static int __PropertyOffset_1;

		// Token: 0x040141E5 RID: 82405
		internal static int __PropertyOffset_2;
	}
}
