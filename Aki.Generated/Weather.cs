using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012D4 RID: 4820
	public struct Weather : IFlatbufferObject
	{
		// Token: 0x1700419F RID: 16799
		// (get) Token: 0x0600F617 RID: 62999 RVA: 0x0036F29D File Offset: 0x0036D49D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F618 RID: 63000 RVA: 0x0036F2AA File Offset: 0x0036D4AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F619 RID: 63001 RVA: 0x0036F2B4 File Offset: 0x0036D4B4
		public static Weather GetRootAsWeather(ByteBuffer _bb)
		{
			return Weather.GetRootAsWeather(_bb, default(Weather));
		}

		// Token: 0x0600F61A RID: 63002 RVA: 0x0036F2D0 File Offset: 0x0036D4D0
		public static Weather GetRootAsWeather(ByteBuffer _bb, Weather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F61B RID: 63003 RVA: 0x0036F2ED File Offset: 0x0036D4ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F61C RID: 63004 RVA: 0x0036F2FC File Offset: 0x0036D4FC
		public Weather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170041A0 RID: 16800
		// (get) Token: 0x0600F61D RID: 63005 RVA: 0x0036F30C File Offset: 0x0036D50C
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

		// Token: 0x170041A1 RID: 16801
		// (get) Token: 0x0600F61E RID: 63006 RVA: 0x0036F348 File Offset: 0x0036D548
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

		// Token: 0x170041A2 RID: 16802
		// (get) Token: 0x0600F61F RID: 63007 RVA: 0x0036F384 File Offset: 0x0036D584
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

		// Token: 0x170041A3 RID: 16803
		// (get) Token: 0x0600F620 RID: 63008 RVA: 0x0036F3C0 File Offset: 0x0036D5C0
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

		// Token: 0x170041A4 RID: 16804
		// (get) Token: 0x0600F621 RID: 63009 RVA: 0x0036F400 File Offset: 0x0036D600
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

		// Token: 0x0600F622 RID: 63010 RVA: 0x0036F438 File Offset: 0x0036D638
		public Span<byte> GetDAPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600F623 RID: 63011 RVA: 0x0036F448 File Offset: 0x0036D648
		public byte[] GetDAPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400592C RID: 22828
		private Table __p;
	}
}
