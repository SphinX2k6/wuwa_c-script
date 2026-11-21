using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CDF RID: 3295
	public struct DreamLinkRoleDungeon : IFlatbufferObject
	{
		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06006938 RID: 26936 RVA: 0x00235232 File Offset: 0x00233432
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006939 RID: 26937 RVA: 0x0023523F File Offset: 0x0023343F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600693A RID: 26938 RVA: 0x00235248 File Offset: 0x00233448
		public static DreamLinkRoleDungeon GetRootAsDreamLinkRoleDungeon(ByteBuffer _bb)
		{
			return DreamLinkRoleDungeon.GetRootAsDreamLinkRoleDungeon(_bb, default(DreamLinkRoleDungeon));
		}

		// Token: 0x0600693B RID: 26939 RVA: 0x00235264 File Offset: 0x00233464
		public static DreamLinkRoleDungeon GetRootAsDreamLinkRoleDungeon(ByteBuffer _bb, DreamLinkRoleDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600693C RID: 26940 RVA: 0x00235281 File Offset: 0x00233481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600693D RID: 26941 RVA: 0x00235290 File Offset: 0x00233490
		public DreamLinkRoleDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x0600693E RID: 26942 RVA: 0x002352A0 File Offset: 0x002334A0
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

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x0600693F RID: 26943 RVA: 0x002352DC File Offset: 0x002334DC
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

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06006940 RID: 26944 RVA: 0x00235318 File Offset: 0x00233518
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

		// Token: 0x06006941 RID: 26945 RVA: 0x0023534F File Offset: 0x0023354F
		public Span<byte> GetAnimationPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x0023535E File Offset: 0x0023355E
		public byte[] GetAnimationPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06006943 RID: 26947 RVA: 0x00235378 File Offset: 0x00233578
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

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06006944 RID: 26948 RVA: 0x002353B8 File Offset: 0x002335B8
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

		// Token: 0x06006945 RID: 26949 RVA: 0x002353F0 File Offset: 0x002335F0
		public Span<byte> GetIndexTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006946 RID: 26950 RVA: 0x00235400 File Offset: 0x00233600
		public byte[] GetIndexTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06006947 RID: 26951 RVA: 0x00235418 File Offset: 0x00233618
		public DicStringString? WeaponShowConfig(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06006948 RID: 26952 RVA: 0x0023547C File Offset: 0x0023367C
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

		// Token: 0x06006949 RID: 26953 RVA: 0x002354A8 File Offset: 0x002336A8
		public DicStringString? WeaponShowCase(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x0600694A RID: 26954 RVA: 0x0023550C File Offset: 0x0023370C
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

		// Token: 0x0600694B RID: 26955 RVA: 0x00235538 File Offset: 0x00233738
		[NullableContext(1)]
		public Dictionary<string, string> WeaponShowCase()
		{
			return this.WeaponShowCaseIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x0023558E File Offset: 0x0023378E
		[NullableContext(1)]
		public IEnumerable<DicStringString> WeaponShowCaseIter()
		{
			DreamLinkRoleDungeon.<WeaponShowCaseIter>d__29 <WeaponShowCaseIter>d__ = new DreamLinkRoleDungeon.<WeaponShowCaseIter>d__29(-2);
			<WeaponShowCaseIter>d__.<>3__<>4__this = this;
			return <WeaponShowCaseIter>d__;
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x002355A4 File Offset: 0x002337A4
		[NullableContext(1)]
		public Dictionary<string, string> WeaponShowConfig()
		{
			return this.WeaponShowConfigIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x002355FA File Offset: 0x002337FA
		[NullableContext(1)]
		public IEnumerable<DicStringString> WeaponShowConfigIter()
		{
			DreamLinkRoleDungeon.<WeaponShowConfigIter>d__31 <WeaponShowConfigIter>d__ = new DreamLinkRoleDungeon.<WeaponShowConfigIter>d__31(-2);
			<WeaponShowConfigIter>d__.<>3__<>4__this = this;
			return <WeaponShowConfigIter>d__;
		}

		// Token: 0x0600694F RID: 26959 RVA: 0x00235610 File Offset: 0x00233810
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

		// Token: 0x06006950 RID: 26960 RVA: 0x00235638 File Offset: 0x00233838
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

		// Token: 0x06006951 RID: 26961 RVA: 0x00235660 File Offset: 0x00233860
		private void EnsureWeaponShowCaseCacheIfNeeded()
		{
			if (this.WeaponShowCaseCache != null)
			{
				return;
			}
			this.WeaponShowCaseCache = this.WeaponShowCaseIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06006952 RID: 26962 RVA: 0x002356C8 File Offset: 0x002338C8
		private void EnsureWeaponShowConfigCacheIfNeeded()
		{
			if (this.WeaponShowConfigCache != null)
			{
				return;
			}
			this.WeaponShowConfigCache = this.WeaponShowConfigIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x0023572E File Offset: 0x0023392E
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetWeaponShowCaseFrozenDict()
		{
			this.EnsureWeaponShowCaseCacheIfNeeded();
			return this.WeaponShowCaseCache;
		}

		// Token: 0x06006954 RID: 26964 RVA: 0x0023573C File Offset: 0x0023393C
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetWeaponShowConfigFrozenDict()
		{
			this.EnsureWeaponShowConfigCacheIfNeeded();
			return this.WeaponShowConfigCache;
		}

		// Token: 0x0400520C RID: 21004
		private Table __p;

		// Token: 0x0400520D RID: 21005
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> WeaponShowCaseCache;

		// Token: 0x0400520E RID: 21006
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> WeaponShowConfigCache;
	}
}
