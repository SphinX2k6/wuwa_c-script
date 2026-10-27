using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC0 RID: 2752
	public struct ActionMapping : IFlatbufferObject
	{
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600429E RID: 17054 RVA: 0x001CA4E4 File Offset: 0x001C86E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600429F RID: 17055 RVA: 0x001CA4F1 File Offset: 0x001C86F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060042A0 RID: 17056 RVA: 0x001CA4F8 File Offset: 0x001C86F8
		public static ActionMapping GetRootAsActionMapping(ByteBuffer _bb)
		{
			return ActionMapping.GetRootAsActionMapping(_bb, default(ActionMapping));
		}

		// Token: 0x060042A1 RID: 17057 RVA: 0x001CA514 File Offset: 0x001C8714
		public static ActionMapping GetRootAsActionMapping(ByteBuffer _bb, ActionMapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060042A2 RID: 17058 RVA: 0x001CA531 File Offset: 0x001C8731
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x001CA540 File Offset: 0x001C8740
		public ActionMapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060042A4 RID: 17060 RVA: 0x001CA550 File Offset: 0x001C8750
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
		// (get) Token: 0x060042A5 RID: 17061 RVA: 0x001CA58C File Offset: 0x001C878C
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

		// Token: 0x060042A6 RID: 17062 RVA: 0x001CA5C3 File Offset: 0x001C87C3
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060042A7 RID: 17063 RVA: 0x001CA5D2 File Offset: 0x001C87D2
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060042A8 RID: 17064 RVA: 0x001CA5EC File Offset: 0x001C87EC
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
		// (get) Token: 0x060042A9 RID: 17065 RVA: 0x001CA628 File Offset: 0x001C8828
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

		// Token: 0x060042AA RID: 17066 RVA: 0x001CA660 File Offset: 0x001C8860
		public Span<byte> GetInputTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x001CA670 File Offset: 0x001C8870
		public byte[] GetInputTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060042AC RID: 17068 RVA: 0x001CA688 File Offset: 0x001C8888
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

		// Token: 0x060042AD RID: 17069 RVA: 0x001CA6C8 File Offset: 0x001C88C8
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
		// (get) Token: 0x060042AE RID: 17070 RVA: 0x001CA704 File Offset: 0x001C8904
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

		// Token: 0x060042AF RID: 17071 RVA: 0x001CA730 File Offset: 0x001C8930
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
		// (get) Token: 0x060042B0 RID: 17072 RVA: 0x001CA76C File Offset: 0x001C896C
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

		// Token: 0x060042B1 RID: 17073 RVA: 0x001CA798 File Offset: 0x001C8998
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
		// (get) Token: 0x060042B2 RID: 17074 RVA: 0x001CA7D4 File Offset: 0x001C89D4
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

		// Token: 0x060042B3 RID: 17075 RVA: 0x001CA800 File Offset: 0x001C8A00
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
		// (get) Token: 0x060042B4 RID: 17076 RVA: 0x001CA83C File Offset: 0x001C8A3C
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
		// (get) Token: 0x060042B5 RID: 17077 RVA: 0x001CA868 File Offset: 0x001C8A68
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

		// Token: 0x060042B6 RID: 17078 RVA: 0x001CA8A0 File Offset: 0x001C8AA0
		public Span<byte> GetMobileIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x001CA8B0 File Offset: 0x001C8AB0
		public byte[] GetMobileIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060042B8 RID: 17080 RVA: 0x001CA8C8 File Offset: 0x001C8AC8
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

		// Token: 0x060042B9 RID: 17081 RVA: 0x001CA900 File Offset: 0x001C8B00
		public Span<byte> GetDisplayNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x001CA910 File Offset: 0x001C8B10
		public byte[] GetDisplayNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060042BB RID: 17083 RVA: 0x001CA928 File Offset: 0x001C8B28
		public bool IsIdleAction
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x001CA968 File Offset: 0x001C8B68
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
		// (get) Token: 0x060042BD RID: 17085 RVA: 0x001CA9CC File Offset: 0x001C8BCC
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

		// Token: 0x060042BE RID: 17086 RVA: 0x001CA9F8 File Offset: 0x001C8BF8
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
		// (get) Token: 0x060042BF RID: 17087 RVA: 0x001CAA5C File Offset: 0x001C8C5C
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

		// Token: 0x060042C0 RID: 17088 RVA: 0x001CAA88 File Offset: 0x001C8C88
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FrancePcKeysIter()或GetFrancePcKeysBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] FrancePcKeys()
		{
			return this.FrancePcKeysIter().ToArray<string>();
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x001CAA95 File Offset: 0x001C8C95
		[NullableContext(1)]
		public readonly IEnumerable<string> FrancePcKeysIter()
		{
			ActionMapping.<FrancePcKeysIter>d__51 <FrancePcKeysIter>d__ = new ActionMapping.<FrancePcKeysIter>d__51(-2);
			<FrancePcKeysIter>d__.<>3__<>4__this = this;
			return <FrancePcKeysIter>d__;
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x001CAAAA File Offset: 0x001C8CAA
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GamepadKeysIter()或GetGamepadKeysBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] GamepadKeys()
		{
			return this.GamepadKeysIter().ToArray<string>();
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x001CAAB7 File Offset: 0x001C8CB7
		[NullableContext(1)]
		public readonly IEnumerable<string> GamepadKeysIter()
		{
			ActionMapping.<GamepadKeysIter>d__53 <GamepadKeysIter>d__ = new ActionMapping.<GamepadKeysIter>d__53(-2);
			<GamepadKeysIter>d__.<>3__<>4__this = this;
			return <GamepadKeysIter>d__;
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x001CAACC File Offset: 0x001C8CCC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用GamepadVersionMapFrozenDict()缓存字典，遍历请使用GamepadVersionMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> GamepadVersionMap()
		{
			return this.GamepadVersionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x001CAB22 File Offset: 0x001C8D22
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> GamepadVersionMapIter()
		{
			ActionMapping.<GamepadVersionMapIter>d__55 <GamepadVersionMapIter>d__ = new ActionMapping.<GamepadVersionMapIter>d__55(-2);
			<GamepadVersionMapIter>d__.<>3__<>4__this = this;
			return <GamepadVersionMapIter>d__;
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x001CAB38 File Offset: 0x001C8D38
		[NullableContext(1)]
		[Obsolete("已废弃，请使用KeyboardVersionMapFrozenDict()缓存字典，遍历请使用KeyboardVersionMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> KeyboardVersionMap()
		{
			return this.KeyboardVersionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x001CAB8E File Offset: 0x001C8D8E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> KeyboardVersionMapIter()
		{
			ActionMapping.<KeyboardVersionMapIter>d__57 <KeyboardVersionMapIter>d__ = new ActionMapping.<KeyboardVersionMapIter>d__57(-2);
			<KeyboardVersionMapIter>d__.<>3__<>4__this = this;
			return <KeyboardVersionMapIter>d__;
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x001CABA3 File Offset: 0x001C8DA3
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PcKeysIter()或GetPcKeysBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] PcKeys()
		{
			return this.PcKeysIter().ToArray<string>();
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x001CABB0 File Offset: 0x001C8DB0
		[NullableContext(1)]
		public readonly IEnumerable<string> PcKeysIter()
		{
			ActionMapping.<PcKeysIter>d__59 <PcKeysIter>d__ = new ActionMapping.<PcKeysIter>d__59(-2);
			<PcKeysIter>d__.<>3__<>4__this = this;
			return <PcKeysIter>d__;
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x001CABC5 File Offset: 0x001C8DC5
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ThaiPcKeysIter()或GetThaiPcKeysBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ThaiPcKeys()
		{
			return this.ThaiPcKeysIter().ToArray<string>();
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x001CABD2 File Offset: 0x001C8DD2
		[NullableContext(1)]
		public readonly IEnumerable<string> ThaiPcKeysIter()
		{
			ActionMapping.<ThaiPcKeysIter>d__61 <ThaiPcKeysIter>d__ = new ActionMapping.<ThaiPcKeysIter>d__61(-2);
			<ThaiPcKeysIter>d__.<>3__<>4__this = this;
			return <ThaiPcKeysIter>d__;
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x001CABE8 File Offset: 0x001C8DE8
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

		// Token: 0x060042CD RID: 17101 RVA: 0x001CAC1C File Offset: 0x001C8E1C
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

		// Token: 0x060042CE RID: 17102 RVA: 0x001CAC50 File Offset: 0x001C8E50
		private void EnsureGamepadVersionMapCacheIfNeeded()
		{
			if (this.GamepadVersionMapCache != null)
			{
				return;
			}
			this.GamepadVersionMapCache = this.GamepadVersionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060042CF RID: 17103 RVA: 0x001CACB8 File Offset: 0x001C8EB8
		private void EnsureKeyboardVersionMapCacheIfNeeded()
		{
			if (this.KeyboardVersionMapCache != null)
			{
				return;
			}
			this.KeyboardVersionMapCache = this.KeyboardVersionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060042D0 RID: 17104 RVA: 0x001CAD1E File Offset: 0x001C8F1E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetGamepadVersionMapFrozenDict(int key)
		{
			this.EnsureGamepadVersionMapCacheIfNeeded();
			return this.GamepadVersionMapCache;
		}

		// Token: 0x060042D1 RID: 17105 RVA: 0x001CAD2C File Offset: 0x001C8F2C
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetKeyboardVersionMapFrozenDict(int key)
		{
			this.EnsureKeyboardVersionMapCacheIfNeeded();
			return this.KeyboardVersionMapCache;
		}

		// Token: 0x04004A9A RID: 19098
		private Table __p;

		// Token: 0x04004A9B RID: 19099
		[Nullable(2)]
		private FrozenDictionary<int, int> GamepadVersionMapCache;

		// Token: 0x04004A9C RID: 19100
		[Nullable(2)]
		private FrozenDictionary<int, int> KeyboardVersionMapCache;
	}
}
