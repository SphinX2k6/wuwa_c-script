using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AEB RID: 2795
	public struct AiBehaviorTree : IFlatbufferObject
	{
		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06004688 RID: 18056 RVA: 0x001D2C49 File Offset: 0x001D0E49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004689 RID: 18057 RVA: 0x001D2C56 File Offset: 0x001D0E56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600468A RID: 18058 RVA: 0x001D2C60 File Offset: 0x001D0E60
		public static AiBehaviorTree GetRootAsAiBehaviorTree(ByteBuffer _bb)
		{
			return AiBehaviorTree.GetRootAsAiBehaviorTree(_bb, default(AiBehaviorTree));
		}

		// Token: 0x0600468B RID: 18059 RVA: 0x001D2C7C File Offset: 0x001D0E7C
		public static AiBehaviorTree GetRootAsAiBehaviorTree(ByteBuffer _bb, AiBehaviorTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600468C RID: 18060 RVA: 0x001D2C99 File Offset: 0x001D0E99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600468D RID: 18061 RVA: 0x001D2CA8 File Offset: 0x001D0EA8
		public AiBehaviorTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600468E RID: 18062 RVA: 0x001D2CB8 File Offset: 0x001D0EB8
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

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600468F RID: 18063 RVA: 0x001D2CF4 File Offset: 0x001D0EF4
		public string Description
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

		// Token: 0x06004690 RID: 18064 RVA: 0x001D2D2B File Offset: 0x001D0F2B
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x001D2D3A File Offset: 0x001D0F3A
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06004692 RID: 18066 RVA: 0x001D2D54 File Offset: 0x001D0F54
		public string BtPath
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

		// Token: 0x06004693 RID: 18067 RVA: 0x001D2D8B File Offset: 0x001D0F8B
		public Span<byte> GetBtPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004694 RID: 18068 RVA: 0x001D2D9A File Offset: 0x001D0F9A
		public byte[] GetBtPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06004695 RID: 18069 RVA: 0x001D2DB4 File Offset: 0x001D0FB4
		public string BtType
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

		// Token: 0x06004696 RID: 18070 RVA: 0x001D2DEC File Offset: 0x001D0FEC
		public Span<byte> GetBtTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x001D2DFC File Offset: 0x001D0FFC
		public byte[] GetBtTypeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004ACC RID: 19148
		private Table __p;
	}
}
