using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F7F RID: 3967
	public struct QuestType : IFlatbufferObject
	{
		// Token: 0x17002C47 RID: 11335
		// (get) Token: 0x0600B734 RID: 46900 RVA: 0x002D3305 File Offset: 0x002D1505
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B735 RID: 46901 RVA: 0x002D3312 File Offset: 0x002D1512
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B736 RID: 46902 RVA: 0x002D331C File Offset: 0x002D151C
		public static QuestType GetRootAsQuestType(ByteBuffer _bb)
		{
			return QuestType.GetRootAsQuestType(_bb, default(QuestType));
		}

		// Token: 0x0600B737 RID: 46903 RVA: 0x002D3338 File Offset: 0x002D1538
		public static QuestType GetRootAsQuestType(ByteBuffer _bb, QuestType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B738 RID: 46904 RVA: 0x002D3355 File Offset: 0x002D1555
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B739 RID: 46905 RVA: 0x002D3364 File Offset: 0x002D1564
		public QuestType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C48 RID: 11336
		// (get) Token: 0x0600B73A RID: 46906 RVA: 0x002D3374 File Offset: 0x002D1574
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

		// Token: 0x17002C49 RID: 11337
		// (get) Token: 0x0600B73B RID: 46907 RVA: 0x002D33B0 File Offset: 0x002D15B0
		public int MainId
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

		// Token: 0x17002C4A RID: 11338
		// (get) Token: 0x0600B73C RID: 46908 RVA: 0x002D33EC File Offset: 0x002D15EC
		public string QuestTypeName
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

		// Token: 0x0600B73D RID: 46909 RVA: 0x002D3423 File Offset: 0x002D1623
		public Span<byte> GetQuestTypeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B73E RID: 46910 RVA: 0x002D3432 File Offset: 0x002D1632
		public byte[] GetQuestTypeNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C4B RID: 11339
		// (get) Token: 0x0600B73F RID: 46911 RVA: 0x002D344C File Offset: 0x002D164C
		public bool IsShowInQuestPanel
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002C4C RID: 11340
		// (get) Token: 0x0600B740 RID: 46912 RVA: 0x002D348C File Offset: 0x002D168C
		public string TypeColor
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B741 RID: 46913 RVA: 0x002D34C4 File Offset: 0x002D16C4
		public Span<byte> GetTypeColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B742 RID: 46914 RVA: 0x002D34D4 File Offset: 0x002D16D4
		public byte[] GetTypeColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C4D RID: 11341
		// (get) Token: 0x0600B743 RID: 46915 RVA: 0x002D34EC File Offset: 0x002D16EC
		public string TextColor
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B744 RID: 46916 RVA: 0x002D3524 File Offset: 0x002D1724
		public Span<byte> GetTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B745 RID: 46917 RVA: 0x002D3534 File Offset: 0x002D1734
		public byte[] GetTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C4E RID: 11342
		// (get) Token: 0x0600B746 RID: 46918 RVA: 0x002D354C File Offset: 0x002D174C
		public bool NeedRedDot
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600B747 RID: 46919 RVA: 0x002D358C File Offset: 0x002D178C
		public int MapId(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C4F RID: 11343
		// (get) Token: 0x0600B748 RID: 46920 RVA: 0x002D35CC File Offset: 0x002D17CC
		public int MapIdLength
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

		// Token: 0x0600B749 RID: 46921 RVA: 0x002D35F8 File Offset: 0x002D17F8
		public Span<int> GetMapIdBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600B74A RID: 46922 RVA: 0x002D3608 File Offset: 0x002D1808
		public int[] GetMapIdArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17002C50 RID: 11344
		// (get) Token: 0x0600B74B RID: 46923 RVA: 0x002D3620 File Offset: 0x002D1820
		public int IsHide
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B74C RID: 46924 RVA: 0x002D3660 File Offset: 0x002D1860
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MapIdIter()或GetMapIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MapId()
		{
			QuestType questType = this;
			return questType.GetMapIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B74D RID: 46925 RVA: 0x002D3684 File Offset: 0x002D1884
		[NullableContext(1)]
		public readonly IEnumerable<int> MapIdIter()
		{
			QuestType.<MapIdIter>d__36 <MapIdIter>d__ = new QuestType.<MapIdIter>d__36(-2);
			<MapIdIter>d__.<>3__<>4__this = this;
			return <MapIdIter>d__;
		}

		// Token: 0x0400504D RID: 20557
		private Table __p;
	}
}
