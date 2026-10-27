using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D42 RID: 3394
	public struct HonamiStoryOutDialog : IFlatbufferObject
	{
		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x06008093 RID: 32915 RVA: 0x00258C91 File Offset: 0x00256E91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008094 RID: 32916 RVA: 0x00258C9E File Offset: 0x00256E9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008095 RID: 32917 RVA: 0x00258CA8 File Offset: 0x00256EA8
		public static HonamiStoryOutDialog GetRootAsHonamiStoryOutDialog(ByteBuffer _bb)
		{
			return HonamiStoryOutDialog.GetRootAsHonamiStoryOutDialog(_bb, default(HonamiStoryOutDialog));
		}

		// Token: 0x06008096 RID: 32918 RVA: 0x00258CC4 File Offset: 0x00256EC4
		public static HonamiStoryOutDialog GetRootAsHonamiStoryOutDialog(ByteBuffer _bb, HonamiStoryOutDialog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008097 RID: 32919 RVA: 0x00258CE1 File Offset: 0x00256EE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008098 RID: 32920 RVA: 0x00258CF0 File Offset: 0x00256EF0
		public HonamiStoryOutDialog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x06008099 RID: 32921 RVA: 0x00258D00 File Offset: 0x00256F00
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

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x0600809A RID: 32922 RVA: 0x00258D3C File Offset: 0x00256F3C
		public int ActivityId
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

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x0600809B RID: 32923 RVA: 0x00258D78 File Offset: 0x00256F78
		public int Type
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

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x0600809C RID: 32924 RVA: 0x00258DB4 File Offset: 0x00256FB4
		public int Interval
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

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x0600809D RID: 32925 RVA: 0x00258DF4 File Offset: 0x00256FF4
		public string Name
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

		// Token: 0x0600809E RID: 32926 RVA: 0x00258E2C File Offset: 0x0025702C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600809F RID: 32927 RVA: 0x00258E3C File Offset: 0x0025703C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x060080A0 RID: 32928 RVA: 0x00258E54 File Offset: 0x00257054
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060080A1 RID: 32929 RVA: 0x00258E8C File Offset: 0x0025708C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060080A2 RID: 32930 RVA: 0x00258E9C File Offset: 0x0025709C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x060080A3 RID: 32931 RVA: 0x00258EB4 File Offset: 0x002570B4
		public string AudioEvent
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

		// Token: 0x060080A4 RID: 32932 RVA: 0x00258EEC File Offset: 0x002570EC
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060080A5 RID: 32933 RVA: 0x00258EFC File Offset: 0x002570FC
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x060080A6 RID: 32934 RVA: 0x00258F14 File Offset: 0x00257114
		public string MontagePath
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

		// Token: 0x060080A7 RID: 32935 RVA: 0x00258F4C File Offset: 0x0025714C
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060080A8 RID: 32936 RVA: 0x00258F5C File Offset: 0x0025715C
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x060080A9 RID: 32937 RVA: 0x00258F74 File Offset: 0x00257174
		public int EntityId
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

		// Token: 0x04004DBD RID: 19901
		private Table __p;
	}
}
