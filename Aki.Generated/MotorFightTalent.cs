using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F34 RID: 3892
	public struct MotorFightTalent : IFlatbufferObject
	{
		// Token: 0x17002193 RID: 8595
		// (get) Token: 0x06009F85 RID: 40837 RVA: 0x002AEEAA File Offset: 0x002AD0AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009F86 RID: 40838 RVA: 0x002AEEB7 File Offset: 0x002AD0B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009F87 RID: 40839 RVA: 0x002AEEC0 File Offset: 0x002AD0C0
		public static MotorFightTalent GetRootAsMotorFightTalent(ByteBuffer _bb)
		{
			return MotorFightTalent.GetRootAsMotorFightTalent(_bb, default(MotorFightTalent));
		}

		// Token: 0x06009F88 RID: 40840 RVA: 0x002AEEDC File Offset: 0x002AD0DC
		public static MotorFightTalent GetRootAsMotorFightTalent(ByteBuffer _bb, MotorFightTalent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009F89 RID: 40841 RVA: 0x002AEEF9 File Offset: 0x002AD0F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009F8A RID: 40842 RVA: 0x002AEF08 File Offset: 0x002AD108
		public MotorFightTalent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002194 RID: 8596
		// (get) Token: 0x06009F8B RID: 40843 RVA: 0x002AEF18 File Offset: 0x002AD118
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

		// Token: 0x17002195 RID: 8597
		// (get) Token: 0x06009F8C RID: 40844 RVA: 0x002AEF54 File Offset: 0x002AD154
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

		// Token: 0x17002196 RID: 8598
		// (get) Token: 0x06009F8D RID: 40845 RVA: 0x002AEF90 File Offset: 0x002AD190
		public int UnlockCondition
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

		// Token: 0x06009F8E RID: 40846 RVA: 0x002AEFCC File Offset: 0x002AD1CC
		public int PreNode(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002197 RID: 8599
		// (get) Token: 0x06009F8F RID: 40847 RVA: 0x002AF00C File Offset: 0x002AD20C
		public int PreNodeLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009F90 RID: 40848 RVA: 0x002AF038 File Offset: 0x002AD238
		public Span<int> GetPreNodeBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009F91 RID: 40849 RVA: 0x002AF048 File Offset: 0x002AD248
		public int[] GetPreNodeArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002198 RID: 8600
		// (get) Token: 0x06009F92 RID: 40850 RVA: 0x002AF060 File Offset: 0x002AD260
		public int Consume
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

		// Token: 0x17002199 RID: 8601
		// (get) Token: 0x06009F93 RID: 40851 RVA: 0x002AF0A0 File Offset: 0x002AD2A0
		public int Effect
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

		// Token: 0x1700219A RID: 8602
		// (get) Token: 0x06009F94 RID: 40852 RVA: 0x002AF0E0 File Offset: 0x002AD2E0
		public string Name
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

		// Token: 0x06009F95 RID: 40853 RVA: 0x002AF118 File Offset: 0x002AD318
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009F96 RID: 40854 RVA: 0x002AF128 File Offset: 0x002AD328
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700219B RID: 8603
		// (get) Token: 0x06009F97 RID: 40855 RVA: 0x002AF140 File Offset: 0x002AD340
		public string Desc
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

		// Token: 0x06009F98 RID: 40856 RVA: 0x002AF178 File Offset: 0x002AD378
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009F99 RID: 40857 RVA: 0x002AF188 File Offset: 0x002AD388
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06009F9A RID: 40858 RVA: 0x002AF1A0 File Offset: 0x002AD3A0
		public string DescParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700219C RID: 8604
		// (get) Token: 0x06009F9B RID: 40859 RVA: 0x002AF1DC File Offset: 0x002AD3DC
		public int DescParamLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700219D RID: 8605
		// (get) Token: 0x06009F9C RID: 40860 RVA: 0x002AF208 File Offset: 0x002AD408
		public int Column
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

		// Token: 0x1700219E RID: 8606
		// (get) Token: 0x06009F9D RID: 40861 RVA: 0x002AF248 File Offset: 0x002AD448
		public int Row
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

		// Token: 0x1700219F RID: 8607
		// (get) Token: 0x06009F9E RID: 40862 RVA: 0x002AF288 File Offset: 0x002AD488
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009F9F RID: 40863 RVA: 0x002AF2C0 File Offset: 0x002AD4C0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009FA0 RID: 40864 RVA: 0x002AF2D0 File Offset: 0x002AD4D0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x06009FA1 RID: 40865 RVA: 0x002AF2E8 File Offset: 0x002AD4E8
		[NullableContext(1)]
		public string[] DescParam()
		{
			return this.DescParamIter().ToArray<string>();
		}

		// Token: 0x06009FA2 RID: 40866 RVA: 0x002AF2F5 File Offset: 0x002AD4F5
		[NullableContext(1)]
		public IEnumerable<string> DescParamIter()
		{
			MotorFightTalent.<DescParamIter>d__43 <DescParamIter>d__ = new MotorFightTalent.<DescParamIter>d__43(-2);
			<DescParamIter>d__.<>3__<>4__this = this;
			return <DescParamIter>d__;
		}

		// Token: 0x06009FA3 RID: 40867 RVA: 0x002AF30A File Offset: 0x002AD50A
		[NullableContext(1)]
		public int[] PreNode()
		{
			return this.GetPreNodeArray();
		}

		// Token: 0x06009FA4 RID: 40868 RVA: 0x002AF312 File Offset: 0x002AD512
		[NullableContext(1)]
		public IEnumerable<int> PreNodeIter()
		{
			MotorFightTalent.<PreNodeIter>d__45 <PreNodeIter>d__ = new MotorFightTalent.<PreNodeIter>d__45(-2);
			<PreNodeIter>d__.<>3__<>4__this = this;
			return <PreNodeIter>d__;
		}

		// Token: 0x040054DD RID: 21725
		private Table __p;
	}
}
