using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200119F RID: 4511
	public struct WeatherLib : IFlatbufferObject
	{
		// Token: 0x17003E40 RID: 15936
		// (get) Token: 0x0600E8B3 RID: 59571 RVA: 0x00344778 File Offset: 0x00342978
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E8B4 RID: 59572 RVA: 0x00344785 File Offset: 0x00342985
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E8B5 RID: 59573 RVA: 0x0034478C File Offset: 0x0034298C
		public static WeatherLib GetRootAsWeatherLib(ByteBuffer _bb)
		{
			return WeatherLib.GetRootAsWeatherLib(_bb, default(WeatherLib));
		}

		// Token: 0x0600E8B6 RID: 59574 RVA: 0x003447A8 File Offset: 0x003429A8
		public static WeatherLib GetRootAsWeatherLib(ByteBuffer _bb, WeatherLib obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E8B7 RID: 59575 RVA: 0x003447C5 File Offset: 0x003429C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E8B8 RID: 59576 RVA: 0x003447D4 File Offset: 0x003429D4
		public WeatherLib __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E41 RID: 15937
		// (get) Token: 0x0600E8B9 RID: 59577 RVA: 0x003447E4 File Offset: 0x003429E4
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

		// Token: 0x0600E8BA RID: 59578 RVA: 0x00344820 File Offset: 0x00342A20
		public int PhotoWeather(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E42 RID: 15938
		// (get) Token: 0x0600E8BB RID: 59579 RVA: 0x00344860 File Offset: 0x00342A60
		public int PhotoWeatherLength
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

		// Token: 0x0600E8BC RID: 59580 RVA: 0x0034488B File Offset: 0x00342A8B
		public Span<int> GetPhotoWeatherBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600E8BD RID: 59581 RVA: 0x0034489A File Offset: 0x00342A9A
		public int[] GetPhotoWeatherArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600E8BE RID: 59582 RVA: 0x003448B4 File Offset: 0x00342AB4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PhotoWeatherIter()或GetPhotoWeatherBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PhotoWeather()
		{
			WeatherLib weatherLib = this;
			return weatherLib.GetPhotoWeatherArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E8BF RID: 59583 RVA: 0x003448D8 File Offset: 0x00342AD8
		[NullableContext(1)]
		public readonly IEnumerable<int> PhotoWeatherIter()
		{
			WeatherLib.<PhotoWeatherIter>d__16 <PhotoWeatherIter>d__ = new WeatherLib.<PhotoWeatherIter>d__16(-2);
			<PhotoWeatherIter>d__.<>3__<>4__this = this;
			return <PhotoWeatherIter>d__;
		}

		// Token: 0x040052EA RID: 21226
		private Table __p;
	}
}
