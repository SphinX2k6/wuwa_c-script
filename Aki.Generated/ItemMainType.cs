using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E67 RID: 3687
	public struct ItemMainType : IFlatbufferObject
	{
		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x06008CF0 RID: 36080 RVA: 0x002853D8 File Offset: 0x002835D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008CF1 RID: 36081 RVA: 0x002853E5 File Offset: 0x002835E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008CF2 RID: 36082 RVA: 0x002853EC File Offset: 0x002835EC
		public static ItemMainType GetRootAsItemMainType(ByteBuffer _bb)
		{
			return ItemMainType.GetRootAsItemMainType(_bb, default(ItemMainType));
		}

		// Token: 0x06008CF3 RID: 36083 RVA: 0x00285408 File Offset: 0x00283608
		public static ItemMainType GetRootAsItemMainType(ByteBuffer _bb, ItemMainType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008CF4 RID: 36084 RVA: 0x00285425 File Offset: 0x00283625
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008CF5 RID: 36085 RVA: 0x00285434 File Offset: 0x00283634
		public ItemMainType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x06008CF6 RID: 36086 RVA: 0x00285444 File Offset: 0x00283644
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

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x06008CF7 RID: 36087 RVA: 0x00285480 File Offset: 0x00283680
		public bool BShowInRecallInstance
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x06008CF8 RID: 36088 RVA: 0x002854C0 File Offset: 0x002836C0
		public bool BShowInInventoryView
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x06008CF9 RID: 36089 RVA: 0x00285500 File Offset: 0x00283700
		public string Name
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

		// Token: 0x06008CFA RID: 36090 RVA: 0x00285538 File Offset: 0x00283738
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008CFB RID: 36091 RVA: 0x00285548 File Offset: 0x00283748
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x06008CFC RID: 36092 RVA: 0x00285560 File Offset: 0x00283760
		public string Icon
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

		// Token: 0x06008CFD RID: 36093 RVA: 0x00285598 File Offset: 0x00283798
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008CFE RID: 36094 RVA: 0x002855A8 File Offset: 0x002837A8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x06008CFF RID: 36095 RVA: 0x002855C0 File Offset: 0x002837C0
		public string IconFirstAchieve
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

		// Token: 0x06008D00 RID: 36096 RVA: 0x002855F8 File Offset: 0x002837F8
		public Span<byte> GetIconFirstAchieveBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008D01 RID: 36097 RVA: 0x00285608 File Offset: 0x00283808
		public byte[] GetIconFirstAchieveArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x06008D02 RID: 36098 RVA: 0x00285620 File Offset: 0x00283820
		public int PackageId
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

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x06008D03 RID: 36099 RVA: 0x00285660 File Offset: 0x00283860
		public bool BShowDescompose
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x06008D04 RID: 36100 RVA: 0x002856A0 File Offset: 0x002838A0
		public int SequenceId
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

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x06008D05 RID: 36101 RVA: 0x002856E0 File Offset: 0x002838E0
		public int UseWayId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x06008D06 RID: 36102 RVA: 0x00285720 File Offset: 0x00283920
		public int DestroyUseWayId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x06008D07 RID: 36103 RVA: 0x00285760 File Offset: 0x00283960
		public bool BFilterSortVisible
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040053F3 RID: 21491
		private Table __p;
	}
}
