using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B78 RID: 2936
	public struct CiacconaGalChoice : IFlatbufferObject
	{
		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06005547 RID: 21831 RVA: 0x001F57B1 File Offset: 0x001F39B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005548 RID: 21832 RVA: 0x001F57BE File Offset: 0x001F39BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005549 RID: 21833 RVA: 0x001F57C8 File Offset: 0x001F39C8
		public static CiacconaGalChoice GetRootAsCiacconaGalChoice(ByteBuffer _bb)
		{
			return CiacconaGalChoice.GetRootAsCiacconaGalChoice(_bb, default(CiacconaGalChoice));
		}

		// Token: 0x0600554A RID: 21834 RVA: 0x001F57E4 File Offset: 0x001F39E4
		public static CiacconaGalChoice GetRootAsCiacconaGalChoice(ByteBuffer _bb, CiacconaGalChoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600554B RID: 21835 RVA: 0x001F5801 File Offset: 0x001F3A01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600554C RID: 21836 RVA: 0x001F5810 File Offset: 0x001F3A10
		public CiacconaGalChoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x0600554D RID: 21837 RVA: 0x001F5820 File Offset: 0x001F3A20
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

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x0600554E RID: 21838 RVA: 0x001F585C File Offset: 0x001F3A5C
		public string Content
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

		// Token: 0x0600554F RID: 21839 RVA: 0x001F5893 File Offset: 0x001F3A93
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005550 RID: 21840 RVA: 0x001F58A2 File Offset: 0x001F3AA2
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06005551 RID: 21841 RVA: 0x001F58BC File Offset: 0x001F3ABC
		public int RequiredInspiration
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

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06005552 RID: 21842 RVA: 0x001F58F8 File Offset: 0x001F3AF8
		public int UnlockCondition
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

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06005553 RID: 21843 RVA: 0x001F5938 File Offset: 0x001F3B38
		public int ToStep
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

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06005554 RID: 21844 RVA: 0x001F5978 File Offset: 0x001F3B78
		public int CorrSubEnding
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

		// Token: 0x04004B7C RID: 19324
		private Table __p;
	}
}
