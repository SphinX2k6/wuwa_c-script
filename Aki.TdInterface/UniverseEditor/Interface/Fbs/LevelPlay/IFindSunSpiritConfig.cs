using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044AC RID: 17580
	public struct IFindSunSpiritConfig : IFlatbufferObject
	{
		// Token: 0x17007C14 RID: 31764
		// (get) Token: 0x0601A41A RID: 107546 RVA: 0x003C031E File Offset: 0x003BE51E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A41B RID: 107547 RVA: 0x003C032B File Offset: 0x003BE52B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A41C RID: 107548 RVA: 0x003C0334 File Offset: 0x003BE534
		public static IFindSunSpiritConfig GetRootAsIFindSunSpiritConfig(ByteBuffer _bb)
		{
			return IFindSunSpiritConfig.GetRootAsIFindSunSpiritConfig(_bb, default(IFindSunSpiritConfig));
		}

		// Token: 0x0601A41D RID: 107549 RVA: 0x003C0350 File Offset: 0x003BE550
		public static IFindSunSpiritConfig GetRootAsIFindSunSpiritConfig(ByteBuffer _bb, IFindSunSpiritConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A41E RID: 107550 RVA: 0x003C036D File Offset: 0x003BE56D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A41F RID: 107551 RVA: 0x003C037C File Offset: 0x003BE57C
		public IFindSunSpiritConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C15 RID: 31765
		// (get) Token: 0x0601A420 RID: 107552 RVA: 0x003C038C File Offset: 0x003BE58C
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

		// Token: 0x17007C16 RID: 31766
		// (get) Token: 0x0601A421 RID: 107553 RVA: 0x003C03C8 File Offset: 0x003BE5C8
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

		// Token: 0x0601A422 RID: 107554 RVA: 0x003C03FF File Offset: 0x003BE5FF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601A423 RID: 107555 RVA: 0x003C040E File Offset: 0x003BE60E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17007C17 RID: 31767
		// (get) Token: 0x0601A424 RID: 107556 RVA: 0x003C041C File Offset: 0x003BE61C
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

		// Token: 0x0601A425 RID: 107557 RVA: 0x003C0479 File Offset: 0x003BE679
		public static Offset<IFindSunSpiritConfig> CreateIFindSunSpiritConfig(FlatBufferBuilder builder, int Id = 0, StringOffset NameOffset = default(StringOffset), Offset<IFindSunSpiritLevelConfig> LevelOffset = default(Offset<IFindSunSpiritLevelConfig>))
		{
			builder.StartTable(3);
			IFindSunSpiritConfig.AddLevel(builder, LevelOffset);
			IFindSunSpiritConfig.AddName(builder, NameOffset);
			IFindSunSpiritConfig.AddId(builder, Id);
			return IFindSunSpiritConfig.EndIFindSunSpiritConfig(builder);
		}

		// Token: 0x0601A426 RID: 107558 RVA: 0x003C049D File Offset: 0x003BE69D
		public static void StartIFindSunSpiritConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A427 RID: 107559 RVA: 0x003C04A6 File Offset: 0x003BE6A6
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601A428 RID: 107560 RVA: 0x003C04B1 File Offset: 0x003BE6B1
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601A429 RID: 107561 RVA: 0x003C04C1 File Offset: 0x003BE6C1
		public static void AddLevel(FlatBufferBuilder builder, Offset<IFindSunSpiritLevelConfig> levelOffset)
		{
			builder.AddOffset(2, levelOffset.Value, 0);
		}

		// Token: 0x0601A42A RID: 107562 RVA: 0x003C04D1 File Offset: 0x003BE6D1
		public static Offset<IFindSunSpiritConfig> EndIFindSunSpiritConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritConfig>(builder.EndTable());
		}

		// Token: 0x0601A42B RID: 107563 RVA: 0x003C04E0 File Offset: 0x003BE6E0
		public IFindSunSpiritConfigT UnPack()
		{
			IFindSunSpiritConfigT findSunSpiritConfigT = new IFindSunSpiritConfigT();
			this.UnPackTo(findSunSpiritConfigT);
			return findSunSpiritConfigT;
		}

		// Token: 0x0601A42C RID: 107564 RVA: 0x003C04FC File Offset: 0x003BE6FC
		public void UnPackTo(IFindSunSpiritConfigT _o)
		{
			_o.Id = this.Id;
			_o.Name = this.Name;
			_o.Level = ((this.Level != null) ? this.Level.Value.UnPack() : null);
		}

		// Token: 0x0601A42D RID: 107565 RVA: 0x003C0550 File Offset: 0x003BE750
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

		// Token: 0x0400C4B9 RID: 50361
		private Table __p;
	}
}
