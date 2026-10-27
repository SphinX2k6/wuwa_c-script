using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E23 RID: 3619
	public struct MoraleArea : IFlatbufferObject
	{
		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x060095DC RID: 38364 RVA: 0x00289381 File Offset: 0x00287581
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060095DD RID: 38365 RVA: 0x0028938E File Offset: 0x0028758E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060095DE RID: 38366 RVA: 0x00289398 File Offset: 0x00287598
		public static MoraleArea GetRootAsMoraleArea(ByteBuffer _bb)
		{
			return MoraleArea.GetRootAsMoraleArea(_bb, default(MoraleArea));
		}

		// Token: 0x060095DF RID: 38367 RVA: 0x002893B4 File Offset: 0x002875B4
		public static MoraleArea GetRootAsMoraleArea(ByteBuffer _bb, MoraleArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060095E0 RID: 38368 RVA: 0x002893D1 File Offset: 0x002875D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060095E1 RID: 38369 RVA: 0x002893E0 File Offset: 0x002875E0
		public MoraleArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FBF RID: 8127
		// (get) Token: 0x060095E2 RID: 38370 RVA: 0x002893F0 File Offset: 0x002875F0
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

		// Token: 0x060095E3 RID: 38371 RVA: 0x0028942C File Offset: 0x0028762C
		public int ExploreBox(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x060095E4 RID: 38372 RVA: 0x0028946C File Offset: 0x0028766C
		public int ExploreBoxLength
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

		// Token: 0x060095E5 RID: 38373 RVA: 0x00289497 File Offset: 0x00287697
		public Span<int> GetExploreBoxBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060095E6 RID: 38374 RVA: 0x002894A6 File Offset: 0x002876A6
		public int[] GetExploreBoxArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x060095E7 RID: 38375 RVA: 0x002894C0 File Offset: 0x002876C0
		public string Name
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

		// Token: 0x060095E8 RID: 38376 RVA: 0x002894F7 File Offset: 0x002876F7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060095E9 RID: 38377 RVA: 0x00289506 File Offset: 0x00287706
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x060095EA RID: 38378 RVA: 0x00289520 File Offset: 0x00287720
		public int PlotIdList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x060095EB RID: 38379 RVA: 0x00289560 File Offset: 0x00287760
		public int PlotIdListLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060095EC RID: 38380 RVA: 0x0028958C File Offset: 0x0028778C
		public Span<int> GetPlotIdListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060095ED RID: 38381 RVA: 0x0028959C File Offset: 0x0028779C
		public int[] GetPlotIdListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001FC3 RID: 8131
		// (get) Token: 0x060095EE RID: 38382 RVA: 0x002895B4 File Offset: 0x002877B4
		public string DescBigBgPath
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

		// Token: 0x060095EF RID: 38383 RVA: 0x002895EC File Offset: 0x002877EC
		public Span<byte> GetDescBigBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060095F0 RID: 38384 RVA: 0x002895FC File Offset: 0x002877FC
		public byte[] GetDescBigBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x060095F1 RID: 38385 RVA: 0x00289614 File Offset: 0x00287814
		public string DescGridBgPath
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

		// Token: 0x060095F2 RID: 38386 RVA: 0x0028964C File Offset: 0x0028784C
		public Span<byte> GetDescGridBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060095F3 RID: 38387 RVA: 0x0028965C File Offset: 0x0028785C
		public byte[] GetDescGridBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x060095F4 RID: 38388 RVA: 0x00289674 File Offset: 0x00287874
		public int DescGridBgAddX
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

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x060095F5 RID: 38389 RVA: 0x002896B4 File Offset: 0x002878B4
		public string BuffLockDesc
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060095F6 RID: 38390 RVA: 0x002896EC File Offset: 0x002878EC
		public Span<byte> GetBuffLockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060095F7 RID: 38391 RVA: 0x002896FC File Offset: 0x002878FC
		public byte[] GetBuffLockDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x060095F8 RID: 38392 RVA: 0x00289714 File Offset: 0x00287914
		public string BuffActiveDesc
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060095F9 RID: 38393 RVA: 0x0028974C File Offset: 0x0028794C
		public Span<byte> GetBuffActiveDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060095FA RID: 38394 RVA: 0x0028975C File Offset: 0x0028795C
		public byte[] GetBuffActiveDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x060095FB RID: 38395 RVA: 0x00289774 File Offset: 0x00287974
		public int BuffId
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

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x060095FC RID: 38396 RVA: 0x002897B4 File Offset: 0x002879B4
		public string MonsterIconPath
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060095FD RID: 38397 RVA: 0x002897EC File Offset: 0x002879EC
		public Span<byte> GetMonsterIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060095FE RID: 38398 RVA: 0x002897FC File Offset: 0x002879FC
		public byte[] GetMonsterIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x060095FF RID: 38399 RVA: 0x00289814 File Offset: 0x00287A14
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExploreBoxIter()或GetExploreBoxBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ExploreBox()
		{
			MoraleArea moraleArea = this;
			return moraleArea.GetExploreBoxArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009600 RID: 38400 RVA: 0x00289838 File Offset: 0x00287A38
		[NullableContext(1)]
		public readonly IEnumerable<int> ExploreBoxIter()
		{
			MoraleArea.<ExploreBoxIter>d__49 <ExploreBoxIter>d__ = new MoraleArea.<ExploreBoxIter>d__49(-2);
			<ExploreBoxIter>d__.<>3__<>4__this = this;
			return <ExploreBoxIter>d__;
		}

		// Token: 0x06009601 RID: 38401 RVA: 0x00289850 File Offset: 0x00287A50
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PlotIdListIter()或GetPlotIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PlotIdList()
		{
			MoraleArea moraleArea = this;
			return moraleArea.GetPlotIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009602 RID: 38402 RVA: 0x00289874 File Offset: 0x00287A74
		[NullableContext(1)]
		public readonly IEnumerable<int> PlotIdListIter()
		{
			MoraleArea.<PlotIdListIter>d__51 <PlotIdListIter>d__ = new MoraleArea.<PlotIdListIter>d__51(-2);
			<PlotIdListIter>d__.<>3__<>4__this = this;
			return <PlotIdListIter>d__;
		}

		// Token: 0x04004EC8 RID: 20168
		private Table __p;
	}
}
