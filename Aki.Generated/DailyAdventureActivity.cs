using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB0 RID: 2992
	public struct DailyAdventureActivity : IFlatbufferObject
	{
		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06005AD0 RID: 23248 RVA: 0x00202CAF File Offset: 0x00200EAF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x00202CBC File Offset: 0x00200EBC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x00202CC4 File Offset: 0x00200EC4
		public static DailyAdventureActivity GetRootAsDailyAdventureActivity(ByteBuffer _bb)
		{
			return DailyAdventureActivity.GetRootAsDailyAdventureActivity(_bb, default(DailyAdventureActivity));
		}

		// Token: 0x06005AD3 RID: 23251 RVA: 0x00202CE0 File Offset: 0x00200EE0
		public static DailyAdventureActivity GetRootAsDailyAdventureActivity(ByteBuffer _bb, DailyAdventureActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x00202CFD File Offset: 0x00200EFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005AD5 RID: 23253 RVA: 0x00202D0C File Offset: 0x00200F0C
		public DailyAdventureActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06005AD6 RID: 23254 RVA: 0x00202D1C File Offset: 0x00200F1C
		public int ActivityId
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

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06005AD7 RID: 23255 RVA: 0x00202D58 File Offset: 0x00200F58
		public string AreaTitle
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

		// Token: 0x06005AD8 RID: 23256 RVA: 0x00202D8F File Offset: 0x00200F8F
		public Span<byte> GetAreaTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005AD9 RID: 23257 RVA: 0x00202D9E File Offset: 0x00200F9E
		public byte[] GetAreaTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06005ADA RID: 23258 RVA: 0x00202DB8 File Offset: 0x00200FB8
		public string AreaDescription
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

		// Token: 0x06005ADB RID: 23259 RVA: 0x00202DEF File Offset: 0x00200FEF
		public Span<byte> GetAreaDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x00202DFE File Offset: 0x00200FFE
		public byte[] GetAreaDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06005ADD RID: 23261 RVA: 0x00202E18 File Offset: 0x00201018
		public string AreaPic
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

		// Token: 0x06005ADE RID: 23262 RVA: 0x00202E50 File Offset: 0x00201050
		public Span<byte> GetAreaPicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005ADF RID: 23263 RVA: 0x00202E60 File Offset: 0x00201060
		public byte[] GetAreaPicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06005AE0 RID: 23264 RVA: 0x00202E78 File Offset: 0x00201078
		public int AreaDefaultMarkId
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

		// Token: 0x06005AE1 RID: 23265 RVA: 0x00202EB8 File Offset: 0x002010B8
		public int TaskList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06005AE2 RID: 23266 RVA: 0x00202EF8 File Offset: 0x002010F8
		public int TaskListLength
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

		// Token: 0x06005AE3 RID: 23267 RVA: 0x00202F24 File Offset: 0x00201124
		public Span<int> GetTaskListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x00202F34 File Offset: 0x00201134
		public int[] GetTaskListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06005AE5 RID: 23269 RVA: 0x00202F4C File Offset: 0x0020114C
		public int RewardList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06005AE6 RID: 23270 RVA: 0x00202F8C File Offset: 0x0020118C
		public int RewardListLength
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

		// Token: 0x06005AE7 RID: 23271 RVA: 0x00202FB8 File Offset: 0x002011B8
		public Span<int> GetRewardListBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x00202FC8 File Offset: 0x002011C8
		public int[] GetRewardListArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06005AE9 RID: 23273 RVA: 0x00202FE0 File Offset: 0x002011E0
		public int TaskRefreshNum
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005AEA RID: 23274 RVA: 0x00203020 File Offset: 0x00201220
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RewardListIter()或GetRewardListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RewardList()
		{
			DailyAdventureActivity dailyAdventureActivity = this;
			return dailyAdventureActivity.GetRewardListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005AEB RID: 23275 RVA: 0x00203044 File Offset: 0x00201244
		[NullableContext(1)]
		public readonly IEnumerable<int> RewardListIter()
		{
			DailyAdventureActivity.<RewardListIter>d__37 <RewardListIter>d__ = new DailyAdventureActivity.<RewardListIter>d__37(-2);
			<RewardListIter>d__.<>3__<>4__this = this;
			return <RewardListIter>d__;
		}

		// Token: 0x06005AEC RID: 23276 RVA: 0x0020305C File Offset: 0x0020125C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TaskListIter()或GetTaskListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TaskList()
		{
			DailyAdventureActivity dailyAdventureActivity = this;
			return dailyAdventureActivity.GetTaskListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005AED RID: 23277 RVA: 0x00203080 File Offset: 0x00201280
		[NullableContext(1)]
		public readonly IEnumerable<int> TaskListIter()
		{
			DailyAdventureActivity.<TaskListIter>d__39 <TaskListIter>d__ = new DailyAdventureActivity.<TaskListIter>d__39(-2);
			<TaskListIter>d__.<>3__<>4__this = this;
			return <TaskListIter>d__;
		}

		// Token: 0x04004BD3 RID: 19411
		private Table __p;
	}
}
