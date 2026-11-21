using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED4 RID: 3796
	public struct MapMarkPhantomGroup : IFlatbufferObject
	{
		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x06009775 RID: 38773 RVA: 0x0029D50C File Offset: 0x0029B70C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009776 RID: 38774 RVA: 0x0029D519 File Offset: 0x0029B719
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009777 RID: 38775 RVA: 0x0029D520 File Offset: 0x0029B720
		public static MapMarkPhantomGroup GetRootAsMapMarkPhantomGroup(ByteBuffer _bb)
		{
			return MapMarkPhantomGroup.GetRootAsMapMarkPhantomGroup(_bb, default(MapMarkPhantomGroup));
		}

		// Token: 0x06009778 RID: 38776 RVA: 0x0029D53C File Offset: 0x0029B73C
		public static MapMarkPhantomGroup GetRootAsMapMarkPhantomGroup(ByteBuffer _bb, MapMarkPhantomGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009779 RID: 38777 RVA: 0x0029D559 File Offset: 0x0029B759
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600977A RID: 38778 RVA: 0x0029D568 File Offset: 0x0029B768
		public MapMarkPhantomGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x0600977B RID: 38779 RVA: 0x0029D578 File Offset: 0x0029B778
		public int MarkId
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

		// Token: 0x0600977C RID: 38780 RVA: 0x0029D5B4 File Offset: 0x0029B7B4
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x0600977D RID: 38781 RVA: 0x0029D5F4 File Offset: 0x0029B7F4
		public int ShowRangeLength
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

		// Token: 0x0600977E RID: 38782 RVA: 0x0029D61F File Offset: 0x0029B81F
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600977F RID: 38783 RVA: 0x0029D62E File Offset: 0x0029B82E
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06009780 RID: 38784 RVA: 0x0029D648 File Offset: 0x0029B848
		public int ShowPhantom(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x06009781 RID: 38785 RVA: 0x0029D688 File Offset: 0x0029B888
		public int ShowPhantomLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009782 RID: 38786 RVA: 0x0029D6B3 File Offset: 0x0029B8B3
		public Span<int> GetShowPhantomBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009783 RID: 38787 RVA: 0x0029D6C2 File Offset: 0x0029B8C2
		public int[] GetShowPhantomArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06009784 RID: 38788 RVA: 0x0029D6D9 File Offset: 0x0029B8D9
		[NullableContext(1)]
		public int[] ShowPhantom()
		{
			return this.GetShowPhantomArray();
		}

		// Token: 0x06009785 RID: 38789 RVA: 0x0029D6E1 File Offset: 0x0029B8E1
		[NullableContext(1)]
		public IEnumerable<int> ShowPhantomIter()
		{
			MapMarkPhantomGroup.<ShowPhantomIter>d__21 <ShowPhantomIter>d__ = new MapMarkPhantomGroup.<ShowPhantomIter>d__21(-2);
			<ShowPhantomIter>d__.<>3__<>4__this = this;
			return <ShowPhantomIter>d__;
		}

		// Token: 0x06009786 RID: 38790 RVA: 0x0029D6F6 File Offset: 0x0029B8F6
		[NullableContext(1)]
		public int[] ShowRange()
		{
			return this.GetShowRangeArray();
		}

		// Token: 0x06009787 RID: 38791 RVA: 0x0029D6FE File Offset: 0x0029B8FE
		[NullableContext(1)]
		public IEnumerable<int> ShowRangeIter()
		{
			MapMarkPhantomGroup.<ShowRangeIter>d__23 <ShowRangeIter>d__ = new MapMarkPhantomGroup.<ShowRangeIter>d__23(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x04005471 RID: 21617
		private Table __p;
	}
}
