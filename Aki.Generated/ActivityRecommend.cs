using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA3 RID: 2979
	public struct ActivityRecommend : IFlatbufferObject
	{
		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060048E7 RID: 18663 RVA: 0x001EC764 File Offset: 0x001EA964
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x001EC771 File Offset: 0x001EA971
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060048E9 RID: 18665 RVA: 0x001EC778 File Offset: 0x001EA978
		public static ActivityRecommend GetRootAsActivityRecommend(ByteBuffer _bb)
		{
			return ActivityRecommend.GetRootAsActivityRecommend(_bb, default(ActivityRecommend));
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x001EC794 File Offset: 0x001EA994
		public static ActivityRecommend GetRootAsActivityRecommend(ByteBuffer _bb, ActivityRecommend obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060048EB RID: 18667 RVA: 0x001EC7B1 File Offset: 0x001EA9B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060048EC RID: 18668 RVA: 0x001EC7C0 File Offset: 0x001EA9C0
		public ActivityRecommend __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060048ED RID: 18669 RVA: 0x001EC7D0 File Offset: 0x001EA9D0
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

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060048EE RID: 18670 RVA: 0x001EC80C File Offset: 0x001EAA0C
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

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060048EF RID: 18671 RVA: 0x001EC848 File Offset: 0x001EAA48
		public int ActivityGroup
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

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060048F0 RID: 18672 RVA: 0x001EC884 File Offset: 0x001EAA84
		public int Sort
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

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060048F1 RID: 18673 RVA: 0x001EC8C4 File Offset: 0x001EAAC4
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

		// Token: 0x060048F2 RID: 18674 RVA: 0x001EC8FC File Offset: 0x001EAAFC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x001EC90C File Offset: 0x001EAB0C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060048F4 RID: 18676 RVA: 0x001EC924 File Offset: 0x001EAB24
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

		// Token: 0x060048F5 RID: 18677 RVA: 0x001EC95C File Offset: 0x001EAB5C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060048F6 RID: 18678 RVA: 0x001EC96C File Offset: 0x001EAB6C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060048F7 RID: 18679 RVA: 0x001EC984 File Offset: 0x001EAB84
		public string TagIcon
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

		// Token: 0x060048F8 RID: 18680 RVA: 0x001EC9BC File Offset: 0x001EABBC
		public Span<byte> GetTagIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060048F9 RID: 18681 RVA: 0x001EC9CC File Offset: 0x001EABCC
		public byte[] GetTagIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060048FA RID: 18682 RVA: 0x001EC9E4 File Offset: 0x001EABE4
		public int ShowReward
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060048FB RID: 18683 RVA: 0x001ECA24 File Offset: 0x001EAC24
		public int JumpParam
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

		// Token: 0x04005080 RID: 20608
		private Table __p;
	}
}
