using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E64 RID: 3684
	public struct ItemHandBookType : IFlatbufferObject
	{
		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x06008C7B RID: 35963 RVA: 0x00284115 File Offset: 0x00282315
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008C7C RID: 35964 RVA: 0x00284122 File Offset: 0x00282322
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008C7D RID: 35965 RVA: 0x0028412C File Offset: 0x0028232C
		public static ItemHandBookType GetRootAsItemHandBookType(ByteBuffer _bb)
		{
			return ItemHandBookType.GetRootAsItemHandBookType(_bb, default(ItemHandBookType));
		}

		// Token: 0x06008C7E RID: 35966 RVA: 0x00284148 File Offset: 0x00282348
		public static ItemHandBookType GetRootAsItemHandBookType(ByteBuffer _bb, ItemHandBookType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008C7F RID: 35967 RVA: 0x00284165 File Offset: 0x00282365
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008C80 RID: 35968 RVA: 0x00284174 File Offset: 0x00282374
		public ItemHandBookType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x06008C81 RID: 35969 RVA: 0x00284184 File Offset: 0x00282384
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

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x06008C82 RID: 35970 RVA: 0x002841C0 File Offset: 0x002823C0
		public string Descrtption
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

		// Token: 0x06008C83 RID: 35971 RVA: 0x002841F7 File Offset: 0x002823F7
		public Span<byte> GetDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008C84 RID: 35972 RVA: 0x00284206 File Offset: 0x00282406
		public byte[] GetDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x06008C85 RID: 35973 RVA: 0x00284220 File Offset: 0x00282420
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

		// Token: 0x06008C86 RID: 35974 RVA: 0x00284257 File Offset: 0x00282457
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008C87 RID: 35975 RVA: 0x00284266 File Offset: 0x00282466
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040053ED RID: 21485
		private Table __p;
	}
}
