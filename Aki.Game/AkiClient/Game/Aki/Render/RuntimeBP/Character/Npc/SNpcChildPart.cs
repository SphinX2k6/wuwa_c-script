using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003E03 RID: 15875
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcChildPart.SNpcChildPart")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SNpcChildPart : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027B6D RID: 162669 RVA: 0x00999850 File Offset: 0x00997A50
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNpcChildPart._ScriptStructPtr != 0) ? SNpcChildPart._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcChildPart.SNpcChildPart", ref SNpcChildPart._ScriptStructPtr);
		}

		// Token: 0x170059A0 RID: 22944
		// (get) Token: 0x06027B6E RID: 162670 RVA: 0x00999874 File Offset: 0x00997A74
		// (set) Token: 0x06027B6F RID: 162671 RVA: 0x00999888 File Offset: 0x00997A88
		[Nullable(2)]
		public unsafe USkeletalMesh Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + SNpcChildPart.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNpcChildPart.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170059A1 RID: 22945
		// (get) Token: 0x06027B70 RID: 162672 RVA: 0x009998A0 File Offset: 0x00997AA0
		// (set) Token: 0x06027B71 RID: 162673 RVA: 0x009998E3 File Offset: 0x00997AE3
		public TArray<SNpcHookPartMaterial> MaterialInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPartMaterial> result;
				if ((result = this._MaterialInfos) == null)
				{
					result = (this._MaterialInfos = new TArray<SNpcHookPartMaterial>(base.NativePtr + (IntPtr)SNpcChildPart.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialInfos.CopyAssign(value);
			}
		}

		// Token: 0x06027B72 RID: 162674 RVA: 0x009998F1 File Offset: 0x00997AF1
		public SNpcChildPart()
		{
		}

		// Token: 0x06027B73 RID: 162675 RVA: 0x009998F9 File Offset: 0x00997AF9
		public SNpcChildPart(USkeletalMesh Mesh, TArray<SNpcHookPartMaterial> MaterialInfos)
		{
			this.Mesh = Mesh;
			this.MaterialInfos = MaterialInfos;
		}

		// Token: 0x06027B74 RID: 162676 RVA: 0x0099990F File Offset: 0x00997B0F
		protected override IntPtr GetUStructPtr()
		{
			return SNpcChildPart.StaticStruct();
		}

		// Token: 0x06027B75 RID: 162677 RVA: 0x0099991B File Offset: 0x00997B1B
		[NullableContext(2)]
		public SNpcChildPart(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027B76 RID: 162678 RVA: 0x00999925 File Offset: 0x00997B25
		public SNpcChildPart(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027B77 RID: 162679 RVA: 0x00999930 File Offset: 0x00997B30
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNpcChildPart(Pointer, false, true);
		}

		// Token: 0x06027B78 RID: 162680 RVA: 0x0099993A File Offset: 0x00997B3A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNpcChildPart(Pointer, MemoryOwner);
		}

		// Token: 0x040141C0 RID: 82368
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcChildPart.SNpcChildPart";

		// Token: 0x040141C1 RID: 82369
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040141C2 RID: 82370
		internal static int __PropertyOffset_0;

		// Token: 0x040141C3 RID: 82371
		internal static int __PropertyOffset_1;

		// Token: 0x040141C4 RID: 82372
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPartMaterial> _MaterialInfos;
	}
}
