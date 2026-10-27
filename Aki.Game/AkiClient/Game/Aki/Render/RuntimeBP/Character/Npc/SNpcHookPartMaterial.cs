using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003E05 RID: 15877
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcHookPartMaterial.SNpcHookPartMaterial")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SNpcHookPartMaterial : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027B89 RID: 162697 RVA: 0x00999AC2 File Offset: 0x00997CC2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNpcHookPartMaterial._ScriptStructPtr != 0) ? SNpcHookPartMaterial._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcHookPartMaterial.SNpcHookPartMaterial", ref SNpcHookPartMaterial._ScriptStructPtr);
		}

		// Token: 0x170059A6 RID: 22950
		// (get) Token: 0x06027B8A RID: 162698 RVA: 0x00999AE6 File Offset: 0x00997CE6
		// (set) Token: 0x06027B8B RID: 162699 RVA: 0x00999AF6 File Offset: 0x00997CF6
		public unsafe int SlotID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNpcHookPartMaterial.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNpcHookPartMaterial.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170059A7 RID: 22951
		// (get) Token: 0x06027B8C RID: 162700 RVA: 0x00999B07 File Offset: 0x00997D07
		// (set) Token: 0x06027B8D RID: 162701 RVA: 0x00999B1B File Offset: 0x00997D1B
		[Nullable(2)]
		public unsafe UMaterialInstance Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + SNpcHookPartMaterial.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SNpcHookPartMaterial.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06027B8E RID: 162702 RVA: 0x00999B30 File Offset: 0x00997D30
		public SNpcHookPartMaterial()
		{
		}

		// Token: 0x06027B8F RID: 162703 RVA: 0x00999B38 File Offset: 0x00997D38
		[NullableContext(1)]
		public SNpcHookPartMaterial(int SlotID, UMaterialInstance Material)
		{
			this.SlotID = SlotID;
			this.Material = Material;
		}

		// Token: 0x06027B90 RID: 162704 RVA: 0x00999B4E File Offset: 0x00997D4E
		protected override IntPtr GetUStructPtr()
		{
			return SNpcHookPartMaterial.StaticStruct();
		}

		// Token: 0x06027B91 RID: 162705 RVA: 0x00999B5A File Offset: 0x00997D5A
		[NullableContext(2)]
		public SNpcHookPartMaterial(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027B92 RID: 162706 RVA: 0x00999B64 File Offset: 0x00997D64
		public SNpcHookPartMaterial(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027B93 RID: 162707 RVA: 0x00999B6F File Offset: 0x00997D6F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNpcHookPartMaterial(Pointer, false, true);
		}

		// Token: 0x06027B94 RID: 162708 RVA: 0x00999B79 File Offset: 0x00997D79
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNpcHookPartMaterial(Pointer, MemoryOwner);
		}

		// Token: 0x040141CD RID: 82381
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/SNpcHookPartMaterial.SNpcHookPartMaterial";

		// Token: 0x040141CE RID: 82382
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040141CF RID: 82383
		internal static int __PropertyOffset_0;

		// Token: 0x040141D0 RID: 82384
		internal static int __PropertyOffset_1;
	}
}
