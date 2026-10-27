using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ECF RID: 3791
	public struct PhantomBattleEntry : IFlatbufferObject
	{
		// Token: 0x17002630 RID: 9776
		// (get) Token: 0x0600A6F5 RID: 42741 RVA: 0x002AFA01 File Offset: 0x002ADC01
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A6F6 RID: 42742 RVA: 0x002AFA0E File Offset: 0x002ADC0E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A6F7 RID: 42743 RVA: 0x002AFA18 File Offset: 0x002ADC18
		public static PhantomBattleEntry GetRootAsPhantomBattleEntry(ByteBuffer _bb)
		{
			return PhantomBattleEntry.GetRootAsPhantomBattleEntry(_bb, default(PhantomBattleEntry));
		}

		// Token: 0x0600A6F8 RID: 42744 RVA: 0x002AFA34 File Offset: 0x002ADC34
		public static PhantomBattleEntry GetRootAsPhantomBattleEntry(ByteBuffer _bb, PhantomBattleEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A6F9 RID: 42745 RVA: 0x002AFA51 File Offset: 0x002ADC51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A6FA RID: 42746 RVA: 0x002AFA60 File Offset: 0x002ADC60
		public PhantomBattleEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002631 RID: 9777
		// (get) Token: 0x0600A6FB RID: 42747 RVA: 0x002AFA70 File Offset: 0x002ADC70
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

		// Token: 0x17002632 RID: 9778
		// (get) Token: 0x0600A6FC RID: 42748 RVA: 0x002AFAAC File Offset: 0x002ADCAC
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

		// Token: 0x0600A6FD RID: 42749 RVA: 0x002AFAE3 File Offset: 0x002ADCE3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A6FE RID: 42750 RVA: 0x002AFAF2 File Offset: 0x002ADCF2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002633 RID: 9779
		// (get) Token: 0x0600A6FF RID: 42751 RVA: 0x002AFB0C File Offset: 0x002ADD0C
		public string Description
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

		// Token: 0x0600A700 RID: 42752 RVA: 0x002AFB43 File Offset: 0x002ADD43
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A701 RID: 42753 RVA: 0x002AFB52 File Offset: 0x002ADD52
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F8D RID: 20365
		private Table __p;
	}
}
