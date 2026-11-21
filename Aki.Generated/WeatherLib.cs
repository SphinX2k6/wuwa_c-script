using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012D5 RID: 4821
	public struct WeatherLib : IFlatbufferObject
	{
		// Token: 0x170041A5 RID: 16805
		// (get) Token: 0x0600F624 RID: 63012 RVA: 0x0036F460 File Offset: 0x0036D660
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F625 RID: 63013 RVA: 0x0036F46D File Offset: 0x0036D66D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F626 RID: 63014 RVA: 0x0036F474 File Offset: 0x0036D674
		public static WeatherLib GetRootAsWeatherLib(ByteBuffer _bb)
		{
			return WeatherLib.GetRootAsWeatherLib(_bb, default(WeatherLib));
		}

		// Token: 0x0600F627 RID: 63015 RVA: 0x0036F490 File Offset: 0x0036D690
		public static WeatherLib GetRootAsWeatherLib(ByteBuffer _bb, WeatherLib obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F628 RID: 63016 RVA: 0x0036F4AD File Offset: 0x0036D6AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F629 RID: 63017 RVA: 0x0036F4BC File Offset: 0x0036D6BC
		public WeatherLib __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170041A6 RID: 16806
		// (get) Token: 0x0600F62A RID: 63018 RVA: 0x0036F4CC File Offset: 0x0036D6CC
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

		// Token: 0x0600F62B RID: 63019 RVA: 0x0036F508 File Offset: 0x0036D708
		public int PhotoWeather(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170041A7 RID: 16807
		// (get) Token: 0x0600F62C RID: 63020 RVA: 0x0036F548 File Offset: 0x0036D748
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

		// Token: 0x0600F62D RID: 63021 RVA: 0x0036F573 File Offset: 0x0036D773
		public Span<int> GetPhotoWeatherBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600F62E RID: 63022 RVA: 0x0036F582 File Offset: 0x0036D782
		public int[] GetPhotoWeatherArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600F62F RID: 63023 RVA: 0x0036F599 File Offset: 0x0036D799
		[NullableContext(1)]
		public int[] PhotoWeather()
		{
			return this.GetPhotoWeatherArray();
		}

		// Token: 0x0600F630 RID: 63024 RVA: 0x0036F5A1 File Offset: 0x0036D7A1
		[NullableContext(1)]
		public IEnumerable<int> PhotoWeatherIter()
		{
			WeatherLib.<PhotoWeatherIter>d__16 <PhotoWeatherIter>d__ = new WeatherLib.<PhotoWeatherIter>d__16(-2);
			<PhotoWeatherIter>d__.<>3__<>4__this = this;
			return <PhotoWeatherIter>d__;
		}

		// Token: 0x0400592D RID: 22829
		private Table __p;
	}
}
