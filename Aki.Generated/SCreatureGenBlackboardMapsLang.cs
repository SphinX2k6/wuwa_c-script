using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001314 RID: 4884
	[NullableContext(1)]
	[Nullable(0)]
	public struct SCreatureGenBlackboardMapsLang : IFlatbufferObject
	{
		// Token: 0x1700428A RID: 17034
		// (get) Token: 0x0600F8B7 RID: 63671 RVA: 0x00374994 File Offset: 0x00372B94
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F8B8 RID: 63672 RVA: 0x003749A1 File Offset: 0x00372BA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F8B9 RID: 63673 RVA: 0x003749A8 File Offset: 0x00372BA8
		[NullableContext(0)]
		public static SCreatureGenBlackboardMapsLang GetRootAsSCreatureGenBlackboardMapsLang(ByteBuffer _bb)
		{
			return SCreatureGenBlackboardMapsLang.GetRootAsSCreatureGenBlackboardMapsLang(_bb, default(SCreatureGenBlackboardMapsLang));
		}

		// Token: 0x0600F8BA RID: 63674 RVA: 0x003749C4 File Offset: 0x00372BC4
		[NullableContext(0)]
		public static SCreatureGenBlackboardMapsLang GetRootAsSCreatureGenBlackboardMapsLang(ByteBuffer _bb, SCreatureGenBlackboardMapsLang obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F8BB RID: 63675 RVA: 0x003749E1 File Offset: 0x00372BE1
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F8BC RID: 63676 RVA: 0x003749F0 File Offset: 0x00372BF0
		[NullableContext(0)]
		public SCreatureGenBlackboardMapsLang __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600F8BD RID: 63677 RVA: 0x00374A00 File Offset: 0x00372C00
		public DicStringInt? MapString(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700428B RID: 17035
		// (get) Token: 0x0600F8BE RID: 63678 RVA: 0x00374A60 File Offset: 0x00372C60
		public int MapStringLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F8BF RID: 63679 RVA: 0x00374A8C File Offset: 0x00372C8C
		public DicStringInt? MapInt(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700428C RID: 17036
		// (get) Token: 0x0600F8C0 RID: 63680 RVA: 0x00374AEC File Offset: 0x00372CEC
		public int MapIntLength
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

		// Token: 0x0600F8C1 RID: 63681 RVA: 0x00374B18 File Offset: 0x00372D18
		public DicStringBool? MapBool(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringBool?(default(DicStringBool).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700428D RID: 17037
		// (get) Token: 0x0600F8C2 RID: 63682 RVA: 0x00374B78 File Offset: 0x00372D78
		public int MapBoolLength
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

		// Token: 0x0600F8C3 RID: 63683 RVA: 0x00374BA4 File Offset: 0x00372DA4
		public Dictionary<string, bool> MapBool()
		{
			return this.MapBoolIter().ToDictionary((DicStringBool element) => element.Key, (DicStringBool element) => element.Value);
		}

		// Token: 0x0600F8C4 RID: 63684 RVA: 0x00374BFA File Offset: 0x00372DFA
		public IEnumerable<DicStringBool> MapBoolIter()
		{
			SCreatureGenBlackboardMapsLang.<MapBoolIter>d__18 <MapBoolIter>d__ = new SCreatureGenBlackboardMapsLang.<MapBoolIter>d__18(-2);
			<MapBoolIter>d__.<>3__<>4__this = this;
			return <MapBoolIter>d__;
		}

		// Token: 0x0600F8C5 RID: 63685 RVA: 0x00374C10 File Offset: 0x00372E10
		public Dictionary<string, int> MapInt()
		{
			return this.MapIntIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600F8C6 RID: 63686 RVA: 0x00374C66 File Offset: 0x00372E66
		public IEnumerable<DicStringInt> MapIntIter()
		{
			SCreatureGenBlackboardMapsLang.<MapIntIter>d__20 <MapIntIter>d__ = new SCreatureGenBlackboardMapsLang.<MapIntIter>d__20(-2);
			<MapIntIter>d__.<>3__<>4__this = this;
			return <MapIntIter>d__;
		}

		// Token: 0x0600F8C7 RID: 63687 RVA: 0x00374C7C File Offset: 0x00372E7C
		public Dictionary<string, int> MapString()
		{
			return this.MapStringIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600F8C8 RID: 63688 RVA: 0x00374CD2 File Offset: 0x00372ED2
		public IEnumerable<DicStringInt> MapStringIter()
		{
			SCreatureGenBlackboardMapsLang.<MapStringIter>d__22 <MapStringIter>d__ = new SCreatureGenBlackboardMapsLang.<MapStringIter>d__22(-2);
			<MapStringIter>d__.<>3__<>4__this = this;
			return <MapStringIter>d__;
		}

		// Token: 0x0600F8C9 RID: 63689 RVA: 0x00374CE8 File Offset: 0x00372EE8
		public bool? GetMapBool(string key)
		{
			this.EnsureMapBoolCacheIfNeeded();
			bool value;
			if (!this.MapBoolCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new bool?(value);
		}

		// Token: 0x0600F8CA RID: 63690 RVA: 0x00374D1C File Offset: 0x00372F1C
		public int? GetMapInt(string key)
		{
			this.EnsureMapIntCacheIfNeeded();
			int value;
			if (!this.MapIntCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600F8CB RID: 63691 RVA: 0x00374D50 File Offset: 0x00372F50
		public int? GetMapString(string key)
		{
			this.EnsureMapStringCacheIfNeeded();
			int value;
			if (!this.MapStringCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600F8CC RID: 63692 RVA: 0x00374D84 File Offset: 0x00372F84
		private void EnsureMapBoolCacheIfNeeded()
		{
			if (this.MapBoolCache != null)
			{
				return;
			}
			this.MapBoolCache = this.MapBoolIter().ToFrozenDictionary((DicStringBool kvp) => kvp.Key, (DicStringBool kvp) => kvp.Value, null);
		}

		// Token: 0x0600F8CD RID: 63693 RVA: 0x00374DEC File Offset: 0x00372FEC
		private void EnsureMapIntCacheIfNeeded()
		{
			if (this.MapIntCache != null)
			{
				return;
			}
			this.MapIntCache = this.MapIntIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600F8CE RID: 63694 RVA: 0x00374E54 File Offset: 0x00373054
		private void EnsureMapStringCacheIfNeeded()
		{
			if (this.MapStringCache != null)
			{
				return;
			}
			this.MapStringCache = this.MapStringIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600F8CF RID: 63695 RVA: 0x00374EBA File Offset: 0x003730BA
		public FrozenDictionary<string, bool> GetMapBoolFrozenDict()
		{
			this.EnsureMapBoolCacheIfNeeded();
			return this.MapBoolCache;
		}

		// Token: 0x0600F8D0 RID: 63696 RVA: 0x00374EC8 File Offset: 0x003730C8
		public FrozenDictionary<string, int> GetMapIntFrozenDict()
		{
			this.EnsureMapIntCacheIfNeeded();
			return this.MapIntCache;
		}

		// Token: 0x0600F8D1 RID: 63697 RVA: 0x00374ED6 File Offset: 0x003730D6
		public FrozenDictionary<string, int> GetMapStringFrozenDict()
		{
			this.EnsureMapStringCacheIfNeeded();
			return this.MapStringCache;
		}

		// Token: 0x04005997 RID: 22935
		private Table __p;

		// Token: 0x04005998 RID: 22936
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, bool> MapBoolCache;

		// Token: 0x04005999 RID: 22937
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> MapIntCache;

		// Token: 0x0400599A RID: 22938
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> MapStringCache;
	}
}
