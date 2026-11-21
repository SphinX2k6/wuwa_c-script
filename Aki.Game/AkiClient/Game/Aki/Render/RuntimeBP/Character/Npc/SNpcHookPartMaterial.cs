using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003122 RID: 12578
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcHookPartMaterial.SNpcHookPartMaterial")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SNpcHookPartMaterial : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EDD7 RID: 126423 RVA: 0x0091FE55 File Offset: 0x0091E055
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNpcHookPartMaterial._ScriptStructPtr != 0) ? SNpcHookPartMaterial._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcHookPartMaterial.SNpcHookPartMaterial", ref SNpcHookPartMaterial._ScriptStructPtr);
		}

		// Token: 0x170035FC RID: 13820
		// (get) Token: 0x0601EDD8 RID: 126424 RVA: 0x0091FE79 File Offset: 0x0091E079
		// (set) Token: 0x0601EDD9 RID: 126425 RVA: 0x0091FE89 File Offset: 0x0091E089
		public unsafe int SlotID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNpcHookPartMaterial.__PropertyOffset_SlotID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNpcHookPartMaterial.__PropertyOffset_SlotID) = value;
			}
		}

		// Token: 0x170035FD RID: 13821
		// (get) Token: 0x0601EDDA RID: 126426 RVA: 0x0091FE9A File Offset: 0x0091E09A
		// (set) Token: 0x0601EDDB RID: 126427 RVA: 0x0091FEAE File Offset: 0x0091E0AE
		[Nullable(2)]
		public unsafe UMaterialInstance Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + SNpcHookPartMaterial.__PropertyOffset_Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNpcHookPartMaterial.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x0601EDDC RID: 126428 RVA: 0x0091FEC3 File Offset: 0x0091E0C3
		public SNpcHookPartMaterial()
		{
		}

		// Token: 0x0601EDDD RID: 126429 RVA: 0x0091FECB File Offset: 0x0091E0CB
		protected override IntPtr GetUStructPtr()
		{
			return SNpcHookPartMaterial.StaticStruct();
		}

		// Token: 0x0601EDDE RID: 126430 RVA: 0x0091FED7 File Offset: 0x0091E0D7
		[NullableContext(2)]
		public SNpcHookPartMaterial(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EDDF RID: 126431 RVA: 0x0091FEE1 File Offset: 0x0091E0E1
		public SNpcHookPartMaterial(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EDE0 RID: 126432 RVA: 0x0091FEEC File Offset: 0x0091E0EC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNpcHookPartMaterial(Pointer, false, true);
		}

		// Token: 0x0601EDE1 RID: 126433 RVA: 0x0091FEF6 File Offset: 0x0091E0F6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNpcHookPartMaterial(Pointer, MemoryOwner);
		}

		// Token: 0x04010695 RID: 67221
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcHookPartMaterial.SNpcHookPartMaterial";

		// Token: 0x04010696 RID: 67222
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010697 RID: 67223
		internal static int __PropertyOffset_SlotID;

		// Token: 0x04010698 RID: 67224
		internal static int __PropertyOffset_Material;
	}
}
