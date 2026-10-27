using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A0 RID: 4512
	public struct WeatherSwitch : IFlatbufferObject
	{
		// Token: 0x17003E43 RID: 15939
		// (get) Token: 0x0600E8C0 RID: 59584 RVA: 0x003448ED File Offset: 0x00342AED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E8C1 RID: 59585 RVA: 0x003448FA File Offset: 0x00342AFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E8C2 RID: 59586 RVA: 0x00344904 File Offset: 0x00342B04
		public static WeatherSwitch GetRootAsWeatherSwitch(ByteBuffer _bb)
		{
			return WeatherSwitch.GetRootAsWeatherSwitch(_bb, default(WeatherSwitch));
		}

		// Token: 0x0600E8C3 RID: 59587 RVA: 0x00344920 File Offset: 0x00342B20
		public static WeatherSwitch GetRootAsWeatherSwitch(ByteBuffer _bb, WeatherSwitch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E8C4 RID: 59588 RVA: 0x0034493D File Offset: 0x00342B3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E8C5 RID: 59589 RVA: 0x0034494C File Offset: 0x00342B4C
		public WeatherSwitch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E44 RID: 15940
		// (get) Token: 0x0600E8C6 RID: 59590 RVA: 0x0034495C File Offset: 0x00342B5C
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

		// Token: 0x17003E45 RID: 15941
		// (get) Token: 0x0600E8C7 RID: 59591 RVA: 0x00344998 File Offset: 0x00342B98
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

		// Token: 0x0600E8C8 RID: 59592 RVA: 0x003449CF File Offset: 0x00342BCF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E8C9 RID: 59593 RVA: 0x003449DE File Offset: 0x00342BDE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E8CA RID: 59594 RVA: 0x003449F8 File Offset: 0x00342BF8
		public DicIntInt? Weather(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003E46 RID: 15942
		// (get) Token: 0x0600E8CB RID: 59595 RVA: 0x00344A58 File Offset: 0x00342C58
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

		// Token: 0x0600E8CC RID: 59596 RVA: 0x00344A84 File Offset: 0x00342C84
		public int ValidTime(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E47 RID: 15943
		// (get) Token: 0x0600E8CD RID: 59597 RVA: 0x00344AC4 File Offset: 0x00342CC4
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

		// Token: 0x0600E8CE RID: 59598 RVA: 0x00344AF0 File Offset: 0x00342CF0
		public Span<int> GetValidTimeBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600E8CF RID: 59599 RVA: 0x00344B00 File Offset: 0x00342D00
		public int[] GetValidTimeArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17003E48 RID: 15944
		// (get) Token: 0x0600E8D0 RID: 59600 RVA: 0x00344B18 File Offset: 0x00342D18
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

		// Token: 0x17003E49 RID: 15945
		// (get) Token: 0x0600E8D1 RID: 59601 RVA: 0x00344B58 File Offset: 0x00342D58
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

		// Token: 0x17003E4A RID: 15946
		// (get) Token: 0x0600E8D2 RID: 59602 RVA: 0x00344B98 File Offset: 0x00342D98
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

		// Token: 0x0600E8D3 RID: 59603 RVA: 0x00344BD0 File Offset: 0x00342DD0
		public Span<byte> GetBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E8D4 RID: 59604 RVA: 0x00344BE0 File Offset: 0x00342DE0
		public byte[] GetBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E4B RID: 15947
		// (get) Token: 0x0600E8D5 RID: 59605 RVA: 0x00344BF8 File Offset: 0x00342DF8
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

		// Token: 0x0600E8D6 RID: 59606 RVA: 0x00344C30 File Offset: 0x00342E30
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E8D7 RID: 59607 RVA: 0x00344C40 File Offset: 0x00342E40
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E4C RID: 15948
		// (get) Token: 0x0600E8D8 RID: 59608 RVA: 0x00344C58 File Offset: 0x00342E58
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

		// Token: 0x0600E8D9 RID: 59609 RVA: 0x00344C98 File Offset: 0x00342E98
		public int BanAreaList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E4D RID: 15949
		// (get) Token: 0x0600E8DA RID: 59610 RVA: 0x00344CD8 File Offset: 0x00342ED8
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

		// Token: 0x0600E8DB RID: 59611 RVA: 0x00344D04 File Offset: 0x00342F04
		public Span<int> GetBanAreaListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600E8DC RID: 59612 RVA: 0x00344D14 File Offset: 0x00342F14
		public int[] GetBanAreaListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600E8DD RID: 59613 RVA: 0x00344D2C File Offset: 0x00342F2C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BanAreaListIter()或GetBanAreaListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BanAreaList()
		{
			WeatherSwitch weatherSwitch = this;
			return weatherSwitch.GetBanAreaListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E8DE RID: 59614 RVA: 0x00344D50 File Offset: 0x00342F50
		[NullableContext(1)]
		public readonly IEnumerable<int> BanAreaListIter()
		{
			WeatherSwitch.<BanAreaListIter>d__42 <BanAreaListIter>d__ = new WeatherSwitch.<BanAreaListIter>d__42(-2);
			<BanAreaListIter>d__.<>3__<>4__this = this;
			return <BanAreaListIter>d__;
		}

		// Token: 0x0600E8DF RID: 59615 RVA: 0x00344D68 File Offset: 0x00342F68
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ValidTimeIter()或GetValidTimeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ValidTime()
		{
			WeatherSwitch weatherSwitch = this;
			return weatherSwitch.GetValidTimeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E8E0 RID: 59616 RVA: 0x00344D8C File Offset: 0x00342F8C
		[NullableContext(1)]
		public readonly IEnumerable<int> ValidTimeIter()
		{
			WeatherSwitch.<ValidTimeIter>d__44 <ValidTimeIter>d__ = new WeatherSwitch.<ValidTimeIter>d__44(-2);
			<ValidTimeIter>d__.<>3__<>4__this = this;
			return <ValidTimeIter>d__;
		}

		// Token: 0x0600E8E1 RID: 59617 RVA: 0x00344DA4 File Offset: 0x00342FA4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用WeatherFrozenDict()缓存字典，遍历请使用WeatherIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Weather()
		{
			return this.WeatherIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600E8E2 RID: 59618 RVA: 0x00344DFA File Offset: 0x00342FFA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> WeatherIter()
		{
			WeatherSwitch.<WeatherIter>d__46 <WeatherIter>d__ = new WeatherSwitch.<WeatherIter>d__46(-2);
			<WeatherIter>d__.<>3__<>4__this = this;
			return <WeatherIter>d__;
		}

		// Token: 0x0600E8E3 RID: 59619 RVA: 0x00344E10 File Offset: 0x00343010
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

		// Token: 0x0600E8E4 RID: 59620 RVA: 0x00344E44 File Offset: 0x00343044
		private void EnsureWeatherCacheIfNeeded()
		{
			if (this.WeatherCache != null)
			{
				return;
			}
			this.WeatherCache = this.WeatherIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600E8E5 RID: 59621 RVA: 0x00344EAA File Offset: 0x003430AA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetWeatherFrozenDict(int key)
		{
			this.EnsureWeatherCacheIfNeeded();
			return this.WeatherCache;
		}

		// Token: 0x040052EB RID: 21227
		private Table __p;

		// Token: 0x040052EC RID: 21228
		[Nullable(2)]
		private FrozenDictionary<int, int> WeatherCache;
	}
}
