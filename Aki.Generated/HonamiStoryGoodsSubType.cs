using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E1B RID: 3611
	public struct HonamiStoryGoodsSubType : IFlatbufferObject
	{
		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x0600859B RID: 34203 RVA: 0x00275115 File Offset: 0x00273315
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600859C RID: 34204 RVA: 0x00275122 File Offset: 0x00273322
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600859D RID: 34205 RVA: 0x0027512C File Offset: 0x0027332C
		public static HonamiStoryGoodsSubType GetRootAsHonamiStoryGoodsSubType(ByteBuffer _bb)
		{
			return HonamiStoryGoodsSubType.GetRootAsHonamiStoryGoodsSubType(_bb, default(HonamiStoryGoodsSubType));
		}

		// Token: 0x0600859E RID: 34206 RVA: 0x00275148 File Offset: 0x00273348
		public static HonamiStoryGoodsSubType GetRootAsHonamiStoryGoodsSubType(ByteBuffer _bb, HonamiStoryGoodsSubType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600859F RID: 34207 RVA: 0x00275165 File Offset: 0x00273365
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060085A0 RID: 34208 RVA: 0x00275174 File Offset: 0x00273374
		public HonamiStoryGoodsSubType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x060085A1 RID: 34209 RVA: 0x00275184 File Offset: 0x00273384
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

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x060085A2 RID: 34210 RVA: 0x002751C0 File Offset: 0x002733C0
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

		// Token: 0x060085A3 RID: 34211 RVA: 0x002751F7 File Offset: 0x002733F7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060085A4 RID: 34212 RVA: 0x00275206 File Offset: 0x00273406
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005395 RID: 21397
		private Table __p;
	}
}
