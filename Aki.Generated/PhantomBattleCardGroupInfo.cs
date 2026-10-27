using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC5 RID: 3781
	public struct PhantomBattleCardGroupInfo : IFlatbufferObject
	{
		// Token: 0x170025B9 RID: 9657
		// (get) Token: 0x0600A5C0 RID: 42432 RVA: 0x002ACCE0 File Offset: 0x002AAEE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A5C1 RID: 42433 RVA: 0x002ACCED File Offset: 0x002AAEED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A5C2 RID: 42434 RVA: 0x002ACCF4 File Offset: 0x002AAEF4
		public static PhantomBattleCardGroupInfo GetRootAsPhantomBattleCardGroupInfo(ByteBuffer _bb)
		{
			return PhantomBattleCardGroupInfo.GetRootAsPhantomBattleCardGroupInfo(_bb, default(PhantomBattleCardGroupInfo));
		}

		// Token: 0x0600A5C3 RID: 42435 RVA: 0x002ACD10 File Offset: 0x002AAF10
		public static PhantomBattleCardGroupInfo GetRootAsPhantomBattleCardGroupInfo(ByteBuffer _bb, PhantomBattleCardGroupInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A5C4 RID: 42436 RVA: 0x002ACD2D File Offset: 0x002AAF2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A5C5 RID: 42437 RVA: 0x002ACD3C File Offset: 0x002AAF3C
		public PhantomBattleCardGroupInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170025BA RID: 9658
		// (get) Token: 0x0600A5C6 RID: 42438 RVA: 0x002ACD4C File Offset: 0x002AAF4C
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

		// Token: 0x170025BB RID: 9659
		// (get) Token: 0x0600A5C7 RID: 42439 RVA: 0x002ACD88 File Offset: 0x002AAF88
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

		// Token: 0x0600A5C8 RID: 42440 RVA: 0x002ACDBF File Offset: 0x002AAFBF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A5C9 RID: 42441 RVA: 0x002ACDCE File Offset: 0x002AAFCE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170025BC RID: 9660
		// (get) Token: 0x0600A5CA RID: 42442 RVA: 0x002ACDE8 File Offset: 0x002AAFE8
		public bool CoreSlotLocked
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170025BD RID: 9661
		// (get) Token: 0x0600A5CB RID: 42443 RVA: 0x002ACE28 File Offset: 0x002AB028
		public int CoreCardCountLimit
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

		// Token: 0x170025BE RID: 9662
		// (get) Token: 0x0600A5CC RID: 42444 RVA: 0x002ACE68 File Offset: 0x002AB068
		public int FieldCardCountLimit
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025BF RID: 9663
		// (get) Token: 0x0600A5CD RID: 42445 RVA: 0x002ACEA8 File Offset: 0x002AB0A8
		public int ItemCardCountLimit
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025C0 RID: 9664
		// (get) Token: 0x0600A5CE RID: 42446 RVA: 0x002ACEE8 File Offset: 0x002AB0E8
		public int NormalCardCountLimit
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

		// Token: 0x170025C1 RID: 9665
		// (get) Token: 0x0600A5CF RID: 42447 RVA: 0x002ACF28 File Offset: 0x002AB128
		public int ElementCountLimit
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

		// Token: 0x04004F81 RID: 20353
		private Table __p;
	}
}
