using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012CC RID: 4812
	public struct WeaponLevel : IFlatbufferObject
	{
		// Token: 0x17004150 RID: 16720
		// (get) Token: 0x0600F556 RID: 62806 RVA: 0x0036D6C5 File Offset: 0x0036B8C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F557 RID: 62807 RVA: 0x0036D6D2 File Offset: 0x0036B8D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F558 RID: 62808 RVA: 0x0036D6DC File Offset: 0x0036B8DC
		public static WeaponLevel GetRootAsWeaponLevel(ByteBuffer _bb)
		{
			return WeaponLevel.GetRootAsWeaponLevel(_bb, default(WeaponLevel));
		}

		// Token: 0x0600F559 RID: 62809 RVA: 0x0036D6F8 File Offset: 0x0036B8F8
		public static WeaponLevel GetRootAsWeaponLevel(ByteBuffer _bb, WeaponLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F55A RID: 62810 RVA: 0x0036D715 File Offset: 0x0036B915
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F55B RID: 62811 RVA: 0x0036D724 File Offset: 0x0036B924
		public WeaponLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004151 RID: 16721
		// (get) Token: 0x0600F55C RID: 62812 RVA: 0x0036D734 File Offset: 0x0036B934
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

		// Token: 0x17004152 RID: 16722
		// (get) Token: 0x0600F55D RID: 62813 RVA: 0x0036D770 File Offset: 0x0036B970
		public int LevelId
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

		// Token: 0x17004153 RID: 16723
		// (get) Token: 0x0600F55E RID: 62814 RVA: 0x0036D7AC File Offset: 0x0036B9AC
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

		// Token: 0x17004154 RID: 16724
		// (get) Token: 0x0600F55F RID: 62815 RVA: 0x0036D7E8 File Offset: 0x0036B9E8
		public int Exp
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

		// Token: 0x04005924 RID: 22820
		private Table __p;
	}
}
