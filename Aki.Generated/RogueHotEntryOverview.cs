using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010CB RID: 4299
	public struct RogueHotEntryOverview : IFlatbufferObject
	{
		// Token: 0x17002FCA RID: 12234
		// (get) Token: 0x0600C5B5 RID: 50613 RVA: 0x00301F3C File Offset: 0x0030013C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C5B6 RID: 50614 RVA: 0x00301F49 File Offset: 0x00300149
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C5B7 RID: 50615 RVA: 0x00301F50 File Offset: 0x00300150
		public static RogueHotEntryOverview GetRootAsRogueHotEntryOverview(ByteBuffer _bb)
		{
			return RogueHotEntryOverview.GetRootAsRogueHotEntryOverview(_bb, default(RogueHotEntryOverview));
		}

		// Token: 0x0600C5B8 RID: 50616 RVA: 0x00301F6C File Offset: 0x0030016C
		public static RogueHotEntryOverview GetRootAsRogueHotEntryOverview(ByteBuffer _bb, RogueHotEntryOverview obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C5B9 RID: 50617 RVA: 0x00301F89 File Offset: 0x00300189
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C5BA RID: 50618 RVA: 0x00301F98 File Offset: 0x00300198
		public RogueHotEntryOverview __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FCB RID: 12235
		// (get) Token: 0x0600C5BB RID: 50619 RVA: 0x00301FA8 File Offset: 0x003001A8
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

		// Token: 0x17002FCC RID: 12236
		// (get) Token: 0x0600C5BC RID: 50620 RVA: 0x00301FE4 File Offset: 0x003001E4
		public int Type
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

		// Token: 0x0600C5BD RID: 50621 RVA: 0x00302020 File Offset: 0x00300220
		public bool ParamShowPercent(int j)
		{
			int num = this.__p.__offset(8);
			return num != 0 && this.__p.bb.Get(this.__p.__vector(num) + j) > 0;
		}

		// Token: 0x17002FCD RID: 12237
		// (get) Token: 0x0600C5BE RID: 50622 RVA: 0x00302060 File Offset: 0x00300260
		public int ParamShowPercentLength
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

		// Token: 0x0600C5BF RID: 50623 RVA: 0x0030208B File Offset: 0x0030028B
		public Span<bool> GetParamShowPercentBytes()
		{
			return this.__p.__vector_as_span<bool>(8, 1);
		}

		// Token: 0x0600C5C0 RID: 50624 RVA: 0x0030209A File Offset: 0x0030029A
		public bool[] GetParamShowPercentArray()
		{
			return this.__p.__vector_as_array<bool>(8) ?? Array.Empty<bool>();
		}

		// Token: 0x0600C5C1 RID: 50625 RVA: 0x003020B4 File Offset: 0x003002B4
		public string Desc(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FCE RID: 12238
		// (get) Token: 0x0600C5C2 RID: 50626 RVA: 0x003020F0 File Offset: 0x003002F0
		public int DescLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002FCF RID: 12239
		// (get) Token: 0x0600C5C3 RID: 50627 RVA: 0x0030211C File Offset: 0x0030031C
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C5C4 RID: 50628 RVA: 0x00302159 File Offset: 0x00300359
		[NullableContext(1)]
		public string[] Desc()
		{
			return this.DescIter().ToArray<string>();
		}

		// Token: 0x0600C5C5 RID: 50629 RVA: 0x00302166 File Offset: 0x00300366
		[NullableContext(1)]
		public IEnumerable<string> DescIter()
		{
			RogueHotEntryOverview.<DescIter>d__23 <DescIter>d__ = new RogueHotEntryOverview.<DescIter>d__23(-2);
			<DescIter>d__.<>3__<>4__this = this;
			return <DescIter>d__;
		}

		// Token: 0x0600C5C6 RID: 50630 RVA: 0x0030217B File Offset: 0x0030037B
		[NullableContext(1)]
		public bool[] ParamShowPercent()
		{
			return this.GetParamShowPercentArray();
		}

		// Token: 0x0600C5C7 RID: 50631 RVA: 0x00302183 File Offset: 0x00300383
		[NullableContext(1)]
		public IEnumerable<bool> ParamShowPercentIter()
		{
			RogueHotEntryOverview.<ParamShowPercentIter>d__25 <ParamShowPercentIter>d__ = new RogueHotEntryOverview.<ParamShowPercentIter>d__25(-2);
			<ParamShowPercentIter>d__.<>3__<>4__this = this;
			return <ParamShowPercentIter>d__;
		}

		// Token: 0x040056A8 RID: 22184
		private Table __p;
	}
}
