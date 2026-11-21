using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C6B RID: 3179
	public struct ComboTeachingCondition : IFlatbufferObject
	{
		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06005CDE RID: 23774 RVA: 0x00219C06 File Offset: 0x00217E06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005CDF RID: 23775 RVA: 0x00219C13 File Offset: 0x00217E13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005CE0 RID: 23776 RVA: 0x00219C1C File Offset: 0x00217E1C
		public static ComboTeachingCondition GetRootAsComboTeachingCondition(ByteBuffer _bb)
		{
			return ComboTeachingCondition.GetRootAsComboTeachingCondition(_bb, default(ComboTeachingCondition));
		}

		// Token: 0x06005CE1 RID: 23777 RVA: 0x00219C38 File Offset: 0x00217E38
		public static ComboTeachingCondition GetRootAsComboTeachingCondition(ByteBuffer _bb, ComboTeachingCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005CE2 RID: 23778 RVA: 0x00219C55 File Offset: 0x00217E55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005CE3 RID: 23779 RVA: 0x00219C64 File Offset: 0x00217E64
		public ComboTeachingCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06005CE4 RID: 23780 RVA: 0x00219C74 File Offset: 0x00217E74
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

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06005CE5 RID: 23781 RVA: 0x00219CB0 File Offset: 0x00217EB0
		public int CompleteCondition
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

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06005CE6 RID: 23782 RVA: 0x00219CEC File Offset: 0x00217EEC
		public int CompleteDelay
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

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06005CE7 RID: 23783 RVA: 0x00219D28 File Offset: 0x00217F28
		public string CompleteParam
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

		// Token: 0x06005CE8 RID: 23784 RVA: 0x00219D60 File Offset: 0x00217F60
		public Span<byte> GetCompleteParamBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005CE9 RID: 23785 RVA: 0x00219D70 File Offset: 0x00217F70
		public byte[] GetCompleteParamArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06005CEA RID: 23786 RVA: 0x00219D88 File Offset: 0x00217F88
		public int FailedCondition(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06005CEB RID: 23787 RVA: 0x00219DC8 File Offset: 0x00217FC8
		public int FailedConditionLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005CEC RID: 23788 RVA: 0x00219DF4 File Offset: 0x00217FF4
		public Span<int> GetFailedConditionBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06005CED RID: 23789 RVA: 0x00219E04 File Offset: 0x00218004
		public int[] GetFailedConditionArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06005CEE RID: 23790 RVA: 0x00219E1C File Offset: 0x0021801C
		public int FailDelay
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

		// Token: 0x06005CEF RID: 23791 RVA: 0x00219E5C File Offset: 0x0021805C
		public string FailedParam(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06005CF0 RID: 23792 RVA: 0x00219E98 File Offset: 0x00218098
		public int FailedParamLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005CF1 RID: 23793 RVA: 0x00219EC4 File Offset: 0x002180C4
		public int RemoveBuff(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06005CF2 RID: 23794 RVA: 0x00219F04 File Offset: 0x00218104
		public int RemoveBuffLength
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

		// Token: 0x06005CF3 RID: 23795 RVA: 0x00219F30 File Offset: 0x00218130
		public Span<int> GetRemoveBuffBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06005CF4 RID: 23796 RVA: 0x00219F40 File Offset: 0x00218140
		public int[] GetRemoveBuffArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06005CF5 RID: 23797 RVA: 0x00219F58 File Offset: 0x00218158
		public string RemoveBullet(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06005CF6 RID: 23798 RVA: 0x00219F94 File Offset: 0x00218194
		public int RemoveBulletLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06005CF7 RID: 23799 RVA: 0x00219FC0 File Offset: 0x002181C0
		public int SummonPos
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005CF8 RID: 23800 RVA: 0x0021A000 File Offset: 0x00218200
		public int SummonRemoveBuff(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06005CF9 RID: 23801 RVA: 0x0021A040 File Offset: 0x00218240
		public int SummonRemoveBuffLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005CFA RID: 23802 RVA: 0x0021A06C File Offset: 0x0021826C
		public Span<int> GetSummonRemoveBuffBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06005CFB RID: 23803 RVA: 0x0021A07C File Offset: 0x0021827C
		public int[] GetSummonRemoveBuffArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x06005CFC RID: 23804 RVA: 0x0021A094 File Offset: 0x00218294
		public int SummonAddBuff(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06005CFD RID: 23805 RVA: 0x0021A0D4 File Offset: 0x002182D4
		public int SummonAddBuffLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005CFE RID: 23806 RVA: 0x0021A100 File Offset: 0x00218300
		public Span<int> GetSummonAddBuffBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06005CFF RID: 23807 RVA: 0x0021A110 File Offset: 0x00218310
		public int[] GetSummonAddBuffArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x06005D00 RID: 23808 RVA: 0x0021A128 File Offset: 0x00218328
		[NullableContext(1)]
		public int[] FailedCondition()
		{
			return this.GetFailedConditionArray();
		}

		// Token: 0x06005D01 RID: 23809 RVA: 0x0021A130 File Offset: 0x00218330
		[NullableContext(1)]
		public IEnumerable<int> FailedConditionIter()
		{
			ComboTeachingCondition.<FailedConditionIter>d__49 <FailedConditionIter>d__ = new ComboTeachingCondition.<FailedConditionIter>d__49(-2);
			<FailedConditionIter>d__.<>3__<>4__this = this;
			return <FailedConditionIter>d__;
		}

		// Token: 0x06005D02 RID: 23810 RVA: 0x0021A145 File Offset: 0x00218345
		[NullableContext(1)]
		public string[] FailedParam()
		{
			return this.FailedParamIter().ToArray<string>();
		}

		// Token: 0x06005D03 RID: 23811 RVA: 0x0021A152 File Offset: 0x00218352
		[NullableContext(1)]
		public IEnumerable<string> FailedParamIter()
		{
			ComboTeachingCondition.<FailedParamIter>d__51 <FailedParamIter>d__ = new ComboTeachingCondition.<FailedParamIter>d__51(-2);
			<FailedParamIter>d__.<>3__<>4__this = this;
			return <FailedParamIter>d__;
		}

		// Token: 0x06005D04 RID: 23812 RVA: 0x0021A167 File Offset: 0x00218367
		[NullableContext(1)]
		public int[] RemoveBuff()
		{
			return this.GetRemoveBuffArray();
		}

		// Token: 0x06005D05 RID: 23813 RVA: 0x0021A16F File Offset: 0x0021836F
		[NullableContext(1)]
		public IEnumerable<int> RemoveBuffIter()
		{
			ComboTeachingCondition.<RemoveBuffIter>d__53 <RemoveBuffIter>d__ = new ComboTeachingCondition.<RemoveBuffIter>d__53(-2);
			<RemoveBuffIter>d__.<>3__<>4__this = this;
			return <RemoveBuffIter>d__;
		}

		// Token: 0x06005D06 RID: 23814 RVA: 0x0021A184 File Offset: 0x00218384
		[NullableContext(1)]
		public string[] RemoveBullet()
		{
			return this.RemoveBulletIter().ToArray<string>();
		}

		// Token: 0x06005D07 RID: 23815 RVA: 0x0021A191 File Offset: 0x00218391
		[NullableContext(1)]
		public IEnumerable<string> RemoveBulletIter()
		{
			ComboTeachingCondition.<RemoveBulletIter>d__55 <RemoveBulletIter>d__ = new ComboTeachingCondition.<RemoveBulletIter>d__55(-2);
			<RemoveBulletIter>d__.<>3__<>4__this = this;
			return <RemoveBulletIter>d__;
		}

		// Token: 0x06005D08 RID: 23816 RVA: 0x0021A1A6 File Offset: 0x002183A6
		[NullableContext(1)]
		public int[] SummonAddBuff()
		{
			return this.GetSummonAddBuffArray();
		}

		// Token: 0x06005D09 RID: 23817 RVA: 0x0021A1AE File Offset: 0x002183AE
		[NullableContext(1)]
		public IEnumerable<int> SummonAddBuffIter()
		{
			ComboTeachingCondition.<SummonAddBuffIter>d__57 <SummonAddBuffIter>d__ = new ComboTeachingCondition.<SummonAddBuffIter>d__57(-2);
			<SummonAddBuffIter>d__.<>3__<>4__this = this;
			return <SummonAddBuffIter>d__;
		}

		// Token: 0x06005D0A RID: 23818 RVA: 0x0021A1C3 File Offset: 0x002183C3
		[NullableContext(1)]
		public int[] SummonRemoveBuff()
		{
			return this.GetSummonRemoveBuffArray();
		}

		// Token: 0x06005D0B RID: 23819 RVA: 0x0021A1CB File Offset: 0x002183CB
		[NullableContext(1)]
		public IEnumerable<int> SummonRemoveBuffIter()
		{
			ComboTeachingCondition.<SummonRemoveBuffIter>d__59 <SummonRemoveBuffIter>d__ = new ComboTeachingCondition.<SummonRemoveBuffIter>d__59(-2);
			<SummonRemoveBuffIter>d__.<>3__<>4__this = this;
			return <SummonRemoveBuffIter>d__;
		}

		// Token: 0x0400517A RID: 20858
		private Table __p;
	}
}
