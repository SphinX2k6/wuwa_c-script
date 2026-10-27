using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EE9 RID: 20201
	public struct IBaseInfoComponent : IFlatbufferObject
	{
		// Token: 0x170090FF RID: 37119
		// (get) Token: 0x0601FD7D RID: 130429 RVA: 0x0046E35F File Offset: 0x0046C55F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FD7E RID: 130430 RVA: 0x0046E36C File Offset: 0x0046C56C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FD7F RID: 130431 RVA: 0x0046E374 File Offset: 0x0046C574
		public static IBaseInfoComponent GetRootAsIBaseInfoComponent(ByteBuffer _bb)
		{
			return IBaseInfoComponent.GetRootAsIBaseInfoComponent(_bb, default(IBaseInfoComponent));
		}

		// Token: 0x0601FD80 RID: 130432 RVA: 0x0046E390 File Offset: 0x0046C590
		public static IBaseInfoComponent GetRootAsIBaseInfoComponent(ByteBuffer _bb, IBaseInfoComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FD81 RID: 130433 RVA: 0x0046E3AD File Offset: 0x0046C5AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FD82 RID: 130434 RVA: 0x0046E3BC File Offset: 0x0046C5BC
		public IBaseInfoComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009100 RID: 37120
		// (get) Token: 0x0601FD83 RID: 130435 RVA: 0x0046E3CC File Offset: 0x0046C5CC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009101 RID: 37121
		// (get) Token: 0x0601FD84 RID: 130436 RVA: 0x0046E40C File Offset: 0x0046C60C
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

		// Token: 0x0601FD85 RID: 130437 RVA: 0x0046E443 File Offset: 0x0046C643
		public Span<byte> GetTidNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601FD86 RID: 130438 RVA: 0x0046E452 File Offset: 0x0046C652
		public byte[] GetTidNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009102 RID: 37122
		// (get) Token: 0x0601FD87 RID: 130439 RVA: 0x0046E460 File Offset: 0x0046C660
		public bool IsShowNameOnHead
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009103 RID: 37123
		// (get) Token: 0x0601FD88 RID: 130440 RVA: 0x0046E4A0 File Offset: 0x0046C6A0
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

		// Token: 0x17009104 RID: 37124
		// (get) Token: 0x0601FD89 RID: 130441 RVA: 0x0046E500 File Offset: 0x0046C700
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

		// Token: 0x17009105 RID: 37125
		// (get) Token: 0x0601FD8A RID: 130442 RVA: 0x0046E560 File Offset: 0x0046C760
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

		// Token: 0x17009106 RID: 37126
		// (get) Token: 0x0601FD8B RID: 130443 RVA: 0x0046E5A0 File Offset: 0x0046C7A0
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

		// Token: 0x17009107 RID: 37127
		// (get) Token: 0x0601FD8C RID: 130444 RVA: 0x0046E5E0 File Offset: 0x0046C7E0
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

		// Token: 0x17009108 RID: 37128
		// (get) Token: 0x0601FD8D RID: 130445 RVA: 0x0046E620 File Offset: 0x0046C820
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

		// Token: 0x17009109 RID: 37129
		// (get) Token: 0x0601FD8E RID: 130446 RVA: 0x0046E660 File Offset: 0x0046C860
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

		// Token: 0x0601FD8F RID: 130447 RVA: 0x0046E698 File Offset: 0x0046C898
		public Span<byte> GetAoiGroupKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0601FD90 RID: 130448 RVA: 0x0046E6A8 File Offset: 0x0046C8A8
		public byte[] GetAoiGroupKeyArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700910A RID: 37130
		// (get) Token: 0x0601FD91 RID: 130449 RVA: 0x0046E6B8 File Offset: 0x0046C8B8
		public bool IsAoiFitterPlatform
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700910B RID: 37131
		// (get) Token: 0x0601FD92 RID: 130450 RVA: 0x0046E6F8 File Offset: 0x0046C8F8
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

		// Token: 0x1700910C RID: 37132
		// (get) Token: 0x0601FD93 RID: 130451 RVA: 0x0046E758 File Offset: 0x0046C958
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

		// Token: 0x1700910D RID: 37133
		// (get) Token: 0x0601FD94 RID: 130452 RVA: 0x0046E798 File Offset: 0x0046C998
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

		// Token: 0x1700910E RID: 37134
		// (get) Token: 0x0601FD95 RID: 130453 RVA: 0x0046E7D8 File Offset: 0x0046C9D8
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

		// Token: 0x0601FD96 RID: 130454 RVA: 0x0046E810 File Offset: 0x0046CA10
		public Span<byte> GetOccupationBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0601FD97 RID: 130455 RVA: 0x0046E820 File Offset: 0x0046CA20
		public byte[] GetOccupationArray()
		{
			return this.__p.__vector_as_array<byte>(32);
		}

		// Token: 0x1700910F RID: 37135
		// (get) Token: 0x0601FD98 RID: 130456 RVA: 0x0046E830 File Offset: 0x0046CA30
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

		// Token: 0x17009110 RID: 37136
		// (get) Token: 0x0601FD99 RID: 130457 RVA: 0x0046E890 File Offset: 0x0046CA90
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

		// Token: 0x17009111 RID: 37137
		// (get) Token: 0x0601FD9A RID: 130458 RVA: 0x0046E8D0 File Offset: 0x0046CAD0
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

		// Token: 0x17009112 RID: 37138
		// (get) Token: 0x0601FD9B RID: 130459 RVA: 0x0046E910 File Offset: 0x0046CB10
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

		// Token: 0x17009113 RID: 37139
		// (get) Token: 0x0601FD9C RID: 130460 RVA: 0x0046E950 File Offset: 0x0046CB50
		public bool NotAllowHidedByTargetRange
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009114 RID: 37140
		// (get) Token: 0x0601FD9D RID: 130461 RVA: 0x0046E990 File Offset: 0x0046CB90
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

		// Token: 0x0601FD9E RID: 130462 RVA: 0x0046E9D0 File Offset: 0x0046CBD0
		public int DataLayers(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009115 RID: 37141
		// (get) Token: 0x0601FD9F RID: 130463 RVA: 0x0046EA10 File Offset: 0x0046CC10
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

		// Token: 0x0601FDA0 RID: 130464 RVA: 0x0046EA3C File Offset: 0x0046CC3C
		public Span<int> GetDataLayersBytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x0601FDA1 RID: 130465 RVA: 0x0046EA4C File Offset: 0x0046CC4C
		public int[] GetDataLayersArray()
		{
			return this.__p.__vector_as_array<int>(46);
		}

		// Token: 0x0601FDA2 RID: 130466 RVA: 0x0046EA5C File Offset: 0x0046CC5C
		public int ChildEntityIds(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009116 RID: 37142
		// (get) Token: 0x0601FDA3 RID: 130467 RVA: 0x0046EA9C File Offset: 0x0046CC9C
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

		// Token: 0x0601FDA4 RID: 130468 RVA: 0x0046EAC8 File Offset: 0x0046CCC8
		public Span<int> GetChildEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(48, 4);
		}

		// Token: 0x0601FDA5 RID: 130469 RVA: 0x0046EAD8 File Offset: 0x0046CCD8
		public int[] GetChildEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(48);
		}

		// Token: 0x17009117 RID: 37143
		// (get) Token: 0x0601FDA6 RID: 130470 RVA: 0x0046EAE8 File Offset: 0x0046CCE8
		public bool IsOnlineStandalone
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601FDA7 RID: 130471 RVA: 0x0046EB28 File Offset: 0x0046CD28
		public string SpecifiedOnlineStandaloneParentUids(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009118 RID: 37144
		// (get) Token: 0x0601FDA8 RID: 130472 RVA: 0x0046EB64 File Offset: 0x0046CD64
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

		// Token: 0x17009119 RID: 37145
		// (get) Token: 0x0601FDA9 RID: 130473 RVA: 0x0046EB90 File Offset: 0x0046CD90
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

		// Token: 0x1700911A RID: 37146
		// (get) Token: 0x0601FDAA RID: 130474 RVA: 0x0046EBF0 File Offset: 0x0046CDF0
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

		// Token: 0x1700911B RID: 37147
		// (get) Token: 0x0601FDAB RID: 130475 RVA: 0x0046EC30 File Offset: 0x0046CE30
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

		// Token: 0x1700911C RID: 37148
		// (get) Token: 0x0601FDAC RID: 130476 RVA: 0x0046EC70 File Offset: 0x0046CE70
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

		// Token: 0x1700911D RID: 37149
		// (get) Token: 0x0601FDAD RID: 130477 RVA: 0x0046ECB0 File Offset: 0x0046CEB0
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

		// Token: 0x0601FDAE RID: 130478 RVA: 0x0046ED10 File Offset: 0x0046CF10
		public IHeadInfoChangeData? HeadInfoChangeConfig(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return null;
			}
			return new IHeadInfoChangeData?(default(IHeadInfoChangeData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700911E RID: 37150
		// (get) Token: 0x0601FDAF RID: 130479 RVA: 0x0046ED74 File Offset: 0x0046CF74
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

		// Token: 0x1700911F RID: 37151
		// (get) Token: 0x0601FDB0 RID: 130480 RVA: 0x0046EDA0 File Offset: 0x0046CFA0
		public bool IsForceDestroy
		{
			get
			{
				int num = this.__p.__offset(66);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009120 RID: 37152
		// (get) Token: 0x0601FDB1 RID: 130481 RVA: 0x0046EDE0 File Offset: 0x0046CFE0
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

		// Token: 0x0601FDB2 RID: 130482 RVA: 0x0046EE34 File Offset: 0x0046D034
		public IEntityAttachPoint? EntityAttachPointList(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return new IEntityAttachPoint?(default(IEntityAttachPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009121 RID: 37153
		// (get) Token: 0x0601FDB3 RID: 130483 RVA: 0x0046EE98 File Offset: 0x0046D098
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

		// Token: 0x17009122 RID: 37154
		// (get) Token: 0x0601FDB4 RID: 130484 RVA: 0x0046EEC4 File Offset: 0x0046D0C4
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

		// Token: 0x17009123 RID: 37155
		// (get) Token: 0x0601FDB5 RID: 130485 RVA: 0x0046EF04 File Offset: 0x0046D104
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

		// Token: 0x17009124 RID: 37156
		// (get) Token: 0x0601FDB6 RID: 130486 RVA: 0x0046EF44 File Offset: 0x0046D144
		public bool KeepAnimationRateWithShadow
		{
			get
			{
				int num = this.__p.__offset(76);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009125 RID: 37157
		// (get) Token: 0x0601FDB7 RID: 130487 RVA: 0x0046EF84 File Offset: 0x0046D184
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

		// Token: 0x0601FDB8 RID: 130488 RVA: 0x0046EFC4 File Offset: 0x0046D1C4
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

		// Token: 0x0601FDB9 RID: 130489 RVA: 0x0046F112 File Offset: 0x0046D312
		public static void StartIBaseInfoComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(38);
		}

		// Token: 0x0601FDBA RID: 130490 RVA: 0x0046F11C File Offset: 0x0046D31C
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0601FDBB RID: 130491 RVA: 0x0046F127 File Offset: 0x0046D327
		public static void AddTidName(FlatBufferBuilder builder, StringOffset tidNameOffset)
		{
			builder.AddOffset(1, tidNameOffset.Value, 0);
		}

		// Token: 0x0601FDBC RID: 130492 RVA: 0x0046F137 File Offset: 0x0046D337
		public static void AddIsShowNameOnHead(FlatBufferBuilder builder, bool isShowNameOnHead)
		{
			builder.AddBool(2, isShowNameOnHead, false);
		}

		// Token: 0x0601FDBD RID: 130493 RVA: 0x0046F142 File Offset: 0x0046D342
		public static void AddCategory(FlatBufferBuilder builder, Offset<IEntityCategory> categoryOffset)
		{
			builder.AddOffset(3, categoryOffset.Value, 0);
		}

		// Token: 0x0601FDBE RID: 130494 RVA: 0x0046F152 File Offset: 0x0046D352
		public static void AddScanFunction(FlatBufferBuilder builder, Offset<IEntityScanFunction> scanFunctionOffset)
		{
			builder.AddOffset(4, scanFunctionOffset.Value, 0);
		}

		// Token: 0x0601FDBF RID: 130495 RVA: 0x0046F162 File Offset: 0x0046D362
		public static void AddHeadInfo(FlatBufferBuilder builder, int headInfo)
		{
			builder.AddInt(5, headInfo, 0);
		}

		// Token: 0x0601FDC0 RID: 130496 RVA: 0x0046F16D File Offset: 0x0046D36D
		public static void AddCamp(FlatBufferBuilder builder, ECamp camp)
		{
			builder.AddByte(6, (byte)camp, 0);
		}

		// Token: 0x0601FDC1 RID: 130497 RVA: 0x0046F178 File Offset: 0x0046D378
		public static void AddAoiLayer(FlatBufferBuilder builder, EAoiLayer aoiLayer)
		{
			builder.AddByte(7, (byte)aoiLayer, 0);
		}

		// Token: 0x0601FDC2 RID: 130498 RVA: 0x0046F183 File Offset: 0x0046D383
		public static void AddAoiZRadius(FlatBufferBuilder builder, EAoizRadius aoiZRadius)
		{
			builder.AddByte(8, (byte)aoiZRadius, 0);
		}

		// Token: 0x0601FDC3 RID: 130499 RVA: 0x0046F18E File Offset: 0x0046D38E
		public static void AddAoiGroupKey(FlatBufferBuilder builder, StringOffset aoiGroupKeyOffset)
		{
			builder.AddOffset(9, aoiGroupKeyOffset.Value, 0);
		}

		// Token: 0x0601FDC4 RID: 130500 RVA: 0x0046F19F File Offset: 0x0046D39F
		public static void AddIsAoiFitterPlatform(FlatBufferBuilder builder, bool isAoiFitterPlatform)
		{
			builder.AddBool(10, isAoiFitterPlatform, false);
		}

		// Token: 0x0601FDC5 RID: 130501 RVA: 0x0046F1AB File Offset: 0x0046D3AB
		public static void AddCustomAoiZRadius(FlatBufferBuilder builder, Offset<ICustomAoizRadius> customAoiZRadiusOffset)
		{
			builder.AddOffset(11, customAoiZRadiusOffset.Value, 0);
		}

		// Token: 0x0601FDC6 RID: 130502 RVA: 0x0046F1BC File Offset: 0x0046D3BC
		public static void AddMapIcon(FlatBufferBuilder builder, int mapIcon)
		{
			builder.AddInt(12, mapIcon, 0);
		}

		// Token: 0x0601FDC7 RID: 130503 RVA: 0x0046F1C8 File Offset: 0x0046D3C8
		public static void AddPackId(FlatBufferBuilder builder, int packId)
		{
			builder.AddInt(13, packId, 0);
		}

		// Token: 0x0601FDC8 RID: 130504 RVA: 0x0046F1D4 File Offset: 0x0046D3D4
		public static void AddOccupation(FlatBufferBuilder builder, StringOffset occupationOffset)
		{
			builder.AddOffset(14, occupationOffset.Value, 0);
		}

		// Token: 0x0601FDC9 RID: 130505 RVA: 0x0046F1E5 File Offset: 0x0046D3E5
		public static void AddHeadStateViewConfig(FlatBufferBuilder builder, Offset<IHeadStateViewConfig> headStateViewConfigOffset)
		{
			builder.AddOffset(15, headStateViewConfigOffset.Value, 0);
		}

		// Token: 0x0601FDCA RID: 130506 RVA: 0x0046F1F6 File Offset: 0x0046D3F6
		public static void AddEntityPropertyId(FlatBufferBuilder builder, int entityPropertyId)
		{
			builder.AddInt(16, entityPropertyId, 0);
		}

		// Token: 0x0601FDCB RID: 130507 RVA: 0x0046F202 File Offset: 0x0046D402
		public static void AddFocusPriority(FlatBufferBuilder builder, int focusPriority)
		{
			builder.AddInt(17, focusPriority, 0);
		}

		// Token: 0x0601FDCC RID: 130508 RVA: 0x0046F20E File Offset: 0x0046D40E
		public static void AddOnlineInteractType(FlatBufferBuilder builder, EOnlineInteractType onlineInteractType)
		{
			builder.AddByte(18, (byte)onlineInteractType, 0);
		}

		// Token: 0x0601FDCD RID: 130509 RVA: 0x0046F21A File Offset: 0x0046D41A
		public static void AddNotAllowHidedByTargetRange(FlatBufferBuilder builder, bool notAllowHidedByTargetRange)
		{
			builder.AddBool(19, notAllowHidedByTargetRange, false);
		}

		// Token: 0x0601FDCE RID: 130510 RVA: 0x0046F226 File Offset: 0x0046D426
		public static void AddLowerNpcDensity(FlatBufferBuilder builder, ENpcDensity lowerNpcDensity)
		{
			builder.AddByte(20, (byte)lowerNpcDensity, 0);
		}

		// Token: 0x0601FDCF RID: 130511 RVA: 0x0046F232 File Offset: 0x0046D432
		public static void AddDataLayers(FlatBufferBuilder builder, VectorOffset dataLayersOffset)
		{
			builder.AddOffset(21, dataLayersOffset.Value, 0);
		}

		// Token: 0x0601FDD0 RID: 130512 RVA: 0x0046F244 File Offset: 0x0046D444
		public static VectorOffset CreateDataLayersVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FDD1 RID: 130513 RVA: 0x0046F27B File Offset: 0x0046D47B
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FDD2 RID: 130514 RVA: 0x0046F295 File Offset: 0x0046D495
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FDD3 RID: 130515 RVA: 0x0046F2B3 File Offset: 0x0046D4B3
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FDD4 RID: 130516 RVA: 0x0046F2CC File Offset: 0x0046D4CC
		public static void StartDataLayersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FDD5 RID: 130517 RVA: 0x0046F2D7 File Offset: 0x0046D4D7
		public static void AddChildEntityIds(FlatBufferBuilder builder, VectorOffset childEntityIdsOffset)
		{
			builder.AddOffset(22, childEntityIdsOffset.Value, 0);
		}

		// Token: 0x0601FDD6 RID: 130518 RVA: 0x0046F2E8 File Offset: 0x0046D4E8
		public static VectorOffset CreateChildEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FDD7 RID: 130519 RVA: 0x0046F31F File Offset: 0x0046D51F
		public static VectorOffset CreateChildEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FDD8 RID: 130520 RVA: 0x0046F339 File Offset: 0x0046D539
		public static VectorOffset CreateChildEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FDD9 RID: 130521 RVA: 0x0046F357 File Offset: 0x0046D557
		public static VectorOffset CreateChildEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FDDA RID: 130522 RVA: 0x0046F370 File Offset: 0x0046D570
		public static void StartChildEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FDDB RID: 130523 RVA: 0x0046F37B File Offset: 0x0046D57B
		public static void AddIsOnlineStandalone(FlatBufferBuilder builder, bool isOnlineStandalone)
		{
			builder.AddBool(23, isOnlineStandalone, false);
		}

		// Token: 0x0601FDDC RID: 130524 RVA: 0x0046F387 File Offset: 0x0046D587
		public static void AddSpecifiedOnlineStandaloneParentUids(FlatBufferBuilder builder, VectorOffset specifiedOnlineStandaloneParentUidsOffset)
		{
			builder.AddOffset(24, specifiedOnlineStandaloneParentUidsOffset.Value, 0);
		}

		// Token: 0x0601FDDD RID: 130525 RVA: 0x0046F398 File Offset: 0x0046D598
		public static VectorOffset CreateSpecifiedOnlineStandaloneParentUidsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FDDE RID: 130526 RVA: 0x0046F3D8 File Offset: 0x0046D5D8
		public static VectorOffset CreateSpecifiedOnlineStandaloneParentUidsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FDDF RID: 130527 RVA: 0x0046F3F2 File Offset: 0x0046D5F2
		public static VectorOffset CreateSpecifiedOnlineStandaloneParentUidsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FDE0 RID: 130528 RVA: 0x0046F410 File Offset: 0x0046D610
		public static VectorOffset CreateSpecifiedOnlineStandaloneParentUidsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FDE1 RID: 130529 RVA: 0x0046F429 File Offset: 0x0046D629
		public static void StartSpecifiedOnlineStandaloneParentUidsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FDE2 RID: 130530 RVA: 0x0046F434 File Offset: 0x0046D634
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(25, fixProcessorOffset.Value, 0);
		}

		// Token: 0x0601FDE3 RID: 130531 RVA: 0x0046F445 File Offset: 0x0046D645
		public static void AddEntityUpdateStrategy(FlatBufferBuilder builder, EEntityUpdateStrategy entityUpdateStrategy)
		{
			builder.AddByte(26, (byte)entityUpdateStrategy, 0);
		}

		// Token: 0x0601FDE4 RID: 130532 RVA: 0x0046F451 File Offset: 0x0046D651
		public static void AddMaterialUpdateStrategy(FlatBufferBuilder builder, EMaterialUpdateStrategy materialUpdateStrategy)
		{
			builder.AddByte(27, (byte)materialUpdateStrategy, 0);
		}

		// Token: 0x0601FDE5 RID: 130533 RVA: 0x0046F45D File Offset: 0x0046D65D
		public static void AddTimeScaleModifyStrategy(FlatBufferBuilder builder, ETimeScaleModifyStrategy timeScaleModifyStrategy)
		{
			builder.AddByte(28, (byte)timeScaleModifyStrategy, 0);
		}

		// Token: 0x0601FDE6 RID: 130534 RVA: 0x0046F469 File Offset: 0x0046D669
		public static void AddGravityConfig(FlatBufferBuilder builder, Offset<IEntityGravityConfig> gravityConfigOffset)
		{
			builder.AddOffset(29, gravityConfigOffset.Value, 0);
		}

		// Token: 0x0601FDE7 RID: 130535 RVA: 0x0046F47A File Offset: 0x0046D67A
		public static void AddHeadInfoChangeConfig(FlatBufferBuilder builder, VectorOffset headInfoChangeConfigOffset)
		{
			builder.AddOffset(30, headInfoChangeConfigOffset.Value, 0);
		}

		// Token: 0x0601FDE8 RID: 130536 RVA: 0x0046F48C File Offset: 0x0046D68C
		public static VectorOffset CreateHeadInfoChangeConfigVector(FlatBufferBuilder builder, Offset<IHeadInfoChangeData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FDE9 RID: 130537 RVA: 0x0046F4CC File Offset: 0x0046D6CC
		public static VectorOffset CreateHeadInfoChangeConfigVectorBlock(FlatBufferBuilder builder, Offset<IHeadInfoChangeData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IHeadInfoChangeData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FDEA RID: 130538 RVA: 0x0046F4E6 File Offset: 0x0046D6E6
		public static VectorOffset CreateHeadInfoChangeConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IHeadInfoChangeData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IHeadInfoChangeData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FDEB RID: 130539 RVA: 0x0046F504 File Offset: 0x0046D704
		public static VectorOffset CreateHeadInfoChangeConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IHeadInfoChangeData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FDEC RID: 130540 RVA: 0x0046F51D File Offset: 0x0046D71D
		public static void StartHeadInfoChangeConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FDED RID: 130541 RVA: 0x0046F528 File Offset: 0x0046D728
		public static void AddIsForceDestroy(FlatBufferBuilder builder, bool isForceDestroy)
		{
			builder.AddBool(31, isForceDestroy, false);
		}

		// Token: 0x0601FDEE RID: 130542 RVA: 0x0046F534 File Offset: 0x0046D734
		public static void AddTimeScaleConfig(FlatBufferBuilder builder, Offset<ITimeScaleConfig> timeScaleConfigOffset)
		{
			builder.AddStruct(32, timeScaleConfigOffset.Value, 0);
		}

		// Token: 0x0601FDEF RID: 130543 RVA: 0x0046F545 File Offset: 0x0046D745
		public static void AddEntityAttachPointList(FlatBufferBuilder builder, VectorOffset entityAttachPointListOffset)
		{
			builder.AddOffset(33, entityAttachPointListOffset.Value, 0);
		}

		// Token: 0x0601FDF0 RID: 130544 RVA: 0x0046F558 File Offset: 0x0046D758
		public static VectorOffset CreateEntityAttachPointListVector(FlatBufferBuilder builder, Offset<IEntityAttachPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FDF1 RID: 130545 RVA: 0x0046F598 File Offset: 0x0046D798
		public static VectorOffset CreateEntityAttachPointListVectorBlock(FlatBufferBuilder builder, Offset<IEntityAttachPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityAttachPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FDF2 RID: 130546 RVA: 0x0046F5B2 File Offset: 0x0046D7B2
		public static VectorOffset CreateEntityAttachPointListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityAttachPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityAttachPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FDF3 RID: 130547 RVA: 0x0046F5D0 File Offset: 0x0046D7D0
		public static VectorOffset CreateEntityAttachPointListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityAttachPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FDF4 RID: 130548 RVA: 0x0046F5E9 File Offset: 0x0046D7E9
		public static void StartEntityAttachPointListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FDF5 RID: 130549 RVA: 0x0046F5F4 File Offset: 0x0046D7F4
		public static void AddDelayDestroyDistance(FlatBufferBuilder builder, int delayDestroyDistance)
		{
			builder.AddInt(34, delayDestroyDistance, 0);
		}

		// Token: 0x0601FDF6 RID: 130550 RVA: 0x0046F600 File Offset: 0x0046D800
		public static void AddIsClientEntityFlag(FlatBufferBuilder builder, EClientEntityMark isClientEntityFlag)
		{
			builder.AddByte(35, (byte)isClientEntityFlag, 0);
		}

		// Token: 0x0601FDF7 RID: 130551 RVA: 0x0046F60C File Offset: 0x0046D80C
		public static void AddKeepAnimationRateWithShadow(FlatBufferBuilder builder, bool keepAnimationRateWithShadow)
		{
			builder.AddBool(36, keepAnimationRateWithShadow, false);
		}

		// Token: 0x0601FDF8 RID: 130552 RVA: 0x0046F618 File Offset: 0x0046D818
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(37, nullMask, 0U);
		}

		// Token: 0x0601FDF9 RID: 130553 RVA: 0x0046F624 File Offset: 0x0046D824
		public static Offset<IBaseInfoComponent> EndIBaseInfoComponent(FlatBufferBuilder builder)
		{
			return new Offset<IBaseInfoComponent>(builder.EndTable());
		}

		// Token: 0x0601FDFA RID: 130554 RVA: 0x0046F634 File Offset: 0x0046D834
		public IBaseInfoComponentT UnPack()
		{
			IBaseInfoComponentT baseInfoComponentT = new IBaseInfoComponentT();
			this.UnPackTo(baseInfoComponentT);
			return baseInfoComponentT;
		}

		// Token: 0x0601FDFB RID: 130555 RVA: 0x0046F650 File Offset: 0x0046D850
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

		// Token: 0x0601FDFC RID: 130556 RVA: 0x0046FA3C File Offset: 0x0046DC3C
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

		// Token: 0x0400DCF2 RID: 56562
		private Table __p;
	}
}
