using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B4B RID: 2891
	public struct BoxState : IFlatbufferObject
	{
		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06004F6A RID: 20330 RVA: 0x001E8290 File Offset: 0x001E6490
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F6B RID: 20331 RVA: 0x001E829D File Offset: 0x001E649D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F6C RID: 20332 RVA: 0x001E82A4 File Offset: 0x001E64A4
		public static BoxState GetRootAsBoxState(ByteBuffer _bb)
		{
			return BoxState.GetRootAsBoxState(_bb, default(BoxState));
		}

		// Token: 0x06004F6D RID: 20333 RVA: 0x001E82C0 File Offset: 0x001E64C0
		public static BoxState GetRootAsBoxState(ByteBuffer _bb, BoxState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x001E82DD File Offset: 0x001E64DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x001E82EC File Offset: 0x001E64EC
		public BoxState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06004F70 RID: 20336 RVA: 0x001E82FC File Offset: 0x001E64FC
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

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06004F71 RID: 20337 RVA: 0x001E8338 File Offset: 0x001E6538
		public int TagId
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

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06004F72 RID: 20338 RVA: 0x001E8374 File Offset: 0x001E6574
		public string Name
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

		// Token: 0x06004F73 RID: 20339 RVA: 0x001E83AB File Offset: 0x001E65AB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004F74 RID: 20340 RVA: 0x001E83BA File Offset: 0x001E65BA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06004F75 RID: 20341 RVA: 0x001E83D4 File Offset: 0x001E65D4
		public string Effect
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

		// Token: 0x06004F76 RID: 20342 RVA: 0x001E840C File Offset: 0x001E660C
		public Span<byte> GetEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004F77 RID: 20343 RVA: 0x001E841C File Offset: 0x001E661C
		public byte[] GetEffectArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06004F78 RID: 20344 RVA: 0x001E8434 File Offset: 0x001E6634
		public bool IsInteraction
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06004F79 RID: 20345 RVA: 0x001E8474 File Offset: 0x001E6674
		public float Interval
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06004F7A RID: 20346 RVA: 0x001E84B8 File Offset: 0x001E66B8
		public int NextState
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004B46 RID: 19270
		private Table __p;
	}
}
