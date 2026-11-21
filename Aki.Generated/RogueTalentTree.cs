using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200110B RID: 4363
	public struct RogueTalentTree : IFlatbufferObject
	{
		// Token: 0x170031A7 RID: 12711
		// (get) Token: 0x0600CB6B RID: 52075 RVA: 0x0030E700 File Offset: 0x0030C900
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CB6C RID: 52076 RVA: 0x0030E70D File Offset: 0x0030C90D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CB6D RID: 52077 RVA: 0x0030E714 File Offset: 0x0030C914
		public static RogueTalentTree GetRootAsRogueTalentTree(ByteBuffer _bb)
		{
			return RogueTalentTree.GetRootAsRogueTalentTree(_bb, default(RogueTalentTree));
		}

		// Token: 0x0600CB6E RID: 52078 RVA: 0x0030E730 File Offset: 0x0030C930
		public static RogueTalentTree GetRootAsRogueTalentTree(ByteBuffer _bb, RogueTalentTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CB6F RID: 52079 RVA: 0x0030E74D File Offset: 0x0030C94D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CB70 RID: 52080 RVA: 0x0030E75C File Offset: 0x0030C95C
		public RogueTalentTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031A8 RID: 12712
		// (get) Token: 0x0600CB71 RID: 52081 RVA: 0x0030E76C File Offset: 0x0030C96C
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

		// Token: 0x170031A9 RID: 12713
		// (get) Token: 0x0600CB72 RID: 52082 RVA: 0x0030E7A8 File Offset: 0x0030C9A8
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

		// Token: 0x170031AA RID: 12714
		// (get) Token: 0x0600CB73 RID: 52083 RVA: 0x0030E7E4 File Offset: 0x0030C9E4
		public int TalentType
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

		// Token: 0x170031AB RID: 12715
		// (get) Token: 0x0600CB74 RID: 52084 RVA: 0x0030E820 File Offset: 0x0030CA20
		public int Column
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

		// Token: 0x170031AC RID: 12716
		// (get) Token: 0x0600CB75 RID: 52085 RVA: 0x0030E860 File Offset: 0x0030CA60
		public int Row
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

		// Token: 0x0600CB76 RID: 52086 RVA: 0x0030E8A0 File Offset: 0x0030CAA0
		public int PostId(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031AD RID: 12717
		// (get) Token: 0x0600CB77 RID: 52087 RVA: 0x0030E8E0 File Offset: 0x0030CAE0
		public int PostIdLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CB78 RID: 52088 RVA: 0x0030E90C File Offset: 0x0030CB0C
		public Span<int> GetPostIdBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600CB79 RID: 52089 RVA: 0x0030E91C File Offset: 0x0030CB1C
		public int[] GetPostIdArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170031AE RID: 12718
		// (get) Token: 0x0600CB7A RID: 52090 RVA: 0x0030E934 File Offset: 0x0030CB34
		public int Condition
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

		// Token: 0x0600CB7B RID: 52091 RVA: 0x0030E974 File Offset: 0x0030CB74
		public int Consule(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031AF RID: 12719
		// (get) Token: 0x0600CB7C RID: 52092 RVA: 0x0030E9B4 File Offset: 0x0030CBB4
		public int ConsuleLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CB7D RID: 52093 RVA: 0x0030E9E0 File Offset: 0x0030CBE0
		public Span<int> GetConsuleBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600CB7E RID: 52094 RVA: 0x0030E9F0 File Offset: 0x0030CBF0
		public int[] GetConsuleArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x170031B0 RID: 12720
		// (get) Token: 0x0600CB7F RID: 52095 RVA: 0x0030EA08 File Offset: 0x0030CC08
		public int Describe
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

		// Token: 0x0600CB80 RID: 52096 RVA: 0x0030EA45 File Offset: 0x0030CC45
		[NullableContext(1)]
		public int[] Consule()
		{
			return this.GetConsuleArray();
		}

		// Token: 0x0600CB81 RID: 52097 RVA: 0x0030EA4D File Offset: 0x0030CC4D
		[NullableContext(1)]
		public IEnumerable<int> ConsuleIter()
		{
			RogueTalentTree.<ConsuleIter>d__33 <ConsuleIter>d__ = new RogueTalentTree.<ConsuleIter>d__33(-2);
			<ConsuleIter>d__.<>3__<>4__this = this;
			return <ConsuleIter>d__;
		}

		// Token: 0x0600CB82 RID: 52098 RVA: 0x0030EA62 File Offset: 0x0030CC62
		[NullableContext(1)]
		public int[] PostId()
		{
			return this.GetPostIdArray();
		}

		// Token: 0x0600CB83 RID: 52099 RVA: 0x0030EA6A File Offset: 0x0030CC6A
		[NullableContext(1)]
		public IEnumerable<int> PostIdIter()
		{
			RogueTalentTree.<PostIdIter>d__35 <PostIdIter>d__ = new RogueTalentTree.<PostIdIter>d__35(-2);
			<PostIdIter>d__.<>3__<>4__this = this;
			return <PostIdIter>d__;
		}

		// Token: 0x040056FE RID: 22270
		private Table __p;
	}
}
