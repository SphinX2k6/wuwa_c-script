using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200110E RID: 4366
	public struct SurvivorsWeaponLv : IFlatbufferObject
	{
		// Token: 0x17003975 RID: 14709
		// (get) Token: 0x0600DC57 RID: 56407 RVA: 0x00328470 File Offset: 0x00326670
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DC58 RID: 56408 RVA: 0x0032847D File Offset: 0x0032667D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DC59 RID: 56409 RVA: 0x00328484 File Offset: 0x00326684
		public static SurvivorsWeaponLv GetRootAsSurvivorsWeaponLv(ByteBuffer _bb)
		{
			return SurvivorsWeaponLv.GetRootAsSurvivorsWeaponLv(_bb, default(SurvivorsWeaponLv));
		}

		// Token: 0x0600DC5A RID: 56410 RVA: 0x003284A0 File Offset: 0x003266A0
		public static SurvivorsWeaponLv GetRootAsSurvivorsWeaponLv(ByteBuffer _bb, SurvivorsWeaponLv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DC5B RID: 56411 RVA: 0x003284BD File Offset: 0x003266BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DC5C RID: 56412 RVA: 0x003284CC File Offset: 0x003266CC
		public SurvivorsWeaponLv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003976 RID: 14710
		// (get) Token: 0x0600DC5D RID: 56413 RVA: 0x003284DC File Offset: 0x003266DC
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

		// Token: 0x17003977 RID: 14711
		// (get) Token: 0x0600DC5E RID: 56414 RVA: 0x00328518 File Offset: 0x00326718
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

		// Token: 0x17003978 RID: 14712
		// (get) Token: 0x0600DC5F RID: 56415 RVA: 0x00328554 File Offset: 0x00326754
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

		// Token: 0x17003979 RID: 14713
		// (get) Token: 0x0600DC60 RID: 56416 RVA: 0x00328590 File Offset: 0x00326790
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

		// Token: 0x1700397A RID: 14714
		// (get) Token: 0x0600DC61 RID: 56417 RVA: 0x003285D0 File Offset: 0x003267D0
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

		// Token: 0x1700397B RID: 14715
		// (get) Token: 0x0600DC62 RID: 56418 RVA: 0x00328610 File Offset: 0x00326810
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

		// Token: 0x0600DC63 RID: 56419 RVA: 0x00328648 File Offset: 0x00326848
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600DC64 RID: 56420 RVA: 0x00328658 File Offset: 0x00326858
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700397C RID: 14716
		// (get) Token: 0x0600DC65 RID: 56421 RVA: 0x00328670 File Offset: 0x00326870
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

		// Token: 0x1700397D RID: 14717
		// (get) Token: 0x0600DC66 RID: 56422 RVA: 0x003286B0 File Offset: 0x003268B0
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

		// Token: 0x1700397E RID: 14718
		// (get) Token: 0x0600DC67 RID: 56423 RVA: 0x003286F0 File Offset: 0x003268F0
		public bool IsPercent
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400524B RID: 21067
		private Table __p;
	}
}
