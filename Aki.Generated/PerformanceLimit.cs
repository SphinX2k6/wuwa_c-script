using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB8 RID: 3768
	public struct PerformanceLimit : IFlatbufferObject
	{
		// Token: 0x170024ED RID: 9453
		// (get) Token: 0x0600A3AF RID: 41903 RVA: 0x002A7D71 File Offset: 0x002A5F71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A3B0 RID: 41904 RVA: 0x002A7D7E File Offset: 0x002A5F7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A3B1 RID: 41905 RVA: 0x002A7D88 File Offset: 0x002A5F88
		public static PerformanceLimit GetRootAsPerformanceLimit(ByteBuffer _bb)
		{
			return PerformanceLimit.GetRootAsPerformanceLimit(_bb, default(PerformanceLimit));
		}

		// Token: 0x0600A3B2 RID: 41906 RVA: 0x002A7DA4 File Offset: 0x002A5FA4
		public static PerformanceLimit GetRootAsPerformanceLimit(ByteBuffer _bb, PerformanceLimit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A3B3 RID: 41907 RVA: 0x002A7DC1 File Offset: 0x002A5FC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A3B4 RID: 41908 RVA: 0x002A7DD0 File Offset: 0x002A5FD0
		public PerformanceLimit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024EE RID: 9454
		// (get) Token: 0x0600A3B5 RID: 41909 RVA: 0x002A7DE0 File Offset: 0x002A5FE0
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

		// Token: 0x170024EF RID: 9455
		// (get) Token: 0x0600A3B6 RID: 41910 RVA: 0x002A7E1C File Offset: 0x002A601C
		public string ViewName
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

		// Token: 0x0600A3B7 RID: 41911 RVA: 0x002A7E53 File Offset: 0x002A6053
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A3B8 RID: 41912 RVA: 0x002A7E62 File Offset: 0x002A6062
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170024F0 RID: 9456
		// (get) Token: 0x0600A3B9 RID: 41913 RVA: 0x002A7E7C File Offset: 0x002A607C
		public bool FrameLimit
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170024F1 RID: 9457
		// (get) Token: 0x0600A3BA RID: 41914 RVA: 0x002A7EBC File Offset: 0x002A60BC
		public bool CacheWorldFrame
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004F6E RID: 20334
		private Table __p;
	}
}
