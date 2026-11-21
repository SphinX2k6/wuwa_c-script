using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003120 RID: 12576
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcChildPart.SNpcChildPart")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SNpcChildPart : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EDBD RID: 126397 RVA: 0x0091FC20 File Offset: 0x0091DE20
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNpcChildPart._ScriptStructPtr != 0) ? SNpcChildPart._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcChildPart.SNpcChildPart", ref SNpcChildPart._ScriptStructPtr);
		}

		// Token: 0x170035F6 RID: 13814
		// (get) Token: 0x0601EDBE RID: 126398 RVA: 0x0091FC44 File Offset: 0x0091DE44
		// (set) Token: 0x0601EDBF RID: 126399 RVA: 0x0091FC58 File Offset: 0x0091DE58
		[Nullable(2)]
		public unsafe USkeletalMesh Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + SNpcChildPart.__PropertyOffset_Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNpcChildPart.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x170035F7 RID: 13815
		// (get) Token: 0x0601EDC0 RID: 126400 RVA: 0x0091FC70 File Offset: 0x0091DE70
		// (set) Token: 0x0601EDC1 RID: 126401 RVA: 0x0091FCB3 File Offset: 0x0091DEB3
		public TArray<SNpcHookPartMaterial> MaterialInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPartMaterial> result;
				if ((result = this._MaterialInfos) == null)
				{
					result = (this._MaterialInfos = new TArray<SNpcHookPartMaterial>(base.NativePtr + (IntPtr)SNpcChildPart.__PropertyOffset_MaterialInfos, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialInfos.CopyAssign(value);
			}
		}

		// Token: 0x0601EDC2 RID: 126402 RVA: 0x0091FCC1 File Offset: 0x0091DEC1
		public SNpcChildPart()
		{
		}

		// Token: 0x0601EDC3 RID: 126403 RVA: 0x0091FCC9 File Offset: 0x0091DEC9
		protected override IntPtr GetUStructPtr()
		{
			return SNpcChildPart.StaticStruct();
		}

		// Token: 0x0601EDC4 RID: 126404 RVA: 0x0091FCD5 File Offset: 0x0091DED5
		[NullableContext(2)]
		public SNpcChildPart(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EDC5 RID: 126405 RVA: 0x0091FCDF File Offset: 0x0091DEDF
		public SNpcChildPart(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EDC6 RID: 126406 RVA: 0x0091FCEA File Offset: 0x0091DEEA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNpcChildPart(Pointer, false, true);
		}

		// Token: 0x0601EDC7 RID: 126407 RVA: 0x0091FCF4 File Offset: 0x0091DEF4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNpcChildPart(Pointer, MemoryOwner);
		}

		// Token: 0x04010688 RID: 67208
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcChildPart.SNpcChildPart";

		// Token: 0x04010689 RID: 67209
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401068A RID: 67210
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0401068B RID: 67211
		internal static int __PropertyOffset_MaterialInfos;

		// Token: 0x0401068C RID: 67212
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPartMaterial> _MaterialInfos;
	}
}
