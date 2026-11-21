using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001095 RID: 4245
	public struct RegressEntry : IFlatbufferObject
	{
		// Token: 0x17002E1D RID: 11805
		// (get) Token: 0x0600C131 RID: 49457 RVA: 0x002F8461 File Offset: 0x002F6661
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C132 RID: 49458 RVA: 0x002F846E File Offset: 0x002F666E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C133 RID: 49459 RVA: 0x002F8478 File Offset: 0x002F6678
		public static RegressEntry GetRootAsRegressEntry(ByteBuffer _bb)
		{
			return RegressEntry.GetRootAsRegressEntry(_bb, default(RegressEntry));
		}

		// Token: 0x0600C134 RID: 49460 RVA: 0x002F8494 File Offset: 0x002F6694
		public static RegressEntry GetRootAsRegressEntry(ByteBuffer _bb, RegressEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C135 RID: 49461 RVA: 0x002F84B1 File Offset: 0x002F66B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C136 RID: 49462 RVA: 0x002F84C0 File Offset: 0x002F66C0
		public RegressEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E1E RID: 11806
		// (get) Token: 0x0600C137 RID: 49463 RVA: 0x002F84D0 File Offset: 0x002F66D0
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

		// Token: 0x17002E1F RID: 11807
		// (get) Token: 0x0600C138 RID: 49464 RVA: 0x002F850C File Offset: 0x002F670C
		public int EntryType
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

		// Token: 0x17002E20 RID: 11808
		// (get) Token: 0x0600C139 RID: 49465 RVA: 0x002F8548 File Offset: 0x002F6748
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

		// Token: 0x0600C13A RID: 49466 RVA: 0x002F857F File Offset: 0x002F677F
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C13B RID: 49467 RVA: 0x002F858E File Offset: 0x002F678E
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E21 RID: 11809
		// (get) Token: 0x0600C13C RID: 49468 RVA: 0x002F85A8 File Offset: 0x002F67A8
		public string IconPathF
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

		// Token: 0x0600C13D RID: 49469 RVA: 0x002F85E0 File Offset: 0x002F67E0
		public Span<byte> GetIconPathFBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C13E RID: 49470 RVA: 0x002F85F0 File Offset: 0x002F67F0
		public byte[] GetIconPathFArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E22 RID: 11810
		// (get) Token: 0x0600C13F RID: 49471 RVA: 0x002F8608 File Offset: 0x002F6808
		public string IconPath
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C140 RID: 49472 RVA: 0x002F8640 File Offset: 0x002F6840
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C141 RID: 49473 RVA: 0x002F8650 File Offset: 0x002F6850
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E23 RID: 11811
		// (get) Token: 0x0600C142 RID: 49474 RVA: 0x002F8668 File Offset: 0x002F6868
		public int GachaId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E24 RID: 11812
		// (get) Token: 0x0600C143 RID: 49475 RVA: 0x002F86A8 File Offset: 0x002F68A8
		public int Grade
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400566E RID: 22126
		private Table __p;
	}
}
