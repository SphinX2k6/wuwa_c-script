using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Entity.Enum;
using AkiClient.Game.Aki.GamePlay;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Entity.Struct
{
	// Token: 0x02003F8B RID: 16267
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Struct/SEntityConfig.SEntityConfig")]
	[UnrealStructLayout(672, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 668)]
	public class SEntityConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029893 RID: 170131 RVA: 0x009C68FB File Offset: 0x009C4AFB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEntityConfig._ScriptStructPtr != 0) ? SEntityConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Entity/Struct/SEntityConfig.SEntityConfig", ref SEntityConfig._ScriptStructPtr);
		}

		// Token: 0x170063C8 RID: 25544
		// (get) Token: 0x06029894 RID: 170132 RVA: 0x009C691F File Offset: 0x009C4B1F
		// (set) Token: 0x06029895 RID: 170133 RVA: 0x009C692F File Offset: 0x009C4B2F
		public unsafe int ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170063C9 RID: 25545
		// (get) Token: 0x06029896 RID: 170134 RVA: 0x009C6940 File Offset: 0x009C4B40
		// (set) Token: 0x06029897 RID: 170135 RVA: 0x009C6954 File Offset: 0x009C4B54
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SEntityConfig.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SEntityConfig.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x170063CA RID: 25546
		// (get) Token: 0x06029898 RID: 170136 RVA: 0x009C6969 File Offset: 0x009C4B69
		// (set) Token: 0x06029899 RID: 170137 RVA: 0x009C697D File Offset: 0x009C4B7D
		[Nullable(0)]
		public unsafe TEnumAsByte<EEntityType> EntityType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_2);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170063CB RID: 25547
		// (get) Token: 0x0602989A RID: 170138 RVA: 0x009C6994 File Offset: 0x009C4B94
		// (set) Token: 0x0602989B RID: 170139 RVA: 0x009C69D7 File Offset: 0x009C4BD7
		public unsafe FText Title
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Title) == null)
				{
					result = (this._Title = new FText(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)SEntityConfig.__PropertyOffset_3)), value.NativePtr, 1);
			}
		}

		// Token: 0x170063CC RID: 25548
		// (get) Token: 0x0602989C RID: 170140 RVA: 0x009C69F2 File Offset: 0x009C4BF2
		// (set) Token: 0x0602989D RID: 170141 RVA: 0x009C6A02 File Offset: 0x009C4C02
		public unsafe int ModleId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170063CD RID: 25549
		// (get) Token: 0x0602989E RID: 170142 RVA: 0x009C6A13 File Offset: 0x009C4C13
		// (set) Token: 0x0602989F RID: 170143 RVA: 0x009C6A23 File Offset: 0x009C4C23
		public unsafe bool IsExchangeControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170063CE RID: 25550
		// (get) Token: 0x060298A0 RID: 170144 RVA: 0x009C6A34 File Offset: 0x009C4C34
		// (set) Token: 0x060298A1 RID: 170145 RVA: 0x009C6A77 File Offset: 0x009C4C77
		public TArray<FName> Tag
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Tag) == null)
				{
					result = (this._Tag = new TArray<FName>(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Tag.CopyAssign(value);
			}
		}

		// Token: 0x170063CF RID: 25551
		// (get) Token: 0x060298A2 RID: 170146 RVA: 0x009C6A88 File Offset: 0x009C4C88
		// (set) Token: 0x060298A3 RID: 170147 RVA: 0x009C6ACB File Offset: 0x009C4CCB
		public TArray<FName> InteractionId
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._InteractionId) == null)
				{
					result = (this._InteractionId = new TArray<FName>(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InteractionId.CopyAssign(value);
			}
		}

		// Token: 0x170063D0 RID: 25552
		// (get) Token: 0x060298A4 RID: 170148 RVA: 0x009C6AD9 File Offset: 0x009C4CD9
		// (set) Token: 0x060298A5 RID: 170149 RVA: 0x009C6AE9 File Offset: 0x009C4CE9
		public unsafe int AiControllerId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170063D1 RID: 25553
		// (get) Token: 0x060298A6 RID: 170150 RVA: 0x009C6AFA File Offset: 0x009C4CFA
		// (set) Token: 0x060298A7 RID: 170151 RVA: 0x009C6B0A File Offset: 0x009C4D0A
		public unsafe int PropertyId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170063D2 RID: 25554
		// (get) Token: 0x060298A8 RID: 170152 RVA: 0x009C6B1B File Offset: 0x009C4D1B
		// (set) Token: 0x060298A9 RID: 170153 RVA: 0x009C6B2F File Offset: 0x009C4D2F
		public unsafe FName StateType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170063D3 RID: 25555
		// (get) Token: 0x060298AA RID: 170154 RVA: 0x009C6B44 File Offset: 0x009C4D44
		// (set) Token: 0x060298AB RID: 170155 RVA: 0x009C6B63 File Offset: 0x009C4D63
		public TSoftObjectPtr<UTexture> MapMarkId
		{
			get
			{
				return new TSoftObjectPtr<UTexture>(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_11, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_11, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170063D4 RID: 25556
		// (get) Token: 0x060298AC RID: 170156 RVA: 0x009C6B88 File Offset: 0x009C4D88
		// (set) Token: 0x060298AD RID: 170157 RVA: 0x009C6B9C File Offset: 0x009C4D9C
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UUserWidget> SpEnergyBar
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_12);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170063D5 RID: 25557
		// (get) Token: 0x060298AE RID: 170158 RVA: 0x009C6BB1 File Offset: 0x009C4DB1
		// (set) Token: 0x060298AF RID: 170159 RVA: 0x009C6BC5 File Offset: 0x009C4DC5
		[Nullable(0)]
		public unsafe TEnumAsByte<ECamp> Camp
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_13);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170063D6 RID: 25558
		// (get) Token: 0x060298B0 RID: 170160 RVA: 0x009C6BDA File Offset: 0x009C4DDA
		// (set) Token: 0x060298B1 RID: 170161 RVA: 0x009C6BEE File Offset: 0x009C4DEE
		public unsafe string remarks
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SEntityConfig.__PropertyOffset_14)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SEntityConfig.__PropertyOffset_14)), value);
			}
		}

		// Token: 0x170063D7 RID: 25559
		// (get) Token: 0x060298B2 RID: 170162 RVA: 0x009C6C04 File Offset: 0x009C4E04
		// (set) Token: 0x060298B3 RID: 170163 RVA: 0x009C6C47 File Offset: 0x009C4E47
		public TArray<FName> Bones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Bones) == null)
				{
					result = (this._Bones = new TArray<FName>(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_15, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Bones.CopyAssign(value);
			}
		}

		// Token: 0x170063D8 RID: 25560
		// (get) Token: 0x060298B4 RID: 170164 RVA: 0x009C6C55 File Offset: 0x009C4E55
		// (set) Token: 0x060298B5 RID: 170165 RVA: 0x009C6C65 File Offset: 0x009C4E65
		public unsafe int FocusPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170063D9 RID: 25561
		// (get) Token: 0x060298B6 RID: 170166 RVA: 0x009C6C78 File Offset: 0x009C4E78
		// (set) Token: 0x060298B7 RID: 170167 RVA: 0x009C6CBB File Offset: 0x009C4EBB
		public TMap<int, int> DropConfig
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._DropConfig) == null)
				{
					result = (this._DropConfig = new TMap<int, int>(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_17, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DropConfig.CopyAssign(value);
			}
		}

		// Token: 0x170063DA RID: 25562
		// (get) Token: 0x060298B8 RID: 170168 RVA: 0x009C6CC9 File Offset: 0x009C4EC9
		// (set) Token: 0x060298B9 RID: 170169 RVA: 0x009C6CD9 File Offset: 0x009C4ED9
		public unsafe int EntityPropertyID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170063DB RID: 25563
		// (get) Token: 0x060298BA RID: 170170 RVA: 0x009C6CEA File Offset: 0x009C4EEA
		// (set) Token: 0x060298BB RID: 170171 RVA: 0x009C6CFA File Offset: 0x009C4EFA
		public unsafe int RageModeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170063DC RID: 25564
		// (get) Token: 0x060298BC RID: 170172 RVA: 0x009C6D0B File Offset: 0x009C4F0B
		// (set) Token: 0x060298BD RID: 170173 RVA: 0x009C6D1B File Offset: 0x009C4F1B
		public unsafe int HardnessModeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170063DD RID: 25565
		// (get) Token: 0x060298BE RID: 170174 RVA: 0x009C6D2C File Offset: 0x009C4F2C
		// (set) Token: 0x060298BF RID: 170175 RVA: 0x009C6D3C File Offset: 0x009C4F3C
		public unsafe bool BeHitIgnoreRotate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x170063DE RID: 25566
		// (get) Token: 0x060298C0 RID: 170176 RVA: 0x009C6D50 File Offset: 0x009C4F50
		// (set) Token: 0x060298C1 RID: 170177 RVA: 0x009C6D93 File Offset: 0x009C4F93
		public TMap<int, int> SceneOwnerDropConfig
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._SceneOwnerDropConfig) == null)
				{
					result = (this._SceneOwnerDropConfig = new TMap<int, int>(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_22, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SceneOwnerDropConfig.CopyAssign(value);
			}
		}

		// Token: 0x170063DF RID: 25567
		// (get) Token: 0x060298C2 RID: 170178 RVA: 0x009C6DA1 File Offset: 0x009C4FA1
		// (set) Token: 0x060298C3 RID: 170179 RVA: 0x009C6DB5 File Offset: 0x009C4FB5
		[Nullable(0)]
		public unsafe TEnumAsByte<EBossStateViewType> BossStateViewType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_23);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170063E0 RID: 25568
		// (get) Token: 0x060298C4 RID: 170180 RVA: 0x009C6DCC File Offset: 0x009C4FCC
		// (set) Token: 0x060298C5 RID: 170181 RVA: 0x009C6E0F File Offset: 0x009C500F
		public TArray<SHardnessStageInfo> HardnessPercentStage
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SHardnessStageInfo> result;
				if ((result = this._HardnessPercentStage) == null)
				{
					result = (this._HardnessPercentStage = new TArray<SHardnessStageInfo>(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_24, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HardnessPercentStage.CopyAssign(value);
			}
		}

		// Token: 0x170063E1 RID: 25569
		// (get) Token: 0x060298C6 RID: 170182 RVA: 0x009C6E1D File Offset: 0x009C501D
		// (set) Token: 0x060298C7 RID: 170183 RVA: 0x009C6E31 File Offset: 0x009C5031
		[Nullable(0)]
		public unsafe TEnumAsByte<EHeadStateViewType> HeadStateViewType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_25);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170063E2 RID: 25570
		// (get) Token: 0x060298C8 RID: 170184 RVA: 0x009C6E46 File Offset: 0x009C5046
		// (set) Token: 0x060298C9 RID: 170185 RVA: 0x009C6E5A File Offset: 0x009C505A
		public unsafe FName HeadStateSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170063E3 RID: 25571
		// (get) Token: 0x060298CA RID: 170186 RVA: 0x009C6E6F File Offset: 0x009C506F
		// (set) Token: 0x060298CB RID: 170187 RVA: 0x009C6E7F File Offset: 0x009C507F
		public unsafe int HeadStateZOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x170063E4 RID: 25572
		// (get) Token: 0x060298CC RID: 170188 RVA: 0x009C6E90 File Offset: 0x009C5090
		// (set) Token: 0x060298CD RID: 170189 RVA: 0x009C6EA0 File Offset: 0x009C50A0
		public unsafe int HeadStateForwardOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x170063E5 RID: 25573
		// (get) Token: 0x060298CE RID: 170190 RVA: 0x009C6EB1 File Offset: 0x009C50B1
		// (set) Token: 0x060298CF RID: 170191 RVA: 0x009C6EC5 File Offset: 0x009C50C5
		[Nullable(0)]
		public unsafe TEnumAsByte<EGameplayFunctionType> SceneItemFunctionType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_29);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170063E6 RID: 25574
		// (get) Token: 0x060298D0 RID: 170192 RVA: 0x009C6EDA File Offset: 0x009C50DA
		// (set) Token: 0x060298D1 RID: 170193 RVA: 0x009C6EEA File Offset: 0x009C50EA
		public unsafe int SceneItemFunctionID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x170063E7 RID: 25575
		// (get) Token: 0x060298D2 RID: 170194 RVA: 0x009C6EFC File Offset: 0x009C50FC
		// (set) Token: 0x060298D3 RID: 170195 RVA: 0x009C6F3F File Offset: 0x009C513F
		public SAiWeaponSocket AiWeaponSocket
		{
			get
			{
				base.FastCheckIsValid();
				SAiWeaponSocket result;
				if ((result = this._AiWeaponSocket) == null)
				{
					result = (this._AiWeaponSocket = new SAiWeaponSocket(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_31, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiWeaponSocket.StaticStruct(), base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_31, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170063E8 RID: 25576
		// (get) Token: 0x060298D4 RID: 170196 RVA: 0x009C6F60 File Offset: 0x009C5160
		// (set) Token: 0x060298D5 RID: 170197 RVA: 0x009C6F70 File Offset: 0x009C5170
		public unsafe int AiWeaponConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x170063E9 RID: 25577
		// (get) Token: 0x060298D6 RID: 170198 RVA: 0x009C6F81 File Offset: 0x009C5181
		// (set) Token: 0x060298D7 RID: 170199 RVA: 0x009C6F91 File Offset: 0x009C5191
		public unsafe int ForceLockOnCoefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x170063EA RID: 25578
		// (get) Token: 0x060298D8 RID: 170200 RVA: 0x009C6FA2 File Offset: 0x009C51A2
		// (set) Token: 0x060298D9 RID: 170201 RVA: 0x009C6FB2 File Offset: 0x009C51B2
		public unsafe int NpcMessageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x170063EB RID: 25579
		// (get) Token: 0x060298DA RID: 170202 RVA: 0x009C6FC4 File Offset: 0x009C51C4
		// (set) Token: 0x060298DB RID: 170203 RVA: 0x009C7007 File Offset: 0x009C5207
		public TMap<string, string> param
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._param) == null)
				{
					result = (this._param = new TMap<string, string>(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_35, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.param.CopyAssign(value);
			}
		}

		// Token: 0x170063EC RID: 25580
		// (get) Token: 0x060298DC RID: 170204 RVA: 0x009C7015 File Offset: 0x009C5215
		// (set) Token: 0x060298DD RID: 170205 RVA: 0x009C7025 File Offset: 0x009C5225
		public unsafe int AOILOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x170063ED RID: 25581
		// (get) Token: 0x060298DE RID: 170206 RVA: 0x009C7038 File Offset: 0x009C5238
		// (set) Token: 0x060298DF RID: 170207 RVA: 0x009C707B File Offset: 0x009C527B
		public TArray<long> BornBuff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._BornBuff) == null)
				{
					result = (this._BornBuff = new TArray<long>(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_37, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BornBuff.CopyAssign(value);
			}
		}

		// Token: 0x170063EE RID: 25582
		// (get) Token: 0x060298E0 RID: 170208 RVA: 0x009C7089 File Offset: 0x009C5289
		// (set) Token: 0x060298E1 RID: 170209 RVA: 0x009C7099 File Offset: 0x009C5299
		public unsafe float AffectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x060298E2 RID: 170210 RVA: 0x009C70AA File Offset: 0x009C52AA
		public SEntityConfig()
		{
		}

		// Token: 0x060298E3 RID: 170211 RVA: 0x009C70B4 File Offset: 0x009C52B4
		public SEntityConfig(int ID, string Name, [Nullable(0)] TEnumAsByte<EEntityType> EntityType, FText Title, int ModleId, bool IsExchangeControl, TArray<FName> Tag, TArray<FName> InteractionId, int AiControllerId, int PropertyId, FName StateType, TSoftObjectPtr<UTexture> MapMarkId, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UUserWidget> SpEnergyBar, [Nullable(0)] TEnumAsByte<ECamp> Camp, string remarks, TArray<FName> Bones, int FocusPriority, TMap<int, int> DropConfig, int EntityPropertyID, int RageModeId, int HardnessModeId, bool BeHitIgnoreRotate, TMap<int, int> SceneOwnerDropConfig, [Nullable(0)] TEnumAsByte<EBossStateViewType> BossStateViewType, TArray<SHardnessStageInfo> HardnessPercentStage, [Nullable(0)] TEnumAsByte<EHeadStateViewType> HeadStateViewType, FName HeadStateSocketName, int HeadStateZOffset, int HeadStateForwardOffset, [Nullable(0)] TEnumAsByte<EGameplayFunctionType> SceneItemFunctionType, int SceneItemFunctionID, SAiWeaponSocket AiWeaponSocket, int AiWeaponConfigId, int ForceLockOnCoefficient, int NpcMessageId, TMap<string, string> param, int AOILOD, TArray<long> BornBuff, float AffectDistance)
		{
			this.ID = ID;
			this.Name = Name;
			this.EntityType = EntityType;
			this.Title = Title;
			this.ModleId = ModleId;
			this.IsExchangeControl = IsExchangeControl;
			this.Tag = Tag;
			this.InteractionId = InteractionId;
			this.AiControllerId = AiControllerId;
			this.PropertyId = PropertyId;
			this.StateType = StateType;
			this.MapMarkId = MapMarkId;
			this.SpEnergyBar = SpEnergyBar;
			this.Camp = Camp;
			this.remarks = remarks;
			this.Bones = Bones;
			this.FocusPriority = FocusPriority;
			this.DropConfig = DropConfig;
			this.EntityPropertyID = EntityPropertyID;
			this.RageModeId = RageModeId;
			this.HardnessModeId = HardnessModeId;
			this.BeHitIgnoreRotate = BeHitIgnoreRotate;
			this.SceneOwnerDropConfig = SceneOwnerDropConfig;
			this.BossStateViewType = BossStateViewType;
			this.HardnessPercentStage = HardnessPercentStage;
			this.HeadStateViewType = HeadStateViewType;
			this.HeadStateSocketName = HeadStateSocketName;
			this.HeadStateZOffset = HeadStateZOffset;
			this.HeadStateForwardOffset = HeadStateForwardOffset;
			this.SceneItemFunctionType = SceneItemFunctionType;
			this.SceneItemFunctionID = SceneItemFunctionID;
			this.AiWeaponSocket = AiWeaponSocket;
			this.AiWeaponConfigId = AiWeaponConfigId;
			this.ForceLockOnCoefficient = ForceLockOnCoefficient;
			this.NpcMessageId = NpcMessageId;
			this.param = param;
			this.AOILOD = AOILOD;
			this.BornBuff = BornBuff;
			this.AffectDistance = AffectDistance;
		}

		// Token: 0x060298E4 RID: 170212 RVA: 0x009C71FC File Offset: 0x009C53FC
		protected override IntPtr GetUStructPtr()
		{
			return SEntityConfig.StaticStruct();
		}

		// Token: 0x060298E5 RID: 170213 RVA: 0x009C7208 File Offset: 0x009C5408
		[NullableContext(2)]
		public SEntityConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060298E6 RID: 170214 RVA: 0x009C7212 File Offset: 0x009C5412
		public SEntityConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060298E7 RID: 170215 RVA: 0x009C721D File Offset: 0x009C541D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SEntityConfig(Pointer, false, true);
		}

		// Token: 0x060298E8 RID: 170216 RVA: 0x009C7227 File Offset: 0x009C5427
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SEntityConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040154AC RID: 87212
		public const string __ObjectPath = "/Game/Aki/Data/Entity/Struct/SEntityConfig.SEntityConfig";

		// Token: 0x040154AD RID: 87213
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040154AE RID: 87214
		internal static int __PropertyOffset_0;

		// Token: 0x040154AF RID: 87215
		internal static int __PropertyOffset_1;

		// Token: 0x040154B0 RID: 87216
		internal static int __PropertyOffset_2;

		// Token: 0x040154B1 RID: 87217
		internal static int __PropertyOffset_3;

		// Token: 0x040154B2 RID: 87218
		[Nullable(2)]
		private FText _Title;

		// Token: 0x040154B3 RID: 87219
		internal static int __PropertyOffset_4;

		// Token: 0x040154B4 RID: 87220
		internal static int __PropertyOffset_5;

		// Token: 0x040154B5 RID: 87221
		internal static int __PropertyOffset_6;

		// Token: 0x040154B6 RID: 87222
		[Nullable(2)]
		private TArray<FName> _Tag;

		// Token: 0x040154B7 RID: 87223
		internal static int __PropertyOffset_7;

		// Token: 0x040154B8 RID: 87224
		[Nullable(2)]
		private TArray<FName> _InteractionId;

		// Token: 0x040154B9 RID: 87225
		internal static int __PropertyOffset_8;

		// Token: 0x040154BA RID: 87226
		internal static int __PropertyOffset_9;

		// Token: 0x040154BB RID: 87227
		internal static int __PropertyOffset_10;

		// Token: 0x040154BC RID: 87228
		internal static int __PropertyOffset_11;

		// Token: 0x040154BD RID: 87229
		internal static int __PropertyOffset_12;

		// Token: 0x040154BE RID: 87230
		internal static int __PropertyOffset_13;

		// Token: 0x040154BF RID: 87231
		internal static int __PropertyOffset_14;

		// Token: 0x040154C0 RID: 87232
		internal static int __PropertyOffset_15;

		// Token: 0x040154C1 RID: 87233
		[Nullable(2)]
		private TArray<FName> _Bones;

		// Token: 0x040154C2 RID: 87234
		internal static int __PropertyOffset_16;

		// Token: 0x040154C3 RID: 87235
		internal static int __PropertyOffset_17;

		// Token: 0x040154C4 RID: 87236
		[Nullable(2)]
		private TMap<int, int> _DropConfig;

		// Token: 0x040154C5 RID: 87237
		internal static int __PropertyOffset_18;

		// Token: 0x040154C6 RID: 87238
		internal static int __PropertyOffset_19;

		// Token: 0x040154C7 RID: 87239
		internal static int __PropertyOffset_20;

		// Token: 0x040154C8 RID: 87240
		internal static int __PropertyOffset_21;

		// Token: 0x040154C9 RID: 87241
		internal static int __PropertyOffset_22;

		// Token: 0x040154CA RID: 87242
		[Nullable(2)]
		private TMap<int, int> _SceneOwnerDropConfig;

		// Token: 0x040154CB RID: 87243
		internal static int __PropertyOffset_23;

		// Token: 0x040154CC RID: 87244
		internal static int __PropertyOffset_24;

		// Token: 0x040154CD RID: 87245
		[Nullable(2)]
		private TArray<SHardnessStageInfo> _HardnessPercentStage;

		// Token: 0x040154CE RID: 87246
		internal static int __PropertyOffset_25;

		// Token: 0x040154CF RID: 87247
		internal static int __PropertyOffset_26;

		// Token: 0x040154D0 RID: 87248
		internal static int __PropertyOffset_27;

		// Token: 0x040154D1 RID: 87249
		internal static int __PropertyOffset_28;

		// Token: 0x040154D2 RID: 87250
		internal static int __PropertyOffset_29;

		// Token: 0x040154D3 RID: 87251
		internal static int __PropertyOffset_30;

		// Token: 0x040154D4 RID: 87252
		internal static int __PropertyOffset_31;

		// Token: 0x040154D5 RID: 87253
		[Nullable(2)]
		private SAiWeaponSocket _AiWeaponSocket;

		// Token: 0x040154D6 RID: 87254
		internal static int __PropertyOffset_32;

		// Token: 0x040154D7 RID: 87255
		internal static int __PropertyOffset_33;

		// Token: 0x040154D8 RID: 87256
		internal static int __PropertyOffset_34;

		// Token: 0x040154D9 RID: 87257
		internal static int __PropertyOffset_35;

		// Token: 0x040154DA RID: 87258
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _param;

		// Token: 0x040154DB RID: 87259
		internal static int __PropertyOffset_36;

		// Token: 0x040154DC RID: 87260
		internal static int __PropertyOffset_37;

		// Token: 0x040154DD RID: 87261
		[Nullable(2)]
		private TArray<long> _BornBuff;

		// Token: 0x040154DE RID: 87262
		internal static int __PropertyOffset_38;
	}
}
