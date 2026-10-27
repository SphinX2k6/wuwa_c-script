using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075CE RID: 30158
	public struct IVisualNovelPortraitPosPreset : IFlatbufferObject
	{
		// Token: 0x1700E518 RID: 58648
		// (get) Token: 0x06036EE6 RID: 224998 RVA: 0x00774AF8 File Offset: 0x00772CF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036EE7 RID: 224999 RVA: 0x00774B05 File Offset: 0x00772D05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036EE8 RID: 225000 RVA: 0x00774B0C File Offset: 0x00772D0C
		public static IVisualNovelPortraitPosPreset GetRootAsIVisualNovelPortraitPosPreset(ByteBuffer _bb)
		{
			return IVisualNovelPortraitPosPreset.GetRootAsIVisualNovelPortraitPosPreset(_bb, default(IVisualNovelPortraitPosPreset));
		}

		// Token: 0x06036EE9 RID: 225001 RVA: 0x00774B28 File Offset: 0x00772D28
		public static IVisualNovelPortraitPosPreset GetRootAsIVisualNovelPortraitPosPreset(ByteBuffer _bb, IVisualNovelPortraitPosPreset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036EEA RID: 225002 RVA: 0x00774B45 File Offset: 0x00772D45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036EEB RID: 225003 RVA: 0x00774B54 File Offset: 0x00772D54
		public IVisualNovelPortraitPosPreset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E519 RID: 58649
		// (get) Token: 0x06036EEC RID: 225004 RVA: 0x00774B64 File Offset: 0x00772D64
		public string Name
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036EED RID: 225005 RVA: 0x00774B9B File Offset: 0x00772D9B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06036EEE RID: 225006 RVA: 0x00774BAA File Offset: 0x00772DAA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700E51A RID: 58650
		// (get) Token: 0x06036EEF RID: 225007 RVA: 0x00774BB8 File Offset: 0x00772DB8
		public int PosX
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

		// Token: 0x1700E51B RID: 58651
		// (get) Token: 0x06036EF0 RID: 225008 RVA: 0x00774BF4 File Offset: 0x00772DF4
		public int PosY
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

		// Token: 0x06036EF1 RID: 225009 RVA: 0x00774C30 File Offset: 0x00772E30
		public static Offset<IVisualNovelPortraitPosPreset> CreateIVisualNovelPortraitPosPreset(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), int PosX = 0, int PosY = 0)
		{
			builder.StartTable(3);
			IVisualNovelPortraitPosPreset.AddPosY(builder, PosY);
			IVisualNovelPortraitPosPreset.AddPosX(builder, PosX);
			IVisualNovelPortraitPosPreset.AddName(builder, NameOffset);
			return IVisualNovelPortraitPosPreset.EndIVisualNovelPortraitPosPreset(builder);
		}

		// Token: 0x06036EF2 RID: 225010 RVA: 0x00774C54 File Offset: 0x00772E54
		public static void StartIVisualNovelPortraitPosPreset(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036EF3 RID: 225011 RVA: 0x00774C5D File Offset: 0x00772E5D
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x06036EF4 RID: 225012 RVA: 0x00774C6D File Offset: 0x00772E6D
		public static void AddPosX(FlatBufferBuilder builder, int posX)
		{
			builder.AddInt(1, posX, 0);
		}

		// Token: 0x06036EF5 RID: 225013 RVA: 0x00774C78 File Offset: 0x00772E78
		public static void AddPosY(FlatBufferBuilder builder, int posY)
		{
			builder.AddInt(2, posY, 0);
		}

		// Token: 0x06036EF6 RID: 225014 RVA: 0x00774C83 File Offset: 0x00772E83
		public static Offset<IVisualNovelPortraitPosPreset> EndIVisualNovelPortraitPosPreset(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPortraitPosPreset>(builder.EndTable());
		}

		// Token: 0x06036EF7 RID: 225015 RVA: 0x00774C90 File Offset: 0x00772E90
		public IVisualNovelPortraitPosPresetT UnPack()
		{
			IVisualNovelPortraitPosPresetT visualNovelPortraitPosPresetT = new IVisualNovelPortraitPosPresetT();
			this.UnPackTo(visualNovelPortraitPosPresetT);
			return visualNovelPortraitPosPresetT;
		}

		// Token: 0x06036EF8 RID: 225016 RVA: 0x00774CAB File Offset: 0x00772EAB
		public void UnPackTo(IVisualNovelPortraitPosPresetT _o)
		{
			_o.Name = this.Name;
			_o.PosX = this.PosX;
			_o.PosY = this.PosY;
		}

		// Token: 0x06036EF9 RID: 225017 RVA: 0x00774CD4 File Offset: 0x00772ED4
		public static Offset<IVisualNovelPortraitPosPreset> Pack(FlatBufferBuilder builder, IVisualNovelPortraitPosPresetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPortraitPosPreset>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return IVisualNovelPortraitPosPreset.CreateIVisualNovelPortraitPosPreset(builder, nameOffset, _o.PosX, _o.PosY);
		}

		// Token: 0x0401252B RID: 75051
		private Table __p;
	}
}
