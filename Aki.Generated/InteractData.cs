using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D79 RID: 3449
	public struct InteractData : IFlatbufferObject
	{
		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x060085FF RID: 34303 RVA: 0x00265231 File Offset: 0x00263431
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008600 RID: 34304 RVA: 0x0026523E File Offset: 0x0026343E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008601 RID: 34305 RVA: 0x00265248 File Offset: 0x00263448
		public static InteractData GetRootAsInteractData(ByteBuffer _bb)
		{
			return InteractData.GetRootAsInteractData(_bb, default(InteractData));
		}

		// Token: 0x06008602 RID: 34306 RVA: 0x00265264 File Offset: 0x00263464
		public static InteractData GetRootAsInteractData(ByteBuffer _bb, InteractData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008603 RID: 34307 RVA: 0x00265281 File Offset: 0x00263481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008604 RID: 34308 RVA: 0x00265290 File Offset: 0x00263490
		public InteractData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x06008605 RID: 34309 RVA: 0x002652A0 File Offset: 0x002634A0
		public string Guid
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

		// Token: 0x06008606 RID: 34310 RVA: 0x002652D7 File Offset: 0x002634D7
		public Span<byte> GetGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06008607 RID: 34311 RVA: 0x002652E6 File Offset: 0x002634E6
		public byte[] GetGuidArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x06008608 RID: 34312 RVA: 0x00265300 File Offset: 0x00263500
		public string Type
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

		// Token: 0x06008609 RID: 34313 RVA: 0x00265337 File Offset: 0x00263537
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600860A RID: 34314 RVA: 0x00265346 File Offset: 0x00263546
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x0600860B RID: 34315 RVA: 0x00265360 File Offset: 0x00263560
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

		// Token: 0x0600860C RID: 34316 RVA: 0x00265397 File Offset: 0x00263597
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600860D RID: 34317 RVA: 0x002653A6 File Offset: 0x002635A6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x0600860E RID: 34318 RVA: 0x002653C0 File Offset: 0x002635C0
		public string TidContent
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

		// Token: 0x0600860F RID: 34319 RVA: 0x002653F8 File Offset: 0x002635F8
		public Span<byte> GetTidContentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008610 RID: 34320 RVA: 0x00265408 File Offset: 0x00263608
		public byte[] GetTidContentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x06008611 RID: 34321 RVA: 0x00265420 File Offset: 0x00263620
		public string Condition
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

		// Token: 0x06008612 RID: 34322 RVA: 0x00265458 File Offset: 0x00263658
		public Span<byte> GetConditionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008613 RID: 34323 RVA: 0x00265468 File Offset: 0x00263668
		public byte[] GetConditionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x06008614 RID: 34324 RVA: 0x00265480 File Offset: 0x00263680
		public string UniquenessTest
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

		// Token: 0x06008615 RID: 34325 RVA: 0x002654B8 File Offset: 0x002636B8
		public Span<byte> GetUniquenessTestBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008616 RID: 34326 RVA: 0x002654C8 File Offset: 0x002636C8
		public byte[] GetUniquenessTestArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x06008617 RID: 34327 RVA: 0x002654E0 File Offset: 0x002636E0
		public string DoIntactType
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

		// Token: 0x06008618 RID: 34328 RVA: 0x00265518 File Offset: 0x00263718
		public Span<byte> GetDoIntactTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008619 RID: 34329 RVA: 0x00265528 File Offset: 0x00263728
		public byte[] GetDoIntactTypeArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x0600861A RID: 34330 RVA: 0x00265540 File Offset: 0x00263740
		public int Range
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x0600861B RID: 34331 RVA: 0x00265580 File Offset: 0x00263780
		public string Duration
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600861C RID: 34332 RVA: 0x002655B8 File Offset: 0x002637B8
		public Span<byte> GetDurationBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600861D RID: 34333 RVA: 0x002655C8 File Offset: 0x002637C8
		public byte[] GetDurationArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x0600861E RID: 34334 RVA: 0x002655E0 File Offset: 0x002637E0
		public string OptionLockTypeList
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600861F RID: 34335 RVA: 0x00265618 File Offset: 0x00263818
		public Span<byte> GetOptionLockTypeListBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008620 RID: 34336 RVA: 0x00265628 File Offset: 0x00263828
		public byte[] GetOptionLockTypeListArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x06008621 RID: 34337 RVA: 0x00265640 File Offset: 0x00263840
		public string LongPressInteractConfig
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008622 RID: 34338 RVA: 0x00265678 File Offset: 0x00263878
		public Span<byte> GetLongPressInteractConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06008623 RID: 34339 RVA: 0x00265688 File Offset: 0x00263888
		public byte[] GetLongPressInteractConfigArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E01 RID: 19969
		private Table __p;
	}
}
