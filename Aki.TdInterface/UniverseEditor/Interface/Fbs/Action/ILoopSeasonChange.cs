using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007187 RID: 29063
	public struct ILoopSeasonChange : IFlatbufferObject
	{
		// Token: 0x1700D4B9 RID: 54457
		// (get) Token: 0x06032852 RID: 206930 RVA: 0x006D3C58 File Offset: 0x006D1E58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032853 RID: 206931 RVA: 0x006D3C65 File Offset: 0x006D1E65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032854 RID: 206932 RVA: 0x006D3C6C File Offset: 0x006D1E6C
		public static ILoopSeasonChange GetRootAsILoopSeasonChange(ByteBuffer _bb)
		{
			return ILoopSeasonChange.GetRootAsILoopSeasonChange(_bb, default(ILoopSeasonChange));
		}

		// Token: 0x06032855 RID: 206933 RVA: 0x006D3C88 File Offset: 0x006D1E88
		public static ILoopSeasonChange GetRootAsILoopSeasonChange(ByteBuffer _bb, ILoopSeasonChange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032856 RID: 206934 RVA: 0x006D3CA5 File Offset: 0x006D1EA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032857 RID: 206935 RVA: 0x006D3CB4 File Offset: 0x006D1EB4
		public ILoopSeasonChange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4BA RID: 54458
		// (get) Token: 0x06032858 RID: 206936 RVA: 0x006D3CC4 File Offset: 0x006D1EC4
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

		// Token: 0x1700D4BB RID: 54459
		// (get) Token: 0x06032859 RID: 206937 RVA: 0x006D3D00 File Offset: 0x006D1F00
		public bool EnableLoop
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D4BC RID: 54460
		// (get) Token: 0x0603285A RID: 206938 RVA: 0x006D3D40 File Offset: 0x006D1F40
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

		// Token: 0x1700D4BD RID: 54461
		// (get) Token: 0x0603285B RID: 206939 RVA: 0x006D3DA0 File Offset: 0x006D1FA0
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

		// Token: 0x1700D4BE RID: 54462
		// (get) Token: 0x0603285C RID: 206940 RVA: 0x006D3E00 File Offset: 0x006D2000
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

		// Token: 0x1700D4BF RID: 54463
		// (get) Token: 0x0603285D RID: 206941 RVA: 0x006D3E60 File Offset: 0x006D2060
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

		// Token: 0x0603285E RID: 206942 RVA: 0x006D3EBE File Offset: 0x006D20BE
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

		// Token: 0x0603285F RID: 206943 RVA: 0x006D3EFA File Offset: 0x006D20FA
		public static void StartILoopSeasonChange(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06032860 RID: 206944 RVA: 0x006D3F03 File Offset: 0x006D2103
		public static void AddType(FlatBufferBuilder builder, EClientSetSeasonStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032861 RID: 206945 RVA: 0x006D3F0E File Offset: 0x006D210E
		public static void AddEnableLoop(FlatBufferBuilder builder, bool enableLoop)
		{
			builder.AddBool(1, enableLoop, false);
		}

		// Token: 0x06032862 RID: 206946 RVA: 0x006D3F19 File Offset: 0x006D2119
		public static void AddSpringConfig(FlatBufferBuilder builder, Offset<ISeasonLoopConfig> springConfigOffset)
		{
			builder.AddOffset(2, springConfigOffset.Value, 0);
		}

		// Token: 0x06032863 RID: 206947 RVA: 0x006D3F29 File Offset: 0x006D2129
		public static void AddSummerConfig(FlatBufferBuilder builder, Offset<ISeasonLoopConfig> summerConfigOffset)
		{
			builder.AddOffset(3, summerConfigOffset.Value, 0);
		}

		// Token: 0x06032864 RID: 206948 RVA: 0x006D3F39 File Offset: 0x006D2139
		public static void AddAutumnConfig(FlatBufferBuilder builder, Offset<ISeasonLoopConfig> autumnConfigOffset)
		{
			builder.AddOffset(4, autumnConfigOffset.Value, 0);
		}

		// Token: 0x06032865 RID: 206949 RVA: 0x006D3F49 File Offset: 0x006D2149
		public static void AddWinterConfig(FlatBufferBuilder builder, Offset<ISeasonLoopConfig> winterConfigOffset)
		{
			builder.AddOffset(5, winterConfigOffset.Value, 0);
		}

		// Token: 0x06032866 RID: 206950 RVA: 0x006D3F59 File Offset: 0x006D2159
		public static Offset<ILoopSeasonChange> EndILoopSeasonChange(FlatBufferBuilder builder)
		{
			return new Offset<ILoopSeasonChange>(builder.EndTable());
		}

		// Token: 0x06032867 RID: 206951 RVA: 0x006D3F68 File Offset: 0x006D2168
		public ILoopSeasonChangeT UnPack()
		{
			ILoopSeasonChangeT loopSeasonChangeT = new ILoopSeasonChangeT();
			this.UnPackTo(loopSeasonChangeT);
			return loopSeasonChangeT;
		}

		// Token: 0x06032868 RID: 206952 RVA: 0x006D3F84 File Offset: 0x006D2184
		public void UnPackTo(ILoopSeasonChangeT _o)
		{
			_o.Type = this.Type;
			_o.EnableLoop = this.EnableLoop;
			_o.SpringConfig = ((this.SpringConfig != null) ? this.SpringConfig.Value.UnPack() : null);
			_o.SummerConfig = ((this.SummerConfig != null) ? this.SummerConfig.Value.UnPack() : null);
			_o.AutumnConfig = ((this.AutumnConfig != null) ? this.AutumnConfig.Value.UnPack() : null);
			_o.WinterConfig = ((this.WinterConfig != null) ? this.WinterConfig.Value.UnPack() : null);
		}

		// Token: 0x06032869 RID: 206953 RVA: 0x006D4068 File Offset: 0x006D2268
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

		// Token: 0x0401217E RID: 74110
		private Table __p;
	}
}
