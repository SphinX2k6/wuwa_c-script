using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B3B RID: 2875
	public struct BlackSwordUIAsset : IFlatbufferObject
	{
		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06004DD7 RID: 19927 RVA: 0x001E4D94 File Offset: 0x001E2F94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004DD8 RID: 19928 RVA: 0x001E4DA1 File Offset: 0x001E2FA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004DD9 RID: 19929 RVA: 0x001E4DA8 File Offset: 0x001E2FA8
		public static BlackSwordUIAsset GetRootAsBlackSwordUIAsset(ByteBuffer _bb)
		{
			return BlackSwordUIAsset.GetRootAsBlackSwordUIAsset(_bb, default(BlackSwordUIAsset));
		}

		// Token: 0x06004DDA RID: 19930 RVA: 0x001E4DC4 File Offset: 0x001E2FC4
		public static BlackSwordUIAsset GetRootAsBlackSwordUIAsset(ByteBuffer _bb, BlackSwordUIAsset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004DDB RID: 19931 RVA: 0x001E4DE1 File Offset: 0x001E2FE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004DDC RID: 19932 RVA: 0x001E4DF0 File Offset: 0x001E2FF0
		public BlackSwordUIAsset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06004DDD RID: 19933 RVA: 0x001E4E00 File Offset: 0x001E3000
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

		// Token: 0x06004DDE RID: 19934 RVA: 0x001E4E3C File Offset: 0x001E303C
		public string LevelColors(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06004DDF RID: 19935 RVA: 0x001E4E78 File Offset: 0x001E3078
		public int LevelColorsLength
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

		// Token: 0x06004DE0 RID: 19936 RVA: 0x001E4EA4 File Offset: 0x001E30A4
		public string PatternPaths(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06004DE1 RID: 19937 RVA: 0x001E4EE0 File Offset: 0x001E30E0
		public int PatternPathsLength
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

		// Token: 0x06004DE2 RID: 19938 RVA: 0x001E4F0C File Offset: 0x001E310C
		public string StarPaths(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06004DE3 RID: 19939 RVA: 0x001E4F48 File Offset: 0x001E3148
		public int StarPathsLength
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

		// Token: 0x06004DE4 RID: 19940 RVA: 0x001E4F74 File Offset: 0x001E3174
		public string CountDownTextAsset(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06004DE5 RID: 19941 RVA: 0x001E4FB0 File Offset: 0x001E31B0
		public int CountDownTextAssetLength
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

		// Token: 0x06004DE6 RID: 19942 RVA: 0x001E4FDC File Offset: 0x001E31DC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CountDownTextAssetIter()或GetCountDownTextAssetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] CountDownTextAsset()
		{
			return this.CountDownTextAssetIter().ToArray<string>();
		}

		// Token: 0x06004DE7 RID: 19943 RVA: 0x001E4FE9 File Offset: 0x001E31E9
		[NullableContext(1)]
		public readonly IEnumerable<string> CountDownTextAssetIter()
		{
			BlackSwordUIAsset.<CountDownTextAssetIter>d__23 <CountDownTextAssetIter>d__ = new BlackSwordUIAsset.<CountDownTextAssetIter>d__23(-2);
			<CountDownTextAssetIter>d__.<>3__<>4__this = this;
			return <CountDownTextAssetIter>d__;
		}

		// Token: 0x06004DE8 RID: 19944 RVA: 0x001E4FFE File Offset: 0x001E31FE
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelColorsIter()或GetLevelColorsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] LevelColors()
		{
			return this.LevelColorsIter().ToArray<string>();
		}

		// Token: 0x06004DE9 RID: 19945 RVA: 0x001E500B File Offset: 0x001E320B
		[NullableContext(1)]
		public readonly IEnumerable<string> LevelColorsIter()
		{
			BlackSwordUIAsset.<LevelColorsIter>d__25 <LevelColorsIter>d__ = new BlackSwordUIAsset.<LevelColorsIter>d__25(-2);
			<LevelColorsIter>d__.<>3__<>4__this = this;
			return <LevelColorsIter>d__;
		}

		// Token: 0x06004DEA RID: 19946 RVA: 0x001E5020 File Offset: 0x001E3220
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PatternPathsIter()或GetPatternPathsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] PatternPaths()
		{
			return this.PatternPathsIter().ToArray<string>();
		}

		// Token: 0x06004DEB RID: 19947 RVA: 0x001E502D File Offset: 0x001E322D
		[NullableContext(1)]
		public readonly IEnumerable<string> PatternPathsIter()
		{
			BlackSwordUIAsset.<PatternPathsIter>d__27 <PatternPathsIter>d__ = new BlackSwordUIAsset.<PatternPathsIter>d__27(-2);
			<PatternPathsIter>d__.<>3__<>4__this = this;
			return <PatternPathsIter>d__;
		}

		// Token: 0x06004DEC RID: 19948 RVA: 0x001E5042 File Offset: 0x001E3242
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StarPathsIter()或GetStarPathsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] StarPaths()
		{
			return this.StarPathsIter().ToArray<string>();
		}

		// Token: 0x06004DED RID: 19949 RVA: 0x001E504F File Offset: 0x001E324F
		[NullableContext(1)]
		public readonly IEnumerable<string> StarPathsIter()
		{
			BlackSwordUIAsset.<StarPathsIter>d__29 <StarPathsIter>d__ = new BlackSwordUIAsset.<StarPathsIter>d__29(-2);
			<StarPathsIter>d__.<>3__<>4__this = this;
			return <StarPathsIter>d__;
		}

		// Token: 0x04004B36 RID: 19254
		private Table __p;
	}
}
