using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Entity.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Entity.Struct
{
	// Token: 0x02003220 RID: 12832
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Struct/SEntityConfig.SEntityConfig")]
	[UnrealStructLayout(672, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 668)]
	public class SEntityConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020026 RID: 131110 RVA: 0x0093B023 File Offset: 0x00939223
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEntityConfig._ScriptStructPtr != 0) ? SEntityConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Entity/Struct/SEntityConfig.SEntityConfig", ref SEntityConfig._ScriptStructPtr);
		}

		// Token: 0x17003CBD RID: 15549
		// (get) Token: 0x06020027 RID: 131111 RVA: 0x0093B047 File Offset: 0x00939247
		// (set) Token: 0x06020028 RID: 131112 RVA: 0x0093B057 File Offset: 0x00939257
		public unsafe int ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_ID) = value;
			}
		}

		// Token: 0x17003CBE RID: 15550
		// (get) Token: 0x06020029 RID: 131113 RVA: 0x0093B068 File Offset: 0x00939268
		// (set) Token: 0x0602002A RID: 131114 RVA: 0x0093B07C File Offset: 0x0093927C
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SEntityConfig.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SEntityConfig.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17003CBF RID: 15551
		// (get) Token: 0x0602002B RID: 131115 RVA: 0x0093B094 File Offset: 0x00939294
		// (set) Token: 0x0602002C RID: 131116 RVA: 0x0093B0D7 File Offset: 0x009392D7
		public unsafe FText Title
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Title) == null)
				{
					result = (this._Title = new FText(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_Title, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)SEntityConfig.__PropertyOffset_Title)), value.NativePtr, 1);
			}
		}

		// Token: 0x17003CC0 RID: 15552
		// (get) Token: 0x0602002D RID: 131117 RVA: 0x0093B0F2 File Offset: 0x009392F2
		// (set) Token: 0x0602002E RID: 131118 RVA: 0x0093B102 File Offset: 0x00939302
		public unsafe int ModleId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_ModleId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_ModleId) = value;
			}
		}

		// Token: 0x17003CC1 RID: 15553
		// (get) Token: 0x0602002F RID: 131119 RVA: 0x0093B113 File Offset: 0x00939313
		// (set) Token: 0x06020030 RID: 131120 RVA: 0x0093B123 File Offset: 0x00939323
		public unsafe bool IsExchangeControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_IsExchangeControl) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_IsExchangeControl) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CC2 RID: 15554
		// (get) Token: 0x06020031 RID: 131121 RVA: 0x0093B134 File Offset: 0x00939334
		// (set) Token: 0x06020032 RID: 131122 RVA: 0x0093B177 File Offset: 0x00939377
		public TArray<FName> Tag
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Tag) == null)
				{
					result = (this._Tag = new TArray<FName>(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_Tag, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Tag.CopyAssign(value);
			}
		}

		// Token: 0x17003CC3 RID: 15555
		// (get) Token: 0x06020033 RID: 131123 RVA: 0x0093B188 File Offset: 0x00939388
		// (set) Token: 0x06020034 RID: 131124 RVA: 0x0093B1CB File Offset: 0x009393CB
		public TArray<FName> InteractionId
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._InteractionId) == null)
				{
					result = (this._InteractionId = new TArray<FName>(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_InteractionId, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InteractionId.CopyAssign(value);
			}
		}

		// Token: 0x17003CC4 RID: 15556
		// (get) Token: 0x06020035 RID: 131125 RVA: 0x0093B1D9 File Offset: 0x009393D9
		// (set) Token: 0x06020036 RID: 131126 RVA: 0x0093B1E9 File Offset: 0x009393E9
		public unsafe int AiControllerId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_AiControllerId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_AiControllerId) = value;
			}
		}

		// Token: 0x17003CC5 RID: 15557
		// (get) Token: 0x06020037 RID: 131127 RVA: 0x0093B1FA File Offset: 0x009393FA
		// (set) Token: 0x06020038 RID: 131128 RVA: 0x0093B20A File Offset: 0x0093940A
		public unsafe int PropertyId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_PropertyId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_PropertyId) = value;
			}
		}

		// Token: 0x17003CC6 RID: 15558
		// (get) Token: 0x06020039 RID: 131129 RVA: 0x0093B21B File Offset: 0x0093941B
		// (set) Token: 0x0602003A RID: 131130 RVA: 0x0093B22F File Offset: 0x0093942F
		public unsafe FName StateType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_StateType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_StateType) = value;
			}
		}

		// Token: 0x17003CC7 RID: 15559
		// (get) Token: 0x0602003B RID: 131131 RVA: 0x0093B244 File Offset: 0x00939444
		// (set) Token: 0x0602003C RID: 131132 RVA: 0x0093B263 File Offset: 0x00939463
		public TSoftObjectPtr<UTexture> MapMarkId
		{
			get
			{
				return new TSoftObjectPtr<UTexture>(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_MapMarkId, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_MapMarkId, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003CC8 RID: 15560
		// (get) Token: 0x0602003D RID: 131133 RVA: 0x0093B288 File Offset: 0x00939488
		// (set) Token: 0x0602003E RID: 131134 RVA: 0x0093B29C File Offset: 0x0093949C
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
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_SpEnergyBar);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_SpEnergyBar) = value;
			}
		}

		// Token: 0x17003CC9 RID: 15561
		// (get) Token: 0x0602003F RID: 131135 RVA: 0x0093B2B1 File Offset: 0x009394B1
		// (set) Token: 0x06020040 RID: 131136 RVA: 0x0093B2C5 File Offset: 0x009394C5
		[Nullable(0)]
		public unsafe TEnumAsByte<ECamp> Camp
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_Camp);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_Camp) = value;
			}
		}

		// Token: 0x17003CCA RID: 15562
		// (get) Token: 0x06020041 RID: 131137 RVA: 0x0093B2DA File Offset: 0x009394DA
		// (set) Token: 0x06020042 RID: 131138 RVA: 0x0093B2EE File Offset: 0x009394EE
		public unsafe string remarks
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SEntityConfig.__PropertyOffset_remarks)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SEntityConfig.__PropertyOffset_remarks)), value);
			}
		}

		// Token: 0x17003CCB RID: 15563
		// (get) Token: 0x06020043 RID: 131139 RVA: 0x0093B304 File Offset: 0x00939504
		// (set) Token: 0x06020044 RID: 131140 RVA: 0x0093B347 File Offset: 0x00939547
		public TArray<FName> Bones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Bones) == null)
				{
					result = (this._Bones = new TArray<FName>(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_Bones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Bones.CopyAssign(value);
			}
		}

		// Token: 0x17003CCC RID: 15564
		// (get) Token: 0x06020045 RID: 131141 RVA: 0x0093B355 File Offset: 0x00939555
		// (set) Token: 0x06020046 RID: 131142 RVA: 0x0093B365 File Offset: 0x00939565
		public unsafe int FocusPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_FocusPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_FocusPriority) = value;
			}
		}

		// Token: 0x17003CCD RID: 15565
		// (get) Token: 0x06020047 RID: 131143 RVA: 0x0093B378 File Offset: 0x00939578
		// (set) Token: 0x06020048 RID: 131144 RVA: 0x0093B3BB File Offset: 0x009395BB
		public TMap<int, int> DropConfig
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._DropConfig) == null)
				{
					result = (this._DropConfig = new TMap<int, int>(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_DropConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DropConfig.CopyAssign(value);
			}
		}

		// Token: 0x17003CCE RID: 15566
		// (get) Token: 0x06020049 RID: 131145 RVA: 0x0093B3C9 File Offset: 0x009395C9
		// (set) Token: 0x0602004A RID: 131146 RVA: 0x0093B3D9 File Offset: 0x009395D9
		public unsafe int EntityPropertyID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_EntityPropertyID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_EntityPropertyID) = value;
			}
		}

		// Token: 0x17003CCF RID: 15567
		// (get) Token: 0x0602004B RID: 131147 RVA: 0x0093B3EA File Offset: 0x009395EA
		// (set) Token: 0x0602004C RID: 131148 RVA: 0x0093B3FA File Offset: 0x009395FA
		public unsafe int RageModeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_RageModeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_RageModeId) = value;
			}
		}

		// Token: 0x17003CD0 RID: 15568
		// (get) Token: 0x0602004D RID: 131149 RVA: 0x0093B40B File Offset: 0x0093960B
		// (set) Token: 0x0602004E RID: 131150 RVA: 0x0093B41B File Offset: 0x0093961B
		public unsafe int HardnessModeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_HardnessModeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_HardnessModeId) = value;
			}
		}

		// Token: 0x17003CD1 RID: 15569
		// (get) Token: 0x0602004F RID: 131151 RVA: 0x0093B42C File Offset: 0x0093962C
		// (set) Token: 0x06020050 RID: 131152 RVA: 0x0093B43C File Offset: 0x0093963C
		public unsafe bool BeHitIgnoreRotate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_BeHitIgnoreRotate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_BeHitIgnoreRotate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CD2 RID: 15570
		// (get) Token: 0x06020051 RID: 131153 RVA: 0x0093B450 File Offset: 0x00939650
		// (set) Token: 0x06020052 RID: 131154 RVA: 0x0093B493 File Offset: 0x00939693
		public TMap<int, int> SceneOwnerDropConfig
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._SceneOwnerDropConfig) == null)
				{
					result = (this._SceneOwnerDropConfig = new TMap<int, int>(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_SceneOwnerDropConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SceneOwnerDropConfig.CopyAssign(value);
			}
		}

		// Token: 0x17003CD3 RID: 15571
		// (get) Token: 0x06020053 RID: 131155 RVA: 0x0093B4A1 File Offset: 0x009396A1
		// (set) Token: 0x06020054 RID: 131156 RVA: 0x0093B4B5 File Offset: 0x009396B5
		[Nullable(0)]
		public unsafe TEnumAsByte<EBossStateViewType> BossStateViewType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_BossStateViewType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_BossStateViewType) = value;
			}
		}

		// Token: 0x17003CD4 RID: 15572
		// (get) Token: 0x06020055 RID: 131157 RVA: 0x0093B4CA File Offset: 0x009396CA
		// (set) Token: 0x06020056 RID: 131158 RVA: 0x0093B4DE File Offset: 0x009396DE
		public unsafe FName HeadStateSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_HeadStateSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_HeadStateSocketName) = value;
			}
		}

		// Token: 0x17003CD5 RID: 15573
		// (get) Token: 0x06020057 RID: 131159 RVA: 0x0093B4F3 File Offset: 0x009396F3
		// (set) Token: 0x06020058 RID: 131160 RVA: 0x0093B503 File Offset: 0x00939703
		public unsafe int HeadStateZOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_HeadStateZOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_HeadStateZOffset) = value;
			}
		}

		// Token: 0x17003CD6 RID: 15574
		// (get) Token: 0x06020059 RID: 131161 RVA: 0x0093B514 File Offset: 0x00939714
		// (set) Token: 0x0602005A RID: 131162 RVA: 0x0093B524 File Offset: 0x00939724
		public unsafe int HeadStateForwardOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_HeadStateForwardOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_HeadStateForwardOffset) = value;
			}
		}

		// Token: 0x17003CD7 RID: 15575
		// (get) Token: 0x0602005B RID: 131163 RVA: 0x0093B535 File Offset: 0x00939735
		// (set) Token: 0x0602005C RID: 131164 RVA: 0x0093B545 File Offset: 0x00939745
		public unsafe int SceneItemFunctionID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_SceneItemFunctionID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_SceneItemFunctionID) = value;
			}
		}

		// Token: 0x17003CD8 RID: 15576
		// (get) Token: 0x0602005D RID: 131165 RVA: 0x0093B558 File Offset: 0x00939758
		// (set) Token: 0x0602005E RID: 131166 RVA: 0x0093B59B File Offset: 0x0093979B
		public SAiWeaponSocket AiWeaponSocket
		{
			get
			{
				base.FastCheckIsValid();
				SAiWeaponSocket result;
				if ((result = this._AiWeaponSocket) == null)
				{
					result = (this._AiWeaponSocket = new SAiWeaponSocket(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_AiWeaponSocket, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiWeaponSocket.StaticStruct(), base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_AiWeaponSocket, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003CD9 RID: 15577
		// (get) Token: 0x0602005F RID: 131167 RVA: 0x0093B5BC File Offset: 0x009397BC
		// (set) Token: 0x06020060 RID: 131168 RVA: 0x0093B5CC File Offset: 0x009397CC
		public unsafe int AiWeaponConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_AiWeaponConfigId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_AiWeaponConfigId) = value;
			}
		}

		// Token: 0x17003CDA RID: 15578
		// (get) Token: 0x06020061 RID: 131169 RVA: 0x0093B5DD File Offset: 0x009397DD
		// (set) Token: 0x06020062 RID: 131170 RVA: 0x0093B5ED File Offset: 0x009397ED
		public unsafe int ForceLockOnCoefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_ForceLockOnCoefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_ForceLockOnCoefficient) = value;
			}
		}

		// Token: 0x17003CDB RID: 15579
		// (get) Token: 0x06020063 RID: 131171 RVA: 0x0093B5FE File Offset: 0x009397FE
		// (set) Token: 0x06020064 RID: 131172 RVA: 0x0093B60E File Offset: 0x0093980E
		public unsafe int NpcMessageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_NpcMessageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_NpcMessageId) = value;
			}
		}

		// Token: 0x17003CDC RID: 15580
		// (get) Token: 0x06020065 RID: 131173 RVA: 0x0093B620 File Offset: 0x00939820
		// (set) Token: 0x06020066 RID: 131174 RVA: 0x0093B663 File Offset: 0x00939863
		public TMap<string, string> param
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._param) == null)
				{
					result = (this._param = new TMap<string, string>(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_param, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.param.CopyAssign(value);
			}
		}

		// Token: 0x17003CDD RID: 15581
		// (get) Token: 0x06020067 RID: 131175 RVA: 0x0093B671 File Offset: 0x00939871
		// (set) Token: 0x06020068 RID: 131176 RVA: 0x0093B681 File Offset: 0x00939881
		public unsafe int AOILOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_AOILOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_AOILOD) = value;
			}
		}

		// Token: 0x17003CDE RID: 15582
		// (get) Token: 0x06020069 RID: 131177 RVA: 0x0093B694 File Offset: 0x00939894
		// (set) Token: 0x0602006A RID: 131178 RVA: 0x0093B6D7 File Offset: 0x009398D7
		public TArray<long> BornBuff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._BornBuff) == null)
				{
					result = (this._BornBuff = new TArray<long>(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_BornBuff, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BornBuff.CopyAssign(value);
			}
		}

		// Token: 0x17003CDF RID: 15583
		// (get) Token: 0x0602006B RID: 131179 RVA: 0x0093B6E5 File Offset: 0x009398E5
		// (set) Token: 0x0602006C RID: 131180 RVA: 0x0093B6F5 File Offset: 0x009398F5
		public unsafe float AffectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_AffectDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityConfig.__PropertyOffset_AffectDistance) = value;
			}
		}

		// Token: 0x0602006D RID: 131181 RVA: 0x0093B706 File Offset: 0x00939906
		public SEntityConfig()
		{
		}

		// Token: 0x0602006E RID: 131182 RVA: 0x0093B70E File Offset: 0x0093990E
		protected override IntPtr GetUStructPtr()
		{
			return SEntityConfig.StaticStruct();
		}

		// Token: 0x0602006F RID: 131183 RVA: 0x0093B71A File Offset: 0x0093991A
		[NullableContext(2)]
		public SEntityConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020070 RID: 131184 RVA: 0x0093B724 File Offset: 0x00939924
		public SEntityConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020071 RID: 131185 RVA: 0x0093B72F File Offset: 0x0093992F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SEntityConfig(Pointer, false, true);
		}

		// Token: 0x06020072 RID: 131186 RVA: 0x0093B739 File Offset: 0x00939939
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SEntityConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401132B RID: 70443
		public const string __ObjectPath = "/Game/Aki/Data/Entity/Struct/SEntityConfig.SEntityConfig";

		// Token: 0x0401132C RID: 70444
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401132D RID: 70445
		internal static int __PropertyOffset_ID;

		// Token: 0x0401132E RID: 70446
		internal static int __PropertyOffset_Name;

		// Token: 0x0401132F RID: 70447
		internal static int __PropertyOffset_Title;

		// Token: 0x04011330 RID: 70448
		[Nullable(2)]
		private FText _Title;

		// Token: 0x04011331 RID: 70449
		internal static int __PropertyOffset_ModleId;

		// Token: 0x04011332 RID: 70450
		internal static int __PropertyOffset_IsExchangeControl;

		// Token: 0x04011333 RID: 70451
		internal static int __PropertyOffset_Tag;

		// Token: 0x04011334 RID: 70452
		[Nullable(2)]
		private TArray<FName> _Tag;

		// Token: 0x04011335 RID: 70453
		internal static int __PropertyOffset_InteractionId;

		// Token: 0x04011336 RID: 70454
		[Nullable(2)]
		private TArray<FName> _InteractionId;

		// Token: 0x04011337 RID: 70455
		internal static int __PropertyOffset_AiControllerId;

		// Token: 0x04011338 RID: 70456
		internal static int __PropertyOffset_PropertyId;

		// Token: 0x04011339 RID: 70457
		internal static int __PropertyOffset_StateType;

		// Token: 0x0401133A RID: 70458
		internal static int __PropertyOffset_MapMarkId;

		// Token: 0x0401133B RID: 70459
		internal static int __PropertyOffset_SpEnergyBar;

		// Token: 0x0401133C RID: 70460
		internal static int __PropertyOffset_Camp;

		// Token: 0x0401133D RID: 70461
		internal static int __PropertyOffset_remarks;

		// Token: 0x0401133E RID: 70462
		internal static int __PropertyOffset_Bones;

		// Token: 0x0401133F RID: 70463
		[Nullable(2)]
		private TArray<FName> _Bones;

		// Token: 0x04011340 RID: 70464
		internal static int __PropertyOffset_FocusPriority;

		// Token: 0x04011341 RID: 70465
		internal static int __PropertyOffset_DropConfig;

		// Token: 0x04011342 RID: 70466
		[Nullable(2)]
		private TMap<int, int> _DropConfig;

		// Token: 0x04011343 RID: 70467
		internal static int __PropertyOffset_EntityPropertyID;

		// Token: 0x04011344 RID: 70468
		internal static int __PropertyOffset_RageModeId;

		// Token: 0x04011345 RID: 70469
		internal static int __PropertyOffset_HardnessModeId;

		// Token: 0x04011346 RID: 70470
		internal static int __PropertyOffset_BeHitIgnoreRotate;

		// Token: 0x04011347 RID: 70471
		internal static int __PropertyOffset_SceneOwnerDropConfig;

		// Token: 0x04011348 RID: 70472
		[Nullable(2)]
		private TMap<int, int> _SceneOwnerDropConfig;

		// Token: 0x04011349 RID: 70473
		internal static int __PropertyOffset_BossStateViewType;

		// Token: 0x0401134A RID: 70474
		internal static int __PropertyOffset_HeadStateSocketName;

		// Token: 0x0401134B RID: 70475
		internal static int __PropertyOffset_HeadStateZOffset;

		// Token: 0x0401134C RID: 70476
		internal static int __PropertyOffset_HeadStateForwardOffset;

		// Token: 0x0401134D RID: 70477
		internal static int __PropertyOffset_SceneItemFunctionID;

		// Token: 0x0401134E RID: 70478
		internal static int __PropertyOffset_AiWeaponSocket;

		// Token: 0x0401134F RID: 70479
		[Nullable(2)]
		private SAiWeaponSocket _AiWeaponSocket;

		// Token: 0x04011350 RID: 70480
		internal static int __PropertyOffset_AiWeaponConfigId;

		// Token: 0x04011351 RID: 70481
		internal static int __PropertyOffset_ForceLockOnCoefficient;

		// Token: 0x04011352 RID: 70482
		internal static int __PropertyOffset_NpcMessageId;

		// Token: 0x04011353 RID: 70483
		internal static int __PropertyOffset_param;

		// Token: 0x04011354 RID: 70484
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _param;

		// Token: 0x04011355 RID: 70485
		internal static int __PropertyOffset_AOILOD;

		// Token: 0x04011356 RID: 70486
		internal static int __PropertyOffset_BornBuff;

		// Token: 0x04011357 RID: 70487
		[Nullable(2)]
		private TArray<long> _BornBuff;

		// Token: 0x04011358 RID: 70488
		internal static int __PropertyOffset_AffectDistance;
	}
}
