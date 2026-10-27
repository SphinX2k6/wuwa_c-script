using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A65 RID: 27237
	public struct ILoopSeasonChange : IFlatbufferObject
	{
		// Token: 0x1700CA0E RID: 51726
		// (get) Token: 0x0602FB2C RID: 195372 RVA: 0x0067DB98 File Offset: 0x0067BD98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FB2D RID: 195373 RVA: 0x0067DBA5 File Offset: 0x0067BDA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FB2E RID: 195374 RVA: 0x0067DBAC File Offset: 0x0067BDAC
		public static ILoopSeasonChange GetRootAsILoopSeasonChange(ByteBuffer _bb)
		{
			return ILoopSeasonChange.GetRootAsILoopSeasonChange(_bb, default(ILoopSeasonChange));
		}

		// Token: 0x0602FB2F RID: 195375 RVA: 0x0067DBC8 File Offset: 0x0067BDC8
		public static ILoopSeasonChange GetRootAsILoopSeasonChange(ByteBuffer _bb, ILoopSeasonChange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FB30 RID: 195376 RVA: 0x0067DBE5 File Offset: 0x0067BDE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FB31 RID: 195377 RVA: 0x0067DBF4 File Offset: 0x0067BDF4
		public ILoopSeasonChange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA0F RID: 51727
		// (get) Token: 0x0602FB32 RID: 195378 RVA: 0x0067DC04 File Offset: 0x0067BE04
		public EClientSetSeasonStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientSetSeasonStateType.SwitchSeason;
				}
				return (EClientSetSeasonStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CA10 RID: 51728
		// (get) Token: 0x0602FB33 RID: 195379 RVA: 0x0067DC40 File Offset: 0x0067BE40
		public bool EnableLoop
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CA11 RID: 51729
		// (get) Token: 0x0602FB34 RID: 195380 RVA: 0x0067DC80 File Offset: 0x0067BE80
		public ISeasonLoopConfig? SpringConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ISeasonLoopConfig?(default(ISeasonLoopConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CA12 RID: 51730
		// (get) Token: 0x0602FB35 RID: 195381 RVA: 0x0067DCE0 File Offset: 0x0067BEE0
		public ISeasonLoopConfig? SummerConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ISeasonLoopConfig?(default(ISeasonLoopConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CA13 RID: 51731
		// (get) Token: 0x0602FB36 RID: 195382 RVA: 0x0067DD40 File Offset: 0x0067BF40
		public ISeasonLoopConfig? AutumnConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ISeasonLoopConfig?(default(ISeasonLoopConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CA14 RID: 51732
		// (get) Token: 0x0602FB37 RID: 195383 RVA: 0x0067DDA0 File Offset: 0x0067BFA0
		public ISeasonLoopConfig? WinterConfig
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new ISeasonLoopConfig?(default(ISeasonLoopConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602FB38 RID: 195384 RVA: 0x0067DDFE File Offset: 0x0067BFFE
		public static Offset<ILoopSeasonChange> CreateILoopSeasonChange(FlatBufferBuilder builder, EClientSetSeasonStateType Type = EClientSetSeasonStateType.SwitchSeason, bool EnableLoop = false, Offset<ISeasonLoopConfig> SpringConfigOffset = default(Offset<ISeasonLoopConfig>), Offset<ISeasonLoopConfig> SummerConfigOffset = default(Offset<ISeasonLoopConfig>), Offset<ISeasonLoopConfig> AutumnConfigOffset = default(Offset<ISeasonLoopConfig>), Offset<ISeasonLoopConfig> WinterConfigOffset = default(Offset<ISeasonLoopConfig>))
		{
			builder.StartTable(6);
			ILoopSeasonChange.AddWinterConfig(builder, WinterConfigOffset);
			ILoopSeasonChange.AddAutumnConfig(builder, AutumnConfigOffset);
			ILoopSeasonChange.AddSummerConfig(builder, SummerConfigOffset);
			ILoopSeasonChange.AddSpringConfig(builder, SpringConfigOffset);
			ILoopSeasonChange.AddEnableLoop(builder, EnableLoop);
			ILoopSeasonChange.AddType(builder, Type);
			return ILoopSeasonChange.EndILoopSeasonChange(builder);
		}

		// Token: 0x0602FB39 RID: 195385 RVA: 0x0067DE3A File Offset: 0x0067C03A
		public static void StartILoopSeasonChange(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602FB3A RID: 195386 RVA: 0x0067DE43 File Offset: 0x0067C043
		public static void AddType(FlatBufferBuilder builder, EClientSetSeasonStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FB3B RID: 195387 RVA: 0x0067DE4E File Offset: 0x0067C04E
		public static void AddEnableLoop(FlatBufferBuilder builder, bool enableLoop)
		{
			builder.AddBool(1, enableLoop, false);
		}

		// Token: 0x0602FB3C RID: 195388 RVA: 0x0067DE59 File Offset: 0x0067C059
		public static void AddSpringConfig(FlatBufferBuilder builder, Offset<ISeasonLoopConfig> springConfigOffset)
		{
			builder.AddOffset(2, springConfigOffset.Value, 0);
		}

		// Token: 0x0602FB3D RID: 195389 RVA: 0x0067DE69 File Offset: 0x0067C069
		public static void AddSummerConfig(FlatBufferBuilder builder, Offset<ISeasonLoopConfig> summerConfigOffset)
		{
			builder.AddOffset(3, summerConfigOffset.Value, 0);
		}

		// Token: 0x0602FB3E RID: 195390 RVA: 0x0067DE79 File Offset: 0x0067C079
		public static void AddAutumnConfig(FlatBufferBuilder builder, Offset<ISeasonLoopConfig> autumnConfigOffset)
		{
			builder.AddOffset(4, autumnConfigOffset.Value, 0);
		}

		// Token: 0x0602FB3F RID: 195391 RVA: 0x0067DE89 File Offset: 0x0067C089
		public static void AddWinterConfig(FlatBufferBuilder builder, Offset<ISeasonLoopConfig> winterConfigOffset)
		{
			builder.AddOffset(5, winterConfigOffset.Value, 0);
		}

		// Token: 0x0602FB40 RID: 195392 RVA: 0x0067DE99 File Offset: 0x0067C099
		public static Offset<ILoopSeasonChange> EndILoopSeasonChange(FlatBufferBuilder builder)
		{
			return new Offset<ILoopSeasonChange>(builder.EndTable());
		}

		// Token: 0x0602FB41 RID: 195393 RVA: 0x0067DEA8 File Offset: 0x0067C0A8
		public ILoopSeasonChangeT UnPack()
		{
			ILoopSeasonChangeT loopSeasonChangeT = new ILoopSeasonChangeT();
			this.UnPackTo(loopSeasonChangeT);
			return loopSeasonChangeT;
		}

		// Token: 0x0602FB42 RID: 195394 RVA: 0x0067DEC4 File Offset: 0x0067C0C4
		public void UnPackTo(ILoopSeasonChangeT _o)
		{
			_o.Type = this.Type;
			_o.EnableLoop = this.EnableLoop;
			_o.SpringConfig = ((this.SpringConfig != null) ? this.SpringConfig.Value.UnPack() : null);
			_o.SummerConfig = ((this.SummerConfig != null) ? this.SummerConfig.Value.UnPack() : null);
			_o.AutumnConfig = ((this.AutumnConfig != null) ? this.AutumnConfig.Value.UnPack() : null);
			_o.WinterConfig = ((this.WinterConfig != null) ? this.WinterConfig.Value.UnPack() : null);
		}

		// Token: 0x0602FB43 RID: 195395 RVA: 0x0067DFA8 File Offset: 0x0067C1A8
		public static Offset<ILoopSeasonChange> Pack(FlatBufferBuilder builder, ILoopSeasonChangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILoopSeasonChange>);
			}
			Offset<ISeasonLoopConfig> springConfigOffset = (_o.SpringConfig == null) ? default(Offset<ISeasonLoopConfig>) : ISeasonLoopConfig.Pack(builder, _o.SpringConfig);
			Offset<ISeasonLoopConfig> summerConfigOffset = (_o.SummerConfig == null) ? default(Offset<ISeasonLoopConfig>) : ISeasonLoopConfig.Pack(builder, _o.SummerConfig);
			Offset<ISeasonLoopConfig> autumnConfigOffset = (_o.AutumnConfig == null) ? default(Offset<ISeasonLoopConfig>) : ISeasonLoopConfig.Pack(builder, _o.AutumnConfig);
			Offset<ISeasonLoopConfig> winterConfigOffset = (_o.WinterConfig == null) ? default(Offset<ISeasonLoopConfig>) : ISeasonLoopConfig.Pack(builder, _o.WinterConfig);
			return ILoopSeasonChange.CreateILoopSeasonChange(builder, _o.Type, _o.EnableLoop, springConfigOffset, summerConfigOffset, autumnConfigOffset, winterConfigOffset);
		}

		// Token: 0x04011286 RID: 70278
		private Table __p;
	}
}
