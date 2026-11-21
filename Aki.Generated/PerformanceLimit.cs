using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F9D RID: 3997
	public struct PerformanceLimit : IFlatbufferObject
	{
		// Token: 0x17002553 RID: 9555
		// (get) Token: 0x0600A9D0 RID: 43472 RVA: 0x002C50B1 File Offset: 0x002C32B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A9D1 RID: 43473 RVA: 0x002C50BE File Offset: 0x002C32BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A9D2 RID: 43474 RVA: 0x002C50C8 File Offset: 0x002C32C8
		public static PerformanceLimit GetRootAsPerformanceLimit(ByteBuffer _bb)
		{
			return PerformanceLimit.GetRootAsPerformanceLimit(_bb, default(PerformanceLimit));
		}

		// Token: 0x0600A9D3 RID: 43475 RVA: 0x002C50E4 File Offset: 0x002C32E4
		public static PerformanceLimit GetRootAsPerformanceLimit(ByteBuffer _bb, PerformanceLimit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A9D4 RID: 43476 RVA: 0x002C5101 File Offset: 0x002C3301
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A9D5 RID: 43477 RVA: 0x002C5110 File Offset: 0x002C3310
		public PerformanceLimit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002554 RID: 9556
		// (get) Token: 0x0600A9D6 RID: 43478 RVA: 0x002C5120 File Offset: 0x002C3320
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

		// Token: 0x17002555 RID: 9557
		// (get) Token: 0x0600A9D7 RID: 43479 RVA: 0x002C515C File Offset: 0x002C335C
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

		// Token: 0x0600A9D8 RID: 43480 RVA: 0x002C5193 File Offset: 0x002C3393
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A9D9 RID: 43481 RVA: 0x002C51A2 File Offset: 0x002C33A2
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002556 RID: 9558
		// (get) Token: 0x0600A9DA RID: 43482 RVA: 0x002C51BC File Offset: 0x002C33BC
		public bool FrameLimit
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002557 RID: 9559
		// (get) Token: 0x0600A9DB RID: 43483 RVA: 0x002C51FC File Offset: 0x002C33FC
		public bool CacheWorldFrame
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005553 RID: 21843
		private Table __p;
	}
}
