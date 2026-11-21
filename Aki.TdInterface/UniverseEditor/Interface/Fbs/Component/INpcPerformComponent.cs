using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BD0 RID: 23504
	public struct INpcPerformComponent : IFlatbufferObject
	{
		// Token: 0x1700ABD3 RID: 43987
		// (get) Token: 0x06026C42 RID: 158786 RVA: 0x0054E40C File Offset: 0x0054C60C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026C43 RID: 158787 RVA: 0x0054E419 File Offset: 0x0054C619
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026C44 RID: 158788 RVA: 0x0054E420 File Offset: 0x0054C620
		public static INpcPerformComponent GetRootAsINpcPerformComponent(ByteBuffer _bb)
		{
			return INpcPerformComponent.GetRootAsINpcPerformComponent(_bb, default(INpcPerformComponent));
		}

		// Token: 0x06026C45 RID: 158789 RVA: 0x0054E43C File Offset: 0x0054C63C
		public static INpcPerformComponent GetRootAsINpcPerformComponent(ByteBuffer _bb, INpcPerformComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026C46 RID: 158790 RVA: 0x0054E459 File Offset: 0x0054C659
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026C47 RID: 158791 RVA: 0x0054E468 File Offset: 0x0054C668
		public INpcPerformComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABD4 RID: 43988
		// (get) Token: 0x06026C48 RID: 158792 RVA: 0x0054E478 File Offset: 0x0054C678
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ABD5 RID: 43989
		// (get) Token: 0x06026C49 RID: 158793 RVA: 0x0054E4B8 File Offset: 0x0054C6B8
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

		// Token: 0x1700ABD6 RID: 43990
		// (get) Token: 0x06026C4A RID: 158794 RVA: 0x0054E518 File Offset: 0x0054C718
		public bool IsStare
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ABD7 RID: 43991
		// (get) Token: 0x06026C4B RID: 158795 RVA: 0x0054E558 File Offset: 0x0054C758
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

		// Token: 0x1700ABD8 RID: 43992
		// (get) Token: 0x06026C4C RID: 158796 RVA: 0x0054E5B8 File Offset: 0x0054C7B8
		public bool IsShowStrike
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ABD9 RID: 43993
		// (get) Token: 0x06026C4D RID: 158797 RVA: 0x0054E5F8 File Offset: 0x0054C7F8
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

		// Token: 0x1700ABDA RID: 43994
		// (get) Token: 0x06026C4E RID: 158798 RVA: 0x0054E658 File Offset: 0x0054C858
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

		// Token: 0x1700ABDB RID: 43995
		// (get) Token: 0x06026C4F RID: 158799 RVA: 0x0054E6B8 File Offset: 0x0054C8B8
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

		// Token: 0x06026C50 RID: 158800 RVA: 0x0054E6F8 File Offset: 0x0054C8F8
		public TTable? ShowOnStandby<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026C51 RID: 158801 RVA: 0x0054E740 File Offset: 0x0054C940
		public INpcStandbyShowFinitely ShowOnStandbyAsINpcStandbyShowFinitely()
		{
			return this.ShowOnStandby<INpcStandbyShowFinitely>().Value;
		}

		// Token: 0x06026C52 RID: 158802 RVA: 0x0054E75C File Offset: 0x0054C95C
		public INpcStandbyShowLooply ShowOnStandbyAsINpcStandbyShowLooply()
		{
			return this.ShowOnStandby<INpcStandbyShowLooply>().Value;
		}

		// Token: 0x06026C53 RID: 158803 RVA: 0x0054E778 File Offset: 0x0054C978
		public INpcStandbySit ShowOnStandbyAsINpcStandbySit()
		{
			return this.ShowOnStandby<INpcStandbySit>().Value;
		}

		// Token: 0x1700ABDC RID: 43996
		// (get) Token: 0x06026C54 RID: 158804 RVA: 0x0054E794 File Offset: 0x0054C994
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

		// Token: 0x06026C55 RID: 158805 RVA: 0x0054E7F4 File Offset: 0x0054C9F4
		public IConditionalNpcPerformOnInteract? ConditionalShowOnInteracts(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new IConditionalNpcPerformOnInteract?(default(IConditionalNpcPerformOnInteract).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700ABDD RID: 43997
		// (get) Token: 0x06026C56 RID: 158806 RVA: 0x0054E858 File Offset: 0x0054CA58
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

		// Token: 0x1700ABDE RID: 43998
		// (get) Token: 0x06026C57 RID: 158807 RVA: 0x0054E884 File Offset: 0x0054CA84
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

		// Token: 0x06026C58 RID: 158808 RVA: 0x0054E8C4 File Offset: 0x0054CAC4
		public TTable? ShowOnUiInteract<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026C59 RID: 158809 RVA: 0x0054E90C File Offset: 0x0054CB0C
		public INpcUiInteractOnAntiqueShop ShowOnUiInteractAsINpcUiInteractOnAntiqueShop()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnAntiqueShop>().Value;
		}

		// Token: 0x06026C5A RID: 158810 RVA: 0x0054E928 File Offset: 0x0054CB28
		public INpcUiInteractOnChengXiaoShanShop ShowOnUiInteractAsINpcUiInteractOnChengXiaoShanShop()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnChengXiaoShanShop>().Value;
		}

		// Token: 0x06026C5B RID: 158811 RVA: 0x0054E944 File Offset: 0x0054CB44
		public INpcUiInteractOnDollGrabDelivery ShowOnUiInteractAsINpcUiInteractOnDollGrabDelivery()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnDollGrabDelivery>().Value;
		}

		// Token: 0x06026C5C RID: 158812 RVA: 0x0054E960 File Offset: 0x0054CB60
		public INpcUiInteractOnGramophone ShowOnUiInteractAsINpcUiInteractOnGramophone()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnGramophone>().Value;
		}

		// Token: 0x06026C5D RID: 158813 RVA: 0x0054E97C File Offset: 0x0054CB7C
		public INpcUiInteractOnHandInItem ShowOnUiInteractAsINpcUiInteractOnHandInItem()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnHandInItem>().Value;
		}

		// Token: 0x06026C5E RID: 158814 RVA: 0x0054E998 File Offset: 0x0054CB98
		public INpcUiInteractOnShop ShowOnUiInteractAsINpcUiInteractOnShop()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnShop>().Value;
		}

		// Token: 0x06026C5F RID: 158815 RVA: 0x0054E9B4 File Offset: 0x0054CBB4
		public INpcUiInteractOnShopNew ShowOnUiInteractAsINpcUiInteractOnShopNew()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnShopNew>().Value;
		}

		// Token: 0x06026C60 RID: 158816 RVA: 0x0054E9D0 File Offset: 0x0054CBD0
		public INpcUiInteractOnSoundBox3 ShowOnUiInteractAsINpcUiInteractOnSoundBox3()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnSoundBox3>().Value;
		}

		// Token: 0x06026C61 RID: 158817 RVA: 0x0054E9EC File Offset: 0x0054CBEC
		public INpcUiInteractOnSoundBox35 ShowOnUiInteractAsINpcUiInteractOnSoundBox35()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnSoundBox35>().Value;
		}

		// Token: 0x06026C62 RID: 158818 RVA: 0x0054EA08 File Offset: 0x0054CC08
		public INpcUiInteractOnSunSpirit ShowOnUiInteractAsINpcUiInteractOnSunSpirit()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnSunSpirit>().Value;
		}

		// Token: 0x06026C63 RID: 158819 RVA: 0x0054EA24 File Offset: 0x0054CC24
		public INpcUiInteractOnVillageInfr ShowOnUiInteractAsINpcUiInteractOnVillageInfr()
		{
			return this.ShowOnUiInteract<INpcUiInteractOnVillageInfr>().Value;
		}

		// Token: 0x06026C64 RID: 158820 RVA: 0x0054EA40 File Offset: 0x0054CC40
		public TNpcRideInVehiclePerformType ShowOnRideInVehicleType(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return TNpcRideInVehiclePerformType.NONE;
			}
			return (TNpcRideInVehiclePerformType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700ABDF RID: 43999
		// (get) Token: 0x06026C65 RID: 158821 RVA: 0x0054EA80 File Offset: 0x0054CC80
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

		// Token: 0x06026C66 RID: 158822 RVA: 0x0054EAAC File Offset: 0x0054CCAC
		public Span<TNpcRideInVehiclePerformType> GetShowOnRideInVehicleTypeBytes()
		{
			return this.__p.__vector_as_span<TNpcRideInVehiclePerformType>(30, 1);
		}

		// Token: 0x06026C67 RID: 158823 RVA: 0x0054EABC File Offset: 0x0054CCBC
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

		// Token: 0x06026C68 RID: 158824 RVA: 0x0054EB28 File Offset: 0x0054CD28
		public TTable? ShowOnRideInVehicle<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700ABE0 RID: 44000
		// (get) Token: 0x06026C69 RID: 158825 RVA: 0x0054EB70 File Offset: 0x0054CD70
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

		// Token: 0x1700ABE1 RID: 44001
		// (get) Token: 0x06026C6A RID: 158826 RVA: 0x0054EB9C File Offset: 0x0054CD9C
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

		// Token: 0x1700ABE2 RID: 44002
		// (get) Token: 0x06026C6B RID: 158827 RVA: 0x0054EBFC File Offset: 0x0054CDFC
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

		// Token: 0x1700ABE3 RID: 44003
		// (get) Token: 0x06026C6C RID: 158828 RVA: 0x0054EC5C File Offset: 0x0054CE5C
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

		// Token: 0x1700ABE4 RID: 44004
		// (get) Token: 0x06026C6D RID: 158829 RVA: 0x0054ECBC File Offset: 0x0054CEBC
		public bool FixedPosition
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ABE5 RID: 44005
		// (get) Token: 0x06026C6E RID: 158830 RVA: 0x0054ECFC File Offset: 0x0054CEFC
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

		// Token: 0x06026C6F RID: 158831 RVA: 0x0054ED34 File Offset: 0x0054CF34
		public Span<byte> GetDefaultAbpStateBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06026C70 RID: 158832 RVA: 0x0054ED44 File Offset: 0x0054CF44
		public byte[] GetDefaultAbpStateArray()
		{
			return this.__p.__vector_as_array<byte>(42);
		}

		// Token: 0x1700ABE6 RID: 44006
		// (get) Token: 0x06026C71 RID: 158833 RVA: 0x0054ED54 File Offset: 0x0054CF54
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

		// Token: 0x1700ABE7 RID: 44007
		// (get) Token: 0x06026C72 RID: 158834 RVA: 0x0054ED94 File Offset: 0x0054CF94
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

		// Token: 0x06026C73 RID: 158835 RVA: 0x0054EDF4 File Offset: 0x0054CFF4
		public TNpcSpecialMark NpcSpecialMarksType(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return TNpcSpecialMark.NONE;
			}
			return (TNpcSpecialMark)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700ABE8 RID: 44008
		// (get) Token: 0x06026C74 RID: 158836 RVA: 0x0054EE34 File Offset: 0x0054D034
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

		// Token: 0x06026C75 RID: 158837 RVA: 0x0054EE60 File Offset: 0x0054D060
		public Span<TNpcSpecialMark> GetNpcSpecialMarksTypeBytes()
		{
			return this.__p.__vector_as_span<TNpcSpecialMark>(48, 1);
		}

		// Token: 0x06026C76 RID: 158838 RVA: 0x0054EE70 File Offset: 0x0054D070
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

		// Token: 0x06026C77 RID: 158839 RVA: 0x0054EEDC File Offset: 0x0054D0DC
		public TTable? NpcSpecialMarks<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700ABE9 RID: 44009
		// (get) Token: 0x06026C78 RID: 158840 RVA: 0x0054EF24 File Offset: 0x0054D124
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

		// Token: 0x06026C79 RID: 158841 RVA: 0x0054EF50 File Offset: 0x0054D150
		public EExtraMovementAbility ExtraMovementAbilities(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return EExtraMovementAbility.Diving;
			}
			return (EExtraMovementAbility)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700ABEA RID: 44010
		// (get) Token: 0x06026C7A RID: 158842 RVA: 0x0054EF90 File Offset: 0x0054D190
		public int ExtraMovementAbilitiesLength
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06026C7B RID: 158843 RVA: 0x0054EFBC File Offset: 0x0054D1BC
		public Span<EExtraMovementAbility> GetExtraMovementAbilitiesBytes()
		{
			return this.__p.__vector_as_span<EExtraMovementAbility>(52, 1);
		}

		// Token: 0x06026C7C RID: 158844 RVA: 0x0054EFCC File Offset: 0x0054D1CC
		public EExtraMovementAbility[] GetExtraMovementAbilitiesArray()
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EExtraMovementAbility[] array = new EExtraMovementAbility[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EExtraMovementAbility)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x1700ABEB RID: 44011
		// (get) Token: 0x06026C7D RID: 158845 RVA: 0x0054F038 File Offset: 0x0054D238
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026C7E RID: 158846 RVA: 0x0054F078 File Offset: 0x0054D278
		public static Offset<INpcPerformComponent> CreateINpcPerformComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IBaseRoleNpcPerform> SpecialNpcPerformConfigOffset = default(Offset<IBaseRoleNpcPerform>), bool IsStare = false, Offset<INpcHitShow> NpcHitShowOffset = default(Offset<INpcHitShow>), bool IsShowStrike = false, Offset<INpcBumpShow> NpcBumpShowOffset = default(Offset<INpcBumpShow>), Offset<INpcAwakeShow> ShowOnAwakeOffset = default(Offset<INpcAwakeShow>), TNpcStandbyShowOption ShowOnStandby_type = TNpcStandbyShowOption.NONE, int ShowOnStandbyOffset = 0, Offset<INpcPerformOnInteract> ShowOnInteractOffset = default(Offset<INpcPerformOnInteract>), VectorOffset ConditionalShowOnInteractsOffset = default(VectorOffset), TNpcUiInteractOption ShowOnUiInteract_type = TNpcUiInteractOption.NONE, int ShowOnUiInteractOffset = 0, VectorOffset ShowOnRideInVehicle_typeOffset = default(VectorOffset), VectorOffset ShowOnRideInVehicleOffset = default(VectorOffset), Offset<INpcPerformOnMonsterCloseby> NpcMonsterClosePerformOffset = default(Offset<INpcPerformOnMonsterCloseby>), Offset<INpcPerformState> NpcPerformStateOffset = default(Offset<INpcPerformState>), Offset<INpcDeathInteract> DeathInteractOffset = default(Offset<INpcDeathInteract>), bool FixedPosition = false, StringOffset DefaultAbpStateOffset = default(StringOffset), int DefaultFaceExpressionId = 0, Offset<INpcDefaultPerform> DefaultPerformOffset = default(Offset<INpcDefaultPerform>), VectorOffset NpcSpecialMarks_typeOffset = default(VectorOffset), VectorOffset NpcSpecialMarksOffset = default(VectorOffset), VectorOffset ExtraMovementAbilitiesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(26);
			INpcPerformComponent.AddExtraMovementAbilities(builder, ExtraMovementAbilitiesOffset);
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

		// Token: 0x06026C7F RID: 158847 RVA: 0x0054F160 File Offset: 0x0054D360
		public static void StartINpcPerformComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(26);
		}

		// Token: 0x06026C80 RID: 158848 RVA: 0x0054F16A File Offset: 0x0054D36A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026C81 RID: 158849 RVA: 0x0054F175 File Offset: 0x0054D375
		public static void AddSpecialNpcPerformConfig(FlatBufferBuilder builder, Offset<IBaseRoleNpcPerform> specialNpcPerformConfigOffset)
		{
			builder.AddOffset(1, specialNpcPerformConfigOffset.Value, 0);
		}

		// Token: 0x06026C82 RID: 158850 RVA: 0x0054F185 File Offset: 0x0054D385
		public static void AddIsStare(FlatBufferBuilder builder, bool isStare)
		{
			builder.AddBool(2, isStare, false);
		}

		// Token: 0x06026C83 RID: 158851 RVA: 0x0054F190 File Offset: 0x0054D390
		public static void AddNpcHitShow(FlatBufferBuilder builder, Offset<INpcHitShow> npcHitShowOffset)
		{
			builder.AddOffset(3, npcHitShowOffset.Value, 0);
		}

		// Token: 0x06026C84 RID: 158852 RVA: 0x0054F1A0 File Offset: 0x0054D3A0
		public static void AddIsShowStrike(FlatBufferBuilder builder, bool isShowStrike)
		{
			builder.AddBool(4, isShowStrike, false);
		}

		// Token: 0x06026C85 RID: 158853 RVA: 0x0054F1AB File Offset: 0x0054D3AB
		public static void AddNpcBumpShow(FlatBufferBuilder builder, Offset<INpcBumpShow> npcBumpShowOffset)
		{
			builder.AddOffset(5, npcBumpShowOffset.Value, 0);
		}

		// Token: 0x06026C86 RID: 158854 RVA: 0x0054F1BB File Offset: 0x0054D3BB
		public static void AddShowOnAwake(FlatBufferBuilder builder, Offset<INpcAwakeShow> showOnAwakeOffset)
		{
			builder.AddOffset(6, showOnAwakeOffset.Value, 0);
		}

		// Token: 0x06026C87 RID: 158855 RVA: 0x0054F1CB File Offset: 0x0054D3CB
		public static void AddShowOnStandbyType(FlatBufferBuilder builder, TNpcStandbyShowOption showOnStandbyType)
		{
			builder.AddByte(7, (byte)showOnStandbyType, 0);
		}

		// Token: 0x06026C88 RID: 158856 RVA: 0x0054F1D6 File Offset: 0x0054D3D6
		public static void AddShowOnStandby(FlatBufferBuilder builder, int showOnStandbyOffset)
		{
			builder.AddOffset(8, showOnStandbyOffset, 0);
		}

		// Token: 0x06026C89 RID: 158857 RVA: 0x0054F1E1 File Offset: 0x0054D3E1
		public static void AddShowOnInteract(FlatBufferBuilder builder, Offset<INpcPerformOnInteract> showOnInteractOffset)
		{
			builder.AddOffset(9, showOnInteractOffset.Value, 0);
		}

		// Token: 0x06026C8A RID: 158858 RVA: 0x0054F1F2 File Offset: 0x0054D3F2
		public static void AddConditionalShowOnInteracts(FlatBufferBuilder builder, VectorOffset conditionalShowOnInteractsOffset)
		{
			builder.AddOffset(10, conditionalShowOnInteractsOffset.Value, 0);
		}

		// Token: 0x06026C8B RID: 158859 RVA: 0x0054F204 File Offset: 0x0054D404
		public static VectorOffset CreateConditionalShowOnInteractsVector(FlatBufferBuilder builder, Offset<IConditionalNpcPerformOnInteract>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026C8C RID: 158860 RVA: 0x0054F244 File Offset: 0x0054D444
		public static VectorOffset CreateConditionalShowOnInteractsVectorBlock(FlatBufferBuilder builder, Offset<IConditionalNpcPerformOnInteract>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionalNpcPerformOnInteract>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026C8D RID: 158861 RVA: 0x0054F25E File Offset: 0x0054D45E
		public static VectorOffset CreateConditionalShowOnInteractsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionalNpcPerformOnInteract>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionalNpcPerformOnInteract>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026C8E RID: 158862 RVA: 0x0054F27C File Offset: 0x0054D47C
		public static VectorOffset CreateConditionalShowOnInteractsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionalNpcPerformOnInteract>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026C8F RID: 158863 RVA: 0x0054F295 File Offset: 0x0054D495
		public static void StartConditionalShowOnInteractsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026C90 RID: 158864 RVA: 0x0054F2A0 File Offset: 0x0054D4A0
		public static void AddShowOnUiInteractType(FlatBufferBuilder builder, TNpcUiInteractOption showOnUiInteractType)
		{
			builder.AddByte(11, (byte)showOnUiInteractType, 0);
		}

		// Token: 0x06026C91 RID: 158865 RVA: 0x0054F2AC File Offset: 0x0054D4AC
		public static void AddShowOnUiInteract(FlatBufferBuilder builder, int showOnUiInteractOffset)
		{
			builder.AddOffset(12, showOnUiInteractOffset, 0);
		}

		// Token: 0x06026C92 RID: 158866 RVA: 0x0054F2B8 File Offset: 0x0054D4B8
		public static void AddShowOnRideInVehicleType(FlatBufferBuilder builder, VectorOffset showOnRideInVehicleTypeOffset)
		{
			builder.AddOffset(13, showOnRideInVehicleTypeOffset.Value, 0);
		}

		// Token: 0x06026C93 RID: 158867 RVA: 0x0054F2CC File Offset: 0x0054D4CC
		public static VectorOffset CreateShowOnRideInVehicleTypeVector(FlatBufferBuilder builder, TNpcRideInVehiclePerformType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026C94 RID: 158868 RVA: 0x0054F303 File Offset: 0x0054D503
		public static VectorOffset CreateShowOnRideInVehicleTypeVectorBlock(FlatBufferBuilder builder, TNpcRideInVehiclePerformType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TNpcRideInVehiclePerformType>(data);
			return builder.EndVector();
		}

		// Token: 0x06026C95 RID: 158869 RVA: 0x0054F31D File Offset: 0x0054D51D
		public static VectorOffset CreateShowOnRideInVehicleTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TNpcRideInVehiclePerformType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TNpcRideInVehiclePerformType>(data);
			return builder.EndVector();
		}

		// Token: 0x06026C96 RID: 158870 RVA: 0x0054F33B File Offset: 0x0054D53B
		public static VectorOffset CreateShowOnRideInVehicleTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TNpcRideInVehiclePerformType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026C97 RID: 158871 RVA: 0x0054F354 File Offset: 0x0054D554
		public static void StartShowOnRideInVehicleTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06026C98 RID: 158872 RVA: 0x0054F35F File Offset: 0x0054D55F
		public static void AddShowOnRideInVehicle(FlatBufferBuilder builder, VectorOffset showOnRideInVehicleOffset)
		{
			builder.AddOffset(14, showOnRideInVehicleOffset.Value, 0);
		}

		// Token: 0x06026C99 RID: 158873 RVA: 0x0054F370 File Offset: 0x0054D570
		public static VectorOffset CreateShowOnRideInVehicleVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026C9A RID: 158874 RVA: 0x0054F3A7 File Offset: 0x0054D5A7
		public static VectorOffset CreateShowOnRideInVehicleVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026C9B RID: 158875 RVA: 0x0054F3C1 File Offset: 0x0054D5C1
		public static VectorOffset CreateShowOnRideInVehicleVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026C9C RID: 158876 RVA: 0x0054F3DF File Offset: 0x0054D5DF
		public static VectorOffset CreateShowOnRideInVehicleVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026C9D RID: 158877 RVA: 0x0054F3F8 File Offset: 0x0054D5F8
		public static void StartShowOnRideInVehicleVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026C9E RID: 158878 RVA: 0x0054F403 File Offset: 0x0054D603
		public static void AddNpcMonsterClosePerform(FlatBufferBuilder builder, Offset<INpcPerformOnMonsterCloseby> npcMonsterClosePerformOffset)
		{
			builder.AddOffset(15, npcMonsterClosePerformOffset.Value, 0);
		}

		// Token: 0x06026C9F RID: 158879 RVA: 0x0054F414 File Offset: 0x0054D614
		public static void AddNpcPerformState(FlatBufferBuilder builder, Offset<INpcPerformState> npcPerformStateOffset)
		{
			builder.AddOffset(16, npcPerformStateOffset.Value, 0);
		}

		// Token: 0x06026CA0 RID: 158880 RVA: 0x0054F425 File Offset: 0x0054D625
		public static void AddDeathInteract(FlatBufferBuilder builder, Offset<INpcDeathInteract> deathInteractOffset)
		{
			builder.AddOffset(17, deathInteractOffset.Value, 0);
		}

		// Token: 0x06026CA1 RID: 158881 RVA: 0x0054F436 File Offset: 0x0054D636
		public static void AddFixedPosition(FlatBufferBuilder builder, bool fixedPosition)
		{
			builder.AddBool(18, fixedPosition, false);
		}

		// Token: 0x06026CA2 RID: 158882 RVA: 0x0054F442 File Offset: 0x0054D642
		public static void AddDefaultAbpState(FlatBufferBuilder builder, StringOffset defaultAbpStateOffset)
		{
			builder.AddOffset(19, defaultAbpStateOffset.Value, 0);
		}

		// Token: 0x06026CA3 RID: 158883 RVA: 0x0054F453 File Offset: 0x0054D653
		public static void AddDefaultFaceExpressionId(FlatBufferBuilder builder, int defaultFaceExpressionId)
		{
			builder.AddInt(20, defaultFaceExpressionId, 0);
		}

		// Token: 0x06026CA4 RID: 158884 RVA: 0x0054F45F File Offset: 0x0054D65F
		public static void AddDefaultPerform(FlatBufferBuilder builder, Offset<INpcDefaultPerform> defaultPerformOffset)
		{
			builder.AddOffset(21, defaultPerformOffset.Value, 0);
		}

		// Token: 0x06026CA5 RID: 158885 RVA: 0x0054F470 File Offset: 0x0054D670
		public static void AddNpcSpecialMarksType(FlatBufferBuilder builder, VectorOffset npcSpecialMarksTypeOffset)
		{
			builder.AddOffset(22, npcSpecialMarksTypeOffset.Value, 0);
		}

		// Token: 0x06026CA6 RID: 158886 RVA: 0x0054F484 File Offset: 0x0054D684
		public static VectorOffset CreateNpcSpecialMarksTypeVector(FlatBufferBuilder builder, TNpcSpecialMark[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026CA7 RID: 158887 RVA: 0x0054F4BB File Offset: 0x0054D6BB
		public static VectorOffset CreateNpcSpecialMarksTypeVectorBlock(FlatBufferBuilder builder, TNpcSpecialMark[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TNpcSpecialMark>(data);
			return builder.EndVector();
		}

		// Token: 0x06026CA8 RID: 158888 RVA: 0x0054F4D5 File Offset: 0x0054D6D5
		public static VectorOffset CreateNpcSpecialMarksTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TNpcSpecialMark> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TNpcSpecialMark>(data);
			return builder.EndVector();
		}

		// Token: 0x06026CA9 RID: 158889 RVA: 0x0054F4F3 File Offset: 0x0054D6F3
		public static VectorOffset CreateNpcSpecialMarksTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TNpcSpecialMark>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026CAA RID: 158890 RVA: 0x0054F50C File Offset: 0x0054D70C
		public static void StartNpcSpecialMarksTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06026CAB RID: 158891 RVA: 0x0054F517 File Offset: 0x0054D717
		public static void AddNpcSpecialMarks(FlatBufferBuilder builder, VectorOffset npcSpecialMarksOffset)
		{
			builder.AddOffset(23, npcSpecialMarksOffset.Value, 0);
		}

		// Token: 0x06026CAC RID: 158892 RVA: 0x0054F528 File Offset: 0x0054D728
		public static VectorOffset CreateNpcSpecialMarksVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026CAD RID: 158893 RVA: 0x0054F55F File Offset: 0x0054D75F
		public static VectorOffset CreateNpcSpecialMarksVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026CAE RID: 158894 RVA: 0x0054F579 File Offset: 0x0054D779
		public static VectorOffset CreateNpcSpecialMarksVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026CAF RID: 158895 RVA: 0x0054F597 File Offset: 0x0054D797
		public static VectorOffset CreateNpcSpecialMarksVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026CB0 RID: 158896 RVA: 0x0054F5B0 File Offset: 0x0054D7B0
		public static void StartNpcSpecialMarksVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026CB1 RID: 158897 RVA: 0x0054F5BB File Offset: 0x0054D7BB
		public static void AddExtraMovementAbilities(FlatBufferBuilder builder, VectorOffset extraMovementAbilitiesOffset)
		{
			builder.AddOffset(24, extraMovementAbilitiesOffset.Value, 0);
		}

		// Token: 0x06026CB2 RID: 158898 RVA: 0x0054F5CC File Offset: 0x0054D7CC
		public static VectorOffset CreateExtraMovementAbilitiesVector(FlatBufferBuilder builder, EExtraMovementAbility[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026CB3 RID: 158899 RVA: 0x0054F603 File Offset: 0x0054D803
		public static VectorOffset CreateExtraMovementAbilitiesVectorBlock(FlatBufferBuilder builder, EExtraMovementAbility[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EExtraMovementAbility>(data);
			return builder.EndVector();
		}

		// Token: 0x06026CB4 RID: 158900 RVA: 0x0054F61D File Offset: 0x0054D81D
		public static VectorOffset CreateExtraMovementAbilitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<EExtraMovementAbility> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EExtraMovementAbility>(data);
			return builder.EndVector();
		}

		// Token: 0x06026CB5 RID: 158901 RVA: 0x0054F63B File Offset: 0x0054D83B
		public static VectorOffset CreateExtraMovementAbilitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EExtraMovementAbility>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026CB6 RID: 158902 RVA: 0x0054F654 File Offset: 0x0054D854
		public static void StartExtraMovementAbilitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06026CB7 RID: 158903 RVA: 0x0054F65F File Offset: 0x0054D85F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(25, nullMask, 0);
		}

		// Token: 0x06026CB8 RID: 158904 RVA: 0x0054F66B File Offset: 0x0054D86B
		public static Offset<INpcPerformComponent> EndINpcPerformComponent(FlatBufferBuilder builder)
		{
			return new Offset<INpcPerformComponent>(builder.EndTable());
		}

		// Token: 0x06026CB9 RID: 158905 RVA: 0x0054F678 File Offset: 0x0054D878
		public INpcPerformComponentT UnPack()
		{
			INpcPerformComponentT npcPerformComponentT = new INpcPerformComponentT();
			this.UnPackTo(npcPerformComponentT);
			return npcPerformComponentT;
		}

		// Token: 0x06026CBA RID: 158906 RVA: 0x0054F694 File Offset: 0x0054D894
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
				switch (this.NpcSpecialMarksType(k))
				{
				case TNpcSpecialMark.INpcSpecialMarkIgnoreCameraHideNpc:
					tnpcSpecialMarkUnion.Value = ((this.NpcSpecialMarks<INpcSpecialMarkIgnoreCameraHideNpc>(k) != null) ? this.NpcSpecialMarks<INpcSpecialMarkIgnoreCameraHideNpc>(k).Value.UnPack() : null);
					break;
				case TNpcSpecialMark.INpcSpecialMarkTrafficLight:
					tnpcSpecialMarkUnion.Value = ((this.NpcSpecialMarks<INpcSpecialMarkTrafficLight>(k) != null) ? this.NpcSpecialMarks<INpcSpecialMarkTrafficLight>(k).Value.UnPack() : null);
					break;
				case TNpcSpecialMark.INpcSpecialMarkTriggerBlueprintFootprintEvent:
					tnpcSpecialMarkUnion.Value = ((this.NpcSpecialMarks<INpcSpecialMarkTriggerBlueprintFootprintEvent>(k) != null) ? this.NpcSpecialMarks<INpcSpecialMarkTriggerBlueprintFootprintEvent>(k).Value.UnPack() : null);
					break;
				}
				_o.NpcSpecialMarks.Add(tnpcSpecialMarkUnion);
			}
			_o.ExtraMovementAbilities = new List<EExtraMovementAbility>();
			for (int l = 0; l < this.ExtraMovementAbilitiesLength; l++)
			{
				_o.ExtraMovementAbilities.Add(this.ExtraMovementAbilities(l));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026CBB RID: 158907 RVA: 0x0054FF7C File Offset: 0x0054E17C
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
			VectorOffset extraMovementAbilitiesOffset = default(VectorOffset);
			if (_o.ExtraMovementAbilities != null)
			{
				EExtraMovementAbility[] data = _o.ExtraMovementAbilities.ToArray();
				extraMovementAbilitiesOffset = INpcPerformComponent.CreateExtraMovementAbilitiesVector(builder, data);
			}
			return INpcPerformComponent.CreateINpcPerformComponent(builder, _o.Disabled, specialNpcPerformConfigOffset, _o.IsStare, npcHitShowOffset, _o.IsShowStrike, npcBumpShowOffset, showOnAwakeOffset, showOnStandby_type, showOnStandbyOffset, showOnInteractOffset, conditionalShowOnInteractsOffset, showOnUiInteract_type, showOnUiInteractOffset, showOnRideInVehicle_typeOffset, showOnRideInVehicleOffset, npcMonsterClosePerformOffset, npcPerformStateOffset, deathInteractOffset, _o.FixedPosition, defaultAbpStateOffset, _o.DefaultFaceExpressionId, defaultPerformOffset, npcSpecialMarks_typeOffset, npcSpecialMarksOffset, extraMovementAbilitiesOffset, _o.NullMask);
		}

		// Token: 0x0400F625 RID: 63013
		private Table __p;
	}
}
