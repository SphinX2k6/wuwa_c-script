using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001092 RID: 4242
	public struct ScratchCardTimesRe : IFlatbufferObject
	{
		// Token: 0x17003508 RID: 13576
		// (get) Token: 0x0600CFE1 RID: 53217 RVA: 0x0030A9DD File Offset: 0x00308BDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CFE2 RID: 53218 RVA: 0x0030A9EA File Offset: 0x00308BEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CFE3 RID: 53219 RVA: 0x0030A9F4 File Offset: 0x00308BF4
		public static ScratchCardTimesRe GetRootAsScratchCardTimesRe(ByteBuffer _bb)
		{
			return ScratchCardTimesRe.GetRootAsScratchCardTimesRe(_bb, default(ScratchCardTimesRe));
		}

		// Token: 0x0600CFE4 RID: 53220 RVA: 0x0030AA10 File Offset: 0x00308C10
		public static ScratchCardTimesRe GetRootAsScratchCardTimesRe(ByteBuffer _bb, ScratchCardTimesRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CFE5 RID: 53221 RVA: 0x0030AA2D File Offset: 0x00308C2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CFE6 RID: 53222 RVA: 0x0030AA3C File Offset: 0x00308C3C
		public ScratchCardTimesRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003509 RID: 13577
		// (get) Token: 0x0600CFE7 RID: 53223 RVA: 0x0030AA4C File Offset: 0x00308C4C
		public int TaskId
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

		// Token: 0x1700350A RID: 13578
		// (get) Token: 0x0600CFE8 RID: 53224 RVA: 0x0030AA88 File Offset: 0x00308C88
		public string TaskName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CFE9 RID: 53225 RVA: 0x0030AABF File Offset: 0x00308CBF
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CFEA RID: 53226 RVA: 0x0030AACE File Offset: 0x00308CCE
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700350B RID: 13579
		// (get) Token: 0x0600CFEB RID: 53227 RVA: 0x0030AAE8 File Offset: 0x00308CE8
		public int TaskType
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

		// Token: 0x1700350C RID: 13580
		// (get) Token: 0x0600CFEC RID: 53228 RVA: 0x0030AB24 File Offset: 0x00308D24
		public string TaskTypeName
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

		// Token: 0x0600CFED RID: 53229 RVA: 0x0030AB5C File Offset: 0x00308D5C
		public Span<byte> GetTaskTypeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CFEE RID: 53230 RVA: 0x0030AB6C File Offset: 0x00308D6C
		public byte[] GetTaskTypeNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700350D RID: 13581
		// (get) Token: 0x0600CFEF RID: 53231 RVA: 0x0030AB84 File Offset: 0x00308D84
		public int TaskReward
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

		// Token: 0x0600CFF0 RID: 53232 RVA: 0x0030ABC4 File Offset: 0x00308DC4
		public int TaskParams(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700350E RID: 13582
		// (get) Token: 0x0600CFF1 RID: 53233 RVA: 0x0030AC04 File Offset: 0x00308E04
		public int TaskParamsLength
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

		// Token: 0x0600CFF2 RID: 53234 RVA: 0x0030AC30 File Offset: 0x00308E30
		public Span<int> GetTaskParamsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600CFF3 RID: 53235 RVA: 0x0030AC40 File Offset: 0x00308E40
		public int[] GetTaskParamsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x1700350F RID: 13583
		// (get) Token: 0x0600CFF4 RID: 53236 RVA: 0x0030AC58 File Offset: 0x00308E58
		public int RefreshTimesLimit
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

		// Token: 0x0600CFF5 RID: 53237 RVA: 0x0030AC98 File Offset: 0x00308E98
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TaskParamsIter()或GetTaskParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TaskParams()
		{
			ScratchCardTimesRe scratchCardTimesRe = this;
			return scratchCardTimesRe.GetTaskParamsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CFF6 RID: 53238 RVA: 0x0030ACBC File Offset: 0x00308EBC
		[NullableContext(1)]
		public readonly IEnumerable<int> TaskParamsIter()
		{
			ScratchCardTimesRe.<TaskParamsIter>d__30 <TaskParamsIter>d__ = new ScratchCardTimesRe.<TaskParamsIter>d__30(-2);
			<TaskParamsIter>d__.<>3__<>4__this = this;
			return <TaskParamsIter>d__;
		}

		// Token: 0x0400519F RID: 20895
		private Table __p;
	}
}
