using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004914 RID: 18708
	public struct IFindSunSpiritConfig : IFlatbufferObject
	{
		// Token: 0x17008253 RID: 33363
		// (get) Token: 0x0601BBEB RID: 113643 RVA: 0x003EC52A File Offset: 0x003EA72A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BBEC RID: 113644 RVA: 0x003EC537 File Offset: 0x003EA737
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BBED RID: 113645 RVA: 0x003EC540 File Offset: 0x003EA740
		public static IFindSunSpiritConfig GetRootAsIFindSunSpiritConfig(ByteBuffer _bb)
		{
			return IFindSunSpiritConfig.GetRootAsIFindSunSpiritConfig(_bb, default(IFindSunSpiritConfig));
		}

		// Token: 0x0601BBEE RID: 113646 RVA: 0x003EC55C File Offset: 0x003EA75C
		public static IFindSunSpiritConfig GetRootAsIFindSunSpiritConfig(ByteBuffer _bb, IFindSunSpiritConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BBEF RID: 113647 RVA: 0x003EC579 File Offset: 0x003EA779
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BBF0 RID: 113648 RVA: 0x003EC588 File Offset: 0x003EA788
		public IFindSunSpiritConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008254 RID: 33364
		// (get) Token: 0x0601BBF1 RID: 113649 RVA: 0x003EC598 File Offset: 0x003EA798
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008255 RID: 33365
		// (get) Token: 0x0601BBF2 RID: 113650 RVA: 0x003EC5D4 File Offset: 0x003EA7D4
		public string Name
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

		// Token: 0x0601BBF3 RID: 113651 RVA: 0x003EC60B File Offset: 0x003EA80B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601BBF4 RID: 113652 RVA: 0x003EC61A File Offset: 0x003EA81A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008256 RID: 33366
		// (get) Token: 0x0601BBF5 RID: 113653 RVA: 0x003EC628 File Offset: 0x003EA828
		public IFindSunSpiritLevelConfig? Level
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IFindSunSpiritLevelConfig?(default(IFindSunSpiritLevelConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601BBF6 RID: 113654 RVA: 0x003EC685 File Offset: 0x003EA885
		public static Offset<IFindSunSpiritConfig> CreateIFindSunSpiritConfig(FlatBufferBuilder builder, int Id = 0, StringOffset NameOffset = default(StringOffset), Offset<IFindSunSpiritLevelConfig> LevelOffset = default(Offset<IFindSunSpiritLevelConfig>))
		{
			builder.StartTable(3);
			IFindSunSpiritConfig.AddLevel(builder, LevelOffset);
			IFindSunSpiritConfig.AddName(builder, NameOffset);
			IFindSunSpiritConfig.AddId(builder, Id);
			return IFindSunSpiritConfig.EndIFindSunSpiritConfig(builder);
		}

		// Token: 0x0601BBF7 RID: 113655 RVA: 0x003EC6A9 File Offset: 0x003EA8A9
		public static void StartIFindSunSpiritConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601BBF8 RID: 113656 RVA: 0x003EC6B2 File Offset: 0x003EA8B2
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601BBF9 RID: 113657 RVA: 0x003EC6BD File Offset: 0x003EA8BD
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601BBFA RID: 113658 RVA: 0x003EC6CD File Offset: 0x003EA8CD
		public static void AddLevel(FlatBufferBuilder builder, Offset<IFindSunSpiritLevelConfig> levelOffset)
		{
			builder.AddOffset(2, levelOffset.Value, 0);
		}

		// Token: 0x0601BBFB RID: 113659 RVA: 0x003EC6DD File Offset: 0x003EA8DD
		public static Offset<IFindSunSpiritConfig> EndIFindSunSpiritConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritConfig>(builder.EndTable());
		}

		// Token: 0x0601BBFC RID: 113660 RVA: 0x003EC6EC File Offset: 0x003EA8EC
		public IFindSunSpiritConfigT UnPack()
		{
			IFindSunSpiritConfigT findSunSpiritConfigT = new IFindSunSpiritConfigT();
			this.UnPackTo(findSunSpiritConfigT);
			return findSunSpiritConfigT;
		}

		// Token: 0x0601BBFD RID: 113661 RVA: 0x003EC708 File Offset: 0x003EA908
		public void UnPackTo(IFindSunSpiritConfigT _o)
		{
			_o.Id = this.Id;
			_o.Name = this.Name;
			_o.Level = ((this.Level != null) ? this.Level.Value.UnPack() : null);
		}

		// Token: 0x0601BBFE RID: 113662 RVA: 0x003EC75C File Offset: 0x003EA95C
		public static Offset<IFindSunSpiritConfig> Pack(FlatBufferBuilder builder, IFindSunSpiritConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFindSunSpiritConfig>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			Offset<IFindSunSpiritLevelConfig> levelOffset = (_o.Level == null) ? default(Offset<IFindSunSpiritLevelConfig>) : IFindSunSpiritLevelConfig.Pack(builder, _o.Level);
			return IFindSunSpiritConfig.CreateIFindSunSpiritConfig(builder, _o.Id, nameOffset, levelOffset);
		}

		// Token: 0x0400CEE7 RID: 52967
		private Table __p;
	}
}
