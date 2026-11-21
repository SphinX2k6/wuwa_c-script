using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012E0 RID: 4832
	public struct WuWuLogisticsDesc : IFlatbufferObject
	{
		// Token: 0x170041EF RID: 16879
		// (get) Token: 0x0600F6EA RID: 63210 RVA: 0x00370F51 File Offset: 0x0036F151
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F6EB RID: 63211 RVA: 0x00370F5E File Offset: 0x0036F15E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F6EC RID: 63212 RVA: 0x00370F68 File Offset: 0x0036F168
		public static WuWuLogisticsDesc GetRootAsWuWuLogisticsDesc(ByteBuffer _bb)
		{
			return WuWuLogisticsDesc.GetRootAsWuWuLogisticsDesc(_bb, default(WuWuLogisticsDesc));
		}

		// Token: 0x0600F6ED RID: 63213 RVA: 0x00370F84 File Offset: 0x0036F184
		public static WuWuLogisticsDesc GetRootAsWuWuLogisticsDesc(ByteBuffer _bb, WuWuLogisticsDesc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F6EE RID: 63214 RVA: 0x00370FA1 File Offset: 0x0036F1A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F6EF RID: 63215 RVA: 0x00370FB0 File Offset: 0x0036F1B0
		public WuWuLogisticsDesc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170041F0 RID: 16880
		// (get) Token: 0x0600F6F0 RID: 63216 RVA: 0x00370FC0 File Offset: 0x0036F1C0
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

		// Token: 0x170041F1 RID: 16881
		// (get) Token: 0x0600F6F1 RID: 63217 RVA: 0x00370FFC File Offset: 0x0036F1FC
		public int GroupId
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

		// Token: 0x170041F2 RID: 16882
		// (get) Token: 0x0600F6F2 RID: 63218 RVA: 0x00371038 File Offset: 0x0036F238
		public string Desc
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

		// Token: 0x0600F6F3 RID: 63219 RVA: 0x0037106F File Offset: 0x0036F26F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F6F4 RID: 63220 RVA: 0x0037107E File Offset: 0x0036F27E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170041F3 RID: 16883
		// (get) Token: 0x0600F6F5 RID: 63221 RVA: 0x00371098 File Offset: 0x0036F298
		public int UnlockTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400593A RID: 22842
		private Table __p;
	}
}
