using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA6 RID: 3238
	public struct DangoBrawlItemSubType : IFlatbufferObject
	{
		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x060063E8 RID: 25576 RVA: 0x00229F68 File Offset: 0x00228168
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060063E9 RID: 25577 RVA: 0x00229F75 File Offset: 0x00228175
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060063EA RID: 25578 RVA: 0x00229F7C File Offset: 0x0022817C
		public static DangoBrawlItemSubType GetRootAsDangoBrawlItemSubType(ByteBuffer _bb)
		{
			return DangoBrawlItemSubType.GetRootAsDangoBrawlItemSubType(_bb, default(DangoBrawlItemSubType));
		}

		// Token: 0x060063EB RID: 25579 RVA: 0x00229F98 File Offset: 0x00228198
		public static DangoBrawlItemSubType GetRootAsDangoBrawlItemSubType(ByteBuffer _bb, DangoBrawlItemSubType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060063EC RID: 25580 RVA: 0x00229FB5 File Offset: 0x002281B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060063ED RID: 25581 RVA: 0x00229FC4 File Offset: 0x002281C4
		public DangoBrawlItemSubType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x060063EE RID: 25582 RVA: 0x00229FD4 File Offset: 0x002281D4
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

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x060063EF RID: 25583 RVA: 0x0022A010 File Offset: 0x00228210
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

		// Token: 0x060063F0 RID: 25584 RVA: 0x0022A047 File Offset: 0x00228247
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x0022A056 File Offset: 0x00228256
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x060063F2 RID: 25586 RVA: 0x0022A070 File Offset: 0x00228270
		public string Icon
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

		// Token: 0x060063F3 RID: 25587 RVA: 0x0022A0A7 File Offset: 0x002282A7
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060063F4 RID: 25588 RVA: 0x0022A0B6 File Offset: 0x002282B6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040051CF RID: 20943
		private Table __p;
	}
}
