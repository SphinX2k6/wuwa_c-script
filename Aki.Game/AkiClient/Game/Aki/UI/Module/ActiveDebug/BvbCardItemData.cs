using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Module.ActiveDebug
{
	// Token: 0x020039DB RID: 14811
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Module/ActiveDebug/BvbCardItemData.BvbCardItemData")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class BvbCardItemData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EFAC RID: 126892 RVA: 0x008A67F2 File Offset: 0x008A49F2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (BvbCardItemData._ScriptStructPtr != 0) ? BvbCardItemData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/UI/Module/ActiveDebug/BvbCardItemData.BvbCardItemData", ref BvbCardItemData._ScriptStructPtr);
		}

		// Token: 0x170029AB RID: 10667
		// (get) Token: 0x0601EFAD RID: 126893 RVA: 0x008A6816 File Offset: 0x008A4A16
		// (set) Token: 0x0601EFAE RID: 126894 RVA: 0x008A682A File Offset: 0x008A4A2A
		public unsafe string CardName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170029AC RID: 10668
		// (get) Token: 0x0601EFAF RID: 126895 RVA: 0x008A683F File Offset: 0x008A4A3F
		// (set) Token: 0x0601EFB0 RID: 126896 RVA: 0x008A6853 File Offset: 0x008A4A53
		public unsafe string Cost
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x170029AD RID: 10669
		// (get) Token: 0x0601EFB1 RID: 126897 RVA: 0x008A6868 File Offset: 0x008A4A68
		// (set) Token: 0x0601EFB2 RID: 126898 RVA: 0x008A687C File Offset: 0x008A4A7C
		public unsafe string Element
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x170029AE RID: 10670
		// (get) Token: 0x0601EFB3 RID: 126899 RVA: 0x008A6891 File Offset: 0x008A4A91
		// (set) Token: 0x0601EFB4 RID: 126900 RVA: 0x008A68A5 File Offset: 0x008A4AA5
		public unsafe string Power
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x170029AF RID: 10671
		// (get) Token: 0x0601EFB5 RID: 126901 RVA: 0x008A68BA File Offset: 0x008A4ABA
		// (set) Token: 0x0601EFB6 RID: 126902 RVA: 0x008A68CE File Offset: 0x008A4ACE
		public unsafe string CardDesc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_4)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_4)), value);
			}
		}

		// Token: 0x170029B0 RID: 10672
		// (get) Token: 0x0601EFB7 RID: 126903 RVA: 0x008A68E4 File Offset: 0x008A4AE4
		// (set) Token: 0x0601EFB8 RID: 126904 RVA: 0x008A6927 File Offset: 0x008A4B27
		public TArray<BvbEffectItemData> EffectList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BvbEffectItemData> result;
				if ((result = this._EffectList) == null)
				{
					result = (this._EffectList = new TArray<BvbEffectItemData>(base.NativePtr + (IntPtr)BvbCardItemData.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EffectList.CopyAssign(value);
			}
		}

		// Token: 0x0601EFB9 RID: 126905 RVA: 0x008A6935 File Offset: 0x008A4B35
		public BvbCardItemData()
		{
		}

		// Token: 0x0601EFBA RID: 126906 RVA: 0x008A693D File Offset: 0x008A4B3D
		public BvbCardItemData(string CardName, string Cost, string Element, string Power, string CardDesc, TArray<BvbEffectItemData> EffectList)
		{
			this.CardName = CardName;
			this.Cost = Cost;
			this.Element = Element;
			this.Power = Power;
			this.CardDesc = CardDesc;
			this.EffectList = EffectList;
		}

		// Token: 0x0601EFBB RID: 126907 RVA: 0x008A6972 File Offset: 0x008A4B72
		protected override IntPtr GetUStructPtr()
		{
			return BvbCardItemData.StaticStruct();
		}

		// Token: 0x0601EFBC RID: 126908 RVA: 0x008A697E File Offset: 0x008A4B7E
		[NullableContext(2)]
		public BvbCardItemData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EFBD RID: 126909 RVA: 0x008A6988 File Offset: 0x008A4B88
		public BvbCardItemData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EFBE RID: 126910 RVA: 0x008A6993 File Offset: 0x008A4B93
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new BvbCardItemData(Pointer, false, true);
		}

		// Token: 0x0601EFBF RID: 126911 RVA: 0x008A699D File Offset: 0x008A4B9D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new BvbCardItemData(Pointer, MemoryOwner);
		}

		// Token: 0x0400ED3B RID: 60731
		public const string __ObjectPath = "/Game/Aki/UI/Module/ActiveDebug/BvbCardItemData.BvbCardItemData";

		// Token: 0x0400ED3C RID: 60732
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400ED3D RID: 60733
		internal static int __PropertyOffset_0;

		// Token: 0x0400ED3E RID: 60734
		internal static int __PropertyOffset_1;

		// Token: 0x0400ED3F RID: 60735
		internal static int __PropertyOffset_2;

		// Token: 0x0400ED40 RID: 60736
		internal static int __PropertyOffset_3;

		// Token: 0x0400ED41 RID: 60737
		internal static int __PropertyOffset_4;

		// Token: 0x0400ED42 RID: 60738
		internal static int __PropertyOffset_5;

		// Token: 0x0400ED43 RID: 60739
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BvbEffectItemData> _EffectList;
	}
}
