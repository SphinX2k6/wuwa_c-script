using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003123 RID: 12579
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcSetupPartInfo.SNpcSetupPartInfo")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SNpcSetupPartInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EDE2 RID: 126434 RVA: 0x0091FEFF File Offset: 0x0091E0FF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNpcSetupPartInfo._ScriptStructPtr != 0) ? SNpcSetupPartInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcSetupPartInfo.SNpcSetupPartInfo", ref SNpcSetupPartInfo._ScriptStructPtr);
		}

		// Token: 0x170035FE RID: 13822
		// (get) Token: 0x0601EDE3 RID: 126435 RVA: 0x0091FF24 File Offset: 0x0091E124
		// (set) Token: 0x0601EDE4 RID: 126436 RVA: 0x0091FF67 File Offset: 0x0091E167
		public TArray<USkeletalMeshComponent> SkeletalMeshComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USkeletalMeshComponent> result;
				if ((result = this._SkeletalMeshComponents) == null)
				{
					result = (this._SkeletalMeshComponents = new TArray<USkeletalMeshComponent>(base.NativePtr + (IntPtr)SNpcSetupPartInfo.__PropertyOffset_SkeletalMeshComponents, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkeletalMeshComponents.CopyAssign(value);
			}
		}

		// Token: 0x0601EDE5 RID: 126437 RVA: 0x0091FF75 File Offset: 0x0091E175
		public SNpcSetupPartInfo()
		{
		}

		// Token: 0x0601EDE6 RID: 126438 RVA: 0x0091FF7D File Offset: 0x0091E17D
		protected override IntPtr GetUStructPtr()
		{
			return SNpcSetupPartInfo.StaticStruct();
		}

		// Token: 0x0601EDE7 RID: 126439 RVA: 0x0091FF89 File Offset: 0x0091E189
		[NullableContext(2)]
		public SNpcSetupPartInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EDE8 RID: 126440 RVA: 0x0091FF93 File Offset: 0x0091E193
		public SNpcSetupPartInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EDE9 RID: 126441 RVA: 0x0091FF9E File Offset: 0x0091E19E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNpcSetupPartInfo(Pointer, false, true);
		}

		// Token: 0x0601EDEA RID: 126442 RVA: 0x0091FFA8 File Offset: 0x0091E1A8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNpcSetupPartInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04010699 RID: 67225
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcSetupPartInfo.SNpcSetupPartInfo";

		// Token: 0x0401069A RID: 67226
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401069B RID: 67227
		internal static int __PropertyOffset_SkeletalMeshComponents;

		// Token: 0x0401069C RID: 67228
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USkeletalMeshComponent> _SkeletalMeshComponents;
	}
}
