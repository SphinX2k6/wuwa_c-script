using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A85 RID: 27269
	public struct IMechStunt : IFlatbufferObject
	{
		// Token: 0x1700CA73 RID: 51827
		// (get) Token: 0x0602FC90 RID: 195728 RVA: 0x00680A59 File Offset: 0x0067EC59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FC91 RID: 195729 RVA: 0x00680A66 File Offset: 0x0067EC66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FC92 RID: 195730 RVA: 0x00680A70 File Offset: 0x0067EC70
		public static IMechStunt GetRootAsIMechStunt(ByteBuffer _bb)
		{
			return IMechStunt.GetRootAsIMechStunt(_bb, default(IMechStunt));
		}

		// Token: 0x0602FC93 RID: 195731 RVA: 0x00680A8C File Offset: 0x0067EC8C
		public static IMechStunt GetRootAsIMechStunt(ByteBuffer _bb, IMechStunt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FC94 RID: 195732 RVA: 0x00680AA9 File Offset: 0x0067ECA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FC95 RID: 195733 RVA: 0x00680AB8 File Offset: 0x0067ECB8
		public IMechStunt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA74 RID: 51828
		// (get) Token: 0x0602FC96 RID: 195734 RVA: 0x00680AC8 File Offset: 0x0067ECC8
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CA75 RID: 51829
		// (get) Token: 0x0602FC97 RID: 195735 RVA: 0x00680B04 File Offset: 0x0067ED04
		public TMechStuntConfig StuntConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TMechStuntConfig.NONE;
				}
				return (TMechStuntConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FC98 RID: 195736 RVA: 0x00680B40 File Offset: 0x0067ED40
		public TTable? StuntConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FC99 RID: 195737 RVA: 0x00680B84 File Offset: 0x0067ED84
		public IMechStuntBurrow StuntConfigAsIMechStuntBurrow()
		{
			return this.StuntConfig<IMechStuntBurrow>().Value;
		}

		// Token: 0x0602FC9A RID: 195738 RVA: 0x00680BA0 File Offset: 0x0067EDA0
		public IMechStuntClimbFly StuntConfigAsIMechStuntClimbFly()
		{
			return this.StuntConfig<IMechStuntClimbFly>().Value;
		}

		// Token: 0x0602FC9B RID: 195739 RVA: 0x00680BBC File Offset: 0x0067EDBC
		public IMechStuntDive StuntConfigAsIMechStuntDive()
		{
			return this.StuntConfig<IMechStuntDive>().Value;
		}

		// Token: 0x0602FC9C RID: 195740 RVA: 0x00680BD8 File Offset: 0x0067EDD8
		public IMechStuntHighSpeed StuntConfigAsIMechStuntHighSpeed()
		{
			return this.StuntConfig<IMechStuntHighSpeed>().Value;
		}

		// Token: 0x0602FC9D RID: 195741 RVA: 0x00680BF4 File Offset: 0x0067EDF4
		public IMechStuntLevelFly StuntConfigAsIMechStuntLevelFly()
		{
			return this.StuntConfig<IMechStuntLevelFly>().Value;
		}

		// Token: 0x0602FC9E RID: 195742 RVA: 0x00680C10 File Offset: 0x0067EE10
		public IMechStuntWater StuntConfigAsIMechStuntWater()
		{
			return this.StuntConfig<IMechStuntWater>().Value;
		}

		// Token: 0x1700CA76 RID: 51830
		// (get) Token: 0x0602FC9F RID: 195743 RVA: 0x00680C2C File Offset: 0x0067EE2C
		public IVectorInfo? TargetPos
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CA77 RID: 51831
		// (get) Token: 0x0602FCA0 RID: 195744 RVA: 0x00680C8C File Offset: 0x0067EE8C
		public bool CanInterrupt
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CA78 RID: 51832
		// (get) Token: 0x0602FCA1 RID: 195745 RVA: 0x00680CCC File Offset: 0x0067EECC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FCA2 RID: 195746 RVA: 0x00680D09 File Offset: 0x0067EF09
		public static Offset<IMechStunt> CreateIMechStunt(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, TMechStuntConfig StuntConfig_type = TMechStuntConfig.NONE, int StuntConfigOffset = 0, Offset<IVectorInfo> TargetPosOffset = default(Offset<IVectorInfo>), bool CanInterrupt = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IMechStunt.AddTargetPos(builder, TargetPosOffset);
			IMechStunt.AddStuntConfig(builder, StuntConfigOffset);
			IMechStunt.AddNullMask(builder, NullMask);
			IMechStunt.AddCanInterrupt(builder, CanInterrupt);
			IMechStunt.AddStuntConfigType(builder, StuntConfig_type);
			IMechStunt.AddType(builder, Type);
			return IMechStunt.EndIMechStunt(builder);
		}

		// Token: 0x0602FCA3 RID: 195747 RVA: 0x00680D45 File Offset: 0x0067EF45
		public static void StartIMechStunt(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602FCA4 RID: 195748 RVA: 0x00680D4E File Offset: 0x0067EF4E
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FCA5 RID: 195749 RVA: 0x00680D59 File Offset: 0x0067EF59
		public static void AddStuntConfigType(FlatBufferBuilder builder, TMechStuntConfig stuntConfigType)
		{
			builder.AddByte(1, (byte)stuntConfigType, 0);
		}

		// Token: 0x0602FCA6 RID: 195750 RVA: 0x00680D64 File Offset: 0x0067EF64
		public static void AddStuntConfig(FlatBufferBuilder builder, int stuntConfigOffset)
		{
			builder.AddOffset(2, stuntConfigOffset, 0);
		}

		// Token: 0x0602FCA7 RID: 195751 RVA: 0x00680D6F File Offset: 0x0067EF6F
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IVectorInfo> targetPosOffset)
		{
			builder.AddOffset(3, targetPosOffset.Value, 0);
		}

		// Token: 0x0602FCA8 RID: 195752 RVA: 0x00680D7F File Offset: 0x0067EF7F
		public static void AddCanInterrupt(FlatBufferBuilder builder, bool canInterrupt)
		{
			builder.AddBool(4, canInterrupt, false);
		}

		// Token: 0x0602FCA9 RID: 195753 RVA: 0x00680D8A File Offset: 0x0067EF8A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602FCAA RID: 195754 RVA: 0x00680D95 File Offset: 0x0067EF95
		public static Offset<IMechStunt> EndIMechStunt(FlatBufferBuilder builder)
		{
			return new Offset<IMechStunt>(builder.EndTable());
		}

		// Token: 0x0602FCAB RID: 195755 RVA: 0x00680DA4 File Offset: 0x0067EFA4
		public IMechStuntT UnPack()
		{
			IMechStuntT mechStuntT = new IMechStuntT();
			this.UnPackTo(mechStuntT);
			return mechStuntT;
		}

		// Token: 0x0602FCAC RID: 195756 RVA: 0x00680DC0 File Offset: 0x0067EFC0
		public void UnPackTo(IMechStuntT _o)
		{
			_o.Type = this.Type;
			_o.StuntConfig = new TMechStuntConfigUnion();
			_o.StuntConfig.Type = this.StuntConfigType;
			switch (this.StuntConfigType)
			{
			case TMechStuntConfig.IMechStuntBurrow:
				_o.StuntConfig.Value = ((this.StuntConfig<IMechStuntBurrow>() != null) ? this.StuntConfig<IMechStuntBurrow>().Value.UnPack() : null);
				break;
			case TMechStuntConfig.IMechStuntClimbFly:
				_o.StuntConfig.Value = ((this.StuntConfig<IMechStuntClimbFly>() != null) ? this.StuntConfig<IMechStuntClimbFly>().Value.UnPack() : null);
				break;
			case TMechStuntConfig.IMechStuntDive:
				_o.StuntConfig.Value = ((this.StuntConfig<IMechStuntDive>() != null) ? this.StuntConfig<IMechStuntDive>().Value.UnPack() : null);
				break;
			case TMechStuntConfig.IMechStuntHighSpeed:
				_o.StuntConfig.Value = ((this.StuntConfig<IMechStuntHighSpeed>() != null) ? this.StuntConfig<IMechStuntHighSpeed>().Value.UnPack() : null);
				break;
			case TMechStuntConfig.IMechStuntLevelFly:
				_o.StuntConfig.Value = ((this.StuntConfig<IMechStuntLevelFly>() != null) ? this.StuntConfig<IMechStuntLevelFly>().Value.UnPack() : null);
				break;
			case TMechStuntConfig.IMechStuntWater:
				_o.StuntConfig.Value = ((this.StuntConfig<IMechStuntWater>() != null) ? this.StuntConfig<IMechStuntWater>().Value.UnPack() : null);
				break;
			}
			_o.TargetPos = ((this.TargetPos != null) ? this.TargetPos.Value.UnPack() : null);
			_o.CanInterrupt = this.CanInterrupt;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602FCAD RID: 195757 RVA: 0x00680FC4 File Offset: 0x0067F1C4
		public static Offset<IMechStunt> Pack(FlatBufferBuilder builder, IMechStuntT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechStunt>);
			}
			TMechStuntConfig stuntConfig_type = (_o.StuntConfig == null) ? TMechStuntConfig.NONE : _o.StuntConfig.Type;
			int stuntConfigOffset = (_o.StuntConfig == null) ? 0 : TMechStuntConfigUnion.Pack(builder, _o.StuntConfig);
			Offset<IVectorInfo> targetPosOffset = (_o.TargetPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TargetPos);
			return IMechStunt.CreateIMechStunt(builder, _o.Type, stuntConfig_type, stuntConfigOffset, targetPosOffset, _o.CanInterrupt, _o.NullMask);
		}

		// Token: 0x040112BE RID: 70334
		private Table __p;
	}
}
