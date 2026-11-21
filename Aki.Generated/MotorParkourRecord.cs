using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F48 RID: 3912
	public struct MotorParkourRecord : IFlatbufferObject
	{
		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x0600A18B RID: 41355 RVA: 0x002B35B9 File Offset: 0x002B17B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A18C RID: 41356 RVA: 0x002B35C6 File Offset: 0x002B17C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A18D RID: 41357 RVA: 0x002B35D0 File Offset: 0x002B17D0
		public static MotorParkourRecord GetRootAsMotorParkourRecord(ByteBuffer _bb)
		{
			return MotorParkourRecord.GetRootAsMotorParkourRecord(_bb, default(MotorParkourRecord));
		}

		// Token: 0x0600A18E RID: 41358 RVA: 0x002B35EC File Offset: 0x002B17EC
		public static MotorParkourRecord GetRootAsMotorParkourRecord(ByteBuffer _bb, MotorParkourRecord obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A18F RID: 41359 RVA: 0x002B3609 File Offset: 0x002B1809
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A190 RID: 41360 RVA: 0x002B3618 File Offset: 0x002B1818
		public MotorParkourRecord __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x0600A191 RID: 41361 RVA: 0x002B3628 File Offset: 0x002B1828
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

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x0600A192 RID: 41362 RVA: 0x002B3664 File Offset: 0x002B1864
		public int NPCId
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

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x0600A193 RID: 41363 RVA: 0x002B36A0 File Offset: 0x002B18A0
		public int Record
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A194 RID: 41364 RVA: 0x002B36DC File Offset: 0x002B18DC
		public int LapRecord(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x0600A195 RID: 41365 RVA: 0x002B371C File Offset: 0x002B191C
		public int LapRecordLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A196 RID: 41366 RVA: 0x002B3748 File Offset: 0x002B1948
		public Span<int> GetLapRecordBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600A197 RID: 41367 RVA: 0x002B3758 File Offset: 0x002B1958
		public int[] GetLapRecordArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600A198 RID: 41368 RVA: 0x002B3770 File Offset: 0x002B1970
		[NullableContext(1)]
		public int[] LapRecord()
		{
			return this.GetLapRecordArray();
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x002B3778 File Offset: 0x002B1978
		[NullableContext(1)]
		public IEnumerable<int> LapRecordIter()
		{
			MotorParkourRecord.<LapRecordIter>d__20 <LapRecordIter>d__ = new MotorParkourRecord.<LapRecordIter>d__20(-2);
			<LapRecordIter>d__.<>3__<>4__this = this;
			return <LapRecordIter>d__;
		}

		// Token: 0x040054F4 RID: 21748
		private Table __p;
	}
}
