using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200506F RID: 20591
	public struct IDamageTextOptimizationConfig : IFlatbufferObject
	{
		// Token: 0x17009560 RID: 38240
		// (get) Token: 0x06021007 RID: 135175 RVA: 0x00495D8B File Offset: 0x00493F8B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021008 RID: 135176 RVA: 0x00495D98 File Offset: 0x00493F98
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021009 RID: 135177 RVA: 0x00495DA0 File Offset: 0x00493FA0
		public static IDamageTextOptimizationConfig GetRootAsIDamageTextOptimizationConfig(ByteBuffer _bb)
		{
			return IDamageTextOptimizationConfig.GetRootAsIDamageTextOptimizationConfig(_bb, default(IDamageTextOptimizationConfig));
		}

		// Token: 0x0602100A RID: 135178 RVA: 0x00495DBC File Offset: 0x00493FBC
		public static IDamageTextOptimizationConfig GetRootAsIDamageTextOptimizationConfig(ByteBuffer _bb, IDamageTextOptimizationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602100B RID: 135179 RVA: 0x00495DD9 File Offset: 0x00493FD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602100C RID: 135180 RVA: 0x00495DE8 File Offset: 0x00493FE8
		public IDamageTextOptimizationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009561 RID: 38241
		// (get) Token: 0x0602100D RID: 135181 RVA: 0x00495DF8 File Offset: 0x00493FF8
		public EPerformanceOptimizationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformanceOptimizationType.PlaneMovementOptimization;
				}
				return (EPerformanceOptimizationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009562 RID: 38242
		// (get) Token: 0x0602100E RID: 135182 RVA: 0x00495E34 File Offset: 0x00494034
		public bool UseRange
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009563 RID: 38243
		// (get) Token: 0x0602100F RID: 135183 RVA: 0x00495E74 File Offset: 0x00494074
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021010 RID: 135184 RVA: 0x00495EB0 File Offset: 0x004940B0
		public static Offset<IDamageTextOptimizationConfig> CreateIDamageTextOptimizationConfig(FlatBufferBuilder builder, EPerformanceOptimizationType Type = EPerformanceOptimizationType.PlaneMovementOptimization, bool UseRange = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDamageTextOptimizationConfig.AddNullMask(builder, NullMask);
			IDamageTextOptimizationConfig.AddUseRange(builder, UseRange);
			IDamageTextOptimizationConfig.AddType(builder, Type);
			return IDamageTextOptimizationConfig.EndIDamageTextOptimizationConfig(builder);
		}

		// Token: 0x06021011 RID: 135185 RVA: 0x00495ED4 File Offset: 0x004940D4
		public static void StartIDamageTextOptimizationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021012 RID: 135186 RVA: 0x00495EDD File Offset: 0x004940DD
		public static void AddType(FlatBufferBuilder builder, EPerformanceOptimizationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021013 RID: 135187 RVA: 0x00495EE8 File Offset: 0x004940E8
		public static void AddUseRange(FlatBufferBuilder builder, bool useRange)
		{
			builder.AddBool(1, useRange, false);
		}

		// Token: 0x06021014 RID: 135188 RVA: 0x00495EF3 File Offset: 0x004940F3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06021015 RID: 135189 RVA: 0x00495EFE File Offset: 0x004940FE
		public static Offset<IDamageTextOptimizationConfig> EndIDamageTextOptimizationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDamageTextOptimizationConfig>(builder.EndTable());
		}

		// Token: 0x06021016 RID: 135190 RVA: 0x00495F0C File Offset: 0x0049410C
		public IDamageTextOptimizationConfigT UnPack()
		{
			IDamageTextOptimizationConfigT damageTextOptimizationConfigT = new IDamageTextOptimizationConfigT();
			this.UnPackTo(damageTextOptimizationConfigT);
			return damageTextOptimizationConfigT;
		}

		// Token: 0x06021017 RID: 135191 RVA: 0x00495F27 File Offset: 0x00494127
		public void UnPackTo(IDamageTextOptimizationConfigT _o)
		{
			_o.Type = this.Type;
			_o.UseRange = this.UseRange;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021018 RID: 135192 RVA: 0x00495F50 File Offset: 0x00494150
		public static Offset<IDamageTextOptimizationConfig> Pack(FlatBufferBuilder builder, IDamageTextOptimizationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDamageTextOptimizationConfig>);
			}
			return IDamageTextOptimizationConfig.CreateIDamageTextOptimizationConfig(builder, _o.Type, _o.UseRange, _o.NullMask);
		}

		// Token: 0x0400E070 RID: 57456
		private Table __p;
	}
}
