using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001193 RID: 4499
	public struct WeaponExpItem : IFlatbufferObject
	{
		// Token: 0x17003DE0 RID: 15840
		// (get) Token: 0x0600E7CA RID: 59338 RVA: 0x003425B7 File Offset: 0x003407B7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E7CB RID: 59339 RVA: 0x003425C4 File Offset: 0x003407C4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E7CC RID: 59340 RVA: 0x003425CC File Offset: 0x003407CC
		public static WeaponExpItem GetRootAsWeaponExpItem(ByteBuffer _bb)
		{
			return WeaponExpItem.GetRootAsWeaponExpItem(_bb, default(WeaponExpItem));
		}

		// Token: 0x0600E7CD RID: 59341 RVA: 0x003425E8 File Offset: 0x003407E8
		public static WeaponExpItem GetRootAsWeaponExpItem(ByteBuffer _bb, WeaponExpItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E7CE RID: 59342 RVA: 0x00342605 File Offset: 0x00340805
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E7CF RID: 59343 RVA: 0x00342614 File Offset: 0x00340814
		public WeaponExpItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DE1 RID: 15841
		// (get) Token: 0x0600E7D0 RID: 59344 RVA: 0x00342624 File Offset: 0x00340824
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

		// Token: 0x17003DE2 RID: 15842
		// (get) Token: 0x0600E7D1 RID: 59345 RVA: 0x00342660 File Offset: 0x00340860
		public int Cost
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

		// Token: 0x17003DE3 RID: 15843
		// (get) Token: 0x0600E7D2 RID: 59346 RVA: 0x0034269C File Offset: 0x0034089C
		public int BasicExp
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

		// Token: 0x040052DE RID: 21214
		private Table __p;
	}
}
