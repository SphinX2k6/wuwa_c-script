using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F4A RID: 3914
	public struct MotorQuality : IFlatbufferObject
	{
		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x0600A1A7 RID: 41383 RVA: 0x002B3951 File Offset: 0x002B1B51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A1A8 RID: 41384 RVA: 0x002B395E File Offset: 0x002B1B5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A1A9 RID: 41385 RVA: 0x002B3968 File Offset: 0x002B1B68
		public static MotorQuality GetRootAsMotorQuality(ByteBuffer _bb)
		{
			return MotorQuality.GetRootAsMotorQuality(_bb, default(MotorQuality));
		}

		// Token: 0x0600A1AA RID: 41386 RVA: 0x002B3984 File Offset: 0x002B1B84
		public static MotorQuality GetRootAsMotorQuality(ByteBuffer _bb, MotorQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A1AB RID: 41387 RVA: 0x002B39A1 File Offset: 0x002B1BA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A1AC RID: 41388 RVA: 0x002B39B0 File Offset: 0x002B1BB0
		public MotorQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x0600A1AD RID: 41389 RVA: 0x002B39C0 File Offset: 0x002B1BC0
		public int QualityId
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

		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x0600A1AE RID: 41390 RVA: 0x002B39FC File Offset: 0x002B1BFC
		public string Path
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

		// Token: 0x0600A1AF RID: 41391 RVA: 0x002B3A33 File Offset: 0x002B1C33
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A1B0 RID: 41392 RVA: 0x002B3A42 File Offset: 0x002B1C42
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x0600A1B1 RID: 41393 RVA: 0x002B3A5C File Offset: 0x002B1C5C
		public string FramePath
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

		// Token: 0x0600A1B2 RID: 41394 RVA: 0x002B3A93 File Offset: 0x002B1C93
		public Span<byte> GetFramePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A1B3 RID: 41395 RVA: 0x002B3AA2 File Offset: 0x002B1CA2
		public byte[] GetFramePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x0600A1B4 RID: 41396 RVA: 0x002B3ABC File Offset: 0x002B1CBC
		public string FrameShinePath
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

		// Token: 0x0600A1B5 RID: 41397 RVA: 0x002B3AF4 File Offset: 0x002B1CF4
		public Span<byte> GetFrameShinePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A1B6 RID: 41398 RVA: 0x002B3B04 File Offset: 0x002B1D04
		public byte[] GetFrameShinePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040054F6 RID: 21750
		private Table __p;
	}
}
