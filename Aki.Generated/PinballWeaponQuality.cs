using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F3F RID: 3903
	public struct PinballWeaponQuality : IFlatbufferObject
	{
		// Token: 0x17002A0A RID: 10762
		// (get) Token: 0x0600B0CC RID: 45260 RVA: 0x002C5F2F File Offset: 0x002C412F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B0CD RID: 45261 RVA: 0x002C5F3C File Offset: 0x002C413C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B0CE RID: 45262 RVA: 0x002C5F44 File Offset: 0x002C4144
		public static PinballWeaponQuality GetRootAsPinballWeaponQuality(ByteBuffer _bb)
		{
			return PinballWeaponQuality.GetRootAsPinballWeaponQuality(_bb, default(PinballWeaponQuality));
		}

		// Token: 0x0600B0CF RID: 45263 RVA: 0x002C5F60 File Offset: 0x002C4160
		public static PinballWeaponQuality GetRootAsPinballWeaponQuality(ByteBuffer _bb, PinballWeaponQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B0D0 RID: 45264 RVA: 0x002C5F7D File Offset: 0x002C417D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B0D1 RID: 45265 RVA: 0x002C5F8C File Offset: 0x002C418C
		public PinballWeaponQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A0B RID: 10763
		// (get) Token: 0x0600B0D2 RID: 45266 RVA: 0x002C5F9C File Offset: 0x002C419C
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

		// Token: 0x17002A0C RID: 10764
		// (get) Token: 0x0600B0D3 RID: 45267 RVA: 0x002C5FD8 File Offset: 0x002C41D8
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

		// Token: 0x0600B0D4 RID: 45268 RVA: 0x002C600F File Offset: 0x002C420F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B0D5 RID: 45269 RVA: 0x002C601E File Offset: 0x002C421E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A0D RID: 10765
		// (get) Token: 0x0600B0D6 RID: 45270 RVA: 0x002C6038 File Offset: 0x002C4238
		public string TexQuality
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B0D7 RID: 45271 RVA: 0x002C606F File Offset: 0x002C426F
		public Span<byte> GetTexQualityBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B0D8 RID: 45272 RVA: 0x002C607E File Offset: 0x002C427E
		public byte[] GetTexQualityArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A0E RID: 10766
		// (get) Token: 0x0600B0D9 RID: 45273 RVA: 0x002C6098 File Offset: 0x002C4298
		public string Color
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

		// Token: 0x0600B0DA RID: 45274 RVA: 0x002C60D0 File Offset: 0x002C42D0
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B0DB RID: 45275 RVA: 0x002C60E0 File Offset: 0x002C42E0
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005009 RID: 20489
		private Table __p;
	}
}
