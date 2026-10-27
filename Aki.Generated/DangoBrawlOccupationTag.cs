using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC9 RID: 3017
	public struct DangoBrawlOccupationTag : IFlatbufferObject
	{
		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06005E96 RID: 24214 RVA: 0x0020B8BC File Offset: 0x00209ABC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005E97 RID: 24215 RVA: 0x0020B8C9 File Offset: 0x00209AC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005E98 RID: 24216 RVA: 0x0020B8D0 File Offset: 0x00209AD0
		public static DangoBrawlOccupationTag GetRootAsDangoBrawlOccupationTag(ByteBuffer _bb)
		{
			return DangoBrawlOccupationTag.GetRootAsDangoBrawlOccupationTag(_bb, default(DangoBrawlOccupationTag));
		}

		// Token: 0x06005E99 RID: 24217 RVA: 0x0020B8EC File Offset: 0x00209AEC
		public static DangoBrawlOccupationTag GetRootAsDangoBrawlOccupationTag(ByteBuffer _bb, DangoBrawlOccupationTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005E9A RID: 24218 RVA: 0x0020B909 File Offset: 0x00209B09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005E9B RID: 24219 RVA: 0x0020B918 File Offset: 0x00209B18
		public DangoBrawlOccupationTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06005E9C RID: 24220 RVA: 0x0020B928 File Offset: 0x00209B28
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

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06005E9D RID: 24221 RVA: 0x0020B964 File Offset: 0x00209B64
		public string Icon
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

		// Token: 0x06005E9E RID: 24222 RVA: 0x0020B99B File Offset: 0x00209B9B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005E9F RID: 24223 RVA: 0x0020B9AA File Offset: 0x00209BAA
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06005EA0 RID: 24224 RVA: 0x0020B9C4 File Offset: 0x00209BC4
		public string Name
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

		// Token: 0x06005EA1 RID: 24225 RVA: 0x0020B9FB File Offset: 0x00209BFB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005EA2 RID: 24226 RVA: 0x0020BA0A File Offset: 0x00209C0A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06005EA3 RID: 24227 RVA: 0x0020BA24 File Offset: 0x00209C24
		public string BgColor
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

		// Token: 0x06005EA4 RID: 24228 RVA: 0x0020BA5C File Offset: 0x00209C5C
		public Span<byte> GetBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005EA5 RID: 24229 RVA: 0x0020BA6C File Offset: 0x00209C6C
		public byte[] GetBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06005EA6 RID: 24230 RVA: 0x0020BA84 File Offset: 0x00209C84
		public string NameColor
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

		// Token: 0x06005EA7 RID: 24231 RVA: 0x0020BABC File Offset: 0x00209CBC
		public Span<byte> GetNameColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005EA8 RID: 24232 RVA: 0x0020BACC File Offset: 0x00209CCC
		public byte[] GetNameColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004BF3 RID: 19443
		private Table __p;
	}
}
