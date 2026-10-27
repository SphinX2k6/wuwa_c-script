using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B98 RID: 2968
	public struct ConnectBlockWhite : IFlatbufferObject
	{
		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x060058F3 RID: 22771 RVA: 0x001FEAF7 File Offset: 0x001FCCF7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060058F4 RID: 22772 RVA: 0x001FEB04 File Offset: 0x001FCD04
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060058F5 RID: 22773 RVA: 0x001FEB0C File Offset: 0x001FCD0C
		public static ConnectBlockWhite GetRootAsConnectBlockWhite(ByteBuffer _bb)
		{
			return ConnectBlockWhite.GetRootAsConnectBlockWhite(_bb, default(ConnectBlockWhite));
		}

		// Token: 0x060058F6 RID: 22774 RVA: 0x001FEB28 File Offset: 0x001FCD28
		public static ConnectBlockWhite GetRootAsConnectBlockWhite(ByteBuffer _bb, ConnectBlockWhite obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x001FEB45 File Offset: 0x001FCD45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060058F8 RID: 22776 RVA: 0x001FEB54 File Offset: 0x001FCD54
		public ConnectBlockWhite __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x060058F9 RID: 22777 RVA: 0x001FEB64 File Offset: 0x001FCD64
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

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x060058FA RID: 22778 RVA: 0x001FEBA0 File Offset: 0x001FCDA0
		public int Type
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

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x060058FB RID: 22779 RVA: 0x001FEBDC File Offset: 0x001FCDDC
		public int ItemId
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

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x060058FC RID: 22780 RVA: 0x001FEC18 File Offset: 0x001FCE18
		public int MapId
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

		// Token: 0x04004BB9 RID: 19385
		private Table __p;
	}
}
