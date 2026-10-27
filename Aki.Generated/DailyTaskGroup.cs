using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB5 RID: 2997
	public struct DailyTaskGroup : IFlatbufferObject
	{
		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06005B1D RID: 23325 RVA: 0x002036A0 File Offset: 0x002018A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005B1E RID: 23326 RVA: 0x002036AD File Offset: 0x002018AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005B1F RID: 23327 RVA: 0x002036B4 File Offset: 0x002018B4
		public static DailyTaskGroup GetRootAsDailyTaskGroup(ByteBuffer _bb)
		{
			return DailyTaskGroup.GetRootAsDailyTaskGroup(_bb, default(DailyTaskGroup));
		}

		// Token: 0x06005B20 RID: 23328 RVA: 0x002036D0 File Offset: 0x002018D0
		public static DailyTaskGroup GetRootAsDailyTaskGroup(ByteBuffer _bb, DailyTaskGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005B21 RID: 23329 RVA: 0x002036ED File Offset: 0x002018ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005B22 RID: 23330 RVA: 0x002036FC File Offset: 0x002018FC
		public DailyTaskGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06005B23 RID: 23331 RVA: 0x0020370C File Offset: 0x0020190C
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

		// Token: 0x06005B24 RID: 23332 RVA: 0x00203748 File Offset: 0x00201948
		public int TaskIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06005B25 RID: 23333 RVA: 0x00203788 File Offset: 0x00201988
		public int TaskIdsLength
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

		// Token: 0x06005B26 RID: 23334 RVA: 0x002037B3 File Offset: 0x002019B3
		public Span<int> GetTaskIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06005B27 RID: 23335 RVA: 0x002037C2 File Offset: 0x002019C2
		public int[] GetTaskIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06005B28 RID: 23336 RVA: 0x002037DC File Offset: 0x002019DC
		public int TypeId
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

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06005B29 RID: 23337 RVA: 0x00203818 File Offset: 0x00201A18
		public int CountryId
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

		// Token: 0x06005B2A RID: 23338 RVA: 0x00203858 File Offset: 0x00201A58
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TaskIdsIter()或GetTaskIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TaskIds()
		{
			DailyTaskGroup dailyTaskGroup = this;
			return dailyTaskGroup.GetTaskIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005B2B RID: 23339 RVA: 0x0020387C File Offset: 0x00201A7C
		[NullableContext(1)]
		public readonly IEnumerable<int> TaskIdsIter()
		{
			DailyTaskGroup.<TaskIdsIter>d__20 <TaskIdsIter>d__ = new DailyTaskGroup.<TaskIdsIter>d__20(-2);
			<TaskIdsIter>d__.<>3__<>4__this = this;
			return <TaskIdsIter>d__;
		}

		// Token: 0x04004BD9 RID: 19417
		private Table __p;
	}
}
