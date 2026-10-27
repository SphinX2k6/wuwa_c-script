using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005632 RID: 22066
	public struct INpcPerformComponent : IFlatbufferObject
	{
		// Token: 0x1700A34B RID: 41803
		// (get) Token: 0x06024A2F RID: 150063 RVA: 0x0050DD4C File Offset: 0x0050BF4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024A30 RID: 150064 RVA: 0x0050DD59 File Offset: 0x0050BF59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024A31 RID: 150065 RVA: 0x0050DD60 File Offset: 0x0050BF60
		public static INpcPerformComponent GetRootAsINpcPerformComponent(ByteBuffer _bb)
		{
			return INpcPerformComponent.GetRootAsINpcPerformComponent(_bb, default(INpcPerformComponent));
		}

		// Token: 0x06024A32 RID: 150066 RVA: 0x0050DD7C File Offset: 0x0050BF7C
		public static INpcPerformComponent GetRootAsINpcPerformComponent(ByteBuffer _bb, INpcPerformComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024A33 RID: 150067 RVA: 0x0050DD99 File Offset: 0x0050BF99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024A34 RID: 150068 RVA: 0x0050DDA8 File Offset: 0x0050BFA8
		public INpcPerformComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A34C RID: 41804
		// (get) Token: 0x06024A35 RID: 150069 RVA: 0x0050DDB8 File Offset: 0x0050BFB8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A34D RID: 41805
		// (get) Token: 0x06024A36 RID: 150070 RVA: 0x0050DDF8 File Offset: 0x0050BFF8
		public IBaseRoleNpcPerform? SpecialNpcPerformConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IBaseRoleNpcPerform?(default(IBaseRoleNpcPerform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A34E RID: 41806
		// (get) Token: 0x06024A37 RID: 150071 RVA: 0x0050DE58 File Offset: 0x0050C058
		public bool IsStare
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A34F RID: 41807
		// (get) Token: 0x06024A38 RID: 150072 RVA: 0x0050DE98 File Offset: 0x0050C098
		public INpcHitShow? NpcHitShow
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new INpcHitShow?(default(INpcHitShow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A350 RID: 41808
		// (get) Token: 0x06024A39 RID: 150073 RVA: 0x0050DEF8 File Offset: 0x0050C0F8
		public bool IsShowStrike
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A351 RID: 41809
		// (get) Token: 0x06024A3A RID: 150074 RVA: 0x0050DF38 File Offset: 0x0050C138
		public INpcBumpShow? NpcBumpShow
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new INpcBumpShow?(default(INpcBumpShow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A352 RID: 41810
		// (get) Token: 0x06024A3B RID: 150075 RVA: 0x0050DF98 File Offset: 0x0050C198
		public INpcAwakeShow? ShowOnAwake
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new INpcAwakeShow?(default(INpcAwakeShow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A353 RID: 41811
		// (get) Token: 0x06024A3C RID: 150076 RVA: 0x0050DFF8 File Offset: 0x0050C1F8
		public TNpcStandbyShowOption ShowOnStandbyType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return TNpcStandbyShowOption.NONE;
				}
				return (TNpcStandbyShowOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024A3D RID: 150077 RVA: 0x0050E038 File Offset: 0x0050C238
		public TTable? ShowOnStandby<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024A3E RID: 150078 RVA: 0x0050E080 File Offset: 0x0050C280
		public INpcStandbyShowFinitely ShowOnStandbyAsINpcStandbyShowFinitely()
		{
			return this.ShowOnStandby<INpcStandbyShowFinitely>().Value;
		}

		// Token: 0x06024A3F RID: 150079 RVA: 0x0050E09C File Offset: 0x0050C29C
		public INpcStandbyShowLooply ShowOnStandbyAsINpcStandbyShowLooply()
		{
			return this.ShowOnStandby<INpcStandbyShowLooply>().Value;
		}

		// Token: 0x06024A40 RID: 150080 RVA: 0x0050E0B8 File Offset: 0x0050C2B8
		public INpcStandbySit ShowOnStandbyAsINpcStandbySit()
		{
			return this.ShowOnStandby<INpcStandbySit>().Value;
		}

		// Token: 0x1700A354 RID: 41812
		// (get) Token: 0x06024A41 RID: 150081 RVA: 0x0050E0D4 File Offset: 0x0050C2D4
		public INpcPerformOnInteract? ShowOnInteract
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new INpcPerformOnInteract?(default(INpcPerformOnInteract).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024A42 RID: 150082 RVA: 0x0050E134 File Offset: 0x0050C334
		public IConditionalNpcPerformOnInteract? ConditionalShowOnInteracts(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new IConditionalNpcPerformOnInteract?(default(IConditionalNpcPerformOnInteract).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A355 RID: 41813
		// (get) Token: 0x06024A43 RID: 150083 RVA: 0x0050E198 File Offset: 0x0050C398
		public int ConditionalShowOnInteractsLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A356 RID: 41814
		// (get) Token: 0x06024A44 RID: 150084 RVA: 0x0050E1C4 File Offset: 0x0050C3C4
		public TNpcUiInteractOption ShowOnUiInteractType
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return TNpcUiInteractOption.NONE;
				}
				return (TNpcUiInteractOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024A45 RID: 150085 RVA: 0x0050E204 File Offset: 0x0050C404
		public TTable? ShowOnUiInteract<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024A46 RID: 150086 RVA: 0x0050E24C File Offset: 0x0050C44C
		public INpcUiInteractOnAntiqueShop ShowOnUiInteractAsINpcUiInteractOnAntiqueShop()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnAntiqueShop>().Value;
		}

		// Token: 0x06024A47 RID: 150087 RVA: 0x0050E268 File Offset: 0x0050C468
		public INpcUiInteractOnChengXiaoShanShop ShowOnUiInteractAsINpcUiInteractOnChengXiaoShanShop()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnChengXiaoShanShop>().Value;
		}

		// Token: 0x06024A48 RID: 150088 RVA: 0x0050E284 File Offset: 0x0050C484
		public INpcUiInteractOnDollGrabDelivery ShowOnUiInteractAsINpcUiInteractOnDollGrabDelivery()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnDollGrabDelivery>().Value;
		}

		// Token: 0x06024A49 RID: 150089 RVA: 0x0050E2A0 File Offset: 0x0050C4A0
		public INpcUiInteractOnGramophone ShowOnUiInteractAsINpcUiInteractOnGramophone()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnGramophone>().Value;
		}

		// Token: 0x06024A4A RID: 150090 RVA: 0x0050E2BC File Offset: 0x0050C4BC
		public INpcUiInteractOnHandInItem ShowOnUiInteractAsINpcUiInteractOnHandInItem()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnHandInItem>().Value;
		}

		// Token: 0x06024A4B RID: 150091 RVA: 0x0050E2D8 File Offset: 0x0050C4D8
		public INpcUiInteractOnShop ShowOnUiInteractAsINpcUiInteractOnShop()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnShop>().Value;
		}

		// Token: 0x06024A4C RID: 150092 RVA: 0x0050E2F4 File Offset: 0x0050C4F4
		public INpcUiInteractOnShopNew ShowOnUiInteractAsINpcUiInteractOnShopNew()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnShopNew>().Value;
		}

		// Token: 0x06024A4D RID: 150093 RVA: 0x0050E310 File Offset: 0x0050C510
		public INpcUiInteractOnSoundBox3 ShowOnUiInteractAsINpcUiInteractOnSoundBox3()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnSoundBox3>().Value;
		}

		// Token: 0x06024A4E RID: 150094 RVA: 0x0050E32C File Offset: 0x0050C52C
		public INpcUiInteractOnSoundBox35 ShowOnUiInteractAsINpcUiInteractOnSoundBox35()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnSoundBox35>().Value;
		}

		// Token: 0x06024A4F RID: 150095 RVA: 0x0050E348 File Offset: 0x0050C548
		public INpcUiInteractOnSunSpirit ShowOnUiInteractAsINpcUiInteractOnSunSpirit()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnSunSpirit>().Value;
		}

		// Token: 0x06024A50 RID: 150096 RVA: 0x0050E364 File Offset: 0x0050C564
		public INpcUiInteractOnVillageInfr ShowOnUiInteractAsINpcUiInteractOnVillageInfr()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnVillageInfr>().Value;
		}

		// Token: 0x06024A51 RID: 150097 RVA: 0x0050E380 File Offset: 0x0050C580
		public TNpcRideInVehiclePerformType ShowOnRideInVehicleType(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return TNpcRideInVehiclePerformType.NONE;
			}
			return (TNpcRideInVehiclePerformType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700A357 RID: 41815
		// (get) Token: 0x06024A52 RID: 150098 RVA: 0x0050E3C0 File Offset: 0x0050C5C0
		public int ShowOnRideInVehicleTypeLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06024A53 RID: 150099 RVA: 0x0050E3EC File Offset: 0x0050C5EC
		public Span<TNpcRideInVehiclePerformType> GetShowOnRideInVehicleTypeBytes()
		{
			return this.__p.__vector_as_span<TNpcRideInVehiclePerformType>(30, 1);
		}

		// Token: 0x06024A54 RID: 150100 RVA: 0x0050E3FC File Offset: 0x0050C5FC
		public TNpcRideInVehiclePerformType[] GetShowOnRideInVehicleTypeArray()
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TNpcRideInVehiclePerformType[] array = new TNpcRideInVehiclePerformType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TNpcRideInVehiclePerformType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06024A55 RID: 150101 RVA: 0x0050E468 File Offset: 0x0050C668
		public TTable? ShowOnRideInVehicle<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700A358 RID: 41816
		// (get) Token: 0x06024A56 RID: 150102 RVA: 0x0050E4B0 File Offset: 0x0050C6B0
		public int ShowOnRideInVehicleLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A359 RID: 41817
		// (get) Token: 0x06024A57 RID: 150103 RVA: 0x0050E4DC File Offset: 0x0050C6DC
		public INpcPerformOnMonsterCloseby? NpcMonsterClosePerform
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return new INpcPerformOnMonsterCloseby?(default(INpcPerformOnMonsterCloseby).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A35A RID: 41818
		// (get) Token: 0x06024A58 RID: 150104 RVA: 0x0050E53C File Offset: 0x0050C73C
		public INpcPerformState? NpcPerformState
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return new INpcPerformState?(default(INpcPerformState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A35B RID: 41819
		// (get) Token: 0x06024A59 RID: 150105 RVA: 0x0050E59C File Offset: 0x0050C79C
		public INpcDeathInteract? DeathInteract
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return new INpcDeathInteract?(default(INpcDeathInteract).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A35C RID: 41820
		// (get) Token: 0x06024A5A RID: 150106 RVA: 0x0050E5FC File Offset: 0x0050C7FC
		public bool FixedPosition
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A35D RID: 41821
		// (get) Token: 0x06024A5B RID: 150107 RVA: 0x0050E63C File Offset: 0x0050C83C
		public string DefaultAbpState
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024A5C RID: 150108 RVA: 0x0050E674 File Offset: 0x0050C874
		public Span<byte> GetDefaultAbpStateBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06024A5D RID: 150109 RVA: 0x0050E684 File Offset: 0x0050C884
		public byte[] GetDefaultAbpStateArray()
		{
			return this.__p.__vector_as_array<byte>(42);
		}

		// Token: 0x1700A35E RID: 41822
		// (get) Token: 0x06024A5E RID: 150110 RVA: 0x0050E694 File Offset: 0x0050C894
		public int DefaultFaceExpressionId
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A35F RID: 41823
		// (get) Token: 0x06024A5F RID: 150111 RVA: 0x0050E6D4 File Offset: 0x0050C8D4
		public INpcDefaultPerform? DefaultPerform
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return new INpcDefaultPerform?(default(INpcDefaultPerform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024A60 RID: 150112 RVA: 0x0050E734 File Offset: 0x0050C934
		public TNpcSpecialMark NpcSpecialMarksType(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return TNpcSpecialMark.NONE;
			}
			return (TNpcSpecialMark)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700A360 RID: 41824
		// (get) Token: 0x06024A61 RID: 150113 RVA: 0x0050E774 File Offset: 0x0050C974
		public int NpcSpecialMarksTypeLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06024A62 RID: 150114 RVA: 0x0050E7A0 File Offset: 0x0050C9A0
		public Span<TNpcSpecialMark> GetNpcSpecialMarksTypeBytes()
		{
			return this.__p.__vector_as_span<TNpcSpecialMark>(48, 1);
		}

		// Token: 0x06024A63 RID: 150115 RVA: 0x0050E7B0 File Offset: 0x0050C9B0
		public TNpcSpecialMark[] GetNpcSpecialMarksTypeArray()
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TNpcSpecialMark[] array = new TNpcSpecialMark[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TNpcSpecialMark)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06024A64 RID: 150116 RVA: 0x0050E81C File Offset: 0x0050CA1C
		public TTable? NpcSpecialMarks<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700A361 RID: 41825
		// (get) Token: 0x06024A65 RID: 150117 RVA: 0x0050E864 File Offset: 0x0050CA64
		public int NpcSpecialMarksLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A362 RID: 41826
		// (get) Token: 0x06024A66 RID: 150118 RVA: 0x0050E890 File Offset: 0x0050CA90
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024A67 RID: 150119 RVA: 0x0050E8D0 File Offset: 0x0050CAD0
		public static Offset<INpcPerformComponent> CreateINpcPerformComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IBaseRoleNpcPerform> SpecialNpcPerformConfigOffset = default(Offset<IBaseRoleNpcPerform>), bool IsStare = false, Offset<INpcHitShow> NpcHitShowOffset = default(Offset<INpcHitShow>), bool IsShowStrike = false, Offset<INpcBumpShow> NpcBumpShowOffset = default(Offset<INpcBumpShow>), Offset<INpcAwakeShow> ShowOnAwakeOffset = default(Offset<INpcAwakeShow>), TNpcStandbyShowOption ShowOnStandby_type = TNpcStandbyShowOption.NONE, int ShowOnStandbyOffset = 0, Offset<INpcPerformOnInteract> ShowOnInteractOffset = default(Offset<INpcPerformOnInteract>), VectorOffset ConditionalShowOnInteractsOffset = default(VectorOffset), TNpcUiInteractOption ShowOnUiInteract_type = TNpcUiInteractOption.NONE, int ShowOnUiInteractOffset = 0, VectorOffset ShowOnRideInVehicle_typeOffset = default(VectorOffset), VectorOffset ShowOnRideInVehicleOffset = default(VectorOffset), Offset<INpcPerformOnMonsterCloseby> NpcMonsterClosePerformOffset = default(Offset<INpcPerformOnMonsterCloseby>), Offset<INpcPerformState> NpcPerformStateOffset = default(Offset<INpcPerformState>), Offset<INpcDeathInteract> DeathInteractOffset = default(Offset<INpcDeathInteract>), bool FixedPosition = false, StringOffset DefaultAbpStateOffset = default(StringOffset), int DefaultFaceExpressionId = 0, Offset<INpcDefaultPerform> DefaultPerformOffset = default(Offset<INpcDefaultPerform>), VectorOffset NpcSpecialMarks_typeOffset = default(VectorOffset), VectorOffset NpcSpecialMarksOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(25);
			INpcPerformComponent.AddNpcSpecialMarks(builder, NpcSpecialMarksOffset);
			INpcPerformComponent.AddNpcSpecialMarksType(builder, NpcSpecialMarks_typeOffset);
			INpcPerformComponent.AddDefaultPerform(builder, DefaultPerformOffset);
			INpcPerformComponent.AddDefaultFaceExpressionId(builder, DefaultFaceExpressionId);
			INpcPerformComponent.AddDefaultAbpState(builder, DefaultAbpStateOffset);
			INpcPerformComponent.AddDeathInteract(builder, DeathInteractOffset);
			INpcPerformComponent.AddNpcPerformState(builder, NpcPerformStateOffset);
			INpcPerformComponent.AddNpcMonsterClosePerform(builder, NpcMonsterClosePerformOffset);
			INpcPerformComponent.AddShowOnRideInVehicle(builder, ShowOnRideInVehicleOffset);
			INpcPerformComponent.AddShowOnRideInVehicleType(builder, ShowOnRideInVehicle_typeOffset);
			INpcPerformComponent.AddShowOnUiInteract(builder, ShowOnUiInteractOffset);
			INpcPerformComponent.AddConditionalShowOnInteracts(builder, ConditionalShowOnInteractsOffset);
			INpcPerformComponent.AddShowOnInteract(builder, ShowOnInteractOffset);
			INpcPerformComponent.AddShowOnStandby(builder, ShowOnStandbyOffset);
			INpcPerformComponent.AddShowOnAwake(builder, ShowOnAwakeOffset);
			INpcPerformComponent.AddNpcBumpShow(builder, NpcBumpShowOffset);
			INpcPerformComponent.AddNpcHitShow(builder, NpcHitShowOffset);
			INpcPerformComponent.AddSpecialNpcPerformConfig(builder, SpecialNpcPerformConfigOffset);
			INpcPerformComponent.AddNullMask(builder, NullMask);
			INpcPerformComponent.AddFixedPosition(builder, FixedPosition);
			INpcPerformComponent.AddShowOnUiInteractType(builder, ShowOnUiInteract_type);
			INpcPerformComponent.AddShowOnStandbyType(builder, ShowOnStandby_type);
			INpcPerformComponent.AddIsShowStrike(builder, IsShowStrike);
			INpcPerformComponent.AddIsStare(builder, IsStare);
			INpcPerformComponent.AddDisabled(builder, Disabled);
			return INpcPerformComponent.EndINpcPerformComponent(builder);
		}

		// Token: 0x06024A68 RID: 150120 RVA: 0x0050E9B0 File Offset: 0x0050CBB0
		public static void StartINpcPerformComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(25);
		}

		// Token: 0x06024A69 RID: 150121 RVA: 0x0050E9BA File Offset: 0x0050CBBA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024A6A RID: 150122 RVA: 0x0050E9C5 File Offset: 0x0050CBC5
		public static void AddSpecialNpcPerformConfig(FlatBufferBuilder builder, Offset<IBaseRoleNpcPerform> specialNpcPerformConfigOffset)
		{
			builder.AddOffset(1, specialNpcPerformConfigOffset.Value, 0);
		}

		// Token: 0x06024A6B RID: 150123 RVA: 0x0050E9D5 File Offset: 0x0050CBD5
		public static void AddIsStare(FlatBufferBuilder builder, bool isStare)
		{
			builder.AddBool(2, isStare, false);
		}

		// Token: 0x06024A6C RID: 150124 RVA: 0x0050E9E0 File Offset: 0x0050CBE0
		public static void AddNpcHitShow(FlatBufferBuilder builder, Offset<INpcHitShow> npcHitShowOffset)
		{
			builder.AddOffset(3, npcHitShowOffset.Value, 0);
		}

		// Token: 0x06024A6D RID: 150125 RVA: 0x0050E9F0 File Offset: 0x0050CBF0
		public static void AddIsShowStrike(FlatBufferBuilder builder, bool isShowStrike)
		{
			builder.AddBool(4, isShowStrike, false);
		}

		// Token: 0x06024A6E RID: 150126 RVA: 0x0050E9FB File Offset: 0x0050CBFB
		public static void AddNpcBumpShow(FlatBufferBuilder builder, Offset<INpcBumpShow> npcBumpShowOffset)
		{
			builder.AddOffset(5, npcBumpShowOffset.Value, 0);
		}

		// Token: 0x06024A6F RID: 150127 RVA: 0x0050EA0B File Offset: 0x0050CC0B
		public static void AddShowOnAwake(FlatBufferBuilder builder, Offset<INpcAwakeShow> showOnAwakeOffset)
		{
			builder.AddOffset(6, showOnAwakeOffset.Value, 0);
		}

		// Token: 0x06024A70 RID: 150128 RVA: 0x0050EA1B File Offset: 0x0050CC1B
		public static void AddShowOnStandbyType(FlatBufferBuilder builder, TNpcStandbyShowOption showOnStandbyType)
		{
			builder.AddByte(7, (byte)showOnStandbyType, 0);
		}

		// Token: 0x06024A71 RID: 150129 RVA: 0x0050EA26 File Offset: 0x0050CC26
		public static void AddShowOnStandby(FlatBufferBuilder builder, int showOnStandbyOffset)
		{
			builder.AddOffset(8, showOnStandbyOffset, 0);
		}

		// Token: 0x06024A72 RID: 150130 RVA: 0x0050EA31 File Offset: 0x0050CC31
		public static void AddShowOnInteract(FlatBufferBuilder builder, Offset<INpcPerformOnInteract> showOnInteractOffset)
		{
			builder.AddOffset(9, showOnInteractOffset.Value, 0);
		}

		// Token: 0x06024A73 RID: 150131 RVA: 0x0050EA42 File Offset: 0x0050CC42
		public static void AddConditionalShowOnInteracts(FlatBufferBuilder builder, VectorOffset conditionalShowOnInteractsOffset)
		{
			builder.AddOffset(10, conditionalShowOnInteractsOffset.Value, 0);
		}

		// Token: 0x06024A74 RID: 150132 RVA: 0x0050EA54 File Offset: 0x0050CC54
		public static VectorOffset CreateConditionalShowOnInteractsVector(FlatBufferBuilder builder, Offset<IConditionalNpcPerformOnInteract>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024A75 RID: 150133 RVA: 0x0050EA94 File Offset: 0x0050CC94
		public static VectorOffset CreateConditionalShowOnInteractsVectorBlock(FlatBufferBuilder builder, Offset<IConditionalNpcPerformOnInteract>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionalNpcPerformOnInteract>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024A76 RID: 150134 RVA: 0x0050EAAE File Offset: 0x0050CCAE
		public static VectorOffset CreateConditionalShowOnInteractsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionalNpcPerformOnInteract>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionalNpcPerformOnInteract>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024A77 RID: 150135 RVA: 0x0050EACC File Offset: 0x0050CCCC
		public static VectorOffset CreateConditionalShowOnInteractsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionalNpcPerformOnInteract>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024A78 RID: 150136 RVA: 0x0050EAE5 File Offset: 0x0050CCE5
		public static void StartConditionalShowOnInteractsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024A79 RID: 150137 RVA: 0x0050EAF0 File Offset: 0x0050CCF0
		public static void AddShowOnUiInteractType(FlatBufferBuilder builder, TNpcUiInteractOption showOnUiInteractType)
		{
			builder.AddByte(11, (byte)showOnUiInteractType, 0);
		}

		// Token: 0x06024A7A RID: 150138 RVA: 0x0050EAFC File Offset: 0x0050CCFC
		public static void AddShowOnUiInteract(FlatBufferBuilder builder, int showOnUiInteractOffset)
		{
			builder.AddOffset(12, showOnUiInteractOffset, 0);
		}

		// Token: 0x06024A7B RID: 150139 RVA: 0x0050EB08 File Offset: 0x0050CD08
		public static void AddShowOnRideInVehicleType(FlatBufferBuilder builder, VectorOffset showOnRideInVehicleTypeOffset)
		{
			builder.AddOffset(13, showOnRideInVehicleTypeOffset.Value, 0);
		}

		// Token: 0x06024A7C RID: 150140 RVA: 0x0050EB1C File Offset: 0x0050CD1C
		public static VectorOffset CreateShowOnRideInVehicleTypeVector(FlatBufferBuilder builder, TNpcRideInVehiclePerformType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024A7D RID: 150141 RVA: 0x0050EB53 File Offset: 0x0050CD53
		public static VectorOffset CreateShowOnRideInVehicleTypeVectorBlock(FlatBufferBuilder builder, TNpcRideInVehiclePerformType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TNpcRideInVehiclePerformType>(data);
			return builder.EndVector();
		}

		// Token: 0x06024A7E RID: 150142 RVA: 0x0050EB6D File Offset: 0x0050CD6D
		public static VectorOffset CreateShowOnRideInVehicleTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TNpcRideInVehiclePerformType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TNpcRideInVehiclePerformType>(data);
			return builder.EndVector();
		}

		// Token: 0x06024A7F RID: 150143 RVA: 0x0050EB8B File Offset: 0x0050CD8B
		public static VectorOffset CreateShowOnRideInVehicleTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TNpcRideInVehiclePerformType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024A80 RID: 150144 RVA: 0x0050EBA4 File Offset: 0x0050CDA4
		public static void StartShowOnRideInVehicleTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06024A81 RID: 150145 RVA: 0x0050EBAF File Offset: 0x0050CDAF
		public static void AddShowOnRideInVehicle(FlatBufferBuilder builder, VectorOffset showOnRideInVehicleOffset)
		{
			builder.AddOffset(14, showOnRideInVehicleOffset.Value, 0);
		}

		// Token: 0x06024A82 RID: 150146 RVA: 0x0050EBC0 File Offset: 0x0050CDC0
		public static VectorOffset CreateShowOnRideInVehicleVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024A83 RID: 150147 RVA: 0x0050EBF7 File Offset: 0x0050CDF7
		public static VectorOffset CreateShowOnRideInVehicleVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024A84 RID: 150148 RVA: 0x0050EC11 File Offset: 0x0050CE11
		public static VectorOffset CreateShowOnRideInVehicleVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024A85 RID: 150149 RVA: 0x0050EC2F File Offset: 0x0050CE2F
		public static VectorOffset CreateShowOnRideInVehicleVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024A86 RID: 150150 RVA: 0x0050EC48 File Offset: 0x0050CE48
		public static void StartShowOnRideInVehicleVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024A87 RID: 150151 RVA: 0x0050EC53 File Offset: 0x0050CE53
		public static void AddNpcMonsterClosePerform(FlatBufferBuilder builder, Offset<INpcPerformOnMonsterCloseby> npcMonsterClosePerformOffset)
		{
			builder.AddOffset(15, npcMonsterClosePerformOffset.Value, 0);
		}

		// Token: 0x06024A88 RID: 150152 RVA: 0x0050EC64 File Offset: 0x0050CE64
		public static void AddNpcPerformState(FlatBufferBuilder builder, Offset<INpcPerformState> npcPerformStateOffset)
		{
			builder.AddOffset(16, npcPerformStateOffset.Value, 0);
		}

		// Token: 0x06024A89 RID: 150153 RVA: 0x0050EC75 File Offset: 0x0050CE75
		public static void AddDeathInteract(FlatBufferBuilder builder, Offset<INpcDeathInteract> deathInteractOffset)
		{
			builder.AddOffset(17, deathInteractOffset.Value, 0);
		}

		// Token: 0x06024A8A RID: 150154 RVA: 0x0050EC86 File Offset: 0x0050CE86
		public static void AddFixedPosition(FlatBufferBuilder builder, bool fixedPosition)
		{
			builder.AddBool(18, fixedPosition, false);
		}

		// Token: 0x06024A8B RID: 150155 RVA: 0x0050EC92 File Offset: 0x0050CE92
		public static void AddDefaultAbpState(FlatBufferBuilder builder, StringOffset defaultAbpStateOffset)
		{
			builder.AddOffset(19, defaultAbpStateOffset.Value, 0);
		}

		// Token: 0x06024A8C RID: 150156 RVA: 0x0050ECA3 File Offset: 0x0050CEA3
		public static void AddDefaultFaceExpressionId(FlatBufferBuilder builder, int defaultFaceExpressionId)
		{
			builder.AddInt(20, defaultFaceExpressionId, 0);
		}

		// Token: 0x06024A8D RID: 150157 RVA: 0x0050ECAF File Offset: 0x0050CEAF
		public static void AddDefaultPerform(FlatBufferBuilder builder, Offset<INpcDefaultPerform> defaultPerformOffset)
		{
			builder.AddOffset(21, defaultPerformOffset.Value, 0);
		}

		// Token: 0x06024A8E RID: 150158 RVA: 0x0050ECC0 File Offset: 0x0050CEC0
		public static void AddNpcSpecialMarksType(FlatBufferBuilder builder, VectorOffset npcSpecialMarksTypeOffset)
		{
			builder.AddOffset(22, npcSpecialMarksTypeOffset.Value, 0);
		}

		// Token: 0x06024A8F RID: 150159 RVA: 0x0050ECD4 File Offset: 0x0050CED4
		public static VectorOffset CreateNpcSpecialMarksTypeVector(FlatBufferBuilder builder, TNpcSpecialMark[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024A90 RID: 150160 RVA: 0x0050ED0B File Offset: 0x0050CF0B
		public static VectorOffset CreateNpcSpecialMarksTypeVectorBlock(FlatBufferBuilder builder, TNpcSpecialMark[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TNpcSpecialMark>(data);
			return builder.EndVector();
		}

		// Token: 0x06024A91 RID: 150161 RVA: 0x0050ED25 File Offset: 0x0050CF25
		public static VectorOffset CreateNpcSpecialMarksTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TNpcSpecialMark> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TNpcSpecialMark>(data);
			return builder.EndVector();
		}

		// Token: 0x06024A92 RID: 150162 RVA: 0x0050ED43 File Offset: 0x0050CF43
		public static VectorOffset CreateNpcSpecialMarksTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TNpcSpecialMark>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024A93 RID: 150163 RVA: 0x0050ED5C File Offset: 0x0050CF5C
		public static void StartNpcSpecialMarksTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06024A94 RID: 150164 RVA: 0x0050ED67 File Offset: 0x0050CF67
		public static void AddNpcSpecialMarks(FlatBufferBuilder builder, VectorOffset npcSpecialMarksOffset)
		{
			builder.AddOffset(23, npcSpecialMarksOffset.Value, 0);
		}

		// Token: 0x06024A95 RID: 150165 RVA: 0x0050ED78 File Offset: 0x0050CF78
		public static VectorOffset CreateNpcSpecialMarksVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024A96 RID: 150166 RVA: 0x0050EDAF File Offset: 0x0050CFAF
		public static VectorOffset CreateNpcSpecialMarksVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024A97 RID: 150167 RVA: 0x0050EDC9 File Offset: 0x0050CFC9
		public static VectorOffset CreateNpcSpecialMarksVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024A98 RID: 150168 RVA: 0x0050EDE7 File Offset: 0x0050CFE7
		public static VectorOffset CreateNpcSpecialMarksVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024A99 RID: 150169 RVA: 0x0050EE00 File Offset: 0x0050D000
		public static void StartNpcSpecialMarksVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024A9A RID: 150170 RVA: 0x0050EE0B File Offset: 0x0050D00B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(24, nullMask, 0);
		}

		// Token: 0x06024A9B RID: 150171 RVA: 0x0050EE17 File Offset: 0x0050D017
		public static Offset<INpcPerformComponent> EndINpcPerformComponent(FlatBufferBuilder builder)
		{
			return new Offset<INpcPerformComponent>(builder.EndTable());
		}

		// Token: 0x06024A9C RID: 150172 RVA: 0x0050EE24 File Offset: 0x0050D024
		public INpcPerformComponentT UnPack()
		{
			INpcPerformComponentT npcPerformComponentT = new INpcPerformComponentT();
			this.UnPackTo(npcPerformComponentT);
			return npcPerformComponentT;
		}

		// Token: 0x06024A9D RID: 150173 RVA: 0x0050EE40 File Offset: 0x0050D040
		public void UnPackTo(INpcPerformComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.SpecialNpcPerformConfig = ((this.SpecialNpcPerformConfig != null) ? this.SpecialNpcPerformConfig.Value.UnPack() : null);
			_o.IsStare = this.IsStare;
			_o.NpcHitShow = ((this.NpcHitShow != null) ? this.NpcHitShow.Value.UnPack() : null);
			_o.IsShowStrike = this.IsShowStrike;
			_o.NpcBumpShow = ((this.NpcBumpShow != null) ? this.NpcBumpShow.Value.UnPack() : null);
			_o.ShowOnAwake = ((this.ShowOnAwake != null) ? this.ShowOnAwake.Value.UnPack() : null);
			_o.ShowOnStandby = new TNpcStandbyShowOptionUnion();
			_o.ShowOnStandby.Type = this.ShowOnStandbyType;
			switch (this.ShowOnStandbyType)
			{
			case TNpcStandbyShowOption.INpcStandbyShowFinitely:
				_o.ShowOnStandby.Value = ((this.ShowOnStandby<INpcStandbyShowFinitely>() != null) ? this.ShowOnStandby<INpcStandbyShowFinitely>().Value.UnPack() : null);
				break;
			case TNpcStandbyShowOption.INpcStandbyShowLooply:
				_o.ShowOnStandby.Value = ((this.ShowOnStandby<INpcStandbyShowLooply>() != null) ? this.ShowOnStandby<INpcStandbyShowLooply>().Value.UnPack() : null);
				break;
			case TNpcStandbyShowOption.INpcStandbySit:
				_o.ShowOnStandby.Value = ((this.ShowOnStandby<INpcStandbySit>() != null) ? this.ShowOnStandby<INpcStandbySit>().Value.UnPack() : null);
				break;
			}
			_o.ShowOnInteract = ((this.ShowOnInteract != null) ? this.ShowOnInteract.Value.UnPack() : null);
			_o.ConditionalShowOnInteracts = new List<IConditionalNpcPerformOnInteractT>();
			for (int i = 0; i < this.ConditionalShowOnInteractsLength; i++)
			{
				_o.ConditionalShowOnInteracts.Add((this.ConditionalShowOnInteracts(i) != null) ? this.ConditionalShowOnInteracts(i).Value.UnPack() : null);
			}
			_o.ShowOnUiInteract = new TNpcUiInteractOptionUnion();
			_o.ShowOnUiInteract.Type = this.ShowOnUiInteractType;
			switch (this.ShowOnUiInteractType)
			{
			case TNpcUiInteractOption.INpcUiInteractOnAntiqueShop:
				_o.ShowOnUiInteract.Value = ((this.ShowOnUiInteract<INpcUiInteractOnAntiqueShop>() != null) ? this.ShowOnUiInteract<INpcUiInteractOnAntiqueShop>().Value.UnPack() : null);
				break;
			case TNpcUiInteractOption.INpcUiInteractOnChengXiaoShanShop:
				_o.ShowOnUiInteract.Value = ((this.ShowOnUiInteract<INpcUiInteractOnChengXiaoShanShop>() != null) ? this.ShowOnUiInteract<INpcUiInteractOnChengXiaoShanShop>().Value.UnPack() : null);
				break;
			case TNpcUiInteractOption.INpcUiInteractOnDollGrabDelivery:
				_o.ShowOnUiInteract.Value = ((this.ShowOnUiInteract<INpcUiInteractOnDollGrabDelivery>() != null) ? this.ShowOnUiInteract<INpcUiInteractOnDollGrabDelivery>().Value.UnPack() : null);
				break;
			case TNpcUiInteractOption.INpcUiInteractOnGramophone:
				_o.ShowOnUiInteract.Value = ((this.ShowOnUiInteract<INpcUiInteractOnGramophone>() != null) ? this.ShowOnUiInteract<INpcUiInteractOnGramophone>().Value.UnPack() : null);
				break;
			case TNpcUiInteractOption.INpcUiInteractOnHandInItem:
				_o.ShowOnUiInteract.Value = ((this.ShowOnUiInteract<INpcUiInteractOnHandInItem>() != null) ? this.ShowOnUiInteract<INpcUiInteractOnHandInItem>().Value.UnPack() : null);
				break;
			case TNpcUiInteractOption.INpcUiInteractOnShop:
				_o.ShowOnUiInteract.Value = ((this.ShowOnUiInteract<INpcUiInteractOnShop>() != null) ? this.ShowOnUiInteract<INpcUiInteractOnShop>().Value.UnPack() : null);
				break;
			case TNpcUiInteractOption.INpcUiInteractOnShopNew:
				_o.ShowOnUiInteract.Value = ((this.ShowOnUiInteract<INpcUiInteractOnShopNew>() != null) ? this.ShowOnUiInteract<INpcUiInteractOnShopNew>().Value.UnPack() : null);
				break;
			case TNpcUiInteractOption.INpcUiInteractOnSoundBox3:
				_o.ShowOnUiInteract.Value = ((this.ShowOnUiInteract<INpcUiInteractOnSoundBox3>() != null) ? this.ShowOnUiInteract<INpcUiInteractOnSoundBox3>().Value.UnPack() : null);
				break;
			case TNpcUiInteractOption.INpcUiInteractOnSoundBox35:
				_o.ShowOnUiInteract.Value = ((this.ShowOnUiInteract<INpcUiInteractOnSoundBox35>() != null) ? this.ShowOnUiInteract<INpcUiInteractOnSoundBox35>().Value.UnPack() : null);
				break;
			case TNpcUiInteractOption.INpcUiInteractOnSunSpirit:
				_o.ShowOnUiInteract.Value = ((this.ShowOnUiInteract<INpcUiInteractOnSunSpirit>() != null) ? this.ShowOnUiInteract<INpcUiInteractOnSunSpirit>().Value.UnPack() : null);
				break;
			case TNpcUiInteractOption.INpcUiInteractOnVillageInfr:
				_o.ShowOnUiInteract.Value = ((this.ShowOnUiInteract<INpcUiInteractOnVillageInfr>() != null) ? this.ShowOnUiInteract<INpcUiInteractOnVillageInfr>().Value.UnPack() : null);
				break;
			}
			_o.ShowOnRideInVehicle = new List<TNpcRideInVehiclePerformTypeUnion>();
			for (int j = 0; j < this.ShowOnRideInVehicleLength; j++)
			{
				TNpcRideInVehiclePerformTypeUnion tnpcRideInVehiclePerformTypeUnion = new TNpcRideInVehiclePerformTypeUnion();
				tnpcRideInVehiclePerformTypeUnion.Type = this.ShowOnRideInVehicleType(j);
				switch (this.ShowOnRideInVehicleType(j))
				{
				case TNpcRideInVehiclePerformType.ICyberpunkShareEmptyVehiclePerform:
					tnpcRideInVehiclePerformTypeUnion.Value = ((this.ShowOnRideInVehicle<ICyberpunkShareEmptyVehiclePerform>(j) != null) ? this.ShowOnRideInVehicle<ICyberpunkShareEmptyVehiclePerform>(j).Value.UnPack() : null);
					break;
				case TNpcRideInVehiclePerformType.INpcRideInAutoGongduolaPerform:
					tnpcRideInVehiclePerformTypeUnion.Value = ((this.ShowOnRideInVehicle<INpcRideInAutoGongduolaPerform>(j) != null) ? this.ShowOnRideInVehicle<INpcRideInAutoGongduolaPerform>(j).Value.UnPack() : null);
					break;
				case TNpcRideInVehiclePerformType.INpcRideInGongduolaPerform:
					tnpcRideInVehiclePerformTypeUnion.Value = ((this.ShowOnRideInVehicle<INpcRideInGongduolaPerform>(j) != null) ? this.ShowOnRideInVehicle<INpcRideInGongduolaPerform>(j).Value.UnPack() : null);
					break;
				case TNpcRideInVehiclePerformType.IWoodenOxenAndFlowingHorsesPerform:
					tnpcRideInVehiclePerformTypeUnion.Value = ((this.ShowOnRideInVehicle<IWoodenOxenAndFlowingHorsesPerform>(j) != null) ? this.ShowOnRideInVehicle<IWoodenOxenAndFlowingHorsesPerform>(j).Value.UnPack() : null);
					break;
				}
				_o.ShowOnRideInVehicle.Add(tnpcRideInVehiclePerformTypeUnion);
			}
			_o.NpcMonsterClosePerform = ((this.NpcMonsterClosePerform != null) ? this.NpcMonsterClosePerform.Value.UnPack() : null);
			_o.NpcPerformState = ((this.NpcPerformState != null) ? this.NpcPerformState.Value.UnPack() : null);
			_o.DeathInteract = ((this.DeathInteract != null) ? this.DeathInteract.Value.UnPack() : null);
			_o.FixedPosition = this.FixedPosition;
			_o.DefaultAbpState = this.DefaultAbpState;
			_o.DefaultFaceExpressionId = this.DefaultFaceExpressionId;
			_o.DefaultPerform = ((this.DefaultPerform != null) ? this.DefaultPerform.Value.UnPack() : null);
			_o.NpcSpecialMarks = new List<TNpcSpecialMarkUnion>();
			for (int k = 0; k < this.NpcSpecialMarksLength; k++)
			{
				TNpcSpecialMarkUnion tnpcSpecialMarkUnion = new TNpcSpecialMarkUnion();
				tnpcSpecialMarkUnion.Type = this.NpcSpecialMarksType(k);
				TNpcSpecialMark tnpcSpecialMark = this.NpcSpecialMarksType(k);
				if (tnpcSpecialMark != TNpcSpecialMark.INpcSpecialMarkIgnoreCameraHideNpc)
				{
					if (tnpcSpecialMark == TNpcSpecialMark.INpcSpecialMarkTrafficLight)
					{
						tnpcSpecialMarkUnion.Value = ((this.NpcSpecialMarks<INpcSpecialMarkTrafficLight>(k) != null) ? this.NpcSpecialMarks<INpcSpecialMarkTrafficLight>(k).Value.UnPack() : null);
					}
				}
				else
				{
					tnpcSpecialMarkUnion.Value = ((this.NpcSpecialMarks<INpcSpecialMarkIgnoreCameraHideNpc>(k) != null) ? this.NpcSpecialMarks<INpcSpecialMarkIgnoreCameraHideNpc>(k).Value.UnPack() : null);
				}
				_o.NpcSpecialMarks.Add(tnpcSpecialMarkUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024A9E RID: 150174 RVA: 0x0050F6AC File Offset: 0x0050D8AC
		public static Offset<INpcPerformComponent> Pack(FlatBufferBuilder builder, INpcPerformComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcPerformComponent>);
			}
			Offset<IBaseRoleNpcPerform> specialNpcPerformConfigOffset = (_o.SpecialNpcPerformConfig == null) ? default(Offset<IBaseRoleNpcPerform>) : IBaseRoleNpcPerform.Pack(builder, _o.SpecialNpcPerformConfig);
			Offset<INpcHitShow> npcHitShowOffset = (_o.NpcHitShow == null) ? default(Offset<INpcHitShow>) : INpcHitShow.Pack(builder, _o.NpcHitShow);
			Offset<INpcBumpShow> npcBumpShowOffset = (_o.NpcBumpShow == null) ? default(Offset<INpcBumpShow>) : INpcBumpShow.Pack(builder, _o.NpcBumpShow);
			Offset<INpcAwakeShow> showOnAwakeOffset = (_o.ShowOnAwake == null) ? default(Offset<INpcAwakeShow>) : INpcAwakeShow.Pack(builder, _o.ShowOnAwake);
			TNpcStandbyShowOption showOnStandby_type = (_o.ShowOnStandby == null) ? TNpcStandbyShowOption.NONE : _o.ShowOnStandby.Type;
			int showOnStandbyOffset = (_o.ShowOnStandby == null) ? 0 : TNpcStandbyShowOptionUnion.Pack(builder, _o.ShowOnStandby);
			Offset<INpcPerformOnInteract> showOnInteractOffset = (_o.ShowOnInteract == null) ? default(Offset<INpcPerformOnInteract>) : INpcPerformOnInteract.Pack(builder, _o.ShowOnInteract);
			VectorOffset conditionalShowOnInteractsOffset = default(VectorOffset);
			if (_o.ConditionalShowOnInteracts != null)
			{
				Offset<IConditionalNpcPerformOnInteract>[] array = new Offset<IConditionalNpcPerformOnInteract>[_o.ConditionalShowOnInteracts.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IConditionalNpcPerformOnInteract.Pack(builder, _o.ConditionalShowOnInteracts[i]);
				}
				conditionalShowOnInteractsOffset = INpcPerformComponent.CreateConditionalShowOnInteractsVector(builder, array);
			}
			TNpcUiInteractOption showOnUiInteract_type = (_o.ShowOnUiInteract == null) ? TNpcUiInteractOption.NONE : _o.ShowOnUiInteract.Type;
			int showOnUiInteractOffset = (_o.ShowOnUiInteract == null) ? 0 : TNpcUiInteractOptionUnion.Pack(builder, _o.ShowOnUiInteract);
			VectorOffset showOnRideInVehicle_typeOffset = default(VectorOffset);
			if (_o.ShowOnRideInVehicle != null)
			{
				TNpcRideInVehiclePerformType[] array2 = new TNpcRideInVehiclePerformType[_o.ShowOnRideInVehicle.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = _o.ShowOnRideInVehicle[j].Type;
				}
				showOnRideInVehicle_typeOffset = INpcPerformComponent.CreateShowOnRideInVehicleTypeVector(builder, array2);
			}
			VectorOffset showOnRideInVehicleOffset = default(VectorOffset);
			if (_o.ShowOnRideInVehicle != null)
			{
				int[] array3 = new int[_o.ShowOnRideInVehicle.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = TNpcRideInVehiclePerformTypeUnion.Pack(builder, _o.ShowOnRideInVehicle[k]);
				}
				showOnRideInVehicleOffset = INpcPerformComponent.CreateShowOnRideInVehicleVector(builder, array3);
			}
			Offset<INpcPerformOnMonsterCloseby> npcMonsterClosePerformOffset = (_o.NpcMonsterClosePerform == null) ? default(Offset<INpcPerformOnMonsterCloseby>) : INpcPerformOnMonsterCloseby.Pack(builder, _o.NpcMonsterClosePerform);
			Offset<INpcPerformState> npcPerformStateOffset = (_o.NpcPerformState == null) ? default(Offset<INpcPerformState>) : INpcPerformState.Pack(builder, _o.NpcPerformState);
			Offset<INpcDeathInteract> deathInteractOffset = (_o.DeathInteract == null) ? default(Offset<INpcDeathInteract>) : INpcDeathInteract.Pack(builder, _o.DeathInteract);
			StringOffset defaultAbpStateOffset = (_o.DefaultAbpState == null) ? default(StringOffset) : builder.CreateString(_o.DefaultAbpState);
			Offset<INpcDefaultPerform> defaultPerformOffset = (_o.DefaultPerform == null) ? default(Offset<INpcDefaultPerform>) : INpcDefaultPerform.Pack(builder, _o.DefaultPerform);
			VectorOffset npcSpecialMarks_typeOffset = default(VectorOffset);
			if (_o.NpcSpecialMarks != null)
			{
				TNpcSpecialMark[] array4 = new TNpcSpecialMark[_o.NpcSpecialMarks.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = _o.NpcSpecialMarks[l].Type;
				}
				npcSpecialMarks_typeOffset = INpcPerformComponent.CreateNpcSpecialMarksTypeVector(builder, array4);
			}
			VectorOffset npcSpecialMarksOffset = default(VectorOffset);
			if (_o.NpcSpecialMarks != null)
			{
				int[] array5 = new int[_o.NpcSpecialMarks.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = TNpcSpecialMarkUnion.Pack(builder, _o.NpcSpecialMarks[m]);
				}
				npcSpecialMarksOffset = INpcPerformComponent.CreateNpcSpecialMarksVector(builder, array5);
			}
			return INpcPerformComponent.CreateINpcPerformComponent(builder, _o.Disabled, specialNpcPerformConfigOffset, _o.IsStare, npcHitShowOffset, _o.IsShowStrike, npcBumpShowOffset, showOnAwakeOffset, showOnStandby_type, showOnStandbyOffset, showOnInteractOffset, conditionalShowOnInteractsOffset, showOnUiInteract_type, showOnUiInteractOffset, showOnRideInVehicle_typeOffset, showOnRideInVehicleOffset, npcMonsterClosePerformOffset, npcPerformStateOffset, deathInteractOffset, _o.FixedPosition, defaultAbpStateOffset, _o.DefaultFaceExpressionId, defaultPerformOffset, npcSpecialMarks_typeOffset, npcSpecialMarksOffset, _o.NullMask);
		}

		// Token: 0x0400E9C1 RID: 59841
		private Table __p;
	}
}
