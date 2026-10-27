using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200108F RID: 4239
	public struct ScratchCardActivityRe : IFlatbufferObject
	{
		// Token: 0x170034F5 RID: 13557
		// (get) Token: 0x0600CFAF RID: 53167 RVA: 0x0030A318 File Offset: 0x00308518
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CFB0 RID: 53168 RVA: 0x0030A325 File Offset: 0x00308525
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CFB1 RID: 53169 RVA: 0x0030A32C File Offset: 0x0030852C
		public static ScratchCardActivityRe GetRootAsScratchCardActivityRe(ByteBuffer _bb)
		{
			return ScratchCardActivityRe.GetRootAsScratchCardActivityRe(_bb, default(ScratchCardActivityRe));
		}

		// Token: 0x0600CFB2 RID: 53170 RVA: 0x0030A348 File Offset: 0x00308548
		public static ScratchCardActivityRe GetRootAsScratchCardActivityRe(ByteBuffer _bb, ScratchCardActivityRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CFB3 RID: 53171 RVA: 0x0030A365 File Offset: 0x00308565
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CFB4 RID: 53172 RVA: 0x0030A374 File Offset: 0x00308574
		public ScratchCardActivityRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034F6 RID: 13558
		// (get) Token: 0x0600CFB5 RID: 53173 RVA: 0x0030A384 File Offset: 0x00308584
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

		// Token: 0x170034F7 RID: 13559
		// (get) Token: 0x0600CFB6 RID: 53174 RVA: 0x0030A3C0 File Offset: 0x003085C0
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

		// Token: 0x0600CFB7 RID: 53175 RVA: 0x0030A3FC File Offset: 0x003085FC
		public int TaskIdList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034F8 RID: 13560
		// (get) Token: 0x0600CFB8 RID: 53176 RVA: 0x0030A43C File Offset: 0x0030863C
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

		// Token: 0x0600CFB9 RID: 53177 RVA: 0x0030A467 File Offset: 0x00308667
		public Span<int> GetTaskIdListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600CFBA RID: 53178 RVA: 0x0030A476 File Offset: 0x00308676
		public int[] GetTaskIdListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170034F9 RID: 13561
		// (get) Token: 0x0600CFBB RID: 53179 RVA: 0x0030A490 File Offset: 0x00308690
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

		// Token: 0x0600CFBC RID: 53180 RVA: 0x0030A4D0 File Offset: 0x003086D0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TaskIdListIter()或GetTaskIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TaskIdList()
		{
			ScratchCardActivityRe scratchCardActivityRe = this;
			return scratchCardActivityRe.GetTaskIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CFBD RID: 53181 RVA: 0x0030A4F4 File Offset: 0x003086F4
		[NullableContext(1)]
		public readonly IEnumerable<int> TaskIdListIter()
		{
			ScratchCardActivityRe.<TaskIdListIter>d__20 <TaskIdListIter>d__ = new ScratchCardActivityRe.<TaskIdListIter>d__20(-2);
			<TaskIdListIter>d__.<>3__<>4__this = this;
			return <TaskIdListIter>d__;
		}

		// Token: 0x0400519C RID: 20892
		private Table __p;
	}
}
