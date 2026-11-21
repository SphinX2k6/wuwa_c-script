using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001244 RID: 4676
	public struct SurvivorsWeaponLv : IFlatbufferObject
	{
		// Token: 0x17003CCB RID: 15563
		// (get) Token: 0x0600E9A2 RID: 59810 RVA: 0x00353600 File Offset: 0x00351800
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E9A3 RID: 59811 RVA: 0x0035360D File Offset: 0x0035180D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E9A4 RID: 59812 RVA: 0x00353614 File Offset: 0x00351814
		public static SurvivorsWeaponLv GetRootAsSurvivorsWeaponLv(ByteBuffer _bb)
		{
			return SurvivorsWeaponLv.GetRootAsSurvivorsWeaponLv(_bb, default(SurvivorsWeaponLv));
		}

		// Token: 0x0600E9A5 RID: 59813 RVA: 0x00353630 File Offset: 0x00351830
		public static SurvivorsWeaponLv GetRootAsSurvivorsWeaponLv(ByteBuffer _bb, SurvivorsWeaponLv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E9A6 RID: 59814 RVA: 0x0035364D File Offset: 0x0035184D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E9A7 RID: 59815 RVA: 0x0035365C File Offset: 0x0035185C
		public SurvivorsWeaponLv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CCC RID: 15564
		// (get) Token: 0x0600E9A8 RID: 59816 RVA: 0x0035366C File Offset: 0x0035186C
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

		// Token: 0x17003CCD RID: 15565
		// (get) Token: 0x0600E9A9 RID: 59817 RVA: 0x003536A8 File Offset: 0x003518A8
		public int WeaponId
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

		// Token: 0x17003CCE RID: 15566
		// (get) Token: 0x0600E9AA RID: 59818 RVA: 0x003536E4 File Offset: 0x003518E4
		public int Level
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

		// Token: 0x17003CCF RID: 15567
		// (get) Token: 0x0600E9AB RID: 59819 RVA: 0x00353720 File Offset: 0x00351920
		public int Effect
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

		// Token: 0x17003CD0 RID: 15568
		// (get) Token: 0x0600E9AC RID: 59820 RVA: 0x00353760 File Offset: 0x00351960
		public int Quality
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

		// Token: 0x17003CD1 RID: 15569
		// (get) Token: 0x0600E9AD RID: 59821 RVA: 0x003537A0 File Offset: 0x003519A0
		public string Describe
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

		// Token: 0x0600E9AE RID: 59822 RVA: 0x003537D8 File Offset: 0x003519D8
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E9AF RID: 59823 RVA: 0x003537E8 File Offset: 0x003519E8
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CD2 RID: 15570
		// (get) Token: 0x0600E9B0 RID: 59824 RVA: 0x00353800 File Offset: 0x00351A00
		public int PropertyId
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

		// Token: 0x17003CD3 RID: 15571
		// (get) Token: 0x0600E9B1 RID: 59825 RVA: 0x00353840 File Offset: 0x00351A40
		public int PropertyValue
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

		// Token: 0x17003CD4 RID: 15572
		// (get) Token: 0x0600E9B2 RID: 59826 RVA: 0x00353880 File Offset: 0x00351A80
		public bool IsPercent
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400588E RID: 22670
		private Table __p;
	}
}
