using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E2A RID: 3626
	public struct HonamiStoryPluginSubType : IFlatbufferObject
	{
		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x060086DD RID: 34525 RVA: 0x00277B94 File Offset: 0x00275D94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060086DE RID: 34526 RVA: 0x00277BA1 File Offset: 0x00275DA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060086DF RID: 34527 RVA: 0x00277BA8 File Offset: 0x00275DA8
		public static HonamiStoryPluginSubType GetRootAsHonamiStoryPluginSubType(ByteBuffer _bb)
		{
			return HonamiStoryPluginSubType.GetRootAsHonamiStoryPluginSubType(_bb, default(HonamiStoryPluginSubType));
		}

		// Token: 0x060086E0 RID: 34528 RVA: 0x00277BC4 File Offset: 0x00275DC4
		public static HonamiStoryPluginSubType GetRootAsHonamiStoryPluginSubType(ByteBuffer _bb, HonamiStoryPluginSubType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060086E1 RID: 34529 RVA: 0x00277BE1 File Offset: 0x00275DE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060086E2 RID: 34530 RVA: 0x00277BF0 File Offset: 0x00275DF0
		public HonamiStoryPluginSubType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x060086E3 RID: 34531 RVA: 0x00277C00 File Offset: 0x00275E00
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

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x060086E4 RID: 34532 RVA: 0x00277C3C File Offset: 0x00275E3C
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

		// Token: 0x060086E5 RID: 34533 RVA: 0x00277C73 File Offset: 0x00275E73
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060086E6 RID: 34534 RVA: 0x00277C82 File Offset: 0x00275E82
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x060086E7 RID: 34535 RVA: 0x00277C9C File Offset: 0x00275E9C
		public string ActiveSpritePath
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060086E8 RID: 34536 RVA: 0x00277CD3 File Offset: 0x00275ED3
		public Span<byte> GetActiveSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060086E9 RID: 34537 RVA: 0x00277CE2 File Offset: 0x00275EE2
		public byte[] GetActiveSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x060086EA RID: 34538 RVA: 0x00277CFC File Offset: 0x00275EFC
		public string ActiveOneSpritePath
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060086EB RID: 34539 RVA: 0x00277D34 File Offset: 0x00275F34
		public Span<byte> GetActiveOneSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060086EC RID: 34540 RVA: 0x00277D44 File Offset: 0x00275F44
		public byte[] GetActiveOneSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x060086ED RID: 34541 RVA: 0x00277D5C File Offset: 0x00275F5C
		public string ActiveAllSpritePath
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060086EE RID: 34542 RVA: 0x00277D94 File Offset: 0x00275F94
		public Span<byte> GetActiveAllSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060086EF RID: 34543 RVA: 0x00277DA4 File Offset: 0x00275FA4
		public byte[] GetActiveAllSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040053A6 RID: 21414
		private Table __p;
	}
}
