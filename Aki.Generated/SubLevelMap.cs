using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200122A RID: 4650
	public struct SubLevelMap : IFlatbufferObject
	{
		// Token: 0x17003BD0 RID: 15312
		// (get) Token: 0x0600E6E9 RID: 59113 RVA: 0x0034D1E4 File Offset: 0x0034B3E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E6EA RID: 59114 RVA: 0x0034D1F1 File Offset: 0x0034B3F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E6EB RID: 59115 RVA: 0x0034D1F8 File Offset: 0x0034B3F8
		public static SubLevelMap GetRootAsSubLevelMap(ByteBuffer _bb)
		{
			return SubLevelMap.GetRootAsSubLevelMap(_bb, default(SubLevelMap));
		}

		// Token: 0x0600E6EC RID: 59116 RVA: 0x0034D214 File Offset: 0x0034B414
		public static SubLevelMap GetRootAsSubLevelMap(ByteBuffer _bb, SubLevelMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E6ED RID: 59117 RVA: 0x0034D231 File Offset: 0x0034B431
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E6EE RID: 59118 RVA: 0x0034D240 File Offset: 0x0034B440
		public SubLevelMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BD1 RID: 15313
		// (get) Token: 0x0600E6EF RID: 59119 RVA: 0x0034D250 File Offset: 0x0034B450
		public string MapPath
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

		// Token: 0x0600E6F0 RID: 59120 RVA: 0x0034D287 File Offset: 0x0034B487
		public Span<byte> GetMapPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600E6F1 RID: 59121 RVA: 0x0034D296 File Offset: 0x0034B496
		public byte[] GetMapPathArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x0400586B RID: 22635
		private Table __p;
	}
}
