using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD9 RID: 3033
	public struct AnniversaryEntrance : IFlatbufferObject
	{
		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06004D5F RID: 19807 RVA: 0x001F6088 File Offset: 0x001F4288
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x001F6095 File Offset: 0x001F4295
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004D61 RID: 19809 RVA: 0x001F609C File Offset: 0x001F429C
		public static AnniversaryEntrance GetRootAsAnniversaryEntrance(ByteBuffer _bb)
		{
			return AnniversaryEntrance.GetRootAsAnniversaryEntrance(_bb, default(AnniversaryEntrance));
		}

		// Token: 0x06004D62 RID: 19810 RVA: 0x001F60B8 File Offset: 0x001F42B8
		public static AnniversaryEntrance GetRootAsAnniversaryEntrance(ByteBuffer _bb, AnniversaryEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004D63 RID: 19811 RVA: 0x001F60D5 File Offset: 0x001F42D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004D64 RID: 19812 RVA: 0x001F60E4 File Offset: 0x001F42E4
		public AnniversaryEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06004D65 RID: 19813 RVA: 0x001F60F4 File Offset: 0x001F42F4
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

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06004D66 RID: 19814 RVA: 0x001F6130 File Offset: 0x001F4330
		public int ActivityId
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

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06004D67 RID: 19815 RVA: 0x001F616C File Offset: 0x001F436C
		public string IconPath
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

		// Token: 0x06004D68 RID: 19816 RVA: 0x001F61A3 File Offset: 0x001F43A3
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004D69 RID: 19817 RVA: 0x001F61B2 File Offset: 0x001F43B2
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040050BA RID: 20666
		private Table __p;
	}
}
