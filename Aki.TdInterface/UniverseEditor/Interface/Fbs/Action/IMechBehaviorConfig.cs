using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A7C RID: 27260
	public struct IMechBehaviorConfig : IFlatbufferObject
	{
		// Token: 0x1700CA56 RID: 51798
		// (get) Token: 0x0602FC1F RID: 195615 RVA: 0x0067F94A File Offset: 0x0067DB4A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FC20 RID: 195616 RVA: 0x0067F957 File Offset: 0x0067DB57
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FC21 RID: 195617 RVA: 0x0067F960 File Offset: 0x0067DB60
		public static IMechBehaviorConfig GetRootAsIMechBehaviorConfig(ByteBuffer _bb)
		{
			return IMechBehaviorConfig.GetRootAsIMechBehaviorConfig(_bb, default(IMechBehaviorConfig));
		}

		// Token: 0x0602FC22 RID: 195618 RVA: 0x0067F97C File Offset: 0x0067DB7C
		public static IMechBehaviorConfig GetRootAsIMechBehaviorConfig(ByteBuffer _bb, IMechBehaviorConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FC23 RID: 195619 RVA: 0x0067F999 File Offset: 0x0067DB99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FC24 RID: 195620 RVA: 0x0067F9A8 File Offset: 0x0067DBA8
		public IMechBehaviorConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA57 RID: 51799
		// (get) Token: 0x0602FC25 RID: 195621 RVA: 0x0067F9B8 File Offset: 0x0067DBB8
		public TMechStuntConfig StuntConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TMechStuntConfig.NONE;
				}
				return (TMechStuntConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FC26 RID: 195622 RVA: 0x0067F9F4 File Offset: 0x0067DBF4
		public TTable? StuntConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FC27 RID: 195623 RVA: 0x0067FA38 File Offset: 0x0067DC38
		public IMechStuntBurrow StuntConfigAsIMechStuntBurrow()
		{
			return this.StuntConfig<IMechStuntBurrow>().Value;
		}

		// Token: 0x0602FC28 RID: 195624 RVA: 0x0067FA54 File Offset: 0x0067DC54
		public IMechStuntClimbFly StuntConfigAsIMechStuntClimbFly()
		{
			return this.StuntConfig<IMechStuntClimbFly>().Value;
		}

		// Token: 0x0602FC29 RID: 195625 RVA: 0x0067FA70 File Offset: 0x0067DC70
		public IMechStuntDive StuntConfigAsIMechStuntDive()
		{
			return this.StuntConfig<IMechStuntDive>().Value;
		}

		// Token: 0x0602FC2A RID: 195626 RVA: 0x0067FA8C File Offset: 0x0067DC8C
		public IMechStuntHighSpeed StuntConfigAsIMechStuntHighSpeed()
		{
			return this.StuntConfig<IMechStuntHighSpeed>().Value;
		}

		// Token: 0x0602FC2B RID: 195627 RVA: 0x0067FAA8 File Offset: 0x0067DCA8
		public IMechStuntLevelFly StuntConfigAsIMechStuntLevelFly()
		{
			return this.StuntConfig<IMechStuntLevelFly>().Value;
		}

		// Token: 0x0602FC2C RID: 195628 RVA: 0x0067FAC4 File Offset: 0x0067DCC4
		public IMechStuntWater StuntConfigAsIMechStuntWater()
		{
			return this.StuntConfig<IMechStuntWater>().Value;
		}

		// Token: 0x1700CA58 RID: 51800
		// (get) Token: 0x0602FC2D RID: 195629 RVA: 0x0067FAE0 File Offset: 0x0067DCE0
		public IVectorInfo? TargetPos
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CA59 RID: 51801
		// (get) Token: 0x0602FC2E RID: 195630 RVA: 0x0067FB40 File Offset: 0x0067DD40
		public bool CanInterrupt
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CA5A RID: 51802
		// (get) Token: 0x0602FC2F RID: 195631 RVA: 0x0067FB80 File Offset: 0x0067DD80
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FC30 RID: 195632 RVA: 0x0067FBBD File Offset: 0x0067DDBD
		public static Offset<IMechBehaviorConfig> CreateIMechBehaviorConfig(FlatBufferBuilder builder, TMechStuntConfig StuntConfig_type = TMechStuntConfig.NONE, int StuntConfigOffset = 0, Offset<IVectorInfo> TargetPosOffset = default(Offset<IVectorInfo>), bool CanInterrupt = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IMechBehaviorConfig.AddTargetPos(builder, TargetPosOffset);
			IMechBehaviorConfig.AddStuntConfig(builder, StuntConfigOffset);
			IMechBehaviorConfig.AddNullMask(builder, NullMask);
			IMechBehaviorConfig.AddCanInterrupt(builder, CanInterrupt);
			IMechBehaviorConfig.AddStuntConfigType(builder, StuntConfig_type);
			return IMechBehaviorConfig.EndIMechBehaviorConfig(builder);
		}

		// Token: 0x0602FC31 RID: 195633 RVA: 0x0067FBF1 File Offset: 0x0067DDF1
		public static void StartIMechBehaviorConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602FC32 RID: 195634 RVA: 0x0067FBFA File Offset: 0x0067DDFA
		public static void AddStuntConfigType(FlatBufferBuilder builder, TMechStuntConfig stuntConfigType)
		{
			builder.AddByte(0, (byte)stuntConfigType, 0);
		}

		// Token: 0x0602FC33 RID: 195635 RVA: 0x0067FC05 File Offset: 0x0067DE05
		public static void AddStuntConfig(FlatBufferBuilder builder, int stuntConfigOffset)
		{
			builder.AddOffset(1, stuntConfigOffset, 0);
		}

		// Token: 0x0602FC34 RID: 195636 RVA: 0x0067FC10 File Offset: 0x0067DE10
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IVectorInfo> targetPosOffset)
		{
			builder.AddOffset(2, targetPosOffset.Value, 0);
		}

		// Token: 0x0602FC35 RID: 195637 RVA: 0x0067FC20 File Offset: 0x0067DE20
		public static void AddCanInterrupt(FlatBufferBuilder builder, bool canInterrupt)
		{
			builder.AddBool(3, canInterrupt, false);
		}

		// Token: 0x0602FC36 RID: 195638 RVA: 0x0067FC2B File Offset: 0x0067DE2B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602FC37 RID: 195639 RVA: 0x0067FC36 File Offset: 0x0067DE36
		public static Offset<IMechBehaviorConfig> EndIMechBehaviorConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMechBehaviorConfig>(builder.EndTable());
		}

		// Token: 0x0602FC38 RID: 195640 RVA: 0x0067FC44 File Offset: 0x0067DE44
		public IMechBehaviorConfigT UnPack()
		{
			IMechBehaviorConfigT mechBehaviorConfigT = new IMechBehaviorConfigT();
			this.UnPackTo(mechBehaviorConfigT);
			return mechBehaviorConfigT;
		}

		// Token: 0x0602FC39 RID: 195641 RVA: 0x0067FC60 File Offset: 0x0067DE60
		public void UnPackTo(IMechBehaviorConfigT _o)
		{
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

		// Token: 0x0602FC3A RID: 195642 RVA: 0x0067FE58 File Offset: 0x0067E058
		public static Offset<IMechBehaviorConfig> Pack(FlatBufferBuilder builder, IMechBehaviorConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechBehaviorConfig>);
			}
			TMechStuntConfig stuntConfig_type = (_o.StuntConfig == null) ? TMechStuntConfig.NONE : _o.StuntConfig.Type;
			int stuntConfigOffset = (_o.StuntConfig == null) ? 0 : TMechStuntConfigUnion.Pack(builder, _o.StuntConfig);
			Offset<IVectorInfo> targetPosOffset = (_o.TargetPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TargetPos);
			return IMechBehaviorConfig.CreateIMechBehaviorConfig(builder, stuntConfig_type, stuntConfigOffset, targetPosOffset, _o.CanInterrupt, _o.NullMask);
		}

		// Token: 0x040112AE RID: 70318
		private Table __p;
	}
}
