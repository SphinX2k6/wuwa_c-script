using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE2 RID: 3554
	public struct GiantLevelUnlock : IFlatbufferObject
	{
		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x0600809F RID: 32927 RVA: 0x0026A09C File Offset: 0x0026829C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060080A0 RID: 32928 RVA: 0x0026A0A9 File Offset: 0x002682A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060080A1 RID: 32929 RVA: 0x0026A0B0 File Offset: 0x002682B0
		public static GiantLevelUnlock GetRootAsGiantLevelUnlock(ByteBuffer _bb)
		{
			return GiantLevelUnlock.GetRootAsGiantLevelUnlock(_bb, default(GiantLevelUnlock));
		}

		// Token: 0x060080A2 RID: 32930 RVA: 0x0026A0CC File Offset: 0x002682CC
		public static GiantLevelUnlock GetRootAsGiantLevelUnlock(ByteBuffer _bb, GiantLevelUnlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060080A3 RID: 32931 RVA: 0x0026A0E9 File Offset: 0x002682E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060080A4 RID: 32932 RVA: 0x0026A0F8 File Offset: 0x002682F8
		public GiantLevelUnlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x060080A5 RID: 32933 RVA: 0x0026A108 File Offset: 0x00268308
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

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x060080A6 RID: 32934 RVA: 0x0026A144 File Offset: 0x00268344
		public int EcoType
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

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x060080A7 RID: 32935 RVA: 0x0026A180 File Offset: 0x00268380
		public int Level
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

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x060080A8 RID: 32936 RVA: 0x0026A1BC File Offset: 0x002683BC
		public string PreUnlockDesc
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

		// Token: 0x060080A9 RID: 32937 RVA: 0x0026A1F4 File Offset: 0x002683F4
		public Span<byte> GetPreUnlockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060080AA RID: 32938 RVA: 0x0026A204 File Offset: 0x00268404
		public byte[] GetPreUnlockDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x060080AB RID: 32939 RVA: 0x0026A21C File Offset: 0x0026841C
		public string PostUnlockDesc1
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

		// Token: 0x060080AC RID: 32940 RVA: 0x0026A254 File Offset: 0x00268454
		public Span<byte> GetPostUnlockDesc1Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060080AD RID: 32941 RVA: 0x0026A264 File Offset: 0x00268464
		public byte[] GetPostUnlockDesc1Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x060080AE RID: 32942 RVA: 0x0026A27C File Offset: 0x0026847C
		public string PostUnlockDesc2
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

		// Token: 0x060080AF RID: 32943 RVA: 0x0026A2B4 File Offset: 0x002684B4
		public Span<byte> GetPostUnlockDesc2Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060080B0 RID: 32944 RVA: 0x0026A2C4 File Offset: 0x002684C4
		public byte[] GetPostUnlockDesc2Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x060080B1 RID: 32945 RVA: 0x0026A2DC File Offset: 0x002684DC
		public string NodeUnlockDesc
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060080B2 RID: 32946 RVA: 0x0026A314 File Offset: 0x00268514
		public Span<byte> GetNodeUnlockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060080B3 RID: 32947 RVA: 0x0026A324 File Offset: 0x00268524
		public byte[] GetNodeUnlockDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x060080B4 RID: 32948 RVA: 0x0026A33C File Offset: 0x0026853C
		public int PicWeight
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005356 RID: 21334
		private Table __p;
	}
}
