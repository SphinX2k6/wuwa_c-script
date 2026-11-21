using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200492F RID: 18735
	public struct IFindSunSpiritLevelConfig : IFlatbufferObject
	{
		// Token: 0x17008282 RID: 33410
		// (get) Token: 0x0601BCC9 RID: 113865 RVA: 0x003EDE40 File Offset: 0x003EC040
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BCCA RID: 113866 RVA: 0x003EDE4D File Offset: 0x003EC04D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BCCB RID: 113867 RVA: 0x003EDE54 File Offset: 0x003EC054
		public static IFindSunSpiritLevelConfig GetRootAsIFindSunSpiritLevelConfig(ByteBuffer _bb)
		{
			return IFindSunSpiritLevelConfig.GetRootAsIFindSunSpiritLevelConfig(_bb, default(IFindSunSpiritLevelConfig));
		}

		// Token: 0x0601BCCC RID: 113868 RVA: 0x003EDE70 File Offset: 0x003EC070
		public static IFindSunSpiritLevelConfig GetRootAsIFindSunSpiritLevelConfig(ByteBuffer _bb, IFindSunSpiritLevelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BCCD RID: 113869 RVA: 0x003EDE8D File Offset: 0x003EC08D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BCCE RID: 113870 RVA: 0x003EDE9C File Offset: 0x003EC09C
		public IFindSunSpiritLevelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008283 RID: 33411
		// (get) Token: 0x0601BCCF RID: 113871 RVA: 0x003EDEAC File Offset: 0x003EC0AC
		public IFindSunSpiritGridConfig? GridConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IFindSunSpiritGridConfig?(default(IFindSunSpiritGridConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008284 RID: 33412
		// (get) Token: 0x0601BCD0 RID: 113872 RVA: 0x003EDF0C File Offset: 0x003EC10C
		public int MaxJumpHeight
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008285 RID: 33413
		// (get) Token: 0x0601BCD1 RID: 113873 RVA: 0x003EDF48 File Offset: 0x003EC148
		public int MaxTimes
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008286 RID: 33414
		// (get) Token: 0x0601BCD2 RID: 113874 RVA: 0x003EDF84 File Offset: 0x003EC184
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BCD3 RID: 113875 RVA: 0x003EDFC1 File Offset: 0x003EC1C1
		public static Offset<IFindSunSpiritLevelConfig> CreateIFindSunSpiritLevelConfig(FlatBufferBuilder builder, Offset<IFindSunSpiritGridConfig> GridConfigOffset = default(Offset<IFindSunSpiritGridConfig>), int MaxJumpHeight = 0, int MaxTimes = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IFindSunSpiritLevelConfig.AddMaxTimes(builder, MaxTimes);
			IFindSunSpiritLevelConfig.AddMaxJumpHeight(builder, MaxJumpHeight);
			IFindSunSpiritLevelConfig.AddGridConfig(builder, GridConfigOffset);
			IFindSunSpiritLevelConfig.AddNullMask(builder, NullMask);
			return IFindSunSpiritLevelConfig.EndIFindSunSpiritLevelConfig(builder);
		}

		// Token: 0x0601BCD4 RID: 113876 RVA: 0x003EDFED File Offset: 0x003EC1ED
		public static void StartIFindSunSpiritLevelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601BCD5 RID: 113877 RVA: 0x003EDFF6 File Offset: 0x003EC1F6
		public static void AddGridConfig(FlatBufferBuilder builder, Offset<IFindSunSpiritGridConfig> gridConfigOffset)
		{
			builder.AddOffset(0, gridConfigOffset.Value, 0);
		}

		// Token: 0x0601BCD6 RID: 113878 RVA: 0x003EE006 File Offset: 0x003EC206
		public static void AddMaxJumpHeight(FlatBufferBuilder builder, int maxJumpHeight)
		{
			builder.AddInt(1, maxJumpHeight, 0);
		}

		// Token: 0x0601BCD7 RID: 113879 RVA: 0x003EE011 File Offset: 0x003EC211
		public static void AddMaxTimes(FlatBufferBuilder builder, int maxTimes)
		{
			builder.AddInt(2, maxTimes, 0);
		}

		// Token: 0x0601BCD8 RID: 113880 RVA: 0x003EE01C File Offset: 0x003EC21C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601BCD9 RID: 113881 RVA: 0x003EE027 File Offset: 0x003EC227
		public static Offset<IFindSunSpiritLevelConfig> EndIFindSunSpiritLevelConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritLevelConfig>(builder.EndTable());
		}

		// Token: 0x0601BCDA RID: 113882 RVA: 0x003EE034 File Offset: 0x003EC234
		public IFindSunSpiritLevelConfigT UnPack()
		{
			IFindSunSpiritLevelConfigT findSunSpiritLevelConfigT = new IFindSunSpiritLevelConfigT();
			this.UnPackTo(findSunSpiritLevelConfigT);
			return findSunSpiritLevelConfigT;
		}

		// Token: 0x0601BCDB RID: 113883 RVA: 0x003EE050 File Offset: 0x003EC250
		public void UnPackTo(IFindSunSpiritLevelConfigT _o)
		{
			_o.GridConfig = ((this.GridConfig != null) ? this.GridConfig.Value.UnPack() : null);
			_o.MaxJumpHeight = this.MaxJumpHeight;
			_o.MaxTimes = this.MaxTimes;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601BCDC RID: 113884 RVA: 0x003EE0B0 File Offset: 0x003EC2B0
		public static Offset<IFindSunSpiritLevelConfig> Pack(FlatBufferBuilder builder, IFindSunSpiritLevelConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFindSunSpiritLevelConfig>);
			}
			Offset<IFindSunSpiritGridConfig> gridConfigOffset = (_o.GridConfig == null) ? default(Offset<IFindSunSpiritGridConfig>) : IFindSunSpiritGridConfig.Pack(builder, _o.GridConfig);
			return IFindSunSpiritLevelConfig.CreateIFindSunSpiritLevelConfig(builder, gridConfigOffset, _o.MaxJumpHeight, _o.MaxTimes, _o.NullMask);
		}

		// Token: 0x0400CF0B RID: 53003
		private Table __p;
	}
}
