using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010FD RID: 4349
	public struct RogueResTalentTree : IFlatbufferObject
	{
		// Token: 0x17003147 RID: 12615
		// (get) Token: 0x0600CA52 RID: 51794 RVA: 0x0030BFB9 File Offset: 0x0030A1B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CA53 RID: 51795 RVA: 0x0030BFC6 File Offset: 0x0030A1C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CA54 RID: 51796 RVA: 0x0030BFD0 File Offset: 0x0030A1D0
		public static RogueResTalentTree GetRootAsRogueResTalentTree(ByteBuffer _bb)
		{
			return RogueResTalentTree.GetRootAsRogueResTalentTree(_bb, default(RogueResTalentTree));
		}

		// Token: 0x0600CA55 RID: 51797 RVA: 0x0030BFEC File Offset: 0x0030A1EC
		public static RogueResTalentTree GetRootAsRogueResTalentTree(ByteBuffer _bb, RogueResTalentTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CA56 RID: 51798 RVA: 0x0030C009 File Offset: 0x0030A209
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CA57 RID: 51799 RVA: 0x0030C018 File Offset: 0x0030A218
		public RogueResTalentTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003148 RID: 12616
		// (get) Token: 0x0600CA58 RID: 51800 RVA: 0x0030C028 File Offset: 0x0030A228
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

		// Token: 0x17003149 RID: 12617
		// (get) Token: 0x0600CA59 RID: 51801 RVA: 0x0030C064 File Offset: 0x0030A264
		public int SeasonId
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

		// Token: 0x1700314A RID: 12618
		// (get) Token: 0x0600CA5A RID: 51802 RVA: 0x0030C0A0 File Offset: 0x0030A2A0
		public int Condition
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

		// Token: 0x0600CA5B RID: 51803 RVA: 0x0030C0DC File Offset: 0x0030A2DC
		public int Consule(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700314B RID: 12619
		// (get) Token: 0x0600CA5C RID: 51804 RVA: 0x0030C11C File Offset: 0x0030A31C
		public int ConsuleLength
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

		// Token: 0x0600CA5D RID: 51805 RVA: 0x0030C148 File Offset: 0x0030A348
		public Span<int> GetConsuleBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600CA5E RID: 51806 RVA: 0x0030C158 File Offset: 0x0030A358
		public int[] GetConsuleArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700314C RID: 12620
		// (get) Token: 0x0600CA5F RID: 51807 RVA: 0x0030C170 File Offset: 0x0030A370
		public int Describe
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

		// Token: 0x0600CA60 RID: 51808 RVA: 0x0030C1AD File Offset: 0x0030A3AD
		[NullableContext(1)]
		public int[] Consule()
		{
			return this.GetConsuleArray();
		}

		// Token: 0x0600CA61 RID: 51809 RVA: 0x0030C1B5 File Offset: 0x0030A3B5
		[NullableContext(1)]
		public IEnumerable<int> ConsuleIter()
		{
			RogueResTalentTree.<ConsuleIter>d__22 <ConsuleIter>d__ = new RogueResTalentTree.<ConsuleIter>d__22(-2);
			<ConsuleIter>d__.<>3__<>4__this = this;
			return <ConsuleIter>d__;
		}

		// Token: 0x040056EB RID: 22251
		private Table __p;
	}
}
