using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200719E RID: 29086
	public struct IMechBehaviorConfig : IFlatbufferObject
	{
		// Token: 0x1700D501 RID: 54529
		// (get) Token: 0x06032945 RID: 207173 RVA: 0x006D5A0A File Offset: 0x006D3C0A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032946 RID: 207174 RVA: 0x006D5A17 File Offset: 0x006D3C17
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032947 RID: 207175 RVA: 0x006D5A20 File Offset: 0x006D3C20
		public static IMechBehaviorConfig GetRootAsIMechBehaviorConfig(ByteBuffer _bb)
		{
			return IMechBehaviorConfig.GetRootAsIMechBehaviorConfig(_bb, default(IMechBehaviorConfig));
		}

		// Token: 0x06032948 RID: 207176 RVA: 0x006D5A3C File Offset: 0x006D3C3C
		public static IMechBehaviorConfig GetRootAsIMechBehaviorConfig(ByteBuffer _bb, IMechBehaviorConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032949 RID: 207177 RVA: 0x006D5A59 File Offset: 0x006D3C59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603294A RID: 207178 RVA: 0x006D5A68 File Offset: 0x006D3C68
		public IMechBehaviorConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D502 RID: 54530
		// (get) Token: 0x0603294B RID: 207179 RVA: 0x006D5A78 File Offset: 0x006D3C78
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

		// Token: 0x0603294C RID: 207180 RVA: 0x006D5AB4 File Offset: 0x006D3CB4
		public TTable? StuntConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603294D RID: 207181 RVA: 0x006D5AF8 File Offset: 0x006D3CF8
		public IMechStuntBurrow StuntConfigAsIMechStuntBurrow()
		{
			return this.StuntConfig<IMechStuntBurrow>().Value;
		}

		// Token: 0x0603294E RID: 207182 RVA: 0x006D5B14 File Offset: 0x006D3D14
		public IMechStuntClimbFly StuntConfigAsIMechStuntClimbFly()
		{
			return this.StuntConfig<IMechStuntClimbFly>().Value;
		}

		// Token: 0x0603294F RID: 207183 RVA: 0x006D5B30 File Offset: 0x006D3D30
		public IMechStuntDive StuntConfigAsIMechStuntDive()
		{
			return this.StuntConfig<IMechStuntDive>().Value;
		}

		// Token: 0x06032950 RID: 207184 RVA: 0x006D5B4C File Offset: 0x006D3D4C
		public IMechStuntHighSpeed StuntConfigAsIMechStuntHighSpeed()
		{
			return this.StuntConfig<IMechStuntHighSpeed>().Value;
		}

		// Token: 0x06032951 RID: 207185 RVA: 0x006D5B68 File Offset: 0x006D3D68
		public IMechStuntLevelFly StuntConfigAsIMechStuntLevelFly()
		{
			return this.StuntConfig<IMechStuntLevelFly>().Value;
		}

		// Token: 0x06032952 RID: 207186 RVA: 0x006D5B84 File Offset: 0x006D3D84
		public IMechStuntWater StuntConfigAsIMechStuntWater()
		{
			return this.StuntConfig<IMechStuntWater>().Value;
		}

		// Token: 0x1700D503 RID: 54531
		// (get) Token: 0x06032953 RID: 207187 RVA: 0x006D5BA0 File Offset: 0x006D3DA0
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

		// Token: 0x1700D504 RID: 54532
		// (get) Token: 0x06032954 RID: 207188 RVA: 0x006D5C00 File Offset: 0x006D3E00
		public bool CanInterrupt
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D505 RID: 54533
		// (get) Token: 0x06032955 RID: 207189 RVA: 0x006D5C40 File Offset: 0x006D3E40
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

		// Token: 0x06032956 RID: 207190 RVA: 0x006D5C7D File Offset: 0x006D3E7D
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

		// Token: 0x06032957 RID: 207191 RVA: 0x006D5CB1 File Offset: 0x006D3EB1
		public static void StartIMechBehaviorConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06032958 RID: 207192 RVA: 0x006D5CBA File Offset: 0x006D3EBA
		public static void AddStuntConfigType(FlatBufferBuilder builder, TMechStuntConfig stuntConfigType)
		{
			builder.AddByte(0, (byte)stuntConfigType, 0);
		}

		// Token: 0x06032959 RID: 207193 RVA: 0x006D5CC5 File Offset: 0x006D3EC5
		public static void AddStuntConfig(FlatBufferBuilder builder, int stuntConfigOffset)
		{
			builder.AddOffset(1, stuntConfigOffset, 0);
		}

		// Token: 0x0603295A RID: 207194 RVA: 0x006D5CD0 File Offset: 0x006D3ED0
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IVectorInfo> targetPosOffset)
		{
			builder.AddOffset(2, targetPosOffset.Value, 0);
		}

		// Token: 0x0603295B RID: 207195 RVA: 0x006D5CE0 File Offset: 0x006D3EE0
		public static void AddCanInterrupt(FlatBufferBuilder builder, bool canInterrupt)
		{
			builder.AddBool(3, canInterrupt, false);
		}

		// Token: 0x0603295C RID: 207196 RVA: 0x006D5CEB File Offset: 0x006D3EEB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0603295D RID: 207197 RVA: 0x006D5CF6 File Offset: 0x006D3EF6
		public static Offset<IMechBehaviorConfig> EndIMechBehaviorConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMechBehaviorConfig>(builder.EndTable());
		}

		// Token: 0x0603295E RID: 207198 RVA: 0x006D5D04 File Offset: 0x006D3F04
		public IMechBehaviorConfigT UnPack()
		{
			IMechBehaviorConfigT mechBehaviorConfigT = new IMechBehaviorConfigT();
			this.UnPackTo(mechBehaviorConfigT);
			return mechBehaviorConfigT;
		}

		// Token: 0x0603295F RID: 207199 RVA: 0x006D5D20 File Offset: 0x006D3F20
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

		// Token: 0x06032960 RID: 207200 RVA: 0x006D5F18 File Offset: 0x006D4118
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

		// Token: 0x040121A6 RID: 74150
		private Table __p;
	}
}
