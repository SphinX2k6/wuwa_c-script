using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ECC RID: 3788
	public struct MainRoleConfig : IFlatbufferObject
	{
		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x0600969D RID: 38557 RVA: 0x0029B445 File Offset: 0x00299645
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600969E RID: 38558 RVA: 0x0029B452 File Offset: 0x00299652
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600969F RID: 38559 RVA: 0x0029B45C File Offset: 0x0029965C
		public static MainRoleConfig GetRootAsMainRoleConfig(ByteBuffer _bb)
		{
			return MainRoleConfig.GetRootAsMainRoleConfig(_bb, default(MainRoleConfig));
		}

		// Token: 0x060096A0 RID: 38560 RVA: 0x0029B478 File Offset: 0x00299678
		public static MainRoleConfig GetRootAsMainRoleConfig(ByteBuffer _bb, MainRoleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060096A1 RID: 38561 RVA: 0x0029B495 File Offset: 0x00299695
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060096A2 RID: 38562 RVA: 0x0029B4A4 File Offset: 0x002996A4
		public MainRoleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x060096A3 RID: 38563 RVA: 0x0029B4B4 File Offset: 0x002996B4
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

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x060096A4 RID: 38564 RVA: 0x0029B4F0 File Offset: 0x002996F0
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

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x060096A5 RID: 38565 RVA: 0x0029B52C File Offset: 0x0029972C
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

		// Token: 0x04005468 RID: 21608
		private Table __p;
	}
}
