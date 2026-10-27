using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B95 RID: 2965
	public struct ConditionGroup : IFlatbufferObject
	{
		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06005815 RID: 22549 RVA: 0x001FC2DA File Offset: 0x001FA4DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005816 RID: 22550 RVA: 0x001FC2E7 File Offset: 0x001FA4E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005817 RID: 22551 RVA: 0x001FC2F0 File Offset: 0x001FA4F0
		public static ConditionGroup GetRootAsConditionGroup(ByteBuffer _bb)
		{
			return ConditionGroup.GetRootAsConditionGroup(_bb, default(ConditionGroup));
		}

		// Token: 0x06005818 RID: 22552 RVA: 0x001FC30C File Offset: 0x001FA50C
		public static ConditionGroup GetRootAsConditionGroup(ByteBuffer _bb, ConditionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005819 RID: 22553 RVA: 0x001FC329 File Offset: 0x001FA529
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600581A RID: 22554 RVA: 0x001FC338 File Offset: 0x001FA538
		public ConditionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x0600581B RID: 22555 RVA: 0x001FC348 File Offset: 0x001FA548
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

		// Token: 0x0600581C RID: 22556 RVA: 0x001FC384 File Offset: 0x001FA584
		public int GroupId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x0600581D RID: 22557 RVA: 0x001FC3C4 File Offset: 0x001FA5C4
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

		// Token: 0x0600581E RID: 22558 RVA: 0x001FC3EF File Offset: 0x001FA5EF
		public Span<int> GetGroupIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600581F RID: 22559 RVA: 0x001FC3FE File Offset: 0x001FA5FE
		public int[] GetGroupIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06005820 RID: 22560 RVA: 0x001FC418 File Offset: 0x001FA618
		public int Relation
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

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06005821 RID: 22561 RVA: 0x001FC454 File Offset: 0x001FA654
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

		// Token: 0x06005822 RID: 22562 RVA: 0x001FC48C File Offset: 0x001FA68C
		public Span<byte> GetHintTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005823 RID: 22563 RVA: 0x001FC49C File Offset: 0x001FA69C
		public byte[] GetHintTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06005824 RID: 22564 RVA: 0x001FC4B4 File Offset: 0x001FA6B4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GroupIdIter()或GetGroupIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GroupId()
		{
			ConditionGroup conditionGroup = this;
			return conditionGroup.GetGroupIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005825 RID: 22565 RVA: 0x001FC4D8 File Offset: 0x001FA6D8
		[NullableContext(1)]
		public readonly IEnumerable<int> GroupIdIter()
		{
			ConditionGroup.<GroupIdIter>d__22 <GroupIdIter>d__ = new ConditionGroup.<GroupIdIter>d__22(-2);
			<GroupIdIter>d__.<>3__<>4__this = this;
			return <GroupIdIter>d__;
		}

		// Token: 0x04004BA6 RID: 19366
		private Table __p;
	}
}
