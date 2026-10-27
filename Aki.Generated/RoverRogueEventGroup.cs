using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200107A RID: 4218
	public struct RoverRogueEventGroup : IFlatbufferObject
	{
		// Token: 0x17003444 RID: 13380
		// (get) Token: 0x0600CDBF RID: 52671 RVA: 0x00305ECC File Offset: 0x003040CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CDC0 RID: 52672 RVA: 0x00305ED9 File Offset: 0x003040D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CDC1 RID: 52673 RVA: 0x00305EE0 File Offset: 0x003040E0
		public static RoverRogueEventGroup GetRootAsRoverRogueEventGroup(ByteBuffer _bb)
		{
			return RoverRogueEventGroup.GetRootAsRoverRogueEventGroup(_bb, default(RoverRogueEventGroup));
		}

		// Token: 0x0600CDC2 RID: 52674 RVA: 0x00305EFC File Offset: 0x003040FC
		public static RoverRogueEventGroup GetRootAsRoverRogueEventGroup(ByteBuffer _bb, RoverRogueEventGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CDC3 RID: 52675 RVA: 0x00305F19 File Offset: 0x00304119
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CDC4 RID: 52676 RVA: 0x00305F28 File Offset: 0x00304128
		public RoverRogueEventGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003445 RID: 13381
		// (get) Token: 0x0600CDC5 RID: 52677 RVA: 0x00305F38 File Offset: 0x00304138
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

		// Token: 0x0600CDC6 RID: 52678 RVA: 0x00305F74 File Offset: 0x00304174
		public int ChoicePool(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003446 RID: 13382
		// (get) Token: 0x0600CDC7 RID: 52679 RVA: 0x00305FB4 File Offset: 0x003041B4
		public int ChoicePoolLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CDC8 RID: 52680 RVA: 0x00305FDF File Offset: 0x003041DF
		public Span<int> GetChoicePoolBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600CDC9 RID: 52681 RVA: 0x00305FEE File Offset: 0x003041EE
		public int[] GetChoicePoolArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17003447 RID: 13383
		// (get) Token: 0x0600CDCA RID: 52682 RVA: 0x00306008 File Offset: 0x00304208
		public int Num
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CDCB RID: 52683 RVA: 0x00306044 File Offset: 0x00304244
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ChoicePoolIter()或GetChoicePoolBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ChoicePool()
		{
			RoverRogueEventGroup roverRogueEventGroup = this;
			return roverRogueEventGroup.GetChoicePoolArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CDCC RID: 52684 RVA: 0x00306068 File Offset: 0x00304268
		[NullableContext(1)]
		public readonly IEnumerable<int> ChoicePoolIter()
		{
			RoverRogueEventGroup.<ChoicePoolIter>d__18 <ChoicePoolIter>d__ = new RoverRogueEventGroup.<ChoicePoolIter>d__18(-2);
			<ChoicePoolIter>d__.<>3__<>4__this = this;
			return <ChoicePoolIter>d__;
		}

		// Token: 0x04005184 RID: 20868
		private Table __p;
	}
}
