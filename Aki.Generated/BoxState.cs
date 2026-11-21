using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C2B RID: 3115
	public struct BoxState : IFlatbufferObject
	{
		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x0600552C RID: 21804 RVA: 0x00208410 File Offset: 0x00206610
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600552D RID: 21805 RVA: 0x0020841D File Offset: 0x0020661D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600552E RID: 21806 RVA: 0x00208424 File Offset: 0x00206624
		public static BoxState GetRootAsBoxState(ByteBuffer _bb)
		{
			return BoxState.GetRootAsBoxState(_bb, default(BoxState));
		}

		// Token: 0x0600552F RID: 21807 RVA: 0x00208440 File Offset: 0x00206640
		public static BoxState GetRootAsBoxState(ByteBuffer _bb, BoxState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005530 RID: 21808 RVA: 0x0020845D File Offset: 0x0020665D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005531 RID: 21809 RVA: 0x0020846C File Offset: 0x0020666C
		public BoxState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06005532 RID: 21810 RVA: 0x0020847C File Offset: 0x0020667C
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

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06005533 RID: 21811 RVA: 0x002084B8 File Offset: 0x002066B8
		public int TagId
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

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06005534 RID: 21812 RVA: 0x002084F4 File Offset: 0x002066F4
		public string Name
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

		// Token: 0x06005535 RID: 21813 RVA: 0x0020852B File Offset: 0x0020672B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x0020853A File Offset: 0x0020673A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06005537 RID: 21815 RVA: 0x00208554 File Offset: 0x00206754
		public string Effect
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

		// Token: 0x06005538 RID: 21816 RVA: 0x0020858C File Offset: 0x0020678C
		public Span<byte> GetEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005539 RID: 21817 RVA: 0x0020859C File Offset: 0x0020679C
		public byte[] GetEffectArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600553A RID: 21818 RVA: 0x002085B4 File Offset: 0x002067B4
		public bool IsInteraction
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600553B RID: 21819 RVA: 0x002085F4 File Offset: 0x002067F4
		public float Interval
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x0600553C RID: 21820 RVA: 0x00208638 File Offset: 0x00206838
		public int NextState
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

		// Token: 0x04005126 RID: 20774
		private Table __p;
	}
}
