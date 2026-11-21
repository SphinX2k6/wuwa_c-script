using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001313 RID: 4883
	[NullableContext(1)]
	[Nullable(0)]
	public struct SCreatureGenBlackboardMaps : IFlatbufferObject
	{
		// Token: 0x17004286 RID: 17030
		// (get) Token: 0x0600F89C RID: 63644 RVA: 0x0037444E File Offset: 0x0037264E
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F89D RID: 63645 RVA: 0x0037445B File Offset: 0x0037265B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F89E RID: 63646 RVA: 0x00374464 File Offset: 0x00372664
		[NullableContext(0)]
		public static SCreatureGenBlackboardMaps GetRootAsSCreatureGenBlackboardMaps(ByteBuffer _bb)
		{
			return SCreatureGenBlackboardMaps.GetRootAsSCreatureGenBlackboardMaps(_bb, default(SCreatureGenBlackboardMaps));
		}

		// Token: 0x0600F89F RID: 63647 RVA: 0x00374480 File Offset: 0x00372680
		[NullableContext(0)]
		public static SCreatureGenBlackboardMaps GetRootAsSCreatureGenBlackboardMaps(ByteBuffer _bb, SCreatureGenBlackboardMaps obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F8A0 RID: 63648 RVA: 0x0037449D File Offset: 0x0037269D
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F8A1 RID: 63649 RVA: 0x003744AC File Offset: 0x003726AC
		[NullableContext(0)]
		public SCreatureGenBlackboardMaps __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600F8A2 RID: 63650 RVA: 0x003744BC File Offset: 0x003726BC
		public DicStringString? MapString(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17004287 RID: 17031
		// (get) Token: 0x0600F8A3 RID: 63651 RVA: 0x0037451C File Offset: 0x0037271C
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

		// Token: 0x0600F8A4 RID: 63652 RVA: 0x00374548 File Offset: 0x00372748
		public DicStringInt? MapInt(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17004288 RID: 17032
		// (get) Token: 0x0600F8A5 RID: 63653 RVA: 0x003745A8 File Offset: 0x003727A8
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

		// Token: 0x0600F8A6 RID: 63654 RVA: 0x003745D4 File Offset: 0x003727D4
		public DicStringBool? MapBool(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringBool?(default(DicStringBool).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17004289 RID: 17033
		// (get) Token: 0x0600F8A7 RID: 63655 RVA: 0x00374634 File Offset: 0x00372834
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

		// Token: 0x0600F8A8 RID: 63656 RVA: 0x00374660 File Offset: 0x00372860
		public Dictionary<string, bool> MapBool()
		{
			return this.MapBoolIter().ToDictionary((DicStringBool element) => element.Key, (DicStringBool element) => element.Value);
		}

		// Token: 0x0600F8A9 RID: 63657 RVA: 0x003746B6 File Offset: 0x003728B6
		public IEnumerable<DicStringBool> MapBoolIter()
		{
			SCreatureGenBlackboardMaps.<MapBoolIter>d__18 <MapBoolIter>d__ = new SCreatureGenBlackboardMaps.<MapBoolIter>d__18(-2);
			<MapBoolIter>d__.<>3__<>4__this = this;
			return <MapBoolIter>d__;
		}

		// Token: 0x0600F8AA RID: 63658 RVA: 0x003746CC File Offset: 0x003728CC
		public Dictionary<string, int> MapInt()
		{
			return this.MapIntIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600F8AB RID: 63659 RVA: 0x00374722 File Offset: 0x00372922
		public IEnumerable<DicStringInt> MapIntIter()
		{
			SCreatureGenBlackboardMaps.<MapIntIter>d__20 <MapIntIter>d__ = new SCreatureGenBlackboardMaps.<MapIntIter>d__20(-2);
			<MapIntIter>d__.<>3__<>4__this = this;
			return <MapIntIter>d__;
		}

		// Token: 0x0600F8AC RID: 63660 RVA: 0x00374738 File Offset: 0x00372938
		public Dictionary<string, string> MapString()
		{
			return this.MapStringIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600F8AD RID: 63661 RVA: 0x0037478E File Offset: 0x0037298E
		public IEnumerable<DicStringString> MapStringIter()
		{
			SCreatureGenBlackboardMaps.<MapStringIter>d__22 <MapStringIter>d__ = new SCreatureGenBlackboardMaps.<MapStringIter>d__22(-2);
			<MapStringIter>d__.<>3__<>4__this = this;
			return <MapStringIter>d__;
		}

		// Token: 0x0600F8AE RID: 63662 RVA: 0x003747A4 File Offset: 0x003729A4
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

		// Token: 0x0600F8AF RID: 63663 RVA: 0x003747D8 File Offset: 0x003729D8
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

		// Token: 0x0600F8B0 RID: 63664 RVA: 0x0037480C File Offset: 0x00372A0C
		[return: Nullable(2)]
		public string GetMapString(string key)
		{
			this.EnsureMapStringCacheIfNeeded();
			string result;
			if (!this.MapStringCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600F8B1 RID: 63665 RVA: 0x00374834 File Offset: 0x00372A34
		private void EnsureMapBoolCacheIfNeeded()
		{
			if (this.MapBoolCache != null)
			{
				return;
			}
			this.MapBoolCache = this.MapBoolIter().ToFrozenDictionary((DicStringBool kvp) => kvp.Key, (DicStringBool kvp) => kvp.Value, null);
		}

		// Token: 0x0600F8B2 RID: 63666 RVA: 0x0037489C File Offset: 0x00372A9C
		private void EnsureMapIntCacheIfNeeded()
		{
			if (this.MapIntCache != null)
			{
				return;
			}
			this.MapIntCache = this.MapIntIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600F8B3 RID: 63667 RVA: 0x00374904 File Offset: 0x00372B04
		private void EnsureMapStringCacheIfNeeded()
		{
			if (this.MapStringCache != null)
			{
				return;
			}
			this.MapStringCache = this.MapStringIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600F8B4 RID: 63668 RVA: 0x0037496A File Offset: 0x00372B6A
		public FrozenDictionary<string, bool> GetMapBoolFrozenDict()
		{
			this.EnsureMapBoolCacheIfNeeded();
			return this.MapBoolCache;
		}

		// Token: 0x0600F8B5 RID: 63669 RVA: 0x00374978 File Offset: 0x00372B78
		public FrozenDictionary<string, int> GetMapIntFrozenDict()
		{
			this.EnsureMapIntCacheIfNeeded();
			return this.MapIntCache;
		}

		// Token: 0x0600F8B6 RID: 63670 RVA: 0x00374986 File Offset: 0x00372B86
		public FrozenDictionary<string, string> GetMapStringFrozenDict()
		{
			this.EnsureMapStringCacheIfNeeded();
			return this.MapStringCache;
		}

		// Token: 0x04005993 RID: 22931
		private Table __p;

		// Token: 0x04005994 RID: 22932
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, bool> MapBoolCache;

		// Token: 0x04005995 RID: 22933
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> MapIntCache;

		// Token: 0x04005996 RID: 22934
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> MapStringCache;
	}
}
