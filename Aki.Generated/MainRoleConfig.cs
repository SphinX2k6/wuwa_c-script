using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE7 RID: 3559
	public struct MainRoleConfig : IFlatbufferObject
	{
		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x06009081 RID: 36993 RVA: 0x0027D1C5 File Offset: 0x0027B3C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009082 RID: 36994 RVA: 0x0027D1D2 File Offset: 0x0027B3D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009083 RID: 36995 RVA: 0x0027D1DC File Offset: 0x0027B3DC
		public static MainRoleConfig GetRootAsMainRoleConfig(ByteBuffer _bb)
		{
			return MainRoleConfig.GetRootAsMainRoleConfig(_bb, default(MainRoleConfig));
		}

		// Token: 0x06009084 RID: 36996 RVA: 0x0027D1F8 File Offset: 0x0027B3F8
		public static MainRoleConfig GetRootAsMainRoleConfig(ByteBuffer _bb, MainRoleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009085 RID: 36997 RVA: 0x0027D215 File Offset: 0x0027B415
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009086 RID: 36998 RVA: 0x0027D224 File Offset: 0x0027B424
		public MainRoleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x06009087 RID: 36999 RVA: 0x0027D234 File Offset: 0x0027B434
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

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x06009088 RID: 37000 RVA: 0x0027D270 File Offset: 0x0027B470
		public int Gender
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

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x06009089 RID: 37001 RVA: 0x0027D2AC File Offset: 0x0027B4AC
		public int UnlockCondition
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

		// Token: 0x04004E83 RID: 20099
		private Table __p;
	}
}
