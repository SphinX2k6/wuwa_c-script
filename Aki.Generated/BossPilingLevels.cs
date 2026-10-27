using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B41 RID: 2881
	public struct BossPilingLevels : IFlatbufferObject
	{
		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06004E64 RID: 20068 RVA: 0x001E5FBA File Offset: 0x001E41BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004E65 RID: 20069 RVA: 0x001E5FC7 File Offset: 0x001E41C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004E66 RID: 20070 RVA: 0x001E5FD0 File Offset: 0x001E41D0
		public static BossPilingLevels GetRootAsBossPilingLevels(ByteBuffer _bb)
		{
			return BossPilingLevels.GetRootAsBossPilingLevels(_bb, default(BossPilingLevels));
		}

		// Token: 0x06004E67 RID: 20071 RVA: 0x001E5FEC File Offset: 0x001E41EC
		public static BossPilingLevels GetRootAsBossPilingLevels(ByteBuffer _bb, BossPilingLevels obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004E68 RID: 20072 RVA: 0x001E6009 File Offset: 0x001E4209
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004E69 RID: 20073 RVA: 0x001E6018 File Offset: 0x001E4218
		public BossPilingLevels __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06004E6A RID: 20074 RVA: 0x001E6028 File Offset: 0x001E4228
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

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06004E6B RID: 20075 RVA: 0x001E6064 File Offset: 0x001E4264
		public int ActivityId
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

		// Token: 0x06004E6C RID: 20076 RVA: 0x001E60A0 File Offset: 0x001E42A0
		public int InstIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06004E6D RID: 20077 RVA: 0x001E60E0 File Offset: 0x001E42E0
		public int InstIdsLength
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

		// Token: 0x06004E6E RID: 20078 RVA: 0x001E610B File Offset: 0x001E430B
		public Span<int> GetInstIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06004E6F RID: 20079 RVA: 0x001E611A File Offset: 0x001E431A
		public int[] GetInstIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x001E6134 File Offset: 0x001E4334
		public int RareBuffGroup(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06004E71 RID: 20081 RVA: 0x001E6174 File Offset: 0x001E4374
		public int RareBuffGroupLength
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

		// Token: 0x06004E72 RID: 20082 RVA: 0x001E61A0 File Offset: 0x001E43A0
		public Span<int> GetRareBuffGroupBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06004E73 RID: 20083 RVA: 0x001E61B0 File Offset: 0x001E43B0
		public int[] GetRareBuffGroupArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06004E74 RID: 20084 RVA: 0x001E61C8 File Offset: 0x001E43C8
		public int BuffGroup(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06004E75 RID: 20085 RVA: 0x001E6208 File Offset: 0x001E4408
		public int BuffGroupLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x001E6234 File Offset: 0x001E4434
		public Span<int> GetBuffGroupBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06004E77 RID: 20087 RVA: 0x001E6244 File Offset: 0x001E4444
		public int[] GetBuffGroupArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06004E78 RID: 20088 RVA: 0x001E625C File Offset: 0x001E445C
		public int BuffShow(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06004E79 RID: 20089 RVA: 0x001E629C File Offset: 0x001E449C
		public int BuffShowLength
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

		// Token: 0x06004E7A RID: 20090 RVA: 0x001E62C8 File Offset: 0x001E44C8
		public Span<int> GetBuffShowBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06004E7B RID: 20091 RVA: 0x001E62D8 File Offset: 0x001E44D8
		public int[] GetBuffShowArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06004E7C RID: 20092 RVA: 0x001E62F0 File Offset: 0x001E44F0
		public int RecommendFetter(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06004E7D RID: 20093 RVA: 0x001E6330 File Offset: 0x001E4530
		public int RecommendFetterLength
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

		// Token: 0x06004E7E RID: 20094 RVA: 0x001E635C File Offset: 0x001E455C
		public Span<int> GetRecommendFetterBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06004E7F RID: 20095 RVA: 0x001E636C File Offset: 0x001E456C
		public int[] GetRecommendFetterArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06004E80 RID: 20096 RVA: 0x001E6384 File Offset: 0x001E4584
		public int RecommendLevel
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004E81 RID: 20097 RVA: 0x001E63C4 File Offset: 0x001E45C4
		public int Achievement(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06004E82 RID: 20098 RVA: 0x001E6404 File Offset: 0x001E4604
		public int AchievementLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004E83 RID: 20099 RVA: 0x001E6430 File Offset: 0x001E4630
		public Span<int> GetAchievementBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06004E84 RID: 20100 RVA: 0x001E6440 File Offset: 0x001E4640
		public int[] GetAchievementArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06004E85 RID: 20101 RVA: 0x001E6458 File Offset: 0x001E4658
		public string LevelName
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004E86 RID: 20102 RVA: 0x001E6490 File Offset: 0x001E4690
		public Span<byte> GetLevelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004E87 RID: 20103 RVA: 0x001E64A0 File Offset: 0x001E46A0
		public byte[] GetLevelNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06004E88 RID: 20104 RVA: 0x001E64B8 File Offset: 0x001E46B8
		public string Bg
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

		// Token: 0x06004E89 RID: 20105 RVA: 0x001E64F0 File Offset: 0x001E46F0
		public Span<byte> GetBgBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06004E8A RID: 20106 RVA: 0x001E6500 File Offset: 0x001E4700
		public byte[] GetBgArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06004E8B RID: 20107 RVA: 0x001E6518 File Offset: 0x001E4718
		public string ToggleLock
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004E8C RID: 20108 RVA: 0x001E6550 File Offset: 0x001E4750
		public Span<byte> GetToggleLockBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06004E8D RID: 20109 RVA: 0x001E6560 File Offset: 0x001E4760
		public byte[] GetToggleLockArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06004E8E RID: 20110 RVA: 0x001E6578 File Offset: 0x001E4778
		public string ToggleUnlock
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004E8F RID: 20111 RVA: 0x001E65B0 File Offset: 0x001E47B0
		public Span<byte> GetToggleUnlockBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06004E90 RID: 20112 RVA: 0x001E65C0 File Offset: 0x001E47C0
		public byte[] GetToggleUnlockArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06004E91 RID: 20113 RVA: 0x001E65D8 File Offset: 0x001E47D8
		public string TaskIndexTex
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004E92 RID: 20114 RVA: 0x001E6610 File Offset: 0x001E4810
		public Span<byte> GetTaskIndexTexBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06004E93 RID: 20115 RVA: 0x001E6620 File Offset: 0x001E4820
		public byte[] GetTaskIndexTexArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06004E94 RID: 20116 RVA: 0x001E6638 File Offset: 0x001E4838
		public string LevelMechanism1
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x001E6670 File Offset: 0x001E4870
		public Span<byte> GetLevelMechanism1Bytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x001E6680 File Offset: 0x001E4880
		public byte[] GetLevelMechanism1Array()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06004E97 RID: 20119 RVA: 0x001E6698 File Offset: 0x001E4898
		public string LevelMechanism2
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004E98 RID: 20120 RVA: 0x001E66D0 File Offset: 0x001E48D0
		public Span<byte> GetLevelMechanism2Bytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06004E99 RID: 20121 RVA: 0x001E66E0 File Offset: 0x001E48E0
		public byte[] GetLevelMechanism2Array()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06004E9A RID: 20122 RVA: 0x001E66F8 File Offset: 0x001E48F8
		public string LevelMonsterDesc1
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004E9B RID: 20123 RVA: 0x001E6730 File Offset: 0x001E4930
		public Span<byte> GetLevelMonsterDesc1Bytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06004E9C RID: 20124 RVA: 0x001E6740 File Offset: 0x001E4940
		public byte[] GetLevelMonsterDesc1Array()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06004E9D RID: 20125 RVA: 0x001E6758 File Offset: 0x001E4958
		public string LevelDesc1
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004E9E RID: 20126 RVA: 0x001E6790 File Offset: 0x001E4990
		public Span<byte> GetLevelDesc1Bytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06004E9F RID: 20127 RVA: 0x001E67A0 File Offset: 0x001E49A0
		public byte[] GetLevelDesc1Array()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06004EA0 RID: 20128 RVA: 0x001E67B8 File Offset: 0x001E49B8
		public string LevelMonsterDesc2
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004EA1 RID: 20129 RVA: 0x001E67F0 File Offset: 0x001E49F0
		public Span<byte> GetLevelMonsterDesc2Bytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x001E6800 File Offset: 0x001E4A00
		public byte[] GetLevelMonsterDesc2Array()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06004EA3 RID: 20131 RVA: 0x001E6818 File Offset: 0x001E4A18
		public string LevelDesc2
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x001E6850 File Offset: 0x001E4A50
		public Span<byte> GetLevelDesc2Bytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06004EA5 RID: 20133 RVA: 0x001E6860 File Offset: 0x001E4A60
		public byte[] GetLevelDesc2Array()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x06004EA6 RID: 20134 RVA: 0x001E6878 File Offset: 0x001E4A78
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AchievementIter()或GetAchievementBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Achievement()
		{
			BossPilingLevels bossPilingLevels = this;
			return bossPilingLevels.GetAchievementArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004EA7 RID: 20135 RVA: 0x001E689C File Offset: 0x001E4A9C
		[NullableContext(1)]
		public readonly IEnumerable<int> AchievementIter()
		{
			BossPilingLevels.<AchievementIter>d__89 <AchievementIter>d__ = new BossPilingLevels.<AchievementIter>d__89(-2);
			<AchievementIter>d__.<>3__<>4__this = this;
			return <AchievementIter>d__;
		}

		// Token: 0x06004EA8 RID: 20136 RVA: 0x001E68B4 File Offset: 0x001E4AB4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffGroupIter()或GetBuffGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BuffGroup()
		{
			BossPilingLevels bossPilingLevels = this;
			return bossPilingLevels.GetBuffGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004EA9 RID: 20137 RVA: 0x001E68D8 File Offset: 0x001E4AD8
		[NullableContext(1)]
		public readonly IEnumerable<int> BuffGroupIter()
		{
			BossPilingLevels.<BuffGroupIter>d__91 <BuffGroupIter>d__ = new BossPilingLevels.<BuffGroupIter>d__91(-2);
			<BuffGroupIter>d__.<>3__<>4__this = this;
			return <BuffGroupIter>d__;
		}

		// Token: 0x06004EAA RID: 20138 RVA: 0x001E68F0 File Offset: 0x001E4AF0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffShowIter()或GetBuffShowBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BuffShow()
		{
			BossPilingLevels bossPilingLevels = this;
			return bossPilingLevels.GetBuffShowArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004EAB RID: 20139 RVA: 0x001E6914 File Offset: 0x001E4B14
		[NullableContext(1)]
		public readonly IEnumerable<int> BuffShowIter()
		{
			BossPilingLevels.<BuffShowIter>d__93 <BuffShowIter>d__ = new BossPilingLevels.<BuffShowIter>d__93(-2);
			<BuffShowIter>d__.<>3__<>4__this = this;
			return <BuffShowIter>d__;
		}

		// Token: 0x06004EAC RID: 20140 RVA: 0x001E692C File Offset: 0x001E4B2C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InstIdsIter()或GetInstIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InstIds()
		{
			BossPilingLevels bossPilingLevels = this;
			return bossPilingLevels.GetInstIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004EAD RID: 20141 RVA: 0x001E6950 File Offset: 0x001E4B50
		[NullableContext(1)]
		public readonly IEnumerable<int> InstIdsIter()
		{
			BossPilingLevels.<InstIdsIter>d__95 <InstIdsIter>d__ = new BossPilingLevels.<InstIdsIter>d__95(-2);
			<InstIdsIter>d__.<>3__<>4__this = this;
			return <InstIdsIter>d__;
		}

		// Token: 0x06004EAE RID: 20142 RVA: 0x001E6968 File Offset: 0x001E4B68
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RareBuffGroupIter()或GetRareBuffGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RareBuffGroup()
		{
			BossPilingLevels bossPilingLevels = this;
			return bossPilingLevels.GetRareBuffGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004EAF RID: 20143 RVA: 0x001E698C File Offset: 0x001E4B8C
		[NullableContext(1)]
		public readonly IEnumerable<int> RareBuffGroupIter()
		{
			BossPilingLevels.<RareBuffGroupIter>d__97 <RareBuffGroupIter>d__ = new BossPilingLevels.<RareBuffGroupIter>d__97(-2);
			<RareBuffGroupIter>d__.<>3__<>4__this = this;
			return <RareBuffGroupIter>d__;
		}

		// Token: 0x06004EB0 RID: 20144 RVA: 0x001E69A4 File Offset: 0x001E4BA4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendFetterIter()或GetRecommendFetterBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendFetter()
		{
			BossPilingLevels bossPilingLevels = this;
			return bossPilingLevels.GetRecommendFetterArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004EB1 RID: 20145 RVA: 0x001E69C8 File Offset: 0x001E4BC8
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendFetterIter()
		{
			BossPilingLevels.<RecommendFetterIter>d__99 <RecommendFetterIter>d__ = new BossPilingLevels.<RecommendFetterIter>d__99(-2);
			<RecommendFetterIter>d__.<>3__<>4__this = this;
			return <RecommendFetterIter>d__;
		}

		// Token: 0x04004B3C RID: 19260
		private Table __p;
	}
}
