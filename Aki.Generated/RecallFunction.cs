using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001087 RID: 4231
	public struct RecallFunction : IFlatbufferObject
	{
		// Token: 0x17002DC6 RID: 11718
		// (get) Token: 0x0600C026 RID: 49190 RVA: 0x002F5EA2 File Offset: 0x002F40A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C027 RID: 49191 RVA: 0x002F5EAF File Offset: 0x002F40AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C028 RID: 49192 RVA: 0x002F5EB8 File Offset: 0x002F40B8
		public static RecallFunction GetRootAsRecallFunction(ByteBuffer _bb)
		{
			return RecallFunction.GetRootAsRecallFunction(_bb, default(RecallFunction));
		}

		// Token: 0x0600C029 RID: 49193 RVA: 0x002F5ED4 File Offset: 0x002F40D4
		public static RecallFunction GetRootAsRecallFunction(ByteBuffer _bb, RecallFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C02A RID: 49194 RVA: 0x002F5EF1 File Offset: 0x002F40F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C02B RID: 49195 RVA: 0x002F5F00 File Offset: 0x002F4100
		public RecallFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DC7 RID: 11719
		// (get) Token: 0x0600C02C RID: 49196 RVA: 0x002F5F10 File Offset: 0x002F4110
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

		// Token: 0x17002DC8 RID: 11720
		// (get) Token: 0x0600C02D RID: 49197 RVA: 0x002F5F4C File Offset: 0x002F414C
		public int FunctionId
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

		// Token: 0x17002DC9 RID: 11721
		// (get) Token: 0x0600C02E RID: 49198 RVA: 0x002F5F88 File Offset: 0x002F4188
		public string FunctionName
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

		// Token: 0x0600C02F RID: 49199 RVA: 0x002F5FBF File Offset: 0x002F41BF
		public Span<byte> GetFunctionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C030 RID: 49200 RVA: 0x002F5FCE File Offset: 0x002F41CE
		public byte[] GetFunctionNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DCA RID: 11722
		// (get) Token: 0x0600C031 RID: 49201 RVA: 0x002F5FE8 File Offset: 0x002F41E8
		public string FunctionIcon
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

		// Token: 0x0600C032 RID: 49202 RVA: 0x002F6020 File Offset: 0x002F4220
		public Span<byte> GetFunctionIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C033 RID: 49203 RVA: 0x002F6030 File Offset: 0x002F4230
		public byte[] GetFunctionIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DCB RID: 11723
		// (get) Token: 0x0600C034 RID: 49204 RVA: 0x002F6048 File Offset: 0x002F4248
		public int Sort
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

		// Token: 0x0600C035 RID: 49205 RVA: 0x002F6088 File Offset: 0x002F4288
		public int NeedFinishQuestIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DCC RID: 11724
		// (get) Token: 0x0600C036 RID: 49206 RVA: 0x002F60C8 File Offset: 0x002F42C8
		public int NeedFinishQuestIdsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C037 RID: 49207 RVA: 0x002F60F4 File Offset: 0x002F42F4
		public Span<int> GetNeedFinishQuestIdsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600C038 RID: 49208 RVA: 0x002F6104 File Offset: 0x002F4304
		public int[] GetNeedFinishQuestIdsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600C039 RID: 49209 RVA: 0x002F611C File Offset: 0x002F431C
		[NullableContext(1)]
		public int[] NeedFinishQuestIds()
		{
			return this.GetNeedFinishQuestIdsArray();
		}

		// Token: 0x0600C03A RID: 49210 RVA: 0x002F6124 File Offset: 0x002F4324
		[NullableContext(1)]
		public IEnumerable<int> NeedFinishQuestIdsIter()
		{
			RecallFunction.<NeedFinishQuestIdsIter>d__28 <NeedFinishQuestIdsIter>d__ = new RecallFunction.<NeedFinishQuestIdsIter>d__28(-2);
			<NeedFinishQuestIdsIter>d__.<>3__<>4__this = this;
			return <NeedFinishQuestIdsIter>d__;
		}

		// Token: 0x0400565A RID: 22106
		private Table __p;
	}
}
