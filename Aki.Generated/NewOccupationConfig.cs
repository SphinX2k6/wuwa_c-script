using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E85 RID: 3717
	public struct NewOccupationConfig : IFlatbufferObject
	{
		// Token: 0x1700230F RID: 8975
		// (get) Token: 0x06009E9B RID: 40603 RVA: 0x0029C905 File Offset: 0x0029AB05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E9C RID: 40604 RVA: 0x0029C912 File Offset: 0x0029AB12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E9D RID: 40605 RVA: 0x0029C91C File Offset: 0x0029AB1C
		public static NewOccupationConfig GetRootAsNewOccupationConfig(ByteBuffer _bb)
		{
			return NewOccupationConfig.GetRootAsNewOccupationConfig(_bb, default(NewOccupationConfig));
		}

		// Token: 0x06009E9E RID: 40606 RVA: 0x0029C938 File Offset: 0x0029AB38
		public static NewOccupationConfig GetRootAsNewOccupationConfig(ByteBuffer _bb, NewOccupationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E9F RID: 40607 RVA: 0x0029C955 File Offset: 0x0029AB55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009EA0 RID: 40608 RVA: 0x0029C964 File Offset: 0x0029AB64
		public NewOccupationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002310 RID: 8976
		// (get) Token: 0x06009EA1 RID: 40609 RVA: 0x0029C974 File Offset: 0x0029AB74
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009EA2 RID: 40610 RVA: 0x0029C9AB File Offset: 0x0029ABAB
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06009EA3 RID: 40611 RVA: 0x0029C9BA File Offset: 0x0029ABBA
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17002311 RID: 8977
		// (get) Token: 0x06009EA4 RID: 40612 RVA: 0x0029C9D4 File Offset: 0x0029ABD4
		public string OccupationType
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

		// Token: 0x06009EA5 RID: 40613 RVA: 0x0029CA0B File Offset: 0x0029AC0B
		public Span<byte> GetOccupationTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009EA6 RID: 40614 RVA: 0x0029CA1A File Offset: 0x0029AC1A
		public byte[] GetOccupationTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002312 RID: 8978
		// (get) Token: 0x06009EA7 RID: 40615 RVA: 0x0029CA34 File Offset: 0x0029AC34
		public string OccupationData
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

		// Token: 0x06009EA8 RID: 40616 RVA: 0x0029CA6B File Offset: 0x0029AC6B
		public Span<byte> GetOccupationDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009EA9 RID: 40617 RVA: 0x0029CA7A File Offset: 0x0029AC7A
		public byte[] GetOccupationDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002313 RID: 8979
		// (get) Token: 0x06009EAA RID: 40618 RVA: 0x0029CA94 File Offset: 0x0029AC94
		public string OccupationNameStringKey
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

		// Token: 0x06009EAB RID: 40619 RVA: 0x0029CACC File Offset: 0x0029ACCC
		public Span<byte> GetOccupationNameStringKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009EAC RID: 40620 RVA: 0x0029CADC File Offset: 0x0029ACDC
		public byte[] GetOccupationNameStringKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F33 RID: 20275
		private Table __p;
	}
}
