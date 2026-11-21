using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C77 RID: 3191
	public struct ConditionGroup : IFlatbufferObject
	{
		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06005DEE RID: 24046 RVA: 0x0021C0B6 File Offset: 0x0021A2B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005DEF RID: 24047 RVA: 0x0021C0C3 File Offset: 0x0021A2C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005DF0 RID: 24048 RVA: 0x0021C0CC File Offset: 0x0021A2CC
		public static ConditionGroup GetRootAsConditionGroup(ByteBuffer _bb)
		{
			return ConditionGroup.GetRootAsConditionGroup(_bb, default(ConditionGroup));
		}

		// Token: 0x06005DF1 RID: 24049 RVA: 0x0021C0E8 File Offset: 0x0021A2E8
		public static ConditionGroup GetRootAsConditionGroup(ByteBuffer _bb, ConditionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005DF2 RID: 24050 RVA: 0x0021C105 File Offset: 0x0021A305
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005DF3 RID: 24051 RVA: 0x0021C114 File Offset: 0x0021A314
		public ConditionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06005DF4 RID: 24052 RVA: 0x0021C124 File Offset: 0x0021A324
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

		// Token: 0x06005DF5 RID: 24053 RVA: 0x0021C160 File Offset: 0x0021A360
		public int GroupId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06005DF6 RID: 24054 RVA: 0x0021C1A0 File Offset: 0x0021A3A0
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

		// Token: 0x06005DF7 RID: 24055 RVA: 0x0021C1CB File Offset: 0x0021A3CB
		public Span<int> GetGroupIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06005DF8 RID: 24056 RVA: 0x0021C1DA File Offset: 0x0021A3DA
		public int[] GetGroupIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06005DF9 RID: 24057 RVA: 0x0021C1F4 File Offset: 0x0021A3F4
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

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06005DFA RID: 24058 RVA: 0x0021C230 File Offset: 0x0021A430
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

		// Token: 0x06005DFB RID: 24059 RVA: 0x0021C268 File Offset: 0x0021A468
		public Span<byte> GetHintTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005DFC RID: 24060 RVA: 0x0021C278 File Offset: 0x0021A478
		public byte[] GetHintTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06005DFD RID: 24061 RVA: 0x0021C290 File Offset: 0x0021A490
		[NullableContext(1)]
		public int[] GroupId()
		{
			return this.GetGroupIdArray();
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x0021C298 File Offset: 0x0021A498
		[NullableContext(1)]
		public IEnumerable<int> GroupIdIter()
		{
			ConditionGroup.<GroupIdIter>d__22 <GroupIdIter>d__ = new ConditionGroup.<GroupIdIter>d__22(-2);
			<GroupIdIter>d__.<>3__<>4__this = this;
			return <GroupIdIter>d__;
		}

		// Token: 0x04005188 RID: 20872
		private Table __p;
	}
}
