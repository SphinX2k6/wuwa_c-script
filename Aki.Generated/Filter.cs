using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D51 RID: 3409
	public struct Filter : IFlatbufferObject
	{
		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06007438 RID: 29752 RVA: 0x0024D928 File Offset: 0x0024BB28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007439 RID: 29753 RVA: 0x0024D935 File Offset: 0x0024BB35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600743A RID: 29754 RVA: 0x0024D93C File Offset: 0x0024BB3C
		public static Filter GetRootAsFilter(ByteBuffer _bb)
		{
			return Filter.GetRootAsFilter(_bb, default(Filter));
		}

		// Token: 0x0600743B RID: 29755 RVA: 0x0024D958 File Offset: 0x0024BB58
		public static Filter GetRootAsFilter(ByteBuffer _bb, Filter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600743C RID: 29756 RVA: 0x0024D975 File Offset: 0x0024BB75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600743D RID: 29757 RVA: 0x0024D984 File Offset: 0x0024BB84
		public Filter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x0600743E RID: 29758 RVA: 0x0024D994 File Offset: 0x0024BB94
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

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x0600743F RID: 29759 RVA: 0x0024D9D0 File Offset: 0x0024BBD0
		public int DataType
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

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x06007440 RID: 29760 RVA: 0x0024DA0C File Offset: 0x0024BC0C
		public int PrefabType
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

		// Token: 0x06007441 RID: 29761 RVA: 0x0024DA48 File Offset: 0x0024BC48
		public int RuleList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06007442 RID: 29762 RVA: 0x0024DA88 File Offset: 0x0024BC88
		public int RuleListLength
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

		// Token: 0x06007443 RID: 29763 RVA: 0x0024DAB4 File Offset: 0x0024BCB4
		public Span<int> GetRuleListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06007444 RID: 29764 RVA: 0x0024DAC4 File Offset: 0x0024BCC4
		public int[] GetRuleListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x06007445 RID: 29765 RVA: 0x0024DADC File Offset: 0x0024BCDC
		public bool IsSupportSelectAll
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x06007446 RID: 29766 RVA: 0x0024DB1C File Offset: 0x0024BD1C
		public bool IsSelectAllUnion
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x06007447 RID: 29767 RVA: 0x0024DB5C File Offset: 0x0024BD5C
		public bool IsShowIcon
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06007448 RID: 29768 RVA: 0x0024DB9C File Offset: 0x0024BD9C
		public string GridType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007449 RID: 29769 RVA: 0x0024DBD4 File Offset: 0x0024BDD4
		public Span<byte> GetGridTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600744A RID: 29770 RVA: 0x0024DBE4 File Offset: 0x0024BDE4
		public byte[] GetGridTypeArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600744B RID: 29771 RVA: 0x0024DBFC File Offset: 0x0024BDFC
		[NullableContext(1)]
		public int[] RuleList()
		{
			return this.GetRuleListArray();
		}

		// Token: 0x0600744C RID: 29772 RVA: 0x0024DC04 File Offset: 0x0024BE04
		[NullableContext(1)]
		public IEnumerable<int> RuleListIter()
		{
			Filter.<RuleListIter>d__30 <RuleListIter>d__ = new Filter.<RuleListIter>d__30(-2);
			<RuleListIter>d__.<>3__<>4__this = this;
			return <RuleListIter>d__;
		}

		// Token: 0x0400529C RID: 21148
		private Table __p;
	}
}
