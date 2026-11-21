using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C73 RID: 3187
	public struct Communicate : IFlatbufferObject
	{
		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06005D91 RID: 23953 RVA: 0x0021B341 File Offset: 0x00219541
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005D92 RID: 23954 RVA: 0x0021B34E File Offset: 0x0021954E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005D93 RID: 23955 RVA: 0x0021B358 File Offset: 0x00219558
		public static Communicate GetRootAsCommunicate(ByteBuffer _bb)
		{
			return Communicate.GetRootAsCommunicate(_bb, default(Communicate));
		}

		// Token: 0x06005D94 RID: 23956 RVA: 0x0021B374 File Offset: 0x00219574
		public static Communicate GetRootAsCommunicate(ByteBuffer _bb, Communicate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005D95 RID: 23957 RVA: 0x0021B391 File Offset: 0x00219591
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005D96 RID: 23958 RVA: 0x0021B3A0 File Offset: 0x002195A0
		public Communicate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06005D97 RID: 23959 RVA: 0x0021B3B0 File Offset: 0x002195B0
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

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06005D98 RID: 23960 RVA: 0x0021B3EC File Offset: 0x002195EC
		public string DescText
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

		// Token: 0x06005D99 RID: 23961 RVA: 0x0021B423 File Offset: 0x00219623
		public Span<byte> GetDescTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005D9A RID: 23962 RVA: 0x0021B432 File Offset: 0x00219632
		public byte[] GetDescTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06005D9B RID: 23963 RVA: 0x0021B44C File Offset: 0x0021964C
		public int Talker
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

		// Token: 0x04005182 RID: 20866
		private Table __p;
	}
}
