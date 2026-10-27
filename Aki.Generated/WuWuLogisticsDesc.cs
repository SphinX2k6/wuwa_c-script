using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011AA RID: 4522
	public struct WuWuLogisticsDesc : IFlatbufferObject
	{
		// Token: 0x17003E8A RID: 16010
		// (get) Token: 0x0600E979 RID: 59769 RVA: 0x003462C5 File Offset: 0x003444C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E97A RID: 59770 RVA: 0x003462D2 File Offset: 0x003444D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E97B RID: 59771 RVA: 0x003462DC File Offset: 0x003444DC
		public static WuWuLogisticsDesc GetRootAsWuWuLogisticsDesc(ByteBuffer _bb)
		{
			return WuWuLogisticsDesc.GetRootAsWuWuLogisticsDesc(_bb, default(WuWuLogisticsDesc));
		}

		// Token: 0x0600E97C RID: 59772 RVA: 0x003462F8 File Offset: 0x003444F8
		public static WuWuLogisticsDesc GetRootAsWuWuLogisticsDesc(ByteBuffer _bb, WuWuLogisticsDesc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E97D RID: 59773 RVA: 0x00346315 File Offset: 0x00344515
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E97E RID: 59774 RVA: 0x00346324 File Offset: 0x00344524
		public WuWuLogisticsDesc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E8B RID: 16011
		// (get) Token: 0x0600E97F RID: 59775 RVA: 0x00346334 File Offset: 0x00344534
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

		// Token: 0x17003E8C RID: 16012
		// (get) Token: 0x0600E980 RID: 59776 RVA: 0x00346370 File Offset: 0x00344570
		public int GroupId
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

		// Token: 0x17003E8D RID: 16013
		// (get) Token: 0x0600E981 RID: 59777 RVA: 0x003463AC File Offset: 0x003445AC
		public string Desc
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

		// Token: 0x0600E982 RID: 59778 RVA: 0x003463E3 File Offset: 0x003445E3
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E983 RID: 59779 RVA: 0x003463F2 File Offset: 0x003445F2
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E8E RID: 16014
		// (get) Token: 0x0600E984 RID: 59780 RVA: 0x0034640C File Offset: 0x0034460C
		public int UnlockTime
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

		// Token: 0x040052F7 RID: 21239
		private Table __p;
	}
}
