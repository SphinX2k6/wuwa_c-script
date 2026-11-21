using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200123E RID: 4670
	public struct SurvivorsTalentTree : IFlatbufferObject
	{
		// Token: 0x17003C8A RID: 15498
		// (get) Token: 0x0600E8E0 RID: 59616 RVA: 0x00351A10 File Offset: 0x0034FC10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E8E1 RID: 59617 RVA: 0x00351A1D File Offset: 0x0034FC1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E8E2 RID: 59618 RVA: 0x00351A24 File Offset: 0x0034FC24
		public static SurvivorsTalentTree GetRootAsSurvivorsTalentTree(ByteBuffer _bb)
		{
			return SurvivorsTalentTree.GetRootAsSurvivorsTalentTree(_bb, default(SurvivorsTalentTree));
		}

		// Token: 0x0600E8E3 RID: 59619 RVA: 0x00351A40 File Offset: 0x0034FC40
		public static SurvivorsTalentTree GetRootAsSurvivorsTalentTree(ByteBuffer _bb, SurvivorsTalentTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E8E4 RID: 59620 RVA: 0x00351A5D File Offset: 0x0034FC5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E8E5 RID: 59621 RVA: 0x00351A6C File Offset: 0x0034FC6C
		public SurvivorsTalentTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C8B RID: 15499
		// (get) Token: 0x0600E8E6 RID: 59622 RVA: 0x00351A7C File Offset: 0x0034FC7C
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

		// Token: 0x17003C8C RID: 15500
		// (get) Token: 0x0600E8E7 RID: 59623 RVA: 0x00351AB8 File Offset: 0x0034FCB8
		public int ActivityId
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

		// Token: 0x17003C8D RID: 15501
		// (get) Token: 0x0600E8E8 RID: 59624 RVA: 0x00351AF4 File Offset: 0x0034FCF4
		public string Name
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E8E9 RID: 59625 RVA: 0x00351B2B File Offset: 0x0034FD2B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E8EA RID: 59626 RVA: 0x00351B3A File Offset: 0x0034FD3A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C8E RID: 15502
		// (get) Token: 0x0600E8EB RID: 59627 RVA: 0x00351B54 File Offset: 0x0034FD54
		public int Area
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C8F RID: 15503
		// (get) Token: 0x0600E8EC RID: 59628 RVA: 0x00351B94 File Offset: 0x0034FD94
		public int Type
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

		// Token: 0x17003C90 RID: 15504
		// (get) Token: 0x0600E8ED RID: 59629 RVA: 0x00351BD4 File Offset: 0x0034FDD4
		public int IndexId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C91 RID: 15505
		// (get) Token: 0x0600E8EE RID: 59630 RVA: 0x00351C14 File Offset: 0x0034FE14
		public int IndexSortId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E8EF RID: 59631 RVA: 0x00351C54 File Offset: 0x0034FE54
		public int PreNode(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C92 RID: 15506
		// (get) Token: 0x0600E8F0 RID: 59632 RVA: 0x00351C94 File Offset: 0x0034FE94
		public int PreNodeLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E8F1 RID: 59633 RVA: 0x00351CC0 File Offset: 0x0034FEC0
		public Span<int> GetPreNodeBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600E8F2 RID: 59634 RVA: 0x00351CD0 File Offset: 0x0034FED0
		public int[] GetPreNodeArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17003C93 RID: 15507
		// (get) Token: 0x0600E8F3 RID: 59635 RVA: 0x00351CE8 File Offset: 0x0034FEE8
		public int UnlockCondition
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C94 RID: 15508
		// (get) Token: 0x0600E8F4 RID: 59636 RVA: 0x00351D28 File Offset: 0x0034FF28
		public string UnlockConditionDesc
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E8F5 RID: 59637 RVA: 0x00351D60 File Offset: 0x0034FF60
		public Span<byte> GetUnlockConditionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600E8F6 RID: 59638 RVA: 0x00351D70 File Offset: 0x0034FF70
		public byte[] GetUnlockConditionDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C95 RID: 15509
		// (get) Token: 0x0600E8F7 RID: 59639 RVA: 0x00351D88 File Offset: 0x0034FF88
		public int Effect
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C96 RID: 15510
		// (get) Token: 0x0600E8F8 RID: 59640 RVA: 0x00351DC8 File Offset: 0x0034FFC8
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E8F9 RID: 59641 RVA: 0x00351E00 File Offset: 0x00350000
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600E8FA RID: 59642 RVA: 0x00351E10 File Offset: 0x00350010
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E8FB RID: 59643 RVA: 0x00351E28 File Offset: 0x00350028
		[NullableContext(1)]
		public int[] PreNode()
		{
			return this.GetPreNodeArray();
		}

		// Token: 0x0600E8FC RID: 59644 RVA: 0x00351E30 File Offset: 0x00350030
		[NullableContext(1)]
		public IEnumerable<int> PreNodeIter()
		{
			SurvivorsTalentTree.<PreNodeIter>d__42 <PreNodeIter>d__ = new SurvivorsTalentTree.<PreNodeIter>d__42(-2);
			<PreNodeIter>d__.<>3__<>4__this = this;
			return <PreNodeIter>d__;
		}

		// Token: 0x04005885 RID: 22661
		private Table __p;
	}
}
