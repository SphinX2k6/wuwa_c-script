using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DAD RID: 3501
	public struct FoleySynthBoneConfig : IFlatbufferObject
	{
		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x06007C25 RID: 31781 RVA: 0x00260285 File Offset: 0x0025E485
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007C26 RID: 31782 RVA: 0x00260292 File Offset: 0x0025E492
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007C27 RID: 31783 RVA: 0x0026029C File Offset: 0x0025E49C
		public static FoleySynthBoneConfig GetRootAsFoleySynthBoneConfig(ByteBuffer _bb)
		{
			return FoleySynthBoneConfig.GetRootAsFoleySynthBoneConfig(_bb, default(FoleySynthBoneConfig));
		}

		// Token: 0x06007C28 RID: 31784 RVA: 0x002602B8 File Offset: 0x0025E4B8
		public static FoleySynthBoneConfig GetRootAsFoleySynthBoneConfig(ByteBuffer _bb, FoleySynthBoneConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007C29 RID: 31785 RVA: 0x002602D5 File Offset: 0x0025E4D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007C2A RID: 31786 RVA: 0x002602E4 File Offset: 0x0025E4E4
		public FoleySynthBoneConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x06007C2B RID: 31787 RVA: 0x002602F4 File Offset: 0x0025E4F4
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

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x06007C2C RID: 31788 RVA: 0x00260330 File Offset: 0x0025E530
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

		// Token: 0x06007C2D RID: 31789 RVA: 0x00260367 File Offset: 0x0025E567
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007C2E RID: 31790 RVA: 0x00260376 File Offset: 0x0025E576
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x06007C2F RID: 31791 RVA: 0x00260390 File Offset: 0x0025E590
		public string BoneName
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

		// Token: 0x06007C30 RID: 31792 RVA: 0x002603C7 File Offset: 0x0025E5C7
		public Span<byte> GetBoneNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007C31 RID: 31793 RVA: 0x002603D6 File Offset: 0x0025E5D6
		public byte[] GetBoneNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x06007C32 RID: 31794 RVA: 0x002603F0 File Offset: 0x0025E5F0
		public float Model1Ceil
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x06007C33 RID: 31795 RVA: 0x00260434 File Offset: 0x0025E634
		public string Model1CeilEventPath
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

		// Token: 0x06007C34 RID: 31796 RVA: 0x0026046C File Offset: 0x0025E66C
		public Span<byte> GetModel1CeilEventPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007C35 RID: 31797 RVA: 0x0026047C File Offset: 0x0025E67C
		public byte[] GetModel1CeilEventPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x06007C36 RID: 31798 RVA: 0x00260494 File Offset: 0x0025E694
		public float Model1Floor
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

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x06007C37 RID: 31799 RVA: 0x002604D8 File Offset: 0x0025E6D8
		public string Model1FloorEventPath
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

		// Token: 0x06007C38 RID: 31800 RVA: 0x00260510 File Offset: 0x0025E710
		public Span<byte> GetModel1FloorEventPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007C39 RID: 31801 RVA: 0x00260520 File Offset: 0x0025E720
		public byte[] GetModel1FloorEventPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x06007C3A RID: 31802 RVA: 0x00260538 File Offset: 0x0025E738
		public float Model1CeilInterpolation
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x06007C3B RID: 31803 RVA: 0x0026057C File Offset: 0x0025E77C
		public float Model1FloorInterpolation
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x06007C3C RID: 31804 RVA: 0x002605C0 File Offset: 0x0025E7C0
		public string Model1RtpcPath
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007C3D RID: 31805 RVA: 0x002605F8 File Offset: 0x0025E7F8
		public Span<byte> GetModel1RtpcPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007C3E RID: 31806 RVA: 0x00260608 File Offset: 0x0025E808
		public byte[] GetModel1RtpcPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x06007C3F RID: 31807 RVA: 0x00260620 File Offset: 0x0025E820
		public float Model2Ceil
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x06007C40 RID: 31808 RVA: 0x00260664 File Offset: 0x0025E864
		public string Model2CeilEventPath
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

		// Token: 0x06007C41 RID: 31809 RVA: 0x0026069C File Offset: 0x0025E89C
		public Span<byte> GetModel2CeilEventPathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06007C42 RID: 31810 RVA: 0x002606AC File Offset: 0x0025E8AC
		public byte[] GetModel2CeilEventPathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x06007C43 RID: 31811 RVA: 0x002606C4 File Offset: 0x0025E8C4
		public float Model2Floor
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x06007C44 RID: 31812 RVA: 0x00260708 File Offset: 0x0025E908
		public string Model2FloorPath
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007C45 RID: 31813 RVA: 0x00260740 File Offset: 0x0025E940
		public Span<byte> GetModel2FloorPathBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06007C46 RID: 31814 RVA: 0x00260750 File Offset: 0x0025E950
		public byte[] GetModel2FloorPathArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x06007C47 RID: 31815 RVA: 0x00260768 File Offset: 0x0025E968
		public float Model2FloorPrecent
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x06007C48 RID: 31816 RVA: 0x002607AC File Offset: 0x0025E9AC
		public string Model2RptcVelocityMax
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007C49 RID: 31817 RVA: 0x002607E4 File Offset: 0x0025E9E4
		public Span<byte> GetModel2RptcVelocityMaxBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06007C4A RID: 31818 RVA: 0x002607F4 File Offset: 0x0025E9F4
		public byte[] GetModel2RptcVelocityMaxArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x06007C4B RID: 31819 RVA: 0x0026080C File Offset: 0x0025EA0C
		public string Model2RptcAccelerationMax
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007C4C RID: 31820 RVA: 0x00260844 File Offset: 0x0025EA44
		public Span<byte> GetModel2RptcAccelerationMaxBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06007C4D RID: 31821 RVA: 0x00260854 File Offset: 0x0025EA54
		public byte[] GetModel2RptcAccelerationMaxArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x06007C4E RID: 31822 RVA: 0x0026086C File Offset: 0x0025EA6C
		public string Model2RptcVelocityDuring
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007C4F RID: 31823 RVA: 0x002608A4 File Offset: 0x0025EAA4
		public Span<byte> GetModel2RptcVelocityDuringBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06007C50 RID: 31824 RVA: 0x002608B4 File Offset: 0x0025EAB4
		public byte[] GetModel2RptcVelocityDuringArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x06007C51 RID: 31825 RVA: 0x002608CC File Offset: 0x0025EACC
		public float Model2CeilInterpolation
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x06007C52 RID: 31826 RVA: 0x00260910 File Offset: 0x0025EB10
		public float Model2FloorInterpolation
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400531D RID: 21277
		private Table __p;
	}
}
