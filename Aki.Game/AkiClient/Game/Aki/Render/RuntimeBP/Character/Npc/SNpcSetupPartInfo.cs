using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003E06 RID: 15878
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcSetupPartInfo.SNpcSetupPartInfo")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SNpcSetupPartInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027B95 RID: 162709 RVA: 0x00999B82 File Offset: 0x00997D82
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNpcSetupPartInfo._ScriptStructPtr != 0) ? SNpcSetupPartInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcSetupPartInfo.SNpcSetupPartInfo", ref SNpcSetupPartInfo._ScriptStructPtr);
		}

		// Token: 0x170059A8 RID: 22952
		// (get) Token: 0x06027B96 RID: 162710 RVA: 0x00999BA8 File Offset: 0x00997DA8
		// (set) Token: 0x06027B97 RID: 162711 RVA: 0x00999BEB File Offset: 0x00997DEB
		public TArray<USkeletalMeshComponent> SkeletalMeshComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USkeletalMeshComponent> result;
				if ((result = this._SkeletalMeshComponents) == null)
				{
					result = (this._SkeletalMeshComponents = new TArray<USkeletalMeshComponent>(base.NativePtr + (IntPtr)SNpcSetupPartInfo.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkeletalMeshComponents.CopyAssign(value);
			}
		}

		// Token: 0x06027B98 RID: 162712 RVA: 0x00999BF9 File Offset: 0x00997DF9
		public SNpcSetupPartInfo()
		{
		}

		// Token: 0x06027B99 RID: 162713 RVA: 0x00999C01 File Offset: 0x00997E01
		public SNpcSetupPartInfo(TArray<USkeletalMeshComponent> SkeletalMeshComponents)
		{
			this.SkeletalMeshComponents = SkeletalMeshComponents;
		}

		// Token: 0x06027B9A RID: 162714 RVA: 0x00999C10 File Offset: 0x00997E10
		protected override IntPtr GetUStructPtr()
		{
			return SNpcSetupPartInfo.StaticStruct();
		}

		// Token: 0x06027B9B RID: 162715 RVA: 0x00999C1C File Offset: 0x00997E1C
		[NullableContext(2)]
		public SNpcSetupPartInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027B9C RID: 162716 RVA: 0x00999C26 File Offset: 0x00997E26
		public SNpcSetupPartInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027B9D RID: 162717 RVA: 0x00999C31 File Offset: 0x00997E31
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNpcSetupPartInfo(Pointer, false, true);
		}

		// Token: 0x06027B9E RID: 162718 RVA: 0x00999C3B File Offset: 0x00997E3B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNpcSetupPartInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040141D1 RID: 82385
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcSetupPartInfo.SNpcSetupPartInfo";

		// Token: 0x040141D2 RID: 82386
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040141D3 RID: 82387
		internal static int __PropertyOffset_0;

		// Token: 0x040141D4 RID: 82388
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USkeletalMeshComponent> _SkeletalMeshComponents;
	}
}
