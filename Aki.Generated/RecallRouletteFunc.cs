using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001089 RID: 4233
	public struct RecallRouletteFunc : IFlatbufferObject
	{
		// Token: 0x17002DD1 RID: 11729
		// (get) Token: 0x0600C044 RID: 49220 RVA: 0x002F625C File Offset: 0x002F445C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C045 RID: 49221 RVA: 0x002F6269 File Offset: 0x002F4469
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C046 RID: 49222 RVA: 0x002F6270 File Offset: 0x002F4470
		public static RecallRouletteFunc GetRootAsRecallRouletteFunc(ByteBuffer _bb)
		{
			return RecallRouletteFunc.GetRootAsRecallRouletteFunc(_bb, default(RecallRouletteFunc));
		}

		// Token: 0x0600C047 RID: 49223 RVA: 0x002F628C File Offset: 0x002F448C
		public static RecallRouletteFunc GetRootAsRecallRouletteFunc(ByteBuffer _bb, RecallRouletteFunc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C048 RID: 49224 RVA: 0x002F62A9 File Offset: 0x002F44A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C049 RID: 49225 RVA: 0x002F62B8 File Offset: 0x002F44B8
		public RecallRouletteFunc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DD2 RID: 11730
		// (get) Token: 0x0600C04A RID: 49226 RVA: 0x002F62C8 File Offset: 0x002F44C8
		public int FunctionId
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

		// Token: 0x0600C04B RID: 49227 RVA: 0x002F6304 File Offset: 0x002F4504
		public int NeedFinishQuestIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DD3 RID: 11731
		// (get) Token: 0x0600C04C RID: 49228 RVA: 0x002F6344 File Offset: 0x002F4544
		public int NeedFinishQuestIdsLength
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

		// Token: 0x0600C04D RID: 49229 RVA: 0x002F636F File Offset: 0x002F456F
		public Span<int> GetNeedFinishQuestIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600C04E RID: 49230 RVA: 0x002F637E File Offset: 0x002F457E
		public int[] GetNeedFinishQuestIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600C04F RID: 49231 RVA: 0x002F6395 File Offset: 0x002F4595
		[NullableContext(1)]
		public int[] NeedFinishQuestIds()
		{
			return this.GetNeedFinishQuestIdsArray();
		}

		// Token: 0x0600C050 RID: 49232 RVA: 0x002F639D File Offset: 0x002F459D
		[NullableContext(1)]
		public IEnumerable<int> NeedFinishQuestIdsIter()
		{
			RecallRouletteFunc.<NeedFinishQuestIdsIter>d__16 <NeedFinishQuestIdsIter>d__ = new RecallRouletteFunc.<NeedFinishQuestIdsIter>d__16(-2);
			<NeedFinishQuestIdsIter>d__.<>3__<>4__this = this;
			return <NeedFinishQuestIdsIter>d__;
		}

		// Token: 0x0400565C RID: 22108
		private Table __p;
	}
}
