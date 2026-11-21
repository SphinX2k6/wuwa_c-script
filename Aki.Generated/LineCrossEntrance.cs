using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB0 RID: 3760
	public struct LineCrossEntrance : IFlatbufferObject
	{
		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x0600944D RID: 37965 RVA: 0x00296464 File Offset: 0x00294664
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600944E RID: 37966 RVA: 0x00296471 File Offset: 0x00294671
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600944F RID: 37967 RVA: 0x00296478 File Offset: 0x00294678
		public static LineCrossEntrance GetRootAsLineCrossEntrance(ByteBuffer _bb)
		{
			return LineCrossEntrance.GetRootAsLineCrossEntrance(_bb, default(LineCrossEntrance));
		}

		// Token: 0x06009450 RID: 37968 RVA: 0x00296494 File Offset: 0x00294694
		public static LineCrossEntrance GetRootAsLineCrossEntrance(ByteBuffer _bb, LineCrossEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009451 RID: 37969 RVA: 0x002964B1 File Offset: 0x002946B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009452 RID: 37970 RVA: 0x002964C0 File Offset: 0x002946C0
		public LineCrossEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x06009453 RID: 37971 RVA: 0x002964D0 File Offset: 0x002946D0
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

		// Token: 0x06009454 RID: 37972 RVA: 0x0029650C File Offset: 0x0029470C
		public int GroupList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x06009455 RID: 37973 RVA: 0x0029654C File Offset: 0x0029474C
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

		// Token: 0x06009456 RID: 37974 RVA: 0x00296577 File Offset: 0x00294777
		public Span<int> GetGroupListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06009457 RID: 37975 RVA: 0x00296586 File Offset: 0x00294786
		public int[] GetGroupListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06009458 RID: 37976 RVA: 0x0029659D File Offset: 0x0029479D
		[NullableContext(1)]
		public int[] GroupList()
		{
			return this.GetGroupListArray();
		}

		// Token: 0x06009459 RID: 37977 RVA: 0x002965A5 File Offset: 0x002947A5
		[NullableContext(1)]
		public IEnumerable<int> GroupListIter()
		{
			LineCrossEntrance.<GroupListIter>d__16 <GroupListIter>d__ = new LineCrossEntrance.<GroupListIter>d__16(-2);
			<GroupListIter>d__.<>3__<>4__this = this;
			return <GroupListIter>d__;
		}

		// Token: 0x04005446 RID: 21574
		private Table __p;
	}
}
