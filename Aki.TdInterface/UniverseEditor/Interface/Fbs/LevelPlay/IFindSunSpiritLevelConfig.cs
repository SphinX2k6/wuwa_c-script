using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044C7 RID: 17607
	public struct IFindSunSpiritLevelConfig : IFlatbufferObject
	{
		// Token: 0x17007C43 RID: 31811
		// (get) Token: 0x0601A4F8 RID: 107768 RVA: 0x003C1C34 File Offset: 0x003BFE34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A4F9 RID: 107769 RVA: 0x003C1C41 File Offset: 0x003BFE41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A4FA RID: 107770 RVA: 0x003C1C48 File Offset: 0x003BFE48
		public static IFindSunSpiritLevelConfig GetRootAsIFindSunSpiritLevelConfig(ByteBuffer _bb)
		{
			return IFindSunSpiritLevelConfig.GetRootAsIFindSunSpiritLevelConfig(_bb, default(IFindSunSpiritLevelConfig));
		}

		// Token: 0x0601A4FB RID: 107771 RVA: 0x003C1C64 File Offset: 0x003BFE64
		public static IFindSunSpiritLevelConfig GetRootAsIFindSunSpiritLevelConfig(ByteBuffer _bb, IFindSunSpiritLevelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A4FC RID: 107772 RVA: 0x003C1C81 File Offset: 0x003BFE81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A4FD RID: 107773 RVA: 0x003C1C90 File Offset: 0x003BFE90
		public IFindSunSpiritLevelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C44 RID: 31812
		// (get) Token: 0x0601A4FE RID: 107774 RVA: 0x003C1CA0 File Offset: 0x003BFEA0
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

		// Token: 0x17007C45 RID: 31813
		// (get) Token: 0x0601A4FF RID: 107775 RVA: 0x003C1D00 File Offset: 0x003BFF00
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

		// Token: 0x17007C46 RID: 31814
		// (get) Token: 0x0601A500 RID: 107776 RVA: 0x003C1D3C File Offset: 0x003BFF3C
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

		// Token: 0x17007C47 RID: 31815
		// (get) Token: 0x0601A501 RID: 107777 RVA: 0x003C1D78 File Offset: 0x003BFF78
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

		// Token: 0x0601A502 RID: 107778 RVA: 0x003C1DB5 File Offset: 0x003BFFB5
		public static Offset<IFindSunSpiritLevelConfig> CreateIFindSunSpiritLevelConfig(FlatBufferBuilder builder, Offset<IFindSunSpiritGridConfig> GridConfigOffset = default(Offset<IFindSunSpiritGridConfig>), int MaxJumpHeight = 0, int MaxTimes = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IFindSunSpiritLevelConfig.AddMaxTimes(builder, MaxTimes);
			IFindSunSpiritLevelConfig.AddMaxJumpHeight(builder, MaxJumpHeight);
			IFindSunSpiritLevelConfig.AddGridConfig(builder, GridConfigOffset);
			IFindSunSpiritLevelConfig.AddNullMask(builder, NullMask);
			return IFindSunSpiritLevelConfig.EndIFindSunSpiritLevelConfig(builder);
		}

		// Token: 0x0601A503 RID: 107779 RVA: 0x003C1DE1 File Offset: 0x003BFFE1
		public static void StartIFindSunSpiritLevelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601A504 RID: 107780 RVA: 0x003C1DEA File Offset: 0x003BFFEA
		public static void AddGridConfig(FlatBufferBuilder builder, Offset<IFindSunSpiritGridConfig> gridConfigOffset)
		{
			builder.AddOffset(0, gridConfigOffset.Value, 0);
		}

		// Token: 0x0601A505 RID: 107781 RVA: 0x003C1DFA File Offset: 0x003BFFFA
		public static void AddMaxJumpHeight(FlatBufferBuilder builder, int maxJumpHeight)
		{
			builder.AddInt(1, maxJumpHeight, 0);
		}

		// Token: 0x0601A506 RID: 107782 RVA: 0x003C1E05 File Offset: 0x003C0005
		public static void AddMaxTimes(FlatBufferBuilder builder, int maxTimes)
		{
			builder.AddInt(2, maxTimes, 0);
		}

		// Token: 0x0601A507 RID: 107783 RVA: 0x003C1E10 File Offset: 0x003C0010
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601A508 RID: 107784 RVA: 0x003C1E1B File Offset: 0x003C001B
		public static Offset<IFindSunSpiritLevelConfig> EndIFindSunSpiritLevelConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritLevelConfig>(builder.EndTable());
		}

		// Token: 0x0601A509 RID: 107785 RVA: 0x003C1E28 File Offset: 0x003C0028
		public IFindSunSpiritLevelConfigT UnPack()
		{
			IFindSunSpiritLevelConfigT findSunSpiritLevelConfigT = new IFindSunSpiritLevelConfigT();
			this.UnPackTo(findSunSpiritLevelConfigT);
			return findSunSpiritLevelConfigT;
		}

		// Token: 0x0601A50A RID: 107786 RVA: 0x003C1E44 File Offset: 0x003C0044
		public void UnPackTo(IFindSunSpiritLevelConfigT _o)
		{
			_o.GridConfig = ((this.GridConfig != null) ? this.GridConfig.Value.UnPack() : null);
			_o.MaxJumpHeight = this.MaxJumpHeight;
			_o.MaxTimes = this.MaxTimes;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A50B RID: 107787 RVA: 0x003C1EA4 File Offset: 0x003C00A4
		public static Offset<IFindSunSpiritLevelConfig> Pack(FlatBufferBuilder builder, IFindSunSpiritLevelConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFindSunSpiritLevelConfig>);
			}
			Offset<IFindSunSpiritGridConfig> gridConfigOffset = (_o.GridConfig == null) ? default(Offset<IFindSunSpiritGridConfig>) : IFindSunSpiritGridConfig.Pack(builder, _o.GridConfig);
			return IFindSunSpiritLevelConfig.CreateIFindSunSpiritLevelConfig(builder, gridConfigOffset, _o.MaxJumpHeight, _o.MaxTimes, _o.NullMask);
		}

		// Token: 0x0400C4DD RID: 50397
		private Table __p;
	}
}
