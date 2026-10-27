using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BFD RID: 3069
	public struct DreamLinkRoleDungeon : IFlatbufferObject
	{
		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06006359 RID: 25433 RVA: 0x00215BD1 File Offset: 0x00213DD1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600635A RID: 25434 RVA: 0x00215BDE File Offset: 0x00213DDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600635B RID: 25435 RVA: 0x00215BE8 File Offset: 0x00213DE8
		public static DreamLinkRoleDungeon GetRootAsDreamLinkRoleDungeon(ByteBuffer _bb)
		{
			return DreamLinkRoleDungeon.GetRootAsDreamLinkRoleDungeon(_bb, default(DreamLinkRoleDungeon));
		}

		// Token: 0x0600635C RID: 25436 RVA: 0x00215C04 File Offset: 0x00213E04
		public static DreamLinkRoleDungeon GetRootAsDreamLinkRoleDungeon(ByteBuffer _bb, DreamLinkRoleDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600635D RID: 25437 RVA: 0x00215C21 File Offset: 0x00213E21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600635E RID: 25438 RVA: 0x00215C30 File Offset: 0x00213E30
		public DreamLinkRoleDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x0600635F RID: 25439 RVA: 0x00215C40 File Offset: 0x00213E40
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

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06006360 RID: 25440 RVA: 0x00215C7C File Offset: 0x00213E7C
		public int RoleId
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

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06006361 RID: 25441 RVA: 0x00215CB8 File Offset: 0x00213EB8
		public string AnimationPath
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

		// Token: 0x06006362 RID: 25442 RVA: 0x00215CEF File Offset: 0x00213EEF
		public Span<byte> GetAnimationPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006363 RID: 25443 RVA: 0x00215CFE File Offset: 0x00213EFE
		public byte[] GetAnimationPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06006364 RID: 25444 RVA: 0x00215D18 File Offset: 0x00213F18
		public int AddProgress
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

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06006365 RID: 25445 RVA: 0x00215D58 File Offset: 0x00213F58
		public string IndexTexturePath
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

		// Token: 0x06006366 RID: 25446 RVA: 0x00215D90 File Offset: 0x00213F90
		public Span<byte> GetIndexTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006367 RID: 25447 RVA: 0x00215DA0 File Offset: 0x00213FA0
		public byte[] GetIndexTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06006368 RID: 25448 RVA: 0x00215DB8 File Offset: 0x00213FB8
		public DicStringString? WeaponShowConfig(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06006369 RID: 25449 RVA: 0x00215E1C File Offset: 0x0021401C
		public int WeaponShowConfigLength
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

		// Token: 0x0600636A RID: 25450 RVA: 0x00215E48 File Offset: 0x00214048
		public DicStringString? WeaponShowCase(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x0600636B RID: 25451 RVA: 0x00215EAC File Offset: 0x002140AC
		public int WeaponShowCaseLength
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

		// Token: 0x0600636C RID: 25452 RVA: 0x00215ED8 File Offset: 0x002140D8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用WeaponShowCaseFrozenDict()缓存字典，遍历请使用WeaponShowCaseIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> WeaponShowCase()
		{
			return this.WeaponShowCaseIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600636D RID: 25453 RVA: 0x00215F2E File Offset: 0x0021412E
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> WeaponShowCaseIter()
		{
			DreamLinkRoleDungeon.<WeaponShowCaseIter>d__29 <WeaponShowCaseIter>d__ = new DreamLinkRoleDungeon.<WeaponShowCaseIter>d__29(-2);
			<WeaponShowCaseIter>d__.<>3__<>4__this = this;
			return <WeaponShowCaseIter>d__;
		}

		// Token: 0x0600636E RID: 25454 RVA: 0x00215F44 File Offset: 0x00214144
		[NullableContext(1)]
		[Obsolete("已废弃，请使用WeaponShowConfigFrozenDict()缓存字典，遍历请使用WeaponShowConfigIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> WeaponShowConfig()
		{
			return this.WeaponShowConfigIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600636F RID: 25455 RVA: 0x00215F9A File Offset: 0x0021419A
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> WeaponShowConfigIter()
		{
			DreamLinkRoleDungeon.<WeaponShowConfigIter>d__31 <WeaponShowConfigIter>d__ = new DreamLinkRoleDungeon.<WeaponShowConfigIter>d__31(-2);
			<WeaponShowConfigIter>d__.<>3__<>4__this = this;
			return <WeaponShowConfigIter>d__;
		}

		// Token: 0x06006370 RID: 25456 RVA: 0x00215FB0 File Offset: 0x002141B0
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetWeaponShowCase(string key)
		{
			this.EnsureWeaponShowCaseCacheIfNeeded();
			string result;
			if (!this.WeaponShowCaseCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06006371 RID: 25457 RVA: 0x00215FD8 File Offset: 0x002141D8
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetWeaponShowConfig(string key)
		{
			this.EnsureWeaponShowConfigCacheIfNeeded();
			string result;
			if (!this.WeaponShowConfigCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06006372 RID: 25458 RVA: 0x00216000 File Offset: 0x00214200
		private void EnsureWeaponShowCaseCacheIfNeeded()
		{
			if (this.WeaponShowCaseCache != null)
			{
				return;
			}
			this.WeaponShowCaseCache = this.WeaponShowCaseIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06006373 RID: 25459 RVA: 0x00216068 File Offset: 0x00214268
		private void EnsureWeaponShowConfigCacheIfNeeded()
		{
			if (this.WeaponShowConfigCache != null)
			{
				return;
			}
			this.WeaponShowConfigCache = this.WeaponShowConfigIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06006374 RID: 25460 RVA: 0x002160CE File Offset: 0x002142CE
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetWeaponShowCaseFrozenDict(string key)
		{
			this.EnsureWeaponShowCaseCacheIfNeeded();
			return this.WeaponShowCaseCache;
		}

		// Token: 0x06006375 RID: 25461 RVA: 0x002160DC File Offset: 0x002142DC
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetWeaponShowConfigFrozenDict(string key)
		{
			this.EnsureWeaponShowConfigCacheIfNeeded();
			return this.WeaponShowConfigCache;
		}

		// Token: 0x04004C2A RID: 19498
		private Table __p;

		// Token: 0x04004C2B RID: 19499
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> WeaponShowCaseCache;

		// Token: 0x04004C2C RID: 19500
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> WeaponShowConfigCache;
	}
}
