using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA0 RID: 4000
	public struct RecallFunction : IFlatbufferObject
	{
		// Token: 0x17002D4E RID: 11598
		// (get) Token: 0x0600B9E9 RID: 47593 RVA: 0x002D975D File Offset: 0x002D795D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B9EA RID: 47594 RVA: 0x002D976A File Offset: 0x002D796A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B9EB RID: 47595 RVA: 0x002D9774 File Offset: 0x002D7974
		public static RecallFunction GetRootAsRecallFunction(ByteBuffer _bb)
		{
			return RecallFunction.GetRootAsRecallFunction(_bb, default(RecallFunction));
		}

		// Token: 0x0600B9EC RID: 47596 RVA: 0x002D9790 File Offset: 0x002D7990
		public static RecallFunction GetRootAsRecallFunction(ByteBuffer _bb, RecallFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B9ED RID: 47597 RVA: 0x002D97AD File Offset: 0x002D79AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B9EE RID: 47598 RVA: 0x002D97BC File Offset: 0x002D79BC
		public RecallFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D4F RID: 11599
		// (get) Token: 0x0600B9EF RID: 47599 RVA: 0x002D97CC File Offset: 0x002D79CC
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

		// Token: 0x17002D50 RID: 11600
		// (get) Token: 0x0600B9F0 RID: 47600 RVA: 0x002D9808 File Offset: 0x002D7A08
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

		// Token: 0x17002D51 RID: 11601
		// (get) Token: 0x0600B9F1 RID: 47601 RVA: 0x002D9844 File Offset: 0x002D7A44
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

		// Token: 0x0600B9F2 RID: 47602 RVA: 0x002D987B File Offset: 0x002D7A7B
		public Span<byte> GetFunctionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B9F3 RID: 47603 RVA: 0x002D988A File Offset: 0x002D7A8A
		public byte[] GetFunctionNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D52 RID: 11602
		// (get) Token: 0x0600B9F4 RID: 47604 RVA: 0x002D98A4 File Offset: 0x002D7AA4
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

		// Token: 0x0600B9F5 RID: 47605 RVA: 0x002D98DC File Offset: 0x002D7ADC
		public Span<byte> GetFunctionIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B9F6 RID: 47606 RVA: 0x002D98EC File Offset: 0x002D7AEC
		public byte[] GetFunctionIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D53 RID: 11603
		// (get) Token: 0x0600B9F7 RID: 47607 RVA: 0x002D9904 File Offset: 0x002D7B04
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

		// Token: 0x0600B9F8 RID: 47608 RVA: 0x002D9944 File Offset: 0x002D7B44
		public int NeedFinishQuestIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D54 RID: 11604
		// (get) Token: 0x0600B9F9 RID: 47609 RVA: 0x002D9984 File Offset: 0x002D7B84
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

		// Token: 0x0600B9FA RID: 47610 RVA: 0x002D99B0 File Offset: 0x002D7BB0
		public Span<int> GetNeedFinishQuestIdsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600B9FB RID: 47611 RVA: 0x002D99C0 File Offset: 0x002D7BC0
		public int[] GetNeedFinishQuestIdsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600B9FC RID: 47612 RVA: 0x002D99D8 File Offset: 0x002D7BD8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NeedFinishQuestIdsIter()或GetNeedFinishQuestIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] NeedFinishQuestIds()
		{
			RecallFunction recallFunction = this;
			return recallFunction.GetNeedFinishQuestIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B9FD RID: 47613 RVA: 0x002D99FC File Offset: 0x002D7BFC
		[NullableContext(1)]
		public readonly IEnumerable<int> NeedFinishQuestIdsIter()
		{
			RecallFunction.<NeedFinishQuestIdsIter>d__28 <NeedFinishQuestIdsIter>d__ = new RecallFunction.<NeedFinishQuestIdsIter>d__28(-2);
			<NeedFinishQuestIdsIter>d__.<>3__<>4__this = this;
			return <NeedFinishQuestIdsIter>d__;
		}

		// Token: 0x04005073 RID: 20595
		private Table __p;
	}
}
