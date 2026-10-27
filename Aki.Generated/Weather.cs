using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200119E RID: 4510
	public struct Weather : IFlatbufferObject
	{
		// Token: 0x17003E3A RID: 15930
		// (get) Token: 0x0600E8A6 RID: 59558 RVA: 0x003445B5 File Offset: 0x003427B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E8A7 RID: 59559 RVA: 0x003445C2 File Offset: 0x003427C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E8A8 RID: 59560 RVA: 0x003445CC File Offset: 0x003427CC
		public static Weather GetRootAsWeather(ByteBuffer _bb)
		{
			return Weather.GetRootAsWeather(_bb, default(Weather));
		}

		// Token: 0x0600E8A9 RID: 59561 RVA: 0x003445E8 File Offset: 0x003427E8
		public static Weather GetRootAsWeather(ByteBuffer _bb, Weather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E8AA RID: 59562 RVA: 0x00344605 File Offset: 0x00342805
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E8AB RID: 59563 RVA: 0x00344614 File Offset: 0x00342814
		public Weather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E3B RID: 15931
		// (get) Token: 0x0600E8AC RID: 59564 RVA: 0x00344624 File Offset: 0x00342824
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

		// Token: 0x17003E3C RID: 15932
		// (get) Token: 0x0600E8AD RID: 59565 RVA: 0x00344660 File Offset: 0x00342860
		public int WeatherType
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

		// Token: 0x17003E3D RID: 15933
		// (get) Token: 0x0600E8AE RID: 59566 RVA: 0x0034469C File Offset: 0x0034289C
		public int PhotoWeatherType
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

		// Token: 0x17003E3E RID: 15934
		// (get) Token: 0x0600E8AF RID: 59567 RVA: 0x003446D8 File Offset: 0x003428D8
		public int Type
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

		// Token: 0x17003E3F RID: 15935
		// (get) Token: 0x0600E8B0 RID: 59568 RVA: 0x00344718 File Offset: 0x00342918
		public string DAPath
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

		// Token: 0x0600E8B1 RID: 59569 RVA: 0x00344750 File Offset: 0x00342950
		public Span<byte> GetDAPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E8B2 RID: 59570 RVA: 0x00344760 File Offset: 0x00342960
		public byte[] GetDAPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040052E9 RID: 21225
		private Table __p;
	}
}
