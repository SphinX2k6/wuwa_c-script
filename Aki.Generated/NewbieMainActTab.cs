using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E83 RID: 3715
	public struct NewbieMainActTab : IFlatbufferObject
	{
		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x06009E73 RID: 40563 RVA: 0x0029C371 File Offset: 0x0029A571
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E74 RID: 40564 RVA: 0x0029C37E File Offset: 0x0029A57E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E75 RID: 40565 RVA: 0x0029C388 File Offset: 0x0029A588
		public static NewbieMainActTab GetRootAsNewbieMainActTab(ByteBuffer _bb)
		{
			return NewbieMainActTab.GetRootAsNewbieMainActTab(_bb, default(NewbieMainActTab));
		}

		// Token: 0x06009E76 RID: 40566 RVA: 0x0029C3A4 File Offset: 0x0029A5A4
		public static NewbieMainActTab GetRootAsNewbieMainActTab(ByteBuffer _bb, NewbieMainActTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E77 RID: 40567 RVA: 0x0029C3C1 File Offset: 0x0029A5C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009E78 RID: 40568 RVA: 0x0029C3D0 File Offset: 0x0029A5D0
		public NewbieMainActTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022FF RID: 8959
		// (get) Token: 0x06009E79 RID: 40569 RVA: 0x0029C3E0 File Offset: 0x0029A5E0
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

		// Token: 0x17002300 RID: 8960
		// (get) Token: 0x06009E7A RID: 40570 RVA: 0x0029C41C File Offset: 0x0029A61C
		public int ActivityId
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

		// Token: 0x17002301 RID: 8961
		// (get) Token: 0x06009E7B RID: 40571 RVA: 0x0029C458 File Offset: 0x0029A658
		public string TitleText
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

		// Token: 0x06009E7C RID: 40572 RVA: 0x0029C48F File Offset: 0x0029A68F
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009E7D RID: 40573 RVA: 0x0029C49E File Offset: 0x0029A69E
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002302 RID: 8962
		// (get) Token: 0x06009E7E RID: 40574 RVA: 0x0029C4B8 File Offset: 0x0029A6B8
		public string TitleIcon
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

		// Token: 0x06009E7F RID: 40575 RVA: 0x0029C4F0 File Offset: 0x0029A6F0
		public Span<byte> GetTitleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009E80 RID: 40576 RVA: 0x0029C500 File Offset: 0x0029A700
		public byte[] GetTitleIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002303 RID: 8963
		// (get) Token: 0x06009E81 RID: 40577 RVA: 0x0029C518 File Offset: 0x0029A718
		public string MaleTaskTexture
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

		// Token: 0x06009E82 RID: 40578 RVA: 0x0029C550 File Offset: 0x0029A750
		public Span<byte> GetMaleTaskTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009E83 RID: 40579 RVA: 0x0029C560 File Offset: 0x0029A760
		public byte[] GetMaleTaskTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002304 RID: 8964
		// (get) Token: 0x06009E84 RID: 40580 RVA: 0x0029C578 File Offset: 0x0029A778
		public string FemaleTaskTexture
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

		// Token: 0x06009E85 RID: 40581 RVA: 0x0029C5B0 File Offset: 0x0029A7B0
		public Span<byte> GetFemaleTaskTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009E86 RID: 40582 RVA: 0x0029C5C0 File Offset: 0x0029A7C0
		public byte[] GetFemaleTaskTextureArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x06009E87 RID: 40583 RVA: 0x0029C5D8 File Offset: 0x0029A7D8
		public int DirectTrainActivityId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x06009E88 RID: 40584 RVA: 0x0029C618 File Offset: 0x0029A818
		public bool IsEnd
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x06009E89 RID: 40585 RVA: 0x0029C658 File Offset: 0x0029A858
		public int Type
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004F31 RID: 20273
		private Table __p;
	}
}
