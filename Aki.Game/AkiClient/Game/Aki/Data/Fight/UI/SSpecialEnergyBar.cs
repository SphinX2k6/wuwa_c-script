using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x020031FD RID: 12797
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SSpecialEnergyBar.SSpecialEnergyBar")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 424)]
	public class SSpecialEnergyBar : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FD87 RID: 130439 RVA: 0x00937381 File Offset: 0x00935581
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSpecialEnergyBar._ScriptStructPtr != 0) ? SSpecialEnergyBar._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SSpecialEnergyBar.SSpecialEnergyBar", ref SSpecialEnergyBar._ScriptStructPtr);
		}

		// Token: 0x17003BC8 RID: 15304
		// (get) Token: 0x0601FD88 RID: 130440 RVA: 0x009373A5 File Offset: 0x009355A5
		// (set) Token: 0x0601FD89 RID: 130441 RVA: 0x009373B9 File Offset: 0x009355B9
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSpecialEnergyBar.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSpecialEnergyBar.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17003BC9 RID: 15305
		// (get) Token: 0x0601FD8A RID: 130442 RVA: 0x009373CE File Offset: 0x009355CE
		// (set) Token: 0x0601FD8B RID: 130443 RVA: 0x009373E2 File Offset: 0x009355E2
		[Nullable(0)]
		public unsafe TEnumAsByte<ESpecialEnergyBarPrefabType> PrefabType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_PrefabType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_PrefabType) = value;
			}
		}

		// Token: 0x17003BCA RID: 15306
		// (get) Token: 0x0601FD8C RID: 130444 RVA: 0x009373F7 File Offset: 0x009355F7
		// (set) Token: 0x0601FD8D RID: 130445 RVA: 0x00937407 File Offset: 0x00935607
		public unsafe int ExtraType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_ExtraType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_ExtraType) = value;
			}
		}

		// Token: 0x17003BCB RID: 15307
		// (get) Token: 0x0601FD8E RID: 130446 RVA: 0x00937418 File Offset: 0x00935618
		// (set) Token: 0x0601FD8F RID: 130447 RVA: 0x00937428 File Offset: 0x00935628
		public unsafe int SlotNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_SlotNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_SlotNum) = value;
			}
		}

		// Token: 0x17003BCC RID: 15308
		// (get) Token: 0x0601FD90 RID: 130448 RVA: 0x0093743C File Offset: 0x0093563C
		// (set) Token: 0x0601FD91 RID: 130449 RVA: 0x0093747F File Offset: 0x0093567F
		public TArray<float> ExtraFloatParams
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ExtraFloatParams) == null)
				{
					result = (this._ExtraFloatParams = new TArray<float>(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_ExtraFloatParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExtraFloatParams.CopyAssign(value);
			}
		}

		// Token: 0x17003BCD RID: 15309
		// (get) Token: 0x0601FD92 RID: 130450 RVA: 0x0093748D File Offset: 0x0093568D
		// (set) Token: 0x0601FD93 RID: 130451 RVA: 0x009374AC File Offset: 0x009356AC
		public TSoftObjectPtr<UPrefabAsset> PrefabPath
		{
			get
			{
				return new TSoftObjectPtr<UPrefabAsset>(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_PrefabPath, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_PrefabPath, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003BCE RID: 15310
		// (get) Token: 0x0601FD94 RID: 130452 RVA: 0x009374D1 File Offset: 0x009356D1
		// (set) Token: 0x0601FD95 RID: 130453 RVA: 0x009374E1 File Offset: 0x009356E1
		public unsafe int AttributeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_AttributeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_AttributeId) = value;
			}
		}

		// Token: 0x17003BCF RID: 15311
		// (get) Token: 0x0601FD96 RID: 130454 RVA: 0x009374F2 File Offset: 0x009356F2
		// (set) Token: 0x0601FD97 RID: 130455 RVA: 0x00937502 File Offset: 0x00935702
		public unsafe int MaxAttributeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_MaxAttributeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_MaxAttributeId) = value;
			}
		}

		// Token: 0x17003BD0 RID: 15312
		// (get) Token: 0x0601FD98 RID: 130456 RVA: 0x00937513 File Offset: 0x00935713
		// (set) Token: 0x0601FD99 RID: 130457 RVA: 0x00937523 File Offset: 0x00935723
		public unsafe long BuffId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_BuffId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_BuffId) = value;
			}
		}

		// Token: 0x17003BD1 RID: 15313
		// (get) Token: 0x0601FD9A RID: 130458 RVA: 0x00937534 File Offset: 0x00935734
		// (set) Token: 0x0601FD9B RID: 130459 RVA: 0x00937577 File Offset: 0x00935777
		public TMap<FGameplayTag, int> TagEnergyBarIdMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, int> result;
				if ((result = this._TagEnergyBarIdMap) == null)
				{
					result = (this._TagEnergyBarIdMap = new TMap<FGameplayTag, int>(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_TagEnergyBarIdMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TagEnergyBarIdMap.CopyAssign(value);
			}
		}

		// Token: 0x17003BD2 RID: 15314
		// (get) Token: 0x0601FD9C RID: 130460 RVA: 0x00937585 File Offset: 0x00935785
		// (set) Token: 0x0601FD9D RID: 130461 RVA: 0x00937599 File Offset: 0x00935799
		public unsafe string EffectColor
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSpecialEnergyBar.__PropertyOffset_EffectColor)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSpecialEnergyBar.__PropertyOffset_EffectColor)), value);
			}
		}

		// Token: 0x17003BD3 RID: 15315
		// (get) Token: 0x0601FD9E RID: 130462 RVA: 0x009375AE File Offset: 0x009357AE
		// (set) Token: 0x0601FD9F RID: 130463 RVA: 0x009375C2 File Offset: 0x009357C2
		public unsafe string PointColor
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSpecialEnergyBar.__PropertyOffset_PointColor)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSpecialEnergyBar.__PropertyOffset_PointColor)), value);
			}
		}

		// Token: 0x17003BD4 RID: 15316
		// (get) Token: 0x0601FDA0 RID: 130464 RVA: 0x009375D7 File Offset: 0x009357D7
		// (set) Token: 0x0601FDA1 RID: 130465 RVA: 0x009375F6 File Offset: 0x009357F6
		public TSoftObjectPtr<UTexture2D> TexturePath
		{
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_TexturePath, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_TexturePath, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003BD5 RID: 15317
		// (get) Token: 0x0601FDA2 RID: 130466 RVA: 0x0093761B File Offset: 0x0093581B
		// (set) Token: 0x0601FDA3 RID: 130467 RVA: 0x0093763A File Offset: 0x0093583A
		public TSoftObjectPtr<UTexture2D> EnableTexturePath
		{
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_EnableTexturePath, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_EnableTexturePath, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003BD6 RID: 15318
		// (get) Token: 0x0601FDA4 RID: 130468 RVA: 0x0093765F File Offset: 0x0093585F
		// (set) Token: 0x0601FDA5 RID: 130469 RVA: 0x0093767E File Offset: 0x0093587E
		public TSoftObjectPtr<UTexture2D> FrontTexturePath
		{
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_FrontTexturePath, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_FrontTexturePath, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003BD7 RID: 15319
		// (get) Token: 0x0601FDA6 RID: 130470 RVA: 0x009376A4 File Offset: 0x009358A4
		// (set) Token: 0x0601FDA7 RID: 130471 RVA: 0x009376E7 File Offset: 0x009358E7
		public TArray<TSoftObjectPtr<UNiagaraSystem>> NiagaraList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UNiagaraSystem>> result;
				if ((result = this._NiagaraList) == null)
				{
					result = (this._NiagaraList = new TArray<TSoftObjectPtr<UNiagaraSystem>>(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_NiagaraList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NiagaraList.CopyAssign(value);
			}
		}

		// Token: 0x17003BD8 RID: 15320
		// (get) Token: 0x0601FDA8 RID: 130472 RVA: 0x009376F5 File Offset: 0x009358F5
		// (set) Token: 0x0601FDA9 RID: 130473 RVA: 0x00937705 File Offset: 0x00935905
		public unsafe int KeyEnableNiagaraIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_KeyEnableNiagaraIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_KeyEnableNiagaraIndex) = value;
			}
		}

		// Token: 0x17003BD9 RID: 15321
		// (get) Token: 0x0601FDAA RID: 130474 RVA: 0x00937716 File Offset: 0x00935916
		// (set) Token: 0x0601FDAB RID: 130475 RVA: 0x00937726 File Offset: 0x00935926
		public unsafe int KeyType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_KeyType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_KeyType) = value;
			}
		}

		// Token: 0x17003BDA RID: 15322
		// (get) Token: 0x0601FDAC RID: 130476 RVA: 0x00937737 File Offset: 0x00935937
		// (set) Token: 0x0601FDAD RID: 130477 RVA: 0x00937747 File Offset: 0x00935947
		public unsafe int DisableKeyOnPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_DisableKeyOnPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_DisableKeyOnPercent) = value;
			}
		}

		// Token: 0x17003BDB RID: 15323
		// (get) Token: 0x0601FDAE RID: 130478 RVA: 0x00937758 File Offset: 0x00935958
		// (set) Token: 0x0601FDAF RID: 130479 RVA: 0x0093776C File Offset: 0x0093596C
		public unsafe FGameplayTag KeyEnableTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_KeyEnableTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_KeyEnableTag) = value;
			}
		}

		// Token: 0x17003BDC RID: 15324
		// (get) Token: 0x0601FDB0 RID: 130480 RVA: 0x00937784 File Offset: 0x00935984
		// (set) Token: 0x0601FDB1 RID: 130481 RVA: 0x009377C7 File Offset: 0x009359C7
		public TArray<SSpecialEnergyBarKey> KeyInfoList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSpecialEnergyBarKey> result;
				if ((result = this._KeyInfoList) == null)
				{
					result = (this._KeyInfoList = new TArray<SSpecialEnergyBarKey>(base.NativePtr + (IntPtr)SSpecialEnergyBar.__PropertyOffset_KeyInfoList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KeyInfoList.CopyAssign(value);
			}
		}

		// Token: 0x0601FDB2 RID: 130482 RVA: 0x009377D5 File Offset: 0x009359D5
		public SSpecialEnergyBar()
		{
		}

		// Token: 0x0601FDB3 RID: 130483 RVA: 0x009377DD File Offset: 0x009359DD
		protected override IntPtr GetUStructPtr()
		{
			return SSpecialEnergyBar.StaticStruct();
		}

		// Token: 0x0601FDB4 RID: 130484 RVA: 0x009377E9 File Offset: 0x009359E9
		[NullableContext(2)]
		public SSpecialEnergyBar(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FDB5 RID: 130485 RVA: 0x009377F3 File Offset: 0x009359F3
		public SSpecialEnergyBar(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FDB6 RID: 130486 RVA: 0x009377FE File Offset: 0x009359FE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSpecialEnergyBar(Pointer, false, true);
		}

		// Token: 0x0601FDB7 RID: 130487 RVA: 0x00937808 File Offset: 0x00935A08
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSpecialEnergyBar(Pointer, MemoryOwner);
		}

		// Token: 0x0401119A RID: 70042
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SSpecialEnergyBar.SSpecialEnergyBar";

		// Token: 0x0401119B RID: 70043
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401119C RID: 70044
		internal static int __PropertyOffset_Name;

		// Token: 0x0401119D RID: 70045
		internal static int __PropertyOffset_PrefabType;

		// Token: 0x0401119E RID: 70046
		internal static int __PropertyOffset_ExtraType;

		// Token: 0x0401119F RID: 70047
		internal static int __PropertyOffset_SlotNum;

		// Token: 0x040111A0 RID: 70048
		internal static int __PropertyOffset_ExtraFloatParams;

		// Token: 0x040111A1 RID: 70049
		[Nullable(2)]
		private TArray<float> _ExtraFloatParams;

		// Token: 0x040111A2 RID: 70050
		internal static int __PropertyOffset_PrefabPath;

		// Token: 0x040111A3 RID: 70051
		internal static int __PropertyOffset_AttributeId;

		// Token: 0x040111A4 RID: 70052
		internal static int __PropertyOffset_MaxAttributeId;

		// Token: 0x040111A5 RID: 70053
		internal static int __PropertyOffset_BuffId;

		// Token: 0x040111A6 RID: 70054
		internal static int __PropertyOffset_TagEnergyBarIdMap;

		// Token: 0x040111A7 RID: 70055
		[Nullable(2)]
		private TMap<FGameplayTag, int> _TagEnergyBarIdMap;

		// Token: 0x040111A8 RID: 70056
		internal static int __PropertyOffset_EffectColor;

		// Token: 0x040111A9 RID: 70057
		internal static int __PropertyOffset_PointColor;

		// Token: 0x040111AA RID: 70058
		internal static int __PropertyOffset_TexturePath;

		// Token: 0x040111AB RID: 70059
		internal static int __PropertyOffset_EnableTexturePath;

		// Token: 0x040111AC RID: 70060
		internal static int __PropertyOffset_FrontTexturePath;

		// Token: 0x040111AD RID: 70061
		internal static int __PropertyOffset_NiagaraList;

		// Token: 0x040111AE RID: 70062
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UNiagaraSystem>> _NiagaraList;

		// Token: 0x040111AF RID: 70063
		internal static int __PropertyOffset_KeyEnableNiagaraIndex;

		// Token: 0x040111B0 RID: 70064
		internal static int __PropertyOffset_KeyType;

		// Token: 0x040111B1 RID: 70065
		internal static int __PropertyOffset_DisableKeyOnPercent;

		// Token: 0x040111B2 RID: 70066
		internal static int __PropertyOffset_KeyEnableTag;

		// Token: 0x040111B3 RID: 70067
		internal static int __PropertyOffset_KeyInfoList;

		// Token: 0x040111B4 RID: 70068
		[Nullable(2)]
		private TArray<SSpecialEnergyBarKey> _KeyInfoList;
	}
}
