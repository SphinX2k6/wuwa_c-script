using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FFD RID: 4093
	public struct RogueResEnd : IFlatbufferObject
	{
		// Token: 0x1700301B RID: 12315
		// (get) Token: 0x0600C1DA RID: 49626 RVA: 0x002EB40C File Offset: 0x002E960C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C1DB RID: 49627 RVA: 0x002EB419 File Offset: 0x002E9619
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C1DC RID: 49628 RVA: 0x002EB420 File Offset: 0x002E9620
		public static RogueResEnd GetRootAsRogueResEnd(ByteBuffer _bb)
		{
			return RogueResEnd.GetRootAsRogueResEnd(_bb, default(RogueResEnd));
		}

		// Token: 0x0600C1DD RID: 49629 RVA: 0x002EB43C File Offset: 0x002E963C
		public static RogueResEnd GetRootAsRogueResEnd(ByteBuffer _bb, RogueResEnd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C1DE RID: 49630 RVA: 0x002EB459 File Offset: 0x002E9659
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C1DF RID: 49631 RVA: 0x002EB468 File Offset: 0x002E9668
		public RogueResEnd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700301C RID: 12316
		// (get) Token: 0x0600C1E0 RID: 49632 RVA: 0x002EB478 File Offset: 0x002E9678
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

		// Token: 0x1700301D RID: 12317
		// (get) Token: 0x0600C1E1 RID: 49633 RVA: 0x002EB4B4 File Offset: 0x002E96B4
		public int SeasonId
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

		// Token: 0x1700301E RID: 12318
		// (get) Token: 0x0600C1E2 RID: 49634 RVA: 0x002EB4F0 File Offset: 0x002E96F0
		public int InstId
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

		// Token: 0x1700301F RID: 12319
		// (get) Token: 0x0600C1E3 RID: 49635 RVA: 0x002EB52C File Offset: 0x002E972C
		public string CGF
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

		// Token: 0x0600C1E4 RID: 49636 RVA: 0x002EB564 File Offset: 0x002E9764
		public Span<byte> GetCGFBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C1E5 RID: 49637 RVA: 0x002EB574 File Offset: 0x002E9774
		public byte[] GetCGFArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003020 RID: 12320
		// (get) Token: 0x0600C1E6 RID: 49638 RVA: 0x002EB58C File Offset: 0x002E978C
		public string CGM
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

		// Token: 0x0600C1E7 RID: 49639 RVA: 0x002EB5C4 File Offset: 0x002E97C4
		public Span<byte> GetCGMBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C1E8 RID: 49640 RVA: 0x002EB5D4 File Offset: 0x002E97D4
		public byte[] GetCGMArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003021 RID: 12321
		// (get) Token: 0x0600C1E9 RID: 49641 RVA: 0x002EB5EC File Offset: 0x002E97EC
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

		// Token: 0x0600C1EA RID: 49642 RVA: 0x002EB624 File Offset: 0x002E9824
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C1EB RID: 49643 RVA: 0x002EB634 File Offset: 0x002E9834
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003022 RID: 12322
		// (get) Token: 0x0600C1EC RID: 49644 RVA: 0x002EB64C File Offset: 0x002E984C
		public string Desc
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

		// Token: 0x0600C1ED RID: 49645 RVA: 0x002EB684 File Offset: 0x002E9884
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C1EE RID: 49646 RVA: 0x002EB694 File Offset: 0x002E9894
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003023 RID: 12323
		// (get) Token: 0x0600C1EF RID: 49647 RVA: 0x002EB6AC File Offset: 0x002E98AC
		public string WinTitle
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

		// Token: 0x0600C1F0 RID: 49648 RVA: 0x002EB6E4 File Offset: 0x002E98E4
		public Span<byte> GetWinTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C1F1 RID: 49649 RVA: 0x002EB6F4 File Offset: 0x002E98F4
		public byte[] GetWinTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003024 RID: 12324
		// (get) Token: 0x0600C1F2 RID: 49650 RVA: 0x002EB70C File Offset: 0x002E990C
		public string WinDesc
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C1F3 RID: 49651 RVA: 0x002EB744 File Offset: 0x002E9944
		public Span<byte> GetWinDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C1F4 RID: 49652 RVA: 0x002EB754 File Offset: 0x002E9954
		public byte[] GetWinDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x040050E5 RID: 20709
		private Table __p;
	}
}
