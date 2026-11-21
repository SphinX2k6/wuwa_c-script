using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200100A RID: 4106
	public struct PinballClassConfig : IFlatbufferObject
	{
		// Token: 0x17002978 RID: 10616
		// (get) Token: 0x0600B483 RID: 46211 RVA: 0x002DD2ED File Offset: 0x002DB4ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B484 RID: 46212 RVA: 0x002DD2FA File Offset: 0x002DB4FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B485 RID: 46213 RVA: 0x002DD304 File Offset: 0x002DB504
		public static PinballClassConfig GetRootAsPinballClassConfig(ByteBuffer _bb)
		{
			return PinballClassConfig.GetRootAsPinballClassConfig(_bb, default(PinballClassConfig));
		}

		// Token: 0x0600B486 RID: 46214 RVA: 0x002DD320 File Offset: 0x002DB520
		public static PinballClassConfig GetRootAsPinballClassConfig(ByteBuffer _bb, PinballClassConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B487 RID: 46215 RVA: 0x002DD33D File Offset: 0x002DB53D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B488 RID: 46216 RVA: 0x002DD34C File Offset: 0x002DB54C
		public PinballClassConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002979 RID: 10617
		// (get) Token: 0x0600B489 RID: 46217 RVA: 0x002DD35C File Offset: 0x002DB55C
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

		// Token: 0x1700297A RID: 10618
		// (get) Token: 0x0600B48A RID: 46218 RVA: 0x002DD398 File Offset: 0x002DB598
		public string PinballClassName
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

		// Token: 0x0600B48B RID: 46219 RVA: 0x002DD3CF File Offset: 0x002DB5CF
		public Span<byte> GetPinballClassNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B48C RID: 46220 RVA: 0x002DD3DE File Offset: 0x002DB5DE
		public byte[] GetPinballClassNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700297B RID: 10619
		// (get) Token: 0x0600B48D RID: 46221 RVA: 0x002DD3F8 File Offset: 0x002DB5F8
		public string Icon
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

		// Token: 0x0600B48E RID: 46222 RVA: 0x002DD42F File Offset: 0x002DB62F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B48F RID: 46223 RVA: 0x002DD43E File Offset: 0x002DB63E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700297C RID: 10620
		// (get) Token: 0x0600B490 RID: 46224 RVA: 0x002DD458 File Offset: 0x002DB658
		public string BigIcon
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

		// Token: 0x0600B491 RID: 46225 RVA: 0x002DD490 File Offset: 0x002DB690
		public Span<byte> GetBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B492 RID: 46226 RVA: 0x002DD4A0 File Offset: 0x002DB6A0
		public byte[] GetBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700297D RID: 10621
		// (get) Token: 0x0600B493 RID: 46227 RVA: 0x002DD4B8 File Offset: 0x002DB6B8
		public string HoverBigIcon
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

		// Token: 0x0600B494 RID: 46228 RVA: 0x002DD4F0 File Offset: 0x002DB6F0
		public Span<byte> GetHoverBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B495 RID: 46229 RVA: 0x002DD500 File Offset: 0x002DB700
		public byte[] GetHoverBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700297E RID: 10622
		// (get) Token: 0x0600B496 RID: 46230 RVA: 0x002DD518 File Offset: 0x002DB718
		public string BgColor
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

		// Token: 0x0600B497 RID: 46231 RVA: 0x002DD550 File Offset: 0x002DB750
		public Span<byte> GetBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B498 RID: 46232 RVA: 0x002DD560 File Offset: 0x002DB760
		public byte[] GetBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040055D3 RID: 21971
		private Table __p;
	}
}
