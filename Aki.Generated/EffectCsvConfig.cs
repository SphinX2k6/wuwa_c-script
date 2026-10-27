using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C21 RID: 3105
	public struct EffectCsvConfig : IFlatbufferObject
	{
		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06006794 RID: 26516 RVA: 0x00220129 File Offset: 0x0021E329
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006795 RID: 26517 RVA: 0x00220136 File Offset: 0x0021E336
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006796 RID: 26518 RVA: 0x00220140 File Offset: 0x0021E340
		public static EffectCsvConfig GetRootAsEffectCsvConfig(ByteBuffer _bb)
		{
			return EffectCsvConfig.GetRootAsEffectCsvConfig(_bb, default(EffectCsvConfig));
		}

		// Token: 0x06006797 RID: 26519 RVA: 0x0022015C File Offset: 0x0021E35C
		public static EffectCsvConfig GetRootAsEffectCsvConfig(ByteBuffer _bb, EffectCsvConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006798 RID: 26520 RVA: 0x00220179 File Offset: 0x0021E379
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006799 RID: 26521 RVA: 0x00220188 File Offset: 0x0021E388
		public EffectCsvConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x0600679A RID: 26522 RVA: 0x00220198 File Offset: 0x0021E398
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

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x0600679B RID: 26523 RVA: 0x002201D4 File Offset: 0x0021E3D4
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

		// Token: 0x0600679C RID: 26524 RVA: 0x0022020B File Offset: 0x0021E40B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600679D RID: 26525 RVA: 0x0022021A File Offset: 0x0021E41A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x0600679E RID: 26526 RVA: 0x00220234 File Offset: 0x0021E434
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

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x0600679F RID: 26527 RVA: 0x00220270 File Offset: 0x0021E470
		public string Data
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

		// Token: 0x060067A0 RID: 26528 RVA: 0x002202A8 File Offset: 0x0021E4A8
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060067A1 RID: 26529 RVA: 0x002202B8 File Offset: 0x0021E4B8
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C61 RID: 19553
		private Table __p;
	}
}
