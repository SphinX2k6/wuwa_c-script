using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Module.ActiveDebug
{
	// Token: 0x020039DF RID: 14815
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Module/ActiveDebug/BvbEffectItemData.BvbEffectItemData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class BvbEffectItemData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F005 RID: 126981 RVA: 0x008A71DE File Offset: 0x008A53DE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (BvbEffectItemData._ScriptStructPtr != 0) ? BvbEffectItemData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/UI/Module/ActiveDebug/BvbEffectItemData.BvbEffectItemData", ref BvbEffectItemData._ScriptStructPtr);
		}

		// Token: 0x170029C7 RID: 10695
		// (get) Token: 0x0601F006 RID: 126982 RVA: 0x008A7202 File Offset: 0x008A5402
		// (set) Token: 0x0601F007 RID: 126983 RVA: 0x008A7216 File Offset: 0x008A5416
		public unsafe string Title
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BvbEffectItemData.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BvbEffectItemData.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170029C8 RID: 10696
		// (get) Token: 0x0601F008 RID: 126984 RVA: 0x008A722B File Offset: 0x008A542B
		// (set) Token: 0x0601F009 RID: 126985 RVA: 0x008A723F File Offset: 0x008A543F
		public unsafe string Desc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BvbEffectItemData.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BvbEffectItemData.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x170029C9 RID: 10697
		// (get) Token: 0x0601F00A RID: 126986 RVA: 0x008A7254 File Offset: 0x008A5454
		// (set) Token: 0x0601F00B RID: 126987 RVA: 0x008A7297 File Offset: 0x008A5497
		public TArray<string> ChildTitleList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ChildTitleList) == null)
				{
					result = (this._ChildTitleList = new TArray<string>(base.NativePtr + (IntPtr)BvbEffectItemData.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ChildTitleList.CopyAssign(value);
			}
		}

		// Token: 0x170029CA RID: 10698
		// (get) Token: 0x0601F00C RID: 126988 RVA: 0x008A72A8 File Offset: 0x008A54A8
		// (set) Token: 0x0601F00D RID: 126989 RVA: 0x008A72EB File Offset: 0x008A54EB
		public TArray<string> ChildDescList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ChildDescList) == null)
				{
					result = (this._ChildDescList = new TArray<string>(base.NativePtr + (IntPtr)BvbEffectItemData.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ChildDescList.CopyAssign(value);
			}
		}

		// Token: 0x0601F00E RID: 126990 RVA: 0x008A72F9 File Offset: 0x008A54F9
		public BvbEffectItemData()
		{
		}

		// Token: 0x0601F00F RID: 126991 RVA: 0x008A7301 File Offset: 0x008A5501
		public BvbEffectItemData(string Title, string Desc, TArray<string> ChildTitleList, TArray<string> ChildDescList)
		{
			this.Title = Title;
			this.Desc = Desc;
			this.ChildTitleList = ChildTitleList;
			this.ChildDescList = ChildDescList;
		}

		// Token: 0x0601F010 RID: 126992 RVA: 0x008A7326 File Offset: 0x008A5526
		protected override IntPtr GetUStructPtr()
		{
			return BvbEffectItemData.StaticStruct();
		}

		// Token: 0x0601F011 RID: 126993 RVA: 0x008A7332 File Offset: 0x008A5532
		[NullableContext(2)]
		public BvbEffectItemData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F012 RID: 126994 RVA: 0x008A733C File Offset: 0x008A553C
		public BvbEffectItemData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F013 RID: 126995 RVA: 0x008A7347 File Offset: 0x008A5547
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new BvbEffectItemData(Pointer, false, true);
		}

		// Token: 0x0601F014 RID: 126996 RVA: 0x008A7351 File Offset: 0x008A5551
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new BvbEffectItemData(Pointer, MemoryOwner);
		}

		// Token: 0x0400ED72 RID: 60786
		public const string __ObjectPath = "/Game/Aki/UI/Module/ActiveDebug/BvbEffectItemData.BvbEffectItemData";

		// Token: 0x0400ED73 RID: 60787
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400ED74 RID: 60788
		internal static int __PropertyOffset_0;

		// Token: 0x0400ED75 RID: 60789
		internal static int __PropertyOffset_1;

		// Token: 0x0400ED76 RID: 60790
		internal static int __PropertyOffset_2;

		// Token: 0x0400ED77 RID: 60791
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ChildTitleList;

		// Token: 0x0400ED78 RID: 60792
		internal static int __PropertyOffset_3;

		// Token: 0x0400ED79 RID: 60793
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ChildDescList;
	}
}
