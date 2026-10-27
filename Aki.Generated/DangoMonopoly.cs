using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD6 RID: 3030
	public struct DangoMonopoly : IFlatbufferObject
	{
		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x0600604E RID: 24654 RVA: 0x0020F460 File Offset: 0x0020D660
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600604F RID: 24655 RVA: 0x0020F46D File Offset: 0x0020D66D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006050 RID: 24656 RVA: 0x0020F474 File Offset: 0x0020D674
		public static DangoMonopoly GetRootAsDangoMonopoly(ByteBuffer _bb)
		{
			return DangoMonopoly.GetRootAsDangoMonopoly(_bb, default(DangoMonopoly));
		}

		// Token: 0x06006051 RID: 24657 RVA: 0x0020F490 File Offset: 0x0020D690
		public static DangoMonopoly GetRootAsDangoMonopoly(ByteBuffer _bb, DangoMonopoly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006052 RID: 24658 RVA: 0x0020F4AD File Offset: 0x0020D6AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006053 RID: 24659 RVA: 0x0020F4BC File Offset: 0x0020D6BC
		public DangoMonopoly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06006054 RID: 24660 RVA: 0x0020F4CC File Offset: 0x0020D6CC
		public int ActivityId
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

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06006055 RID: 24661 RVA: 0x0020F508 File Offset: 0x0020D708
		public int BoardGroupId
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

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06006056 RID: 24662 RVA: 0x0020F544 File Offset: 0x0020D744
		public int TaskGroupId
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

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06006057 RID: 24663 RVA: 0x0020F580 File Offset: 0x0020D780
		public int InstId
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

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06006058 RID: 24664 RVA: 0x0020F5C0 File Offset: 0x0020D7C0
		public int MaleDangoId
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

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06006059 RID: 24665 RVA: 0x0020F600 File Offset: 0x0020D800
		public int FeMaleDangoId
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

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x0600605A RID: 24666 RVA: 0x0020F640 File Offset: 0x0020D840
		public int DiceId
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

		// Token: 0x04004C03 RID: 19459
		private Table __p;
	}
}
