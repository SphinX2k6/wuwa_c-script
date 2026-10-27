using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001098 RID: 4248
	public struct SettleFlag : IFlatbufferObject
	{
		// Token: 0x1700352F RID: 13615
		// (get) Token: 0x0600D04E RID: 53326 RVA: 0x0030B7B1 File Offset: 0x003099B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D04F RID: 53327 RVA: 0x0030B7BE File Offset: 0x003099BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D050 RID: 53328 RVA: 0x0030B7C8 File Offset: 0x003099C8
		public static SettleFlag GetRootAsSettleFlag(ByteBuffer _bb)
		{
			return SettleFlag.GetRootAsSettleFlag(_bb, default(SettleFlag));
		}

		// Token: 0x0600D051 RID: 53329 RVA: 0x0030B7E4 File Offset: 0x003099E4
		public static SettleFlag GetRootAsSettleFlag(ByteBuffer _bb, SettleFlag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D052 RID: 53330 RVA: 0x0030B801 File Offset: 0x00309A01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D053 RID: 53331 RVA: 0x0030B810 File Offset: 0x00309A10
		public SettleFlag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003530 RID: 13616
		// (get) Token: 0x0600D054 RID: 53332 RVA: 0x0030B820 File Offset: 0x00309A20
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

		// Token: 0x17003531 RID: 13617
		// (get) Token: 0x0600D055 RID: 53333 RVA: 0x0030B85C File Offset: 0x00309A5C
		public int Priority
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

		// Token: 0x17003532 RID: 13618
		// (get) Token: 0x0600D056 RID: 53334 RVA: 0x0030B898 File Offset: 0x00309A98
		public string Title
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

		// Token: 0x0600D057 RID: 53335 RVA: 0x0030B8CF File Offset: 0x00309ACF
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D058 RID: 53336 RVA: 0x0030B8DE File Offset: 0x00309ADE
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003533 RID: 13619
		// (get) Token: 0x0600D059 RID: 53337 RVA: 0x0030B8F8 File Offset: 0x00309AF8
		public string Content
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

		// Token: 0x0600D05A RID: 53338 RVA: 0x0030B930 File Offset: 0x00309B30
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D05B RID: 53339 RVA: 0x0030B940 File Offset: 0x00309B40
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003534 RID: 13620
		// (get) Token: 0x0600D05C RID: 53340 RVA: 0x0030B958 File Offset: 0x00309B58
		public int Args
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040051A5 RID: 20901
		private Table __p;
	}
}
