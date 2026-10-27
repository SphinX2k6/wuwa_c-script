using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E72 RID: 3698
	public struct MowTowerLevelsRe : IFlatbufferObject
	{
		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x06009D11 RID: 40209 RVA: 0x0029954B File Offset: 0x0029774B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009D12 RID: 40210 RVA: 0x00299558 File Offset: 0x00297758
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009D13 RID: 40211 RVA: 0x00299560 File Offset: 0x00297760
		public static MowTowerLevelsRe GetRootAsMowTowerLevelsRe(ByteBuffer _bb)
		{
			return MowTowerLevelsRe.GetRootAsMowTowerLevelsRe(_bb, default(MowTowerLevelsRe));
		}

		// Token: 0x06009D14 RID: 40212 RVA: 0x0029957C File Offset: 0x0029777C
		public static MowTowerLevelsRe GetRootAsMowTowerLevelsRe(ByteBuffer _bb, MowTowerLevelsRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009D15 RID: 40213 RVA: 0x00299599 File Offset: 0x00297799
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009D16 RID: 40214 RVA: 0x002995A8 File Offset: 0x002977A8
		public MowTowerLevelsRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x06009D17 RID: 40215 RVA: 0x002995B8 File Offset: 0x002977B8
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

		// Token: 0x17002287 RID: 8839
		// (get) Token: 0x06009D18 RID: 40216 RVA: 0x002995F4 File Offset: 0x002977F4
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

		// Token: 0x17002288 RID: 8840
		// (get) Token: 0x06009D19 RID: 40217 RVA: 0x00299630 File Offset: 0x00297830
		public int GroupId
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

		// Token: 0x06009D1A RID: 40218 RVA: 0x0029966C File Offset: 0x0029786C
		public int InstIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002289 RID: 8841
		// (get) Token: 0x06009D1B RID: 40219 RVA: 0x002996AC File Offset: 0x002978AC
		public int InstIdsLength
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

		// Token: 0x06009D1C RID: 40220 RVA: 0x002996D8 File Offset: 0x002978D8
		public Span<int> GetInstIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009D1D RID: 40221 RVA: 0x002996E8 File Offset: 0x002978E8
		public int[] GetInstIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700228A RID: 8842
		// (get) Token: 0x06009D1E RID: 40222 RVA: 0x00299700 File Offset: 0x00297900
		public int SortId
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

		// Token: 0x1700228B RID: 8843
		// (get) Token: 0x06009D1F RID: 40223 RVA: 0x00299740 File Offset: 0x00297940
		public int BuffCount
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009D20 RID: 40224 RVA: 0x00299780 File Offset: 0x00297980
		public int OptionalBuff(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700228C RID: 8844
		// (get) Token: 0x06009D21 RID: 40225 RVA: 0x002997C0 File Offset: 0x002979C0
		public int OptionalBuffLength
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

		// Token: 0x06009D22 RID: 40226 RVA: 0x002997EC File Offset: 0x002979EC
		public Span<int> GetOptionalBuffBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06009D23 RID: 40227 RVA: 0x002997FC File Offset: 0x002979FC
		public int[] GetOptionalBuffArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x1700228D RID: 8845
		// (get) Token: 0x06009D24 RID: 40228 RVA: 0x00299814 File Offset: 0x00297A14
		public int OpenDay
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

		// Token: 0x1700228E RID: 8846
		// (get) Token: 0x06009D25 RID: 40229 RVA: 0x00299854 File Offset: 0x00297A54
		public int PreLevel
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

		// Token: 0x1700228F RID: 8847
		// (get) Token: 0x06009D26 RID: 40230 RVA: 0x00299894 File Offset: 0x00297A94
		public int PassScore
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

		// Token: 0x17002290 RID: 8848
		// (get) Token: 0x06009D27 RID: 40231 RVA: 0x002998D4 File Offset: 0x00297AD4
		public string LevelRewardDesc
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

		// Token: 0x06009D28 RID: 40232 RVA: 0x0029990C File Offset: 0x00297B0C
		public Span<byte> GetLevelRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009D29 RID: 40233 RVA: 0x0029991C File Offset: 0x00297B1C
		public byte[] GetLevelRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x06009D2A RID: 40234 RVA: 0x00299934 File Offset: 0x00297B34
		public int MowTowerLevel(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002291 RID: 8849
		// (get) Token: 0x06009D2B RID: 40235 RVA: 0x00299974 File Offset: 0x00297B74
		public int MowTowerLevelLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009D2C RID: 40236 RVA: 0x002999A0 File Offset: 0x00297BA0
		public Span<int> GetMowTowerLevelBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06009D2D RID: 40237 RVA: 0x002999B0 File Offset: 0x00297BB0
		public int[] GetMowTowerLevelArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17002292 RID: 8850
		// (get) Token: 0x06009D2E RID: 40238 RVA: 0x002999C8 File Offset: 0x00297BC8
		public string RewardName
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

		// Token: 0x06009D2F RID: 40239 RVA: 0x00299A00 File Offset: 0x00297C00
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06009D30 RID: 40240 RVA: 0x00299A10 File Offset: 0x00297C10
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002293 RID: 8851
		// (get) Token: 0x06009D31 RID: 40241 RVA: 0x00299A28 File Offset: 0x00297C28
		public string RewardTexture
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

		// Token: 0x06009D32 RID: 40242 RVA: 0x00299A60 File Offset: 0x00297C60
		public Span<byte> GetRewardTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06009D33 RID: 40243 RVA: 0x00299A70 File Offset: 0x00297C70
		public byte[] GetRewardTextureArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002294 RID: 8852
		// (get) Token: 0x06009D34 RID: 40244 RVA: 0x00299A88 File Offset: 0x00297C88
		public string LevelDesc
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

		// Token: 0x06009D35 RID: 40245 RVA: 0x00299AC0 File Offset: 0x00297CC0
		public Span<byte> GetLevelDescBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06009D36 RID: 40246 RVA: 0x00299AD0 File Offset: 0x00297CD0
		public byte[] GetLevelDescArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17002295 RID: 8853
		// (get) Token: 0x06009D37 RID: 40247 RVA: 0x00299AE8 File Offset: 0x00297CE8
		public string NormalTexture
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

		// Token: 0x06009D38 RID: 40248 RVA: 0x00299B20 File Offset: 0x00297D20
		public Span<byte> GetNormalTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06009D39 RID: 40249 RVA: 0x00299B30 File Offset: 0x00297D30
		public byte[] GetNormalTextureArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x06009D3A RID: 40250 RVA: 0x00299B48 File Offset: 0x00297D48
		public string LockTexture
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

		// Token: 0x06009D3B RID: 40251 RVA: 0x00299B80 File Offset: 0x00297D80
		public Span<byte> GetLockTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06009D3C RID: 40252 RVA: 0x00299B90 File Offset: 0x00297D90
		public byte[] GetLockTextureArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x06009D3D RID: 40253 RVA: 0x00299BA8 File Offset: 0x00297DA8
		public string LevelTips
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

		// Token: 0x06009D3E RID: 40254 RVA: 0x00299BE0 File Offset: 0x00297DE0
		public Span<byte> GetLevelTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06009D3F RID: 40255 RVA: 0x00299BF0 File Offset: 0x00297DF0
		public byte[] GetLevelTipsArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17002298 RID: 8856
		// (get) Token: 0x06009D40 RID: 40256 RVA: 0x00299C08 File Offset: 0x00297E08
		public bool IsInfinite
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002299 RID: 8857
		// (get) Token: 0x06009D41 RID: 40257 RVA: 0x00299C48 File Offset: 0x00297E48
		public string MonsterDes
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

		// Token: 0x06009D42 RID: 40258 RVA: 0x00299C80 File Offset: 0x00297E80
		public Span<byte> GetMonsterDesBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06009D43 RID: 40259 RVA: 0x00299C90 File Offset: 0x00297E90
		public byte[] GetMonsterDesArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x06009D44 RID: 40260 RVA: 0x00299CA8 File Offset: 0x00297EA8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InstIdsIter()或GetInstIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InstIds()
		{
			MowTowerLevelsRe mowTowerLevelsRe = this;
			return mowTowerLevelsRe.GetInstIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009D45 RID: 40261 RVA: 0x00299CCC File Offset: 0x00297ECC
		[NullableContext(1)]
		public readonly IEnumerable<int> InstIdsIter()
		{
			MowTowerLevelsRe.<InstIdsIter>d__74 <InstIdsIter>d__ = new MowTowerLevelsRe.<InstIdsIter>d__74(-2);
			<InstIdsIter>d__.<>3__<>4__this = this;
			return <InstIdsIter>d__;
		}

		// Token: 0x06009D46 RID: 40262 RVA: 0x00299CE4 File Offset: 0x00297EE4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MowTowerLevelIter()或GetMowTowerLevelBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MowTowerLevel()
		{
			MowTowerLevelsRe mowTowerLevelsRe = this;
			return mowTowerLevelsRe.GetMowTowerLevelArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009D47 RID: 40263 RVA: 0x00299D08 File Offset: 0x00297F08
		[NullableContext(1)]
		public readonly IEnumerable<int> MowTowerLevelIter()
		{
			MowTowerLevelsRe.<MowTowerLevelIter>d__76 <MowTowerLevelIter>d__ = new MowTowerLevelsRe.<MowTowerLevelIter>d__76(-2);
			<MowTowerLevelIter>d__.<>3__<>4__this = this;
			return <MowTowerLevelIter>d__;
		}

		// Token: 0x06009D48 RID: 40264 RVA: 0x00299D20 File Offset: 0x00297F20
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OptionalBuffIter()或GetOptionalBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] OptionalBuff()
		{
			MowTowerLevelsRe mowTowerLevelsRe = this;
			return mowTowerLevelsRe.GetOptionalBuffArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009D49 RID: 40265 RVA: 0x00299D44 File Offset: 0x00297F44
		[NullableContext(1)]
		public readonly IEnumerable<int> OptionalBuffIter()
		{
			MowTowerLevelsRe.<OptionalBuffIter>d__78 <OptionalBuffIter>d__ = new MowTowerLevelsRe.<OptionalBuffIter>d__78(-2);
			<OptionalBuffIter>d__.<>3__<>4__this = this;
			return <OptionalBuffIter>d__;
		}

		// Token: 0x04004F20 RID: 20256
		private Table __p;
	}
}
