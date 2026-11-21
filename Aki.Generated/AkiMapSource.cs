using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD4 RID: 3028
	public struct AkiMapSource : IFlatbufferObject
	{
		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06004CE7 RID: 19687 RVA: 0x001F51F3 File Offset: 0x001F33F3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004CE8 RID: 19688 RVA: 0x001F5200 File Offset: 0x001F3400
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004CE9 RID: 19689 RVA: 0x001F5208 File Offset: 0x001F3408
		public static AkiMapSource GetRootAsAkiMapSource(ByteBuffer _bb)
		{
			return AkiMapSource.GetRootAsAkiMapSource(_bb, default(AkiMapSource));
		}

		// Token: 0x06004CEA RID: 19690 RVA: 0x001F5224 File Offset: 0x001F3424
		public static AkiMapSource GetRootAsAkiMapSource(ByteBuffer _bb, AkiMapSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004CEB RID: 19691 RVA: 0x001F5241 File Offset: 0x001F3441
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004CEC RID: 19692 RVA: 0x001F5250 File Offset: 0x001F3450
		public AkiMapSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06004CED RID: 19693 RVA: 0x001F5260 File Offset: 0x001F3460
		public int MapId
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

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06004CEE RID: 19694 RVA: 0x001F529C File Offset: 0x001F349C
		public int PakRule
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

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06004CEF RID: 19695 RVA: 0x001F52D8 File Offset: 0x001F34D8
		public string MapPath
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

		// Token: 0x06004CF0 RID: 19696 RVA: 0x001F530F File Offset: 0x001F350F
		public Span<byte> GetMapPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004CF1 RID: 19697 RVA: 0x001F531E File Offset: 0x001F351E
		public byte[] GetMapPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06004CF2 RID: 19698 RVA: 0x001F5338 File Offset: 0x001F3538
		public int LoadMapMode
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

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06004CF3 RID: 19699 RVA: 0x001F5378 File Offset: 0x001F3578
		public int IgnoreWorldOrigin
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040050B5 RID: 20661
		private Table __p;
	}
}
