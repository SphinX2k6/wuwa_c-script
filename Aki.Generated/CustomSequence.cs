using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BAE RID: 2990
	public struct CustomSequence : IFlatbufferObject
	{
		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06005AAE RID: 23214 RVA: 0x00202859 File Offset: 0x00200A59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005AAF RID: 23215 RVA: 0x00202866 File Offset: 0x00200A66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005AB0 RID: 23216 RVA: 0x00202870 File Offset: 0x00200A70
		public static CustomSequence GetRootAsCustomSequence(ByteBuffer _bb)
		{
			return CustomSequence.GetRootAsCustomSequence(_bb, default(CustomSequence));
		}

		// Token: 0x06005AB1 RID: 23217 RVA: 0x0020288C File Offset: 0x00200A8C
		public static CustomSequence GetRootAsCustomSequence(ByteBuffer _bb, CustomSequence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005AB2 RID: 23218 RVA: 0x002028A9 File Offset: 0x00200AA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005AB3 RID: 23219 RVA: 0x002028B8 File Offset: 0x00200AB8
		public CustomSequence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06005AB4 RID: 23220 RVA: 0x002028C8 File Offset: 0x00200AC8
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

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06005AB5 RID: 23221 RVA: 0x00202904 File Offset: 0x00200B04
		public int Name
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

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06005AB6 RID: 23222 RVA: 0x00202940 File Offset: 0x00200B40
		public string SeqDataPath
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

		// Token: 0x06005AB7 RID: 23223 RVA: 0x00202977 File Offset: 0x00200B77
		public Span<byte> GetSeqDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005AB8 RID: 23224 RVA: 0x00202986 File Offset: 0x00200B86
		public byte[] GetSeqDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06005AB9 RID: 23225 RVA: 0x002029A0 File Offset: 0x00200BA0
		public string BinderType
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

		// Token: 0x06005ABA RID: 23226 RVA: 0x002029D8 File Offset: 0x00200BD8
		public Span<byte> GetBinderTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x002029E8 File Offset: 0x00200BE8
		public byte[] GetBinderTypeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004BD1 RID: 19409
		private Table __p;
	}
}
