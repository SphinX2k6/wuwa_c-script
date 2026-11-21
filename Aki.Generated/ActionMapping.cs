using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B95 RID: 2965
	public struct ActionMapping : IFlatbufferObject
	{
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600479C RID: 18332 RVA: 0x001E9728 File Offset: 0x001E7928
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x001E9735 File Offset: 0x001E7935
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x001E973C File Offset: 0x001E793C
		public static ActionMapping GetRootAsActionMapping(ByteBuffer _bb)
		{
			return ActionMapping.GetRootAsActionMapping(_bb, default(ActionMapping));
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x001E9758 File Offset: 0x001E7958
		public static ActionMapping GetRootAsActionMapping(ByteBuffer _bb, ActionMapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x001E9775 File Offset: 0x001E7975
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x001E9784 File Offset: 0x001E7984
		public ActionMapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060047A2 RID: 18338 RVA: 0x001E9794 File Offset: 0x001E7994
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

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060047A3 RID: 18339 RVA: 0x001E97D0 File Offset: 0x001E79D0
		public string ActionName
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

		// Token: 0x060047A4 RID: 18340 RVA: 0x001E9807 File Offset: 0x001E7A07
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x001E9816 File Offset: 0x001E7A16
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060047A6 RID: 18342 RVA: 0x001E9830 File Offset: 0x001E7A30
		public int ActionType
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

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060047A7 RID: 18343 RVA: 0x001E986C File Offset: 0x001E7A6C
		public string InputTag
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

		// Token: 0x060047A8 RID: 18344 RVA: 0x001E98A4 File Offset: 0x001E7AA4
		public Span<byte> GetInputTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060047A9 RID: 18345 RVA: 0x001E98B4 File Offset: 0x001E7AB4
		public byte[] GetInputTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060047AA RID: 18346 RVA: 0x001E98CC File Offset: 0x001E7ACC
		public int ExclusiveType
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

		// Token: 0x060047AB RID: 18347 RVA: 0x001E990C File Offset: 0x001E7B0C
		public string PcKeys(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060047AC RID: 18348 RVA: 0x001E9948 File Offset: 0x001E7B48
		public int PcKeysLength
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

		// Token: 0x060047AD RID: 18349 RVA: 0x001E9974 File Offset: 0x001E7B74
		public string FrancePcKeys(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060047AE RID: 18350 RVA: 0x001E99B0 File Offset: 0x001E7BB0
		public int FrancePcKeysLength
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

		// Token: 0x060047AF RID: 18351 RVA: 0x001E99DC File Offset: 0x001E7BDC
		public string ThaiPcKeys(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060047B0 RID: 18352 RVA: 0x001E9A18 File Offset: 0x001E7C18
		public int ThaiPcKeysLength
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

		// Token: 0x060047B1 RID: 18353 RVA: 0x001E9A44 File Offset: 0x001E7C44
		public string GamepadKeys(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060047B2 RID: 18354 RVA: 0x001E9A80 File Offset: 0x001E7C80
		public int GamepadKeysLength
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

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060047B3 RID: 18355 RVA: 0x001E9AAC File Offset: 0x001E7CAC
		public string MobileIconPath
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

		// Token: 0x060047B4 RID: 18356 RVA: 0x001E9AE4 File Offset: 0x001E7CE4
		public Span<byte> GetMobileIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060047B5 RID: 18357 RVA: 0x001E9AF4 File Offset: 0x001E7CF4
		public byte[] GetMobileIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060047B6 RID: 18358 RVA: 0x001E9B0C File Offset: 0x001E7D0C
		public string DisplayName
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

		// Token: 0x060047B7 RID: 18359 RVA: 0x001E9B44 File Offset: 0x001E7D44
		public Span<byte> GetDisplayNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x001E9B54 File Offset: 0x001E7D54
		public byte[] GetDisplayNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060047B9 RID: 18361 RVA: 0x001E9B6C File Offset: 0x001E7D6C
		public bool IsIdleAction
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x001E9BAC File Offset: 0x001E7DAC
		public DicIntInt? KeyboardVersionMap(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060047BB RID: 18363 RVA: 0x001E9C10 File Offset: 0x001E7E10
		public int KeyboardVersionMapLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x001E9C3C File Offset: 0x001E7E3C
		public DicIntInt? GamepadVersionMap(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060047BD RID: 18365 RVA: 0x001E9CA0 File Offset: 0x001E7EA0
		public int GamepadVersionMapLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060047BE RID: 18366 RVA: 0x001E9CCC File Offset: 0x001E7ECC
		[NullableContext(1)]
		public string[] FrancePcKeys()
		{
			return this.FrancePcKeysIter().ToArray<string>();
		}

		// Token: 0x060047BF RID: 18367 RVA: 0x001E9CD9 File Offset: 0x001E7ED9
		[NullableContext(1)]
		public IEnumerable<string> FrancePcKeysIter()
		{
			ActionMapping.<FrancePcKeysIter>d__51 <FrancePcKeysIter>d__ = new ActionMapping.<FrancePcKeysIter>d__51(-2);
			<FrancePcKeysIter>d__.<>3__<>4__this = this;
			return <FrancePcKeysIter>d__;
		}

		// Token: 0x060047C0 RID: 18368 RVA: 0x001E9CEE File Offset: 0x001E7EEE
		[NullableContext(1)]
		public string[] GamepadKeys()
		{
			return this.GamepadKeysIter().ToArray<string>();
		}

		// Token: 0x060047C1 RID: 18369 RVA: 0x001E9CFB File Offset: 0x001E7EFB
		[NullableContext(1)]
		public IEnumerable<string> GamepadKeysIter()
		{
			ActionMapping.<GamepadKeysIter>d__53 <GamepadKeysIter>d__ = new ActionMapping.<GamepadKeysIter>d__53(-2);
			<GamepadKeysIter>d__.<>3__<>4__this = this;
			return <GamepadKeysIter>d__;
		}

		// Token: 0x060047C2 RID: 18370 RVA: 0x001E9D10 File Offset: 0x001E7F10
		[NullableContext(1)]
		public Dictionary<int, int> GamepadVersionMap()
		{
			return this.GamepadVersionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060047C3 RID: 18371 RVA: 0x001E9D66 File Offset: 0x001E7F66
		[NullableContext(1)]
		public IEnumerable<DicIntInt> GamepadVersionMapIter()
		{
			ActionMapping.<GamepadVersionMapIter>d__55 <GamepadVersionMapIter>d__ = new ActionMapping.<GamepadVersionMapIter>d__55(-2);
			<GamepadVersionMapIter>d__.<>3__<>4__this = this;
			return <GamepadVersionMapIter>d__;
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x001E9D7C File Offset: 0x001E7F7C
		[NullableContext(1)]
		public Dictionary<int, int> KeyboardVersionMap()
		{
			return this.KeyboardVersionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x001E9DD2 File Offset: 0x001E7FD2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> KeyboardVersionMapIter()
		{
			ActionMapping.<KeyboardVersionMapIter>d__57 <KeyboardVersionMapIter>d__ = new ActionMapping.<KeyboardVersionMapIter>d__57(-2);
			<KeyboardVersionMapIter>d__.<>3__<>4__this = this;
			return <KeyboardVersionMapIter>d__;
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x001E9DE7 File Offset: 0x001E7FE7
		[NullableContext(1)]
		public string[] PcKeys()
		{
			return this.PcKeysIter().ToArray<string>();
		}

		// Token: 0x060047C7 RID: 18375 RVA: 0x001E9DF4 File Offset: 0x001E7FF4
		[NullableContext(1)]
		public IEnumerable<string> PcKeysIter()
		{
			ActionMapping.<PcKeysIter>d__59 <PcKeysIter>d__ = new ActionMapping.<PcKeysIter>d__59(-2);
			<PcKeysIter>d__.<>3__<>4__this = this;
			return <PcKeysIter>d__;
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x001E9E09 File Offset: 0x001E8009
		[NullableContext(1)]
		public string[] ThaiPcKeys()
		{
			return this.ThaiPcKeysIter().ToArray<string>();
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x001E9E16 File Offset: 0x001E8016
		[NullableContext(1)]
		public IEnumerable<string> ThaiPcKeysIter()
		{
			ActionMapping.<ThaiPcKeysIter>d__61 <ThaiPcKeysIter>d__ = new ActionMapping.<ThaiPcKeysIter>d__61(-2);
			<ThaiPcKeysIter>d__.<>3__<>4__this = this;
			return <ThaiPcKeysIter>d__;
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x001E9E2C File Offset: 0x001E802C
		public int? GetGamepadVersionMap(int key)
		{
			this.EnsureGamepadVersionMapCacheIfNeeded();
			int value;
			if (!this.GamepadVersionMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060047CB RID: 18379 RVA: 0x001E9E60 File Offset: 0x001E8060
		public int? GetKeyboardVersionMap(int key)
		{
			this.EnsureKeyboardVersionMapCacheIfNeeded();
			int value;
			if (!this.KeyboardVersionMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060047CC RID: 18380 RVA: 0x001E9E94 File Offset: 0x001E8094
		private void EnsureGamepadVersionMapCacheIfNeeded()
		{
			if (this.GamepadVersionMapCache != null)
			{
				return;
			}
			this.GamepadVersionMapCache = this.GamepadVersionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060047CD RID: 18381 RVA: 0x001E9EFC File Offset: 0x001E80FC
		private void EnsureKeyboardVersionMapCacheIfNeeded()
		{
			if (this.KeyboardVersionMapCache != null)
			{
				return;
			}
			this.KeyboardVersionMapCache = this.KeyboardVersionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060047CE RID: 18382 RVA: 0x001E9F62 File Offset: 0x001E8162
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetGamepadVersionMapFrozenDict()
		{
			this.EnsureGamepadVersionMapCacheIfNeeded();
			return this.GamepadVersionMapCache;
		}

		// Token: 0x060047CF RID: 18383 RVA: 0x001E9F70 File Offset: 0x001E8170
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetKeyboardVersionMapFrozenDict()
		{
			this.EnsureKeyboardVersionMapCacheIfNeeded();
			return this.KeyboardVersionMapCache;
		}

		// Token: 0x0400506D RID: 20589
		private Table __p;

		// Token: 0x0400506E RID: 20590
		[Nullable(2)]
		private FrozenDictionary<int, int> GamepadVersionMapCache;

		// Token: 0x0400506F RID: 20591
		[Nullable(2)]
		private FrozenDictionary<int, int> KeyboardVersionMapCache;
	}
}
