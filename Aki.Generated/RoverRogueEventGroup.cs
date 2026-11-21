using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001175 RID: 4469
	public struct RoverRogueEventGroup : IFlatbufferObject
	{
		// Token: 0x17003551 RID: 13649
		// (get) Token: 0x0600D592 RID: 54674 RVA: 0x00325630 File Offset: 0x00323830
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D593 RID: 54675 RVA: 0x0032563D File Offset: 0x0032383D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D594 RID: 54676 RVA: 0x00325644 File Offset: 0x00323844
		public static RoverRogueEventGroup GetRootAsRoverRogueEventGroup(ByteBuffer _bb)
		{
			return RoverRogueEventGroup.GetRootAsRoverRogueEventGroup(_bb, default(RoverRogueEventGroup));
		}

		// Token: 0x0600D595 RID: 54677 RVA: 0x00325660 File Offset: 0x00323860
		public static RoverRogueEventGroup GetRootAsRoverRogueEventGroup(ByteBuffer _bb, RoverRogueEventGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D596 RID: 54678 RVA: 0x0032567D File Offset: 0x0032387D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D597 RID: 54679 RVA: 0x0032568C File Offset: 0x0032388C
		public RoverRogueEventGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003552 RID: 13650
		// (get) Token: 0x0600D598 RID: 54680 RVA: 0x0032569C File Offset: 0x0032389C
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

		// Token: 0x0600D599 RID: 54681 RVA: 0x003256D8 File Offset: 0x003238D8
		public int ChoicePool(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003553 RID: 13651
		// (get) Token: 0x0600D59A RID: 54682 RVA: 0x00325718 File Offset: 0x00323918
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

		// Token: 0x0600D59B RID: 54683 RVA: 0x00325743 File Offset: 0x00323943
		public Span<int> GetChoicePoolBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600D59C RID: 54684 RVA: 0x00325752 File Offset: 0x00323952
		public int[] GetChoicePoolArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17003554 RID: 13652
		// (get) Token: 0x0600D59D RID: 54685 RVA: 0x0032576C File Offset: 0x0032396C
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

		// Token: 0x0600D59E RID: 54686 RVA: 0x003257A8 File Offset: 0x003239A8
		[NullableContext(1)]
		public int[] ChoicePool()
		{
			return this.GetChoicePoolArray();
		}

		// Token: 0x0600D59F RID: 54687 RVA: 0x003257B0 File Offset: 0x003239B0
		[NullableContext(1)]
		public IEnumerable<int> ChoicePoolIter()
		{
			RoverRogueEventGroup.<ChoicePoolIter>d__18 <ChoicePoolIter>d__ = new RoverRogueEventGroup.<ChoicePoolIter>d__18(-2);
			<ChoicePoolIter>d__.<>3__<>4__this = this;
			return <ChoicePoolIter>d__;
		}

		// Token: 0x04005783 RID: 22403
		private Table __p;
	}
}
