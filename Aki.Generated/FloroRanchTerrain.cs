using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D9F RID: 3487
	public struct FloroRanchTerrain : IFlatbufferObject
	{
		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x06007AF0 RID: 31472 RVA: 0x0025DABC File Offset: 0x0025BCBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007AF1 RID: 31473 RVA: 0x0025DAC9 File Offset: 0x0025BCC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007AF2 RID: 31474 RVA: 0x0025DAD0 File Offset: 0x0025BCD0
		public static FloroRanchTerrain GetRootAsFloroRanchTerrain(ByteBuffer _bb)
		{
			return FloroRanchTerrain.GetRootAsFloroRanchTerrain(_bb, default(FloroRanchTerrain));
		}

		// Token: 0x06007AF3 RID: 31475 RVA: 0x0025DAEC File Offset: 0x0025BCEC
		public static FloroRanchTerrain GetRootAsFloroRanchTerrain(ByteBuffer _bb, FloroRanchTerrain obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007AF4 RID: 31476 RVA: 0x0025DB09 File Offset: 0x0025BD09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007AF5 RID: 31477 RVA: 0x0025DB18 File Offset: 0x0025BD18
		public FloroRanchTerrain __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x06007AF6 RID: 31478 RVA: 0x0025DB28 File Offset: 0x0025BD28
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

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x06007AF7 RID: 31479 RVA: 0x0025DB64 File Offset: 0x0025BD64
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

		// Token: 0x06007AF8 RID: 31480 RVA: 0x0025DB9B File Offset: 0x0025BD9B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007AF9 RID: 31481 RVA: 0x0025DBAA File Offset: 0x0025BDAA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x06007AFA RID: 31482 RVA: 0x0025DBC4 File Offset: 0x0025BDC4
		public string Pic
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

		// Token: 0x06007AFB RID: 31483 RVA: 0x0025DBFB File Offset: 0x0025BDFB
		public Span<byte> GetPicBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007AFC RID: 31484 RVA: 0x0025DC0A File Offset: 0x0025BE0A
		public byte[] GetPicArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x06007AFD RID: 31485 RVA: 0x0025DC24 File Offset: 0x0025BE24
		public int Tag
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x06007AFE RID: 31486 RVA: 0x0025DC64 File Offset: 0x0025BE64
		public string Desc
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

		// Token: 0x06007AFF RID: 31487 RVA: 0x0025DC9C File Offset: 0x0025BE9C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007B00 RID: 31488 RVA: 0x0025DCAC File Offset: 0x0025BEAC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x06007B01 RID: 31489 RVA: 0x0025DCC4 File Offset: 0x0025BEC4
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007B02 RID: 31490 RVA: 0x0025DCFC File Offset: 0x0025BEFC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007B03 RID: 31491 RVA: 0x0025DD0C File Offset: 0x0025BF0C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400530F RID: 21263
		private Table __p;
	}
}
