using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EAC RID: 3756
	public struct LifePointEntrance : IFlatbufferObject
	{
		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x060093FD RID: 37885 RVA: 0x00295A8C File Offset: 0x00293C8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060093FE RID: 37886 RVA: 0x00295A99 File Offset: 0x00293C99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060093FF RID: 37887 RVA: 0x00295AA0 File Offset: 0x00293CA0
		public static LifePointEntrance GetRootAsLifePointEntrance(ByteBuffer _bb)
		{
			return LifePointEntrance.GetRootAsLifePointEntrance(_bb, default(LifePointEntrance));
		}

		// Token: 0x06009400 RID: 37888 RVA: 0x00295ABC File Offset: 0x00293CBC
		public static LifePointEntrance GetRootAsLifePointEntrance(ByteBuffer _bb, LifePointEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009401 RID: 37889 RVA: 0x00295AD9 File Offset: 0x00293CD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009402 RID: 37890 RVA: 0x00295AE8 File Offset: 0x00293CE8
		public LifePointEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x06009403 RID: 37891 RVA: 0x00295AF8 File Offset: 0x00293CF8
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

		// Token: 0x06009404 RID: 37892 RVA: 0x00295B34 File Offset: 0x00293D34
		public int GroupList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x06009405 RID: 37893 RVA: 0x00295B74 File Offset: 0x00293D74
		public int GroupListLength
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

		// Token: 0x06009406 RID: 37894 RVA: 0x00295B9F File Offset: 0x00293D9F
		public Span<int> GetGroupListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06009407 RID: 37895 RVA: 0x00295BAE File Offset: 0x00293DAE
		public int[] GetGroupListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06009408 RID: 37896 RVA: 0x00295BC5 File Offset: 0x00293DC5
		[NullableContext(1)]
		public int[] GroupList()
		{
			return this.GetGroupListArray();
		}

		// Token: 0x06009409 RID: 37897 RVA: 0x00295BCD File Offset: 0x00293DCD
		[NullableContext(1)]
		public IEnumerable<int> GroupListIter()
		{
			LifePointEntrance.<GroupListIter>d__16 <GroupListIter>d__ = new LifePointEntrance.<GroupListIter>d__16(-2);
			<GroupListIter>d__.<>3__<>4__this = this;
			return <GroupListIter>d__;
		}

		// Token: 0x04005442 RID: 21570
		private Table __p;
	}
}
