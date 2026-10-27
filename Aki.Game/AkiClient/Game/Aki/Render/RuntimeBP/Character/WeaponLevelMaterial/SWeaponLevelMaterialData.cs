using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.WeaponLevelMaterial
{
	// Token: 0x02003DF6 RID: 15862
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/WeaponLevelMaterial/SWeaponLevelMaterialData.SWeaponLevelMaterialData")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class SWeaponLevelMaterialData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060279C6 RID: 162246 RVA: 0x00996184 File Offset: 0x00994384
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWeaponLevelMaterialData._ScriptStructPtr != 0) ? SWeaponLevelMaterialData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/WeaponLevelMaterial/SWeaponLevelMaterialData.SWeaponLevelMaterialData", ref SWeaponLevelMaterialData._ScriptStructPtr);
		}

		// Token: 0x17005903 RID: 22787
		// (get) Token: 0x060279C7 RID: 162247 RVA: 0x009961A8 File Offset: 0x009943A8
		// (set) Token: 0x060279C8 RID: 162248 RVA: 0x009961EB File Offset: 0x009943EB
		public TMap<string, SWeaponMaterialParams> SlotNewParamValues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, SWeaponMaterialParams> result;
				if ((result = this._SlotNewParamValues) == null)
				{
					result = (this._SlotNewParamValues = new TMap<string, SWeaponMaterialParams>(base.NativePtr + (IntPtr)SWeaponLevelMaterialData.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SlotNewParamValues.CopyAssign(value);
			}
		}

		// Token: 0x060279C9 RID: 162249 RVA: 0x009961F9 File Offset: 0x009943F9
		public SWeaponLevelMaterialData()
		{
		}

		// Token: 0x060279CA RID: 162250 RVA: 0x00996201 File Offset: 0x00994401
		public SWeaponLevelMaterialData(TMap<string, SWeaponMaterialParams> SlotNewParamValues)
		{
			this.SlotNewParamValues = SlotNewParamValues;
		}

		// Token: 0x060279CB RID: 162251 RVA: 0x00996210 File Offset: 0x00994410
		protected override IntPtr GetUStructPtr()
		{
			return SWeaponLevelMaterialData.StaticStruct();
		}

		// Token: 0x060279CC RID: 162252 RVA: 0x0099621C File Offset: 0x0099441C
		[NullableContext(2)]
		public SWeaponLevelMaterialData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060279CD RID: 162253 RVA: 0x00996226 File Offset: 0x00994426
		public SWeaponLevelMaterialData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060279CE RID: 162254 RVA: 0x00996231 File Offset: 0x00994431
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWeaponLevelMaterialData(Pointer, false, true);
		}

		// Token: 0x060279CF RID: 162255 RVA: 0x0099623B File Offset: 0x0099443B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWeaponLevelMaterialData(Pointer, MemoryOwner);
		}

		// Token: 0x04014088 RID: 82056
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/WeaponLevelMaterial/SWeaponLevelMaterialData.SWeaponLevelMaterialData";

		// Token: 0x04014089 RID: 82057
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401408A RID: 82058
		internal static int __PropertyOffset_0;

		// Token: 0x0401408B RID: 82059
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, SWeaponMaterialParams> _SlotNewParamValues;
	}
}
