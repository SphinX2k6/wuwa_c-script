using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200541B RID: 21531
	public struct IBaseInfoComponent : IFlatbufferObject
	{
		// Token: 0x17009881 RID: 39041
		// (get) Token: 0x06021AED RID: 137965 RVA: 0x004A46F2 File Offset: 0x004A28F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021AEE RID: 137966 RVA: 0x004A46FF File Offset: 0x004A28FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021AEF RID: 137967 RVA: 0x004A4708 File Offset: 0x004A2908
		public static IBaseInfoComponent GetRootAsIBaseInfoComponent(ByteBuffer _bb)
		{
			return IBaseInfoComponent.GetRootAsIBaseInfoComponent(_bb, default(IBaseInfoComponent));
		}

		// Token: 0x06021AF0 RID: 137968 RVA: 0x004A4724 File Offset: 0x004A2924
		public static IBaseInfoComponent GetRootAsIBaseInfoComponent(ByteBuffer _bb, IBaseInfoComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021AF1 RID: 137969 RVA: 0x004A4741 File Offset: 0x004A2941
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021AF2 RID: 137970 RVA: 0x004A4750 File Offset: 0x004A2950
		public IBaseInfoComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009882 RID: 39042
		// (get) Token: 0x06021AF3 RID: 137971 RVA: 0x004A4760 File Offset: 0x004A2960
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009883 RID: 39043
		// (get) Token: 0x06021AF4 RID: 137972 RVA: 0x004A47A0 File Offset: 0x004A29A0
		public string TidName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021AF5 RID: 137973 RVA: 0x004A47D7 File Offset: 0x004A29D7
		public Span<byte> GetTidNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06021AF6 RID: 137974 RVA: 0x004A47E6 File Offset: 0x004A29E6
		public byte[] GetTidNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009884 RID: 39044
		// (get) Token: 0x06021AF7 RID: 137975 RVA: 0x004A47F4 File Offset: 0x004A29F4
		public bool IsShowNameOnHead
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009885 RID: 39045
		// (get) Token: 0x06021AF8 RID: 137976 RVA: 0x004A4834 File Offset: 0x004A2A34
		public IEntityCategory? Category
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IEntityCategory?(default(IEntityCategory).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009886 RID: 39046
		// (get) Token: 0x06021AF9 RID: 137977 RVA: 0x004A4894 File Offset: 0x004A2A94
		public IEntityScanFunction? ScanFunction
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IEntityScanFunction?(default(IEntityScanFunction).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009887 RID: 39047
		// (get) Token: 0x06021AFA RID: 137978 RVA: 0x004A48F4 File Offset: 0x004A2AF4
		public int HeadInfo
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009888 RID: 39048
		// (get) Token: 0x06021AFB RID: 137979 RVA: 0x004A4934 File Offset: 0x004A2B34
		public ECamp Camp
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return ECamp.Player;
				}
				return (ECamp)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009889 RID: 39049
		// (get) Token: 0x06021AFC RID: 137980 RVA: 0x004A4974 File Offset: 0x004A2B74
		public EAoiLayer AoiLayer
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return EAoiLayer.Default;
				}
				return (EAoiLayer)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700988A RID: 39050
		// (get) Token: 0x06021AFD RID: 137981 RVA: 0x004A49B4 File Offset: 0x004A2BB4
		public EAoizRadius AoiZRadius
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return EAoizRadius.Default;
				}
				return (EAoizRadius)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700988B RID: 39051
		// (get) Token: 0x06021AFE RID: 137982 RVA: 0x004A49F4 File Offset: 0x004A2BF4
		public string AoiGroupKey
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021AFF RID: 137983 RVA: 0x004A4A2C File Offset: 0x004A2C2C
		public Span<byte> GetAoiGroupKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06021B00 RID: 137984 RVA: 0x004A4A3C File Offset: 0x004A2C3C
		public byte[] GetAoiGroupKeyArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700988C RID: 39052
		// (get) Token: 0x06021B01 RID: 137985 RVA: 0x004A4A4C File Offset: 0x004A2C4C
		public bool IsAoiFitterPlatform
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700988D RID: 39053
		// (get) Token: 0x06021B02 RID: 137986 RVA: 0x004A4A8C File Offset: 0x004A2C8C
		public ICustomAoizRadius? CustomAoiZRadius
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return new ICustomAoizRadius?(default(ICustomAoizRadius).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700988E RID: 39054
		// (get) Token: 0x06021B03 RID: 137987 RVA: 0x004A4AEC File Offset: 0x004A2CEC
		public int MapIcon
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700988F RID: 39055
		// (get) Token: 0x06021B04 RID: 137988 RVA: 0x004A4B2C File Offset: 0x004A2D2C
		public int PackId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009890 RID: 39056
		// (get) Token: 0x06021B05 RID: 137989 RVA: 0x004A4B6C File Offset: 0x004A2D6C
		public string Occupation
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021B06 RID: 137990 RVA: 0x004A4BA4 File Offset: 0x004A2DA4
		public Span<byte> GetOccupationBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06021B07 RID: 137991 RVA: 0x004A4BB4 File Offset: 0x004A2DB4
		public byte[] GetOccupationArray()
		{
			return this.__p.__vector_as_array<byte>(32);
		}

		// Token: 0x17009891 RID: 39057
		// (get) Token: 0x06021B08 RID: 137992 RVA: 0x004A4BC4 File Offset: 0x004A2DC4
		public IHeadStateViewConfig? HeadStateViewConfig
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return new IHeadStateViewConfig?(default(IHeadStateViewConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009892 RID: 39058
		// (get) Token: 0x06021B09 RID: 137993 RVA: 0x004A4C24 File Offset: 0x004A2E24
		public int EntityPropertyId
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009893 RID: 39059
		// (get) Token: 0x06021B0A RID: 137994 RVA: 0x004A4C64 File Offset: 0x004A2E64
		public int FocusPriority
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009894 RID: 39060
		// (get) Token: 0x06021B0B RID: 137995 RVA: 0x004A4CA4 File Offset: 0x004A2EA4
		public EOnlineInteractType OnlineInteractType
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return EOnlineInteractType.HostOnly;
				}
				return (EOnlineInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009895 RID: 39061
		// (get) Token: 0x06021B0C RID: 137996 RVA: 0x004A4CE4 File Offset: 0x004A2EE4
		public bool NotAllowHidedByTargetRange
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009896 RID: 39062
		// (get) Token: 0x06021B0D RID: 137997 RVA: 0x004A4D24 File Offset: 0x004A2F24
		public ENpcDensity LowerNpcDensity
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return ENpcDensity.Middle;
				}
				return (ENpcDensity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021B0E RID: 137998 RVA: 0x004A4D64 File Offset: 0x004A2F64
		public int DataLayers(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009897 RID: 39063
		// (get) Token: 0x06021B0F RID: 137999 RVA: 0x004A4DA4 File Offset: 0x004A2FA4
		public int DataLayersLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06021B10 RID: 138000 RVA: 0x004A4DD0 File Offset: 0x004A2FD0
		public Span<int> GetDataLayersBytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x06021B11 RID: 138001 RVA: 0x004A4DE0 File Offset: 0x004A2FE0
		public int[] GetDataLayersArray()
		{
			return this.__p.__vector_as_array<int>(46);
		}

		// Token: 0x06021B12 RID: 138002 RVA: 0x004A4DF0 File Offset: 0x004A2FF0
		public int ChildEntityIds(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009898 RID: 39064
		// (get) Token: 0x06021B13 RID: 138003 RVA: 0x004A4E30 File Offset: 0x004A3030
		public int ChildEntityIdsLength
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

		// Token: 0x06021B14 RID: 138004 RVA: 0x004A4E5C File Offset: 0x004A305C
		public Span<int> GetChildEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(48, 4);
		}

		// Token: 0x06021B15 RID: 138005 RVA: 0x004A4E6C File Offset: 0x004A306C
		public int[] GetChildEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(48);
		}

		// Token: 0x17009899 RID: 39065
		// (get) Token: 0x06021B16 RID: 138006 RVA: 0x004A4E7C File Offset: 0x004A307C
		public bool IsOnlineStandalone
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06021B17 RID: 138007 RVA: 0x004A4EBC File Offset: 0x004A30BC
		public string SpecifiedOnlineStandaloneParentUids(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700989A RID: 39066
		// (get) Token: 0x06021B18 RID: 138008 RVA: 0x004A4EF8 File Offset: 0x004A30F8
		public int SpecifiedOnlineStandaloneParentUidsLength
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

		// Token: 0x1700989B RID: 39067
		// (get) Token: 0x06021B19 RID: 138009 RVA: 0x004A4F24 File Offset: 0x004A3124
		public IFixProcessor? FixProcessor
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return new IFixProcessor?(default(IFixProcessor).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700989C RID: 39068
		// (get) Token: 0x06021B1A RID: 138010 RVA: 0x004A4F84 File Offset: 0x004A3184
		public EEntityUpdateStrategy EntityUpdateStrategy
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return EEntityUpdateStrategy.Custom;
				}
				return (EEntityUpdateStrategy)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700989D RID: 39069
		// (get) Token: 0x06021B1B RID: 138011 RVA: 0x004A4FC4 File Offset: 0x004A31C4
		public EMaterialUpdateStrategy MaterialUpdateStrategy
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return EMaterialUpdateStrategy.Custom;
				}
				return (EMaterialUpdateStrategy)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700989E RID: 39070
		// (get) Token: 0x06021B1C RID: 138012 RVA: 0x004A5004 File Offset: 0x004A3204
		public ETimeScaleModifyStrategy TimeScaleModifyStrategy
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return ETimeScaleModifyStrategy.Default;
				}
				return (ETimeScaleModifyStrategy)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700989F RID: 39071
		// (get) Token: 0x06021B1D RID: 138013 RVA: 0x004A5044 File Offset: 0x004A3244
		public IEntityGravityConfig? GravityConfig
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return null;
				}
				return new IEntityGravityConfig?(default(IEntityGravityConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06021B1E RID: 138014 RVA: 0x004A50A4 File Offset: 0x004A32A4
		public IHeadInfoChangeData? HeadInfoChangeConfig(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return null;
			}
			return new IHeadInfoChangeData?(default(IHeadInfoChangeData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170098A0 RID: 39072
		// (get) Token: 0x06021B1F RID: 138015 RVA: 0x004A5108 File Offset: 0x004A3308
		public int HeadInfoChangeConfigLength
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170098A1 RID: 39073
		// (get) Token: 0x06021B20 RID: 138016 RVA: 0x004A5134 File Offset: 0x004A3334
		public bool IsForceDestroy
		{
			get
			{
				int num = this.__p.__offset(66);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170098A2 RID: 39074
		// (get) Token: 0x06021B21 RID: 138017 RVA: 0x004A5174 File Offset: 0x004A3374
		public ITimeScaleConfig? TimeScaleConfig
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return null;
				}
				return new ITimeScaleConfig?(default(ITimeScaleConfig).__assign(num + this.__p.bb_pos, this.__p.bb));
			}
		}

		// Token: 0x06021B22 RID: 138018 RVA: 0x004A51C8 File Offset: 0x004A33C8
		public IEntityAttachPoint? EntityAttachPointList(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return new IEntityAttachPoint?(default(IEntityAttachPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170098A3 RID: 39075
		// (get) Token: 0x06021B23 RID: 138019 RVA: 0x004A522C File Offset: 0x004A342C
		public int EntityAttachPointListLength
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170098A4 RID: 39076
		// (get) Token: 0x06021B24 RID: 138020 RVA: 0x004A5258 File Offset: 0x004A3458
		public int DelayDestroyDistance
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170098A5 RID: 39077
		// (get) Token: 0x06021B25 RID: 138021 RVA: 0x004A5298 File Offset: 0x004A3498
		public EClientEntityMark IsClientEntityFlag
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return EClientEntityMark.ServerEntity;
				}
				return (EClientEntityMark)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170098A6 RID: 39078
		// (get) Token: 0x06021B26 RID: 138022 RVA: 0x004A52D8 File Offset: 0x004A34D8
		public bool KeepAnimationRateWithShadow
		{
			get
			{
				int num = this.__p.__offset(76);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170098A7 RID: 39079
		// (get) Token: 0x06021B27 RID: 138023 RVA: 0x004A5318 File Offset: 0x004A3518
		public uint NullMask
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return 0U;
				}
				return this.__p.bb.GetUint(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021B28 RID: 138024 RVA: 0x004A5358 File Offset: 0x004A3558
		public static Offset<IBaseInfoComponent> CreateIBaseInfoComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset TidNameOffset = default(StringOffset), bool IsShowNameOnHead = false, Offset<IEntityCategory> CategoryOffset = default(Offset<IEntityCategory>), Offset<IEntityScanFunction> ScanFunctionOffset = default(Offset<IEntityScanFunction>), int HeadInfo = 0, ECamp Camp = ECamp.Player, EAoiLayer AoiLayer = EAoiLayer.Default, EAoizRadius AoiZRadius = EAoizRadius.Default, StringOffset AoiGroupKeyOffset = default(StringOffset), bool IsAoiFitterPlatform = false, Offset<ICustomAoizRadius> CustomAoiZRadiusOffset = default(Offset<ICustomAoizRadius>), int MapIcon = 0, int PackId = 0, StringOffset OccupationOffset = default(StringOffset), Offset<IHeadStateViewConfig> HeadStateViewConfigOffset = default(Offset<IHeadStateViewConfig>), int EntityPropertyId = 0, int FocusPriority = 0, EOnlineInteractType OnlineInteractType = EOnlineInteractType.HostOnly, bool NotAllowHidedByTargetRange = false, ENpcDensity LowerNpcDensity = ENpcDensity.Middle, VectorOffset DataLayersOffset = default(VectorOffset), VectorOffset ChildEntityIdsOffset = default(VectorOffset), bool IsOnlineStandalone = false, VectorOffset SpecifiedOnlineStandaloneParentUidsOffset = default(VectorOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), EEntityUpdateStrategy EntityUpdateStrategy = EEntityUpdateStrategy.Custom, EMaterialUpdateStrategy MaterialUpdateStrategy = EMaterialUpdateStrategy.Custom, ETimeScaleModifyStrategy TimeScaleModifyStrategy = ETimeScaleModifyStrategy.Default, Offset<IEntityGravityConfig> GravityConfigOffset = default(Offset<IEntityGravityConfig>), VectorOffset HeadInfoChangeConfigOffset = default(VectorOffset), bool IsForceDestroy = false, ITimeScaleConfigT TimeScaleConfig = null, VectorOffset EntityAttachPointListOffset = default(VectorOffset), int DelayDestroyDistance = 0, EClientEntityMark IsClientEntityFlag = EClientEntityMark.ServerEntity, bool KeepAnimationRateWithShadow = false, uint NullMask = 0U)
		{
			builder.StartTable(38);
			IBaseInfoComponent.AddNullMask(builder, NullMask);
			IBaseInfoComponent.AddDelayDestroyDistance(builder, DelayDestroyDistance);
			IBaseInfoComponent.AddEntityAttachPointList(builder, EntityAttachPointListOffset);
			IBaseInfoComponent.AddTimeScaleConfig(builder, ITimeScaleConfig.Pack(builder, TimeScaleConfig));
			IBaseInfoComponent.AddHeadInfoChangeConfig(builder, HeadInfoChangeConfigOffset);
			IBaseInfoComponent.AddGravityConfig(builder, GravityConfigOffset);
			IBaseInfoComponent.AddFixProcessor(builder, FixProcessorOffset);
			IBaseInfoComponent.AddSpecifiedOnlineStandaloneParentUids(builder, SpecifiedOnlineStandaloneParentUidsOffset);
			IBaseInfoComponent.AddChildEntityIds(builder, ChildEntityIdsOffset);
			IBaseInfoComponent.AddDataLayers(builder, DataLayersOffset);
			IBaseInfoComponent.AddFocusPriority(builder, FocusPriority);
			IBaseInfoComponent.AddEntityPropertyId(builder, EntityPropertyId);
			IBaseInfoComponent.AddHeadStateViewConfig(builder, HeadStateViewConfigOffset);
			IBaseInfoComponent.AddOccupation(builder, OccupationOffset);
			IBaseInfoComponent.AddPackId(builder, PackId);
			IBaseInfoComponent.AddMapIcon(builder, MapIcon);
			IBaseInfoComponent.AddCustomAoiZRadius(builder, CustomAoiZRadiusOffset);
			IBaseInfoComponent.AddAoiGroupKey(builder, AoiGroupKeyOffset);
			IBaseInfoComponent.AddHeadInfo(builder, HeadInfo);
			IBaseInfoComponent.AddScanFunction(builder, ScanFunctionOffset);
			IBaseInfoComponent.AddCategory(builder, CategoryOffset);
			IBaseInfoComponent.AddTidName(builder, TidNameOffset);
			IBaseInfoComponent.AddKeepAnimationRateWithShadow(builder, KeepAnimationRateWithShadow);
			IBaseInfoComponent.AddIsClientEntityFlag(builder, IsClientEntityFlag);
			IBaseInfoComponent.AddIsForceDestroy(builder, IsForceDestroy);
			IBaseInfoComponent.AddTimeScaleModifyStrategy(builder, TimeScaleModifyStrategy);
			IBaseInfoComponent.AddMaterialUpdateStrategy(builder, MaterialUpdateStrategy);
			IBaseInfoComponent.AddEntityUpdateStrategy(builder, EntityUpdateStrategy);
			IBaseInfoComponent.AddIsOnlineStandalone(builder, IsOnlineStandalone);
			IBaseInfoComponent.AddLowerNpcDensity(builder, LowerNpcDensity);
			IBaseInfoComponent.AddNotAllowHidedByTargetRange(builder, NotAllowHidedByTargetRange);
			IBaseInfoComponent.AddOnlineInteractType(builder, OnlineInteractType);
			IBaseInfoComponent.AddIsAoiFitterPlatform(builder, IsAoiFitterPlatform);
			IBaseInfoComponent.AddAoiZRadius(builder, AoiZRadius);
			IBaseInfoComponent.AddAoiLayer(builder, AoiLayer);
			IBaseInfoComponent.AddCamp(builder, Camp);
			IBaseInfoComponent.AddIsShowNameOnHead(builder, IsShowNameOnHead);
			IBaseInfoComponent.AddDisabled(builder, Disabled);
			return IBaseInfoComponent.EndIBaseInfoComponent(builder);
		}

		// Token: 0x06021B29 RID: 138025 RVA: 0x004A54A6 File Offset: 0x004A36A6
		public static void StartIBaseInfoComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(38);
		}

		// Token: 0x06021B2A RID: 138026 RVA: 0x004A54B0 File Offset: 0x004A36B0
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021B2B RID: 138027 RVA: 0x004A54BB File Offset: 0x004A36BB
		public static void AddTidName(FlatBufferBuilder builder, StringOffset tidNameOffset)
		{
			builder.AddOffset(1, tidNameOffset.Value, 0);
		}

		// Token: 0x06021B2C RID: 138028 RVA: 0x004A54CB File Offset: 0x004A36CB
		public static void AddIsShowNameOnHead(FlatBufferBuilder builder, bool isShowNameOnHead)
		{
			builder.AddBool(2, isShowNameOnHead, false);
		}

		// Token: 0x06021B2D RID: 138029 RVA: 0x004A54D6 File Offset: 0x004A36D6
		public static void AddCategory(FlatBufferBuilder builder, Offset<IEntityCategory> categoryOffset)
		{
			builder.AddOffset(3, categoryOffset.Value, 0);
		}

		// Token: 0x06021B2E RID: 138030 RVA: 0x004A54E6 File Offset: 0x004A36E6
		public static void AddScanFunction(FlatBufferBuilder builder, Offset<IEntityScanFunction> scanFunctionOffset)
		{
			builder.AddOffset(4, scanFunctionOffset.Value, 0);
		}

		// Token: 0x06021B2F RID: 138031 RVA: 0x004A54F6 File Offset: 0x004A36F6
		public static void AddHeadInfo(FlatBufferBuilder builder, int headInfo)
		{
			builder.AddInt(5, headInfo, 0);
		}

		// Token: 0x06021B30 RID: 138032 RVA: 0x004A5501 File Offset: 0x004A3701
		public static void AddCamp(FlatBufferBuilder builder, ECamp camp)
		{
			builder.AddByte(6, (byte)camp, 0);
		}

		// Token: 0x06021B31 RID: 138033 RVA: 0x004A550C File Offset: 0x004A370C
		public static void AddAoiLayer(FlatBufferBuilder builder, EAoiLayer aoiLayer)
		{
			builder.AddByte(7, (byte)aoiLayer, 0);
		}

		// Token: 0x06021B32 RID: 138034 RVA: 0x004A5517 File Offset: 0x004A3717
		public static void AddAoiZRadius(FlatBufferBuilder builder, EAoizRadius aoiZRadius)
		{
			builder.AddByte(8, (byte)aoiZRadius, 0);
		}

		// Token: 0x06021B33 RID: 138035 RVA: 0x004A5522 File Offset: 0x004A3722
		public static void AddAoiGroupKey(FlatBufferBuilder builder, StringOffset aoiGroupKeyOffset)
		{
			builder.AddOffset(9, aoiGroupKeyOffset.Value, 0);
		}

		// Token: 0x06021B34 RID: 138036 RVA: 0x004A5533 File Offset: 0x004A3733
		public static void AddIsAoiFitterPlatform(FlatBufferBuilder builder, bool isAoiFitterPlatform)
		{
			builder.AddBool(10, isAoiFitterPlatform, false);
		}

		// Token: 0x06021B35 RID: 138037 RVA: 0x004A553F File Offset: 0x004A373F
		public static void AddCustomAoiZRadius(FlatBufferBuilder builder, Offset<ICustomAoizRadius> customAoiZRadiusOffset)
		{
			builder.AddOffset(11, customAoiZRadiusOffset.Value, 0);
		}

		// Token: 0x06021B36 RID: 138038 RVA: 0x004A5550 File Offset: 0x004A3750
		public static void AddMapIcon(FlatBufferBuilder builder, int mapIcon)
		{
			builder.AddInt(12, mapIcon, 0);
		}

		// Token: 0x06021B37 RID: 138039 RVA: 0x004A555C File Offset: 0x004A375C
		public static void AddPackId(FlatBufferBuilder builder, int packId)
		{
			builder.AddInt(13, packId, 0);
		}

		// Token: 0x06021B38 RID: 138040 RVA: 0x004A5568 File Offset: 0x004A3768
		public static void AddOccupation(FlatBufferBuilder builder, StringOffset occupationOffset)
		{
			builder.AddOffset(14, occupationOffset.Value, 0);
		}

		// Token: 0x06021B39 RID: 138041 RVA: 0x004A5579 File Offset: 0x004A3779
		public static void AddHeadStateViewConfig(FlatBufferBuilder builder, Offset<IHeadStateViewConfig> headStateViewConfigOffset)
		{
			builder.AddOffset(15, headStateViewConfigOffset.Value, 0);
		}

		// Token: 0x06021B3A RID: 138042 RVA: 0x004A558A File Offset: 0x004A378A
		public static void AddEntityPropertyId(FlatBufferBuilder builder, int entityPropertyId)
		{
			builder.AddInt(16, entityPropertyId, 0);
		}

		// Token: 0x06021B3B RID: 138043 RVA: 0x004A5596 File Offset: 0x004A3796
		public static void AddFocusPriority(FlatBufferBuilder builder, int focusPriority)
		{
			builder.AddInt(17, focusPriority, 0);
		}

		// Token: 0x06021B3C RID: 138044 RVA: 0x004A55A2 File Offset: 0x004A37A2
		public static void AddOnlineInteractType(FlatBufferBuilder builder, EOnlineInteractType onlineInteractType)
		{
			builder.AddByte(18, (byte)onlineInteractType, 0);
		}

		// Token: 0x06021B3D RID: 138045 RVA: 0x004A55AE File Offset: 0x004A37AE
		public static void AddNotAllowHidedByTargetRange(FlatBufferBuilder builder, bool notAllowHidedByTargetRange)
		{
			builder.AddBool(19, notAllowHidedByTargetRange, false);
		}

		// Token: 0x06021B3E RID: 138046 RVA: 0x004A55BA File Offset: 0x004A37BA
		public static void AddLowerNpcDensity(FlatBufferBuilder builder, ENpcDensity lowerNpcDensity)
		{
			builder.AddByte(20, (byte)lowerNpcDensity, 0);
		}

		// Token: 0x06021B3F RID: 138047 RVA: 0x004A55C6 File Offset: 0x004A37C6
		public static void AddDataLayers(FlatBufferBuilder builder, VectorOffset dataLayersOffset)
		{
			builder.AddOffset(21, dataLayersOffset.Value, 0);
		}

		// Token: 0x06021B40 RID: 138048 RVA: 0x004A55D8 File Offset: 0x004A37D8
		public static VectorOffset CreateDataLayersVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06021B41 RID: 138049 RVA: 0x004A560F File Offset: 0x004A380F
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021B42 RID: 138050 RVA: 0x004A5629 File Offset: 0x004A3829
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021B43 RID: 138051 RVA: 0x004A5647 File Offset: 0x004A3847
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021B44 RID: 138052 RVA: 0x004A5660 File Offset: 0x004A3860
		public static void StartDataLayersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021B45 RID: 138053 RVA: 0x004A566B File Offset: 0x004A386B
		public static void AddChildEntityIds(FlatBufferBuilder builder, VectorOffset childEntityIdsOffset)
		{
			builder.AddOffset(22, childEntityIdsOffset.Value, 0);
		}

		// Token: 0x06021B46 RID: 138054 RVA: 0x004A567C File Offset: 0x004A387C
		public static VectorOffset CreateChildEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06021B47 RID: 138055 RVA: 0x004A56B3 File Offset: 0x004A38B3
		public static VectorOffset CreateChildEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021B48 RID: 138056 RVA: 0x004A56CD File Offset: 0x004A38CD
		public static VectorOffset CreateChildEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021B49 RID: 138057 RVA: 0x004A56EB File Offset: 0x004A38EB
		public static VectorOffset CreateChildEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021B4A RID: 138058 RVA: 0x004A5704 File Offset: 0x004A3904
		public static void StartChildEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021B4B RID: 138059 RVA: 0x004A570F File Offset: 0x004A390F
		public static void AddIsOnlineStandalone(FlatBufferBuilder builder, bool isOnlineStandalone)
		{
			builder.AddBool(23, isOnlineStandalone, false);
		}

		// Token: 0x06021B4C RID: 138060 RVA: 0x004A571B File Offset: 0x004A391B
		public static void AddSpecifiedOnlineStandaloneParentUids(FlatBufferBuilder builder, VectorOffset specifiedOnlineStandaloneParentUidsOffset)
		{
			builder.AddOffset(24, specifiedOnlineStandaloneParentUidsOffset.Value, 0);
		}

		// Token: 0x06021B4D RID: 138061 RVA: 0x004A572C File Offset: 0x004A392C
		public static VectorOffset CreateSpecifiedOnlineStandaloneParentUidsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021B4E RID: 138062 RVA: 0x004A576C File Offset: 0x004A396C
		public static VectorOffset CreateSpecifiedOnlineStandaloneParentUidsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06021B4F RID: 138063 RVA: 0x004A5786 File Offset: 0x004A3986
		public static VectorOffset CreateSpecifiedOnlineStandaloneParentUidsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06021B50 RID: 138064 RVA: 0x004A57A4 File Offset: 0x004A39A4
		public static VectorOffset CreateSpecifiedOnlineStandaloneParentUidsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021B51 RID: 138065 RVA: 0x004A57BD File Offset: 0x004A39BD
		public static void StartSpecifiedOnlineStandaloneParentUidsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021B52 RID: 138066 RVA: 0x004A57C8 File Offset: 0x004A39C8
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(25, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06021B53 RID: 138067 RVA: 0x004A57D9 File Offset: 0x004A39D9
		public static void AddEntityUpdateStrategy(FlatBufferBuilder builder, EEntityUpdateStrategy entityUpdateStrategy)
		{
			builder.AddByte(26, (byte)entityUpdateStrategy, 0);
		}

		// Token: 0x06021B54 RID: 138068 RVA: 0x004A57E5 File Offset: 0x004A39E5
		public static void AddMaterialUpdateStrategy(FlatBufferBuilder builder, EMaterialUpdateStrategy materialUpdateStrategy)
		{
			builder.AddByte(27, (byte)materialUpdateStrategy, 0);
		}

		// Token: 0x06021B55 RID: 138069 RVA: 0x004A57F1 File Offset: 0x004A39F1
		public static void AddTimeScaleModifyStrategy(FlatBufferBuilder builder, ETimeScaleModifyStrategy timeScaleModifyStrategy)
		{
			builder.AddByte(28, (byte)timeScaleModifyStrategy, 0);
		}

		// Token: 0x06021B56 RID: 138070 RVA: 0x004A57FD File Offset: 0x004A39FD
		public static void AddGravityConfig(FlatBufferBuilder builder, Offset<IEntityGravityConfig> gravityConfigOffset)
		{
			builder.AddOffset(29, gravityConfigOffset.Value, 0);
		}

		// Token: 0x06021B57 RID: 138071 RVA: 0x004A580E File Offset: 0x004A3A0E
		public static void AddHeadInfoChangeConfig(FlatBufferBuilder builder, VectorOffset headInfoChangeConfigOffset)
		{
			builder.AddOffset(30, headInfoChangeConfigOffset.Value, 0);
		}

		// Token: 0x06021B58 RID: 138072 RVA: 0x004A5820 File Offset: 0x004A3A20
		public static VectorOffset CreateHeadInfoChangeConfigVector(FlatBufferBuilder builder, Offset<IHeadInfoChangeData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021B59 RID: 138073 RVA: 0x004A5860 File Offset: 0x004A3A60
		public static VectorOffset CreateHeadInfoChangeConfigVectorBlock(FlatBufferBuilder builder, Offset<IHeadInfoChangeData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IHeadInfoChangeData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021B5A RID: 138074 RVA: 0x004A587A File Offset: 0x004A3A7A
		public static VectorOffset CreateHeadInfoChangeConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IHeadInfoChangeData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IHeadInfoChangeData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021B5B RID: 138075 RVA: 0x004A5898 File Offset: 0x004A3A98
		public static VectorOffset CreateHeadInfoChangeConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IHeadInfoChangeData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021B5C RID: 138076 RVA: 0x004A58B1 File Offset: 0x004A3AB1
		public static void StartHeadInfoChangeConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021B5D RID: 138077 RVA: 0x004A58BC File Offset: 0x004A3ABC
		public static void AddIsForceDestroy(FlatBufferBuilder builder, bool isForceDestroy)
		{
			builder.AddBool(31, isForceDestroy, false);
		}

		// Token: 0x06021B5E RID: 138078 RVA: 0x004A58C8 File Offset: 0x004A3AC8
		public static void AddTimeScaleConfig(FlatBufferBuilder builder, Offset<ITimeScaleConfig> timeScaleConfigOffset)
		{
			builder.AddStruct(32, timeScaleConfigOffset.Value, 0);
		}

		// Token: 0x06021B5F RID: 138079 RVA: 0x004A58D9 File Offset: 0x004A3AD9
		public static void AddEntityAttachPointList(FlatBufferBuilder builder, VectorOffset entityAttachPointListOffset)
		{
			builder.AddOffset(33, entityAttachPointListOffset.Value, 0);
		}

		// Token: 0x06021B60 RID: 138080 RVA: 0x004A58EC File Offset: 0x004A3AEC
		public static VectorOffset CreateEntityAttachPointListVector(FlatBufferBuilder builder, Offset<IEntityAttachPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021B61 RID: 138081 RVA: 0x004A592C File Offset: 0x004A3B2C
		public static VectorOffset CreateEntityAttachPointListVectorBlock(FlatBufferBuilder builder, Offset<IEntityAttachPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityAttachPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021B62 RID: 138082 RVA: 0x004A5946 File Offset: 0x004A3B46
		public static VectorOffset CreateEntityAttachPointListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityAttachPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityAttachPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021B63 RID: 138083 RVA: 0x004A5964 File Offset: 0x004A3B64
		public static VectorOffset CreateEntityAttachPointListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityAttachPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021B64 RID: 138084 RVA: 0x004A597D File Offset: 0x004A3B7D
		public static void StartEntityAttachPointListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021B65 RID: 138085 RVA: 0x004A5988 File Offset: 0x004A3B88
		public static void AddDelayDestroyDistance(FlatBufferBuilder builder, int delayDestroyDistance)
		{
			builder.AddInt(34, delayDestroyDistance, 0);
		}

		// Token: 0x06021B66 RID: 138086 RVA: 0x004A5994 File Offset: 0x004A3B94
		public static void AddIsClientEntityFlag(FlatBufferBuilder builder, EClientEntityMark isClientEntityFlag)
		{
			builder.AddByte(35, (byte)isClientEntityFlag, 0);
		}

		// Token: 0x06021B67 RID: 138087 RVA: 0x004A59A0 File Offset: 0x004A3BA0
		public static void AddKeepAnimationRateWithShadow(FlatBufferBuilder builder, bool keepAnimationRateWithShadow)
		{
			builder.AddBool(36, keepAnimationRateWithShadow, false);
		}

		// Token: 0x06021B68 RID: 138088 RVA: 0x004A59AC File Offset: 0x004A3BAC
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(37, nullMask, 0U);
		}

		// Token: 0x06021B69 RID: 138089 RVA: 0x004A59B8 File Offset: 0x004A3BB8
		public static Offset<IBaseInfoComponent> EndIBaseInfoComponent(FlatBufferBuilder builder)
		{
			return new Offset<IBaseInfoComponent>(builder.EndTable());
		}

		// Token: 0x06021B6A RID: 138090 RVA: 0x004A59C8 File Offset: 0x004A3BC8
		public IBaseInfoComponentT UnPack()
		{
			IBaseInfoComponentT baseInfoComponentT = new IBaseInfoComponentT();
			this.UnPackTo(baseInfoComponentT);
			return baseInfoComponentT;
		}

		// Token: 0x06021B6B RID: 138091 RVA: 0x004A59E4 File Offset: 0x004A3BE4
		public void UnPackTo(IBaseInfoComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.TidName = this.TidName;
			_o.IsShowNameOnHead = this.IsShowNameOnHead;
			_o.Category = ((this.Category != null) ? this.Category.Value.UnPack() : null);
			_o.ScanFunction = ((this.ScanFunction != null) ? this.ScanFunction.Value.UnPack() : null);
			_o.HeadInfo = this.HeadInfo;
			_o.Camp = this.Camp;
			_o.AoiLayer = this.AoiLayer;
			_o.AoiZRadius = this.AoiZRadius;
			_o.AoiGroupKey = this.AoiGroupKey;
			_o.IsAoiFitterPlatform = this.IsAoiFitterPlatform;
			_o.CustomAoiZRadius = ((this.CustomAoiZRadius != null) ? this.CustomAoiZRadius.Value.UnPack() : null);
			_o.MapIcon = this.MapIcon;
			_o.PackId = this.PackId;
			_o.Occupation = this.Occupation;
			_o.HeadStateViewConfig = ((this.HeadStateViewConfig != null) ? this.HeadStateViewConfig.Value.UnPack() : null);
			_o.EntityPropertyId = this.EntityPropertyId;
			_o.FocusPriority = this.FocusPriority;
			_o.OnlineInteractType = this.OnlineInteractType;
			_o.NotAllowHidedByTargetRange = this.NotAllowHidedByTargetRange;
			_o.LowerNpcDensity = this.LowerNpcDensity;
			_o.DataLayers = new List<int>();
			for (int i = 0; i < this.DataLayersLength; i++)
			{
				_o.DataLayers.Add(this.DataLayers(i));
			}
			_o.ChildEntityIds = new List<int>();
			for (int j = 0; j < this.ChildEntityIdsLength; j++)
			{
				_o.ChildEntityIds.Add(this.ChildEntityIds(j));
			}
			_o.IsOnlineStandalone = this.IsOnlineStandalone;
			_o.SpecifiedOnlineStandaloneParentUids = new List<string>();
			for (int k = 0; k < this.SpecifiedOnlineStandaloneParentUidsLength; k++)
			{
				_o.SpecifiedOnlineStandaloneParentUids.Add(this.SpecifiedOnlineStandaloneParentUids(k));
			}
			_o.FixProcessor = ((this.FixProcessor != null) ? this.FixProcessor.Value.UnPack() : null);
			_o.EntityUpdateStrategy = this.EntityUpdateStrategy;
			_o.MaterialUpdateStrategy = this.MaterialUpdateStrategy;
			_o.TimeScaleModifyStrategy = this.TimeScaleModifyStrategy;
			_o.GravityConfig = ((this.GravityConfig != null) ? this.GravityConfig.Value.UnPack() : null);
			_o.HeadInfoChangeConfig = new List<IHeadInfoChangeDataT>();
			for (int l = 0; l < this.HeadInfoChangeConfigLength; l++)
			{
				_o.HeadInfoChangeConfig.Add((this.HeadInfoChangeConfig(l) != null) ? this.HeadInfoChangeConfig(l).Value.UnPack() : null);
			}
			_o.IsForceDestroy = this.IsForceDestroy;
			_o.TimeScaleConfig = ((this.TimeScaleConfig != null) ? this.TimeScaleConfig.Value.UnPack() : null);
			_o.EntityAttachPointList = new List<IEntityAttachPointT>();
			for (int m = 0; m < this.EntityAttachPointListLength; m++)
			{
				_o.EntityAttachPointList.Add((this.EntityAttachPointList(m) != null) ? this.EntityAttachPointList(m).Value.UnPack() : null);
			}
			_o.DelayDestroyDistance = this.DelayDestroyDistance;
			_o.IsClientEntityFlag = this.IsClientEntityFlag;
			_o.KeepAnimationRateWithShadow = this.KeepAnimationRateWithShadow;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021B6C RID: 138092 RVA: 0x004A5DD0 File Offset: 0x004A3FD0
		public static Offset<IBaseInfoComponent> Pack(FlatBufferBuilder builder, IBaseInfoComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBaseInfoComponent>);
			}
			StringOffset tidNameOffset = (_o.TidName == null) ? default(StringOffset) : builder.CreateString(_o.TidName);
			Offset<IEntityCategory> categoryOffset = (_o.Category == null) ? default(Offset<IEntityCategory>) : IEntityCategory.Pack(builder, _o.Category);
			Offset<IEntityScanFunction> scanFunctionOffset = (_o.ScanFunction == null) ? default(Offset<IEntityScanFunction>) : IEntityScanFunction.Pack(builder, _o.ScanFunction);
			StringOffset aoiGroupKeyOffset = (_o.AoiGroupKey == null) ? default(StringOffset) : builder.CreateString(_o.AoiGroupKey);
			Offset<ICustomAoizRadius> customAoiZRadiusOffset = (_o.CustomAoiZRadius == null) ? default(Offset<ICustomAoizRadius>) : ICustomAoizRadius.Pack(builder, _o.CustomAoiZRadius);
			StringOffset occupationOffset = (_o.Occupation == null) ? default(StringOffset) : builder.CreateString(_o.Occupation);
			Offset<IHeadStateViewConfig> headStateViewConfigOffset = (_o.HeadStateViewConfig == null) ? default(Offset<IHeadStateViewConfig>) : IHeadStateViewConfig.Pack(builder, _o.HeadStateViewConfig);
			VectorOffset dataLayersOffset = default(VectorOffset);
			if (_o.DataLayers != null)
			{
				int[] data = _o.DataLayers.ToArray();
				dataLayersOffset = IBaseInfoComponent.CreateDataLayersVector(builder, data);
			}
			VectorOffset childEntityIdsOffset = default(VectorOffset);
			if (_o.ChildEntityIds != null)
			{
				int[] data2 = _o.ChildEntityIds.ToArray();
				childEntityIdsOffset = IBaseInfoComponent.CreateChildEntityIdsVector(builder, data2);
			}
			VectorOffset specifiedOnlineStandaloneParentUidsOffset = default(VectorOffset);
			if (_o.SpecifiedOnlineStandaloneParentUids != null)
			{
				StringOffset[] array = new StringOffset[_o.SpecifiedOnlineStandaloneParentUids.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.SpecifiedOnlineStandaloneParentUids[i]);
				}
				specifiedOnlineStandaloneParentUidsOffset = IBaseInfoComponent.CreateSpecifiedOnlineStandaloneParentUidsVector(builder, array);
			}
			Offset<IFixProcessor> fixProcessorOffset = (_o.FixProcessor == null) ? default(Offset<IFixProcessor>) : IFixProcessor.Pack(builder, _o.FixProcessor);
			Offset<IEntityGravityConfig> gravityConfigOffset = (_o.GravityConfig == null) ? default(Offset<IEntityGravityConfig>) : IEntityGravityConfig.Pack(builder, _o.GravityConfig);
			VectorOffset headInfoChangeConfigOffset = default(VectorOffset);
			if (_o.HeadInfoChangeConfig != null)
			{
				Offset<IHeadInfoChangeData>[] array2 = new Offset<IHeadInfoChangeData>[_o.HeadInfoChangeConfig.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IHeadInfoChangeData.Pack(builder, _o.HeadInfoChangeConfig[j]);
				}
				headInfoChangeConfigOffset = IBaseInfoComponent.CreateHeadInfoChangeConfigVector(builder, array2);
			}
			VectorOffset entityAttachPointListOffset = default(VectorOffset);
			if (_o.EntityAttachPointList != null)
			{
				Offset<IEntityAttachPoint>[] array3 = new Offset<IEntityAttachPoint>[_o.EntityAttachPointList.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IEntityAttachPoint.Pack(builder, _o.EntityAttachPointList[k]);
				}
				entityAttachPointListOffset = IBaseInfoComponent.CreateEntityAttachPointListVector(builder, array3);
			}
			return IBaseInfoComponent.CreateIBaseInfoComponent(builder, _o.Disabled, tidNameOffset, _o.IsShowNameOnHead, categoryOffset, scanFunctionOffset, _o.HeadInfo, _o.Camp, _o.AoiLayer, _o.AoiZRadius, aoiGroupKeyOffset, _o.IsAoiFitterPlatform, customAoiZRadiusOffset, _o.MapIcon, _o.PackId, occupationOffset, headStateViewConfigOffset, _o.EntityPropertyId, _o.FocusPriority, _o.OnlineInteractType, _o.NotAllowHidedByTargetRange, _o.LowerNpcDensity, dataLayersOffset, childEntityIdsOffset, _o.IsOnlineStandalone, specifiedOnlineStandaloneParentUidsOffset, fixProcessorOffset, _o.EntityUpdateStrategy, _o.MaterialUpdateStrategy, _o.TimeScaleModifyStrategy, gravityConfigOffset, headInfoChangeConfigOffset, _o.IsForceDestroy, _o.TimeScaleConfig, entityAttachPointListOffset, _o.DelayDestroyDistance, _o.IsClientEntityFlag, _o.KeepAnimationRateWithShadow, _o.NullMask);
		}

		// Token: 0x0400E8A1 RID: 59553
		private Table __p;
	}
}
