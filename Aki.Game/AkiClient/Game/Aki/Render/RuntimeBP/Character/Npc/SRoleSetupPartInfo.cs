using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003E0A RID: 15882
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/SRoleSetupPartInfo.SRoleSetupPartInfo")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SRoleSetupPartInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027BC9 RID: 162761 RVA: 0x00999F72 File Offset: 0x00998172
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SRoleSetupPartInfo._ScriptStructPtr != 0) ? SRoleSetupPartInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/Npc/SRoleSetupPartInfo.SRoleSetupPartInfo", ref SRoleSetupPartInfo._ScriptStructPtr);
		}

		// Token: 0x170059B2 RID: 22962
		// (get) Token: 0x06027BCA RID: 162762 RVA: 0x00999F98 File Offset: 0x00998198
		// (set) Token: 0x06027BCB RID: 162763 RVA: 0x00999FDB File Offset: 0x009981DB
		public TArray<USkeletalMeshComponent> SkeletalMeshComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USkeletalMeshComponent> result;
				if ((result = this._SkeletalMeshComponents) == null)
				{
					result = (this._SkeletalMeshComponents = new TArray<USkeletalMeshComponent>(base.NativePtr + (IntPtr)SRoleSetupPartInfo.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkeletalMeshComponents.CopyAssign(value);
			}
		}

		// Token: 0x06027BCC RID: 162764 RVA: 0x00999FE9 File Offset: 0x009981E9
		public SRoleSetupPartInfo()
		{
		}

		// Token: 0x06027BCD RID: 162765 RVA: 0x00999FF1 File Offset: 0x009981F1
		public SRoleSetupPartInfo(TArray<USkeletalMeshComponent> SkeletalMeshComponents)
		{
			this.SkeletalMeshComponents = SkeletalMeshComponents;
		}

		// Token: 0x06027BCE RID: 162766 RVA: 0x0099A000 File Offset: 0x00998200
		protected override IntPtr GetUStructPtr()
		{
			return SRoleSetupPartInfo.StaticStruct();
		}

		// Token: 0x06027BCF RID: 162767 RVA: 0x0099A00C File Offset: 0x0099820C
		[NullableContext(2)]
		public SRoleSetupPartInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027BD0 RID: 162768 RVA: 0x0099A016 File Offset: 0x00998216
		public SRoleSetupPartInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027BD1 RID: 162769 RVA: 0x0099A021 File Offset: 0x00998221
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SRoleSetupPartInfo(Pointer, false, true);
		}

		// Token: 0x06027BD2 RID: 162770 RVA: 0x0099A02B File Offset: 0x0099822B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SRoleSetupPartInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040141E6 RID: 82406
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/SRoleSetupPartInfo.SRoleSetupPartInfo";

		// Token: 0x040141E7 RID: 82407
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040141E8 RID: 82408
		internal static int __PropertyOffset_0;

		// Token: 0x040141E9 RID: 82409
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USkeletalMeshComponent> _SkeletalMeshComponents;
	}
}
