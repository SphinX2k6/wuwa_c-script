using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Module.ActiveDebug
{
	// Token: 0x02003038 RID: 12344
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Module/ActiveDebug/BvbEffectItemData.BvbEffectItemData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class BvbEffectItemData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D491 RID: 119953 RVA: 0x008EFDB9 File Offset: 0x008EDFB9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (BvbEffectItemData._ScriptStructPtr != 0) ? BvbEffectItemData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/UI/Module/ActiveDebug/BvbEffectItemData.BvbEffectItemData", ref BvbEffectItemData._ScriptStructPtr);
		}

		// Token: 0x17002E8C RID: 11916
		// (get) Token: 0x0601D492 RID: 119954 RVA: 0x008EFDDD File Offset: 0x008EDFDD
		// (set) Token: 0x0601D493 RID: 119955 RVA: 0x008EFDF1 File Offset: 0x008EDFF1
		public unsafe string Title
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BvbEffectItemData.__PropertyOffset_Title)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BvbEffectItemData.__PropertyOffset_Title)), value);
			}
		}

		// Token: 0x17002E8D RID: 11917
		// (get) Token: 0x0601D494 RID: 119956 RVA: 0x008EFE06 File Offset: 0x008EE006
		// (set) Token: 0x0601D495 RID: 119957 RVA: 0x008EFE1A File Offset: 0x008EE01A
		public unsafe string Desc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BvbEffectItemData.__PropertyOffset_Desc)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BvbEffectItemData.__PropertyOffset_Desc)), value);
			}
		}

		// Token: 0x17002E8E RID: 11918
		// (get) Token: 0x0601D496 RID: 119958 RVA: 0x008EFE30 File Offset: 0x008EE030
		// (set) Token: 0x0601D497 RID: 119959 RVA: 0x008EFE73 File Offset: 0x008EE073
		public TArray<string> ChildTitleList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ChildTitleList) == null)
				{
					result = (this._ChildTitleList = new TArray<string>(base.NativePtr + (IntPtr)BvbEffectItemData.__PropertyOffset_ChildTitleList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ChildTitleList.CopyAssign(value);
			}
		}

		// Token: 0x17002E8F RID: 11919
		// (get) Token: 0x0601D498 RID: 119960 RVA: 0x008EFE84 File Offset: 0x008EE084
		// (set) Token: 0x0601D499 RID: 119961 RVA: 0x008EFEC7 File Offset: 0x008EE0C7
		public TArray<string> ChildDescList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ChildDescList) == null)
				{
					result = (this._ChildDescList = new TArray<string>(base.NativePtr + (IntPtr)BvbEffectItemData.__PropertyOffset_ChildDescList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ChildDescList.CopyAssign(value);
			}
		}

		// Token: 0x0601D49A RID: 119962 RVA: 0x008EFED5 File Offset: 0x008EE0D5
		public BvbEffectItemData()
		{
		}

		// Token: 0x0601D49B RID: 119963 RVA: 0x008EFEDD File Offset: 0x008EE0DD
		protected override IntPtr GetUStructPtr()
		{
			return BvbEffectItemData.StaticStruct();
		}

		// Token: 0x0601D49C RID: 119964 RVA: 0x008EFEE9 File Offset: 0x008EE0E9
		[NullableContext(2)]
		public BvbEffectItemData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D49D RID: 119965 RVA: 0x008EFEF3 File Offset: 0x008EE0F3
		public BvbEffectItemData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D49E RID: 119966 RVA: 0x008EFEFE File Offset: 0x008EE0FE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new BvbEffectItemData(Pointer, false, true);
		}

		// Token: 0x0601D49F RID: 119967 RVA: 0x008EFF08 File Offset: 0x008EE108
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new BvbEffectItemData(Pointer, MemoryOwner);
		}

		// Token: 0x0400F6B3 RID: 63155
		public const string __ObjectPath = "/Game/Aki/UI/Module/ActiveDebug/BvbEffectItemData.BvbEffectItemData";

		// Token: 0x0400F6B4 RID: 63156
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F6B5 RID: 63157
		internal static int __PropertyOffset_Title;

		// Token: 0x0400F6B6 RID: 63158
		internal static int __PropertyOffset_Desc;

		// Token: 0x0400F6B7 RID: 63159
		internal static int __PropertyOffset_ChildTitleList;

		// Token: 0x0400F6B8 RID: 63160
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ChildTitleList;

		// Token: 0x0400F6B9 RID: 63161
		internal static int __PropertyOffset_ChildDescList;

		// Token: 0x0400F6BA RID: 63162
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ChildDescList;
	}
}
