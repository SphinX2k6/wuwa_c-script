using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001186 RID: 4486
	public struct RoverRogueTalentTree : IFlatbufferObject
	{
		// Token: 0x170035E8 RID: 13800
		// (get) Token: 0x0600D740 RID: 55104 RVA: 0x00329084 File Offset: 0x00327284
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D741 RID: 55105 RVA: 0x00329091 File Offset: 0x00327291
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D742 RID: 55106 RVA: 0x00329098 File Offset: 0x00327298
		public static RoverRogueTalentTree GetRootAsRoverRogueTalentTree(ByteBuffer _bb)
		{
			return RoverRogueTalentTree.GetRootAsRoverRogueTalentTree(_bb, default(RoverRogueTalentTree));
		}

		// Token: 0x0600D743 RID: 55107 RVA: 0x003290B4 File Offset: 0x003272B4
		public static RoverRogueTalentTree GetRootAsRoverRogueTalentTree(ByteBuffer _bb, RoverRogueTalentTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D744 RID: 55108 RVA: 0x003290D1 File Offset: 0x003272D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D745 RID: 55109 RVA: 0x003290E0 File Offset: 0x003272E0
		public RoverRogueTalentTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035E9 RID: 13801
		// (get) Token: 0x0600D746 RID: 55110 RVA: 0x003290F0 File Offset: 0x003272F0
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

		// Token: 0x170035EA RID: 13802
		// (get) Token: 0x0600D747 RID: 55111 RVA: 0x0032912C File Offset: 0x0032732C
		public int Row
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

		// Token: 0x170035EB RID: 13803
		// (get) Token: 0x0600D748 RID: 55112 RVA: 0x00329168 File Offset: 0x00327368
		public int Column
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

		// Token: 0x170035EC RID: 13804
		// (get) Token: 0x0600D749 RID: 55113 RVA: 0x003291A4 File Offset: 0x003273A4
		public int Type
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

		// Token: 0x0600D74A RID: 55114 RVA: 0x003291E4 File Offset: 0x003273E4
		public int PostId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170035ED RID: 13805
		// (get) Token: 0x0600D74B RID: 55115 RVA: 0x00329224 File Offset: 0x00327424
		public int PostIdLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D74C RID: 55116 RVA: 0x00329250 File Offset: 0x00327450
		public Span<int> GetPostIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600D74D RID: 55117 RVA: 0x00329260 File Offset: 0x00327460
		public int[] GetPostIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170035EE RID: 13806
		// (get) Token: 0x0600D74E RID: 55118 RVA: 0x00329278 File Offset: 0x00327478
		public int Consule
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

		// Token: 0x170035EF RID: 13807
		// (get) Token: 0x0600D74F RID: 55119 RVA: 0x003292B8 File Offset: 0x003274B8
		public int EffectTrigger
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

		// Token: 0x170035F0 RID: 13808
		// (get) Token: 0x0600D750 RID: 55120 RVA: 0x003292F8 File Offset: 0x003274F8
		public int NextLevelTalentId
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

		// Token: 0x170035F1 RID: 13809
		// (get) Token: 0x0600D751 RID: 55121 RVA: 0x00329338 File Offset: 0x00327538
		public string Name
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D752 RID: 55122 RVA: 0x00329370 File Offset: 0x00327570
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D753 RID: 55123 RVA: 0x00329380 File Offset: 0x00327580
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170035F2 RID: 13810
		// (get) Token: 0x0600D754 RID: 55124 RVA: 0x00329398 File Offset: 0x00327598
		public string Desc
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

		// Token: 0x0600D755 RID: 55125 RVA: 0x003293D0 File Offset: 0x003275D0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D756 RID: 55126 RVA: 0x003293E0 File Offset: 0x003275E0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D757 RID: 55127 RVA: 0x003293F8 File Offset: 0x003275F8
		public string Params(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170035F3 RID: 13811
		// (get) Token: 0x0600D758 RID: 55128 RVA: 0x00329434 File Offset: 0x00327634
		public int ParamsLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170035F4 RID: 13812
		// (get) Token: 0x0600D759 RID: 55129 RVA: 0x00329460 File Offset: 0x00327660
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

		// Token: 0x0600D75A RID: 55130 RVA: 0x00329498 File Offset: 0x00327698
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600D75B RID: 55131 RVA: 0x003294A8 File Offset: 0x003276A8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D75C RID: 55132 RVA: 0x003294C0 File Offset: 0x003276C0
		[NullableContext(1)]
		public string[] Params()
		{
			return this.ParamsIter().ToArray<string>();
		}

		// Token: 0x0600D75D RID: 55133 RVA: 0x003294CD File Offset: 0x003276CD
		[NullableContext(1)]
		public IEnumerable<string> ParamsIter()
		{
			RoverRogueTalentTree.<ParamsIter>d__43 <ParamsIter>d__ = new RoverRogueTalentTree.<ParamsIter>d__43(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x0600D75E RID: 55134 RVA: 0x003294E2 File Offset: 0x003276E2
		[NullableContext(1)]
		public int[] PostId()
		{
			return this.GetPostIdArray();
		}

		// Token: 0x0600D75F RID: 55135 RVA: 0x003294EA File Offset: 0x003276EA
		[NullableContext(1)]
		public IEnumerable<int> PostIdIter()
		{
			RoverRogueTalentTree.<PostIdIter>d__45 <PostIdIter>d__ = new RoverRogueTalentTree.<PostIdIter>d__45(-2);
			<PostIdIter>d__.<>3__<>4__this = this;
			return <PostIdIter>d__;
		}

		// Token: 0x04005797 RID: 22423
		private Table __p;
	}
}
