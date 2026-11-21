using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B9D RID: 2973
	public struct ActivityGamePlayPlot : IFlatbufferObject
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06004887 RID: 18567 RVA: 0x001EB9E9 File Offset: 0x001E9BE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004888 RID: 18568 RVA: 0x001EB9F6 File Offset: 0x001E9BF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004889 RID: 18569 RVA: 0x001EBA00 File Offset: 0x001E9C00
		public static ActivityGamePlayPlot GetRootAsActivityGamePlayPlot(ByteBuffer _bb)
		{
			return ActivityGamePlayPlot.GetRootAsActivityGamePlayPlot(_bb, default(ActivityGamePlayPlot));
		}

		// Token: 0x0600488A RID: 18570 RVA: 0x001EBA1C File Offset: 0x001E9C1C
		public static ActivityGamePlayPlot GetRootAsActivityGamePlayPlot(ByteBuffer _bb, ActivityGamePlayPlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600488B RID: 18571 RVA: 0x001EBA39 File Offset: 0x001E9C39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600488C RID: 18572 RVA: 0x001EBA48 File Offset: 0x001E9C48
		public ActivityGamePlayPlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600488D RID: 18573 RVA: 0x001EBA58 File Offset: 0x001E9C58
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

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600488E RID: 18574 RVA: 0x001EBA94 File Offset: 0x001E9C94
		public string Name
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

		// Token: 0x0600488F RID: 18575 RVA: 0x001EBACB File Offset: 0x001E9CCB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004890 RID: 18576 RVA: 0x001EBADA File Offset: 0x001E9CDA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06004891 RID: 18577 RVA: 0x001EBAF4 File Offset: 0x001E9CF4
		public string Icon
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

		// Token: 0x06004892 RID: 18578 RVA: 0x001EBB2B File Offset: 0x001E9D2B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004893 RID: 18579 RVA: 0x001EBB3A File Offset: 0x001E9D3A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06004894 RID: 18580 RVA: 0x001EBB54 File Offset: 0x001E9D54
		public int HelpId
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

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06004895 RID: 18581 RVA: 0x001EBB94 File Offset: 0x001E9D94
		public bool NeedClose
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005079 RID: 20601
		private Table __p;
	}
}
