using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001053 RID: 4179
	public struct RoleLevelConsume : IFlatbufferObject
	{
		// Token: 0x170032D1 RID: 13009
		// (get) Token: 0x0600C98C RID: 51596 RVA: 0x002FCC65 File Offset: 0x002FAE65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C98D RID: 51597 RVA: 0x002FCC72 File Offset: 0x002FAE72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C98E RID: 51598 RVA: 0x002FCC7C File Offset: 0x002FAE7C
		public static RoleLevelConsume GetRootAsRoleLevelConsume(ByteBuffer _bb)
		{
			return RoleLevelConsume.GetRootAsRoleLevelConsume(_bb, default(RoleLevelConsume));
		}

		// Token: 0x0600C98F RID: 51599 RVA: 0x002FCC98 File Offset: 0x002FAE98
		public static RoleLevelConsume GetRootAsRoleLevelConsume(ByteBuffer _bb, RoleLevelConsume obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C990 RID: 51600 RVA: 0x002FCCB5 File Offset: 0x002FAEB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C991 RID: 51601 RVA: 0x002FCCC4 File Offset: 0x002FAEC4
		public RoleLevelConsume __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032D2 RID: 13010
		// (get) Token: 0x0600C992 RID: 51602 RVA: 0x002FCCD4 File Offset: 0x002FAED4
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

		// Token: 0x170032D3 RID: 13011
		// (get) Token: 0x0600C993 RID: 51603 RVA: 0x002FCD10 File Offset: 0x002FAF10
		public int ConsumeGroupId
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

		// Token: 0x170032D4 RID: 13012
		// (get) Token: 0x0600C994 RID: 51604 RVA: 0x002FCD4C File Offset: 0x002FAF4C
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

		// Token: 0x170032D5 RID: 13013
		// (get) Token: 0x0600C995 RID: 51605 RVA: 0x002FCD88 File Offset: 0x002FAF88
		public int ExpCount
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

		// Token: 0x04005154 RID: 20820
		private Table __p;
	}
}
