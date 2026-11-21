using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E2F RID: 3631
	public struct HonamiStoryPropLibrary : IFlatbufferObject
	{
		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x0600871D RID: 34589 RVA: 0x002783C4 File Offset: 0x002765C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600871E RID: 34590 RVA: 0x002783D1 File Offset: 0x002765D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600871F RID: 34591 RVA: 0x002783D8 File Offset: 0x002765D8
		public static HonamiStoryPropLibrary GetRootAsHonamiStoryPropLibrary(ByteBuffer _bb)
		{
			return HonamiStoryPropLibrary.GetRootAsHonamiStoryPropLibrary(_bb, default(HonamiStoryPropLibrary));
		}

		// Token: 0x06008720 RID: 34592 RVA: 0x002783F4 File Offset: 0x002765F4
		public static HonamiStoryPropLibrary GetRootAsHonamiStoryPropLibrary(ByteBuffer _bb, HonamiStoryPropLibrary obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008721 RID: 34593 RVA: 0x00278411 File Offset: 0x00276611
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008722 RID: 34594 RVA: 0x00278420 File Offset: 0x00276620
		public HonamiStoryPropLibrary __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x06008723 RID: 34595 RVA: 0x00278430 File Offset: 0x00276630
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

		// Token: 0x06008724 RID: 34596 RVA: 0x0027846C File Offset: 0x0027666C
		public int HonamiStoryPropId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x06008725 RID: 34597 RVA: 0x002784AC File Offset: 0x002766AC
		public int HonamiStoryPropIdLength
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

		// Token: 0x06008726 RID: 34598 RVA: 0x002784D7 File Offset: 0x002766D7
		public Span<int> GetHonamiStoryPropIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008727 RID: 34599 RVA: 0x002784E6 File Offset: 0x002766E6
		public int[] GetHonamiStoryPropIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008728 RID: 34600 RVA: 0x002784FD File Offset: 0x002766FD
		[NullableContext(1)]
		public int[] HonamiStoryPropId()
		{
			return this.GetHonamiStoryPropIdArray();
		}

		// Token: 0x06008729 RID: 34601 RVA: 0x00278505 File Offset: 0x00276705
		[NullableContext(1)]
		public IEnumerable<int> HonamiStoryPropIdIter()
		{
			HonamiStoryPropLibrary.<HonamiStoryPropIdIter>d__16 <HonamiStoryPropIdIter>d__ = new HonamiStoryPropLibrary.<HonamiStoryPropIdIter>d__16(-2);
			<HonamiStoryPropIdIter>d__.<>3__<>4__this = this;
			return <HonamiStoryPropIdIter>d__;
		}

		// Token: 0x040053AB RID: 21419
		private Table __p;
	}
}
