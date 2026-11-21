using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071AA RID: 29098
	public struct IMechStunt : IFlatbufferObject
	{
		// Token: 0x1700D523 RID: 54563
		// (get) Token: 0x060329CC RID: 207308 RVA: 0x006D6D1A File Offset: 0x006D4F1A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060329CD RID: 207309 RVA: 0x006D6D27 File Offset: 0x006D4F27
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060329CE RID: 207310 RVA: 0x006D6D30 File Offset: 0x006D4F30
		public static IMechStunt GetRootAsIMechStunt(ByteBuffer _bb)
		{
			return IMechStunt.GetRootAsIMechStunt(_bb, default(IMechStunt));
		}

		// Token: 0x060329CF RID: 207311 RVA: 0x006D6D4C File Offset: 0x006D4F4C
		public static IMechStunt GetRootAsIMechStunt(ByteBuffer _bb, IMechStunt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060329D0 RID: 207312 RVA: 0x006D6D69 File Offset: 0x006D4F69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060329D1 RID: 207313 RVA: 0x006D6D78 File Offset: 0x006D4F78
		public IMechStunt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D524 RID: 54564
		// (get) Token: 0x060329D2 RID: 207314 RVA: 0x006D6D88 File Offset: 0x006D4F88
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

		// Token: 0x1700D525 RID: 54565
		// (get) Token: 0x060329D3 RID: 207315 RVA: 0x006D6DC4 File Offset: 0x006D4FC4
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

		// Token: 0x060329D4 RID: 207316 RVA: 0x006D6E00 File Offset: 0x006D5000
		public TTable? StuntConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060329D5 RID: 207317 RVA: 0x006D6E44 File Offset: 0x006D5044
		public IMechStuntBurrow StuntConfigAsIMechStuntBurrow()
		{
			return this.StuntConfig<IMechStuntBurrow>().Value;
		}

		// Token: 0x060329D6 RID: 207318 RVA: 0x006D6E60 File Offset: 0x006D5060
		public IMechStuntClimbFly StuntConfigAsIMechStuntClimbFly()
		{
			return this.StuntConfig<IMechStuntClimbFly>().Value;
		}

		// Token: 0x060329D7 RID: 207319 RVA: 0x006D6E7C File Offset: 0x006D507C
		public IMechStuntDive StuntConfigAsIMechStuntDive()
		{
			return this.StuntConfig<IMechStuntDive>().Value;
		}

		// Token: 0x060329D8 RID: 207320 RVA: 0x006D6E98 File Offset: 0x006D5098
		public IMechStuntHighSpeed StuntConfigAsIMechStuntHighSpeed()
		{
			return this.StuntConfig<IMechStuntHighSpeed>().Value;
		}

		// Token: 0x060329D9 RID: 207321 RVA: 0x006D6EB4 File Offset: 0x006D50B4
		public IMechStuntLevelFly StuntConfigAsIMechStuntLevelFly()
		{
			return this.StuntConfig<IMechStuntLevelFly>().Value;
		}

		// Token: 0x060329DA RID: 207322 RVA: 0x006D6ED0 File Offset: 0x006D50D0
		public IMechStuntWater StuntConfigAsIMechStuntWater()
		{
			return this.StuntConfig<IMechStuntWater>().Value;
		}

		// Token: 0x1700D526 RID: 54566
		// (get) Token: 0x060329DB RID: 207323 RVA: 0x006D6EEC File Offset: 0x006D50EC
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

		// Token: 0x1700D527 RID: 54567
		// (get) Token: 0x060329DC RID: 207324 RVA: 0x006D6F4C File Offset: 0x006D514C
		public bool CanInterrupt
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D528 RID: 54568
		// (get) Token: 0x060329DD RID: 207325 RVA: 0x006D6F8C File Offset: 0x006D518C
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

		// Token: 0x060329DE RID: 207326 RVA: 0x006D6FC9 File Offset: 0x006D51C9
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

		// Token: 0x060329DF RID: 207327 RVA: 0x006D7005 File Offset: 0x006D5205
		public static void StartIMechStunt(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060329E0 RID: 207328 RVA: 0x006D700E File Offset: 0x006D520E
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060329E1 RID: 207329 RVA: 0x006D7019 File Offset: 0x006D5219
		public static void AddStuntConfigType(FlatBufferBuilder builder, TMechStuntConfig stuntConfigType)
		{
			builder.AddByte(1, (byte)stuntConfigType, 0);
		}

		// Token: 0x060329E2 RID: 207330 RVA: 0x006D7024 File Offset: 0x006D5224
		public static void AddStuntConfig(FlatBufferBuilder builder, int stuntConfigOffset)
		{
			builder.AddOffset(2, stuntConfigOffset, 0);
		}

		// Token: 0x060329E3 RID: 207331 RVA: 0x006D702F File Offset: 0x006D522F
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IVectorInfo> targetPosOffset)
		{
			builder.AddOffset(3, targetPosOffset.Value, 0);
		}

		// Token: 0x060329E4 RID: 207332 RVA: 0x006D703F File Offset: 0x006D523F
		public static void AddCanInterrupt(FlatBufferBuilder builder, bool canInterrupt)
		{
			builder.AddBool(4, canInterrupt, false);
		}

		// Token: 0x060329E5 RID: 207333 RVA: 0x006D704A File Offset: 0x006D524A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060329E6 RID: 207334 RVA: 0x006D7055 File Offset: 0x006D5255
		public static Offset<IMechStunt> EndIMechStunt(FlatBufferBuilder builder)
		{
			return new Offset<IMechStunt>(builder.EndTable());
		}

		// Token: 0x060329E7 RID: 207335 RVA: 0x006D7064 File Offset: 0x006D5264
		public IMechStuntT UnPack()
		{
			IMechStuntT mechStuntT = new IMechStuntT();
			this.UnPackTo(mechStuntT);
			return mechStuntT;
		}

		// Token: 0x060329E8 RID: 207336 RVA: 0x006D7080 File Offset: 0x006D5280
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

		// Token: 0x060329E9 RID: 207337 RVA: 0x006D7284 File Offset: 0x006D5484
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

		// Token: 0x040121B9 RID: 74169
		private Table __p;
	}
}
