using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F81 RID: 3969
	public struct NpcHeadInfo : IFlatbufferObject
	{
		// Token: 0x17002441 RID: 9281
		// (get) Token: 0x0600A6F1 RID: 42737 RVA: 0x002BED3A File Offset: 0x002BCF3A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A6F2 RID: 42738 RVA: 0x002BED47 File Offset: 0x002BCF47
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A6F3 RID: 42739 RVA: 0x002BED50 File Offset: 0x002BCF50
		public static NpcHeadInfo GetRootAsNpcHeadInfo(ByteBuffer _bb)
		{
			return NpcHeadInfo.GetRootAsNpcHeadInfo(_bb, default(NpcHeadInfo));
		}

		// Token: 0x0600A6F4 RID: 42740 RVA: 0x002BED6C File Offset: 0x002BCF6C
		public static NpcHeadInfo GetRootAsNpcHeadInfo(ByteBuffer _bb, NpcHeadInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A6F5 RID: 42741 RVA: 0x002BED89 File Offset: 0x002BCF89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A6F6 RID: 42742 RVA: 0x002BED98 File Offset: 0x002BCF98
		public NpcHeadInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002442 RID: 9282
		// (get) Token: 0x0600A6F7 RID: 42743 RVA: 0x002BEDA8 File Offset: 0x002BCFA8
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

		// Token: 0x17002443 RID: 9283
		// (get) Token: 0x0600A6F8 RID: 42744 RVA: 0x002BEDE4 File Offset: 0x002BCFE4
		public string SecondName
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

		// Token: 0x0600A6F9 RID: 42745 RVA: 0x002BEE1B File Offset: 0x002BD01B
		public Span<byte> GetSecondNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A6FA RID: 42746 RVA: 0x002BEE2A File Offset: 0x002BD02A
		public byte[] GetSecondNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002444 RID: 9284
		// (get) Token: 0x0600A6FB RID: 42747 RVA: 0x002BEE44 File Offset: 0x002BD044
		public string FunctionPath
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

		// Token: 0x0600A6FC RID: 42748 RVA: 0x002BEE7B File Offset: 0x002BD07B
		public Span<byte> GetFunctionPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A6FD RID: 42749 RVA: 0x002BEE8A File Offset: 0x002BD08A
		public byte[] GetFunctionPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005535 RID: 21813
		private Table __p;
	}
}
