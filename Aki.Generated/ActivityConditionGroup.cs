using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B9B RID: 2971
	public struct ActivityConditionGroup : IFlatbufferObject
	{
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06004868 RID: 18536 RVA: 0x001EB649 File Offset: 0x001E9849
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004869 RID: 18537 RVA: 0x001EB656 File Offset: 0x001E9856
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600486A RID: 18538 RVA: 0x001EB660 File Offset: 0x001E9860
		public static ActivityConditionGroup GetRootAsActivityConditionGroup(ByteBuffer _bb)
		{
			return ActivityConditionGroup.GetRootAsActivityConditionGroup(_bb, default(ActivityConditionGroup));
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x001EB67C File Offset: 0x001E987C
		public static ActivityConditionGroup GetRootAsActivityConditionGroup(ByteBuffer _bb, ActivityConditionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x001EB699 File Offset: 0x001E9899
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600486D RID: 18541 RVA: 0x001EB6A8 File Offset: 0x001E98A8
		public ActivityConditionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600486E RID: 18542 RVA: 0x001EB6B8 File Offset: 0x001E98B8
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

		// Token: 0x0600486F RID: 18543 RVA: 0x001EB6F4 File Offset: 0x001E98F4
		public int GroupId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06004870 RID: 18544 RVA: 0x001EB734 File Offset: 0x001E9934
		public int GroupIdLength
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

		// Token: 0x06004871 RID: 18545 RVA: 0x001EB75F File Offset: 0x001E995F
		public Span<int> GetGroupIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06004872 RID: 18546 RVA: 0x001EB76E File Offset: 0x001E996E
		public int[] GetGroupIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06004873 RID: 18547 RVA: 0x001EB788 File Offset: 0x001E9988
		public int Logic
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

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06004874 RID: 18548 RVA: 0x001EB7C4 File Offset: 0x001E99C4
		public string HintText
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x001EB7FC File Offset: 0x001E99FC
		public Span<byte> GetHintTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004876 RID: 18550 RVA: 0x001EB80C File Offset: 0x001E9A0C
		public byte[] GetHintTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x001EB824 File Offset: 0x001E9A24
		[NullableContext(1)]
		public int[] GroupId()
		{
			return this.GetGroupIdArray();
		}

		// Token: 0x06004878 RID: 18552 RVA: 0x001EB82C File Offset: 0x001E9A2C
		[NullableContext(1)]
		public IEnumerable<int> GroupIdIter()
		{
			ActivityConditionGroup.<GroupIdIter>d__22 <GroupIdIter>d__ = new ActivityConditionGroup.<GroupIdIter>d__22(-2);
			<GroupIdIter>d__.<>3__<>4__this = this;
			return <GroupIdIter>d__;
		}

		// Token: 0x04005077 RID: 20599
		private Table __p;
	}
}
