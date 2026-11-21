using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C32 RID: 3122
	public struct BubbleData : IFlatbufferObject
	{
		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060055C8 RID: 21960 RVA: 0x00209A9A File Offset: 0x00207C9A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060055C9 RID: 21961 RVA: 0x00209AA7 File Offset: 0x00207CA7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060055CA RID: 21962 RVA: 0x00209AB0 File Offset: 0x00207CB0
		public static BubbleData GetRootAsBubbleData(ByteBuffer _bb)
		{
			return BubbleData.GetRootAsBubbleData(_bb, default(BubbleData));
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x00209ACC File Offset: 0x00207CCC
		public static BubbleData GetRootAsBubbleData(ByteBuffer _bb, BubbleData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060055CC RID: 21964 RVA: 0x00209AE9 File Offset: 0x00207CE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060055CD RID: 21965 RVA: 0x00209AF8 File Offset: 0x00207CF8
		public BubbleData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060055CE RID: 21966 RVA: 0x00209B08 File Offset: 0x00207D08
		public string ActionGuid
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060055CF RID: 21967 RVA: 0x00209B3F File Offset: 0x00207D3F
		public Span<byte> GetActionGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060055D0 RID: 21968 RVA: 0x00209B4E File Offset: 0x00207D4E
		public byte[] GetActionGuidArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060055D1 RID: 21969 RVA: 0x00209B68 File Offset: 0x00207D68
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

		// Token: 0x060055D2 RID: 21970 RVA: 0x00209B9F File Offset: 0x00207D9F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060055D3 RID: 21971 RVA: 0x00209BAE File Offset: 0x00207DAE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060055D4 RID: 21972 RVA: 0x00209BC8 File Offset: 0x00207DC8
		public bool Async
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060055D5 RID: 21973 RVA: 0x00209C08 File Offset: 0x00207E08
		public string Params
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

		// Token: 0x060055D6 RID: 21974 RVA: 0x00209C40 File Offset: 0x00207E40
		public Span<byte> GetParamsBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060055D7 RID: 21975 RVA: 0x00209C50 File Offset: 0x00207E50
		public byte[] GetParamsArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060055D8 RID: 21976 RVA: 0x00209C68 File Offset: 0x00207E68
		public int ActionId
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

		// Token: 0x0400512F RID: 20783
		private Table __p;
	}
}
