using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x02003F58 RID: 16216
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SSpecialEnergyBar.SSpecialEnergyBar")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 424)]
	public class SSpecialEnergyBar : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060294BE RID: 169150 RVA: 0x009C0A12 File Offset: 0x009BEC12
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSpecialEnergyBar._ScriptStructPtr != 0) ? SSpecialEnergyBar._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SSpecialEnergyBar.SSpecialEnergyBar", ref SSpecialEnergyBar._ScriptStructPtr);
		}

		// Token: 0x1700627F RID: 25215
		// (get) Token: 0x060294BF RID: 169151 RVA: 0x009C0A36 File Offset: 0x009BEC36
		// (set) Token: 0x060294C0 RID: 169152 RVA: 0x009C0A4A File Offset: 0x009BEC4A
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSpecialEnergyBar.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSpecialEnergyBar.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006280 RID: 25216
		// (get) Token: 0x060294C1 RID: 169153 RVA: 0x009C0A5F File Offset: 0x009BEC5F
		// (set) Token: 0x060294C2 RID: 169154 RVA: 0x009C0A73 File Offset: 0x009BEC73
		[Nullable(0)]
		public unsafe TEnumAsByte<ESpecialEnergyBarPrefabType> PrefabType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_1);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006281 RID: 25217
		// (get) Token: 0x060294C3 RID: 169155 RVA: 0x009C0A88 File Offset: 0x009BEC88
		// (set) Token: 0x060294C4 RID: 169156 RVA: 0x009C0A98 File Offset: 0x009BEC98
		public unsafe int ExtraType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006282 RID: 25218
		// (get) Token: 0x060294C5 RID: 169157 RVA: 0x009C0AA9 File Offset: 0x009BECA9
		// (set) Token: 0x060294C6 RID: 169158 RVA: 0x009C0AB9 File Offset: 0x009BECB9
		public unsafe int SlotNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006283 RID: 25219
		// (get) Token: 0x060294C7 RID: 169159 RVA: 0x009C0ACC File Offset: 0x009BECCC
		// (set) Token: 0x060294C8 RID: 169160 RVA: 0x009C0B0F File Offset: 0x009BED0F
		public TArray<float> ExtraFloatParams
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ExtraFloatParams) == null)
				{
					result = (this._ExtraFloatParams = new TArray<float>(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExtraFloatParams.CopyAssign(value);
			}
		}

		// Token: 0x17006284 RID: 25220
		// (get) Token: 0x060294C9 RID: 169161 RVA: 0x009C0B1D File Offset: 0x009BED1D
		// (set) Token: 0x060294CA RID: 169162 RVA: 0x009C0B3C File Offset: 0x009BED3C
		public TSoftObjectPtr<UPrefabAsset> PrefabPath
		{
			get
			{
				return new TSoftObjectPtr<UPrefabAsset>(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_5, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006285 RID: 25221
		// (get) Token: 0x060294CB RID: 169163 RVA: 0x009C0B61 File Offset: 0x009BED61
		// (set) Token: 0x060294CC RID: 169164 RVA: 0x009C0B71 File Offset: 0x009BED71
		public unsafe int AttributeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006286 RID: 25222
		// (get) Token: 0x060294CD RID: 169165 RVA: 0x009C0B82 File Offset: 0x009BED82
		// (set) Token: 0x060294CE RID: 169166 RVA: 0x009C0B92 File Offset: 0x009BED92
		public unsafe int MaxAttributeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006287 RID: 25223
		// (get) Token: 0x060294CF RID: 169167 RVA: 0x009C0BA3 File Offset: 0x009BEDA3
		// (set) Token: 0x060294D0 RID: 169168 RVA: 0x009C0BB3 File Offset: 0x009BEDB3
		public unsafe long BuffId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006288 RID: 25224
		// (get) Token: 0x060294D1 RID: 169169 RVA: 0x009C0BC4 File Offset: 0x009BEDC4
		// (set) Token: 0x060294D2 RID: 169170 RVA: 0x009C0C07 File Offset: 0x009BEE07
		public TMap<FGameplayTag, int> TagEnergyBarIdMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, int> result;
				if ((result = this._TagEnergyBarIdMap) == null)
				{
					result = (this._TagEnergyBarIdMap = new TMap<FGameplayTag, int>(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TagEnergyBarIdMap.CopyAssign(value);
			}
		}

		// Token: 0x17006289 RID: 25225
		// (get) Token: 0x060294D3 RID: 169171 RVA: 0x009C0C15 File Offset: 0x009BEE15
		// (set) Token: 0x060294D4 RID: 169172 RVA: 0x009C0C29 File Offset: 0x009BEE29
		public unsafe string EffectColor
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSpecialEnergyBar.__PropertyOffset_10)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSpecialEnergyBar.__PropertyOffset_10)), value);
			}
		}

		// Token: 0x1700628A RID: 25226
		// (get) Token: 0x060294D5 RID: 169173 RVA: 0x009C0C3E File Offset: 0x009BEE3E
		// (set) Token: 0x060294D6 RID: 169174 RVA: 0x009C0C52 File Offset: 0x009BEE52
		public unsafe string PointColor
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSpecialEnergyBar.__PropertyOffset_11)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSpecialEnergyBar.__PropertyOffset_11)), value);
			}
		}

		// Token: 0x1700628B RID: 25227
		// (get) Token: 0x060294D7 RID: 169175 RVA: 0x009C0C67 File Offset: 0x009BEE67
		// (set) Token: 0x060294D8 RID: 169176 RVA: 0x009C0C86 File Offset: 0x009BEE86
		public TSoftObjectPtr<UTexture2D> TexturePath
		{
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_12, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_12, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700628C RID: 25228
		// (get) Token: 0x060294D9 RID: 169177 RVA: 0x009C0CAB File Offset: 0x009BEEAB
		// (set) Token: 0x060294DA RID: 169178 RVA: 0x009C0CCA File Offset: 0x009BEECA
		public TSoftObjectPtr<UTexture2D> EnableTexturePath
		{
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_13, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_13, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700628D RID: 25229
		// (get) Token: 0x060294DB RID: 169179 RVA: 0x009C0CEF File Offset: 0x009BEEEF
		// (set) Token: 0x060294DC RID: 169180 RVA: 0x009C0D0E File Offset: 0x009BEF0E
		public TSoftObjectPtr<UTexture2D> FrontTexturePath
		{
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_14, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_14, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700628E RID: 25230
		// (get) Token: 0x060294DD RID: 169181 RVA: 0x009C0D34 File Offset: 0x009BEF34
		// (set) Token: 0x060294DE RID: 169182 RVA: 0x009C0D77 File Offset: 0x009BEF77
		public TArray<TSoftObjectPtr<UNiagaraSystem>> NiagaraList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UNiagaraSystem>> result;
				if ((result = this._NiagaraList) == null)
				{
					result = (this._NiagaraList = new TArray<TSoftObjectPtr<UNiagaraSystem>>(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_15, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NiagaraList.CopyAssign(value);
			}
		}

		// Token: 0x1700628F RID: 25231
		// (get) Token: 0x060294DF RID: 169183 RVA: 0x009C0D85 File Offset: 0x009BEF85
		// (set) Token: 0x060294E0 RID: 169184 RVA: 0x009C0D95 File Offset: 0x009BEF95
		public unsafe int KeyEnableNiagaraIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006290 RID: 25232
		// (get) Token: 0x060294E1 RID: 169185 RVA: 0x009C0DA6 File Offset: 0x009BEFA6
		// (set) Token: 0x060294E2 RID: 169186 RVA: 0x009C0DB6 File Offset: 0x009BEFB6
		public unsafe int KeyType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006291 RID: 25233
		// (get) Token: 0x060294E3 RID: 169187 RVA: 0x009C0DC7 File Offset: 0x009BEFC7
		// (set) Token: 0x060294E4 RID: 169188 RVA: 0x009C0DD7 File Offset: 0x009BEFD7
		public unsafe int DisableKeyOnPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17006292 RID: 25234
		// (get) Token: 0x060294E5 RID: 169189 RVA: 0x009C0DE8 File Offset: 0x009BEFE8
		// (set) Token: 0x060294E6 RID: 169190 RVA: 0x009C0DFC File Offset: 0x009BEFFC
		public unsafe FGameplayTag KeyEnableTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006293 RID: 25235
		// (get) Token: 0x060294E7 RID: 169191 RVA: 0x009C0E14 File Offset: 0x009BF014
		// (set) Token: 0x060294E8 RID: 169192 RVA: 0x009C0E57 File Offset: 0x009BF057
		public TArray<SSpecialEnergyBarKey> KeyInfoList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSpecialEnergyBarKey> result;
				if ((result = this._KeyInfoList) == null)
				{
					result = (this._KeyInfoList = new TArray<SSpecialEnergyBarKey>(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_20, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KeyInfoList.CopyAssign(value);
			}
		}

		// Token: 0x060294E9 RID: 169193 RVA: 0x009C0E65 File Offset: 0x009BF065
		public SSpecialEnergyBar()
		{
		}

		// Token: 0x060294EA RID: 169194 RVA: 0x009C0E70 File Offset: 0x009BF070
		public SSpecialEnergyBar(string Name, [Nullable(0)] TEnumAsByte<ESpecialEnergyBarPrefabType> PrefabType, int ExtraType, int SlotNum, TArray<float> ExtraFloatParams, TSoftObjectPtr<UPrefabAsset> PrefabPath, int AttributeId, int MaxAttributeId, long BuffId, TMap<FGameplayTag, int> TagEnergyBarIdMap, string EffectColor, string PointColor, TSoftObjectPtr<UTexture2D> TexturePath, TSoftObjectPtr<UTexture2D> EnableTexturePath, TSoftObjectPtr<UTexture2D> FrontTexturePath, TArray<TSoftObjectPtr<UNiagaraSystem>> NiagaraList, int KeyEnableNiagaraIndex, int KeyType, int DisableKeyOnPercent, FGameplayTag KeyEnableTag, TArray<SSpecialEnergyBarKey> KeyInfoList)
		{
			this.Name = Name;
			this.PrefabType = PrefabType;
			this.ExtraType = ExtraType;
			this.SlotNum = SlotNum;
			this.ExtraFloatParams = ExtraFloatParams;
			this.PrefabPath = PrefabPath;
			this.AttributeId = AttributeId;
			this.MaxAttributeId = MaxAttributeId;
			this.BuffId = BuffId;
			this.TagEnergyBarIdMap = TagEnergyBarIdMap;
			this.EffectColor = EffectColor;
			this.PointColor = PointColor;
			this.TexturePath = TexturePath;
			this.EnableTexturePath = EnableTexturePath;
			this.FrontTexturePath = FrontTexturePath;
			this.NiagaraList = NiagaraList;
			this.KeyEnableNiagaraIndex = KeyEnableNiagaraIndex;
			this.KeyType = KeyType;
			this.DisableKeyOnPercent = DisableKeyOnPercent;
			this.KeyEnableTag = KeyEnableTag;
			this.KeyInfoList = KeyInfoList;
		}

		// Token: 0x060294EB RID: 169195 RVA: 0x009C0F28 File Offset: 0x009BF128
		protected override IntPtr GetUStructPtr()
		{
			return SSpecialEnergyBar.StaticStruct();
		}

		// Token: 0x060294EC RID: 169196 RVA: 0x009C0F34 File Offset: 0x009BF134
		[NullableContext(2)]
		public SSpecialEnergyBar(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060294ED RID: 169197 RVA: 0x009C0F3E File Offset: 0x009BF13E
		public SSpecialEnergyBar(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060294EE RID: 169198 RVA: 0x009C0F49 File Offset: 0x009BF149
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSpecialEnergyBar(Pointer, false, true);
		}

		// Token: 0x060294EF RID: 169199 RVA: 0x009C0F53 File Offset: 0x009BF153
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSpecialEnergyBar(Pointer, MemoryOwner);
		}

		// Token: 0x04015286 RID: 86662
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SSpecialEnergyBar.SSpecialEnergyBar";

		// Token: 0x04015287 RID: 86663
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015288 RID: 86664
		internal static int __PropertyOffset_0;

		// Token: 0x04015289 RID: 86665
		internal static int __PropertyOffset_1;

		// Token: 0x0401528A RID: 86666
		internal static int __PropertyOffset_2;

		// Token: 0x0401528B RID: 86667
		internal static int __PropertyOffset_3;

		// Token: 0x0401528C RID: 86668
		internal static int __PropertyOffset_4;

		// Token: 0x0401528D RID: 86669
		[Nullable(2)]
		private TArray<float> _ExtraFloatParams;

		// Token: 0x0401528E RID: 86670
		internal static int __PropertyOffset_5;

		// Token: 0x0401528F RID: 86671
		internal static int __PropertyOffset_6;

		// Token: 0x04015290 RID: 86672
		internal static int __PropertyOffset_7;

		// Token: 0x04015291 RID: 86673
		internal static int __PropertyOffset_8;

		// Token: 0x04015292 RID: 86674
		internal static int __PropertyOffset_9;

		// Token: 0x04015293 RID: 86675
		[Nullable(2)]
		private TMap<FGameplayTag, int> _TagEnergyBarIdMap;

		// Token: 0x04015294 RID: 86676
		internal static int __PropertyOffset_10;

		// Token: 0x04015295 RID: 86677
		internal static int __PropertyOffset_11;

		// Token: 0x04015296 RID: 86678
		internal static int __PropertyOffset_12;

		// Token: 0x04015297 RID: 86679
		internal static int __PropertyOffset_13;

		// Token: 0x04015298 RID: 86680
		internal static int __PropertyOffset_14;

		// Token: 0x04015299 RID: 86681
		internal static int __PropertyOffset_15;

		// Token: 0x0401529A RID: 86682
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UNiagaraSystem>> _NiagaraList;

		// Token: 0x0401529B RID: 86683
		internal static int __PropertyOffset_16;

		// Token: 0x0401529C RID: 86684
		internal static int __PropertyOffset_17;

		// Token: 0x0401529D RID: 86685
		internal static int __PropertyOffset_18;

		// Token: 0x0401529E RID: 86686
		internal static int __PropertyOffset_19;

		// Token: 0x0401529F RID: 86687
		internal static int __PropertyOffset_20;

		// Token: 0x040152A0 RID: 86688
		[Nullable(2)]
		private TArray<SSpecialEnergyBarKey> _KeyInfoList;
	}
}
