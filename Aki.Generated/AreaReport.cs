using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B07 RID: 2823
	public struct AreaReport : IFlatbufferObject
	{
		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060048C5 RID: 18629 RVA: 0x001D82D1 File Offset: 0x001D64D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x001D82DE File Offset: 0x001D64DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x001D82E8 File Offset: 0x001D64E8
		public static AreaReport GetRootAsAreaReport(ByteBuffer _bb)
		{
			return AreaReport.GetRootAsAreaReport(_bb, default(AreaReport));
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x001D8304 File Offset: 0x001D6504
		public static AreaReport GetRootAsAreaReport(ByteBuffer _bb, AreaReport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x001D8321 File Offset: 0x001D6521
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x001D8330 File Offset: 0x001D6530
		public AreaReport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060048CB RID: 18635 RVA: 0x001D8340 File Offset: 0x001D6540
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

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060048CC RID: 18636 RVA: 0x001D837C File Offset: 0x001D657C
		public int AreaId
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

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060048CD RID: 18637 RVA: 0x001D83B8 File Offset: 0x001D65B8
		public int Stage
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

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060048CE RID: 18638 RVA: 0x001D83F4 File Offset: 0x001D65F4
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

		// Token: 0x060048CF RID: 18639 RVA: 0x001D842C File Offset: 0x001D662C
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x001D843C File Offset: 0x001D663C
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060048D1 RID: 18641 RVA: 0x001D8454 File Offset: 0x001D6654
		public int Unlock
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060048D2 RID: 18642 RVA: 0x001D8494 File Offset: 0x001D6694
		public string LockText
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x001D84CC File Offset: 0x001D66CC
		public Span<byte> GetLockTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x001D84DC File Offset: 0x001D66DC
		public byte[] GetLockTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060048D5 RID: 18645 RVA: 0x001D84F4 File Offset: 0x001D66F4
		public string PicResource
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x001D852C File Offset: 0x001D672C
		public Span<byte> GetPicResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060048D7 RID: 18647 RVA: 0x001D853C File Offset: 0x001D673C
		public byte[] GetPicResourceArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060048D8 RID: 18648 RVA: 0x001D8554 File Offset: 0x001D6754
		public string StageTitle
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x001D858C File Offset: 0x001D678C
		public Span<byte> GetStageTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060048DA RID: 18650 RVA: 0x001D859C File Offset: 0x001D679C
		public byte[] GetStageTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AEC RID: 19180
		private Table __p;
	}
}
