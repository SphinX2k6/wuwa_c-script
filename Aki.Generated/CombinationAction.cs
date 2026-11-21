using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C68 RID: 3176
	public struct CombinationAction : IFlatbufferObject
	{
		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06005C2A RID: 23594 RVA: 0x00217CF0 File Offset: 0x00215EF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005C2B RID: 23595 RVA: 0x00217CFD File Offset: 0x00215EFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005C2C RID: 23596 RVA: 0x00217D04 File Offset: 0x00215F04
		public static CombinationAction GetRootAsCombinationAction(ByteBuffer _bb)
		{
			return CombinationAction.GetRootAsCombinationAction(_bb, default(CombinationAction));
		}

		// Token: 0x06005C2D RID: 23597 RVA: 0x00217D20 File Offset: 0x00215F20
		public static CombinationAction GetRootAsCombinationAction(ByteBuffer _bb, CombinationAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005C2E RID: 23598 RVA: 0x00217D3D File Offset: 0x00215F3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005C2F RID: 23599 RVA: 0x00217D4C File Offset: 0x00215F4C
		public CombinationAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06005C30 RID: 23600 RVA: 0x00217D5C File Offset: 0x00215F5C
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

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06005C31 RID: 23601 RVA: 0x00217D98 File Offset: 0x00215F98
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

		// Token: 0x06005C32 RID: 23602 RVA: 0x00217DCF File Offset: 0x00215FCF
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005C33 RID: 23603 RVA: 0x00217DDE File Offset: 0x00215FDE
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06005C34 RID: 23604 RVA: 0x00217DF8 File Offset: 0x00215FF8
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

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06005C35 RID: 23605 RVA: 0x00217E34 File Offset: 0x00216034
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

		// Token: 0x06005C36 RID: 23606 RVA: 0x00217E6C File Offset: 0x0021606C
		public Span<byte> GetInputTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005C37 RID: 23607 RVA: 0x00217E7C File Offset: 0x0021607C
		public byte[] GetInputTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06005C38 RID: 23608 RVA: 0x00217E94 File Offset: 0x00216094
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

		// Token: 0x06005C39 RID: 23609 RVA: 0x00217ED4 File Offset: 0x002160D4
		public DicStringString? PcKeys(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06005C3A RID: 23610 RVA: 0x00217F38 File Offset: 0x00216138
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

		// Token: 0x06005C3B RID: 23611 RVA: 0x00217F64 File Offset: 0x00216164
		public DicStringString? FrancePcKeys(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06005C3C RID: 23612 RVA: 0x00217FC8 File Offset: 0x002161C8
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

		// Token: 0x06005C3D RID: 23613 RVA: 0x00217FF4 File Offset: 0x002161F4
		public DicStringString? ThaiPcKeys(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06005C3E RID: 23614 RVA: 0x00218058 File Offset: 0x00216258
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

		// Token: 0x06005C3F RID: 23615 RVA: 0x00218084 File Offset: 0x00216284
		public DicStringString? GamepadKeys(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06005C40 RID: 23616 RVA: 0x002180E8 File Offset: 0x002162E8
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

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06005C41 RID: 23617 RVA: 0x00218114 File Offset: 0x00216314
		public int SecondaryKeyValidTime
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06005C42 RID: 23618 RVA: 0x00218154 File Offset: 0x00216354
		public string MobileIconPath
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

		// Token: 0x06005C43 RID: 23619 RVA: 0x0021818C File Offset: 0x0021638C
		public Span<byte> GetMobileIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06005C44 RID: 23620 RVA: 0x0021819C File Offset: 0x0021639C
		public byte[] GetMobileIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06005C45 RID: 23621 RVA: 0x002181B4 File Offset: 0x002163B4
		public string DisplayName
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

		// Token: 0x06005C46 RID: 23622 RVA: 0x002181EC File Offset: 0x002163EC
		public Span<byte> GetDisplayNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06005C47 RID: 23623 RVA: 0x002181FC File Offset: 0x002163FC
		public byte[] GetDisplayNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x06005C48 RID: 23624 RVA: 0x00218214 File Offset: 0x00216414
		public DicIntInt? KeyboardVersionMap(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06005C49 RID: 23625 RVA: 0x00218278 File Offset: 0x00216478
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

		// Token: 0x06005C4A RID: 23626 RVA: 0x002182A4 File Offset: 0x002164A4
		public DicIntInt? GamepadVersionMap(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06005C4B RID: 23627 RVA: 0x00218308 File Offset: 0x00216508
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

		// Token: 0x06005C4C RID: 23628 RVA: 0x00218334 File Offset: 0x00216534
		public string BlockInput(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06005C4D RID: 23629 RVA: 0x00218370 File Offset: 0x00216570
		public int BlockInputLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005C4E RID: 23630 RVA: 0x0021839C File Offset: 0x0021659C
		[NullableContext(1)]
		public string[] BlockInput()
		{
			return this.BlockInputIter().ToArray<string>();
		}

		// Token: 0x06005C4F RID: 23631 RVA: 0x002183A9 File Offset: 0x002165A9
		[NullableContext(1)]
		public IEnumerable<string> BlockInputIter()
		{
			CombinationAction.<BlockInputIter>d__54 <BlockInputIter>d__ = new CombinationAction.<BlockInputIter>d__54(-2);
			<BlockInputIter>d__.<>3__<>4__this = this;
			return <BlockInputIter>d__;
		}

		// Token: 0x06005C50 RID: 23632 RVA: 0x002183C0 File Offset: 0x002165C0
		[NullableContext(1)]
		public Dictionary<string, string> FrancePcKeys()
		{
			return this.FrancePcKeysIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005C51 RID: 23633 RVA: 0x00218416 File Offset: 0x00216616
		[NullableContext(1)]
		public IEnumerable<DicStringString> FrancePcKeysIter()
		{
			CombinationAction.<FrancePcKeysIter>d__56 <FrancePcKeysIter>d__ = new CombinationAction.<FrancePcKeysIter>d__56(-2);
			<FrancePcKeysIter>d__.<>3__<>4__this = this;
			return <FrancePcKeysIter>d__;
		}

		// Token: 0x06005C52 RID: 23634 RVA: 0x0021842C File Offset: 0x0021662C
		[NullableContext(1)]
		public Dictionary<string, string> GamepadKeys()
		{
			return this.GamepadKeysIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005C53 RID: 23635 RVA: 0x00218482 File Offset: 0x00216682
		[NullableContext(1)]
		public IEnumerable<DicStringString> GamepadKeysIter()
		{
			CombinationAction.<GamepadKeysIter>d__58 <GamepadKeysIter>d__ = new CombinationAction.<GamepadKeysIter>d__58(-2);
			<GamepadKeysIter>d__.<>3__<>4__this = this;
			return <GamepadKeysIter>d__;
		}

		// Token: 0x06005C54 RID: 23636 RVA: 0x00218498 File Offset: 0x00216698
		[NullableContext(1)]
		public Dictionary<int, int> GamepadVersionMap()
		{
			return this.GamepadVersionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005C55 RID: 23637 RVA: 0x002184EE File Offset: 0x002166EE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> GamepadVersionMapIter()
		{
			CombinationAction.<GamepadVersionMapIter>d__60 <GamepadVersionMapIter>d__ = new CombinationAction.<GamepadVersionMapIter>d__60(-2);
			<GamepadVersionMapIter>d__.<>3__<>4__this = this;
			return <GamepadVersionMapIter>d__;
		}

		// Token: 0x06005C56 RID: 23638 RVA: 0x00218504 File Offset: 0x00216704
		[NullableContext(1)]
		public Dictionary<int, int> KeyboardVersionMap()
		{
			return this.KeyboardVersionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005C57 RID: 23639 RVA: 0x0021855A File Offset: 0x0021675A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> KeyboardVersionMapIter()
		{
			CombinationAction.<KeyboardVersionMapIter>d__62 <KeyboardVersionMapIter>d__ = new CombinationAction.<KeyboardVersionMapIter>d__62(-2);
			<KeyboardVersionMapIter>d__.<>3__<>4__this = this;
			return <KeyboardVersionMapIter>d__;
		}

		// Token: 0x06005C58 RID: 23640 RVA: 0x00218570 File Offset: 0x00216770
		[NullableContext(1)]
		public Dictionary<string, string> PcKeys()
		{
			return this.PcKeysIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005C59 RID: 23641 RVA: 0x002185C6 File Offset: 0x002167C6
		[NullableContext(1)]
		public IEnumerable<DicStringString> PcKeysIter()
		{
			CombinationAction.<PcKeysIter>d__64 <PcKeysIter>d__ = new CombinationAction.<PcKeysIter>d__64(-2);
			<PcKeysIter>d__.<>3__<>4__this = this;
			return <PcKeysIter>d__;
		}

		// Token: 0x06005C5A RID: 23642 RVA: 0x002185DC File Offset: 0x002167DC
		[NullableContext(1)]
		public Dictionary<string, string> ThaiPcKeys()
		{
			return this.ThaiPcKeysIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005C5B RID: 23643 RVA: 0x00218632 File Offset: 0x00216832
		[NullableContext(1)]
		public IEnumerable<DicStringString> ThaiPcKeysIter()
		{
			CombinationAction.<ThaiPcKeysIter>d__66 <ThaiPcKeysIter>d__ = new CombinationAction.<ThaiPcKeysIter>d__66(-2);
			<ThaiPcKeysIter>d__.<>3__<>4__this = this;
			return <ThaiPcKeysIter>d__;
		}

		// Token: 0x06005C5C RID: 23644 RVA: 0x00218648 File Offset: 0x00216848
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetFrancePcKeys(string key)
		{
			this.EnsureFrancePcKeysCacheIfNeeded();
			string result;
			if (!this.FrancePcKeysCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005C5D RID: 23645 RVA: 0x00218670 File Offset: 0x00216870
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetGamepadKeys(string key)
		{
			this.EnsureGamepadKeysCacheIfNeeded();
			string result;
			if (!this.GamepadKeysCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005C5E RID: 23646 RVA: 0x00218698 File Offset: 0x00216898
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

		// Token: 0x06005C5F RID: 23647 RVA: 0x002186CC File Offset: 0x002168CC
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

		// Token: 0x06005C60 RID: 23648 RVA: 0x00218700 File Offset: 0x00216900
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetPcKeys(string key)
		{
			this.EnsurePcKeysCacheIfNeeded();
			string result;
			if (!this.PcKeysCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005C61 RID: 23649 RVA: 0x00218728 File Offset: 0x00216928
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetThaiPcKeys(string key)
		{
			this.EnsureThaiPcKeysCacheIfNeeded();
			string result;
			if (!this.ThaiPcKeysCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005C62 RID: 23650 RVA: 0x00218750 File Offset: 0x00216950
		private void EnsureFrancePcKeysCacheIfNeeded()
		{
			if (this.FrancePcKeysCache != null)
			{
				return;
			}
			this.FrancePcKeysCache = this.FrancePcKeysIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005C63 RID: 23651 RVA: 0x002187B8 File Offset: 0x002169B8
		private void EnsureGamepadKeysCacheIfNeeded()
		{
			if (this.GamepadKeysCache != null)
			{
				return;
			}
			this.GamepadKeysCache = this.GamepadKeysIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005C64 RID: 23652 RVA: 0x00218820 File Offset: 0x00216A20
		private void EnsureGamepadVersionMapCacheIfNeeded()
		{
			if (this.GamepadVersionMapCache != null)
			{
				return;
			}
			this.GamepadVersionMapCache = this.GamepadVersionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005C65 RID: 23653 RVA: 0x00218888 File Offset: 0x00216A88
		private void EnsureKeyboardVersionMapCacheIfNeeded()
		{
			if (this.KeyboardVersionMapCache != null)
			{
				return;
			}
			this.KeyboardVersionMapCache = this.KeyboardVersionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005C66 RID: 23654 RVA: 0x002188F0 File Offset: 0x00216AF0
		private void EnsurePcKeysCacheIfNeeded()
		{
			if (this.PcKeysCache != null)
			{
				return;
			}
			this.PcKeysCache = this.PcKeysIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005C67 RID: 23655 RVA: 0x00218958 File Offset: 0x00216B58
		private void EnsureThaiPcKeysCacheIfNeeded()
		{
			if (this.ThaiPcKeysCache != null)
			{
				return;
			}
			this.ThaiPcKeysCache = this.ThaiPcKeysIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005C68 RID: 23656 RVA: 0x002189BE File Offset: 0x00216BBE
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetFrancePcKeysFrozenDict()
		{
			this.EnsureFrancePcKeysCacheIfNeeded();
			return this.FrancePcKeysCache;
		}

		// Token: 0x06005C69 RID: 23657 RVA: 0x002189CC File Offset: 0x00216BCC
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetGamepadKeysFrozenDict()
		{
			this.EnsureGamepadKeysCacheIfNeeded();
			return this.GamepadKeysCache;
		}

		// Token: 0x06005C6A RID: 23658 RVA: 0x002189DA File Offset: 0x00216BDA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetGamepadVersionMapFrozenDict()
		{
			this.EnsureGamepadVersionMapCacheIfNeeded();
			return this.GamepadVersionMapCache;
		}

		// Token: 0x06005C6B RID: 23659 RVA: 0x002189E8 File Offset: 0x00216BE8
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetKeyboardVersionMapFrozenDict()
		{
			this.EnsureKeyboardVersionMapCacheIfNeeded();
			return this.KeyboardVersionMapCache;
		}

		// Token: 0x06005C6C RID: 23660 RVA: 0x002189F6 File Offset: 0x00216BF6
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetPcKeysFrozenDict()
		{
			this.EnsurePcKeysCacheIfNeeded();
			return this.PcKeysCache;
		}

		// Token: 0x06005C6D RID: 23661 RVA: 0x00218A04 File Offset: 0x00216C04
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetThaiPcKeysFrozenDict()
		{
			this.EnsureThaiPcKeysCacheIfNeeded();
			return this.ThaiPcKeysCache;
		}

		// Token: 0x0400516C RID: 20844
		private Table __p;

		// Token: 0x0400516D RID: 20845
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> FrancePcKeysCache;

		// Token: 0x0400516E RID: 20846
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> GamepadKeysCache;

		// Token: 0x0400516F RID: 20847
		[Nullable(2)]
		private FrozenDictionary<int, int> GamepadVersionMapCache;

		// Token: 0x04005170 RID: 20848
		[Nullable(2)]
		private FrozenDictionary<int, int> KeyboardVersionMapCache;

		// Token: 0x04005171 RID: 20849
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> PcKeysCache;

		// Token: 0x04005172 RID: 20850
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> ThaiPcKeysCache;
	}
}
