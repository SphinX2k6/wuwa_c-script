using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012D6 RID: 4822
	public struct WeatherSwitch : IFlatbufferObject
	{
		// Token: 0x170041A8 RID: 16808
		// (get) Token: 0x0600F631 RID: 63025 RVA: 0x0036F5B6 File Offset: 0x0036D7B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F632 RID: 63026 RVA: 0x0036F5C3 File Offset: 0x0036D7C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F633 RID: 63027 RVA: 0x0036F5CC File Offset: 0x0036D7CC
		public static WeatherSwitch GetRootAsWeatherSwitch(ByteBuffer _bb)
		{
			return WeatherSwitch.GetRootAsWeatherSwitch(_bb, default(WeatherSwitch));
		}

		// Token: 0x0600F634 RID: 63028 RVA: 0x0036F5E8 File Offset: 0x0036D7E8
		public static WeatherSwitch GetRootAsWeatherSwitch(ByteBuffer _bb, WeatherSwitch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F635 RID: 63029 RVA: 0x0036F605 File Offset: 0x0036D805
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F636 RID: 63030 RVA: 0x0036F614 File Offset: 0x0036D814
		public WeatherSwitch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170041A9 RID: 16809
		// (get) Token: 0x0600F637 RID: 63031 RVA: 0x0036F624 File Offset: 0x0036D824
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

		// Token: 0x170041AA RID: 16810
		// (get) Token: 0x0600F638 RID: 63032 RVA: 0x0036F660 File Offset: 0x0036D860
		public string Name
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

		// Token: 0x0600F639 RID: 63033 RVA: 0x0036F697 File Offset: 0x0036D897
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F63A RID: 63034 RVA: 0x0036F6A6 File Offset: 0x0036D8A6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F63B RID: 63035 RVA: 0x0036F6C0 File Offset: 0x0036D8C0
		public DicIntInt? Weather(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170041AB RID: 16811
		// (get) Token: 0x0600F63C RID: 63036 RVA: 0x0036F720 File Offset: 0x0036D920
		public int WeatherLength
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

		// Token: 0x0600F63D RID: 63037 RVA: 0x0036F74C File Offset: 0x0036D94C
		public int ValidTime(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170041AC RID: 16812
		// (get) Token: 0x0600F63E RID: 63038 RVA: 0x0036F78C File Offset: 0x0036D98C
		public int ValidTimeLength
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

		// Token: 0x0600F63F RID: 63039 RVA: 0x0036F7B8 File Offset: 0x0036D9B8
		public Span<int> GetValidTimeBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600F640 RID: 63040 RVA: 0x0036F7C8 File Offset: 0x0036D9C8
		public int[] GetValidTimeArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170041AD RID: 16813
		// (get) Token: 0x0600F641 RID: 63041 RVA: 0x0036F7E0 File Offset: 0x0036D9E0
		public int UnlockCondition
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

		// Token: 0x170041AE RID: 16814
		// (get) Token: 0x0600F642 RID: 63042 RVA: 0x0036F820 File Offset: 0x0036DA20
		public int MarkConfigId
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

		// Token: 0x170041AF RID: 16815
		// (get) Token: 0x0600F643 RID: 63043 RVA: 0x0036F860 File Offset: 0x0036DA60
		public string Background
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F644 RID: 63044 RVA: 0x0036F898 File Offset: 0x0036DA98
		public Span<byte> GetBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600F645 RID: 63045 RVA: 0x0036F8A8 File Offset: 0x0036DAA8
		public byte[] GetBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170041B0 RID: 16816
		// (get) Token: 0x0600F646 RID: 63046 RVA: 0x0036F8C0 File Offset: 0x0036DAC0
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F647 RID: 63047 RVA: 0x0036F8F8 File Offset: 0x0036DAF8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600F648 RID: 63048 RVA: 0x0036F908 File Offset: 0x0036DB08
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170041B1 RID: 16817
		// (get) Token: 0x0600F649 RID: 63049 RVA: 0x0036F920 File Offset: 0x0036DB20
		public int QuestId
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

		// Token: 0x0600F64A RID: 63050 RVA: 0x0036F960 File Offset: 0x0036DB60
		public int BanAreaList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170041B2 RID: 16818
		// (get) Token: 0x0600F64B RID: 63051 RVA: 0x0036F9A0 File Offset: 0x0036DBA0
		public int BanAreaListLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F64C RID: 63052 RVA: 0x0036F9CC File Offset: 0x0036DBCC
		public Span<int> GetBanAreaListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600F64D RID: 63053 RVA: 0x0036F9DC File Offset: 0x0036DBDC
		public int[] GetBanAreaListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600F64E RID: 63054 RVA: 0x0036F9F4 File Offset: 0x0036DBF4
		[NullableContext(1)]
		public int[] BanAreaList()
		{
			return this.GetBanAreaListArray();
		}

		// Token: 0x0600F64F RID: 63055 RVA: 0x0036F9FC File Offset: 0x0036DBFC
		[NullableContext(1)]
		public IEnumerable<int> BanAreaListIter()
		{
			WeatherSwitch.<BanAreaListIter>d__42 <BanAreaListIter>d__ = new WeatherSwitch.<BanAreaListIter>d__42(-2);
			<BanAreaListIter>d__.<>3__<>4__this = this;
			return <BanAreaListIter>d__;
		}

		// Token: 0x0600F650 RID: 63056 RVA: 0x0036FA11 File Offset: 0x0036DC11
		[NullableContext(1)]
		public int[] ValidTime()
		{
			return this.GetValidTimeArray();
		}

		// Token: 0x0600F651 RID: 63057 RVA: 0x0036FA19 File Offset: 0x0036DC19
		[NullableContext(1)]
		public IEnumerable<int> ValidTimeIter()
		{
			WeatherSwitch.<ValidTimeIter>d__44 <ValidTimeIter>d__ = new WeatherSwitch.<ValidTimeIter>d__44(-2);
			<ValidTimeIter>d__.<>3__<>4__this = this;
			return <ValidTimeIter>d__;
		}

		// Token: 0x0600F652 RID: 63058 RVA: 0x0036FA30 File Offset: 0x0036DC30
		[NullableContext(1)]
		public Dictionary<int, int> Weather()
		{
			return this.WeatherIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600F653 RID: 63059 RVA: 0x0036FA86 File Offset: 0x0036DC86
		[NullableContext(1)]
		public IEnumerable<DicIntInt> WeatherIter()
		{
			WeatherSwitch.<WeatherIter>d__46 <WeatherIter>d__ = new WeatherSwitch.<WeatherIter>d__46(-2);
			<WeatherIter>d__.<>3__<>4__this = this;
			return <WeatherIter>d__;
		}

		// Token: 0x0600F654 RID: 63060 RVA: 0x0036FA9C File Offset: 0x0036DC9C
		public int? GetWeather(int key)
		{
			this.EnsureWeatherCacheIfNeeded();
			int value;
			if (!this.WeatherCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600F655 RID: 63061 RVA: 0x0036FAD0 File Offset: 0x0036DCD0
		private void EnsureWeatherCacheIfNeeded()
		{
			if (this.WeatherCache != null)
			{
				return;
			}
			this.WeatherCache = this.WeatherIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600F656 RID: 63062 RVA: 0x0036FB36 File Offset: 0x0036DD36
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetWeatherFrozenDict()
		{
			this.EnsureWeatherCacheIfNeeded();
			return this.WeatherCache;
		}

		// Token: 0x0400592E RID: 22830
		private Table __p;

		// Token: 0x0400592F RID: 22831
		[Nullable(2)]
		private FrozenDictionary<int, int> WeatherCache;
	}
}
