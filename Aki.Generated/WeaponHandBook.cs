using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001194 RID: 4500
	public struct WeaponHandBook : IFlatbufferObject
	{
		// Token: 0x17003DE4 RID: 15844
		// (get) Token: 0x0600E7D3 RID: 59347 RVA: 0x003426D8 File Offset: 0x003408D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E7D4 RID: 59348 RVA: 0x003426E5 File Offset: 0x003408E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E7D5 RID: 59349 RVA: 0x003426EC File Offset: 0x003408EC
		public static WeaponHandBook GetRootAsWeaponHandBook(ByteBuffer _bb)
		{
			return WeaponHandBook.GetRootAsWeaponHandBook(_bb, default(WeaponHandBook));
		}

		// Token: 0x0600E7D6 RID: 59350 RVA: 0x00342708 File Offset: 0x00340908
		public static WeaponHandBook GetRootAsWeaponHandBook(ByteBuffer _bb, WeaponHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E7D7 RID: 59351 RVA: 0x00342725 File Offset: 0x00340925
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E7D8 RID: 59352 RVA: 0x00342734 File Offset: 0x00340934
		public WeaponHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DE5 RID: 15845
		// (get) Token: 0x0600E7D9 RID: 59353 RVA: 0x00342744 File Offset: 0x00340944
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

		// Token: 0x17003DE6 RID: 15846
		// (get) Token: 0x0600E7DA RID: 59354 RVA: 0x00342780 File Offset: 0x00340980
		public int Level
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

		// Token: 0x17003DE7 RID: 15847
		// (get) Token: 0x0600E7DB RID: 59355 RVA: 0x003427BC File Offset: 0x003409BC
		public int Breach
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

		// Token: 0x17003DE8 RID: 15848
		// (get) Token: 0x0600E7DC RID: 59356 RVA: 0x003427F8 File Offset: 0x003409F8
		public int Resonance
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

		// Token: 0x040052DF RID: 21215
		private Table __p;
	}
}
