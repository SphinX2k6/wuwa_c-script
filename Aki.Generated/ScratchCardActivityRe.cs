using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200118A RID: 4490
	public struct ScratchCardActivityRe : IFlatbufferObject
	{
		// Token: 0x17003602 RID: 13826
		// (get) Token: 0x0600D782 RID: 55170 RVA: 0x0032990C File Offset: 0x00327B0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D783 RID: 55171 RVA: 0x00329919 File Offset: 0x00327B19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D784 RID: 55172 RVA: 0x00329920 File Offset: 0x00327B20
		public static ScratchCardActivityRe GetRootAsScratchCardActivityRe(ByteBuffer _bb)
		{
			return ScratchCardActivityRe.GetRootAsScratchCardActivityRe(_bb, default(ScratchCardActivityRe));
		}

		// Token: 0x0600D785 RID: 55173 RVA: 0x0032993C File Offset: 0x00327B3C
		public static ScratchCardActivityRe GetRootAsScratchCardActivityRe(ByteBuffer _bb, ScratchCardActivityRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D786 RID: 55174 RVA: 0x00329959 File Offset: 0x00327B59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D787 RID: 55175 RVA: 0x00329968 File Offset: 0x00327B68
		public ScratchCardActivityRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003603 RID: 13827
		// (get) Token: 0x0600D788 RID: 55176 RVA: 0x00329978 File Offset: 0x00327B78
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

		// Token: 0x17003604 RID: 13828
		// (get) Token: 0x0600D789 RID: 55177 RVA: 0x003299B4 File Offset: 0x00327BB4
		public int ItemId
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

		// Token: 0x0600D78A RID: 55178 RVA: 0x003299F0 File Offset: 0x00327BF0
		public int TaskIdList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003605 RID: 13829
		// (get) Token: 0x0600D78B RID: 55179 RVA: 0x00329A30 File Offset: 0x00327C30
		public int TaskIdListLength
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

		// Token: 0x0600D78C RID: 55180 RVA: 0x00329A5B File Offset: 0x00327C5B
		public Span<int> GetTaskIdListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600D78D RID: 55181 RVA: 0x00329A6A File Offset: 0x00327C6A
		public int[] GetTaskIdListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17003606 RID: 13830
		// (get) Token: 0x0600D78E RID: 55182 RVA: 0x00329A84 File Offset: 0x00327C84
		public int JumpId
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

		// Token: 0x0600D78F RID: 55183 RVA: 0x00329AC1 File Offset: 0x00327CC1
		[NullableContext(1)]
		public int[] TaskIdList()
		{
			return this.GetTaskIdListArray();
		}

		// Token: 0x0600D790 RID: 55184 RVA: 0x00329AC9 File Offset: 0x00327CC9
		[NullableContext(1)]
		public IEnumerable<int> TaskIdListIter()
		{
			ScratchCardActivityRe.<TaskIdListIter>d__20 <TaskIdListIter>d__ = new ScratchCardActivityRe.<TaskIdListIter>d__20(-2);
			<TaskIdListIter>d__.<>3__<>4__this = this;
			return <TaskIdListIter>d__;
		}

		// Token: 0x0400579B RID: 22427
		private Table __p;
	}
}
