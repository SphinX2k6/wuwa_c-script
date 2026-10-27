using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E63 RID: 3683
	public struct MotorParkourRecord : IFlatbufferObject
	{
		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x06009B6B RID: 39787 RVA: 0x00295C6D File Offset: 0x00293E6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009B6C RID: 39788 RVA: 0x00295C7A File Offset: 0x00293E7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009B6D RID: 39789 RVA: 0x00295C84 File Offset: 0x00293E84
		public static MotorParkourRecord GetRootAsMotorParkourRecord(ByteBuffer _bb)
		{
			return MotorParkourRecord.GetRootAsMotorParkourRecord(_bb, default(MotorParkourRecord));
		}

		// Token: 0x06009B6E RID: 39790 RVA: 0x00295CA0 File Offset: 0x00293EA0
		public static MotorParkourRecord GetRootAsMotorParkourRecord(ByteBuffer _bb, MotorParkourRecord obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009B6F RID: 39791 RVA: 0x00295CBD File Offset: 0x00293EBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009B70 RID: 39792 RVA: 0x00295CCC File Offset: 0x00293ECC
		public MotorParkourRecord __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x06009B71 RID: 39793 RVA: 0x00295CDC File Offset: 0x00293EDC
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

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x06009B72 RID: 39794 RVA: 0x00295D18 File Offset: 0x00293F18
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

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x06009B73 RID: 39795 RVA: 0x00295D54 File Offset: 0x00293F54
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

		// Token: 0x06009B74 RID: 39796 RVA: 0x00295D90 File Offset: 0x00293F90
		public int LapRecord(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x06009B75 RID: 39797 RVA: 0x00295DD0 File Offset: 0x00293FD0
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

		// Token: 0x06009B76 RID: 39798 RVA: 0x00295DFC File Offset: 0x00293FFC
		public Span<int> GetLapRecordBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009B77 RID: 39799 RVA: 0x00295E0C File Offset: 0x0029400C
		public int[] GetLapRecordArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06009B78 RID: 39800 RVA: 0x00295E24 File Offset: 0x00294024
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LapRecordIter()或GetLapRecordBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LapRecord()
		{
			MotorParkourRecord motorParkourRecord = this;
			return motorParkourRecord.GetLapRecordArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009B79 RID: 39801 RVA: 0x00295E48 File Offset: 0x00294048
		[NullableContext(1)]
		public readonly IEnumerable<int> LapRecordIter()
		{
			MotorParkourRecord.<LapRecordIter>d__20 <LapRecordIter>d__ = new MotorParkourRecord.<LapRecordIter>d__20(-2);
			<LapRecordIter>d__.<>3__<>4__this = this;
			return <LapRecordIter>d__;
		}

		// Token: 0x04004F0F RID: 20239
		private Table __p;
	}
}
