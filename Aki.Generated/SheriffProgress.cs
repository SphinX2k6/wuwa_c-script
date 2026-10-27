using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A2 RID: 4258
	public struct SheriffProgress : IFlatbufferObject
	{
		// Token: 0x17003583 RID: 13699
		// (get) Token: 0x0600D124 RID: 53540 RVA: 0x0030D595 File Offset: 0x0030B795
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D125 RID: 53541 RVA: 0x0030D5A2 File Offset: 0x0030B7A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D126 RID: 53542 RVA: 0x0030D5AC File Offset: 0x0030B7AC
		public static SheriffProgress GetRootAsSheriffProgress(ByteBuffer _bb)
		{
			return SheriffProgress.GetRootAsSheriffProgress(_bb, default(SheriffProgress));
		}

		// Token: 0x0600D127 RID: 53543 RVA: 0x0030D5C8 File Offset: 0x0030B7C8
		public static SheriffProgress GetRootAsSheriffProgress(ByteBuffer _bb, SheriffProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D128 RID: 53544 RVA: 0x0030D5E5 File Offset: 0x0030B7E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D129 RID: 53545 RVA: 0x0030D5F4 File Offset: 0x0030B7F4
		public SheriffProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003584 RID: 13700
		// (get) Token: 0x0600D12A RID: 53546 RVA: 0x0030D604 File Offset: 0x0030B804
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

		// Token: 0x17003585 RID: 13701
		// (get) Token: 0x0600D12B RID: 53547 RVA: 0x0030D640 File Offset: 0x0030B840
		public int SheriffAnomalyId
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

		// Token: 0x17003586 RID: 13702
		// (get) Token: 0x0600D12C RID: 53548 RVA: 0x0030D67C File Offset: 0x0030B87C
		public int ProgressType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003587 RID: 13703
		// (get) Token: 0x0600D12D RID: 53549 RVA: 0x0030D6B8 File Offset: 0x0030B8B8
		public int GroupId
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

		// Token: 0x17003588 RID: 13704
		// (get) Token: 0x0600D12E RID: 53550 RVA: 0x0030D6F8 File Offset: 0x0030B8F8
		public int GroupPriority
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

		// Token: 0x17003589 RID: 13705
		// (get) Token: 0x0600D12F RID: 53551 RVA: 0x0030D738 File Offset: 0x0030B938
		public string Title
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

		// Token: 0x0600D130 RID: 53552 RVA: 0x0030D770 File Offset: 0x0030B970
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D131 RID: 53553 RVA: 0x0030D780 File Offset: 0x0030B980
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700358A RID: 13706
		// (get) Token: 0x0600D132 RID: 53554 RVA: 0x0030D798 File Offset: 0x0030B998
		public string Context
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

		// Token: 0x0600D133 RID: 53555 RVA: 0x0030D7D0 File Offset: 0x0030B9D0
		public Span<byte> GetContextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D134 RID: 53556 RVA: 0x0030D7E0 File Offset: 0x0030B9E0
		public byte[] GetContextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700358B RID: 13707
		// (get) Token: 0x0600D135 RID: 53557 RVA: 0x0030D7F8 File Offset: 0x0030B9F8
		public int Percent
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040051B0 RID: 20912
		private Table __p;
	}
}
